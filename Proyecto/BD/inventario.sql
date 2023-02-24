create database inventario;

use inventario;

create table Usuario(
    cedula int not null primary key,
    nombre varchar(100) not null,
    apellido varchar(100),
    contraseña varchar(100) not null,
    correo varchar(255) not null,
    telefono varchar(50),
    fecha_nacimiento date not null,
    estado varchar(50) not null

);
create table Distribuidor(
    nit int not null primary key,
    nombre varchar(100) not null,
    direccion varchar(100),
    ciudad varchar(30) not null,
    categoria varchar(30) not null, 
    telefono varchar(50),
    descripcion varchar(255)
);
create table Articulos (
    id int not null primary key,
    codigo int not null,
    nombre varchar(100) not null,
    fecha_vencimiento date not null,
    bodega varchar(100) not null,
    cantidad int not null,
    descripcion varchar(255),
    FK_distribuidor int not null,
    FK_usuario int not null,
    foreign key (FK_distribuidor) references Distribuidor(nit),
    foreign key (FK_usuario) references Usuario(cedula)
);

