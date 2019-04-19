using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi=3;
        int sayac;

        private void button1_Click(object sender, EventArgs e)
        { 
            timer1.Interval = 100;
            timer1.Enabled = true; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   if (sayi >= 0)
             {  timer1.Interval = 1000;
                 timer1.Enabled = true;
                 sayac = sayi--;
                 button1.Text = sayac.ToString();
                 button1.Location = new Point(button1.Location.X + 5, button1.Location.Y); 
        }
             else 
             { {     timer1.Interval = 1000;
                     timer1.Enabled = true;
                     sayac = sayi++;
                     button1.Text = sayac.ToString();

                     button1.Location = new Point(button1.Location.X-5,button1.Location.Y);
                     timer1.Stop();  
                 } }}

        private void Form1_Load(object sender, EventArgs e)
        {  
        }
    }
}
