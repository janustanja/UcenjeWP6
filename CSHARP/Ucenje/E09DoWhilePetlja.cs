using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E09DoWhilePetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E09");

            do
            {
                Console.WriteLine("Osijek");
            } while(false);

            int i = 1, suma =0;
            do
            {
                suma+= i;

            } while (++i <= 100);
            Console.WriteLine(suma);


        }
    }
}
