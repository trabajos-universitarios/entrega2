from django.urls import path
from django.views.generic.base import TemplateView
from django.contrib.auth import views as auth_views
from .views import *
from django.conf import settings
from django.conf.urls.static import static


# URLs relacionadas con la autenticación y el usuario
urlpatterns = [
    path('iniciar_sesion/', iniciar_sesion, name="iniciar_sesion"),  # Iniciar sesión
    path('cerrar_sesion/', cerrar_sesion, name='cerrar_sesion'),  # Cerrar sesión
    path('registrar_usuario/', registrar_usuario, name="registrar_usuario"),  # Registro de usuario
    path('perfil_usuario/', perfil_usuario, name="perfil_usuario"),  # Perfil de usuario
    path('cambiar_password/', auth_views.PasswordChangeView.as_view(template_name='core/cambiar_password.html', success_url='/password_cambiada'), name='cambiar_password'),  # Cambio de contraseña
]

# URLs relacionadas con la tienda y los productos
urlpatterns += [
    path('', tienda, name="tienda"),  # Página principal de la tienda
    path('mis_compras/', mis_compras, name="mis_compras"),  # Mis compras
    path('detalle_factura/<id>', detalle_factura, name="detalle_factura"),  # Detalle de factura
    path('ficha/<id>', ficha, name="ficha"),  # Ficha de producto
    path('iniciar_pago/<id>', iniciar_pago, name="iniciar_pago"),  # Iniciar proceso de pago
    path('pago_exitoso/<id>', pago_exitoso, name="pago_exitoso"),  # Pago exitoso
]

# URLs relacionadas con la administración de productos
urlpatterns += [
    path('administrar_productos/<action>/<id>', administrar_productos, name="administrar_productos"),  # Administración de productos
]

# URLs relacionadas con las solicitudes
urlpatterns += [
    path('crear_solicitud/<id>', solicitud_form, name="crear_solicitud"),  # Crear solicitud
    path('mis_solicitudes', mis_solicitudes, name="mis_solicitudes"),  # Mis solicitudes
    path('solicitudes_administrador', solicitudes_administrador, name="solicitudes_administrador"),  # Solicitudes de administrador
    path('eliminar_solicitudes/<id>', eliminar_solicitudes, name="eliminar_solicitudes"),  # Eliminar solicitud
]


urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)