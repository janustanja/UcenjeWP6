import SmjerService from "../../services/SmjerService"
import { Button, Row, Col, Form } from "react-bootstrap";
import moment from "moment";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";
import useLoading from "../../hooks/useLoading";
import useError from '../../hooks/useError';


export default function SmjeroviDodaj(){

    const navigate = useNavigate()
    const { showLoading, hideLoading } = useLoading();
    const { prikaziError } = useError();

    async function dodaj(smjer) {
        showLoading();
        const odgovor = await SmjerService.dodaj(smjer)
        hideLoading();
        if(odgovor.greska){
            prikaziError(odgovor.poruka)
            return;
        }
        navigate(RouteNames.SMJER_PREGLED)
    }

    function obradiSubmit(e){ // e je event
        e.preventDefault(); // nemoj odraditi zahtjev na server
        let podaci = new FormData(e.target)
        //console.log(podaci.get('naziv'))
        dodaj({
            naziv: podaci.get('naziv'),
            cijena: parseFloat(podaci.get('cijena')),
            izvodiSeOd: moment.utc(podaci.get('izvodiSeOd')),
            vaucer: podaci.get('vaucer')=='on' ? true : false 
        })
    }

    return(
        <>
        Dodavanje smjera
        <Form onSubmit={obradiSubmit}>

            <Form.Group controlId="naziv">
                <Form.Label>Naziv</Form.Label>
                <Form.Control type="text" name="naziv" required />
            </Form.Group>

            <Form.Group controlId="cijena">
                <Form.Label>Cijena</Form.Label>
                <Form.Control type="number" step={0.01} name="cijena"  />
            </Form.Group>

            <Form.Group controlId="izvodiSeOd">
                <Form.Label>Izvodi se od</Form.Label>
                <Form.Control type="date" name="izvodiSeOd" />
            </Form.Group>

            <Form.Group controlId="vaucer">
                <Form.Check label="Vaučer" name="vaucer" />
            </Form.Group>

        <Row className="akcije">
            <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
            <Link to={RouteNames.SMJER_PREGLED} 
            className="btn btn-danger siroko">Odustani</Link>
            </Col>
            <Col xs={6} sm={12} md={9} lg={6} xl={6} xxl={6}>
            <Button variant="success"
            type="submit"
            className="siroko">Dodaj smjer</Button>
            </Col>
        </Row>
        </Form>
        </>
    )
}