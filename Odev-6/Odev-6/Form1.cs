using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_6
{
      public partial class Form1 : Form {
        int timeLeft = 0;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;

            label1.Text = "Hamur hazırlanıyor...";
            label1.ForeColor = System.Drawing.Color.Red;
            timeLeft = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            progressBar1.Value = 100 - timeLeft;

            if (timeLeft == 0)
            {
                timer1.Stop();
                progressBar1.Value = 100;
                label1.Text = "Hamur hazır!";
                label1.ForeColor = System.Drawing.Color.DarkBlue;

                label2.Text = "Malzeme ekleniyor...";
                label2.ForeColor = System.Drawing.Color.Red;
                timeLeft = 100;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            progressBar2.Value = 100 - timeLeft;

            if (timeLeft == 0)
            {
                timer2.Stop();
                progressBar2.Value = 100;
                label2.Text = "Malzemeler hazır!";
                label2.ForeColor = System.Drawing.Color.DarkBlue;

                label3.Text = "Fırına veriliyor...";
                label3.ForeColor = System.Drawing.Color.Red;
                timeLeft = 100;
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            progressBar3.Value = 100 - timeLeft;

            if (timeLeft == 0)
            {
                timer3.Stop();
                progressBar3.Value = 100;
                label3.Text = "Pizza pişti!";
                label3.ForeColor = System.Drawing.Color.DarkBlue;

                label4.Text = "Kutulanıyor...";
                label4.ForeColor = System.Drawing.Color.Red;
                timeLeft = 100;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            progressBar4.Value = 100 - timeLeft;

            if (timeLeft == 0) {
                timer4.Stop();
                progressBar4.Value = 100;
                label4.Text = "Pizza hazır!";
                label4.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }
    }
}
