use AppGestion
go

/*ELIMINAR TODOS LOS DATOS DE LAS TABLAS*/
--Desactivar limitaciones de todas las tablas
EXEC sys.sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL' 

--Eliminar elementos de todas las tablas
EXEC sys.sp_msforeachtable 'DELETE FROM ?'

--Activar limitaciones de todas las tablas
EXEC sys.sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'
go

/***************************************************************
						INSERTAR DATOS
****************************************************************/

INSERT INTO TPlanDeEstudios VALUES 
('P001','IN'),
('P002','IN')
GO

INSERT INTO TAsignatura values
('IF662','P001' ,	'DEEP LEARNING',		'04', 'EEEP','','',	'IF652'),
('IF484','P002','EMPRENDIMIENTO E INNOVACION'		,'03'	,'EEEP'	,'','','IF482')
GO

INSERT INTO TDocente values
('D001','BORIS' ,	'CHULLO LLAVE',		'Ingeniero Informatico', 	'Activo'),
('D002','ZONIA','ACURIO USCA'	,'Magister en Ciencias con Mencion en Informatica'	,'Activo'),
('D003','LAURO','ENCISO RODAS'	,'Doctor en Ingenieria de Sistemas'	,'Activo')
GO

INSERT INTO TCatalogo VALUES
('C001','10' ,'IF662', 'A',	'201','D001'),
('C002','10','IF484'	,'B'	,'102','D002')
GO

INSERT INTO TLogin VALUES
('lauro', 'lauro', 'DirectorAcademico','D003'),
('lauro', 'lauro', 'Docente','D003'),
('zonia','zonia' ,'DirectorEscuela','D002'),
('zonia','zonia' ,'Docente','D002'),
('boris','boris','Docente'	,'D001')
GO

INSERT INTO THorario VALUES
('H0001','28/05/21' ,'7','9','C001'),
('H0002','14/04/21','7'	,'9','C001'),
('H0003','28/05/21' ,'9','11','C002'),
('H0004','14/04/21','9'	,'11','C002')
GO

INSERT INTO TAsistencia VALUES
('A0001','28/05/21' ,'7','Alumno','H0001'),
('A0002','14/04/21','7'	,'Docente','H0001'),
('A0003','28/05/21' ,'9','Alumno','H0001'),
('A0004','14/04/21','9'	,'Docente','H0001')
GO

INSERT INTO TAsistenciaDocente VALUES
('AD0001','A0002','5'	,'','A'),
('AD0002','A0004','5'	,'','A')
GO

INSERT INTO TAsistenciaAlumno VALUES
('AA0001','A0001','A'	,''),
('AA0002','A0003','A'	,'')
GO

INSERT INTO TAlumno VALUES
('113572','EDWAR','AUCAPIÑA SUVIZARRETA'),
('160542','ADHAIR EDHINO','CÁCERES-HUANCA'),
('170428','YURI','CASSA LIPA EDWAR'),
('182898','FIORELLA','CERATI CERRILLO')
GO

INSERT INTO TMatriculado VALUES
('M0001','113572','5'	,'A','C001'),
('M0002','160542','5'	,'A','C001'),
('M0003','170428','5'	,'A','C001'),
('M0004','182898','5'	,'A','C001')

GO