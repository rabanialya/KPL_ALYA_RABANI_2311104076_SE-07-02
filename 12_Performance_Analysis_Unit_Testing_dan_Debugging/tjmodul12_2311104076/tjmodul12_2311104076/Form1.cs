using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tjmodul12_2311104076
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int a) && int.TryParse(textBox2.Text, out int b))
            {
                int hasil = CariNilaiPangkat(a, b);
                Hasil.Text = $"Hasil: {hasil}";
            }
            else
            {
                Hasil.Text = "Input tidak valid.";
            }
        }
        public int CariNilaiPangkat(int a, int b)
        {
            if (b < 0)
                return -2;

            try
            {
                long hasil = 1;

                for (int i = 0; i < b; i++)
                {
                    hasil *= a;
                    if (hasil > int.MaxValue || hasil < int.MinValue)
                        return -3;
                }

                return (int)hasil;
            }
            catch
            {
                return -1;
            }

        }
    }
}

