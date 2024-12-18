using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class _13Zadatak
    {
        public static void Izvedi()
        {
            //ima vise podzadataka

            //Zad1();
            Zad2();

        }
        public static string UcitajString(string poruka)
        {
            string s = "";
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    Console.WriteLine("Obvezan unos!");
                    continue;
                }
                return s;
            }
            //return "";
        }
        private static void Zad1()
        {
            Console.WriteLine("Dobrodošli u 1.zadatak!");
            string ime;
            while (true)
            {
                ime =UcitajString("Unesi ime osobe (NE za kraj- prekid programa):");
                if (ime.ToUpper() == "NE")
                {
                    Console.WriteLine("Hvala na korištenju programa, 1. zadatak!");
                    break;
                }
                Console.WriteLine(ime.Length);
            }
        }
        private static void Zad2()
        {
            string ime = UcitajString("Unesi ime osobe: ");
            string prezime = UcitajString("Unesi prezime osobe: ");
            Console.WriteLine("{0} {1}", prezime, ime);
        }
    }
    
}
