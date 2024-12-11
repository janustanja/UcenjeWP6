using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class _7Zadatak
    {
        public static void Izvedi()
        {
            Console.Write("Unesite cijeli broj : ");
            int broj = int.Parse(Console.ReadLine());
            int i = 1;
            int suma = 0;
            while (i <= broj)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
                i++;
            }
            Console.WriteLine(suma);
        }

    }
}
