use master;

drop database if exists webshop;
go

create database webshop collate Croatian_CI_AS;
go

use webshop;
go

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
datumnabave datetime not null,
cijena decimal(18,2) not null,
aktivan bit not null
);

create table kupci(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
ulica varchar (100) not null,
mjesto varchar (50) not null
);

create table racuni(
sifra int not null primary key identity(1,1),
datum datetime not null,
kupac int not null references kupci(sifra),
status varchar (30) not null
);

create table stavke (
racun int not null references racuni(sifra),
proizvod int not null references proizvodi(sifra),
kolicina int not null, 
cijena decimal(18,2) not null
);

insert into proizvodi (naziv, datumnabave, cijena, aktivan)
values 
('Mlijeko','2024-11-06', 1.5 ,1),
('Kruh', '2020-12-11', 2, 0),
('Brašno','2021-05-05', 1.7, 1);

insert into kupci (ime, prezime, ulica, mjesto)
values
('Ana', 'Anić', 'Matije Gupca 5', 'Virovitica'),
('Marko', 'Markić', 'Cvjetni trg 1', 'Zagreb');

insert into racuni (datum, kupac, status)
values
('2022-12-12', 1, 'aktivan'),
('2022-07-07', 2, 'aktivan');

insert into stavke (racun, proizvod, kolicina, cijena)
values
(1, 1, 2, 12.50),
(2, 2, 3, 45);
