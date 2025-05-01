using System;
using AljabarLibraries;

class Program
{
    static void Main(string[] args)
    {
        Aljabar aljabar = new Aljabar();

        // Contoh 1: Akar persamaan kuadrat x^2 - 3x - 10 = 0
        double[] akar = aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
        Console.WriteLine("Akar-akarnya: {0}, {1}", akar[0], akar[1]);

        // Contoh 2: Hasil kuadrat dari 2x - 3
        double[] kuadrat = aljabar.HasilKuadrat(new double[] { 2, -3 });
        Console.WriteLine("Hasil kuadrat: {0}x^2 + {1}x + {2}", kuadrat[0], kuadrat[1], kuadrat[2]);
    }
}
