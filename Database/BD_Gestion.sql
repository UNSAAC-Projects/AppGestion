use master
go

 /* Para ejecutar DB en la nube */
--use db_a7d2c3_appgestion
--go

/* Para ejecutar BD de forma local */
--DROP DATABASE AppGestion
GO
create database AppGestion
go
use AppGestion
go

/***********************************************************************************
					CREACION TABLAS
************************************************************************************/

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
	CodDocentePractico varchar(6),
	CodDocenteTeorico varchar(6),
	PRIMARY KEY (IDCatalogo),
	FOREIGN KEY (CodAsignatura) REFERENCES TAsignatura,
	FOREIGN KEY (CodDocentePractico) REFERENCES TDocente,
	FOREIGN KEY (CodDocenteTeorico) REFERENCES TDocente
)
GO

create table TPlanSesiones
(
	Id		int identity,
	Unidad				varchar(40),
	Capitulo			varchar(20),
	Tema				varchar(255),
	HorasProgramadas	varchar(4),
	Fecha				date,
	IDCatalogo			varchar(6),
	Finalizado			varchar(14),
	foreign key(IDCatalogo) references TCatalogo
)
go

CREATE TABLE THorario
(
	IDHorario INT IDENTITY,
	Dia varchar(10),
	HoraInicio varchar(2),
	HoraFin varchar(2),
	IDCatalogo varchar(6),
	Tipo varchar(10), --(teorico o práctico)
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
	IDHorario INT IDENTITY,
	PRIMARY KEY (IDAsistencia),
	FOREIGN KEY (IDHorario) REFERENCES THorario,
	--DELETE ON CASCADE
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
	Semestre varchar(7),
	Grupo varchar(1),
	IDCatalogo varchar(6),
	PRIMARY KEY (IDMatriculado),
	FOREIGN KEY (CodAlumno) REFERENCES TAlumno,
	FOREIGN KEY (IDCatalogo) REFERENCES TCatalogo
)
GO

------------------------------- PROCEDIMIENTO ALMACENADOS DE ASIGNATURA--------------------------------------
-----------procecedimiento alamcenado para listar las asignaturas-----------
create proc SP_LISTARASIGNATURA
as
select CodAsignatura, IDPlan,Nombre, Creditos, Categoria, HorasPracticas, HorasTeoricas, Prerrequisitos from TAsignatura
go

-----------procecedimiento alamcenado para Buscar una asignatura-----------
CREATE PROC SP_BUSCARASIGNATURA
@BUSCAR varchar(20)
as
select * from TAsignatura
where CodAsignatura like @BUSCAR + '%' or  Nombre like @BUSCAR + '%'
go

-----------procecedimiento alamcenado para agregar una nueva asignatura-----------
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

-----------procecedimiento alamcenado para Editar alguna asignatura-----------
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
		HorasTeoricas=@HorasTeoricas,Prerrequisitos=@Prerrequisitos
where CodAsignatura =@CodAsignatura
go
-----------procecedimiento alamcenado para leliminar una asignatura----------

create proc SP_ELIMINARASIGNATURA
@CodAsignatura varchar(10)
as
delete TAsignatura
where CodAsignatura=@CodAsignatura
go

--------------------- PROCEDIMIENTO ALMACENADOS DE CURSO CATALOGO
-----------procecedimiento alamcenado para listar los cursos de catalogo----------
create proc SP_LISTARCATALOGO
as
select NroSemestre, CodAsignatura, Grupo, Aula ,CodDocenteTeorico, CodDocentePractico from TCatalogo
go

----------procecedimiento alamcenado para un Buscar un curso en el catalogo----------
CREATE PROC SP_BUSCARCATALOGO
@BUSCAR varchar(20)
as
select * from TCatalogo
where NroSemestre like @BUSCAR + '%' or  CodAsignatura like @BUSCAR + '%' 
go


----------procecedimiento alamcenado para un Agregar un curso en el catalogo----------
create proc SP_INSERTARCATALOGO
	@IDCatalogo varchar(6),
	@NroSemestre varchar(2),
	@CodAsignatura varchar(6),
	@Grupo varchar(1),
	@Aula varchar(6),
	@CodDocenteTeorico varchar(6),
	@CodDocentePractico varchar(6)
as
insert into TCatalogo values(@IDCatalogo,@NroSemestre,@CodAsignatura,@Grupo,@Aula,@CodDocentePractico,@CodDocenteTeorico)
go

