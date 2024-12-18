using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class _12Zadatak
    {
        //FAKTORIJELE od 1 do 10
        //al treba dodati while da kada unese neko krivi broj da mu se to kaze
        public static void Izvedi()
        {
            int broj = UcitajCijeliBroj("Unesi broj: ");
            Console.WriteLine(Mnozi(broj));
        }

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


            // return 0; // kasnije obrisati
        }
        private static int Mnozi(int broj)
        {
            if (broj > 1 && broj < 10)
            {
                return broj * Mnozi(broj - 1);
            }
            //return broj * Mnozi(broj - 1);
            return broj;

        }
    }
}
