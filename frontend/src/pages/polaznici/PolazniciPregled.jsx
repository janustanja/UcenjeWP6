import { Button, Table } from "react-bootstrap";
import PolaznikService from "../../services/PolaznikService";
import { useEffect, useState } from "react";
import { RouteNames } from "../../constants";
import { Link, useNavigate } from "react-router-dom";



export default function PolazniciPregled(){

    const[polaznici,setPolaznici] = useState();

    const navigate = useNavigate();

    async function dohvatiPolaznike() {

        // zaustavi kod u Chrome consoli i tamo se može raditi debug
        //debugger;
        
        await PolaznikService.get()
        .then((odgovor)=>{
            //console.log(odgovor);
            setPolaznici(odgovor);
        })
        .catch((e)=>{console.log(e)});

    }

    // npm run lint
    // javlja upozorenje
    // 28:7  warning  React Hook useEffect has a missing dependency: 'dohvatie'. Either include it or remove the dependency array  react-hooks/exhaustive-deps

    useEffect(()=>{
        dohvatiPolaznike();
    },[]);

   

    async function obrisiAsync(sifra) {
        const odgovor = await PolaznikService.obrisi(sifra);
        //console.log(odgovor);
        if(odgovor.greska){
            alert(odgovor.poruka);
            return;
        }
        dohvatiPolaznike();
    }

    function obrisi(sifra){
        obrisiAsync(sifra);
    }


    return(
        <>
            <Link to={RouteNames.POLAZNIK_NOVI}>Dodaj novog polaznika</Link>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Ime</th>
                        <th>Prezime</th>
                        <th>Email</th>
                        <th>OIB</th>
                        <th>Akcija</th>
                    </tr>
                </thead>
                <tbody>
                    {polaznici && polaznici.map((e,index)=>(
                        <tr key={index}>
                            <td>{e.ime}</td>
                            <td>{e.prezime}</td>
                            <td>{e.email}</td>
                            <td>{e.oib}</td>
                           
                            <td>
                            <Button
                                variant="primary"
                                onClick={()=>navigate(`/polaznici/${e.sifra}`)}>
                                    Promjeni
                                </Button>
                                &nbsp;&nbsp;&nbsp;
                                <Button
                                variant="danger"
                                onClick={()=>obrisi(e.sifra)}>
                                    Obriši
                                </Button>

                               
                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </>
    )

}