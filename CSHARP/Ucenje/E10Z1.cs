using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Za dani izraz bez razmaka provjeriti da li je palindrom

    internal class E10Z1
    {

        //abbi
        //kisik
        //anavolimilovana
        //amenetuniminutenema

        public static void Izvedi()
        {
            Console.WriteLine("Palindrom");
            string izraz = E12Metode.UcitajString("Unesi izraz za provjeru palindroma: ");
            bool palindrom = true;
            izraz = izraz.ToUpper();
            //Console.WriteLine(izraz[0]);
            //Console.WriteLine(izraz[izraz.Length - 1 - 0]);
            //Console.WriteLine(izraz[1]);
            //Console.WriteLine(izraz[izraz.Length - 1 - 1]);
            for (int i = 0; i < izraz.Length; i++)
            {
                if (izraz[i] != izraz[izraz.Length - 1 - i])
                {
                    palindrom = false;
                    break;
                }

            }
            Console.WriteLine("Izraz {0} {1} palindrom!", izraz, palindrom ? "je" : "nije");
        }
    }

}
