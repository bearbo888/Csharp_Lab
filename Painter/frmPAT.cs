using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class frmPAT : Form
    {
        public frmPAT()
        {
            InitializeComponent();
        }

        Bitmap bmp;
        int oldX, oldY;
        int PenPixel;
        Color PenColor;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmp);
                Pen p = new Pen(PenColor, PenPixel);
                g.DrawLine(p,oldX,oldY,e.X,e.Y);
                pictureBox1.Image = bmp;
                oldX = e.X;
                oldY = e.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            PenColor = colorDialog1.Color;
            pictureBox2.BackColor = colorDialog1.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_MouseLeave(object sender, EventArgs e)
        {
            PenPixel = trackBar1.Value;
        }

        private void frmPAT_Resize(object sender, EventArgs e)
        {
            bmp = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bmp);
            PenColor = Color.Black;
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            pictureBox1.Height = this.Width;
            pictureBox1.Width = this.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bmp);
            PenColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
        }
    }
}
