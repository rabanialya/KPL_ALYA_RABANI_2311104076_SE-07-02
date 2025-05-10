using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul12_2311104076
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(inputTextBox.Text, out input))
            {
                string hasil = BilanganHelper.CariTandaBilangan(input);
                resultLabel.Text = $"Tanda bilangan: {hasil}";
            }
            else
            {
                resultLabel.Text = "Input tidak valid!";
            }
        }

        public static string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }
    }
}
