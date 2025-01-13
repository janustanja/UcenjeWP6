using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    internal class Osoba
    {
        public int Sifra { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }

        public string ImePrezime()
        {
            Console.WriteLine("Izvođenje metode s objekta!");
            return Ime + " " + Prezime;
        }

        public static void Izvedi()
        {
            Console.WriteLine("Izvođenje statične metode s klase!");
        }

    }
}
