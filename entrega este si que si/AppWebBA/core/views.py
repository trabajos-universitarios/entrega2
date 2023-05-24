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
    return render(request, "core/iniciar_sesion.html")

def cerrar_sesion(request):
    logout(request)
    return redirect(tienda)


    