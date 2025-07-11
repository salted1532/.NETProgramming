using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace molegame
{
    public partial class Form1 : Form
    {
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            for(int i = 0; i < 4; i++) 
            {
                if (index == 0)
                {
                    pictureBox1.Image = Properties.Resources.mole0;
                    pictureBox2.Image = Properties.Resources.mole0;
                    pictureBox3.Image = Properties.Resources.mole0;
                    pictureBox4.Image = Properties.Resources.mole0;
                    pictureBox5.Image = Properties.Resources.mole0;
                    pictureBox6.Image = Properties.Resources.mole0;
                    pictureBox7.Image = Properties.Resources.mole0;
                    pictureBox8.Image = Properties.Resources.mole0;
                    pictureBox9.Image = Properties.Resources.mole0;
                    Thread.Sleep(1000);
                    index++;
                }
                else if (index == 1)
                {
                    pictureBox1.Image = Properties.Resources.mole1;
                    pictureBox2.Image = Properties.Resources.mole1;
                    pictureBox3.Image = Properties.Resources.mole1;
                    pictureBox4.Image = Properties.Resources.mole1;
                    pictureBox5.Image = Properties.Resources.mole1;
                    pictureBox6.Image = Properties.Resources.mole1;
                    pictureBox7.Image = Properties.Resources.mole1;
                    pictureBox8.Image = Properties.Resources.mole1;
                    pictureBox9.Image = Properties.Resources.mole1;
                    Thread.Sleep(1000);
                    index++;
                }
                else if (index == 2)
                {
                    pictureBox1.Image = Properties.Resources.mole2;
                    pictureBox2.Image = Properties.Resources.mole2;
                    pictureBox3.Image = Properties.Resources.mole2;
                    pictureBox4.Image = Properties.Resources.mole2;
                    pictureBox5.Image = Properties.Resources.mole2;
                    pictureBox6.Image = Properties.Resources.mole2;
                    pictureBox7.Image = Properties.Resources.mole2;
                    pictureBox8.Image = Properties.Resources.mole2;
                    pictureBox9.Image = Properties.Resources.mole2;
                    Thread.Sleep(1000);
                    index++;
                }
                else if (index == 3)
                {
                    pictureBox1.Image = Properties.Resources.mole3;
                    pictureBox2.Image = Properties.Resources.mole3;
                    pictureBox3.Image = Properties.Resources.mole3;
                    pictureBox4.Image = Properties.Resources.mole3;
                    pictureBox5.Image = Properties.Resources.mole3;
                    pictureBox6.Image = Properties.Resources.mole3;
                    pictureBox7.Image = Properties.Resources.mole3;
                    pictureBox8.Image = Properties.Resources.mole3;
                    pictureBox9.Image = Properties.Resources.mole3;
                    Thread.Sleep(1000);
                    index++;
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(index == 4)
            {
                pictureBox1.Image = Properties.Resources.MOLE4;
                index = 0;
                Thread.Sleep(1000);
                pictureBox1.Image = Properties.Resources.mole0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                pictureBox2.Image = Properties.Resources.MOLE4;
                index = 0;
                Thread.Sleep(1000);
                pictureBox2.Image = Properties.Resources.mole0;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                pictureBox3.Image = Properties.Resources.MOLE4;
                index = 0;
                Thread.Sleep(1000);
                pictureBox3.Image = Properties.Resources.mole0;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                pictureBox4.Image = Properties.Resources.MOLE4;
                index = 0;
                Thread.Sleep(1000);
                pictureBox4.Image = Properties.Resources.mole0;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                pictureBox5.Image = Properties.Resources.MOLE4;
                index = 0;
                Thread.Sleep(1000);
                pictureBox5.Image = Properties.Resources.mole0;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                pictureBox6.Image = Properties.Resources.MOLE4;
                index = 0;
                Thread.Sleep(1000);
                pictureBox6.Image = Properties.Resources.mole0;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                pictureBox7.Image = Properties.Resources.MOLE4;
                index = 0;
                Thread.Sleep(1000);
                pictureBox7.Image = Properties.Resources.mole0;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                pictureBox8.Image = Properties.Resources.MOLE4;
                index = 0;
                Thread.Sleep(1000);
                pictureBox8.Image = Properties.Resources.mole0;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (index == 4)
            {
                pictureBox9.Image = Properties.Resources.MOLE4;
                index = 0;
                Thread.Sleep(1000);
                pictureBox9.Image = Properties.Resources.mole0;
            }
        }
    }
}
