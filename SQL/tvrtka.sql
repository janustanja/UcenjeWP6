use master;

drop database if exists tvrtka;
go

create database tvrtka collate Croatian_CI_AS;
go

use tvrtka;
go

create table zaposlenici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datumrodenja datetime not null,
placa decimal(18,2) not null,
invalid bit not null
);

create table slike (
sifra int not null primary key identity(1,1),
zaposlenik int not null references zaposlenici(sifra),
rednibroj int not null,
putanja varchar(200) not null
);

insert into zaposlenici (ime, prezime, datumrodenja, placa, invalid)
values 
('Mirko', 'Mirić','1980-11-06', 1200 ,1),
('Ivana', 'Kovač','1999-12-11', 900, 0),
('Darko', 'Darić','1988-05-05', 1100, 1)
;
insert into slike (zaposlenik, rednibroj, putanja)
values
(1, 1, 'UcenjeWP6Q\slika1.jpg'),
(2, 2, 'UcenjeWP6Q\slika2.jpg'),
(3, 3, 'UcenjeWP6Q\slika3.jpg'),
(1, 4, 'UcenjeWP6Q\slika4.jpg'),
(2, 5, 'UcenjeWP6Q\slika5.png'),
(3, 6, 'UcenjeWP6Q\slika6.jpg');

