using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class _5Zadatak
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            if(broj%2 == 0)
            {
                int suma = 0;
                for (int i = 0; i <= broj; i++)
                {
                    suma +=i;
                }
                Console.WriteLine(suma);
            }

            else
            {
                for (int i = 0;i <= broj; i++)
                {
                    if (i % 2 == 1)
                        {
                            Console.WriteLine(i);
                        }

                }
            }

        }
    }
}
