from django.contrib import admin
from .models import Categoria, Vehiculo, PerfilUsuario

# Register your models here.

admin.site.register(Categoria)
admin.site.register(Vehiculo)
admin.site.register(PerfilUsuario)