using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Odev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Öğrenci bilgileri
            listBox.Items.Add("Öğrenci Adı: " + nameBox.Text);
            listBox.Items.Add("Öğrenci Soyadı: " + surnameBox.Text);
            listBox.Items.Add("Öğrenci Yaşı: " + ageBox.Text);

            int vize = int.Parse(VizeNotu.Text);
            int final = int.Parse(FinalNotu.Text);
            int sonuc = (vize + final)/2;

            listBox.Items.Add("Öğrenci Not Ortalaması: " + sonuc);

        }
       
    }
}
