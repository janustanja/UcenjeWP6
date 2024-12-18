using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z1
    {
        public static void Izvedi()
        {
            int broj = E12Metode.UcitajCijeliBroj("Unesi broj: ");
            while (broj < 0 || broj > 0)
            {
                Console.WriteLine("Broj mora biti između 1 i 9!");
                broj = E12Metode.UcitajCijeliBroj("Unesi broj:");
            }
            Console.WriteLine(Mnozi(broj));
        }
        private static int Mnozi(int broj)
        {
            if (broj >1 && broj < 10)
            {
                return broj * Mnozi(broj-1);
            }
            //return broj * Mnozi(broj - 1);
            return broj;

        }
    }
}