----------procecedimiento alamcenado para un Editar un curso en el catalogo----------
create proc SP_EDITARCATALOGO
	@IDCatalogo varchar(6),
	@NroSemestre varchar(2),
	@CodAsignatura varchar(6),
	@Grupo varchar(1),
	@Aula varchar(6),
	@CodDocenteTeorico varchar(6),
	@CodDocentePractico varchar(6)
as 
delete from THorario where IDCatalogo=@IDCatalogo
update TCatalogo set NroSemestre=@NroSemestre, CodAsignatura=@CodAsignatura,Grupo=@Grupo,Aula=@Aula,CodDocentePractico=@CodDocentePractico, CodDocenteTeorico=@CodDocenteTeorico
where IDCatalogo =@IDCatalogo
go
 
----------procecedimiento alamcenado para un Eliminar un curso en el catalogo----------
create proc SP_ELIMINARCATALOGO
@IDCatalogo varchar(10)
as
delete from THorario where IDCatalogo=@IDCatalogo
delete from TCatalogo where IDCatalogo=@IDCatalogo
go

----------------------  PROC.  HORARIO -----------------
CREATE PROC SP_INSERTARHORARIO
	@Dia varchar(100),
	@HoraInicio varchar(2),
	@HoraFin varchar(2),
	@Tipo varchar(10),
	@IDCatalogo varchar(6)
AS INSERT INTO THorario values (
	@Dia,
	@HoraInicio,
	@HoraFin,
	@IDCatalogo,
	@Tipo )
go

----------------------  PROC. VISTA CATALOGO ------------------------------------------------------
CREATE PROC SP_VISTACATALOGO
as
select C.IDCatalogo,C.CodAsignatura ,C.CodAsignatura + C.Grupo +'IN' as GrupoAsignatura,A.Nombre, A.Creditos , A.Categoria, C.NroSemestre, D.Nombres as DocentePractico, D.Nombres as DocenteTeorico, C.CodDocentePractico, c.CodDocenteTeorico
from TAsignatura  A inner join TCatalogo C on C.CodAsignatura=A.CodAsignatura inner join TDocente D on D.CodDocente=C.CodDocentePractico and D.CodDocente=C.CodDocenteTeorico
go

-------procedimiento almacenado para buscar curso-----
CREATE PROC SP_BUSCARVISTACATALOGO
@BUSCAR varchar(20)
as
select C.IDCatalogo,C.CodAsignatura ,C.CodAsignatura + C.Grupo +'IN' as GrupoAsignatura,A.Nombre, A.Creditos , A.Categoria, C.NroSemestre, D.Nombres as DocentePractico, D.Nombres as DocenteTeorico, C.CodDocentePractico, c.CodDocenteTeorico
from TAsignatura  A inner join TCatalogo C on C.CodAsignatura=A.CodAsignatura inner join TDocente D on D.CodDocente=C.CodDocentePractico and D.CodDocente=C.CodDocenteTeorico
where A.Nombre like @BUSCAR + '%'
go

------- LISTAR HORARIO -------------
create proc SP_VISTAHORARIOS
as
select C.CodAsignatura,A.Nombre, C.Grupo, h.Dia ,h.HoraInicio, h.HoraFin, h.Tipo
from THorario h inner join TCatalogo c on h.IDCatalogo = c.IDCatalogo inner join TAsignatura A ON c.CodAsignatura=A.CodAsignatura
go

INSERT INTO TDocente values ('D000','NO DEFINIDO' ,'','','')
GO


/***************************************************************
		PROCEDIMIENTOS DIRECTOR DEPARTAMENTO ACADÉMICO
****************************************************************/
--ver lista del catálogo------------
CREATE PROC SP_LISTACATALOGO 
AS
select (C.CodAsignatura + C.Grupo + 'IN') as CODIGO, 
	A.Nombre as CURSO,
	A.Creditos as CRED,
	H.Tipo as TIPO,
	C.Grupo as GRUPO,
	A.HorasTeoricas as HT,
	A.HorasPracticas as HP,
	H.Dia as DIA,
	H.HoraInicio as 'HORA INICIO',
	H.HoraFin as 'HORA FIN',
	C.Aula as AULA,
	case when H.Tipo = 'T' then (DT.Nombres) else (DP.Nombres) end as NOMBRES,
	case when H.Tipo = 'T' then (DT.Apellidos) else (DP.Apellidos) end as APELLIDOS
