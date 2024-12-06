using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E06Nizovi
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E06");

            int[] temp = new int[12];

            temp[0] = 2;
            temp[11] = 4;
            Console.WriteLine(temp);
            Console.WriteLine(string.Join(", ", temp));

            int[,] tablica =
            {
                {1, 2, 3, },
                {4, 5, 6, },
                {7, 8, 9, }
            };
            Console.WriteLine( tablica[1,2]);


        }
    }
}
