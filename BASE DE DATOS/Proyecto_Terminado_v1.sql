CREATE DATABASE PROYECTOv15;
GO
USE PROYECTOv15;
GO

-----CREACION DE LAS TABLAS DE ACUERDO AL DIAGRAMA NORMALIZADO

CREATE TABLE HORARIOEVENTO(
id INT PRIMARY KEY not null,
f_h_apertura SMALLDATETIME not null,
f_h_cierre SMALLDATETIME not null
);

--DROP DATABASE PROYECTOv15

CREATE TABLE HORARIOAREA(
id INT PRIMARY KEY not null,
h_abierto TIME not null
);

CREATE TABLE TIPOCOLECCION(
id INT PRIMARY KEY not null,
nombre VARCHAR(100) not null
);

CREATE TABLE EDITORIALEJEMPLAR(
id INT PRIMARY KEY not null,
nombre VARCHAR(100) not null
);

CREATE TABLE FORMATOEJEMPLAR(
id INT PRIMARY KEY not null,
nonbre VARCHAR(100) not null
);

CREATE TABLE OCUPACIONUSUARIO(
id INT PRIMARY KEY not null,
nombre VARCHAR(100) not null
);

CREATE TABLE INSTITUCIONUSUARIO(
id INT PRIMARY KEY not null,
nombre VARCHAR(100) not null
);

CREATE TABLE EVENTO(
id INT PRIMARY KEY not null,
titulo VARCHAR(100) not null,
objetivo VARCHAR(100) not null,
cantidad VARCHAR(100) not null,
id_horarioevento INT not null
);

CREATE TABLE AREA(
id INT PRIMARY KEY not null,
nombre VARCHAR(100) not null,
descripcion VARCHAR(100) not null,
nombre_responsable VARCHAR(100) not null,
capacidad VARCHAR(100) not null,
id_horarioarea INT not null
);

CREATE TABLE COLECCION(
id INT PRIMARY KEY not null,
nombre VARCHAR(100) not null,
id_tipocoleccion INT not null
);

CREATE TABLE EJEMPLAR(
codigo INT PRIMARY KEY not null,
autor VARCHAR(100) not null,
f_publicacion DATE not null,
nombre VARCHAR(100) not null,
id_editorialejemplar INT not null,
id_coleccion INT not null
);

CREATE TABLE USUARIO(
carnet INT PRIMARY KEY not null,
email VARCHAR(50) not null,
direccion VARCHAR(100) not null,
nombre VARCHAR(100) not null,
codigo_ejemplar INT not null,
id_ocupacionusuario INT not null,
id_institucionusuario INT not null
);

CREATE TABLE SESION(
id INT PRIMARY KEY not null,
f_h_inicio SMALLDATETIME not null,
f_h_cierre SMALLDATETIME not null,
carnet_usuario INT not null
);

CREATE TABLE REGISTROASISTENCIA(
carnet_usuario INT not null,
id_area INT not null,
id_evento INT not null,
PRIMARY KEY CLUSTERED (carnet_usuario, id_area, id_evento),
f_h_entrada SMALLDATETIME not null,
f_h_salida SMALLDATETIME not null
);

CREATE TABLE PRESTAMO(
carnet_usuario INT not null,
codigo_ejemplar INT not null,
PRIMARY KEY CLUSTERED (carnet_usuario, codigo_ejemplar),
f_h_prestamo SMALLDATETIME not null,
f_h_devolucion SMALLDATETIME not null
);

CREATE TABLE RESERVA(
carnet_usuario INT not null,
codigo_ejemplar INT not null,
PRIMARY KEY CLUSTERED (carnet_usuario, codigo_ejemplar),
f_h_reserva SMALLDATETIME not null,
f_h_devolucion SMALLDATETIME not null
);

CREATE TABLE TELEFONOUSUARIO(
id INT PRIMARY KEY not null,
numero VARCHAR(12) not null,
carnet_usuario INT not null
);

CREATE TABLE GENEROCOLECCION(
id INT PRIMARY KEY not null,
Fantasia VARCHAR(10) not null,
CienciaFiccion VARCHAR(10) not null,
Historia VARCHAR(10) not null,
Realista VARCHAR(10) not null,
Romantico VARCHAR(10) not null,
Suspenso VARCHAR(10) not null,
Policiaco VARCHAR(10) not null,
Drama VARCHAR(10) not null,
Psicologico VARCHAR(10) not null,
Comedia VARCHAR(10) not null,
id_coleccion INT not null
);

CREATE TABLE IDENTIFICADOREJEMPLAR(
id INT PRIMARY KEY not null,
ISBN VARCHAR(20) not null,
ISSN VARCHAR(20) not null,
DOI VARCHAR(20) not null,
codigo_ejemplar INT not null
);

