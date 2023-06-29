from typing import Awaitable
from django.contrib.auth import login, logout, authenticate
from django.contrib.auth.forms import UsernameField
from django.contrib.auth.models import User
from django.shortcuts import redirect, render
from django.views.decorators.csrf import csrf_exempt
from django.urls import reverse_lazy
from .models import *
from .forms import *
from transbank.webpay.webpay_plus.transaction import Transaction, WebpayOptions
import random
from django.db.models import Max
from datetime import datetime
from django.db import connection
import requests
from django.shortcuts import get_object_or_404
from django.db.models import Count


def tienda(request):
    # Obtiene todos los productos de la base de datos
    lista_productos = Producto.objects.all()
    
    # Crea un contexto con la lista de productos
    contexto = {'list': lista_productos}
    
    # Devuelve una respuesta renderizada utilizando la plantilla "core/tienda.html" y el contexto
    return render(request, "core/tienda.html", contexto)




def perfil_usuario(request):
    data = {"mesg": "", "form": PerfilUsuarioForm}

    if request.method == 'POST':
        form = PerfilUsuarioForm(request.POST)
        if form.is_valid():
            user = request.user
            user.first_name = request.POST.get("first_name")
            user.last_name = request.POST.get("last_name")
            user.email = request.POST.get("email")
            user.save()
            perfil = PerfilUsuario.objects.get(user=user)
            perfil.rut = request.POST.get("rut")
            perfil.tipousu = request.POST.get("tipousu")
            perfil.dirusu = request.POST.get("dirusu")
            perfil.save()
            data["mesg"] = "¡Sus datos fueron actualizados correctamente!"

    perfil = PerfilUsuario.objects.get(user=request.user)
    form = PerfilUsuarioForm()
    form.fields['first_name'].initial = request.user.first_name
    form.fields['last_name'].initial = request.user.last_name
    form.fields['email'].initial = request.user.email
    form.fields['rut'].initial = perfil.rut
    form.fields['tipousu'].initial = perfil.tipousu
    form.fields['dirusu'].initial = perfil.dirusu
    data["form"] = form
    return render(request, "core/perfil_usuario.html", data)

def iniciar_sesion(request):
    # Se define un diccionario de datos con claves iniciales y una instancia del formulario IniciarSesionForm
    data = {"mesg": "", "form": IniciarSesionForm()}

    # Verifica si el método de la solicitud es POST
    if request.method == "POST":
        # Crea una instancia del formulario IniciarSesionForm con los datos de la solicitud POST
        form = IniciarSesionForm(request.POST)
        
        # Verifica si el formulario es válido
        if form.is_valid:
            # Obtiene el nombre de usuario y la contraseña de la solicitud POST
            username = request.POST.get("username")
            password = request.POST.get("password")
            
            # Autentica el usuario con el nombre de usuario y la contraseña proporcionados
            user = authenticate(username=username, password=password)
            
            # Verifica si el usuario es válido (no es None)
            if user is not None:
                # Verifica si el usuario está activo
                if user.is_active:
                    # Inicia sesión almacena la información de la sesión en la solicitud actual
                    login(request, user)
                    
                    # Redirige al usuario a la vista "tienda"
                    return redirect(tienda)
                else:
                    # Actualiza el mensaje de error en el diccionario de datos si la cuenta no está activa
                    data["mesg"] = "¡La cuenta o la contraseña no son correctas!"
            else:
                # Actualiza el mensaje de error en el diccionario de datos si la autenticación falla
                data["mesg"] = "¡La cuenta o la contraseña no son correctas!"

    # Devuelve una respuesta renderizada utilizando la plantilla "core/iniciar_sesion.html" y los datos
    return render(request, "core/iniciar_sesion.html", data)


def cerrar_sesion(request):
    logout(request)
    return redirect(tienda)



@csrf_exempt
def ficha(request, id):
    data = {"mesg": "", "aire": None}
    if request.method == "POST":
        if request.user.is_authenticated:
            return redirect(iniciar_pago, id)
        else:
            data["mesg"] = "¡Para poder comprar debe iniciar sesión como cliente!"

    aire = Producto.objects.get(idprod=id)

    # Hacer una solicitud a la API para obtener la tasa de cambio de CLP a USD
    api_url = "https://api.exchangerate-api.com/v4/latest/CLP"
    response = requests.get(api_url)
    
    if response.status_code == 200:
        exchange_data = response.json()
        exchange_rate = exchange_data["rates"]["USD"]
    else:
        # Si no se puede obtener la tasa de cambio de la API, establecer un valor predeterminado
        exchange_rate = 1.0
    
    # Calcular el precio en USD
    precio_usd = aire.precio * exchange_rate
    
    data["aire"] = aire
    data["precio_usd"] = precio_usd
    
    return render(request, "core/ficha.html", data)


#https://www.transbankdevelopers.cl/documentacion/como_empezar#como-empezar
#https://www.transbankdevelopers.cl/documentacion/como_empezar#codigos-de-comercio
#https://www.transbankdevelopers.cl/referencia/webpay

