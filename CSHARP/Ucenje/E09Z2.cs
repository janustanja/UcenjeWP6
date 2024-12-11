using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E09Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E09");
            int broj, suma=0;
            while (true)
            {
                Console.WriteLine("Unosi brojeve (kada je kraj unesi -1): ");
                broj = int.Parse(Console.ReadLine());
                if (broj == -1)
                {
                    break;
                }
                suma = suma+ broj;
            }
            Console.WriteLine(suma);
        }
    }
}
