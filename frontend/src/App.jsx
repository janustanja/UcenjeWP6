import 'bootstrap/dist/css/bootstrap.min.css'
import Container from 'react-bootstrap/Container';
import './App.css'
import NavBarEdunova from './components/NavBarEdunova';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constants';
import Pocetna from './pages/Pocetna';
import SmjeroviPregled from './pages/smjerovi/SmjeroviPregled';
import SmjeroviDodaj from './pages/smjerovi/SmjeroviDodaj';
import SmjeroviPromjena from './pages/smjerovi/SmjeroviPromjena';
import PolazniciPregled from './pages/polaznici/PolazniciPregled'
import PolazniciDodaj from './pages/polaznici/PolazniciDodaj'
import PolazniciPromjena from './pages/polaznici/PolazniciPromjena'
import GrupePregled from './pages/grupe/GrupePregled'
import GrupeDodaj from './pages/grupe/GrupeDodaj'
import GrupePromjena from './pages/grupe/GrupePromjena'


function App() {

  return (
    <>
    <Container>
      <NavBarEdunova />
      <Routes>
        <Route path={RouteNames.HOME} element={<Pocetna/>} />

        <Route path={RouteNames.SMJER_PREGLED} element={<SmjeroviPregled/>}/>
        <Route path={RouteNames.SMJER_NOVI} element={<SmjeroviDodaj/>}/>
        <Route path={RouteNames.SMJER_PROMJENA} element={<SmjeroviPromjena/>}/>

        <Route path={RouteNames.POLAZNIK_PREGLED} element={<PolazniciPregled />} />
        <Route path={RouteNames.POLAZNIK_NOVI} element={<PolazniciDodaj />} />
        <Route path={RouteNames.POLAZNIK_PROMJENA} element={<PolazniciPromjena />} />

        <Route path={RouteNames.GRUPA_PREGLED} element={<GrupePregled />} />
          <Route path={RouteNames.GRUPA_NOVI} element={<GrupeDodaj />} />
          <Route path={RouteNames.GRUPA_PROMJENA} element={<GrupePromjena />} />
      </Routes>
      <hr/>
      &copy; Edunova 2025
    </Container>
    
    </>
  )
}

export default App
