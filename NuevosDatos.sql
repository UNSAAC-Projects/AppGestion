use AppGestion
go

/*ELIMINAR ELEMENTOS DE TODAS LAS TABLAS*/
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

INSERT INTO TAsignatura (CodAsignatura, IDPlan, Nombre, Creditos,HorasPracticas,HorasTeoricas,Categoria,Prerrequisitos) VALUES 
('IF662','P001','DEEP LEARNING','04','02','03','EEEP','IF652'),
('IF484','P001','EMPRENDIMIENTO E INNOVACION','03','02','02','EEEP','IF482'),
('IF653','P001','MINERIA DE DATOS','04','02','03','EEEP','IF652'),
('IF554','P001','REDES DE COMPUTADORAS II','04','02','03','EEEP','IF552'),
('IF658','P001','REDES NEURONALES ARTIFICIALES','04','02','03','EEEP','IF652'),	
('IF214','P001','TEORIA GENERAL DE SISTEMAS	','04','02','03','EE','70 Creds.'),
('IF468','P001','FUNDAMENTOS DE PROGRAMACION','04','02','03','OEES', ''),	
('IF902','P001','TECNOLOGIAS DE LA INFORMACION Y LA COMUNICACION','03','02','02','EG','15 Creds.'),
('IF450','P001','ABSTRACCION DE DATOS Y OBJETOS','04','02','03','OEES','IF468'),	
('IF451','P001','PROGRAMACION I','02','04','00','OEES','IF468'),
('IF480','P001','ADMINISTRACION DE TECNOLOGIAS DE INFORMACION','03','02','02','OEES','ME352'),	
('IF452','P001','ALGORITMOS Y ESTRUCTURAS DE DATOS','04','02','03','OEES','IF450'),	
('IF453','P001','PROGRAMACION II','02','04','00','OEES','IF451'),
('IF610','P001','ANALISIS Y DISE�O DE SISTEMAS DE INFORMACION','04','02','03','OEES','IF450 y IF480'),
('IF650','P001','MODELOS PROBABILISTICOS','04','02','03','OEES','ME352'),
('IF550','P001','ORGANIZACION Y ARQUITECTURA DEL COMPUTADOR','04','02','03','OEES','EL371'),
('IF454','P001','TEORIA DE LA COMPUTACION','03','02','02','OEES','IF452 y ME355'),
('IF455','P001','ALGORITMOS PARALELOS Y DISTRIBUIDOS','04','02','03','OEES','IF452'),
('IF458','P001','COMPUTACION GRAFICA I','04','02','03','EEEP','IF452 y ME351'),
('IF612','P001','FUNDAMENTOS Y DISE�O DE BASES DE DATOS','04','02','03','OEES','IF610'),	
('IF457','P001','METODOS NUMERICOS','03','02','02','OEES','ME356'),	
('IF551','P001','SISTEMAS OPERATIVOS','04','02','03','OEES','IF550'),
('IF456','P001','ALGORITMOS AVANZADOS','04','02','03','OEES','IF454'),
('IF467','P001','ANALISIS Y DISE�O DE ALGORITMOS','03','02','02','EEEP','IF452 y IF453'),
('IF466','P001','COMPILADORES','03','02','02','EEEP','IF454'),	
('IF613','P001','DESARROLLO DE SOFTWARE I','02','04','00','OEES','IF612'),	
('IF651','P001','INTELIGENCIA ARTIFICIAL','04','02','03','OEES','IF650 y IF612'),
('IF063','P001','QUECHUA','02','04','00','AEX','100 Creds.'),
('IF552','P001','REDES DE COMPUTADORAS I','04','02','03','OEES','IF551'),
('IF652','P001','APRENDIZAJE AUTOMATICO','04','02','03','OEES','IF651'),
('IF664','P001','BIOINFORMATICA','04','02','03','EEEP','IF650'),
('IF614','P001','INGENIERIA DE SOFTWARE I','04','02','03','OEES','IF611 y IF613'),
('IF669','P001','MODELADO Y SIMULACION','04','02','03','EEEP','IF650'),
('IF482','P001','PLANEAMIENTO Y DIRECCION ESTRATEGICA DE TECNOLOGIA DE INFORMACION','03','02','02','OEES','140 Creds.'),
('IF710','P001','SEMINARIO DE INVESTIGACION I','03','02','02','OEES','150 Creds.'),
('IF459','P001','COMPUTACION GRAFICA II','04','02','03','EEEP','IF458'),
('IF483','P001','FORMULACION DE PROYECTOS DE TECNOLOGIA DE INFORMACION','03','02','02', 'OEES','IF482'),
('IF617','P001','INGENIERIA DE SOFTWARE II','04','02','03','EEEP','IF614'),
('IF656','P001','PROCESAMIENTO DEL LENGUAJE NATURAL','04','02','03','EEEP','IF651'),	
('IF654','P001','ROBOTICA','04','02','03','EEEP','IF651'),
('IF657','P001','VISION COMPUTACIONAL','04','02','03','EEEP','IF651'),
('IF210','P001','PLANEAMIENTO ESTRATEGICO' ,'04','02','03','OE','IF209'),
('IF603','P001','ROBOTICA Y PROCESAMIENTO DE SE�AL','04','02','03','OE','IF601'),
('IF711','P001','SEMINARIO DE INVESTIGACION II','03','02','02','OEES','IF710');
go

