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

/*CREAR TABLAS Y RELACIONES*/
/*-------------------------*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auth_group](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[auth_group_permissions]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auth_group_permissions](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[group_id] [int] NOT NULL,
	[permission_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[auth_permission]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auth_permission](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[content_type_id] [int] NOT NULL,
	[codename] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[auth_user]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auth_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[password] [nvarchar](128) NOT NULL,
	[last_login] [datetimeoffset](7) NOT NULL,
	[is_superuser] [bit] NOT NULL,
	[username] [nvarchar](30) NOT NULL,
	[first_name] [nvarchar](30) NOT NULL,
	[last_name] [nvarchar](30) NOT NULL,
	[email] [nvarchar](75) NOT NULL,
	[is_staff] [bit] NOT NULL,
	[is_active] [bit] NOT NULL,
	[date_joined] [datetimeoffset](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[auth_user_groups]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auth_user_groups](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[group_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[auth_user_user_permissions]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auth_user_user_permissions](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[permission_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[django_content_type]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[django_content_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[app_label] [nvarchar](100) NOT NULL,
	[model] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[django_migrations]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[django_migrations](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[app] [nvarchar](255) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[applied] [datetimeoffset](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[nrofac] [int] NOT NULL,
	[fechafac] [date] NOT NULL,
	[descfac] [nvarchar](300) NOT NULL,
	[monto] [int] NOT NULL,
	[idprod] [int] NOT NULL,
	[rutcli] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nrofac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuiaDespacho]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuiaDespacho](
	[nrogd] [int] NOT NULL,
	[estadogd] [nvarchar](50) NOT NULL,
	[idprod] [int] NOT NULL,
	[nrofac] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nrogd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PerfilUsuario]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfilUsuario](
	[rut] [nvarchar](20) NOT NULL,
	[tipousu] [nvarchar](50) NOT NULL,
	[nomusu] [nvarchar](100) NOT NULL,
	[apeusu] [nvarchar](100) NOT NULL,
	[correo] [nvarchar](100) NOT NULL,
	[dirusu] [nvarchar](300) NOT NULL,
	[pwd] [nvarchar](50) NOT NULL,
	[user_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idprod] [int] NOT NULL,
	[nomprod] [nvarchar](100) NOT NULL,
	[descprod] [nvarchar](300) NOT NULL,
	[precio] [int] NOT NULL,
	[imagen] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idprod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SolicitudServicio]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SolicitudServicio](
	[nrosol] [int] NOT NULL,
	[tiposol] [nvarchar](50) NOT NULL,
	[fechavisita] [date] NOT NULL,
	[descsol] [nvarchar](200) NOT NULL,
	[estadosol] [nvarchar](50) NOT NULL,
	[nrofac] [int] NOT NULL,
	[ruttec] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nrosol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockProducto]    Script Date: 17/04/2023 3:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockProducto](
	[idstock] [int] NOT NULL,
	[idprod] [int] NOT NULL,
	[nrofac] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idstock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[auth_group_permissions]  WITH CHECK ADD  CONSTRAINT [auth_group_permissions_group_id_b120cbf9_fk_auth_group_id] FOREIGN KEY([group_id])
REFERENCES [dbo].[auth_group] ([id])
GO
ALTER TABLE [dbo].[auth_group_permissions] CHECK CONSTRAINT [auth_group_permissions_group_id_b120cbf9_fk_auth_group_id]
GO
ALTER TABLE [dbo].[auth_group_permissions]  WITH CHECK ADD  CONSTRAINT [auth_group_permissions_permission_id_84c5c92e_fk_auth_permission_id] FOREIGN KEY([permission_id])
REFERENCES [dbo].[auth_permission] ([id])
GO
ALTER TABLE [dbo].[auth_group_permissions] CHECK CONSTRAINT [auth_group_permissions_permission_id_84c5c92e_fk_auth_permission_id]
GO
ALTER TABLE [dbo].[auth_permission]  WITH CHECK ADD  CONSTRAINT [auth_permission_content_type_id_2f476e4b_fk_django_content_type_id] FOREIGN KEY([content_type_id])
REFERENCES [dbo].[django_content_type] ([id])
GO
ALTER TABLE [dbo].[auth_permission] CHECK CONSTRAINT [auth_permission_content_type_id_2f476e4b_fk_django_content_type_id]
GO
ALTER TABLE [dbo].[auth_user_groups]  WITH CHECK ADD  CONSTRAINT [auth_user_groups_group_id_97559544_fk_auth_group_id] FOREIGN KEY([group_id])
REFERENCES [dbo].[auth_group] ([id])
GO
ALTER TABLE [dbo].[auth_user_groups] CHECK CONSTRAINT [auth_user_groups_group_id_97559544_fk_auth_group_id]
GO
ALTER TABLE [dbo].[auth_user_groups]  WITH CHECK ADD  CONSTRAINT [auth_user_groups_user_id_6a12ed8b_fk_auth_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[auth_user] ([id])
GO
ALTER TABLE [dbo].[auth_user_groups] CHECK CONSTRAINT [auth_user_groups_user_id_6a12ed8b_fk_auth_user_id]
GO
ALTER TABLE [dbo].[auth_user_user_permissions]  WITH CHECK ADD  CONSTRAINT [auth_user_user_permissions_permission_id_1fbb5f2c_fk_auth_permission_id] FOREIGN KEY([permission_id])
REFERENCES [dbo].[auth_permission] ([id])
GO
ALTER TABLE [dbo].[auth_user_user_permissions] CHECK CONSTRAINT [auth_user_user_permissions_permission_id_1fbb5f2c_fk_auth_permission_id]
GO
ALTER TABLE [dbo].[auth_user_user_permissions]  WITH CHECK ADD  CONSTRAINT [auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[auth_user] ([id])
GO
ALTER TABLE [dbo].[auth_user_user_permissions] CHECK CONSTRAINT [auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [Factura_idprod_2d2bdf71_fk_Producto_idprod] FOREIGN KEY([idprod])
REFERENCES [dbo].[Producto] ([idprod])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [Factura_idprod_2d2bdf71_fk_Producto_idprod]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [Factura_rutcli_b1520fa1_fk_PerfilUsuario_rut] FOREIGN KEY([rutcli])
REFERENCES [dbo].[PerfilUsuario] ([rut])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [Factura_rutcli_b1520fa1_fk_PerfilUsuario_rut]
GO
ALTER TABLE [dbo].[GuiaDespacho]  WITH CHECK ADD  CONSTRAINT [GuiaDespacho_idprod_2f99a153_fk_Producto_idprod] FOREIGN KEY([idprod])
REFERENCES [dbo].[Producto] ([idprod])
GO
ALTER TABLE [dbo].[GuiaDespacho] CHECK CONSTRAINT [GuiaDespacho_idprod_2f99a153_fk_Producto_idprod]
GO
ALTER TABLE [dbo].[GuiaDespacho]  WITH CHECK ADD  CONSTRAINT [GuiaDespacho_nrofac_c0530d77_fk_Factura_nrofac] FOREIGN KEY([nrofac])
REFERENCES [dbo].[Factura] ([nrofac])
GO
ALTER TABLE [dbo].[GuiaDespacho] CHECK CONSTRAINT [GuiaDespacho_nrofac_c0530d77_fk_Factura_nrofac]
GO
ALTER TABLE [dbo].[PerfilUsuario]  WITH CHECK ADD  CONSTRAINT [PerfilUsuario_user_id_ec66e99e_fk_auth_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[auth_user] ([id])
GO
ALTER TABLE [dbo].[PerfilUsuario] CHECK CONSTRAINT [PerfilUsuario_user_id_ec66e99e_fk_auth_user_id]
GO
ALTER TABLE [dbo].[SolicitudServicio]  WITH CHECK ADD  CONSTRAINT [SolicitudServicio_nrofac_80536535_fk_Factura_nrofac] FOREIGN KEY([nrofac])
REFERENCES [dbo].[Factura] ([nrofac])
GO
ALTER TABLE [dbo].[SolicitudServicio] CHECK CONSTRAINT [SolicitudServicio_nrofac_80536535_fk_Factura_nrofac]
GO
ALTER TABLE [dbo].[SolicitudServicio]  WITH CHECK ADD  CONSTRAINT [SolicitudServicio_ruttec_ac9a6f64_fk_PerfilUsuario_rut] FOREIGN KEY([ruttec])
REFERENCES [dbo].[PerfilUsuario] ([rut])
GO
ALTER TABLE [dbo].[SolicitudServicio] CHECK CONSTRAINT [SolicitudServicio_ruttec_ac9a6f64_fk_PerfilUsuario_rut]
GO
ALTER TABLE [dbo].[StockProducto]  WITH CHECK ADD  CONSTRAINT [StockProducto_idprod_dc3254a8_fk_Producto_idprod] FOREIGN KEY([idprod])
REFERENCES [dbo].[Producto] ([idprod])
GO
ALTER TABLE [dbo].[StockProducto] CHECK CONSTRAINT [StockProducto_idprod_dc3254a8_fk_Producto_idprod]
GO
ALTER TABLE [dbo].[StockProducto]  WITH CHECK ADD  CONSTRAINT [StockProducto_nrofac_7c0b3b70_fk_Factura_nrofac] FOREIGN KEY([nrofac])
REFERENCES [dbo].[Factura] ([nrofac])
GO
ALTER TABLE [dbo].[StockProducto] CHECK CONSTRAINT [StockProducto_nrofac_7c0b3b70_fk_Factura_nrofac]
GO

/*ELIMINAR TODOS LOS DATOS DEL MODELO PARA LIMPIAR LAS TABLAS*/
/*-----------------------------------------------------------*/
DELETE FROM "dbo"."auth_user"
DELETE FROM "dbo"."StockProducto";
DELETE FROM "dbo"."StockProducto";
DELETE FROM "dbo"."SolicitudServicio";
DELETE FROM "dbo"."GuiaDespacho";
DELETE FROM "dbo"."Factura";
DELETE FROM "dbo"."PerfilUsuario";
DELETE FROM "dbo"."Producto";

