from django.shortcuts import render
from .models import *

def home(request):
    list = Producto.objects.all()
    context = {'list': list}
    return render(request, "core/tienda.html", list)


