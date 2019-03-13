using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        int step = 0;
        bool buttonClicked = true;
        int lvl = 1;
      
        public Form1()
        {
            InitializeComponent();
           

            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            pictureBox1.Top = 210;
            timer1.Interval = 20;
            timer1.Enabled = false;
            label3.Hide();
            label1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //step = -5;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //step = 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                pictureBox1.Top += step;
                step = lvl;
            label3.Text = "Ниво " + lvl.ToString();

            if (pictureBox1.Location.Y <= 0)
                {
                label1.Show();
                    label1.Text = "Браво :)";
                timer1.Enabled = false;
                    pictureBox1.Top = 210;
                lvl++;
                label3.Text = "Ниво " + lvl.ToString();
            }
                else if (pictureBox1.Location.Y >= 470)
            {
                timer1.Enabled = false;
                label3.Hide();
                label1.Show();
                label1.Text = "Ти загуби :(";
                pictureBox1.Top = 210;
                lvl = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            label3.Show();
            label1.Hide();
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            step -= 50;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Целта на играта е Батман да достигне горният край, като кликате по прозореца. 
Have fun:) Made by Georgi Sabev");
        }
    }
}
