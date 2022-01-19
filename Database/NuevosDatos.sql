/* Para ejecutar DB en la nube */

/* -- Nube */
--Server name: sql5080.site4now.net
--Login: db_a7d2c3_appgestion_admin
--Password: AppGestion1

--use db_a7d2c3_appgestion
--go

/* Para ejecutar BD de forma local */
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

/********************************************************************************************************************
						INSERTAR DATOS
*********************************************************************************************************************/
INSERT INTO TPlanDeEstudios VALUES 
('P001','IN'),
('P002','IN')
GO

INSERT INTO TAsignatura (CodAsignatura, IDPlan, Nombre, Creditos,HorasPracticas,HorasTeoricas,Categoria,Prerrequisitos,NroSemestre) VALUES 
('IF662','P001','DEEP LEARNING','04','02','03','EEEP','IF652','10'),
('IF484','P001','EMPRENDIMIENTO E INNOVACION','03','02','02','EEEP','IF482','10'),
('IF653','P001','MINERIA DE DATOS','04','02','03','EEEP','IF652','10'),
('IF554','P001','REDES DE COMPUTADORAS II','04','02','03','EEEP','IF552','10'),
('IF658','P001','REDES NEURONALES ARTIFICIALES','04','02','03','EEEP','IF652','10'),	
('IF214','P001','TEORIA GENERAL DE SISTEMAS	','04','02','03','EE','70 Creds.','10'),
('IF468','P001','FUNDAMENTOS DE PROGRAMACION','04','02','03','OEES', '','2'),	
('IF902','P001','TECNOLOGIAS DE LA INFORMACION Y LA COMUNICACION','03','02','02','EG','15 Creds.','2'),
('IF450','P001','ABSTRACCION DE DATOS Y OBJETOS','04','02','03','OEES','IF468','2'),	
('IF451','P001','PROGRAMACION I','02','04','00','OEES','IF468','3'),
('IF480','P001','ADMINISTRACION DE TECNOLOGIAS DE INFORMACION','03','02','02','OEES','ME352','3'),	
('IF452','P001','ALGORITMOS Y ESTRUCTURAS DE DATOS','04','02','03','OEES','IF450','3'),	
('IF453','P001','PROGRAMACION II','02','04','00','OEES','IF451','4'),
('IF610','P001','ANALISIS Y DISEÑO DE SISTEMAS DE INFORMACION','04','02','03','OEES','IF450 y IF480','4'),
('IF650','P001','MODELOS PROBABILISTICOS','04','02','03','OEES','ME352','4'),
('IF550','P001','ORGANIZACION Y ARQUITECTURA DEL COMPUTADOR','04','02','03','OEES','EL371','4'),
('IF454','P001','TEORIA DE LA COMPUTACION','03','02','02','OEES','IF452 y ME355','4'),
('IF455','P001','ALGORITMOS PARALELOS Y DISTRIBUIDOS','04','02','03','OEES','IF452','4'),
('IF458','P001','COMPUTACION GRAFICA I','04','02','03','EEEP','IF452 y ME351','4'),
('IF612','P001','FUNDAMENTOS Y DISEÑO DE BASES DE DATOS','04','02','03','OEES','IF610','4'),	
('IF457','P001','METODOS NUMERICOS','03','02','02','OEES','ME356','4'),	
('IF551','P001','SISTEMAS OPERATIVOS','04','02','03','OEES','IF550','4'),
('IF456','P001','ALGORITMOS AVANZADOS','04','02','03','OEES','IF454','4'),
('IF467','P001','ANALISIS Y DISEÑO DE ALGORITMOS','03','02','02','EEEP','IF452 y IF453','4'),
('IF466','P001','COMPILADORES','03','02','02','EEEP','IF454','4'),	
('IF613','P001','DESARROLLO DE SOFTWARE I','02','04','00','OEES','IF612','4'),	
('IF651','P001','INTELIGENCIA ARTIFICIAL','04','02','03','OEES','IF650 y IF612','4'),
('IF063','P001','QUECHUA','02','04','00','AEX','100 Creds.','5'),
('IF552','P001','REDES DE COMPUTADORAS I','04','02','03','OEES','IF551','5'),
('IF652','P001','APRENDIZAJE AUTOMATICO','04','02','03','OEES','IF651','5'),
('IF664','P001','BIOINFORMATICA','04','02','03','EEEP','IF650','5'),
('IF614','P001','INGENIERIA DE SOFTWARE I','04','02','03','OEES','IF611 y IF613','5'),
('IF669','P001','MODELADO Y SIMULACION','04','02','03','EEEP','IF650','5'),
('IF482','P001','PLANEAMIENTO Y DIRECCION ESTRATEGICA DE TECNOLOGIA DE INFORMACION','03','02','02','OEES','140 Creds.','5'),
('IF710','P001','SEMINARIO DE INVESTIGACION I','03','02','02','OEES','150 Creds.','5'),
('IF459','P001','COMPUTACION GRAFICA II','04','02','03','EEEP','IF458','5'),
('IF483','P001','FORMULACION DE PROYECTOS DE TECNOLOGIA DE INFORMACION','03','02','02', 'OEES','IF482','5'),
('IF617','P001','INGENIERIA DE SOFTWARE II','04','02','03','EEEP','IF614','5'),
('IF656','P001','PROCESAMIENTO DEL LENGUAJE NATURAL','04','02','03','EEEP','IF651','5'),	
('IF654','P001','ROBOTICA','04','02','03','EEEP','IF651','5'),
('IF657','P001','VISION COMPUTACIONAL','04','02','03','EEEP','IF651','5'),
('IF210','P001','PLANEAMIENTO ESTRATEGICO' ,'04','02','03','OE','IF209','5'),
('IF603','P001','ROBOTICA Y PROCESAMIENTO DE SEÃ‘AL','04','02','03','OE','IF601','5'),
('IF711','P001','SEMINARIO DE INVESTIGACION II','03','02','02','OEES','IF710','5');
go

