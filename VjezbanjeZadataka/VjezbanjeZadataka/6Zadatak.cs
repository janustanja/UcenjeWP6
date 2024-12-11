using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class _6Zadatak
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite 1. cijeli broj: ");
            int broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite 2. cijeli broj: ");
            int broj2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Brojevi između {0} i {1} su: ", broj1, broj2);

            if (broj1 < broj2)
            {
                for (int i = broj1; i <= broj2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (broj1 > broj2)
            {
                for (int i = broj2; i >= broj1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Greška! Unesli ste iste brojeve.");
            }




            
        }
    }
}
