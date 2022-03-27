using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            //frmShow s = new frmShow();
            //Bitmap img = s.BackgroundImage();

            //s.StartPosition = FormStartPosition.CenterScreen;
            //s.Size = img.Size;

            //PictureBox pb = new PictureBox();
            //pb.Dock = DockStyle.Fill;
            //pb.Image = img;

            //s.Controls.Add(pb);
            //s.ShowDialog();
        }
    }
}