SET IDENTITY_INSERT auth_user ON;
GO
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (1, N'pbkdf2_sha256$390000$c3HLXdJ7eZzY1qeKKsVAk7$BdDrALhiQErCe55h18CP9EASAWjvBlk6TiabDYWtj10=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 1, N'admin', N'Blanca', N'Rojas Administrador', N'brojas1997@gmail.com', 1, 1, CAST(N'2023-04-17T07:28:23.6183150+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (2, N'pbkdf2_sha256$390000$6zaCYulQuakJA8Zt4YUqZq$Rh5VBt5ZbEwX+xqNxugZtLjTBEoII6K8f8DJoQQOYzg=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'atorres', N'Ana', N'Torres', N'atorres@duoc.cl', 0, 1, CAST(N'2023-04-17T07:28:23.7417030+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (3, N'pbkdf2_sha256$390000$ylpFUdzREyR8pLmDB1l7qX$rYXG4q54soKefE42MzIiufimDhiolhLZZdvWue8VPlg=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'jperez', N'Juan', N'Pérez', N'jperez@duoc.cl', 0, 1, CAST(N'2023-04-17T07:28:23.8587020+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (4, N'pbkdf2_sha256$390000$SWBtEXBewZTqVoQEogfAZX$X6x5mss4U+2p91QtBAe0lkCRdKB7h9OvlA8cm+zY9Ls=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'mayala', N'Mario', N'Ayala', N'mayala@duoc.cl', 0, 1, CAST(N'2023-04-17T07:28:23.9732220+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (5, N'pbkdf2_sha256$390000$GdTgnR5VAUz4yWGGRSIDa4$xazacXmkDYukJyikV3CNd34d/bAYMBDM+02svREoqSQ=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'jsoto', N'John', N'Soto', N'jsoto@duoc.cl', 0, 1, CAST(N'2023-04-17T07:28:24.0900790+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (6, N'pbkdf2_sha256$390000$iTkYZCXelFzOlJrUsnSDZI$RGmmn32WL7JGefvwApl3SKYLsJ4udGCpD3hRUkE8nzk=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'pmora', N'Pedro', N'Mora', N'pmora@duoc.cl', 0, 1, CAST(N'2023-04-17T07:28:24.2101070+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (7, N'pbkdf2_sha256$390000$bsclZFAVboILgsT1IR9hpc$nGlJ8IqZp2X/oaeWXsEa+GlFEyLoug2/xv422AEGVGk=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'jgatica', N'Juan', N'Gatica', N'jgatica@duoc.cl', 0, 1, CAST(N'2023-04-17T07:28:24.3308350+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (8, N'pbkdf2_sha256$390000$D83utFPJxxm8dDhEH7880r$i02EtICw5VRthGNiODEoT1yl/JF4Q/VmQk1u9iub28Q=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'mvera', N'María', N'Vera', N'mvera@duoc.cl', 0, 1, CAST(N'2023-04-17T07:28:24.4505160+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (9, N'pbkdf2_sha256$390000$sRG1SlU6kvFW04vwEU5ZYV$cTBykEMu2lbkYio1cioAx+1oa6w6zbV2q5/cG9LSUd4=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'pdiazduoc', N'Pablo', N'Díaz', N'pdiazduoc.cl', 0, 1, CAST(N'2023-04-17T07:28:24.5682860+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (10, N'pbkdf2_sha256$390000$P4X5FGe5OjsPhZ8IEYOI97$boAux5G38+XmwkXB1N2CDx2n+vJ61KQ1L5NbNbV9lYo=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'creyes', N'Carlos', N'Reyes', N'creyes@duoc.cl', 1, 1, CAST(N'2023-04-17T07:28:24.6856930+00:00' AS DateTimeOffset))
INSERT [dbo].[auth_user] ([id], [password], [last_login], [is_superuser], [username], [first_name], [last_name], [email], [is_staff], [is_active], [date_joined]) VALUES (11, N'pbkdf2_sha256$390000$O5eBUq9oD5anJDZgZwJ9Yt$TwQUtP+XFJMy+e+xazLKah/rMypItAGKZKxD6l8ZF5w=', CAST(N'2022-01-01T12:00:00.0000000+00:00' AS DateTimeOffset), 0, N'emusk', N'Elon', N'Musk', N'emusk@duoc.cl', 1, 1, CAST(N'2023-04-17T07:28:24.8034660+00:00' AS DateTimeOffset))
SET IDENTITY_INSERT auth_user OFF;
GO

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
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (2, N'1111-1', N'Cliente', N'Ana', N'Torres', N'atorres@duoc.cl', N'La Florida', N'123');
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (3, N'2222-2', N'Cliente', N'Juan', N'Pérez', N'jperez@duoc.cl', N'Santiago', N'123');
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (4, N'3333-3', N'Cliente', N'Mario', N'Ayala', N'mayala@duoc.cl', N'Providencia', N'123');
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (5, N'4444-4', N'Cliente', N'John', N'Soto', N'jsoto@duoc.cl', N'Las Condes', N'123');
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (6, N'5555-5', N'Cliente', N'Pedro', N'Mora', N'pmora@duoc.cl', N'Maipú', N'123');
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (7, N'6666-6', N'Técnico', N'Juan', N'Gatica', N'jgatica@duoc.cl', N'Cerro Navia', N'123');
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (8, N'7777-7', N'Técnico', N'María', N'Vera', N'mvera@duoc.cl', N'Peñalolén', N'123');
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (9, N'8888-8', N'Técnico', N'Pablo', N'Díaz', N'pdiazduoc.cl', N'La Reina', N'123');
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (10, N'9999-9', N'Bodeguero', N'Carlos', N'Reyes', N'creyes@duoc.cl', N'La Florida', N'123');
INSERT INTO "dbo"."PerfilUsuario" (user_id, rut, tipousu, nomusu, apeusu, correo, dirusu, pwd) VALUES (11, N'0000-0', N'Administrador', N'Elon', N'Musk', N'emusk@duoc.cl', N'La Reina', N'123');

/*Poblar tabla Factura*/
/*----------------------------*/
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (1, N'1111-1', 1, CAST('20220223' AS datetime), N'Aire Wifi 9000 btu', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (2, N'2222-2', 2, CAST('20220224' AS datetime), N'Split Inv 12000 btu', 450000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (3, N'3333-3', 4, CAST('20220303' AS datetime), N'Anwo Portátil', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (4, N'4444-4', 4, CAST('20220308' AS datetime), N'Anwo Portátil', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (5, N'5555-5', 4, CAST('20220315' AS datetime), N'Anwo Portátil', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (6, N'1111-1', 5, CAST('20220327' AS datetime), N'Mantención', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (7, N'1111-1', 5, CAST('20220403' AS datetime), N'GPORT-14', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (8, N'1111-1', 3, CAST('20220408' AS datetime), N'Anwo VP', 25000);
INSERT INTO "dbo"."Factura" (nrofac, rutcli, idprod, fechafac, descfac, monto) VALUES (9, N'1111-1', 5, CAST('20220415' AS datetime), N'GPORT-14', 25000);

/*Poblar tabla GuiaDespacho*/
/*------------------------------------*/
INSERT INTO "dbo"."GuiaDespacho" (nrogd, nrofac, idprod, estadogd) VALUES (11, 1, 1, N'Entregado');
INSERT INTO "dbo"."GuiaDespacho" (nrogd, nrofac, idprod, estadogd) VALUES (22, 2, 2, N'Depachado');
INSERT INTO "dbo"."GuiaDespacho" (nrogd, nrofac, idprod, estadogd) VALUES (88, 8, 3, N'EnBodega');

/*Poblar tabla SolicitudServicio*/
/*--------------------------------------*/
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (111, 1, N'Instalación', CAST('20220302 09:00' AS datetime), N'6666-6', N'Instalar equipo', N'Cerrada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (222, 2, N'Instalación', CAST('20220303 10:00' AS datetime), N'6666-6', N'Instalar equipo', N'Aceptada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (333, 3, N'Mantención', CAST('20220310 15:00' AS datetime), N'6666-6', N'Cambiar enchufe', N'Aceptada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (444, 4, N'Mantención', CAST('20220315 09:00' AS datetime), N'6666-6', N'Limpiar filtro', N'Aceptada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (555, 5, N'Reparación', CAST('20220322 17:00' AS datetime), N'6666-6', N'Reparar equipo', N'Aceptada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (666, 6, N'Mantención', CAST('20220403 11:00' AS datetime), N'7777-7', N'Limpiar filtro', N'Cerrada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (777, 7, N'Reparación', CAST('20220410 16:00' AS datetime), N'6666-6', N'Reparar aire', N'Modificada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (888, 8, N'Instalación', CAST('20220415 10:00' AS datetime), N'7777-7', N'Instalar equipo', N'Modificada');
INSERT INTO "dbo"."SolicitudServicio" (nrosol, nrofac, tiposol, fechavisita, ruttec, descsol, estadosol) VALUES (999, 9, N'Reparación', CAST('20220422 18:00' AS datetime), N'8888-8', N'Enchufe quemado', N'Aceptada');

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
