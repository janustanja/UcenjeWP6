using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class ZimskiZadaci
    {
        public static void Izvedi()
        {
            Console.WriteLine("Zimski zadaci!");
            Console.WriteLine("___________________________________________");
            Izbornik();
        }

        private static void Izbornik()
        {
            string[] zadaci =
            {
                "Izračun površine pravokutnika",
                "Provjera broja(pozitivan, negativan, nula)",
                "Zbroj elemenata niza",
                "Prosjek ocjena",
                "Ispis Fibonaccijevog niza",
                "Preokret stringa",
                "Brojanje samoglasnika",
                "Pretvorba temperature",
                "Sortiranje niza",
                "Kalkulator"
            };

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");

            for (int i = 0; i < zadaci.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, zadaci[i]);
            }
            Console.WriteLine("0. Izlaz iz zadataka");
            OdabirUIzborniku(zadaci.Length);
        }

        

        private static void OdabirUIzborniku(int brojZadatka)
        {
            switch (Metode.UcitajCijeliBroj("Odaberi opciju u izborniku: ", 0, brojZadatka))
            {
                case 0:
                    break;
                case 1:
                    IzracunPovrsinePravokutnika();
                    Izbornik();
                    break;
                case 2:
                    ProvjeraBrojaPozitivanNegativanNula();
                    Izbornik();
                    break;
                case 3:
                    ZbrojElemenataNiza();
                    Izbornik();
                    break;
                case 4:
                    ProsjekOcjena();
                    Izbornik();
                    break;
                case 5:
                    IspisFibonaccijevogNiza();
                    Izbornik();
                    break;
                case 6:
                    PreokretStringa();
                    Izbornik();
                    break;
                case 7:
                    BrojanjeSamoglasnika();
                    Izbornik();
                    break;
                case 8:
                    PretvorbaTemperature();
                    Izbornik();
                    break;
                case 9:
                    SortiranjeNiza();
                    Izbornik();
                    break;
                case 10:
                    Kalkulator();
                    Izbornik();
                    break;

            }
        }

        private static void Kalkulator()
        {                               ///////////////////////////////////////////
            int prviBroj = 0, drugiBRoj = 0;
             char op;
            Console.WriteLine("Unesi 1. broj: ");
            prviBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi 2. broj: ");
            drugiBRoj = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi operaciju koju želiš izvesti (zbrajanje, oduzimanje, množenje, dijeljenje): ");
            
 
            switch (4)
            {

            }
        }

        private static void SortiranjeNiza()
        {
            throw new NotImplementedException();
        }

        private static void PretvorbaTemperature()
        { ///dobro rijeseno
            int opcija = 0;
            double broj = 0;
            double pretvoreno=0;
            Console.WriteLine("Unesi broj ovisno o opciji koju želiš (1 C-->F ili 2 F-->C):");
            opcija = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi broj koji želiš pretvoriti: ");
            broj = double.Parse(Console.ReadLine());

            if (opcija ==1)
            {
                pretvoreno = broj * 9 / 5 + 32;
                Console.WriteLine("{0} °C je {1} °F.", broj, pretvoreno);
            }
            else if (opcija ==2)
            {
                pretvoreno = ((broj-32) / 1.8);
                Console.WriteLine("{0} °F je {1} °C.", broj, pretvoreno);
            }
        }

        private static void BrojanjeSamoglasnika()
        {
            throw new NotImplementedException();
        }

        private static void PreokretStringa()
        {
            throw new NotImplementedException();
        }

        private static void IspisFibonaccijevogNiza()
        {
            throw new NotImplementedException();
        }

        private static void ProsjekOcjena()
        {
            int brojOcjena = 0;
            Console.WriteLine("Unesi broj ocjena koji ćeš unesti: ");
            brojOcjena  = int.Parse(Console.ReadLine());
            int[] ocjene = new int[brojOcjena];
            for (int i = 0; i < brojOcjena; i++)
            {
                Console.WriteLine("Unesite {0}. ocjenu: ", i+1);
                ocjene[i] = int.Parse(Console.ReadLine());
            }
            int suma = 0;
            foreach (int i in ocjene)
            {
                suma+= i;   
            }
            Console.WriteLine("Prosjek ocjena je {0}.", suma%brojOcjena);   //treba stavit decimal


        }

        private static void ZbrojElemenataNiza()
        {
            int brojElemenata = 0;
            Console.WriteLine("Unesi broj brojeva koji ćeš unesti: ");
            brojElemenata = int.Parse(Console.ReadLine());
            int[] elementi = new int[brojElemenata];
            for (int i = 0; i < brojElemenata; i++)
            {
                Console.WriteLine("Unesite {0}. broj: ", i + 1);
                elementi[i] = int.Parse(Console.ReadLine());
            }
            int suma = 0;
            foreach (int i in elementi)
            {
                suma += i;
            }
            Console.WriteLine("Zbroj brojeva u nizu je {0}.", suma);     //provjeri jel tako trazi zadatak

        }

        private static void ProvjeraBrojaPozitivanNegativanNula()
        {
            Console.WriteLine("Unesi cijeli broj:");
            int broj = int.Parse(Console.ReadLine());
            if (broj == 0)
            {
                Console.WriteLine("Broj je nula.");
            }
            else if (broj % 2 == 1)
            {
                Console.WriteLine("Broj je neparan.");
            }
            else if (broj % 2 ==0)
            {
                Console.WriteLine("Broj je paran.");
            }
        }

        private static void IzracunPovrsinePravokutnika()
        {
            int duljina = 0, sirina = 0;
            Console.WriteLine("Unesi duljinu pravokutnika: ");
            duljina = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi širinu pravokutnika: ");
            sirina = int.Parse(Console.ReadLine());

            Console.WriteLine("Površina pravokutnika je {0}.", sirina * duljina);
        }
    }
}
