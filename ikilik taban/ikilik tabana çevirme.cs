using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int sayi;
        int mod;
        int toplam = 0;
        int kuvvet=1;
                
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void taban_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label2.Text = "";
            sayi = Convert.ToInt32(textBox1.Text);
            while (sayi > 0)
            {
                mod = sayi % 10;
                label2.Text = mod.ToString() + "    " + label2.Text;
                sayi = sayi / 10;
                toplam = toplam + kuvvet * mod;
                label3.Text = kuvvet.ToString() + "     " + label3.Text;
                kuvvet = kuvvet * 2;
            }
            label4.Text = toplam.ToString();
        }
    }
}
