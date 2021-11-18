use master
go

--drop database AppGestion


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
	primary key (CodDocente),
	
)
go
--drop table Docente
--drop table TLogin
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
insert into Docente values ('D0003','Lauro','','Llave','Cusco','Ingeniero Informatico','Activo')
--insert into Administrador (CodAdministrador,Nombres,APaterno,AMaterno,Estado)
--values 
--	('002','Carlos Ramon','Quispe','Onofre','Nombrado')
select * from TLogin
insert into TLogin values ('boris','boris','D0001','Docente')
insert into TLogin values ('zonia','zonia','D0002','Director')
insert into TLogin values ('lauro','lauro','D0003','Jefe')


--- Tabla Asignatura

create table TAsignatura  -- Cursos que se llevara solo en la carrera
(
	CodAsignatura		varchar(6),
	Nombre		varchar(50),
	Creditos		varchar(5),
	Categoria		varchar(30),
	Requisitos      varchar(30),
	NroSemestre varchar(70),
	primary key (CodAsignatura)
)
go
--drop table TAsignatura
create table TCatalogo
(
	IdSemestre	varchar(6),
	CodDocente		varchar(6),
	CodAsignatura		varchar(6),
	Dia		varchar(30),
	Horario     varchar(30),
	Grupo varchar(70),
	Aula  varchar(40),
	Horas varchar(5),
	primary key (IdSemestre),
	FOREIGN KEY (CodAsignatura) references TAsignatura(CodAsignatura),
	FOREIGN KEY (CodDocente) references Docente(CodDocente)
)
go
--drop table TCatalogo
/* create table TAsistencia
(
	CodAsistencia  varchar(50),
	CodAsignatura varchar(50),
	Horario	varchar(6),
	Hora   varchar(50),
	Fecha  varchar(50),
	Dia		varchar(30),
	Grupo varchar(70),
	Aula  varchar(40),
	primary key (CodAsistencia)
)
go*/
--drop table TAsistencia
create table TAsistenciaAlumnos
(
	CodAsistenciaAlumnos varchar(50),
	CodAlumno varchar(50),
	CodAsignatura varchar(50),
	Horario	varchar(6),
	Hora   varchar(50),
	Fecha  varchar(50),
	Dia		varchar(30),

	primary key (CodAsistenciaAlumnos),
	foreign key (CodAlumno) references TAlumnoAsignatura(CodAlumno)
)
go
--drop table TAsistenciaAlumnos
--drop table TAsistenciaDocentes
create table TAsistenciaDocentes
(
	CodAsistenciaDocentes varchar(50),
	CodDocente varchar(6),
	CodAsignatura varchar(6),
	Horario	varchar(6),
	Hora   varchar(50),
	Fecha  varchar(50),
	Dia		varchar(30),

	primary key (CodAsistenciaDocentes),
	foreign key (CodDocente) references Docente(CodDocente)
	--foreign key (CodAsistencia) references TAsistencia (CodAsistencia)
)
go
--drop table TAsistenciaDocentes
create table TAlumnoAsignatura
(
	CodAlumno  varchar(50),
	CodAsignatura  varchar(6),
	CodAsistenciaAlumnos varchar(50),
	Nombres varchar(50),
	Apellidos varchar(50),
	Semestre	varchar(6),
	primary key (CodAlumno),
	foreign key (CodAsignatura) references TAsignatura (CodAsignatura),
	--foreign key (CodAsistenciaAlumnos) references TAsistenciaAlumnos (CodAsistenciaAlumnos)
)
go

--drop table TAlumnoAsignatura



