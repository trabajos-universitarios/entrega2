/*ELIMINAR BS SI EXISTE Y LUEGO CREARLA*/
/*-------------------------------------*/
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'base_datos')
BEGIN
    ALTER DATABASE base_datos SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE base_datos;
END

CREATE DATABASE base_datos;
GO

/*ENTRAR A LA BD*/
/*--------------*/
USE base_datos;
GO

/*ELIMINAR TODOS LOS DATOS DEL MODELO PARA LIMPIAR LAS TABLAS*/
/*-----------------------------------------------------------*/
DELETE FROM "dbo"."StockProducto";
DELETE FROM "dbo"."SolicitudServicio";
DELETE FROM "dbo"."GuiaDespacho";
DELETE FROM "dbo"."Factura";
DELETE FROM "dbo"."PerfilUsuario";
DELETE FROM "dbo"."Producto";

/*Poblar tabla Producto*/
/*---------------------------------*/
INSERT INTO "dbo"."Producto" (idprod, nomprod, descprod, precio, imagen) VALUES (1,N'Aire Wifi 9000 btu',N'Enfría 9-16 m2',299990,'001.png');
INSERT INTO "dbo"."Producto" (idprod, nomprod, descprod, precio, imagen) VALUES (2,N'Split Inv 12000 btu',N'Frío/Calor AR12',450000,'002.png');
INSERT INTO "dbo"."Producto" (idprod, nomprod, descprod, precio, imagen) VALUES (3,N'Anwo VP',N'9000 Virus Protect',288990,'003.png');
INSERT INTO "dbo"."Producto" (idprod, nomprod, descprod, precio, imagen) VALUES (4,N'Anwo Portátil',N'12000 btu f/c',131990,'004.png');
INSERT INTO "dbo"."Producto" (idprod, nomprod, descprod, precio, imagen) VALUES (5,N'GPORT-14',N'Anwo 14000 btu',399990,'005.png');
INSERT INTO "dbo"."Producto" (idprod, nomprod, descprod, precio, imagen) VALUES (6,N'Kendal 12000',N'Climat 22-24 m2',335990,'006.png');

