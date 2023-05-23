from django.urls import path
from django.contrib import admin
from .views import productos_bodega_leer_todos

urlpatterns = [
    path('productos_bodega_leer_todos/', productos_bodega_leer_todos, name="productos_bodega_leer_todos"),
]