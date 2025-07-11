using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveinPictureBox
{
    public partial class Form1 : Form
    {
        Boolean isPositionCurseurImageSet = false;
        Point positionCurseurImage = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();

            this.pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Cursor = Cursors.Hand;
            if (!isPositionCurseurImageSet)
                this.positionCurseurImage = this.pictureBox1.PointToClient(Cursor.Position);
            isPositionCurseurImageSet = true;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.pictureBox1.Top += e.Y - this.positionCurseurImage.Y;
                this.pictureBox1.Left += e.X - this.positionCurseurImage.X;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPositionCurseurImageSet = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cleanup
            if (this.pictureBox1.Image != null)
                this.pictureBox1.Image.Dispose();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.ShowDialog();
        }
    }
}
