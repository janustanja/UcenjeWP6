using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E10");

            Console.Write("Unesi izraz (bez razmaka): ");
            string izraz= Console.ReadLine();
            if (izraz.Length % 2 == 0)
            {
                //Console.WriteLine("Parno");
                bool palindrom = true;
                for (int i = 0; i< izraz.Length /2; i++)
                {
                    if (izraz[i] != izraz[izraz.Length - 1 - i])
                    {
                        palindrom = false;
                        break;
                    }
                }
                Console.WriteLine(palindrom ? "Da" : "Ne");
            }
            else
            {
                Console.WriteLine("Neparno");

            }

            
        }
    }
}
