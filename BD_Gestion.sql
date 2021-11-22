GO
use master
go
--DROP DATABASE AppGestion
--GO
create database AppGestion
go

use AppGestion
go


/***************************************************************
						CREACION TABLAS
****************************************************************/

CREATE TABLE TPlanDeEstudios
(
	IDPlan varchar(6),
	CodDepartamento varchar(6),
	PRIMARY KEY (IDPlan) 
)
GO

CREATE TABLE TAsignatura
(
	CodAsignatura varchar(6),
	IDPlan varchar(6),
	Nombre varchar(100),
	Creditos varchar(2),
	Categoria varchar(100),
	HorasPracticas varchar(2),
	HorasTeoricas varchar(2),
	Prerrequisitos varchar(100),
	PRIMARY KEY (CodAsignatura),
	FOREIGN KEY (IDPlan) REFERENCES TPlanDeEstudios
)
GO

CREATE TABLE TAlumno
(
	CodAlumno varchar(6),
	Nombres varchar(100),
	Apellidos varchar(100),
	PRIMARY KEY (CodAlumno) 
)
GO

CREATE TABLE TDocente
(
	CodDocente varchar(6),
	Nombres varchar(100),
	Apellidos varchar(100),
	TituloAcademico varchar(100),
	Estado varchar (100),
	PRIMARY KEY (CodDocente) 
)
GO

CREATE TABLE TCatalogo
(
	IDCatalogo varchar(6),
	NroSemestre varchar(2),
	CodAsignatura varchar(6),
	Grupo varchar(1),
	Aula varchar(6),
	CodDocente varchar(6),
	PRIMARY KEY (IDCatalogo),
	FOREIGN KEY (CodAsignatura) REFERENCES TAsignatura,
	FOREIGN KEY (CodDocente) REFERENCES TDocente
)
GO

CREATE TABLE THorario
(
	IDHorario varchar(6),
	Dia varchar(100),
	HoraInicio varchar(2),
	HoraFin varchar(2),
	IDCatalogo varchar(6),
	PRIMARY KEY (IDHorario),
	FOREIGN KEY (IDCatalogo) REFERENCES TCatalogo
)
GO

CREATE TABLE TAsistencia
(
	IDAsistencia varchar(6),
	Fecha varchar(10),
	Hora varchar(2),
	Tipo varchar(100),
	IDHorario varchar(6),
	PRIMARY KEY (IDAsistencia),
	FOREIGN KEY (IDHorario) REFERENCES THorario
)
GO

CREATE TABLE TAsistenciaAlumno
(
	IDAsistenciaAlumno varchar(6),
	IDAsistencia varchar(6),
	Asistio varchar(60),
	Observaciones varchar(100),
	PRIMARY KEY (IDAsistenciaAlumno),
	FOREIGN KEY (IDAsistencia) REFERENCES TAsistencia
)
GO

CREATE TABLE TAsistenciaDiariaDocente
(
	IDAsistenciaDiaria varchar(6),
	Fecha varchar(10),
	Hora varchar(2),
	PRIMARY KEY (IDAsistenciaDiaria) 
)
GO

CREATE TABLE TAsistenciaDocente
(
	IDAsistenciaDocente varchar(6),
	IDAsistencia varchar(6),
	Semestre varchar(2),
	TemaAvance varchar(100),
	Asistio varchar(60),
	PRIMARY KEY (IDAsistenciaDocente),
	FOREIGN KEY (IDAsistencia) REFERENCES TAsistencia
)
GO

CREATE TABLE TListadoDocentes
(
	IDListado varchar(6),
	IDAsistenciaDiaria varchar(6),
	Asistio varchar(60),
	CodDocente varchar(6),
	Observaciones varchar(100),
	PRIMARY KEY (IDListado),
	FOREIGN KEY (IDAsistenciaDiaria) REFERENCES TAsistenciaDiariaDocente,
	FOREIGN KEY (CodDocente) REFERENCES TDocente

)
GO

CREATE TABLE TLogin
(
	Usuario varchar(60) NOT NULL, 
	Contrasenia varchar(60),
	Categoria varchar(100) NOT NULL,
	CodDocente varchar(6),
	PRIMARY KEY (Usuario, Categoria),
	FOREIGN KEY (CodDocente) REFERENCES TDocente
)
GO

