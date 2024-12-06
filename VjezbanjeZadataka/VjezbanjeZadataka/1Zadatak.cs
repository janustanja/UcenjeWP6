using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka
{
    internal class _1Zadatak
    {
        public static void Izvedi()
        {
            int a = 0, b = 0;
            Console.WriteLine("Unesi 1. broj: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi 2. broj: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj: {0}", a + b);
            Console.WriteLine("Razlika: {0}", b - a);
            Console.WriteLine("Umnožak: {0}", a * b);
            Console.WriteLine("Zbroj kvadrata: {0}", (a * a) + (b * b));
            Console.WriteLine("Kvocijent: {0}", a / b);
        }
    }
}
