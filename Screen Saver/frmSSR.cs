using System;
using System.Drawing;
using System.Windows.Forms;

namespace Screen_Saver
{
    public partial class frmSSR : Form
    {
        bool top = false;
        bool bottom = false;
        bool right = false;
        bool left = false;
        public frmSSR()
        {
            InitializeComponent();

            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
           
            //this.pictureBox1.Size = new System.Drawing.Size(this.panel1.Width, this.panel1.Height);
        }
        private Point mouseLocation;
        private void frmSSR_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    Application.Exit();
            }

            // Update current mouse location
            mouseLocation = e.Location;

        }

        private void frmSSR_MouseClick(object sender, MouseEventArgs e)
        {
            //Application.Exit();
        }

        private void frmSSR_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Application.Exit();
        }

        private Random rand = new Random();
        private void frmSSR_Load(object sender, EventArgs e)
        {
            moveTimer.Interval = 10;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();

        }

        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            int width = this.Width; 
            int height = this.Height;

            Rectangle windows = Screen.GetWorkingArea(this);
            pictureBox.Visible = true;


            if (pictureBox.Location.X > this.Width && pictureBox.Location.Y > this.Height)
            {//
                right = !right;//碰到右界
                if (bottom) bottom = !bottom;//向下取消
            }
            else if (pictureBox.Location.X > windows.Width)
            {             
                top = !top;//碰到上界
                if (right) right = !right;//向右取消
            }
            else if (pictureBox.Location.Y > windows.Height)
            {
                bottom = !bottom;//碰到下界
            }
            else 
            {         
                if(top) top = !top;
            }

            if (right)
            {
                pictureBox.Location = new Point(pictureBox.Location.X - 5, pictureBox.Location.Y - 5);
            }
            else if (top)
            {
                pictureBox.Location = new Point(pictureBox.Location.X - 5, pictureBox.Location.Y + 5);
            }else if (bottom)
            {
                pictureBox.Location = new Point(pictureBox.Location.X + 5, pictureBox.Location.Y - 5);
            }
            else
            {
                pictureBox.Location = new Point(pictureBox.Location.X + 5, pictureBox.Location.Y + 5);
            }




        }

        private void panel1_AutoSizeChanged(object sender, EventArgs e)
        {
            //pictureBox1.Left = 0;
            //pictureBox1.Top = 0;
            //pictureBox1.Width = panel1.Width;
            //pictureBox1.Height = panel1.Height;
        }
    }
}