INSERT INTO TDocente VALUES 
('D0001','ABDON','RIBAS PUGA','LICENCIADO EN FISICO MATEMATICAS','ACTIVO'),
('D0002','ANA ROCIO','CARDENAS MAITA','MAGISTER EN CIENCIAS EN SISTEMAS DE INFORMACION','ACTIVO'),
('D0003','DENNIS IVAN','CANDIA OVIEDO','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0004','DORIS SABINA','AGUIRRE CARBAJAL','MAESTRO EN CIENCIAS: ING DE SISTEMAS CON MENCION EN ING DE SOFTWARE','ACTIVO'),
('D0005','EDWIN','CARRASCO POBLETE','MAGISTER CON MENCION EN INGENIERIA','ACTIVO'),
('D0006','EFRAINA GLADYS','CUTIPA ARAPA','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0007','EMILIO','PALOMINO OLIVERA','MAGISTER CON MENCION EN INGENIERIA','ACTIVO'),
('D0008','ENRIQUE','GAMARRA SALDIVAR','MAGISTER EN CIENCIAS CON MENCION EN INFORMATICA','ACTIVO'),
('D0009','ESTHER CRISTINA','PACHECO VASQUEZ','LICENCIADA EN FISICO MATEMATICAS','ACTIVO'),
('D0010','GUZMAN','TICONA PARI','INGENIERO QUIMICO','ACTIVO'),
('D0011','HARLEY','VERA OLIVERA','MAGISTER EN INFORMATICA','ACTIVO'),
('D0012','HENRY SAMUEL','DUE�AS DE LA CRUZ','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0013','HERNAN','CASTA�EDA CHIRINOS','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0014','HERNAN','NINA HANCO','MAESTRO EN ADMINISTRACION','ACTIVO'),
('D0015','IVAN CESAR','MEDRANO VALENCIA','INGENIERO QUIMICO','ACTIVO'),
('D0016','JAVIER ARTURO','ROZAS HUACHO','MAGISTER EN CIENCIAS CON MENCION EN INFORMATICA','ACTIVO'),
('D0017','JAVIER DAVID','CHAVEZ CENTENO','MAGISTER SCIENTIAE EN INFORMATICA','ACTIVO'),
('D0018','JOSE MAURO','PILLCO QUISPE','LICENCIADO EN FISICO MATEMATICAS','ACTIVO'),
('D0019','JULIO CESAR','CARBAJAL LUNA','MAGISTER EN CIENCIAS CON MENCION EN INFORMATICA','ACTIVO'),
('D0020','KARELIA','MEDINA MIRANDA','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0021','LAURO','ENCISO RODAS','DOCTOR EN INGENIERIA DE SISTEMAS','ACTIVO'),
('D0022','LINO AQUILES','BACA CARDENAS','INGENIERO DE MINAS','ACTIVO'),
('D0023','LINO PRISCILIANO','FLORES PACHECO','MAGISTER EN INFORMATICA','ACTIVO'),
('D0024','LUIS ALVARO','MONZON CONDORI','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0025','LUIS BELTRAN','PALMA TTITO','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0026','MANUEL AURELIO','PE�ALOZA FIGUEROA','INGENIERO DE TELECOMUNICACIONES','ACTIVO'),
('D0027','MARITZA KATHERINE','IRPANOCCA CUSIMAYTA','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0028','NILA ZONIA','ACURIO USCA','MAGISTER EN CIENCIAS CON MENCION EN INFORMATICA','ACTIVO'),
('D0029','ROBERT WILBERT','ALZAMORA PAREDES','MASTER EN INGENIERIA COMPUTACIONAL Y SISTEMAS INTELIGENTES','ACTIVO'),
('D0030','RONY','VILLAFUERTE SERNA','MAESTRO EN INGENIERIA COMPUTACIONAL Y SISTEMAS INTELIGENTES','ACTIVO'),
('D0031','VANESA MARIBEL','CHOQUE SOTO','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0032','WALDO ELIO','IBARRA ZAMBRANO','MAESTRO EN CIENCIAS CON MENCION EN INFORMATICA','ACTIVO'),
('D0033','WALDO','VILLA RODRIGUEZ','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0034','WILLIAN','ZAMALLOA PARO','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0035','BORIS','CHULLO LLAVE','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO');
GO

