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


def permisos_user(request):
    permiso = "Cliente"
    if request.user.is_authenticated:
        user = User.objects.get(username=request.user.username)
        perfil = PerfilUsuario.objects.get(user=user)
        permiso = perfil.tipousu
    context = {'permiso' : permiso}
    return context