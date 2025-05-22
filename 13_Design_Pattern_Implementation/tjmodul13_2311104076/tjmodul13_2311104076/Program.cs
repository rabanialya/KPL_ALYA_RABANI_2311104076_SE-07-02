using tjmodul13_2311104076;
using System;

class Program
{
    static void Main(string[] args)
    {
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        // Tambah data
        data1.AddSebuahData("Anggota 1 - Alya");
        data1.AddSebuahData("Anggota 2 - Tulus");
        data1.AddSebuahData("Anggota 3 - Zhafir");
        data1.AddSebuahData("Asisten Praktikum - Gideon Torawa");

        // Print dari data2
        Console.WriteLine("Print dari data2:");
        data2.PrintSemuaData();

        // Hapus asisten dari data2
        data2.HapusSebuahData(3); 

        // Print dari data1
        Console.WriteLine("\nPrint dari data1 setelah penghapusan:");
        data1.PrintSemuaData();

        // Print jumlah data
        Console.WriteLine($"\nJumlah Data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah Data di data2: {data2.GetSemuaData().Count}");
    }
}
