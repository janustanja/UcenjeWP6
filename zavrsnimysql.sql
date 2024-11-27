drop database if exists trgovina;
create database trgovina character set utf8mb4 DEFAULT COLLATE utf8mb4_general_ci;
use trgovina;


create table vrstevozila (
sifra int not null auto_increment,
naziv varchar(30) not null,
primary key (sifra)
);

create table kupci (
sifra int not null auto_increment,
ime varchar(30) not null,
prezime varchar(30) not null,
adresa varchar(100) not null,
iban varchar(30) not null,
primary key (sifra)
);

create table dobavljaci (
sifra int not null auto_increment,
naziv varchar(50) not null,
adresa varchar(100) not null,
iban varchar(30) not null,
primary key (sifra)
);

create table vozila (
sifra int not null auto_increment,
vrstavozila int not null,
dobavljac int not null,
marka varchar(30) not null,
godproizvodnje int not null,
prijedenikm int not null,
cijena decimal(18,2) not null,
kupac int not null,
primary key (sifra) ,
constraint FK_vrstavozila foreign key (vrstavozila) references vrstevozila(sifra),
constraint FK_dobavljac foreign key (dobavljac) references dobavljaci(sifra),
constraint FK_kupac foreign key (kupac) references kupci(sifra)
);

insert into vrstevozila(naziv)
values 
('Automobil'),
('Autobus'),
('Kombi'),
('Kamion');

insert into kupci(ime, prezime, adresa, iban)
values
('Mirko', 'Marić', 'Matije Gupca 55 Virovitica', 'HR8452254785126447529'),
('Ivana', 'Kovač', 'Trg bana Josipa Jelačića 2 Zagreb', 'HR8544120326558945258'),
('Jakov', 'Ban', 'Svačićev trg 23 Osijek', 'HR8452654854215978854'),
('Dijana', 'Dombić', 'Miroslava Krleže 75 Varaždin', 'HR7412589632145698753');

insert into dobavljaci(naziv, adresa, iban)
values
('Transport Franić', 'Boškovićeva 13 Beli Manastir', 'HR4552166903487526781'),
('Dominković Prijevoz', 'Cvjetni trg 1 Zagreb', 'HR6223014577521000326'),
('Auto kuća Maras', 'Dalmatinska ulica 8 Split', 'HR1254865770126895587');

insert into vozila(vrstavozila, dobavljac, marka, godproizvodnje, prijedenikm, cijena, kupac)
values
(1, 3, 'Volvo', '2014', 122000, 11000, 4 ),
(4, 1, 'Man', '2008', 682000, 21000, 1 ),
(2, 2, 'Setra', '2000', 800000, 50000, 3 ),
(3, 3, 'Mercedes', '2020', 50000, 33000, 3 )
;





