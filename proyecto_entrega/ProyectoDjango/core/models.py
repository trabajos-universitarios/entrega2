from django.db import models
from django.contrib.auth.models import User

class Categoria(models.Model):
    idCategoria = models.IntegerField(primary_key=True, verbose_name="Id de categoría")
    nombreCategoria = models.CharField(max_length=80, blank=False, null=False, verbose_name="Nombre de la categoría")

    def __str__(self):
        return f"{self.idCategoria} - {self.nombreCategoria}"

class Vehiculo(models.Model):
    patente = models.CharField(max_length=6, primary_key=True, verbose_name="Patente")
    marca = models.CharField(max_length=80, blank=False, null=False, verbose_name="Marca vehículo")
    modelo = models.CharField(max_length=80, null=True, blank=True, verbose_name="Modelo")
    imagen = models.ImageField(upload_to="images/", default="sinfoto.jpg", null=False, blank=False, verbose_name="Imagen")
    precio = models.DecimalField(max_digits=35, decimal_places=2, null=False, blank=False, verbose_name="Precio")
    categoria = models.ForeignKey(Categoria, on_delete=models.DO_NOTHING)
    

    def __str__(self):
        return f"{self.patente} - {self.marca}, {self.modelo}"

class PerfilUsuario(models.Model):
    user = models.OneToOneField(User, on_delete=models.CASCADE)
    rut = models.CharField(max_length=80, blank=True, null=True, verbose_name="Rut")
    direccion = models.CharField(max_length=80, blank=True, null=True, verbose_name="Dirección")

    def __str__(self):
        return f"{self.user.username} - {self.user.first_name} {self.user.last_name} ({self.user.email})"