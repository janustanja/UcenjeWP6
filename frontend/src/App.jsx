import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import NavBarEdunova from './components/NavBarEdunova'
import { Route, Routes } from 'react-router-dom'
import { RouteNames } from './constants'
import Pocetna from './pages/Pocetna'
import SmjeroviPregled from './pages/smjerovi/SmjeroviPregled'
import SmjeroviDodaj from './pages/smjerovi/SmjeroviDodaj'
import SmjeroviPromjena from './pages/smjerovi/SmjeroviPromjena'
import { Container } from 'react-bootstrap'
import PolazniciPregled from './pages/polaznici/PolazniciPregled'
import PolazniciDodaj from './pages/polaznici/PolazniciDodaj'
import PolazniciPromjena from './pages/polaznici/PolazniciPromjena'
import GrupePregled from './pages/grupe/GrupePregled'
import GrupeDodaj from './pages/grupe/GrupeDodaj'
import GrupePromjena from './pages/grupe/GrupePromjena'

import LoadingSpinner from './components/LoadingSpinner'
import Login from "./pages/Login"
import useAuth from "./hooks/useAuth"
import NadzornaPloca from './pages/NadzornaPloca'
import useError from "./hooks/useError"
import ErrorModal from "./components/ErrorModal"
import EraDijagram from './pages/EraDiagram'


function App() {

  const { isLoggedIn } = useAuth();
  const { errors, prikaziErrorModal, sakrijError } = useError();

  function godina(){
    const pocenta = 2024;
    const trenutna = new Date().getFullYear();
    if(pocenta===trenutna){
      return trenutna;
    }
    return pocenta + ' - ' + trenutna;
  }
  
  return (
    <>
      <LoadingSpinner />
      <ErrorModal show={prikaziErrorModal} errors={errors} onHide={sakrijError} />
      <Container className='aplikacija'>
        <NavBarEdunova />
        <Routes>
          <Route path={RouteNames.HOME} element={<Pocetna />} />
          {isLoggedIn ? (
        <>
        <Route path={RouteNames.NADZORNA_PLOCA} element={<NadzornaPloca />} />

          <Route path={RouteNames.SMJER_PREGLED} element={<SmjeroviPregled />} />
          <Route path={RouteNames.SMJER_NOVI} element={<SmjeroviDodaj />} />
          <Route path={RouteNames.SMJER_PROMJENA} element={<SmjeroviPromjena />} />

          <Route path={RouteNames.POLAZNIK_PREGLED} element={<PolazniciPregled />} />
          <Route path={RouteNames.POLAZNIK_NOVI} element={<PolazniciDodaj />} />
          <Route path={RouteNames.POLAZNIK_PROMJENA} element={<PolazniciPromjena />} />

          <Route path={RouteNames.GRUPA_PREGLED} element={<GrupePregled />} />
          <Route path={RouteNames.GRUPA_NOVI} element={<GrupeDodaj />} />
          <Route path={RouteNames.GRUPA_PROMJENA} element={<GrupePromjena />} /> 

          <Route path={RouteNames.ERA} element={<EraDijagram />} /> 
          </>
        ) : (
          <>
            <Route path={RouteNames.LOGIN} element={<Login />} />
          </>
        )}
        </Routes>
      </Container>
      <Container>
        <hr />
        Edunova &copy; {godina()}
      </Container>
    </>
  )
}

export default App
