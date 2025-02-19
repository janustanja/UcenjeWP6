
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import { useNavigate } from 'react-router-dom';
import { RouteNames } from '../constants';

export default function NavBarEdunova(){

    const navigate = useNavigate(); // U pravilu ; ne treba

    return(
        <>
            <Navbar expand="lg" className="bg-body-tertiary">
                <Navbar.Brand className='ruka'
                onClick={()=>navigate(RouteNames.HOME)}
                >Edunova APP [WP6]</Navbar.Brand>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav">
                    <Nav className="me-auto">
                    
                    <NavDropdown title="Programi" id="basic-nav-dropdown">
                        <NavDropdown.Item

                        onClick={()=>navigate(RouteNames.SMJER_PREGLED)}

                        >Smjerovi</NavDropdown.Item>
                        <NavDropdown.Item onClick={()=>navigate(RouteNames.POLAZNIK_PREGLED)}>
                        Polaznici
                        </NavDropdown.Item>
                        <NavDropdown.Item onClick={()=>navigate(RouteNames.GRUPA_PREGLED)}>Grupe</NavDropdown.Item>
                        
                       
                    </NavDropdown>
                    <Nav.Link href="https://tjakopec-001-site2.ntempurl.com/swagger/index.html" target='_blank'>Swagger</Nav.Link>
                    </Nav>
                </Navbar.Collapse>
            </Navbar>
        </>
    )
}