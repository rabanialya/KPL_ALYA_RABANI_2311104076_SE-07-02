using System.Text.Json;
using System.IO;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    private const string filePath = "covid_config.json";

    // Nilai default
    public CovidConfig()
    {
        satuan_suhu = "celcius";
        batas_hari_deman = 14;
        pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
    }

    public void LoadConfig()
    {
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            var config = JsonSerializer.Deserialize<CovidConfig>(jsonString);
            satuan_suhu = config.satuan_suhu;
            batas_hari_deman = config.batas_hari_deman;
            pesan_ditolak = config.pesan_ditolak;
            pesan_diterima = config.pesan_diterima;
        }
        else
        {
            SaveConfig(); // Simpan default config kalau belum ada file
        }
    }

    public void SaveConfig()
    {
        string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }

    public void UbahSatuan()
    {
        if (satuan_suhu.ToLower() == "celcius")
        {
            satuan_suhu = "fahrenheit";
        }
        else
        {
            satuan_suhu = "celcius";
        }
        SaveConfig(); // simpan perubahan satuan
    }
}


class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();
        config.LoadConfig();

        // Ubah satuan dulu (sesuai poin G)
        config.UbahSatuan();
        Console.WriteLine("Satuan suhu sekarang: " + config.satuan_suhu);

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hariDemam = Convert.ToInt32(Console.ReadLine());

        bool suhuNormal = false;

        if (config.satuan_suhu.ToLower() == "celcius")
        {
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        }
        else if (config.satuan_suhu.ToLower() == "fahrenheit")
        {
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;
        }

        bool hariValid = hariDemam < config.batas_hari_deman;

        if (suhuNormal && hariValid)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }
    }
}

