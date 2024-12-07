using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class _0Zadatak
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite svoje ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite broj godina:");
            int godine = int.Parse(Console.ReadLine());

            Console.WriteLine("Osoba {0} ima {1} godina!", ime, godine);
        }
    }
}