from TAsignatura A 
inner join TCatalogo C on A.CodAsignatura = C.CodAsignatura
inner join THorario H on C.IDCatalogo = H.IDCatalogo
left join TDocente DT on C.CodDocenteTeorico = DT.CodDocente
left join TDocente DP on C.CodDocentePractico = DP.CodDocente
GO

--ver horario y docente de un curso catalogo (ex: 'IF450BIN')
CREATE PROC SP_OBTENER_HORARIO_CURSOCATALOGO 
@CURSOCATALOGO varchar(10)
AS
select H.Dia as DIA, H.HoraInicio as 'HORA INICIO', H.HoraFin as'HORA FIN', H.Tipo as TIPO, 
	case when H.Tipo = 'T' then (DT.Nombres) else (DP.Nombres) end as NOMBRES,
	case when H.Tipo = 'T' then (DT.Apellidos) else (DP.Apellidos) end as APELLIDOS
from TCatalogo C
inner join THorario H on H.IDCatalogo = C.IDCatalogo
left join TDocente DT on DT.CodDocente = C.CodDocenteTeorico
left join TDocente DP on DP.CodDocente = C.CodDocentePractico
where C.CodAsignatura = SUBSTRING(@CURSOCATALOGO,1,5) --Obtener CodAsignatura
and C.Grupo = SUBSTRING(@CURSOCATALOGO,6,1) --Obtener Grupo
GO

--Insertar un docente
CREATE PROC SP_INSERT_DOCENTE
	@CodDocente varchar(6),
	@Nombres varchar(100),
	@Apellidos varchar(100),
	@TituloAcademico varchar(100),
	@Estado varchar (100)
as
insert into TDocente values(@CodDocente,@Nombres,@Apellidos,@TituloAcademico,@Estado)
go

-- Verificar si existe un curso en el catalogo (ex: IF324AIN)
CREATE PROC SP_EXISTE_CURSOCATALOGO
	@CURSOCATALOGO varchar(10)
AS
SELECT * FROM TCatalogo
WHERE CodAsignatura = SUBSTRING(@CURSOCATALOGO,1,5) --Obtener CodAsignatura
	and Grupo = SUBSTRING(@CURSOCATALOGO,6,1) --Obtener Grupo
GO

-- Recuperar el codigo de un docente a partir de sus nombres y apellidos
CREATE PROC SP_RECUPERAR_CODDOCENTE
	@Nombres varchar(100),
	@Apellidos varchar(100)
AS
select CodDocente from TDocente
where Nombres = @Nombres and Apellidos = @Apellidos
GO

--Editar docente teorico
CREATE PROC SP_EDITAR_DOCENTETEORICO
	@CURSOCATALOGO varchar(10),
	@CodDocenteTeorico varchar(6)
AS
UPDATE TCatalogo SET
	CodDocenteTeorico=@CodDocenteTeorico
WHERE CodAsignatura = SUBSTRING(@CURSOCATALOGO,1,5) --Obtener CodAsignatura
	and Grupo = SUBSTRING(@CURSOCATALOGO,6,1) --Obtener Grupo
GO

--Editar docente práctico
CREATE PROC SP_EDITAR_DOCENTEPRACTICO
	@CURSOCATALOGO varchar(10),
	@CodDocentePractico varchar(6)
AS
UPDATE TCatalogo SET
	CodDocentePractico=@CodDocentePractico
WHERE CodAsignatura = SUBSTRING(@CURSOCATALOGO,1,5) --Obtener CodAsignatura
	and Grupo = SUBSTRING(@CURSOCATALOGO,6,1) --Obtener Grupo
GO

--Mostrar horario de un docente
CREATE PROC SP_HORARIO_DOCENTE
	@CodDocente varchar(6)
AS
select (C.CodAsignatura + C.Grupo + 'IN') as CODIGO, 
	A.Nombre AS NOMBRE, H.Tipo AS TIPO, C.Grupo AS GRUPO, 
	H.Dia AS DIA, H.HoraInicio AS 'HORA INICIO', H.HoraFin AS 'HORA FIN',
	(CONVERT(int, H.HoraFin) - CONVERT(int, H.HoraInicio)) as HORAS,
	C.Aula AS 'AULA'
