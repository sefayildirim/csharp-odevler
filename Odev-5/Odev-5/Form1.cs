using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Number.Text);

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i + ": çift sayıdır");
                }
                else
                {
                    listBox1.Items.Add(i + ": tek sayıdır");
                }
            }
        }
    }
}