CREATE TABLE IDIOMAEJEMPLAR(
id INT PRIMARY KEY not null,
Espanol VARCHAR(10) not null,
Ingles VARCHAR(10) not null,
Aleman VARCHAR(10) not null,
Frances VARCHAR(10) not null,
Italiano VARCHAR(10) not null,
Japones VARCHAR(10) not null,
Portugues VARCHAR(10) not null,
Arabe VARCHAR(10) not null,
codigo_ejemplar INT not null
);

-----CREACION DE LAS FK EN LAS TABLAS CORRESPONDIENTES

ALTER TABLE EVENTO
ADD CONSTRAINT FK_EVENTO_HORARIOEVENTO
FOREIGN KEY (id_horarioevento) REFERENCES HORARIOEVENTO (id);

ALTER TABLE AREA
ADD CONSTRAINT FK_AREA_HORARIOAREA
FOREIGN KEY (id_horarioarea) REFERENCES HORARIOAREA (id);

ALTER TABLE COLECCION
ADD CONSTRAINT FK_COLECCION_TIPOCOLECCION
FOREIGN KEY (id_tipocoleccion) REFERENCES TIPOCOLECCION (id);

ALTER TABLE EJEMPLAR
ADD CONSTRAINT FK_EJEMPLAR_EDITORIALEJEMPLAR
FOREIGN KEY (id_editorialejemplar) REFERENCES EDITORIALEJEMPLAR (id);

ALTER TABLE EJEMPLAR
ADD CONSTRAINT FK_EJEMPLAR_COLECCION
FOREIGN KEY (id_coleccion) REFERENCES COLECCION (id);

ALTER TABLE USUARIO
ADD CONSTRAINT FK_USUARIO_EJEMPLAR
FOREIGN KEY (codigo_ejemplar) REFERENCES EJEMPLAR (codigo);

ALTER TABLE USUARIO
ADD CONSTRAINT FK_USUARIO_OCUPACIONUSUARIO
FOREIGN KEY (id_ocupacionusuario) REFERENCES OCUPACIONUSUARIO (id);

ALTER TABLE USUARIO
ADD CONSTRAINT FK_USUARIO_INSTITUCIONUSUARIO
FOREIGN KEY (id_institucionusuario) REFERENCES INSTITUCIONUSUARIO (id);

ALTER TABLE SESION
ADD CONSTRAINT FK_SESION_USUARIO
FOREIGN KEY (carnet_usuario) REFERENCES USUARIO (carnet);

ALTER TABLE REGISTROASISTENCIA
ADD CONSTRAINT FK_REGISTROASISTENCIA_USUARIO
FOREIGN KEY (carnet_usuario) REFERENCES USUARIO (carnet);

ALTER TABLE REGISTROASISTENCIA
ADD CONSTRAINT FK_REGISTROASISTENCIA_AREA
FOREIGN KEY (id_area) REFERENCES AREA (id);

ALTER TABLE REGISTROASISTENCIA
ADD CONSTRAINT FK_REGISTROASISTENCIA_EVENTO
FOREIGN KEY (id_evento) REFERENCES EVENTO (id);

ALTER TABLE PRESTAMO
ADD CONSTRAINT FK_PRESTAMO_USUARIO
FOREIGN KEY (carnet_usuario) REFERENCES USUARIO (carnet);

ALTER TABLE PRESTAMO
ADD CONSTRAINT FK_PRESTAMO_EJEMPLAR
FOREIGN KEY (codigo_ejemplar) REFERENCES EJEMPLAR (codigo);

ALTER TABLE RESERVA
ADD CONSTRAINT FK_RESERVA_USUARIO
FOREIGN KEY (carnet_usuario) REFERENCES USUARIO (carnet);

ALTER TABLE RESERVA
ADD CONSTRAINT FK_RESERVA_EJEMPLAR
FOREIGN KEY (codigo_ejemplar) REFERENCES EJEMPLAR (codigo);

ALTER TABLE TELEFONOUSUARIO
ADD CONSTRAINT FK_TELEFONOUSUARIO_USUARIO
FOREIGN KEY (carnet_usuario) REFERENCES USUARIO (carnet);

ALTER TABLE GENEROCOLECCION
ADD CONSTRAINT FK_GENEROCOLECCION_COLECCION
FOREIGN KEY (id_coleccion) REFERENCES COLECCION (id);

ALTER TABLE IDENTIFICADOREJEMPLAR
ADD CONSTRAINT FK_IDENTIFICADOREJEMPLAR_EJEMPLAR
FOREIGN KEY (codigo_ejemplar) REFERENCES EJEMPLAR (codigo);

ALTER TABLE IDIOMAEJEMPLAR
ADD CONSTRAINT FK_IDIOMAEJEMPLAR_EJEMPLAR
FOREIGN KEY (codigo_ejemplar) REFERENCES EJEMPLAR (codigo);

