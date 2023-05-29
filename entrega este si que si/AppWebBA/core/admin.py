from django.contrib import admin
from .models import *

admin.site.register(Producto)
admin.site.register(PerfilUsuario)
admin.site.register(GuiaDespacho)
admin.site.register(Factura)

