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
            // Müşteri bilgileri
            listBox.Items.Add("Müşteri Adı: " + nameBox.Text);
            listBox.Items.Add("Müşteri Soyadı: " + surnameBox.Text);
            listBox.Items.Add("Müşteri Yaşı: " + ageBox.Text);

            // Müşteri şikayeti
            listBox.Items.Add("Müşteri Şikayeti: " + customerComplaint.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tarih
            listBox.Items.Add("Tarih: " + date.Text);
        }
    }
}
