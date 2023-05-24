from django.urls import path
from django.views.generic.base import TemplateView
from django.contrib.auth import views as auth_views
from .views import *

urlpatterns = [
    path('', tienda, name="tienda"),
    path('iniciar_sesion/', iniciar_sesion, name="iniciar_sesion"),
]