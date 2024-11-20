use master;
go

drop database if exists trgovina;
go

create database trgovina collate Croatian_CI_AS;
go

use trgovina;
go

create table vrstavozila (
sifra int not null primary key identity(1,1),
naziv varchar(30) not null,);

create table kupac (
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
adresa varchar(100) not null,
iban varchar(30) 
);

create table dobavljac (
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
adresa varchar(100) not null,
iban varchar(30) not null
);

create table vozilo (
sifra int not null primary key identity(1,1),
vrstavozila int not null references vrstavozila(sifra),
dobavljac int not null references dobavljac(sifra),
marka varchar(30) not null,
godproizvodnje char(4) not null,
prijedenikm int not null,
cijena decimal(18,2) not null,
kupac int not null references kupac(sifra)
);


