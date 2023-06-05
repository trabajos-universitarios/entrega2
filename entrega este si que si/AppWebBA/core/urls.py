from django.urls import path
from django.views.generic.base import TemplateView
from django.contrib.auth import views as auth_views
from .views import *
from django.conf import settings
from django.conf.urls.static import static


urlpatterns = [
    path('', tienda, name="tienda"),
    path('iniciar_sesion/', iniciar_sesion, name="iniciar_sesion"),
    path('cerrar_sesion/', cerrar_sesion, name='cerrar_sesion'),
    path('registrar_usuario/', registrar_usuario, name="registrar_usuario"),
    path('mis_compras/', mis_compras, name="mis_compras"),
    path('detalle_factura/<id>', detalle_factura, name="detalle_factura"),
    path('ficha/<id>', ficha, name="ficha"),
    path('iniciar_pago/<id>', iniciar_pago, name="iniciar_pago"),
    path('pago_exitoso/<id>', pago_exitoso, name="pago_exitoso"),
    path('perfil_usuario/', perfil_usuario, name="perfil_usuario"),
    path('administrar_productos/<action>/<id>', administrar_productos, name="administrar_productos"),
    path('cambiar_password/', auth_views.PasswordChangeView.as_view(template_name='core/cambiar_password.html', success_url='/password_cambiada'), name='cambiar_password'),
    path('crear_solicitud/<id>',solicitud_form , name="crear_solicitud"),
    path('mis_solicitudes',mis_solicitudes , name="mis_solicitudes"),
]

if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)