using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka.ZavrsniRad
{
    public class Vozilo : Entitet
    { 
        public VrstaVozila VrstaVozila { get; set; }
        public Dobavljac Dobavljac { get; set; }
        public string Marka { get; set; }
        public string GodProizvodnje { get; set; }
        public int PrijedeniKm { get; set; }
        public decimal Cijena { get; set; }
        public Kupac Kupac { get; set; }
    }
}
