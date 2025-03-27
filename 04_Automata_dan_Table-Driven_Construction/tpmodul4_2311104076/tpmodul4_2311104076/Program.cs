// MENAMBAHKAN KODE DENGAN TEKNIK TABLE-DRIVEN 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpmodul3_2311104076;

namespace tpmodul3_2311104076
{
    class KodePos
    {
        private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
       {
           {"Batununggal", "40266" },
           {"Kujangsari", "40287"},
           {"Mengger", "40267"},
           {"Wates", "40256"},
           {"Cisarua", "40287"},
           {"Jatisari", "40286"},
           {"Margasari", "40286"},
           {"Sekejati", "40286"},
           {"Kebonwaru", "40272"},
           {"Maleer", "40274"},
           {"Samoja", "40273"}
       };

        public string GetKodePos(string kelurahan)
        {
            if (tabelKodePos.ContainsKey(kelurahan))
            {
                return tabelKodePos[kelurahan];
            }
            else
            {
                return "Kode pos tidak ditemukan";
            }
        }
    }
}

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();

        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        string hasilKodePos = kodePos.GetKodePos(kelurahan);
        Console.WriteLine($"Kode pos {kelurahan}: {hasilKodePos}");
    }
}


// MENAMBAHKAN KODE DENGAN TEKNIK STATE-BASED CONSTRUCTION

namespace tpmodul3_2311104076
{
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }
}


namespace tpmodul3_2311104076
{
    class Program2
    {
        static void Main()
        {
            DoorMachine pintu = new DoorMachine();

            Console.WriteLine("\nMenjalankan simulasi...");

            pintu.BukaPintu();
            pintu.BukaPintu();
            pintu.KunciPintu();
            pintu.KunciPintu();
        }
    }
}
