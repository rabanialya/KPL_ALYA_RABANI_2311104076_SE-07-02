using System;

namespace StringLibrary
{
    public class Aljabar
    {
        public double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double diskriminan = b * b - 4 * a * c;

            if (diskriminan < 0)
                throw new ArgumentException("Akar tidak real");

            double akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);

            return new double[] { akar1, akar2 };
        }

        // B. Mengkuadratkan persamaan berpangkat 1
        public double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double a2 = a * a;
            double ab2 = 2 * a * b;
            double b2 = b * b;

            return new double[] { a2, ab2, b2 };
        }
    }
}
