using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class _4Zadatak
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04");
            Console.WriteLine("Unesi 1. cijeli broj:");
            int broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi 2. cijeli broj:");
            int broj2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi 3. cijeli broj:");
            int broj3 = int.Parse(Console.ReadLine());

            if (broj1 < broj2 && broj1 < broj3)
            {
                Console.WriteLine("Najmanji navedeni broj je {0}.", broj1);
            }
            else if (broj2 < broj1 && broj2 < broj3)
            {
                Console.WriteLine("Najmanji navedeni broj je {0}.", broj2);
            }
            else if (broj3 < broj1 && broj3 < broj2)
            {
                Console.WriteLine("Najmanji navedeni broj je {0}.", broj3);
            }
            else
            {
                Console.WriteLine("Jednaki brojevi.");
            }
        }
    }
}
