using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08WhilePetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E08");

            int brojDo = 0;
            for (int i = 0; i<brojDo; i++)
            {
                Console.WriteLine(i);
            }

            while (true)
            {
                Console.WriteLine("Osijek");
                break;
            }

            int broj = 0;
            while ((broj < 10))
            {
                Console.WriteLine(++broj);
            }

            int sum = 0;
            int j= 1;
            while( j <= 100)
            {
                sum += j++;   
            }
            Console.WriteLine(sum);
        }
    }
}
