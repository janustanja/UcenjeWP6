import { HttpService } from "./HttpService"


async function get(){
    return await HttpService.get('/Polaznik')
    .then((odgovor)=>{
        //console.table(odgovor.data);
        return odgovor.data;
    })
    .catch((e)=>{console.error(e)})
}

async function getBySifra(sifra){
    return await HttpService.get('/Polaznik/' + sifra)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Ne postoji Polaznik!'}
    })
}

async function obrisi(sifra) {
    return await HttpService.delete('/Polaznik/' + sifra)
    .then((odgovor)=>{
        //console.log(odgovor);
        return {greska: false, poruka: odgovor.data}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Polaznik se ne može obrisati!'}
    })
}

async function dodaj(Polaznik) {
    return await HttpService.post('/Polaznik',Polaznik)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        switch (e.status) {
            case 400:
                let poruke='';
                for(const kljuc in e.response.data.errors){
                    poruke += kljuc + ': ' + e.response.data.errors[kljuc][0] + ', ';
                }
                return {greska: true, poruka: poruke}
            default:
                return {greska: true, poruka: 'Polaznik se ne može dodati!'}
        }
    })
}

async function promjena(sifra,Polaznik) {
    return await HttpService.put('/Polaznik/' + sifra,Polaznik)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        switch (e.status) {
            case 400:
                let poruke='';
                for(const kljuc in e.response.data.errors){
                    poruke += kljuc + ': ' + e.response.data.errors[kljuc][0] + ', ';
                }
                return {greska: true, poruka: poruke}
            default:
                return {greska: true, poruka: 'Polaznik se ne može promjeniti!'}
        }
    })
}

async function traziPolaznik(uvjet){
    return await HttpService.get('/Polaznik/trazi/'+uvjet)
    .then((odgovor)=>{
        //console.table(odgovor.data);
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{return {greska: true, poruka: 'Problem kod traženja polaznika'}})
}




async function getStranicenje(stranica,uvjet){
    return await HttpService.get('/Polaznik/traziStranicenje/'+stranica + '?uvjet=' + uvjet)
    .then((odgovor)=>{return  {greska: false, poruka: odgovor.data};})
    .catch((e)=>{ return {greska: true, poruka: 'Problem kod traženja polaznika '}});
  }

  async function postaviSliku(sifra, slika) {
    return await HttpService.put('/Polaznik/postaviSliku/' + sifra, slika)
    .then((odgovor)=>{return  {greska: false, poruka: odgovor.data};})
    .catch((e)=>{ return {greska: true, poruka: 'Problem kod postavljanja slike polaznika '}});
  }

  async function ukupnoPolaznika(){
    return await HttpService.get('/Pocetna/UkupnoPolaznika')
    .then((odgovor)=>{
        //console.table(odgovor.data);
        return odgovor.data;
    })
    .catch((e)=>{console.error(e)})
}


export default{
    get,
    getBySifra,
    obrisi,
    dodaj,
    promjena,

    traziPolaznik,
    getStranicenje,
    postaviSliku,

    ukupnoPolaznika
}