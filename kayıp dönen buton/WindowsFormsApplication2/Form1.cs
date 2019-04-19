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

        int formWidth, formHeight;
        int firstX, firstY;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Gidiyorum Yolcu Et";
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Location = new Point(firstX,firstY);
            button1.Text = "Başlat";
            button2.Text = "Durdur";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Location.X < formWidth)
            {
                button1.Location = new Point(button1.Location.X + 5, button1.Location.Y);
            }

            else 
            {
                button1.Location = new Point(firstX-10,firstY);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(5,(this.Height/2)-(button1.Height/2));
            button1.Text = "başlat";
            firstX = button1.Location.X;
            firstY = button1.Location.Y;
            formWidth = this.Width;
            formHeight = this.Height;
            timer1.Interval = 50;
        }
    }
}
