using System;
using MatematikaLibraries;

namespace ShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematika math = new Matematika();

            Console.WriteLine("FPB 60 & 45 = " + math.FPB(60, 45));
            Console.WriteLine("KPK 12 & 8 = " + math.KPK(12, 8));

            int[] persamaan1 = { 1, 4, -12, 9 };
            Console.WriteLine("Turunan dari x^3 + 4x^2 - 12x + 9 adalah: ");
            Console.WriteLine(math.Turunan(persamaan1));

            int[] persamaan2 = { 4, 6, -12, 9 };
            Console.WriteLine("Integral dari 4x^3 + 6x^2 - 12x + 9 adalah: ");
            Console.WriteLine(math.Integral(persamaan2));

            Console.ReadLine();
        }
    }
}
