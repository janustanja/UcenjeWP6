using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public class Program
    {
        public Program () 
        {
            Console.WriteLine("E18");
            var smjer = new Smjer() { Sifra=1, Naziv="Web programiranje"};

            Console.WriteLine(smjer);

            var osoba = new Osoba() { Sifra = 1, Ime = "Pero", Prezime = "Perić" };

            Console.WriteLine(osoba);

            string s1 = "AA";
            Console.WriteLine(s1.GetHashCode());

            s1 = "BB";
            Console.WriteLine(s1.GetHashCode());

            var sb = new StringBuilder();

            sb.Append("AA");

            Console.WriteLine(sb.GetHashCode());

            sb.Clear().Append("BB");

            Console.WriteLine(sb.GetHashCode());

            Smjer smjer1 = new Smjer() { Naziv = "Web programiranje" };
            Smjer smjer2 = new Smjer() { Naziv = "Web programiranje" };


            Console.WriteLine(smjer1.GetHashCode());
            Console.WriteLine(smjer2.GetHashCode());

            Console.WriteLine(smjer.Equals(smjer2));






        }

    }
}
