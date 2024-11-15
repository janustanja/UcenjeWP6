use master;
go 

drop database if exists nogomet;
go

create database nogomet; 
go

use nogomet;
go

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(30) not null,
osnovan datetime,
stadion varchar(30),
predsjednik varchar(60),
drzava varchar(30),
liga int
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime not null,
vrijeme datetime not null,
lokacija varchar(30) not null,
stadion varchar(30) not null,
domaci_klub int not null references klub(sifra),
gostujuci_klub int not null references klub(sifra)
);

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datum_rodenja datetime not null,
pozicija varchar(30) not null,
broj_dresa int not null,
klub int not null references klub(sifra)
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
klub int not null references klub(sifra),
nacionalnost varchar(30) not null,
iskustvo bit not null
);