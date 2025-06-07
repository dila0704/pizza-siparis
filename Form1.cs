using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calısmadosyası
{
    public partial class PizzaSipariş : Form
    {
        public PizzaSipariş()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = 75;

            if (parmesan.Checked == true)
            {
                fiyat += 40;
            }
            else
            {
                fiyat += 30;
            }
            if (domatessosu.Checked == true)
            {
                fiyat += 15;
            }
            else
            {
                fiyat += 20;
            }

            if (zeytin.Checked == true)
            {
                fiyat += 15;
            }
            if (sucuk.Checked == true)
            {
                fiyat += 25;
            }
            if (mısır.Checked == true)
            {
                fiyat += 10;
            }
            if (salam.Checked == true)
            {
                fiyat += 20;
            }
           

            textBox1.Text=fiyat.ToString();
                }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
