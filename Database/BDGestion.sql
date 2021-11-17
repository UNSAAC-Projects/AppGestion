use master
go

create database AppGestion
go

use AppGestion
go

----Tabla de Administrador
--create table Administrador
--(
--	CodAdministrador varchar(6),
--	APaterno		varchar(50),
--	AMaterno		varchar(50),
--	Nombres			varchar(30),
--	Estado			varchar(40),
--	primary key (CodAdministrador) 
--)
--Tabla de tutor
create table Docente
(
	CodDocente		varchar(6),
	APaterno		varchar(50),
	AMaterno		varchar(50),
	Nombres			varchar(30),
	Direccion       varchar(30),
	TituloAcademico varchar (70),
	Estado			varchar(40),
	primary key (CodDocente)
)
go
drop table TLogin
-- Tabla Login
create table TLogin
(
    Usuario			varchar(6),
	
	Contraseña		varchar(40),
	CodDocente      varchar(6),
	Categoria		varchar(20),
	primary key(Usuario),
	foreign key (CodDocente) references Docente(CodDocente)
	--foreign key (Usuario) references Administrador(CodAdministrador)
)
select * from Docente
insert into Docente values ('D0001','Boris','Chullo','Llave','Cusco','Ingeniero Informatico','Activo')
insert into Docente values ('D0002','Zonia','Acurio','Usca','Cusco','Magister en Ciencias con Mencion en Informatica','Activo')
--insert into Administrador (CodAdministrador,Nombres,APaterno,AMaterno,Estado)
--values 
--	('002','Carlos Ramon','Quispe','Onofre','Nombrado')
select * from TLogin
insert into TLogin values ('boris','boris','D0001','Docente')
insert into TLogin values ('zonia','zonia','D0002','Administrador')