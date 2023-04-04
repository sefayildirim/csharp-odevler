using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = int.Parse(VizeNotu.Text);
            int final = int.Parse(FinalNotu.Text);
            int proje = int.Parse(ProjeNotu.Text);
            int sonuc = (vize + final + proje) / 3;

            string harfNotu = "";

            switch (sonuc)
            {
                case int n when (n<=20):
                    harfNotu = "F";
                    break;
                case int n when (n >= 21 && n <= 40):
                    harfNotu = "D";
                    break;
                case int n when (n >= 41 && n <= 60):
                    harfNotu = "C";
                    break;
                case int n when (n >= 61 && n <= 80):
                    harfNotu = "B";
                    break;
                case int n when (n >= 81 && n <= 100):
                    harfNotu = "A";
                    break;
                default:
                    harfNotu = "Geçersiz not değeri!";
                    break;
            }

            listBox.Items.Add("Öğrenci Not Ortalaması: " + sonuc + " Harf notu: " + harfNotu);

        }
    }
}