INSERT INTO TCatalogo VALUES
('C001','10','IF662','A','202IN','D0035','D0030'),
('C002','10','IF459','B','103IN','D0025','D0025'),
('C003','08','IF554','B','103IN','D0020','D0020'),
('C004','09','IF658','A','103IN','D0017','D0017'),
('C005','04','IF214','A','203IN','D0010','D0012'),
('C006','03','IF468','A','203IN','D0004','D0004'),
('C007','06','IF450','A','105IN','D0016','D0018'),
('C008','10','IF450','B','105IN','D0014','D0010'),

('C009','08','IF484','A','104IN','D0020','D0021'),
('C010','03','IF457','A','104IN','D0008','D0008'),
('C011','05','IF483','B','104IN','D0004','D0004');
GO

INSERT INTO TLogin VALUES 
('boris','boris','Docente','D0035'),
('zonia','zonia','Docente','D0028'),
('zonia','zonia','DirectorEscuela','D0028'),
('lauro','lauro','Docente','D0021'),
('lauro','lauro','DirectorAcademico','D0021');
go

--Primary key = int entity
INSERT INTO THorario VALUES
--4 cr�ditos
('LUNES'    ,'7','9','C001','T'),
('MIERCOLES','7','9','C001','P'),
('VIERNES'  ,'7','8','C001','T'),

('LUNES'    ,'9','11','C002','T'),
('MIERCOLES','9','11','C002','P'),
('VIERNES'  ,'9','10','C002','T'),

('LUNES'    ,'11','13','C003','T'),
('MIERCOLES','11','13','C003','P'),
('VIERNES'  ,'11','13','C003','T'),

('LUNES'    ,'15','17','C004','T'),
('MIERCOLES','15','17','C004','P'),
('VIERNES'  ,'15','16','C004','T'),

('MARTES' ,'7','9','C005','T'),
('JUEVES' ,'7','9','C005','P'),
('VIERNES','7','9','C005','T'),

('MARTES' ,'9','11','C006','T'),
('JUEVES' ,'9','11','C006','P'),
('VIERNES','10','11','C006','T'),