from THorario H
inner join TCatalogo C on H.IDCatalogo = C.IDCatalogo
inner join TAsignatura A on A.CodAsignatura = C.CodAsignatura
where (C.CodDocentePractico = @CodDocente and H.Tipo = 'P') or 
(C.CodDocenteTeorico = @CodDocente and H.Tipo = 'T')
GO

-- Mostrar las horas de dictado de un docente
CREATE PROC SP_HORASDICTADO_DOCENTE
	@CodDocente varchar(9)
AS
-- Declarando tabla temporal
declare @temp table(
	Codigo varchar(9),
	Nombre varchar(100),
	Tipo varchar(10),
	Grupo varchar(1),
	Dia varchar(10),
	HoraInicio varchar (2),
	HoraFin varchar (2),
	Horas int,
	Aula varchar(6)
);
INSERT @temp EXEC SP_HORARIO_DOCENTE @CodDocente;
SELECT
	D.CodDocente as CODIGO,
	D.Nombres as NOMBRES,
	D.Apellidos as APELLIDOS,
	D.Estado as ESTADO,
	SUM(T.Horas) as 'HORAS DICTADO'
from @temp T
inner join TDocente D on D.CodDocente = @CodDocente
group by D.CodDocente, D.Nombres, D.Apellidos, D.Estado
GO

-- Horario de un docente por día
CREATE PROC SP_HORARIO_DOCENTE_DIA
	@CodDocente varchar(9),
	@NombreDia varchar(10)
AS
-- Declarando tabla temporal
declare @temp table(
	Codigo varchar(9),
	Nombre varchar(100),
	Tipo varchar(10),
	Grupo varchar(1),
	Dia varchar(10),
	HoraInicio varchar (2),
	HoraFin varchar (2),
	Horas int,
	Aula varchar(6)
);
INSERT @temp EXEC SP_HORARIO_DOCENTE @CodDocente;
--SELECT Codigo AS 'CODIGO',Nombre AS 'NOMBRE',Tipo AS 'TIPO',Grupo AS 'GRUPO',HoraInicio AS 'HORA INICIO',HoraFin AS 'HORA FIN',Aula AS 'AULA'
SELECT Codigo AS 'CODIGO',Nombre AS 'NOMBRE',Tipo AS 'TIPO',Grupo AS 'GRUPO',(HoraInicio+' - '+HoraFin) AS 'HORAS',Aula AS 'AULA'

FROM @temp
WHERE Dia = @NombreDia
GO

-- Lista docentes con sus horas de dictado
CREATE PROC SP_LISTA_DOCENTES
AS
select CodDocente as CODIGO, Nombres as NOMBRES, 
	Apellidos as APELLIDOS, TituloAcademico as 'TITULO ACADEMICO',
	Estado as ESTADO
from TDocente
GO

-- Obtener el nombre de un docente
CREATE PROC SP_OBTENER_NOMBREUSUARIO
	@CodDocente varchar(6)
AS
select (Nombres + ' ' + Apellidos) as 'NOMBRE USUARIO'
from TDocente
where CodDocente = @CodDocente
GO

