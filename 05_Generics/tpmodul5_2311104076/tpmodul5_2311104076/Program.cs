using System;

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}


class Program
{
    static void Main()
    {
        // Simpan NIM dalam DataGeneric
        DataGeneric<string> dataNIM = new DataGeneric<string>("2311104076");

        // Panggil method PrintData()
        dataNIM.PrintData();

        Console.ReadLine();
    }
}