-----EN ESTE MOMENTO SE PROCEDE A INSERTAR LOS DATOS CORRESPONDIENTES A LAS TABLAS Y SUS CAMPOS

GO

INSERT INTO
HORARIOEVENTO(id, f_h_apertura, f_h_cierre)
VALUES
(111, '2022/07/04 7:30', '2022/07/04 15:00'),
(112, '2022/07/05 7:30', '2022/07/05 16:00'),
(113, '2022/07/06 8:00', '2022/07/06 19:00'),
(114, '2022/07/07 8:00', '2022/07/07 15:00'),
(115, '2022/07/08 6:00', '2022/07/08 16:00'),
(116, '2022/07/09 9:00', '2022/07/09 13:00'),
(117, '2022/07/10 8:30', '2022/07/10 20:00')
;

INSERT INTO
HORARIOAREA(id, h_abierto)
VALUES
(10, '7:00:00'),
(20, '7:00:00'),
(30, '7:30:00'),
(40, '7:30:00'),
(50, '5:30:00'),
(60, '8:30:00'),
(70, '8:00:00')
;

INSERT INTO
TIPOCOLECCION(id, nombre)
VALUES
(130, 'Libros'),
(131, 'Revistas'),
(132, 'Periodicos'),
(133, 'Memorias'),
(134, 'Albumes'),
(135, 'Tesis'),
(136, 'Audio'),
(137, 'Video')
;

INSERT INTO
EDITORIALEJEMPLAR(id, nombre)
VALUES
(500, 'De Conatus'),
(510, 'Hiperi�n'),
(520, 'N�rdica'),
(530, 'Blackie Books'),
(540, 'Editorial Mirahadas'),
(550, 'Santillana'),
(560, 'Renacimiento'),
(570, 'Min�scula'),
(580, 'Tabla resumen'),
(590, 'Visor')
;

INSERT INTO
FORMATOEJEMPLAR(id, nonbre)
VALUES
(1, 'Disponible tanto en Digital como Fisico'),
(2, 'Disponible solo en Fisico'),
(3, 'Disponible solo en Digital'),
(4, 'No disponible en ningun formato')
;

INSERT INTO
OCUPACIONUSUARIO(id, nombre)
VALUES
(41, 'Solo Estudio'),
(42, 'Solo Trabajo')
;

INSERT INTO
INSTITUCIONUSUARIO(id, nombre)
VALUES
(1, 'Skidoo'),
(2, 'Browsebug'),
(3, 'Skilith'),
(4, 'Rhynyx'),
(5, 'Innojam'),
(6, 'Digitube'),
(7, 'Zoomdog'),
(8, 'Vinder'),
(9, 'Skipfire'),
(10, 'Thoughtsphere')
;

INSERT INTO
EVENTO(id, titulo, objetivo, cantidad, id_horarioevento)
VALUES
(200, 'Juegos y Diverion', 'Actuar como centro de diversion para los hijos de las personas que exploran el campus', '100', 117),
(210, 'Feria Teatral', 'Analizar las diferentes perspectivas sobre la organizacion de las mismas', '110', 116),
(220, 'El Cine de los 80�s', 'Interpretar los papeles desde la perspectiva de las nuevas visiones de los jovenes', '50', 115),
(230, 'Juegos VR', 'Otorgar un espacio de diversion a nivel casual y semi-competitivo entre los jovenes', '125', 114),
(240, 'Charlando Tranquilamente', 'Fomentar un espacio en donde se ense�en tecnicas de charla', '75', 113),
(250, 'CONIA', 'Motivar al cuerpo estudiantil sobre posibles campos de estudio', '100', 112),
(260, 'Feria del Libro', 'Promover el arte de la lectura mediante un divertido dia de libros', '25', 111)
;

INSERT INTO
AREA(id, nombre, descripcion, nombre_responsable, capacidad, id_horarioarea)
VALUES
(71, 'Salones l�dicos', 'Zona para los peque�os', 'Tulio Trivi�o', '150', 10),
(72, 'Audit�rium', 'Zona para hacer conferencias y trabajos a gran escala', 'Maria Antonieta', '358', 20),
(73, 'Sala de proyecci�n', 'Zona para estudios y videos', 'Clarence Buttowski', '200', 30),
(74, '�rea de computaci�n', 'Zona para los cursos de informatica', 'Yoel Ram�rez', '40', 40),
(75, '�rea de promoci�n de inclusi�n', 'Zona de relajacion', 'Roberto Bola�os', '30', 50),
(76, 'Sala de investigaci�n', 'Zona de para reuniones de equipo de trabajo', 'IanFlynn', '100', 60),
(77, '�rea de biblioteca', 'Zona de libros', 'Juan Carlos Bodoque', '250', 70)
;