# Tipo de tarjeta   Detalle                        Resultado
#----------------   -----------------------------  ------------------------------
# VISA              4051885600446623
#                   CVV 123
#                   cualquier fecha de expiración  Genera transacciones aprobadas.
# AMEX              3700 0000 0002 032
#                   CVV 1234
#                   cualquier fecha de expiración  Genera transacciones aprobadas.
# MASTERCARD        5186 0595 5959 0568
#                   CVV 123
#                   cualquier fecha de expiración  Genera transacciones rechazadas.
# Redcompra         4051 8842 3993 7763            Genera transacciones aprobadas (para operaciones que permiten débito Redcompra y prepago)
# Redcompra         4511 3466 6003 7060            Genera transacciones aprobadas (para operaciones que permiten débito Redcompra y prepago)
# Redcompra         5186 0085 4123 3829            Genera transacciones rechazadas (para operaciones que permiten débito Redcompra y prepago)


@csrf_exempt
def iniciar_pago(request, id):

    # Esta es la implementacion de la VISTA iniciar_pago, que tiene la responsabilidad
    # de iniciar el pago, por medio de WebPay. Lo primero que hace es seleccionar un 
    # número de orden de compra, para poder así, identificar a la propia compra.
    # Como esta tienda no maneja, en realidad no tiene el concepto de "orden de compra"
    # pero se indica igual
    print("Webpay Plus Transaction.create")
    buy_order = str(random.randrange(1000000, 99999999))
    session_id = request.user.username
    amount = Producto.objects.get(idprod=id).precio
    return_url = f'http://127.0.0.1:8000/pago_exitoso/{id}'

    # response = Transaction.create(buy_order, session_id, amount, return_url)
    commercecode = "597055555532"
    apikey = "579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C"

    tx = Transaction(options=WebpayOptions(commerce_code=commercecode, api_key=apikey, integration_type="TEST"))
    response = tx.create(buy_order, session_id, amount, return_url)
    print(response['token'])

    perfil = PerfilUsuario.objects.get(user=request.user)
    form = PerfilUsuarioForm()

    context = {
        "buy_order": buy_order,
        "session_id": session_id,
        "amount": amount,
        "return_url": return_url,
        "response": response,
        "token_ws": response['token'],
        "url_tbk": response['url'],
        "first_name": request.user.first_name,
        "last_name": request.user.last_name,
        "email": request.user.email,
        "rut": perfil.rut,
        "direccion": perfil.dirusu,
    }

    return render(request, "core/iniciar_pago.html", context)


@csrf_exempt
def pago_exitoso(request,id):
    if request.method == "GET":
        token = request.GET.get("token_ws")
        print("commit for token_ws: {}".format(token))
        commercecode = "597055555532"
        apikey = "579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C"
        tx = Transaction(options=WebpayOptions(commerce_code=commercecode, api_key=apikey, integration_type="TEST"))
        response = tx.commit(token=token)
        print("response: {}".format(response))

        user = User.objects.get(username=response['session_id'])
        perfil = PerfilUsuario.objects.get(user=user)
        form = PerfilUsuarioForm()

        context = {
            "buy_order": response['buy_order'],
            "session_id": response['session_id'],
            "amount": response['amount'],
            "response": response,
            "token_ws": token,
            "first_name": user.first_name,
            "last_name": user.last_name,
            "email": user.email,
            "rut": perfil.rut,
            "direccion": perfil.dirusu,
            "response_code": response['response_code']
        }
        producto = Producto.objects.get(idprod=id)
        resultado = Factura.objects.aggregate(max_id=Max('nrofac'))
        id_mas_alta = resultado['max_id']
        precio = producto.precio
        nombre = producto.nomprod
        rut = PerfilUsuario.objects.get(user_id=request.user.id).rut
        resultado2 = GuiaDespacho.objects.aggregate(max_id=Max('nrogd'))
        id_mas_alta2 = resultado2['max_id']
        print(rut)
        fecha_actual = datetime.now().strftime('%Y-%m-%d')
        if response['response_code'] == 0:
            Factura.objects.update_or_create(nrofac=id_mas_alta+1, fechafac=fecha_actual, descfac=nombre, idprod = producto, monto = precio, rutcli = perfil)
            factura = Factura.objects.get(nrofac=id_mas_alta+1)
            GuiaDespacho.objects.update_or_create(nrogd=id_mas_alta2+1, estadogd="EnBodega", idprod = producto, nrofac = factura)
        return render(request, "core/pago_exitoso.html", context)
    else:
        return redirect(tienda)


def registrar_usuario(request):
    if request.method == 'POST':
        form = RegistrarUsuarioForm(request.POST)
        if form.is_valid():
            user = form.save()
            rut = request.POST.get("rut")
            tipousu = request.POST.get("tipousu")
            dirusu = request.POST.get("dirusu")
            PerfilUsuario.objects.update_or_create(user=user, rut=rut, tipousu=tipousu, dirusu=dirusu)
            return redirect(iniciar_sesion)
    form = RegistrarUsuarioForm()
    return render(request, "core/registrar_usuario.html", context={'form': form})

