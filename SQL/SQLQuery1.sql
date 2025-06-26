create database dbHospital
go
use dbHospital;
go

create table Doctores (
idDoctor int identity (1,1) primary key,
nombre varchar (50) not null,
apellido varchar (50) not null,
especialidad varchar (50) not null,
cargo varchar (50) not null
);
go

create table Pacientes (
idPaciente int identity (1,1) primary key,
numIsss varchar (20) not null unique,
nombre varchar (50) not null,
apellido varchar (50) not null,
domicilio varchar (150) not null,
telefono varchar (30) not null,
sexo char (1) not null,
costoTratamiento decimal(10,2) not null default 0.00
);
go

create table Ingresos (
idIngreso int identity (1,1) primary key,
idPaciente int not null,
fechaIngreso datetime not null,
idDoctor int not null,
diagnostico text not null,
constraint fk_ingresos_pacientes foreign key (idPaciente)
references Pacientes(idPaciente),
constraint fk_ingresos_doctores foreign key (idDoctor)
references Doctores (idDoctor)
);

insert into Doctores
values ('Daniel Orlando', 'Pérez Vásquez', 'Cardiologia', 'Jefe de cardiología'),
('Fabiola Margarita', 'Rivera García', 'Pediatra', 'Jefa de pediatria'),
('Lenin Marcelo', 'Mata Hérnandez', 'Cirujano', 'Jefe de cirujia')

select *from Doctores
select *from Pacientes
select *from Ingresos

select nombre, apellido, especialidad, cargo from Doctores