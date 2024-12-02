select * from smjerovi;

update smjerovi set cijena=1100
where sifra=2; 

update smjerovi set 
izvodiseod= '2024-12-05',
vaucer=0
where sifra=2;

select * from polaznici where sifra=16;

update polaznici set prezime= 'Franjić' where sifra=16;

select * from polaznici where sifra=16;

insert into smjerovi(naziv, cijena, izvodiseod, vaucer)
values
('Web dizajn', 700, '2022-05-12', 1),
('Android developer', 900, '2023-4-7', 0),
('Grafički dizajner', 1000, '2021-4-8', 0),
('Računalni developer', 800, '2021-9-9', 1),
('3D print dizajner', 750, '2024-10-10', 0)
;

--UPDATE
select * from smjerovi;
update smjerovi set cijena = cijena *0.9;
select * from smjerovi;

--uvećajte sve cijene za 35%

select * from smjerovi;
update smjerovi set cijena = cijena *1.35;
select * from smjerovi;

--smanjite svim smjerovima cijenu za 10e

select * from smjerovi;
update smjerovi set cijena = cijena -10;
select * from smjerovi;

--uvjet vanjskog kljuca
update grupe set smjer=8 where sifra=1;

--DELETE

select * from smjerovi;
delete from smjerovi where sifra>8;
select * from smjerovi;


select * from grupe;
update grupe set smjer =1 where sifra=1;

delete grupe where sifra=1;

select * from clanovi;

update clanovi set grupa= 2 where grupa=1;