def mis_compras(request):
    rut = PerfilUsuario.objects.get(user_id=request.user.id).rut
    list = Factura.objects.filter(rutcli=rut)
    facturas = Factura.objects.filter(rutcli=rut)
    guias_despacho = GuiaDespacho.objects.filter(nrofac__in=facturas)
    context = {'fac' : list, 'gi' : guias_despacho}
    return render(request, "core/mis_compras.html", context)

def detalle_factura(request,id):
    factura = get_object_or_404(Factura, nrofac=id)
    guia_despacho = GuiaDespacho.objects.filter(nrofac=factura)
    context = {'factura': factura, 'guia': guia_despacho}
    return render(request, "core/detalle_factura.html",context)


@csrf_exempt
def administrar_productos(request, action, id):
    if not (request.user.is_authenticated and request.user.is_staff):
        return redirect(tienda)

    data = {"mesg": "", "form": ProductoForm, "action": action, "id": id, "formsesion": IniciarSesionForm}

    if action == 'ins':
        if request.method == "POST":
            form = ProductoForm(request.POST, request.FILES)
            if form.is_valid:
                try:
                    form.save()
                    data["mesg"] = "¡El producto fue creado correctamente!"
                except:
                    data["mesg"] = "¡No se puede crear dos vehículos con el mismo ID!"

    elif action == 'upd':
        objeto = Producto.objects.get(idprod=id)
        if request.method == "POST":
            form = ProductoForm(data=request.POST, files=request.FILES, instance=objeto)
            if form.is_valid:
                form.save()
                data["mesg"] = "¡El producto fue actualizado correctamente!"
        data["form"] = ProductoForm(instance=objeto)

    elif action == 'del':
        try:
            Producto.objects.get(idprod=id).delete()
            data["mesg"] = "¡El producto fue eliminado correctamente!"
            return redirect(administrar_productos, action='ins', id = '-1')
        except:
            data["mesg"] = "¡El producto ya estaba eliminado!"

    data["list"] = Producto.objects.all().order_by('idprod')
    return render(request, "core/administrar_productos.html", data)

def solicitud_form(request,id):
    fecha_actual = datetime.now().strftime('%Y-%m-%d')
    tecnico_menos_solicitudes = PerfilUsuario.objects.filter(tipousu='Técnico').annotate(num_solicitudes=Count('solicitudservicio')).order_by('num_solicitudes').first()
    factura = Factura.objects.get(nrofac=id)
    print(tecnico_menos_solicitudes)
    perfil = PerfilUsuario.objects.get(user=request.user)
    resultado = SolicitudServicio.objects.aggregate(max_id=Max('nrosol'))
    id_mas_alta = resultado['max_id']
    if request.method == 'POST':
        form = Solicitud(request.POST)
        if form.is_valid():
            tipo = request.POST.get("tipo")
            desc = request.POST.get("desc")
            fecha = request.POST.get("fecha")
            SolicitudServicio.objects.update_or_create( nrofac=factura, estadosol="Pendiente", descsol = desc, fechavisita = fecha, tiposol = tipo,nrosol = id_mas_alta+1,ruttec = tecnico_menos_solicitudes)
            form = Solicitud()
            return render(request, 'core/crear_solicitud.html', {'form': form})
    else:
        form = Solicitud()

    return render(request, 'core/crear_solicitud.html', {'form': form})


def mis_solicitudes(request):
    solicitudes = SolicitudServicio.objects.filter(nrofac__rutcli__user=request.user)
    nombre_cliente = request.user.first_name
    apellido_cliente = request.user.last_name
    context = {'soli': solicitudes, 'nombre_cliente' : nombre_cliente,'apellido_cliente':apellido_cliente}
    return render(request, 'core/mis_solicitudes.html', context)

def solicitudes_administrador(request):
    if request.method == 'POST':
        form = Solicitud_estado(request.POST)
        if form.is_valid():
            id = request.POST.get("nrosol")
            opcion = request.POST.get("tipo")
            print(opcion)
            solicitud = SolicitudServicio.objects.get(nrosol=id)
            solicitud.estadosol = opcion
            solicitud.save()
            return redirect(solicitudes_administrador)
    form = Solicitud_estado()
    permiso = "Cliente"
    if request.user.is_authenticated:
        user = User.objects.get(username=request.user.username)
        perfil = PerfilUsuario.objects.get(user=user)
        permiso = perfil.tipousu
    if permiso == "Administrador" or permiso=="Superusuario":
        solicitudes = SolicitudServicio.objects.all()
    elif permiso == "Técnico":
        solicitudes = SolicitudServicio.objects.filter(ruttec=perfil)
    context = {'soli': solicitudes,'form' : form }
    return render(request, 'core/admin_solicitudes.html', context)

def eliminar_solicitudes(request,id):
    modelo = get_object_or_404(SolicitudServicio, nrosol=id)
    modelo.delete()
    return redirect(solicitudes_administrador)