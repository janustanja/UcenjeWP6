import { useEffect, useState } from "react";
import {  Col, Row } from "react-bootstrap";
import SmjerService from "../services/SmjerService";
import PolaznikService from "../services/PolaznikService";
import useLoading from "../hooks/useLoading";
import CountUp from "react-countup";


export default function Pocetna(){

    const { showLoading, hideLoading } = useLoading();

    const [polaznika, setPolaznika] = useState(0);
    const [smjerovi, setSmjerovi] = useState([]);

    async function dohvatiSmjerove() {
        
        await SmjerService.dostupniSmjerovi()
        .then((odgovor)=>{
            setSmjerovi(odgovor);
        })
        .catch((e)=>{console.log(e)});

    }

    async function dohvatiBrojPolaznika() {
        await PolaznikService.ukupnoPolaznika()
        .then((odgovor)=>{
            setPolaznika(odgovor.poruka);
        })
        .catch((e)=>{console.log(e)});
    }


    async function ucitajPodatke() {
        showLoading();
        await dohvatiSmjerove();
        await dohvatiBrojPolaznika();
        hideLoading();
      }


    useEffect(()=>{
        ucitajPodatke()
    },[]);

   

    return(
        <>
        <Row>
           
                    <Col xs={6} sm={6} md={3} lg={6} xl={6} xxl={6}>
                    Naši smjerovi:
                    <ul>
                    {smjerovi && smjerovi.map((smjer,index)=>(
                            <li key={index}>{smjer.naziv}</li>
                            
                    ))}
                    </ul>
                    </Col>
                    <Col xs={6} sm={6} md={9} lg={6} xl={6} xxl={6}>
                    Do sada nam je povjerenje pokazalo
                    <div className="brojPolaznika">
                    <CountUp
                    start={0}
                    end={polaznika}
                    duration={10}
                    separator="."></CountUp>
                    </div>
                    polaznika
                    </Col>
                </Row>
            </>
    )
}