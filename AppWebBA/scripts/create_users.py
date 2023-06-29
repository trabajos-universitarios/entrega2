from django.contrib.auth import get_user_model
from django.contrib.auth.models import User
import datetime

def run():

    # Crear usuarios del sistema
    CustomUser = get_user_model()
    if not User.objects.filter(username='admin').exists(): CustomUser.objects.create_superuser(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='admin', first_name='Blanca', last_name='Rojas Administrador', email='brojas1997@gmail.com')
    
    if not User.objects.filter(username='atorres').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='atorres', first_name='Ana', last_name='Torres', email='atorres@duoc.cl', is_staff=False)
    if not User.objects.filter(username='jperez').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='jperez', first_name='Juan', last_name='Pérez', email='jperez@duoc.cl', is_staff=False)
    if not User.objects.filter(username='mayala').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='mayala', first_name='Mario', last_name='Ayala', email='mayala@duoc.cl', is_staff=False)
    if not User.objects.filter(username='jsoto').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='jsoto', first_name='John', last_name='Soto', email='jsoto@duoc.cl', is_staff=False)
    if not User.objects.filter(username='pmora').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='pmora', first_name='Pedro', last_name='Mora', email='pmora@duoc.cl', is_staff=False)
    if not User.objects.filter(username='jgatica').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='jgatica', first_name='Juan', last_name='Gatica', email='jgatica@duoc.cl', is_staff=False)
    if not User.objects.filter(username='mvera').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='mvera', first_name='María', last_name='Vera', email='mvera@duoc.cl', is_staff=False)
    if not User.objects.filter(username='pdiazduoc').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='pdiazduoc', first_name='Pablo', last_name='Díaz', email='pdiazduoc.cl', is_staff=False)
    if not User.objects.filter(username='creyes').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='creyes', first_name='Carlos', last_name='Reyes', email='creyes@duoc.cl', is_staff=True)
    if not User.objects.filter(username='emusk').exists(): CustomUser.objects.create_user(password='123', last_login=datetime.datetime(2022, 1, 1, 9, 0, 0), username='emusk', first_name='Elon', last_name='Musk', email='emusk@duoc.cl', is_staff=True)

#user = User.objects.create_user(username='nombre_de_usuario', email='correo_electronico', password='contraseña')



# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (1, N'1111-1', N'Cliente', N'Ana', N'Torres', N'atorres@duoc.cl', N'La Florida', N'123');
# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (2, N'2222-2', N'Cliente', N'Juan', N'Pérez', N'jperez@duoc.cl', N'Santiago', N'123');
# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (3, N'3333-3', N'Cliente', N'Mario', N'Ayala', N'mayala@duoc.cl', N'Providencia', N'123');
# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (4, N'4444-4', N'Cliente', N'John', N'Soto', N'jsoto@duoc.cl', N'Las Condes', N'123');
# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (5, N'5555-5', N'Cliente', N'Pedro', N'Mora', N'pmora@duoc.cl', N'Maipú', N'123');
# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (6, N'6666-6', N'Técnico', N'Juan', N'Gatica', N'jgatica@duoc.cl', N'Cerro Navia', N'123');
# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (7, N'7777-7', N'Técnico', N'María', N'Vera', N'mvera@duoc.cl', N'Peñalolén', N'123');
# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (8, N'8888-8', N'Técnico', N'Pablo', N'Díaz', N'pdiazduoc.cl', N'La Reina', N'123');
# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (9, N'9999-9', N'Bodeguero', N'Carlos', N'Reyes', N'creyes@duoc.cl', N'La Florida', N'123');
# INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (9, N'0000-0', N'Administrador', N'Elon', N'Musk', N'emusk@duoc.cl', N'La Reina', N'123');