INSERT INTO TDocente VALUES 
('D000','NO DEFINIDO' ,'','',''),
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
('D0012','HENRY SAMUEL','DUEÑAS DE LA CRUZ','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0013','HERNAN','CASTAÑEDA CHIRINOS','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
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
('D0026','MANUEL AURELIO','PEÑALOZA FIGUEROA','INGENIERO DE TELECOMUNICACIONES','ACTIVO'),
('D0027','MARITZA KATHERINE','IRPANOCCA CUSIMAYTA','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0028','NILA ZONIA','ACURIO USCA','MAGISTER EN CIENCIAS CON MENCION EN INFORMATICA','ACTIVO'),
('D0029','ROBERT WILBERT','ALZAMORA PAREDES','MASTER EN INGENIERIA COMPUTACIONAL Y SISTEMAS INTELIGENTES','ACTIVO'),
('D0030','RONY','VILLAFUERTE SERNA','MAESTRO EN INGENIERIA COMPUTACIONAL Y SISTEMAS INTELIGENTES','ACTIVO'),
('D0031','VANESA MARIBEL','CHOQUE SOTO','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0032','WALDO ELIO','IBARRA ZAMBRANO','MAESTRO EN CIENCIAS CON MENCION EN INFORMATICA','ACTIVO'),
('D0033','WALDO','VILLA RODRIGUEZ','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0034','WILLIAN','ZAMALLOA PARO','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0035','BORIS','CHULLO LLAVE','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO'),
('D0036','JISBAJ','GAMARRA SALAS','INGENIERO INFORMATICO Y DE SISTEMAS','ACTIVO');
GO
--*************************************************************************************************************************

INSERT INTO TCatalogo (IDCatalogo, SemestreLectivo, NroSemestre, CodAsignatura, Grupo, Aula, CodDocentePractico, CodDocenteTeorico) VALUES 
-- 2DO SEMESTRE
-- Fundamentos de programacion
('C001','2021-2','02','IF468','A','IN202','D0028','D0028'),
('C002','2021-2','02','IF468','B','IN202','D0028','D0028'),
-- 5TO SEMESTRE
-- Modelos Probabilisticos
('C003','2021-2','05','IF650','A','IN205','D0025','D0021'),
('C004','2021-2','05','IF650','B','IN205','D0025','D0021'),
-- 6TO SEMESTRE
-- Metodologia de desarrollo de software
('C005','2021-2','06','IF611','A','IN206','D0033','D0033'),
('C006','2021-2','06','IF611','B','IN206','D0033','D0033'),
-- Fundamentos y disenio de bases de datos
('C007','2021-2','06','IF612','A','IN206','D0029','D0029'),
-- Ingenieria del software
-- 8VO SEMESTRE
('C008','2021-2','08','IF614','A','IN208','D0029','D0029'),
-- Aprendizaje Automatico
('C009','2021-2','08','IF652','A','IN208','D0025','D0025'),
('C010','2021-2','08','IF652','B','IN208','D0025','D0025');
GO

INSERT INTO TLogin VALUES 
('abdon','abdon','Docente','D0001'),
('ana','ana','Docente','D0002'),
('dennis','dennis','Docente','D0003'),
('doris','doris','Docente','D0004'),
('edwin','edwin','Docente','D0005'),
('efraina','efraina','Docente','D0006'),
('emilio','emilio','Docente','D0007'),
('enrique','enrique','Docente','D0008'),
('esther','esther','Docente','D0009'),
('guzman','guzman','Docente','D0010'),
('harley','harley','Docente','D0011'),
('henry','henry','Docente','D0012'),
('hernan_c','hernan_c','Docente','D0013'),
('hernan_n','hernan_n','Docente','D0014'),
('ivan','ivan','Docente','D0015'),
('javier_a','javier_a','Docente','D0016'),
('javier_d','javier_d','Docente','D0017'),
('jose','jose','Docente','D0018'),
('julio','julio','Docente','D0019'),
('karelia','karelia','Docente','D0020'),
('lauro','lauro','Docente','D0021'),
('lino_a','lino_a','Docente','D0022'),
('lino_p','lino_p','Docente','D0023'),
('luis_a','luis_a','Docente','D0024'),
('luis_b','luis_b','Docente','D0025'),
('manuel','manuel','Docente','D0026'),
('maritza','maritza','Docente','D0027'),
('zonia','zonia','Docente','D0028'),
('robert','robert','Docente','D0029'),
('rony','rony','Docente','D0030'),
('vanesa','vanesa','Docente','D0031'),
('waldo_e','waldo_e','Docente','D0032'),
('waldo','waldo','Docente','D0033'),
('willian','willian','Docente','D0034'),
('boris','boris','Docente','D0035'),
('jisbaj','jisbaj','Docente','D0036'),
('zonia','zonia','DirectorEscuela','D0028'),
('lauro','lauro','DirectorAcademico','D0021');

go

--Primary key = int entity
INSERT INTO THorario VALUES
-- Fundamentos de programacion
-- A
('LUNES'    ,'9','11','C001','T'),
('MIERCOLES','9','11','C001','P'),
('VIERNES'  ,'9','10','C001','T'),
-- B
('LUNES'    ,'18','20','C002','T'),
('MIERCOLES','18','20','C002','P'),
('VIERNES'  ,'18','19','C002','T'),

-- Modelos probabilisticos
-- A
('MARTES','7','9','C003','T'),
('JUEVES','7','9','C003','P'),
('VIERNES','8','9','C003','T'),
-- B
('MARTES','15','17','C004','T'),
('JUEVES','15','17','C004','P'),
('VIERNES','16','17','C004','T'),

-- Metodologia de desarrollo de software
-- A
('MARTES' ,'7','9','C005','T'),
('JUEVES' ,'7','9','C005','P'),
-- B
('MARTES' ,'15','17','C006','T'),
('JUEVES' ,'15','17','C006','P'),

-- Fundamento y disenio de bases de datos
-- A
('MARTES' ,'9','11','C007','T'),
('JUEVES' ,'9','11','C007','P'),
('VIERNES','9','11','C007','T'),

-- Ingenieria del software
-- A
('MARTES' ,'7','9','C008','T'),
('JUEVES','7','9','C008','P'),
('VIERNES','8','9','C008','T'),

-- Aprendizaje Automatico
-- A
('LUNES'    ,'9','11','C009','T'),
('MIERCOLES','9','11','C009','P'),
('VIERNES'  ,'9','10','C009','T'),
-- B
('LUNES'    ,'17','19','C010','T'),
('MIERCOLES','17','19','C010','P'),
('VIERNES'  ,'18','19','C010','T');
GO

INSERT INTO TMatriculado(IDCatalogo, CodAlumno, Apellidos,Nombre) VALUES 
-- Fundamentos de programacion A
('C001',	'211355',	'AUCCACUSI-HUANCA','-PAUL ANDRÉ'	),
('C001',	'210919',	'BIGGERSTAFF-PUMACAHUA','-MEI-LING'	),
('C001',	'210920',	'BUENO-LESCANO','-ANDRIC JEREMY'	),
('C001',	'151832',	'CASTELLANOS-AMANQUI','-GEORGE SANTIAGO'	),
('C001',	'210928',	'ESTRADA-CUYTO','-BRANDON PAOLO'	),
('C001',	'194920',	'HUAMANI-CRIOLLO','-JUVENAL'	),
('C001',	'211857',	'HUISA-NINA','-YIMY YOHEL'	),
('C001',	'193807',	'JANCCO-CONCHA','-CESAR AUGUSTO'	),
('C001',	'200781',	'LIMPI-TINTA','-IVAN NESTOR'	),
('C001',	'210935',	'MERMA-CHURA','-JEANPIER XILANDER'	),
('C001',	'211858',	'MEZA-CHALLCO','-DYLAN PATRICK'	),
('C001',	'210937',	'MOTTA-MENDOZA','-PAVEL ALVARO'	),
('C001',	'211860',	'MUÑOZ-CENTENO','-MILDER'	),
('C001',	'211356',	'PALACIOS-DURAND','-ORIOL FERNANDO'	),
('C001',	'210939',	'PANTOJA-OLAVE','-GUSTAVO'	),
('C001',	'210179',	'PRIETO-CARDOSO','-DAVID FERNANDO'	),
('C001',	'211861',	'PUMA-CHAÑI','-JOSÉ LUIS'	),
('C001',	'210940',	'PUMACHOQUE-CHOQUENAIRA','-JHON ESAU'	),
('C001',	'211357',	'QQUENTE-ALVAREZ','-FRANK RODRIGO'	),
('C001',	'113547',	'QUINAYA-MEJIA','-RONY WILSON'),	
('C001',	'210941',	'QUISPE-CRUZ','-JOSE ARMAND'),	
('C001',	'211359',	'QUISPE-VENTURA','-IAN LOGAN WILL'),	
('C001',	'210411',	'RAMOS-ALVAREZ','-ISMAEL GERSON'),	
('C001',	'210942',	'RODRIGUEZ-PAUCCARA','-CRISTIAN DIEGO'),	
('C001',	'210412',	'ROMERO-BERNAL','-JHAMSID'),	
('C001',	'210413',	'SANCHEZ-ENCISO','-HORUS HUGO'),	
('C001',	'184210',	'TAPIA-QUISPE','-ANDRE WASHINGTON'),	
('C001',	'204807',	'TINOCO-CCOTO','-LUIS MANUEL'),	
('C001',	'211361',	'TORRE-CANO','-EDUARDO'),	
('C001',	'192430',	'TTITO-QUISPE','-ABELARDO'),	
('C001',	'211362',	'VALERIANO-HUACARPUMA','-LUIGUI FERNANDO'),	
('C001',	'210180',	'VILLALOBOS-USCA','-ANGHELO'),
-- Fundamentos de programacion B
('C002',	'204792',	'ACHAHUANCO-VALENZA','-ANDREE'	),
('C002',	'192414',	'BARRIENTOS-CRUZ','-CRISTHIAN'	),
('C002',	'210409',	'CASTILLA-VARGAS','-DAYANA ANGELA'	),
('C002',	'210921',	'CCAMA-ENRIQUEZ','-CAROLAY	'),
('C002',	'210922',	'CCASA-CCAHUANA','-FLOR DELIZ'	),
('C002',	'210923',	'CCOYO-MEJIA','-BRANDON'	),
('C002',	'210924',	'CUSI-DIAZ','-IBETH JANELA DEL PILAR'),	
('C002',	'210925',	'DENOS-LIVANO','-CRISTIAN PAUL'	),
('C002',	'210926',	'DURAN-HUAMAN','-YELSIN MAGIBEL'	),
('C002',	'210927',	'ENRIQUEZ-ARAMBURU','-JELIEL'	),
('C002',	'210929',	'GUTIERREZ-ALFARO','-RONALD EINAR'	),
('C002',	'081561',	'HUACANI -DE LA CRUZ','-DANY DARWIN'	),
('C002',	'211855',	'HUACHO-CRUZ','-DAVID ALI	'),
('C002',	'210930',	'HUAMAN-BERRIO','-FRANZ PAUL	'),
('C002',	'204798',	'HUARACALLO-ARENAS','-LINO ZEYNT'	),
('C002',	'211856',	'HUAYAPA-HUAMANÑAHUI','-OMAR'	),
('C002',	'183067',	'HUAYLLA-HUILLCA','-ROSSBEL'	),
('C002',	'191871',	'IBARRA-HUAMANCARI','-RAY MARCELO'	),
('C002',	'210931',	'KJUIRO-HUAMAN','-HJOVER ELSON'	),
('C002',	'210933',	'MAMANI-JARA','-JORGE LUIS'	),
('C002',	'194522',	'MAMANI-MESCCO','-LUIS ANTHONY'	),
('C002',	'210934',	'MAMANI-SALCEDO','-LIZETH CARLA'	),
('C002',	'210936',	'MONTAÑEZ-MEDINA','-DANIEL'	),
('C002',	'211859',	'MOREANO-VILLENA','-MIGUEL ANGEL'),	
('C002',	'204800',	'MUÑOZ-CASTILLO','-GEORGE IVANOK'),	
('C002',	'210410',	'PACCO-MAMANI','-MARLOM DIEGO'	),
('C002',	'210938',	'PALACIOS-YAPO','-ALAIN ANTHONY'	),
('C002',	'211862',	'QUISPE-ARQQUE','-ETNER YURY'	),
('C002',	'211358',	'QUISPE-HUILLCA','-JOHAM ESAU'),	
('C002',	'200339',	'QUISPE-HUITOCALLO','-GABRIE'	),
('C002',	'211360',	'ROZAS-CCASA','-VICTORIA FATIMA'	),
('C002',	'210943',	'SAIRE-HUAMAN','-ELIAS'	),
('C002',	'204809',	'TORRES-MENDOZA','-RAUL'	),
('C002',	'210944',	'USCAPI-PUCHO','-DIEGO EDU'),	
('C002',	'211863',	'YUCRA-CHURA','-ROY ELMER'),	
('C002',	'211363',	'YUCRA-MENDOZA','-LISBETH'	),
('C002',	'161534',	'ZEGARRA-ROJAS','-JORGE ENRIQUE'	),
('C002',	'204322',	'ZULOAGA-CCOPA','-NILSON LEONEL'),
-- Modelos Porbabilisticos A
('C003',	'194916',	'BACILIO-HUAMAN','-JEAN MARCO'	),
('C003',	'193027',	'BLANCO-MOZO','-CARMEN GUADALUPE'	),
('C003',	'071106',	'CCAHUANTICO-MENDOZA','-JULIO CESAR	'),
('C003',	'182727',	'CCAHUANTICO-NINAMEZA','-LUIS FERNANDO'	),
('C003',	'194516',	'CCAÑIHUA-LAYME','-ELIAZAR'	),
('C003',	'192417',	'CESPEDES-VILCA','-ANGEL LUIS'	),
('C003',	'193110',	'FIGUEROA-RODRIGUEZ','-ASTRID'	),
('C003',	'184199',	'GALLEGOS-CJUIRO','-LUIS ALBERTO'	),
('C003',	'194918',	'GAMARRA-FLORES','-DAYHANA LUCERO'	),
('C003',	'090215',	'GIBAJA-HUAYHUA','-JUAN CARLOS'	),
('C003',	'193834',	'GODOY-LACUTA','-CRISTIAN AYRTHON'	),
('C003',	'192420',	'GUEVARA-DELGADO','-TIRSSA IVONNE'	),
('C003',	'194919',	'HUAICOCHEA-CARDENAS','-WILBER EMANUEL'	),
('C003',	'194518',	'HUAMAN-JAIMES','-NICANOR'	),
('C003',	'194519',	'HUAMAN-QUISPE','-JEMY SANDRO'	),
('C003',	'184204',	'HUILLCA-QUISPE','-JOEL	'),
('C003',	'200334',	'LIMA-ESPERILLA','-KATERINE CANDY'	),
('C003',	'194520',	'LLAMOCCA-QUISPE','-FRANKLIN	'),
('C003',	'171938',	'LOPE-TORRES','-MARISOL'	),
('C003',	'194521',	'MALDONADO-CHALCO','-CRISTIAN DANIEL'),	
('C003',	'194523',	'MAMANI-MEZA','-JOHANA MARIA'	),
('C003',	'194524',	'MELENDRES-PEREZ','-CRISTINA'	),
('C003',	'160331',	'MOZO-DAVILA','-MILTON ADERLIN'	),
('C003',	'194525',	'PAREDES-CURASCO','-ARELI SHALON'	),
('C003',	'184780',	'PAUCCAR-BLANCO','-HAPMYR ERWIN'	),
('C003',	'183469',	'PIMENTEL-FRANCO','-GONZALO MARTIN'	),
('C003',	'171567',	'PUCLLA-HUAMAN','-DIANA STEPHANIE'	),
('C003',	'150495',	'QUISPE-CLEMENTE','-SAMAN'	),
('C003',	'194527',	'QUISPE-SANTA CRUZ','-YOEL SANDRO'),
('C003',	'141158',	'SAIRE-HANCCO','-CESAR ANDERSSON'	),
('C003',	'194921',	'SAMATA-PUMAHUALCCA','-CRISTHIAN'	),
('C003',	'194922',	'SILVA-GUEVARA','-ESTEFAN POL'	),
('C003',	'194529',	'TORRES-MAMANI','-GERSON'	),
('C003',	'191874',	'VALENCIA-ÑAUPA','-MARKO LEONEL'),
-- Modelos Probabilisticos B
('C004',	'175022',	'BAUTISTA-HURTADO','-OWEN DEISER'),
('C004',	'193830',	'CCALA-HUAMANI','-CRISTHIAN'),
('C004',	'192416',	'CCASANI-HUAMAN','-WILMAN'	),
('C004',	'174941',	'CHOQUENAIRA-GARCIA','-RONAL FRANKLIN'),
('C004',	'170431',	'CRUZ-CARRION','-JOSE LUIS'	),
('C004',	'174910',	'CUSI-HUAYLLA','-MIGUEL ANGEL'	),
('C004',	'130737',	'DIANDERAS-LOPEZ','-JHOHELLS ERICK'	),
('C004',	'194917',	'FLORES-CASTRO','-MARY CARMEN'),	
('C004',	'114141',	'FLORES-SANTOS','-YEREMI ANDREI'),
('C004',	'164241',	'GIRALDO-ENCISO','-DAVID'),
('C004',	'100511',	'GUTIERREZ-AMACHI','-JUAN CARLOS'),
('C004',	'191871',	'IBARRA-HUAMANCARI','-RAY MARCELO'),
('C004',	'164243',	'MACEDO-GHEILER','-SEBASTIAN ISRAEL'),
('C004',	'155182',	'MAR-GIBAJA','-RENATO'	),
('C004',	'155192',	'NUÑEZ-HUALL','-ALFREDO'),
('C004',	'174445',	'OLARTE-CASAS','-RODRIGO FABRICIO'),
('C004',	'193004',	'PARQUE-AROSQUIPA','-LENIN JOAQUIN'),
('C004',	'182931',	'QUISPE-MORA','-ANDERSON'),
('C004',	'141673',	'RAMOS-DELGADO','-SAMIRE'),
('C004',	'200826',	'RODRIGUEZ-PHILLCO','-JAIME ANTONIO'),
('C004',	'193129',	'TTITO-HUAMAN','-KEVIN JHOEL'),
('C004',	'182937',	'VELASQUEZ-DURAND','-HANS ROBERT'),
('C004',	'154630',	'YUCRA-VALDEZ','-YEFER YOSELIN'),
-- Metodologia de desarrollo de software A
('C005',	'114136',	'ALMIRON-GONZALES','-JUAN RAISER'	),
('C005',	'192664',	'APARICIO-CASTILLA','-BRAYAN GUSTAVO'	),
('C005',	'192997',	'ARCE-QUISPE','-RUTH MILAGROS'	),
('C005',	'113572',	'AUCAPIÑA-SUVIZARRETA','-EDWAR'	),
('C005',	'191870',	'CAHUATA-LAVILLA','-YOLMY MILAGROS'	),
('C005',	'192998',	'CARDENAS-HUAMAN','-FABRICIO YARED'	),
('C005',	'192999',	'CCONCHO-CASTELLANOS','-MIGUEL ANGEL'	),
('C005',	'184645',	'CCOTO-MACHACA','-EDWIN BRAYAN'	),
('C005',	'154632',	'CHAMPI-PUMA','-WILLIAM RUIZ'	),
('C005',	'182731',	'CHIRINOS-VILCA','-YERSON JOAB'	),
('C005',	'101658',	'CHOQUE-CCOA','-DENNIS ALIPIO'	),
('C005',	'193000',	'CHOQUELUQUE','-GARCIA-ALEJANDRO MIGUEL'	),
('C005',	'193832',	'CORTEZ-CCAHUANTICO','-PAOLA ANDREA'	),
('C005',	'120008',	'CUETO-SANCHEZ','-CARLA PALOMA'	),
('C005',	'192419',	'CUSI-QUISPE','-YANET'	),
('C005',	'192665',	'FERNANDEZ-MANDURA','-ROYER FUNACOSHI'	),
('C005',	'151812',	'FERRO-ALVAREZ','-JUSTINO'	),
('C005',	'182911',	'GAMARRA-HERRERA','-GABRIELA	'),
('C005',	'193001',	'GIFONE-VILLASANTE','-EDUARDO JUAREIS'	),
('C005',	'151835',	'HUAMAN-LONCONI','-MARCO ANTONIO'	),
('C005',	'112207',	'IBARRA-CASTILLO','-WALDO ERICK'	),
('C005',	'192424',	'MACCARCCO-QUISPE','-KAROL GIANELLA	'),
('C005',	'174856',	'MAMANI-HUAMAN','-KALEB GEDEON'	),
('C005',	'192666',	'MELENDEZ-MENDIGURE','-EDWARD'	),
('C005',	'182921',	'MOLLINEDO-PEÑA','-ALVARO SEBASTIAN'	),
('C005',	'110071',	'MUNIVE-SALAS','-CIRO'	),
('C005',	'174913',	'NAOLA-PUMA','-EDWARD BRAYAN'	),
('C005',	'141677',	'NINAHUANCA','-CHOQUE-JUAN CARLOS'	),
('C005',	'184652',	'PANDO-MUÑOZ','-ROSWELL JAIME'	),
('C005',	'141671',	'PAREDES-DENOS','-VICTOR ANIVAL'	),
('C005',	'191873',	'PUMA-HUAMANI','-GLINA DE LA FLOR'	),
('C005',	'171524',	'PUMACAHUA','-APAZA-LEONARDO CHEPPER'),	
('C005',	'160332',	'QUISPE-JIMENEZ','-MIGUEL ANGEL'	),
('C005',	'171917',	'RAMOS-BANDA','-SANDRO'	),
('C005',	'174864',	'RAMOS-CONDORI','-DANNY'),
('C005',	'120897',	'TELLO-JUSTINIANI','-LUIS DAVID	'),
('C005',	'184211',	'TINCUSI-CCORIMANYA','-JHON JAIME'),
('C005',	'163813',	'VIZCARRA-VARGAS','-MARCELO ANGELO'),


('C006','182898','CERATI CERRILLO','FIORELLA'),
('C006','125156','CONDORI FLORES WILLIAMS','DENNIS'),
('C006','163839','CORAZAO HINOJOSA','REISON DARIO'),
('C006','170430','COVARRUBIAS AGUILAR','GEREMY ANDRE'),
('C006','170750','CUSIHUAMAN AUCCACUSI','LUIS ALDAIR'),
('C006','182908','ESPINOZA CHAMPI','ISRAEL ENRIQUE'),
('C006','174443','FARFAN MOSCOSO','JUAN VICTOR'),
('C006','151812','FERRO ALVAREZ','JUSTINO'),
('C006','171059','FLORES IGNACIO','JOSE LUIS'),
('C006','184648','GALICIA CENTENO','EDSON RAUL'),
('C006','171061','GUEVARA FERRO','CRISTIAN LUIS'),
('C006','163808','LOZANO LLACCTAHUAMAN','ROYER BRANDON'),
('C006','130741','MERMA QUISPE','HAROL HELBERT'),
('C006','154631','NOLASCO SUYO','CARLOS ANTONI'),
('C006','182925','OLIVARES CAMERO','ALER SEBASTIAN'),
('C006','182926','ORTEGA SULLCACCORI','ACCENT BLADIMIR'),
('C006','141671','PAREDES DENOS','VICTOR ANIVAL'),
('C006','171066','QUINTO CATACHURA','LADY DIANA'),
('C006','171067','QUISPE SERRANO','HILLARY CRISTINA'),
('C006','161135','QUISPE TACURI','RUDI'),
('C006','171260','QUISPE TTITO','JOEL WILLY'),
('C006','192428','RADO HUAYOTUMA','ARTUR MARTI'),
('C006','163671','ROBLES SILVA','ANGELO'),
('C010','171605','SALINAS ATAUSINCHI','JERSON'),
('C010','184655','SANCA ZEVALLOS','JERY'),
('C010','141011','SIPAUCAR CONDORI','MARITZA MARIBEL'),	
('C010','182938','VILLAFUERTE GARCES','EDU RODRIGO'),
('C010','145009','YCHU VALENCIA','MIGUEL HUMBERTO'),
('C010','182941','YUCA LIMA','KARLA URBELINDA'),
('C010','950610','ANDRADE ESCOBAR','LUIS'),
('C010','131605','AYQUIPA GOMEZ','AMILCAR'),
('C010','130516','BUSTAMANTE MAMANI','WASHINGTON MARCO'),
('C010','170749','CARMONA CHOQUEMAMANI','KENNY HAROLD'),
('C010','170428','CASSA LIPA','EDWAR YURI'),
('C010','161756','CCONISLLA MEDINa','ANTHONY ALDAIR'),
('C010','174440','CONDORI OCHOA','GIOVDEY ABRAHAM'),
('C010','182909','ESTRELLA VILCA','JAMES KEVIN'),
('C010','182910','FLORES ROBLES','KATHERYNE SHARMELLY'),
('C010','182914','HUAMAN MENDOZA','ELVIS JORGE'),
('C010','112207','IBARRA CASTILLO','WALDO ERICK'),
('C010','170436','LUYCHO ANCAIFURO','MARIELA'),
('C010','163809','MAMANI CHINO','RUBEN'),
('C010','164566','MAMANI QUINTA','MICHAEL ANTONNI'),
('C010','182923','MORA CCARHUARUPAY','LUZ LUCERO'),
('C010','171064','ORE GAMARRA','ABRAHAM BENJAMIN'),
('C010','101526','ORUE QUISPE','ALVARO AMERICO'),
('C010','130322','PEREZ TOMAYLLA','BRUNO'),
('C010','151822','PUMA MAMANI','NILSON MAURIO'),
('C010','151780','QUISPE PUMA','LUCERO'),
('C010','101664','QUISPE RODRIGUEZ','LUIS ALEXEI'),
('C010','171069','RODRIGUEZ OJEDA','JORGE VICTOR'),
('C010','174454','TINTAYA TACO','YUREMA LISBETH'),
('C010','083221','TRUJILLO TORBISCO','LUIS ANDERSON'),
('C010','174455','UGARTE CASTILLO','BRIGGITTE LEONOR'),
('C010','182936','USUCACHI ANO','ISAC ANDERSON'),
('C010','155183','VARGAS ARQQUE','JEREMYK RUFINO');
GO

INSERT INTO TPlanSesiones (Unidad,Capitulo,Tema,HorasProgramadas,Finalizado,IDCatalogo,Observacion) VALUES 
('1°UNIDAD','Capitulo0','Presentacion de Silabo','02','NO','C006',''),--Fundamentos de programacion(profe doris)
('1°UNIDAD','Capitulo0','Examen de entrada','02','NO','C006',''),
('1°UNIDAD','Capitulo0','Información complememtaria','01','NO','C006',''),--semana0
-- 1°parcial
('1°UNIDAD','Capitulo1','Tema1_1_Teoria','02','NO','C006',''),
('1°UNIDAD','Capitulo1','Tema1_1_Laboratorio','02','NO','C006',''),
('1°UNIDAD','Capitulo1','Tema1_2_Teoria_1','01','NO','C006',''),--semana1
('1°UNIDAD','Capitulo1','Tema1_2_Teoria_2','02','NO','C006',''),
('1°UNIDAD','Capitulo1','Tema1_2_Laboratorio','02','NO','C006',''),
('1°UNIDAD','Capitulo1','Repaso Capitulo1','01','NO','C006',''),--semana2
('1°UNIDAD','Capitulo2','Tema2_1_Teoria_2','02','NO','C006',''),
('1°UNIDAD','Capitulo2','Tema2_1_Laboratorio','02','NO','C006',''),
('1°UNIDAD','Capitulo2','Tema2_2_Teoria_1','01','NO','C006',''),--semana3
('1°UNIDAD','Capitulo2','Tema2_2_Teoria_2','02','NO','C006',''),
('1°UNIDAD','Capitulo2','Tema2_2_Laboratorio','02','NO','C006',''),
('1°UNIDAD','Capitulo2','Repaso Capitulo2','01','NO','C006',''),--semana4
('1°UNIDAD','---------','Examen Parcial','02','NO','C006',''),
('1°UNIDAD','---------','Revision Examen Parcial I','02','NO','C006',''),
('1°UNIDAD','---------','Entrega de Notas','01','NO','C006',''),--semana5
--2° parcial
('2°UNIDAD','Capitulo3','Tema3_1_Teoria','02','NO','C006',''),
('2°UNIDAD','Capitulo3','Tema3_1_Laboratorio','02','NO','C006',''),
('2°UNIDAD','Capitulo3','Tema3_2_Teoria_1','01','NO','C006',''),--semana6
('2°UNIDAD','Capitulo3','Tema3_2_Teoria_2','02','NO','C006',''),
('2°UNIDAD','Capitulo3','Tema3_2_Laboratorio','02','NO','C006',''),
('2°UNIDAD','Capitulo3','Repaso Capitulo3','01','NO','C006',''),--semana7
('2°UNIDAD','Capitulo4','Tema4_1_Teoria_2','02','NO','C006',''),
('2°UNIDAD','Capitulo4','Tema4_1_Laboratorio','02','NO','C006',''),
('2°UNIDAD','Capitulo4','Tema4_2_Teoria_1','01','NO','C006',''),--semana8
('2°UNIDAD','Capitulo4','Tema4_2_Teoria_2','02','NO','C006',''),
('2°UNIDAD','Capitulo4','Tema4_2_Laboratorio','02','NO','C006',''),
('2°UNIDAD','Capitulo4','Repaso','01','NO','C006',''),--semana9
('2°UNIDAD','---------','Examen Parcial','02','NO','C006',''),
('2°UNIDAD','---------','Revision Examen Parcial I','02','NO','C006',''),
('2°UNIDAD','---------','Entrega de Notas','01','NO','C006',''),--semana10
--3° parcial
('3°UNIDAD','Capitulo5','Tema5_1_Teoria','02','NO','C006',''),
('3°UNIDAD','Capitulo5','Tema5_1_Laboratorio','02','NO','C006',''),
('3°UNIDAD','Capitulo5','Tema5_2_Teoria_1','01','NO','C006',''),--semana11
('3°UNIDAD','Capitulo5','Tema5_2_Teoria_2','02','NO','C006',''),
('3°UNIDAD','Capitulo5','Tema5_2_Laboratorio','02','NO','C006',''),
('3°UNIDAD','Capitulo5','Repaso Capitulo5','01','NO','C006',''),--semana12
('3°UNIDAD','Capitulo6','Tema6_1_Teoria_2','02','NO','C006',''),
('3°UNIDAD','Capitulo6','Tema6_1_Laboratorio','02','NO','C006',''),
('3°UNIDAD','Capitulo6','Tema6_2_Teoria_1','01','NO','C006',''),--semana13
('3°UNIDAD','Capitulo6','Tema6_2_Teoria_2','02','NO','C006',''),
('3°UNIDAD','Capitulo6','Tema6_2_Laboratorio','02','NO','C006',''),
('3°UNIDAD','Capitulo6','Repaso Capitulo6','01','NO','C006',''),--semana14
('3°UNIDAD','---------','Examen Parcial','02','NO','C006',''),
('3°UNIDAD','---------','Revision Examen Parcial I','02','NO','C006',''),
('3°UNIDAD','---------','Entrega de Notas','01','NO','C006',''),--semana15

---C0010 -> MÉTODOS NUMÉRICOS
--(Unidad,Capitulo,Tema,HorasProgramadas,Fecha,Finalizado,IDCatalogo)
('1°UNIDAD','Capitulo0','Presentacion de Silabo','02','SI','C010',''),
('1°UNIDAD','Capitulo0','Examen de entrada','02','SI','C010',''),
('1°UNIDAD','Capitulo0','Información complememtaria','01','SI','C010',''),
-- 1°parcial
('1°UNIDAD','Capitulo1','Introducción y Teoría de Errores','04','NO','C010',''),
('1°UNIDAD','Capitulo2','Series de Taylor','04','NO','C010',''),
('1°UNIDAD','Capitulo3','Resolución de Ecuaciones no Lineales','08','NO','C010',''),
('1°UNIDAD','Capitulo4','Resolución de Sistemas de Ecuaciones Lineales','08','NO','C010',''),
('1°UNIDAD','Capitulo5','Aproximación Polinomial e Interpolación - Parte 1','04','NO','C010',''),
('1°UNIDAD','','Examen Parcial I','02','NO','C010',''),
('1°UNIDAD','','Revision Examen Parcial I','02','NO','C010',''),
('1°UNIDAD','','Entrega de Notas','01','NO','C010',''),--semana15

-- 2°parcial
('2°UNIDAD','Capitulo5','Aproximación Polinomial e Interpolación - Parte 2','04','NO','C010',''),
('2°UNIDAD','Capitulo6','Diferenciación Numérica','04','NO','C010',''),
('2°UNIDAD','Capitulo7','Integración Numérica','08','NO','C010',''),
('2°UNIDAD','Capitulo8','Ecuaciones Diferenciales Ordinarias','08','NO','C010',''),
('2°UNIDAD','','Examen Parcial II','02','NO','C010',''),
('2°UNIDAD','','Revision Examen Parcial II','02','NO','C010',''),
('2°UNIDAD','','Entrega de Notas','01','NO','C010','');--semana15

INSERT INTO TPlanSesiones (Unidad,Capitulo,Tema,HorasProgramadas,Finalizado,IDCatalogo,Observacion) VALUES
-- C001 -> DEEP LEARNING
('1°UNIDAD','Capitulo0','Presentacion de Silabo','02','NO','C001',''),-- Deep Learning(profe Boris)
('1°UNIDAD','Capitulo0','Examen de entrada','02','NO','C001',''),
('1°UNIDAD','Capitulo0','Información complememtaria','01','NO','C001',''),--semana0
-- 1°parcial
('1°UNIDAD','Capitulo1','Tema1_1_Teoria','02','NO','C001',''),
('1°UNIDAD','Capitulo1','Tema1_1_Laboratorio','02','NO','C001',''),
('1°UNIDAD','Capitulo1','Tema1_2_Teoria_1','01','NO','C001',''),--semana1
('1°UNIDAD','Capitulo1','Tema1_2_Teoria_2','02','NO','C001',''),
('1°UNIDAD','Capitulo1','Tema1_2_Laboratorio','02','NO','C001',''),
('1°UNIDAD','Capitulo1','Repaso Capitulo1','01','NO','C001',''),--semana2
('1°UNIDAD','Capitulo2','Tema2_1_Teoria_2','02','NO','C001',''),
('1°UNIDAD','Capitulo2','Tema2_1_Laboratorio','02','NO','C001',''),
('1°UNIDAD','Capitulo2','Tema2_2_Teoria_1','01','NO','C001',''),--semana3
('1°UNIDAD','Capitulo2','Tema2_2_Teoria_2','02','NO','C001',''),
('1°UNIDAD','Capitulo2','Tema2_2_Laboratorio','02','NO','C001',''),
('1°UNIDAD','Capitulo2','Repaso Capitulo2','01','NO','C001',''),--semana4
('1°UNIDAD','---------','Examen Parcial','02','NO','C001',''),
('1°UNIDAD','---------','Revision Examen Parcial I','02','NO','C001',''),
('1°UNIDAD','---------','Entrega de Notas','01','NO','C001',''),--semana5
--2° parcial
('2°UNIDAD','Capitulo3','Tema3_1_Teoria','02','NO','C001',''),
('2°UNIDAD','Capitulo3','Tema3_1_Laboratorio','02','NO','C001',''),
('2°UNIDAD','Capitulo3','Tema3_2_Teoria_1','01','NO','C001',''),--semana6
('2°UNIDAD','Capitulo3','Tema3_2_Teoria_2','02','NO','C001',''),
('2°UNIDAD','Capitulo3','Tema3_2_Laboratorio','02','NO','C001',''),
('2°UNIDAD','Capitulo3','Repaso Capitulo3','01','NO','C001',''),--semana7
('2°UNIDAD','Capitulo4','Tema4_1_Teoria_2','02','NO','C001',''),
('2°UNIDAD','Capitulo4','Tema4_1_Laboratorio','02','NO','C001',''),
('2°UNIDAD','Capitulo4','Tema4_2_Teoria_1','01','NO','C001',''),--semana8
('2°UNIDAD','Capitulo4','Tema4_2_Teoria_2','02','NO','C001',''),
('2°UNIDAD','Capitulo4','Tema4_2_Laboratorio','02','NO','C001',''),
('2°UNIDAD','Capitulo4','Repaso','01','NO','C006',''),--semana9
('2°UNIDAD','---------','Examen Parcial','02','NO','C001',''),
('2°UNIDAD','---------','Revision Examen Parcial I','02','NO','C001',''),
('2°UNIDAD','---------','Entrega de Notas','01','NO','C001',''),--semana10
--3° parcial
('3°UNIDAD','Capitulo5','Tema5_1_Teoria','02','NO','C001',''),
('3°UNIDAD','Capitulo5','Tema5_1_Laboratorio','02','NO','C001',''),
('3°UNIDAD','Capitulo5','Tema5_2_Teoria_1','01','NO','C001',''),--semana11
('3°UNIDAD','Capitulo5','Tema5_2_Teoria_2','02','NO','C001',''),
('3°UNIDAD','Capitulo5','Tema5_2_Laboratorio','02','NO','C001',''),
('3°UNIDAD','Capitulo5','Repaso Capitulo5','01','NO','C001',''),--semana12
('3°UNIDAD','Capitulo6','Tema6_1_Teoria_2','02','NO','C001',''),
('3°UNIDAD','Capitulo6','Tema6_1_Laboratorio','02','NO','C001',''),
('3°UNIDAD','Capitulo6','Tema6_2_Teoria_1','01','NO','C001',''),--semana13
('3°UNIDAD','Capitulo6','Tema6_2_Teoria_2','02','NO','C001',''),
('3°UNIDAD','Capitulo6','Tema6_2_Laboratorio','02','NO','C001',''),
('3°UNIDAD','Capitulo6','Repaso Capitulo6','01','NO','C001',''),--semana14
('3°UNIDAD','---------','Examen Parcial','02','NO','C001',''),
('3°UNIDAD','---------','Revision Examen Parcial I','02','NO','C001',''),
('3°UNIDAD','---------','Entrega de Notas','01','NO','C001','');--semana15
GO

----Silabos insertar-
--exec SP_GuardarSilabo 'C:\Users\LUCERO\Downloads\Silabos\FUNDAMENTOS DE LA PROGRAMACION.pdf','C006'
--exec SP_GuardarSilabo 'C:\Users\LUCERO\Downloads\Silabos\Métodos Numéricos2.pdf','C010'

--insertar datos LISTA DE ALUMNOS - Docente Doris
--exec SP_GuardarArchivo 'FUNDAMENTOS DE PROGRAMACION','E:\Projects - University\Ingeniería de Software\AppGestion\ListaAlumnosCursos\Lista1.xls','E:\Projects - University\Ingeniería de Software\AppGestion\ListaAlumnosCursos\Lista1.xls','C006'
--exec SP_GuardarArchivo 'METODOS NUMERICOS','E:\Projects - University\Ingeniería de Software\AppGestion\ListaAlumnosCursos\Lista2.xls','E:\Projects - University\Ingeniería de Software\AppGestion\ListaAlumnosCursos\Lista2.xls','C010'
--exec SP_GuardarArchivo 'FUNDAMENTOS DE PROGRAMACION','D:\Semestre 2021-2\Ingenieria del Software I\AppGestion\ListaAlumnosCursos\Lista1.xls','C006'
--go
--exec SP_GuardarArchivo 'METODOS NUMERICOS','D:\Semestre 2021-2\Ingenieria del Software I\AppGestion\ListaAlumnosCursos\Lista2.xls','C010'
--GO
--exec SP_ListarArchivo 'C006'
--exec SP_LISTARCURSOSXDOCENTE 'D0004'

--delete from TAsistencia_Alumnos
--insert into TAsistencia_Alumnos(Fecha,IdCatalogo,CodAlumno,Nombres,Asistio,Observacion) values
--('03/01/2022','C006','182898','CERATI CERILLO FIORELA','P',' '),
--('05/01/2022','C006','182898','CERATI CERILLO FIORELA','F',' '),
--('07/01/2022','C006','182898','CERATI CERILLO FIORELA','F',' '),
--('10/01/2022','C006','182898','CERATI CERILLO FIORELA','P',' '),
--('03/01/2022','C006','125156','CONDORI FLORES WILLIAMS DENNIS','P',' '),
--('05/01/2022','C006','125156','CONDORI FLORES WILLIAMS DENNIS','P',' '),
--('07/01/2022','C006','125156','CONDORI FLORES WILLIAMS DENNIS','P',' '),
--('10/01/2022','C006','125156','CONDORI FLORES WILLIAMS DENNIS','F',' '),
--('03/01/2022','C006','163839','CORAZAO HINOJOSA REISON DARIO','P',' '),
--('05/01/2022','C006','163839','CORAZAO HINOJOSA REISON DARIO','P',' '),
--('07/01/2022','C006','163839','CORAZAO HINOJOSA REISON DARIO','P',' '),
--('10/01/2022','C006','163839','CORAZAO HINOJOSA REISON DARIO','F',' '),
--('03/01/2022','C006','170430','COVARRUBIAS AGUILAR GEREMY ANDRE','P',' '),
--('05/01/2022','C006','170430','COVARRUBIAS AGUILAR GEREMY ANDRE','P',' '),
--('07/01/2022','C006','170430','COVARRUBIAS AGUILAR GEREMY ANDRE','F',' ')
--go


