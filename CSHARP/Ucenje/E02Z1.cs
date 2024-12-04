using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02Z1
    {

        public static void Izvedi()
        {
           


            Console.Write("Unesi ime: ");
            string ime = Console.ReadLine();
            int i;
            Console.WriteLine("Upiši broj godina: ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine(" Osoba {0} ima {1} godina.", ime, i);


        }

    }
}