INSERT INTO
COLECCION(id, nombre, id_tipocoleccion)
VALUES
(301, 'Seccion general', 130),
(302, 'Revistas de informacion general', 131),
(303, 'Informacion actualizada general', 132),
(304, 'Bibliografias', 133),
(305, 'Mangas y Comics', 134),
(306, 'Investigaciones Oficializadas', 135),
(307, 'Los 90�s', 136),
(308, 'Oscars', 137)
;

INSERT INTO
EJEMPLAR(codigo, autor, f_publicacion, nombre, id_editorialejemplar, id_coleccion)
VALUES
(001, 'Juan Sol�s', '2022/06/15', 'Las claves de una buena demanda contencioso-administrativa', 500, 301),
(002, 'Alberto Corta', '2022/05/02', 'Las lagrimas de Julieta', 500, 301),
(003, 'Alvaro Moreno', '2022/05/23', 'C�mo entender el arte contempor�neo', 500, 301),
(004, 'Sonia Aguilar', '2022/05/30', 'Emilio Castelar. Mi vida', 500, 301),
(005, 'Andres Orellana', '2022/05/16', 'Retrato de mujer (Con hombre al fondo)', 510, 301),
(006, 'Terence Flores', '2010/04/05', 'J BIOL CHEM', 510, 302),
(007, 'Hegel Roguer', '2006/06/06', 'NATURE', 510, 302),
(008, 'Antoni Padilla', '1998/02/23', 'PHYS REV B', 510, 302),
(009, 'Tulio Perez', '2011/12/30', 'ASTROPHYS J', 520, 302),
(010, 'Andrea Gonzales', '1995/02/14', 'APPL PHYS LETT', 520, 302),
(011, 'Johnny Depp', '2014/08/25', 'El m�s', 520, 303),
(012, 'Diego Beria', '1999/03/17', 'El grafico', 520, 303),
(013, 'Sofia Castaneda', '2020/12/31', 'Diario El Salvdor', 530, 303),
(014, 'Jhon Lennon', '2001/01/20', 'El Chero', 530, 303),
(015, 'Cristiano Ronaldo', '2000/01/01', 'El Mundo', 530, 303),
(016, 'Alejandra Lourdes', '2004/02/02', 'El a�o del mono', 530, 304),
(017, 'Alberto Colon', '2022/09/18', 'Una tierra prometida', 540, 304),
(018, 'Jorge Caballero', '1958/11/25', 'A proposito de nada', 540, 304),
(019, 'Cristina Aguilera', '1997/07/04', 'Hombres', 540, 304),
(020, 'Marcela Vieria', '2022/06/19', 'Chica de campo', 540, 304),
(021, 'Jhon Wick', '1985/09/10', 'Manga Dragon Ball', 550, 305),
(022, 'Henry Escalon', '1999/09/21', 'Manga Naruto', 550, 305),
(023, 'Nayib Bukele', '2013/04/04', 'Manga Shokugeki No Souma', 550, 305),
(024, 'Lee Min-Ho', '2009/07/03', 'Manga One Punch Man', 550, 305),
(025, 'Alberto Palomo', '2014/07/17', 'Manga Domestic Na Kanojo', 560, 305),
(026, 'Daniela Spalla', '2003/03/25', 'La competitividad empresarial en la regi�n de La Plata, Berisso y Ensenada', 560, 306),
(027, 'Alberto Gutierrez', '2010/10/21', 'Calidad educativa del nivel secundario en escuelas de la ciudad de La Plata', 560, 306),
(028, 'Ronaldo Canizales', '2014/10/03', 'An�lisis de eficiencia municipal: la Municipalidad de Berisso', 560, 306),
(029, 'Douglas Torres', '2018/12/06', 'Sistemas Integrados de Recursos Empresariales (ERP). Factores para una implementaci�n exitosa', 570, 306),
(030, 'Daniela Guzman', '2016/11/10', 'La influencia del Contexto en las Actitudes Emprendedoras. Caso de la Provincia de Buenos Aires', 570, 306),
(031, 'Jhonny Bravo', '2022/04/25', 'Paulo Londra BZRP', 570, 307),
(032, 'Michael Jackson', '2022/03/03', 'Residente BZRP', 570, 307),
(033, 'Jackie-chan', '2021/10/28', 'Imagine Dragons', 580, 307),
(034, 'Guillermo Cortes', '2014/11/03', 'Dancin', 580, 307),
(035, 'Esteman Williamson', '2009/10/02', 'Billie Jean', 580, 307),
(036, 'Fatima Rose', '2004/10/29', 'SAW', 580, 308),
(037, 'Michael Myers', '2005/10/28', 'SAW II', 590, 308),
(038, 'Mickey Mouse', '2006/10/27', 'SAW III', 590, 308),
(039, 'John Cena', '2007/10/26', 'SAW IV', 590, 308),
(040, 'Alberto Kors', '2008/10/24', 'SAW V', 590, 308)
;

