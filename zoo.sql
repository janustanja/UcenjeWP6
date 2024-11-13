
use master;
go 
--brisem postojecu bazu ako postoji
drop database if exists zoo;
go
--kreiram novu bazu
create database zoo; 
go
--prebacujem se na novu bazu
use zoo;
go

create table zivotinja(
sifra int,
vrsta varchar(50),
ime varchar(50),
djelatnik int,
prostorija int,
datum int
);
 
create table prostorija(
sifra int,
dimenzije varchar(30),
maks_broj int,
mjesto varchar(30)
);

create table djelatnik(
sifra int,
ime varchar(50),
prezime varchar(50),
iban varchar(50)
);

create table datum(
d_rodenja datetime,
d_dolaska datetime,
d_smrti datetime,
sifra int
);