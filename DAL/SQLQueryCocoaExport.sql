create database CocoaExport

use CocoaExport


create table Usuarios(
			UsuarioId int primary key identity ,
			Nombres varchar(50),
			Apellidos varchar(50), 
			Direccion varchar(50),
			NombreUsuario varchar(40), 
			Contrasena varchar(100),
			Contrasena1 varchar(100));
			select *from Usuarios

					drop table Usuarios
create table Certificaciones(
			CertificacionId int primary key identity, 
			Descripcion varchar(50));
			
			select*from Certificaciones
			drop table Certificaciones

create table Socios(
			SocioId int primary key identity, 
			Nombre varchar(50), 
			Apellido varchar(50),
			Direccion varchar(40),
			Cedula varchar(13), 
			CertificacionId int References Certificaciones(CertificacionId), 
			CantidadTerreno float)
			
		select *from Socios
						drop table Socios		
create table Inspecciones(
			InspeccionId int primary key identity, 
			SocioId int References Socios(SocioId),
			Fecha varchar (60),
			Fertilizantes int,
			MaterialSiembra varchar(50), 
			CrianzaAnimales int,
			ControlPlagas varchar(50), 
			ResumenInspeccion varchar(200));
			
			select *from Inspecciones
			drop table Inspecciones
create table TiposCacao(
			TipoCacaoId int primary key identity, 
			Descripcion varchar(35));					
		
		select *from TiposCacao

create table Lotes(
			LoteId int primary key identity,
			CodigoLote varchar(20), 
			Total float, 
			CertificacionId int References Certificaciones(CertificacionId),
			Fecha varchar(20));
			select *from Lotes;
			select * from Recepciones

		select l.CodigoLote, (l.Total	 +r.CantidadPesada ) from Lotes l inner join Recepciones r on r.LoteId = l.LoteId where l.LoteId = 1
		
		update Lotes set Total=Total + 800 where LoteId=2

	insert into Lotes(CodigoLote, Total) values('025SGS', 500);
create table Recepciones(
			RecepcionId int primary key identity, 
			SocioId int References Socios(SocioId), 
			LoteId int References Lotes(LoteId),
			TipoCacaoId int References TiposCacao(TipoCacaoId),
			CantidadPesada float,
			Monto float,
			Fecha varchar(40),
			Observacion varchar(200), 
			RecibidoPor varchar(50));

			select *from Recepciones
			drop table Recepciones


	--detalle
create table LotesExportes(
			LoteId int References Lotes(LoteId), 
			CodigoLote varchar(20),
			ExportacionId int References Exportaciones(ExportacionId));

			select *from LotesExportes
		    drop table LotesExportes
			select e.CodigoLote from Exportaciones l inner join LotesExportes e on l.ExportacionId = e.ExportacionId where e.ExportacionId = 1



create table DestinosExportes(
			 DestinoId int primary key identity, 
			 Pais varchar(50), 
			 CodigoDestino varchar(30), 
			 NombreDestino varchar(50),
			 Direccion varchar(50), 
			 CodigoPostal float);

			select *from DestinosExportes
			drop table DestinosExportes
create table Exportaciones(
			 ExportacionId int primary key identity, 
			 DestinoId int References DestinosExportes(DestinoId),
			 Monto float,
			 Fecha varchar(40), 
			 Resumen varchar(300));

			 select *from Exportaciones
			 drop table Exportaciones
