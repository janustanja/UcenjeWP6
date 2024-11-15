use master;
go 

drop database if exists sport;
go

create database sport; 
go

use sport;
go

create table klubovi(
sifra int not null primary key identity(1,1),
naziv varchar(30) not null,
osnovan datetime,
stadion varchar(30),
predsjednik varchar(60),
drzava varchar(30),
liga int
);

create table utakmice(
sifra int not null primary key identity(1,1),
datum datetime not null,
vrijeme datetime not null,
lokacija varchar(30) not null,
stadion varchar(30) not null,
domaci_klub int not null references klubovi(sifra),
gostujuci_klub int not null references klubovi(sifra)
);

create table igraci(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datum_rodenja datetime not null,
pozicija varchar(30) not null,
broj_dresa int not null,
klub int not null references klubovi(sifra)
);

create table treneri(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
klub int not null references klubovi(sifra),
nacionalnost varchar(30) not null,
iskustvo bit not null
);