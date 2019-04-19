using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2lik_tabandan_10_luk_tabana_çevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi;
        int mod;
        int toplam = 0;
        int kuvvet = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            //button1 e tıklandığında girilen sayının 2lik tabandaki karşılığını label1 e yazıyor..
            label1.Text = "";
            sayi = Convert.ToInt32(textBox1.Text);

            while (sayi > 1)
            {
                mod = sayi % 2;
                sayi = sayi / 2;
                label1.Text = mod.ToString() + label1.Text;
            }
            label1.Text = sayi.ToString()+label1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2 ye tıklandığında label2 ye basamaklı ayrı bir şekilde yazıyor..

            label2.Text = "";
            sayi = Convert.ToInt32(textBox1.Text);

            while(sayi>0)
            {
                //textbox a ikilik sistemde sayı girilip button2 ye tıklandığında label3 te 2nin kuvvetlerinin karşılığını verir..
            
                label3.Text = "";
                sayi = Convert.ToInt32(textBox1.Text);
                while(sayi>0)
                {
                mod = sayi % 10;
                label2.Text = mod.ToString() +"    "+ label2.Text;
                sayi = sayi / 10;
                toplam = toplam + kuvvet * mod;
                label3.Text = kuvvet.ToString() + "    " + label3.Text;
                kuvvet = kuvvet * 2;
                }
            }

            label4.Text = toplam.ToString();
        }

    }
}