INSERT INTO
USUARIO(carnet, email, direccion, nombre, codigo_ejemplar, id_ocupacionusuario, id_institucionusuario)
VALUES
(2010, 'cmcelrath0@earthlink.net', '1 Kropf Circle', 'Clarita McElrath', 040, 42, 10),
(2020, 'acuschieri1@foxnews.com', '1083 Reinke Park', 'Alford Cuschieri', 040, 42, 10),
(2030, 'bcancutt2@hhs.gov', '4107 Tony Trail', 'Betta Cancutt', 040, 42, 10),
(2040, 'hballendine3@friendfeed.com', '448 Sunnyside Place', 'Hattie Ballendine', 039, 41, 9),
(2050, 'mcombe4@merriam-webster.com', '27 Service Court', 'Marcel Combe', 039, 41, 9),
(2060, 'mteasell5@moonfruit.com', '47870 Springs Alley', 'Mallory Teasell', 039, 41, 9),
(2070, 'chenriksson6@nationalgeographic.com', '166 Elmside Terrace', 'Chery Henriksson', 038, 41, 8),
(2080, 'jkempshall7@vimeo.com', '168 Springview Plaza', 'Jammie Kempshall', 038, 41, 8),
(2090, 'edewar8@example.com', '5736 Prairieview Place', 'Elroy Dewar', 038, 41, 8),
(2100, 'mbracer9@youku.com', '049 Bobwhite Road', 'Malina Bracer', 037, 41, 7),
(2110, 'mgarrocha@blog.com', '759 Ridge Oak Street', 'Mercie Garroch', 037, 41, 7),
(2120, 'aollivierreb@chron.com', '30 Esch Park', 'Amberly Ollivierre', 037, 41, 7),
(2130, 'afallenc@rambler.ru', '80559 Grover Park', 'Amie Fallen', 036, 41, 6),
(2140, 'ctitchmarshd@java.com', '394 Hoard Way', 'Chanda Titchmarsh', 020, 42, 5),
(2150, 'bormane@edublogs.org', '060 Erie Road', 'Brittani Orman', 018, 42, 4),
(2160, 'scadwalladerf@irs.gov', '8 Artisan Circle', 'Storm Cadwallader', 016, 42, 3),
(2170, 'ndouthwaiteg@stanford.edu', '5 Golden Leaf Avenue', 'Noel Douthwaite', 014, 42, 2),
(2180, 'aibelh@narod.ru', '02 Fair Oaks Avenue', 'Andria Ibel', 012, 42, 1),
(2190, 'comohuni@economist.com', '0 Fieldstone Point', 'Chad O''Mohun', 010, 41, 2),
(2200, 'gvedeniktovj@digg.com', '64938 Talmadge Point', 'Geralda Vedeniktov', 008, 41, 3),
(2210, 'bsolesburyk@163.com', '8802 Mallard Lane', 'Bennie Solesbury', 006, 41, 4),
(2220, 'jmcquaidl@photobucket.com', '31188 Northfield Crossing', 'Joelynn McQuaid', 004, 41, 5),
(2230, 'jsetterfieldm@apache.org', '471 Nevada Center', 'Joby Setterfield', 002, 41, 6),
(2240, 'khamblyn@addtoany.com', '708 Lotheville Drive', 'Kareem Hambly', 032, 42, 7),
(2250, 'asangero@multiply.com', '827 Amoth Road', 'Alessandra Sanger', 028, 41, 8)
;

INSERT INTO
SESION(id, f_h_inicio, f_h_cierre, carnet_usuario)
VALUES
(1, '2022-06-01 13:00:00', '2022-06-01 18:00:00', 2250),
(2, '2022-06-10 18:15:00', '2022-06-10 22:30:00', 2240),
(3, '2022-05-30 09:30:00', '2022-05-30 15:00:00', 2230),
(4, '2022-05-22 10:30:00', '2022-05-22 12:00:00', 2220),
(5, '2022-06-04 08:00:00', '2022-06-04 13:00:00', 2210),
(6, '2022-06-18 20:00:00', '2022-06-18 21:30:00', 2200),
(7, '2022-06-02 13:00:00', '2022-06-02 15:00:00', 2190),
(8, '2022-05-19 12:45:00', '2022-05-19 16:30:00', 2180),
(9, '2022-05-20 20:00:00', '2022-05-30 23:00:00', 2170),
(10, '2022-06-08 18:30:00', '2022-06-08 20:00:00', 2160),
(11, '2022-06-03 06:00:00', '2022-06-03 08:00:00', 2150),
(12, '2022-05-18 13:00:00', '2022-05-18 15:30:00', 2140),
(13, '2022-06-01 15:00:00', '2022-06-01 18:00:00', 2130),
(14, '2022-06-10 18:15:00', '2022-06-10 19:30:00', 2120),
(15, '2022-05-30 09:30:00', '2022-05-30 15:45:00', 2110),
(16, '2022-05-22 08:30:00', '2022-05-22 12:15:00', 2100),
(17, '2022-06-18 08:00:00', '2022-06-18 13:00:00', 2090),
(18, '2022-05-29 20:00:00', '2022-06-29 21:30:00', 2080),
(19, '2022-06-13 11:00:00', '2022-06-13 15:00:00', 2070),
(20, '2022-05-19 15:45:00', '2022-05-19 16:30:00', 2060),
(21, '2022-05-26 19:00:00', '2022-05-26 23:00:00', 2050),
(22, '2022-06-08 18:30:00', '2022-06-08 20:00:00', 2040),
(23, '2022-06-03 06:00:00', '2022-06-03 08:00:00', 2030),
(24, '2022-06-18 13:00:00', '2022-06-18 15:00:00', 2020),
(25, '2022-06-20 03:30:00', '2022-06-20 23:45:00', 2010)
;

