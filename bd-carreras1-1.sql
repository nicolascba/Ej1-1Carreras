
create table materias(
id_materia int identity(1,1),
descripcion varchar(50),
constraint pk_materia primary key (id_materia))

Create table carreras(
id_carrera int identity(1,1),
nombre varchar(100),
titulo varchar (100),
constraint pk_carrera primary key (id_carrera))

create table detalles_carreras(
id_detalle int identity(1,1) ,
id_carrera int,
aniocursado int,
cuatrimestre int,
id_materia int,
constraint pk_detalle primary key (id_detalle),
constraint fk_detalle_carrera foreign key (id_carrera) references carreras (id_carrera),
constraint fk_detalle_materia foreign key (id_materia) references materias (id_materia))


insert into materias values('Programacion I')
insert into materias values('Sistemas de Procesamiento de Datos')
insert into materias values('Matemática')
insert into materias values('Inglés I')
insert into materias values('Laboratorio de Computación I')
insert into materias values('Programación II')
insert into materias values('Arquitectura y Sistemas Operativos')
insert into materias values('Estadistica')
insert into materias values('Ingles II')
insert into materias values('Laboratorio de Computación II')
insert into materias values('Metodología de la Investigación')
insert into materias values('Programación III')
insert into materias values('Organización Contable de la Empresa')
insert into materias values('Organización Empresaria')
insert into materias values('Elementos de Investigación Operativa')
insert into materias values('Laboratorio de Computación III')
insert into materias values('Metodología de Sistemas I')
insert into materias values('Diseño y Administración de Bases de Datos')
insert into materias values('Legislación')
insert into materias values('Laboratorio de Computación IV')

insert into materias values('Industrias Alimentarias I')
insert into materias values('Biología General')
insert into materias values('Matematica General')
insert into materias values('Quimica General')
insert into materias values('Física')
insert into materias values('Quimica Analitica')
insert into materias values('Quimica Inorganica')
insert into materias values('Industrial Alimentarias II')
insert into materias values('Legislación Sanitaria')
insert into materias values('Microbiologia de los Alimentos')
insert into materias values('Quimica Organica')
insert into materias values('Economia')
insert into materias values('Bromatologia')

insert into materias values('Mecatronica I')
insert into materias values('Ingles')
insert into materias values('Herramientas Informaticas')
insert into materias values('Sistemas CAD')
insert into materias values('Materiales')
insert into materias values('Electrotecnia I')
insert into materias values('Sistemas Digitales')
insert into materias values('Mecatronica II')
insert into materias values('Mecanica I')
insert into materias values('Mantenimiento Industrial')
insert into materias values('Electronica')
insert into materias values('Electronia II')
insert into materias values('Mecanica II')
insert into materias values('Tecnologia de la Fabricacion')
insert into materias values('Automacion Industral')
insert into materias values('Gestion de la Calidad y Metrologia')
insert into materias values('Pasantia de Endes Ofiaciales o Empresas')
insert into materias values('Seminarios')


create procedure SP_COMBO_MATERIA
AS
select * from materias

create procedure SP_COMBO_CARRERA
as
select * from carreras

create procedure SP_INSERT_MATERIA
@id_materia int ,
@id_carrera int,
@anioCursado int,
@cuatrimestre int
as
insert into detalles_carreras (id_carrera,aniocursado,cuatrimestre,id_materia) values (@id_carrera,@anioCursado,@cuatrimestre,@id_materia)

create procedure SP_PROXIMO_NRO_DETALLE
@next int output
as
SET @next=(select MAX(id_detalle)+1 from detalles_carreras)

select MAX(id_detalle) +1
from detalles_carreras


create procedure SP_INSERT_DETALLE
@id_materia int ,
@id_carrera int,
@anioCursado int,
@cuatrimestre int
as
insert into detalles_carreras (id_carrera,aniocursado,cuatrimestre,id_materia)
values (@id_carrera,@anioCursado,@cuatrimestre,@id_materia)

create procedure SP_INSERTAR_MAESTRO
@nombre varchar(250),
@id_carrera int output
as
begin
	insert into carreras(nombre)
	values(@nombre)
	set @id_carrera = SCOPE_IDENTITY()
	end

select * from carreras


select * from carreras
select * from detalles_carreras



