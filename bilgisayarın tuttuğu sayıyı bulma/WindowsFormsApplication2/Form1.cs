using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         int a;
         int b;
         int denemesayisi=0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random salla = new Random();      //Randoma salla ismini verdik           
            a = salla.Next(1,101);             //1 i gösterir 101 i göstermez 
          //  label2.Text = a.ToString();     //tutulan sayıyı label 2 ye yazdırır 
            denemesayisi = 0;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            denemesayisi = denemesayisi + 1;

            b = Convert.ToInt32(textBox1.Text);
            if (b == a)
            { 
                MessageBox.Show(denemesayisi + ". denemede kazandınız!" );
                denemesayisi = 0;                                                //bildiği için sıfırlıyoruz.
            }

            else
            {
                if (a > b)
                { MessageBox.Show(denemesayisi+". deneme Sayıyı Yükseltin"  ); }

                else
                { MessageBox.Show(denemesayisi+". deneme Sayıyı Azaltın"  ); }
            }


            if (denemesayisi >=3)
            { 
                MessageBox.Show("Hakkınız Bitti");
                button2.Enabled = false;
            }

            

        }
    }
}
