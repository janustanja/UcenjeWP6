
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


create table prostorija(
sifra int not null primary key identity(1,1),
dimenzije varchar(30) not null,
maks_broj int not null,
mjesto varchar(30) not null
);

create table djelatnik(
sifra int not null primary key identity(1,1) ,
ime varchar(50) not null,
prezime varchar(50) not null,
iban varchar(50) not null
);

create table datum(
sifra int not null primary key identity(1,1),
d_rodenja datetime not null,
d_dolaska datetime not null,
d_smrti datetime not null
);

create table zivotinja(
sifra int not null primary key identity(1,1) ,
vrsta varchar(50) not null,
ime varchar(50) not null,
djelatnik int not null references djelatnik(sifra),
prostorija int not null references prostorija(sifra),
datum int not null references datum(sifra)
);