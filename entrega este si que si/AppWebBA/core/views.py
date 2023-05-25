from typing import Awaitable
from django.contrib.auth import login, logout, authenticate
from django.contrib.auth.forms import UsernameField
from django.contrib.auth.models import User
from django.shortcuts import redirect, render
from django.views.decorators.csrf import csrf_exempt
from django.urls import reverse_lazy
from .models import *
from .forms import *
#from .error.transbank_error import TransbankError
import random

def tienda(request):
    list = Producto.objects.all()
    print(list)
    contexto = {'list' : list}
    return render(request, "core/tienda.html", contexto)

def iniciar_sesion(request):
    data = {"mesg": "", "form": IniciarSesionForm()}
    if request.method == "POST":
        form = IniciarSesionForm(request.POST)
        if form.is_valid:
            username = request.POST.get("username")
            password = request.POST.get("password")
            user = authenticate(username=username, password=password)
            if user is not None:
                if user.is_active:
                    login(request, user)
                    return redirect(tienda)
                else:
                    data["mesg"] = "¡La cuenta o la password no son correctos!"
            else:
                data["mesg"] = "¡La cuenta o la password no son correctos!"
    return render(request, "core/iniciar_sesion.html", data)

def cerrar_sesion(request):
    logout(request)
    return redirect(tienda)

def registrar_usuario(request):
    if request.method == 'POST':
        form = RegistrarUsuarioForm(request.POST)
        if form.is_valid():
            user = form.save()
            rut = request.POST.get("rut")
            direccion = request.POST.get("direccion")
            nombre = request.POST.get("first_name")
            apellido = request.POST.get("last_name")
            correo = request.POST.get("email")
            PerfilUsuario.objects.update_or_create(user=user, rut=rut, dirusu=direccion, apeusu = apellido, nomusu = nombre, correo = correo, tipousu="Cliente", pwd=123)
            return redirect(iniciar_sesion)
    form = RegistrarUsuarioForm()
    return render(request, "core/registrar_usuario.html", context={'form': form})

