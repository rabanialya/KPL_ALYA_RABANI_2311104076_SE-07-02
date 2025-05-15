using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tjmodul12_2311104076
{
    public class BilanganHelper
    {
        public static string CariTandaBilangan(int a)
        {
            if (a < 0) return "Negatif";
            else if (a > 0) return "Positif";
            else return "Nol";
        }
    }
}
