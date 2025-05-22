using System;
using System.Collections.Generic;

namespace TpModul14_2311104076
{
    public class KodeBuah
    {
        // Dictionary digunakan untuk table-driven approach
        private readonly Dictionary<string, string> _kodeBuahDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Apel", "A00" },
            { "Aprikot", "B00" },
            { "Alpukat", "C00" },
            { "Pisang", "D00" },
            { "Paprika", "E00" },
            { "Blackberry", "F00" },
            { "Cherry", "H00" },
            { "Kelapa", "J00" },
            { "Kurma", "K00" },
            { "Durian", "L00" },
            { "Anggur", "M00" },
            { "Melon", "N00" },
            { "Semangka", "O00" }
        };
        public string GetKodeBuah(string namaBuah)
        {
            if (_kodeBuahDictionary.TryGetValue(namaBuah, out string kode))
            {
                return kode;
            }
            return "Kode tidak ditemukan";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            KodeBuah kodeBuah = new KodeBuah();

            Console.Write("Masukkan nama buah: ");
            string inputNamaBuah = Console.ReadLine();

            string kode = kodeBuah.GetKodeBuah(inputNamaBuah);
            Console.WriteLine($"Kode untuk {inputNamaBuah} adalah: {kode}");
        }
    }
}
