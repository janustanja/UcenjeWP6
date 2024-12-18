using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Rekurzija
    {
        public static void Izvedi()
        {

            Console.WriteLine(Zboji(100));
            
        }
        private static int Zboji(int broj)
        {
            if (broj == 1)
            {
                return 1;
            }
            return broj + Zboji(broj - 1);
        }
    }
}