INSERT INTO
REGISTROASISTENCIA(carnet_usuario, id_area, id_evento, f_h_entrada, f_h_salida)
VALUES
(2010, 71, 200, '2022/07/08 5:30', '2022/07/08 7:30'),
(2020, 71, 200, '2022/07/05 6:30', '2022/07/05 4:00'),
(2030, 72, 210, '2022/07/08 7:30', '2022/07/08 8:00'),
(2040, 72, 210, '2022/07/05 6:00', '2022/07/05 7:40'),
(2050, 73, 220, '2022/07/06 5:30', '2022/07/06 6:30'),
(2060, 73, 220, '2022/07/06 6:30', '2022/07/06 8:00'),
(2070, 74, 230, '2022/07/06 5:30', '2022/07/06 7:30'),
(2080, 74, 230, '2022/07/05 6:00', '2022/07/05 8:00'),
(2090, 75, 240, '2022/07/05 5:30', '2022/07/05 8:00'),
(2100, 75, 240, '2022/07/09 7:15', '2022/07/09 8:00'),
(2110, 76, 250, '2022/07/08 6:00', '2022/07/08 7:00'),
(2120, 76, 250, '2022/07/07 7:10', '2022/07/07 8:00'),
(2130, 77, 260, '2022/07/08 5:30', '2022/07/08 6:30'),
(2140, 77, 260, '2022/07/07 6:30', '2022/07/07 7:30'),
(2150, 77, 260, '2022/07/08 6:00', '2022/07/08 6:30'),
(2160, 77, 260, '2022/07/06 5:30', '2022/07/06 8:00'),
(2170, 76, 250, '2022/07/04 6:30', '2022/07/04 8:00'),
(2180, 75, 240, '2022/07/05 7:10', '2022/07/05 7:40'),
(2190, 74, 230, '2022/07/05 5:45', '2022/07/05 7:00'),
(2200, 73, 220, '2022/07/09 6:00', '2022/07/09 7:00'),
(2210, 72, 210, '2022/07/05 7:10', '2022/07/05 8:00'),
(2220, 71, 200, '2022/07/06 5:30', '2022/07/06 6:30'),
(2230, 72, 200, '2022/07/09 6:00', '2022/07/09 7:30'),
(2240, 73, 210, '2022/07/08 6:30', '2022/07/08 7:30'),
(2250, 74, 220, '2022/07/05 5:30', '2022/07/05 8:00')
;

INSERT INTO
PRESTAMO(carnet_usuario, codigo_ejemplar, f_h_prestamo, f_h_devolucion)
VALUES
(2250, 001, '2022/07/06 5:30', '2022/07/06 6:30'),
(2240, 002, '2022/07/07 6:30', '2022/07/07 8:00'),
(2230, 003, '2022/07/05 6:00', '2022/07/05 7:40'),
(2220, 004, '2022/07/05 6:00', '2022/07/05 7:40'),
(2210, 014, '2022/07/07 6:30', '2022/07/07 8:00'),
(2200, 015, '2022/07/06 6:30', '2022/07/06 8:00'),
(2190, 016, '2022/07/06 5:30', '2022/07/06 6:30'),
(2180, 018, '2022/07/05 6:00', '2022/07/05 7:40'),
(2170, 024, '2022/07/05 6:00', '2022/07/05 7:40'),
(2160, 025, '2022/07/09 7:15', '2022/07/09 8:00'),
(2150, 026, '2022/07/06 5:30', '2022/07/06 6:30'),
(2140, 027, '2022/07/04 5:30', '2022/07/04 7:30'),
(2130, 028, '2022/07/06 5:30', '2022/07/06 6:30'),
(2120, 034, '2022/07/07 6:30', '2022/07/07 8:00'),
(2110, 035, '2022/07/07 6:30', '2022/07/07 8:00'),
(2100, 036, '2022/07/06 5:30', '2022/07/06 8:00'),
(2090, 037, '2022/07/06 5:30', '2022/07/06 6:30'),
(2080, 038, '2022/07/05 6:00', '2022/07/05 7:40'),
(2070, 005, '2022/07/05 5:45', '2022/07/05 7:00'),
(2060, 006, '2022/07/05 6:00', '2022/07/05 7:40'),
(2050, 007, '2022/07/07 6:30', '2022/07/07 8:00'),
(2040, 008, '2022/07/06 5:30', '2022/07/06 6:30'),
(2030, 011,'2022/07/05 6:00', '2022/07/05 7:40'),
(2020, 021, '2022/07/07 6:30', '2022/07/07 8:00'),
(2010, 031, '2022/07/04 5:30', '2022/07/04 7:30')
;

