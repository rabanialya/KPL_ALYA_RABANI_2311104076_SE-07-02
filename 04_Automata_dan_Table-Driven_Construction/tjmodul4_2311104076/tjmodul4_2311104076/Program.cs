using System;
class KodeBuah
{
    public string GetKodeBuah(string namaBuah)
    {
        switch (namaBuah.ToLower())
        {
            case "apel":
                return "A00";
            case "aprikot":
                return "B00";
            case "alpukat":
                return "C00";
            case "pisang":
                return "D00";
            case "paprika":
                return "E00";
            case "blackberry":
                return "F00";
            case "cherry":
                return "H00";
            case "kelapa":
                return "J00";
            case "kurma":
                return "K00";
            case "durian":
                return "L00";
            case "anggur":
                return "M00";
            case "melon":
                return "N00";
            case "semangka":
                return "O00";
            default:
                return "Kode tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodeBuah kodeBuah = new KodeBuah();
        Console.WriteLine("Masukkan nama buah:");
        string namaBuah = Console.ReadLine();
        string kode = kodeBuah.GetKodeBuah(namaBuah);
        Console.WriteLine($"Kode untuk {namaBuah} adalah: {kode}");
    }
}