('MARTES' ,'11','13','C007','T'),
('JUEVES' ,'11','13','C007','P'),
('VIERNES','12','13','C007','T'),

('MARTES' ,'15','17','C008','T'),
('JUEVES' ,'15','17','C008','P'),
('VIERNES','16','17','C008','T'),

--3 cr�ditos
('MARTES' ,'17','19','C009','T'),
('JUEVES' ,'17','19','C009','P'),

('MARTES' ,'11','13','C010','T'),
('JUEVES' ,'11','13','C010','P'),

('LUNES'    ,'7','9','C011','T'),
('MIERCOLES','7','9','C011','P');
GO

--INSERT INTO TAsistencia VALUES
--('A0001','28/05/21' ,'7','Alumno','H0001'),
--('A0002','14/04/21','7'	,'Docente','H0001'),
--('A0003','28/05/21' ,'9','Alumno','H0001'),
--('A0004','14/04/21','9'	,'Docente','H0001')
--GO

--INSERT INTO TAsistenciaDocente VALUES
--('AD0001','A0002','5'	,'','A'),
--('AD0002','A0004','5'	,'','A')
--GO

--INSERT INTO TAsistenciaAlumno VALUES
--('AA0001','A0001','A'	,''),
--('AA0002','A0003','A'	,'')
--GO

INSERT INTO TALUMNO (CodAlumno, Apellidos, Nombres) VALUES 
('182898','CERATI CERRILLO','FIORELLA'),
('125156','CONDORI FLORES WILLIAMS','DENNIS'),
('163839','CORAZAO HINOJOSA','REISON DARIO'),
('170430','COVARRUBIAS AGUILAR','GEREMY ANDRE'),
('170750','CUSIHUAMAN AUCCACUSI','LUIS ALDAIR'),
('182908','ESPINOZA CHAMPI','ISRAEL ENRIQUE'),
('174443','FARFAN MOSCOSO','JUAN VICTOR'),
('151812','FERRO ALVAREZ','JUSTINO'),
('171059','FLORES IGNACIO','JOSE LUIS'),
('184648','GALICIA CENTENO','EDSON RAUL'),
('171061','GUEVARA FERRO','CRISTIAN LUIS'),
('163808','LOZANO LLACCTAHUAMAN','ROYER BRANDON'),
('130741','MERMA QUISPE','HAROL HELBERT'),
('154631','NOLASCO SUYO','CARLOS ANTONI'),
('182925','OLIVARES CAMERO','ALER SEBASTIAN'),
('182926','ORTEGA SULLCACCORI','ACCENT BLADIMIR'),
('141671','PAREDES DENOS','VICTOR ANIVAL'),
('171066','QUINTO CATACHURA','LADY DIANA'),
('171067','QUISPE SERRANO','HILLARY CRISTINA'),
('161135','QUISPE TACURI','RUDI'),
('171260','QUISPE TTITO','JOEL WILLY'),
('192428','RADO HUAYOTUMA','ARTUR MARTI'),
('163671','ROBLES SILVA','ANGELO'),
('171605','SALINAS ATAUSINCHI','JERSON'),
('184655','SANCA ZEVALLOS','JERY'),
('141011','SIPAUCAR CONDORI','MARITZA MARIBEL'),	
('182938','VILLAFUERTE GARCES','EDU RODRIGO'),
('145009','YCHU VALENCIA','MIGUEL HUMBERTO'),
('182941','YUCA LIMA','KARLA URBELINDA'),
('950610','ANDRADE ESCOBAR','LUIS'),
('131605','AYQUIPA GOMEZ','AMILCAR'),
('130516','BUSTAMANTE MAMANI','WASHINGTON MARCO'),
('170749','CARMONA CHOQUEMAMANI','KENNY HAROLD'),
('170428','CASSA LIPA','EDWAR YURI'),
('161756','CCONISLLA MEDINa','ANTHONY ALDAIR'),
('174440','CONDORI OCHOA','GIOVDEY ABRAHAM'),
('182909','ESTRELLA VILCA','JAMES KEVIN'),
('182910','FLORES ROBLES','KATHERYNE SHARMELLY'),
('182914','HUAMAN MENDOZA','ELVIS JORGE'),
('112207','IBARRA CASTILLO','WALDO ERICK'),
('170436','LUYCHO ANCAIFURO','MARIELA'),
('163809','MAMANI CHINO','RUBEN'),
('164566','MAMANI QUINTA','MICHAEL ANTONNI'),
('182923','MORA CCARHUARUPAY','LUZ LUCERO'),
('171064','ORE GAMARRA','ABRAHAM BENJAMIN'),
('101526','ORUE QUISPE','ALVARO AMERICO'),
('130322','PEREZ TOMAYLLA','BRUNO'),
('151822','PUMA MAMANI','NILSON MAURIO'),
('151780','QUISPE PUMA','LUCERO'),
('101664','QUISPE RODRIGUEZ','LUIS ALEXEI'),
('171069','RODRIGUEZ OJEDA','JORGE VICTOR'),
('174454','TINTAYA TACO','YUREMA LISBETH'),
('083221','TRUJILLO TORBISCO','LUIS ANDERSON'),
('174455','UGARTE CASTILLO','BRIGGITTE LEONOR'),
('182936','USUCACHI ANO','ISAC ANDERSON'),
('155183','VARGAS ARQQUE','JEREMYK RUFINO');
GO