INSERT INTO
RESERVA(carnet_usuario, codigo_ejemplar, f_h_reserva, f_h_devolucion)
VALUES
(2010, 040, '2022/07/06 7:30', '2022/07/12 16:30'),
(2020, 039, '2022/07/04 9:30', '2022/07/16 8:00'),
(2030, 038, '2022/07/07 22:00', '2022/07/09 7:40'),
(2040, 037, '2022/07/05 16:00', '2022/07/08 4:40'),
(2050, 030, '2022/07/07 19:30', '2022/07/11 13:00'),
(2060, 029, '2022/07/06 6:30', '2022/07/20 11:00'),
(2070, 028, '2022/07/04 18:30', '2022/07/24 20:30'),
(2080, 027, '2022/07/05 6:00', '2022/07/09 16:40'),
(2090, 020, '2022/07/07 6:00', '2022/07/08 17:40'),
(2100, 019, '2022/07/09 11:15', '2022/07/15 8:00'),
(2110, 018, '2022/07/06 5:30', '2022/07/16 6:30'),
(2120, 017, '2022/07/04 8:30', '2022/07/24 17:30'),
(2130, 010, '2022/07/06 10:30', '2022/07/16 6:30'),
(2140, 009, '2022/07/04 6:30', '2022/07/21 18:00'),
(2150, 008, '2022/07/07 12:30', '2022/07/17 20:00'),
(2160, 007, '2022/07/06 8:30', '2022/07/09 22:00'),
(2170, 036, '2022/07/06 9:30', '2022/07/14 16:30'),
(2180, 035, '2022/07/05 8:00', '2022/07/25 19:40'),
(2190, 034, '2022/07/07 20:45', '2022/07/15 7:00'),
(2200, 033, '2022/07/05 6:00', '2022/07/07 11:40'),
(2210, 026, '2022/07/07 11:30', '2022/07/18 18:00'),
(2220, 025, '2022/07/04 9:30', '2022/07/16 14:30'),
(2230, 024, '2022/07/04 8:00', '2022/07/08 15:40'),
(2240, 023, '2022/07/06 15:30', '2022/07/29 20:00'),
(2250, 016, '2022/07/04 7:30', '2022/07/11 21:30')
;

INSERT INTO
TELEFONOUSUARIO(id, numero, carnet_usuario)
VALUES
(50, '6962759742', 2250),
(51, '5039657097', 2240),
(52, '5394376907', 2230),
(53, '7667369988', 2220),
(54, '5886902920', 2210),
(55, '4876095485', 2200),
(56, '7254267388', 2190),
(57, '3497284410', 2180),
(58, '2553506811', 2170),
(59, '2542642253', 2160),
(60, '1633536336', 2150),
(61, '6064779348', 2140),
(62, '9618493024', 2130),
(63, '7299005702', 2120),
(64, '2533691664', 2110),
(65, '4198315172', 2100),
(66, '3093532963', 2090),
(67, '9594463903', 2080),
(68, '4748360572', 2070),
(69, '3105109538', 2060),
(70, '8184775990', 2050),
(71, '1128290099', 2040),
(72, '6553181055', 2030),
(73, '8671732791', 2020),
(74, '1191000058', 2010)
;

INSERT INTO
GENEROCOLECCION(id, Fantasia, CienciaFiccion, Historia, Realista, Romantico, Suspenso, Policiaco, Drama, Psicologico, Comedia, id_coleccion)
VALUES
(1000, 'Si', '-', '-', '-', '-', 'Si', '-', 'Si', '-', 'Si', 301),
(1001, '-', '-', 'Si', '-', '-', '-', 'Si', '-', '-', 'Si', 302),
(1002, 'Si', '-', '-', '-', 'Si', '-', '-', '-', 'Si', '-', 303),
(1003, '-', 'Si', '-', '-', '-', 'Si', 'Si', '-', '-', 'Si', 304),
(1004, '-', '-', '-', 'Si', '-', '-', 'Si', '-', '-', '-', 305),
(1005, '-', '-', '-', '-', 'Si', '-', '-', '-', 'Si', '-', 306),
(1006, 'Si', 'Si', '-', '-', '-', 'Si', '-', '-', '-', '-', 307),
(1007, '-', '-', 'Si', 'Si', '-', '-', '-', '-', 'Si', '-', 308)
;

