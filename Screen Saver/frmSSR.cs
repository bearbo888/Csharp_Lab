using System;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;

namespace Screen_Saver
{
    public partial class frmSSR : Form
    {
        int x = 2; int y = 2;
        public frmSSR()
        {
            InitializeComponent();    
        }
        private Point mouseLocation;
        private void frmSSR_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    this.Close();
            }
            mouseLocation = e.Location;
        }
        private void frmSSR_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void frmSSR_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
        private void frmSSR_Load(object sender, EventArgs e)
        {
            /*ResourceManager res = new ResourceManager("方案名稱.資料檔名", typeof(表單物件).Assembly);
            pictureBox.Image = (Bitmap)res.GetObject("iu.gif");*/
            moveTimer.Interval = 1;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();
        }
        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            int distance = 2;
            if (pictureBox.Location.X + pictureBox.Width > this.Width)
            {
                x = -distance;
            }
            else if (pictureBox.Location.Y + pictureBox.Height > this.Height)
            {
                y = -distance;
            }
            else if (pictureBox.Location.Y < 0)
            {
                y = distance;
            }
            else if (pictureBox.Location.X < 0)
            {
                x = distance;
            }

            pictureBox.Location = new Point(pictureBox.Location.X + x, pictureBox.Location.Y + y);
        }
    }
}
