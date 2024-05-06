using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Etkinlik_ve_Bilet_Satış_Platformu
{
    public partial class Form2 : Form
    {
        int seans1 = 0;
        int seans1ücret = 0;
        int seans2 = 0;
        int seans2ücret = 0;
        int seans3 = 0;
        int seans3ücret = 0;
        int mısır = 0;
        int fiyat =0;
        int su = 0;
        int sufiyat = 0;
        int kola = 0;
        int kolafiyat = 0;
        public Form2()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            seans1ücret = seans1ücret + 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ücret.ToString();


            if (seans1 == 10)
                button1.Enabled = false;
            if (seans1 >= 0)
                button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1ücret = seans1ücret - 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ücret.ToString();


            if (seans1 == 0)
                button2.Enabled = false;
            if (seans1 <= 10)
                button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2ücret = seans2ücret + 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ücret.ToString();
            if (seans2 == 10)
                button3.Enabled = false;
            if (seans2 >= 0)
                button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2ücret = seans2ücret - 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ücret.ToString();


            if (seans2 == 0)
                button4.Enabled = false;
            if (seans2 <= 10)
                button3.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3ücret = seans3ücret + 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ücret.ToString();


            if (seans3 == 10)
                button5.Enabled = false;
            if (seans3 >= 0)
                button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3ücret = seans3ücret - 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ücret.ToString();


            if (seans3 == 0)
                button6.Enabled = false;
            if (seans3 <= 10)
                button5.Enabled = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            mısır++;
            fiyat = fiyat + 3;
            textBox7.Text = mısır.ToString();
            textBox8.Text = fiyat.ToString();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            mısır--;
            fiyat = fiyat - 3;
            textBox7.Text = mısır.ToString();
            textBox8.Text = fiyat.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            kola++;
            kolafiyat = kolafiyat + 2;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolafiyat.ToString();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            kola--;
            kolafiyat = kolafiyat - 2;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolafiyat.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            su++;
            sufiyat = sufiyat + 1;
            textBox11.Text = su.ToString();
            textBox12.Text = sufiyat.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            su--;
            sufiyat = sufiyat - 1;
            textBox11.Text = su.ToString();
            textBox12.Text = sufiyat.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int toplamizleyici,toplamücret;
            toplamizleyici = seans1 + seans2 + seans3;
            label12.Text = toplamizleyici.ToString();
            toplamücret = seans1ücret + seans2ücret + seans3ücret;
            label14.Text = toplamücret.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int toplamsatılan, toplamfiyat;
            toplamsatılan = mısır + kola + su;
            label17.Text = toplamsatılan.ToString();

            toplamfiyat = fiyat + kolafiyat + sufiyat;
            label15.Text = toplamfiyat.ToString();

        }
    }
}