INSERT INTO
IDENTIFICADOREJEMPLAR(id, ISBN, ISSN, DOI, codigo_ejemplar)
VALUES
(1, '564', '6997', '29915', 001),
(2, '951', '6801', '48591', 002),
(3, '241', '8076', '96146', 003),
(4, '260', '4984', '78883', 004),
(5, '408', '2002', '93144', 005),
(6, '356', '5831', '31828', 006),
(7, '128', '9954', '19527', 007),
(8, '471', '4814', '23310', 008),
(9, '764', '1536', '65194', 009),
(10, '956', '3162', '12311', 010),
(11, '542', '7178', '37481', 011),
(12, '211', '6478', '29532', 012),
(13, '959', '5288', '38388', 013),
(14, '307', '7276', '78027', 014),
(15, '162', '9192', '40039', 015),
(16, '908', '3311', '80364', 016),
(17, '940', '8775', '77044', 017),
(18, '165', '5504', '64374', 018),
(19, '241', '5738', '15329', 019),
(20, '793', '3133', '51154', 020),
(21, '127', '1004', '76598', 021),
(22, '691', '8409', '82337', 022),
(23, '999', '8077', '55728', 023),
(24, '157', '4535', '24969', 024),
(25, '148', '9709', '74799', 025),
(26, '561', '6078', '77842', 026),
(27, '782', '4496', '82926', 027),
(28, '198', '5216', '65227', 028),
(29, '671', '8455', '18317', 029),
(30, '414', '6937', '14832', 030),
(31, '872', '3325', '64479', 031),
(32, '426', '8001', '69590', 032),
(33, '895', '3383', '26531', 033),
(34, '542', '5687', '23765', 034),
(35, '745', '4675', '68044', 035),
(36, '587', '7692', '41580', 036),
(37, '380', '5899', '29977', 037),
(38, '271', '2302', '18945', 038),
(39, '654', '8317', '71629', 039),
(40, '557', '9449', '37651', 040)
;

INSERT INTO
IDIOMAEJEMPLAR(id, Espanol, Ingles, Aleman, Frances, Italiano, Japones, Portugues, Arabe, codigo_ejemplar)
VALUES
(1, 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 040),
(2, 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 039),
(3, 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 038),
(4, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 037),
(5, 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 036),
(6, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 035),
(7, 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 034),
(8, 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 033),
(9, 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 032),
(10, 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 031),
(11, 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 030),
(12, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 029),
(13, 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 028),
(14, 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 027),
(15, 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 026),
(16, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 025),
(17, 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 024),
(18, 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 023),
(19, 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 022),
(20, 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 021),
(21, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 020),
(22, 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 019),
(23, 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 018),
(24, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 017),
(25, 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 016),
(26, 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 015),
(27, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 014),
(28, 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 013),
(29, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 012),
(30, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 011),
(31, 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 010),
(32, 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 009),
(33, 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 008),
(34, 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 007),
(35, 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 006),
(36, 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 005),
(37, 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 004),
(38, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 003),
(39, 'AGOTADO', 'AGOTADO', 'DISPONIBLE', 'AGOTADO', 'DISPONIBLE', 'DISPONIBLE', 'DISPONIBLE', 'AGOTADO', 002),
(40, 'DISPONIBLE', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 'AGOTADO', 001)
;

-----AHORA ESTARAN LOS RESPECTIVOS SELECTS PARA LA VISUALIZACION DE CADA TABLA

SELECT * FROM HORARIOEVENTO;

SELECT * FROM HORARIOAREA;

SELECT * FROM TIPOCOLECCION;

SELECT * FROM EDITORIALEJEMPLAR;

SELECT * FROM FORMATOEJEMPLAR;

SELECT * FROM OCUPACIONUSUARIO;

SELECT * FROM INSTITUCIONUSUARIO;

SELECT * FROM EVENTO;

SELECT * FROM AREA;

SELECT * FROM COLECCION;

SELECT * FROM EJEMPLAR;

SELECT * FROM USUARIO;

SELECT * FROM SESION;

SELECT * FROM REGISTROASISTENCIA;

SELECT * FROM PRESTAMO;

SELECT * FROM RESERVA;

SELECT * FROM TELEFONOUSUARIO;

SELECT * FROM GENEROCOLECCION;

SELECT * FROM IDENTIFICADOREJEMPLAR;

SELECT * FROM IDIOMAEJEMPLAR;