/*Poblar tabla PerfilUsuario*/
/*-------------------------------*/
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'1111-1', N'Cliente', N'Ana', N'Torres', N'atorres@duoc.cl', N'La Florida', N'123');
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'2222-2', N'Cliente', N'Juan', N'Pérez', N'jperez@duoc.cl', N'Santiago', N'123');
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'3333-3', N'Cliente', N'Mario', N'Ayala', N'mayala@duoc.cl', N'Providencia', N'123');
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'4444-4', N'Cliente', N'John', N'Soto', N'jsoto@duoc.cl', N'Las Condes', N'123');
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'5555-5', N'Cliente', N'Pedro', N'Mora', N'pmora@duoc.cl', N'Maipú', N'123');
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'6666-6', N'Técnico', N'Juan', N'Gatica', N'jgatica@duoc.cl', N'Cerro Navia', N'123');
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'7777-7', N'Técnico', N'María', N'Vera', N'mvera@duoc.cl', N'Peñalolén', N'123');
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'8888-8', N'Técnico', N'Pablo', N'Díaz', N'pdiazduoc.cl', N'La Reina', N'123');
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'9999-9', N'Bodeguero', N'Carlos', N'Reyes', N'creyes@duoc.cl', N'La Florida', N'123');
INSERT INTO "dbo"."PerfilUsuario" (rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (N'0000-0', N'Administrador', N'Elon', N'Musk', N'emusk@duoc.cl', N'La Reina', N'123');

/*Poblar tabla Factura*/
/*----------------------------*/
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (1, N'1111-1', 1, DATE('2022/02/23', 'YYYY-MM-DD HH24:MI:SS'), N'Aire Wifi 9000 btu', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (2, N'2222-2', 2, DATE('2022/02/24', 'YYYY-MM-DD HH24:MI:SS'), N'Split Inv 12000 btu', 450000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (3, N'3333-3', 4, DATE('2022/03/03', 'YYYY-MM-DD HH24:MI:SS'), N'Anwo Portátil', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (4, N'4444-4', 4, DATE('2022/03/08', 'YYYY-MM-DD HH24:MI:SS'), N'Anwo Portátil', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (5, N'5555-5', 4, DATE('2022/03/15', 'YYYY-MM-DD HH24:MI:SS'), N'Anwo Portátil', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (6, N'1111-1', 5, DATE('2022/03/27', 'YYYY-MM-DD HH24:MI:SS'), N'Mantención', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (7, N'1111-1', 5, DATE('2022/04/03', 'YYYY-MM-DD HH24:MI:SS'), N'GPORT-14', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (8, N'1111-1', 3, DATE('2022/04/08', 'YYYY-MM-DD HH24:MI:SS'), N'Anwo VP', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (9, N'1111-1', 5, DATE('2022/04/15', 'YYYY-MM-DD HH24:MI:SS'), N'GPORT-14', 25000);

/*Poblar tabla GuiaDespacho*/
/*------------------------------------*/
INSERT INTO "dbo"."GuiaDespacho" (nrogd, nrofac, idprod, estadogd) VALUES (11, 1, 1, N'Entregado');
INSERT INTO "dbo"."GuiaDespacho" (nrogd, nrofac, idprod, estadogd) VALUES (22, 2, 2, N'Depachado');
INSERT INTO "dbo"."GuiaDespacho" (nrogd, nrofac, idprod, estadogd) VALUES (88, 8, 3, N'EnBodega');

/*Poblar tabla SolicitudServicio*/
/*--------------------------------------*/
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (111, 1, N'Instalación', TO_DATE('2022/03/02 09:00', 'YYYY-MM-DD HH24:MI:SS'), N'6666-6', N'Instalar equipo', N'Cerrada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (222, 2, N'Instalación', TO_DATE('2022/03/03 10:00', 'YYYY-MM-DD HH24:MI:SS'), N'6666-6', N'Instalar equipo', N'Aceptada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (333, 3, N'Mantención', TO_DATE('2022/03/10 15:00', 'YYYY-MM-DD HH24:MI:SS'), N'6666-6', N'Cambiar enchufe', N'Aceptada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (444, 4, N'Mantención', TO_DATE('2022/03/15 09:00', 'YYYY-MM-DD HH24:MI:SS'), N'6666-6', N'Limpiar filtro', N'Aceptada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (555, 5, N'Reparación', TO_DATE('2022/03/22 17:00', 'YYYY-MM-DD HH24:MI:SS'), N'6666-6', N'Reparar equipo', N'Aceptada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (666, 6, N'Mantención', TO_DATE('2022/04/03 11:00', 'YYYY-MM-DD HH24:MI:SS'), N'7777-7', N'Limpiar filtro', N'Cerrada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (777, 7, N'Reparación', TO_DATE('2022/04/10 16:00', 'YYYY-MM-DD HH24:MI:SS'), N'6666-6', N'Reparar aire', N'Modificada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (888, 8, N'Instalación', TO_DATE('2022/04/15 10:00', 'YYYY-MM-DD HH24:MI:SS'), N'7777-7', N'Instalar equipo', N'Modificada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (999, 9, N'Reparación', TO_DATE('2022/04/22 18:00', 'YYYY-MM-DD HH24:MI:SS'), N'8888-8', N'Enchufe quemado', N'Aceptada');

/*Poblar tabla StockProducto*/
/*-------------------------------------*/
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (11111,1,1);
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (22222,2,2);
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (88888,3,8);
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (90001,1,null);
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (90002,3,null);
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (90003,4,null);
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (90004,6,null);
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (90005,1,null);
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (90006,3,null);
INSERT INTO "dbo"."StockProducto" (idstock, idprod, nrofac) VALUES (90007,4,null);