CREATE TABLE TMatriculado
(
	IDMatriculado varchar(6),
	CodAlumno varchar(6),
	Semestre varchar(2),
	Grupo varchar(1),
	IDCatalogo varchar(6),
	PRIMARY KEY (IDMatriculado),
	FOREIGN KEY (CodAlumno) REFERENCES TAlumno,
	FOREIGN KEY (IDCatalogo) REFERENCES TCatalogo
)
GO

/***************************************************************
				PROCEDIMIENTOS ALMACENADOS DE ASIGNATURA
****************************************************************/

CREATE PROC SP_LISTARASIGNATURA
as
select CodAsignatura, IDPlan,Nombre, Creditos, Categoria, HorasPracticas, HorasTeoricas, Prerrequisitos from TAsignatura

GO
---
CREATE PROC SP_BUSCARASIGNATURA
@BUSCAR varchar(20)
as
select * from TAsignatura
where CodAsignatura like @BUSCAR + '%' or  Nombre like @BUSCAR + '%'
go

---
create proc SP_INSERTARASIGNATURA
	@CodAsignatura varchar(6),
	@IDPlan varchar(6),
	@Nombre varchar(100),
	@Creditos varchar(2),
	@Categoria varchar(100),
	@HorasPracticas varchar(2),
	@HorasTeoricas varchar(2),
	@Prerrequisitos varchar(100)
as
insert into TAsignatura values(@CodAsignatura,@IDPlan,@Nombre,@Creditos,@Categoria,@HorasPracticas,@HorasTeoricas,@Prerrequisitos)
go

---
create proc SP_EDITARASIGNATURA
@CodAsignatura varchar(6),
	@IDPlan varchar(6),
	@Nombre varchar(100),
	@Creditos varchar(2),
	@Categoria varchar(100),
	@HorasPracticas varchar(2),
	@HorasTeoricas varchar(2),
	@Prerrequisitos varchar(100)
as 
update TAsignatura set IDPlan=@IDPlan, Nombre=@Nombre,Creditos=@Creditos,Categoria=@Categoria,HorasPracticas=@HorasPracticas,
		@HorasTeoricas=@HorasTeoricas,Prerrequisitos=@Prerrequisitos
where CodAsignatura =@CodAsignatura
go

--- 
create proc SP_ELIMINARASIGNATURA
@CodAsignatura varchar(10)
as
delete TAsignatura
where CodAsignatura=@CodAsignatura
go

---

/***************************************************************
				PROCEDIMIENTOS ALMACENADOS DE CURSO CATALOGO
****************************************************************/

create proc SP_LISTARCATALOGO
as
select NroSemestre, CodAsignatura, Grupo, Aula ,CodDocente from TCatalogo
go
CREATE PROC SP_BUSCARCATALOGO
@BUSCAR varchar(20)
as
select * from TCatalogo
where NroSemestre like @BUSCAR + '%' or  CodAsignatura like @BUSCAR + '%' 
go

---
create proc SP_INSERTARCATALOGO
	@IDCatalogo varchar(6),
	@NroSemestre varchar(2),
	@CodAsignatura varchar(6),
	@Grupo varchar(1),
	@Aula varchar(6),
	@CodDocente varchar(6)
as
insert into TCatalogo values(@IDCatalogo,@NroSemestre,@CodAsignatura,@Grupo,@Aula,@CodDocente)
go

---
create proc SP_EDITARCATALOGO
	@IDCatalogo varchar(6),
	@NroSemestre varchar(2),
	@CodAsignatura varchar(6),
	@Grupo varchar(1),
	@Aula varchar(6),
	@CodDocente varchar(6)
as 
update TCatalogo set NroSemestre=@NroSemestre, CodAsignatura=@CodAsignatura,Grupo=@Grupo,Aula=@Aula,CodDocente=@CodDocente
where IDCatalogo =@IDCatalogo
go

---
create proc SP_ELIMINARCATALOGO
@IDCatalogo varchar(10)
as
delete TCatalogo
where IDCatalogo=@IDCatalogo
go

