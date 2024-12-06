using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class _Zadatak2
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite broj godina: ");
            int godine = int.Parse(Console.ReadLine());
            if (godine >= 18 && godine <= 112)
            {
                Console.WriteLine("Punoljetni ste!");
            }
            else if (godine < 18 && godine >= 0)
            {
                Console.WriteLine("Maloljetni ste.");
            }
            else if (godine < 0)
            {
                Console.WriteLine("Greška.");
            }
            else if (godine > 112)
            {
                Console.WriteLine("Greška.");
            }

        }
    }
}