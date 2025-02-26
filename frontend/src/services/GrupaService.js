import { HttpService } from "./HttpService"


async function get(){
    return await HttpService.get('/Grupa')
    .then((odgovor)=>{
        //console.table(odgovor.data);
        return odgovor.data;
    })
    .catch((e)=>{console.error(e)})
}

async function getBySifra(sifra){
    return await HttpService.get('/Grupa/' + sifra)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Ne postoji Grupa!'}
    })
}

async function obrisi(sifra) {
    return await HttpService.delete('/Grupa/' + sifra)
    .then((odgovor)=>{
        //console.log(odgovor);
        return {greska: false, poruka: odgovor.data}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Grupa se ne može obrisati!'}
    })
}

async function dodaj(Grupa) {
    return await HttpService.post('/Grupa',Grupa)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        switch (e.status) {
            case 400:
                let poruke='';
                for(const kljuc in e.response.data.errors){
                    poruke += kljuc + ': ' + e.response.data.errors[kljuc][0] + '\n';
                }
                return {greska: true, poruka: poruke}
            default:
                return {greska: true, poruka: 'Grupa se ne može dodati!'}
        }
    })
}

async function promjena(sifra,Grupa) {
    return await HttpService.put('/Grupa/' + sifra,Grupa)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        switch (e.status) {
            case 400:
                let poruke='';
                for(const kljuc in e.response.data.errors){
                    poruke += kljuc + ': ' + e.response.data.errors[kljuc][0] + '\n';
                }
                console.log(poruke)
                return {greska: true, poruka: poruke}
            default:
                return {greska: true, poruka: 'Grupa se ne može promjeniti!'}
        }
    })
}


async function getPolaznici(sifra){
    return await HttpService.get('/Grupa/Polaznici/'+ sifra)
    .then((odgovor)=>{
        //console.table(odgovor.data);
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{return {greska: true, poruka: 'Problem kod dohvaćanja polaznika'}})
}

async function dodajPolaznika(grupa,polaznik) {
    return await HttpService.post('/Grupa/' + grupa + '/dodaj/'+polaznik)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
                return {greska: true, poruka: 'Polaznik se ne može dodati na grupu'}
    })
}

async function obrisiPolaznika(grupa,polaznik) {
    return await HttpService.delete('/Grupa/' + grupa + '/obrisi/'+polaznik)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
                return {greska: true, poruka: 'Polaznik se ne može obrisati iz grupe'}
    })
}

export default{
    get,
    getBySifra,
    obrisi,
    dodaj,
    promjena,

    getPolaznici,
    dodajPolaznika,
    obrisiPolaznika
}