INSERT INTO TMatriculado VALUES
('M0001','170750','2021-II','A','C001'),
('M0002','182908','2021-II','A','C001'),
('M0003','174443','2021-II','A','C001'),
('M0004','151812','2021-II','A','C001'),
('M0005','171059','2021-II','A','C001'),
('M0006','184648','2021-II','A','C001'),
('M0007','171061','2021-II','A','C001'),
('M0008','163808','2021-II','B','C001'),
('M0009','130741','2021-II','B','C001'),
('M0010','154631','2021-II','B','C001'),
('M0011','182925','2021-II','B','C001'),
('M0012','182926','2021-II','B','C001'),
('M0016','161135','2021-II','B','C001'),
('M0017','171260','2021-II','A','C002'),
('M0018','192428','2021-II','A','C002'),
('M0019','163671','2021-II','A','C002'),
('M0020','171605','2021-II','A','C002'),
('M0021','184655','2021-II','A','C002'),
('M0022','141011','2021-II','A','C002'),
('M0023','182938','2021-II','A','C002'),
('M0024','145009','2021-II','A','C002'),
('M0027','131605','2021-II','B','C002'),
('M0028','130516','2021-II','B','C002'),
('M0029','170749','2021-II','B','C002'),
('M0030','170428','2021-II','B','C002'),
('M0031','161756','2021-II','B','C002'),
('M0032','174440','2021-II','B','C002'),
('M0033','182909','2021-II','B','C002'),
('M0034','182910','2021-II','B','C002'),
('M0035','182914','2021-II','B','C002'),
('M0036','112207','2021-II','B','C002'),
('M0037','170436','2021-II','B','C002'),
('M0038','163809','2021-II','A','C003'),
('M0039','164566','2021-II','A','C003'),
('M0040','182923','2021-II','A','C003'),
('M0041','171064','2021-II','A','C003'),
('M0042','101526','2021-II','A','C003'),
('M0043','130322','2021-II','A','C004'),
('M0044','151822','2021-II','A','C004'),
('M0048','174454','2021-II','A','C004'),
('M0049','083221','2021-II','A','C004'),
('M0050','174455','2021-II','A','C004'),
('M0051','182936','2021-II','A','C004'),
('M0052','155183','2021-II','B','C004'),
('M0053','182898','2021-II','B','C004'),
('M0054','125156','2021-II','B','C004'),
('M0055','163839','2021-II','B','C004'),
('M0056','170430','2021-II','B','C004');
GO