--listar los cursos asignados de un docente
create proc SP_LISTARCURSOSXDOCENTE
@CODDOCENTE varchar(6)
as
	DROP TABLE IF EXISTS #CursosxDocente
	create table #CursosxDocente
	(
		GrupoAsignatura varchar(12),
		Nombre varchar(100),
		Grupo varchar(2),
		Creditos varchar(2),
		Categoria varchar(10),
		Horario varchar(50)
	)
	-- Declarar el cursor
	DECLARE cu_CursosXDocente CURSOR
	FOR
		select C.CodAsignatura + C.Grupo +'IN' as GrupoAsignatura, A.Nombre, C.Grupo, A.Creditos,
		A.Categoria, H.Dia AS Horario
			from TAsignatura  A inner join TCatalogo C on C.CodAsignatura=A.CodAsignatura inner join THorario H 
			on C.IDCatalogo=H.IDCatalogo
		where C.CodDocentePractico=@CODDOCENTE or c.CodDocenteTeorico=@CODDOCENTE

	-- Declarar variables para utilizar en el cursor
	DECLARE @GrupoAsignatura varchar(12),@Nombre varchar(100), @Grupo varchar(2), @Creditos varchar(2), @Categoria varchar(10),
	@Horario varchar(10), @AuxGrupoAsignatura varchar(12),@AuxNombre varchar(100), @AuxGrupo varchar(2), @AuxCreditos varchar(2), 
	@AuxCategoria varchar(10), @AuxHorario varchar(10), @HorarioTotal varchar(40)

	-- Abrir cursor
	open cu_CursosXDocente

	-- Recuperar la primera fila
	FETCH NEXT FROM cu_CursosXDocente into 
	@GrupoAsignatura,@Nombre, @Grupo, @Creditos, @Categoria,@Horario

	set @HorarioTotal=@Horario
	-- Procesar cada registro
	while @@FETCH_STATUS = 0
	begin
		FETCH NEXT FROM cu_CursosXDocente into 
		@AuxGrupoAsignatura,@AuxNombre, @AuxGrupo, @AuxCreditos, @AuxCategoria,@AuxHorario
		if (@GrupoAsignatura = @AuxGrupoAsignatura)
		begin
			set @Nombre=@AuxNombre
			set @Grupo=@AuxGrupo
			set @Creditos=@AuxCreditos
			set @Categoria=@AuxCategoria
			set @Horario=@AuxHorario

			set @HorarioTotal=@HorarioTotal+' - '+@Horario
		end;
		if (@GrupoAsignatura!=@AuxGrupoAsignatura)
		begin
			insert into #CursosxDocente 
			values(@GrupoAsignatura,@Nombre,@Grupo,@Creditos,@Categoria,@HorarioTotal)

			set @GrupoAsignatura=@AuxGrupoAsignatura
			set @Nombre=@AuxNombre
			set @Grupo=@AuxGrupo
			set @Creditos=@AuxCreditos
			set @Categoria=@AuxCategoria
			set @Horario=@AuxHorario

			set @HorarioTotal=@Horario
		end;
	end
	--Pequeño artificio
	declare @LenHorarioT int, @LenHorario int
	set @LenHorarioT=LEN(@HorarioTotal)
	set @LenHorario=LEN(@Horario)
	set @HorarioTotal=SUBSTRING(@HorarioTotal,1,@LenHorarioT-@LenHorario-3)
	insert into #CursosxDocente 
			values(@GrupoAsignatura,@Nombre,@Grupo,@Creditos,@Categoria,@HorarioTotal)
	--Cerrar el cursor
	close cu_CursosXDocente
	deallocate cu_CursosXDocente

	--mostrar resultados
	select *from #CursosxDocente
GO
-- Crear nueva ID
CREATE FUNCTION NuevoCatalogo()
RETURNS varchar(6)
AS
BEGIN
	declare @Codigo varchar(4)
	
	set @Codigo=((select MAX(IDCatalogo)  from TCatalogo))
	set @Codigo='C' + RIGHT('000' + LTRIM(right(isnull(@Codigo,'000'),3)+1 ),3)
   RETURN (@codigo)
END
GO

-- Obtener los datos de un usuario
CREATE PROC SP_OBTENER_DATOSUSUARIO
	@Usuario varchar(60), 
	@Contrasenia varchar(60),
	@Categoria varchar(100)
AS
select * 
from TLogin
where Usuario = @Usuario and Contrasenia = @Contrasenia and Categoria = @Categoria
GO
-- Obtener Plan de sesiones
CREATE PROC SP_OBTENER_PLANSESIONES
	@CodCatalogo varchar(6)
AS
select
	P.Unidad, 
	P.Capitulo, 
	P.Tema, 
	P.HorasProgramadas AS Horas,
	p.Finalizado
from TCatalogo C, TPlanSesiones P
where C.IDCatalogo=@CodCatalogo
GO

-- Editar plan sesiones
create proc SP_EDITARPLANSESIONES
	@Id int,
	@Unidad varchar(40),
	@Capitulo varchar(20),
	@Tema varchar(255),
	@HorasProgramadas varchar(4),
	@Finalizado varchar(14),
	@Fecha date
as 
update TPlanSesiones set Unidad=@Unidad, Capitulo=@Capitulo, Tema=@Tema, HorasProgramadas=@HorasProgramadas, Finalizado=@Finalizado,Fecha=@Fecha
where Id =@Id
GO
-- Eliminar Tema de plan de sesiones
create proc SP_ELIMINARTEMA_PLANSESIONES
	@CodCatalogo varchar(6),
	@Id int
as
delete from TPlanSesiones where Id=@Id
go





