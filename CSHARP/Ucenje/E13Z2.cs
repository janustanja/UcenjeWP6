using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z2
    {
        public static void Izvedi()
        {
            //Zad1();
            Zad2();

        }
        private static void Zad1()
        {
            Console.WriteLine("Dobrodošli u 1.zadatak!");
            string ime;
            while (true)
            {
                ime = E12Metode.UcitajString("Unesi ime osobe (NE za kraj- prekid programa):");
                if(ime.ToUpper() == "NE")
                {
                    Console.WriteLine("Hvala na korištenju programa, 1. zadatak!");
                    break;
                }
                Console.WriteLine(ime.Length);
            }
        }
        private static void Zad2()
        {
            string ime = E12Metode.UcitajString("Unesi ime osobe: ");
            string prezime = E12Metode.UcitajString("Unesi prezime osobe: ");
            Console.WriteLine( "{0} {1}",prezime, ime);
        }

    }
}
