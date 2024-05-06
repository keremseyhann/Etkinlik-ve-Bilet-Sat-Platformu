using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Etkinlik_ve_Bilet_Satış_Platformu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int vip1 = 0;
        int vip1ücret = 0;
        int vip2 = 0;
        int vip2ücret = 0;
        int vip3 = 0;
        int vip3ücret = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            vip1++;
            vip1ücret = vip1ücret + 50;
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
            vip1ücret = vip1ücret - 50;
            textBox1.Text = vip1.ToString();
            textBox2.Text = vip1ücret.ToString();


            if (vip1 == 0)
                button2.Enabled = false;
            if (vip1 <= 10)
                button1.Enabled = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            vip2++;
            vip2ücret = vip2ücret + 25;
            textBox3.Text = vip2.ToString();
            textBox4.Text = vip2ücret.ToString();


            if (vip2 == 10)
                button3.Enabled = false;
            if (vip2 >= 0)
                button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vip2--;
            vip2ücret = vip2ücret - 25;
            textBox3.Text = vip2.ToString();
            textBox4.Text = vip2ücret.ToString();


            if (vip2 == 0)
                button4.Enabled = false;
            if (vip2 <= 10)
                button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vip3++;
            vip3ücret = vip3ücret + 10;
            textBox5.Text = vip3.ToString();
            textBox6.Text = vip3ücret.ToString();


            if (vip3 == 10)
                button3.Enabled = false;
            if (vip3 >= 0)
                button4.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vip3--;
            vip3ücret = vip3ücret - 10;
            textBox5.Text = vip3.ToString();
            textBox6.Text = vip3ücret.ToString();


            if (vip3 == 0)
                button4.Enabled = false;
            if (vip3 <= 10)
                button3.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int toplamizleyici,toplamücret;
            toplamizleyici = vip1 + vip2 + vip3;
            label12.Text = toplamizleyici.ToString();
            toplamücret = vip1ücret + vip2ücret + vip3ücret;
            label14.Text = toplamücret.ToString();


        }
    }
}
