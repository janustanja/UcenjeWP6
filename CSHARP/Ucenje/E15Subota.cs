using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E15Subota
    {
        public static void Izvedi()
        {
            PrimjerTryCatch();

        }
        private static void PrimjerTryCatch()
        {
            try
            {
                int.Parse("Osijek");

            }
            catch
            {
                Console.WriteLine("Žao nam je zbog greške!");
            }
            bool vrijednost = false;
            Console.WriteLine("Jesi li zaposlen/a? (Upiši DA ili bilo što za ne)");
            if (Console.ReadLine().Trim().ToUpper() == "DA")
            {
                vrijednost= true;
            }
            Console.WriteLine(vrijednost);


            Console.WriteLine(E12Metode.UcitajBool("Jesi li zaposlen/a? (Unesi DA ili bilo što za ne)", "DA"));
            Console.WriteLine(E12Metode.UcitajBool("Jutros sam pojeo 3 sendviča.(Istina / Laž)", "Laž"));

  
            

        }
    }
}
