using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Implement_dp
{
    public interface IAmericanPlug
    {
        void PlugIn();
    }
    public class IndonessianPlug
    {
        public void Sambungkan()
        {
            Console.WriteLine("Colokan Indonesia tersambung");
        }
    }
    public class PlugAdaptor : IAmericanPlug
    {
        private readonly IndonessianPlug _plug;
        public PlugAdaptor(IndonessianPlug indonesianplug)
        {
            _plug = indonesianplug;
        }
        public void PlugIn()
        {
            Console.WriteLine("Menggunakan adapter colokan Indonesia ke Amerika");
            _plug.Sambungkan();
        }
    }
}
