using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ucenje
{
    internal class E04UvjetnoGrananjeIf
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04");
            int i = 0;
            bool uvjet = i == 0;
            Console.WriteLine(uvjet);
            if (uvjet)
            {
                Console.WriteLine("Vrijednost varijable i je 0.");
            }

            if (i == 0)
            {
                Console.WriteLine("Češća sintaksa za provjeru da je i 0.");
            }
            i = 17;
            if (i >= 18)
            {
                Console.WriteLine("Punoljetna osoba.");
            }
            else
            {
                Console.WriteLine("Maloljetna osoba.");
            }

            if (i > 5)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Greška.");
                Console.WriteLine("Dio greške.");

            i = 0;
            int j = 2;
            if(i==5 & j == 2)
            {
                Console.WriteLine("Dvostruki uvjet je zadovoljen.");
            }

            if (i==5 && j == 2)
            {
                Console.WriteLine("Dvostruki uvjet je zadovoljen.");
            }
            
            if (i==0 | j == 0)
            {
                Console.WriteLine("Prvi uvjet je zadovoljen.");
            }

            if (i==0 || j == 0)
            {
                Console.WriteLine("Prvi uvjet je zadovoljen.");
            }

            if (i > 0)
            {
                if (j > 0)
                {
                    Console.WriteLine("Ugnježđivanje.");
                }
            }

            i = 2;
            if (i == 0)
            {
                Console.WriteLine("Nula");
            }
            else if (i == 1)
            {
                Console.WriteLine("Jedan");
            }
            else
            {
                Console.WriteLine("Ostali brojevi.");
            }


            string grad = "Otok";
            if (grad== "Osijek")
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Nije super!");
            }


            Console.WriteLine(grad=="Osijek" ?  "Super!!!" : "Nije super!!!");

            Console.WriteLine((grad=="Osijek" ? "" : "Nije ") + "Super!!");














        }

    }
}
