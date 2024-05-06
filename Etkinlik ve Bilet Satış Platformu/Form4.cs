using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Etkinlik_ve_Bilet_Satış_Platformu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int vip1 = 0;
        int vip1ücret = 0;
        int kategori1 = 0;
        int kategori1ücret = 0;
        int kategori2 = 0;
        int kategori2ücret = 0;
        int kategori3 = 0;
        int kategori3ücret = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            vip1++;
            vip1ücret = vip1ücret + 1000;
            textBox1.Text = vip1.ToString();
            textBox2.Text = vip1ücret.ToString();


            if (vip1 == 10)
                button1.Enabled = false;
            if (vip1 >= 0)
                button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vip1--;
            vip1ücret = vip1ücret - 1000;
            textBox1.Text = vip1.ToString();
            textBox2.Text = vip1ücret.ToString();


            if (vip1 == 0)
                button2.Enabled = false;
            if (vip1 <= 10)
                button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kategori1++;
            kategori1ücret = kategori1ücret + 500;
            textBox3.Text = kategori1.ToString();
            textBox4.Text = kategori1ücret.ToString();


            if (kategori1 == 10)
                button3.Enabled = false;
            if (kategori1 >= 0)
                button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kategori1--;
            kategori1ücret = kategori1ücret - 500;
            textBox3.Text = kategori1.ToString();
            textBox4.Text = kategori1ücret.ToString();


            if (kategori1 == 0)
                button4.Enabled = false;
            if (kategori1 <= 10)
                button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kategori2++;
            kategori2ücret = kategori2ücret + 200;
            textBox5.Text = kategori2.ToString();
            textBox6.Text = kategori2ücret.ToString();


            if (kategori2 == 10)
                button5.Enabled = false;
            if (kategori2 >= 0)
                button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kategori2--;
            kategori2ücret = kategori2ücret - 200;
            textBox5.Text = kategori2.ToString();
            textBox6.Text = kategori2ücret.ToString();


            if (kategori2 == 0)
                button6.Enabled = false;
            if (kategori2 <= 10)
                button5.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kategori3++;
            kategori3ücret = kategori3ücret + 200;
            textBox7.Text = kategori3.ToString();
            textBox8.Text = kategori3ücret.ToString();


            if (kategori3 == 10)
                button7.Enabled = false;
            if (kategori3 >= 0)
                button8.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kategori3--;
            kategori3ücret = kategori3ücret - 200;
            textBox7.Text = kategori3.ToString();
            textBox8.Text = kategori3ücret.ToString();


            if (kategori2 == 0)
                button8.Enabled = false;
            if (kategori2 <= 10)
                button7.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int toplamizleyici, toplamücret;
            toplamizleyici = vip1 + kategori1 + kategori2 + kategori3;
            label12.Text = toplamizleyici.ToString();
            toplamücret = vip1ücret + kategori1ücret + kategori2ücret + kategori3ücret;
            label14.Text = toplamücret.ToString();
        
        
        }
    }
}
