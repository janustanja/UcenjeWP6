using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class Metode
    {
        public static int UcitajCijeliBroj(string poruka)
        {

            while (true)
            {
                Console.Write(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }

        public static int UcitajCijeliBroj(string poruka, int min, int max)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i < min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} - {1}", min, max);
                        continue;
                    }
                    return i;
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }

        }
    }
}
