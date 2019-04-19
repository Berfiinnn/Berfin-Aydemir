using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sınırsız_kayan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Location.X + button1.Size.Width > this.Width)
            {
                button1.Location = new Point(0 - button1.Size.Width, button1.Location.Y);
            }

            else
            {
                button1.Location = new Point(button1.Location.X+10,button1.Location.Y+5);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
