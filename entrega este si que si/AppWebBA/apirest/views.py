import re
from django.shortcuts import render, redirect, get_object_or_404
from django.views.decorators import csrf
from rest_framework import status
from rest_framework.decorators import api_view, authentication_classes, permission_classes
from rest_framework.response import Response
from rest_framework.parsers import JSONParser
from django.views.decorators.csrf import csrf_exempt
from core.models import StockProducto
from .serializers import StockProductoSerializer
from rest_framework.parsers import MultiPartParser, FormParser
from rest_framework.views import APIView
from django.contrib.auth.models import User
from django.contrib.auth.hashers import check_password
from rest_framework.authtoken.models import Token
from rest_framework.authentication import TokenAuthentication
from rest_framework.permissions import IsAuthenticated

@csrf_exempt
@api_view(['GET'])
def productos_bodega_leer_todos(request):
    if request.method == 'GET':
        list = StockProducto.objects.all()
        serializer = StockProductoSerializer(list, many=True)
        return Response(serializer.data)