using System;
using System.Drawing;
using System.Windows.Forms;

namespace Screen_Saver
{
    public partial class frmSSR : Form
    {
        public frmSSR()
        {
            InitializeComponent();

            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(this.panel1.Width, this.panel1.Height);
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
            moveTimer.Interval = 800;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();

        }

        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            int width = this.Width; // get the width of Form.
            int height = this.Height;

            int iDistance = 0; int speed = 2;
            Rectangle windows = Screen.GetWorkingArea(this);
            //pictureBox1.Location = new Point(0 , pictureBox1.Location.Y);
            pictureBox1.Visible = true;
            // 增加2個象素點,你可以通過修改speed的值來改變標籤的移動速度
            iDistance += speed;
            // 如果標籤已經走出螢幕,則把標籤的位置重定位到螢幕的右邊
            /*if (pictureBox1.Location.X <= -(pictureBox1.Width))
            {
                //Reset the distance to 0.
                iDistance = 0;
                //判斷標籤的位置是否在頂部,如果在,則重定位到中部
                if (pictureBox1.Location.Y == 0)
                    pictureBox1.Location = new Point(pictureBox1.Location.X, (windows.Height / 2));
                //判斷標籤的位置是否在中部,如果在,則重定位到底部 
                else if (pictureBox1.Location.Y == windows.Height / 2)
                    pictureBox1.Location = new Point(pictureBox1.Location.X, windows.Height - pictureBox1.Height);
                //重定位到頂部 
                else
                    pictureBox1.Location = new Point(pictureBox1.Location.X, 0);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y + 20);
            }*/

            if (pictureBox1.Location.X > this.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 5);
            }
            else if (pictureBox1.Location.Y > this.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y - 5);
            }
            else if (pictureBox1.Location.X < 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y - 5);
            }
            else if (pictureBox1.Location.Y < 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
            }





            //Move text to new location
            //pictureBox1.Left = rand.Next(Math.Max(1, Bounds.Width - pictureBox1.Width));
            //pictureBox1.Top = rand.Next(Math.Max(1, Bounds.Height - pictureBox1.Height));
        }

        private void panel1_AutoSizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
            pictureBox1.Width = panel1.Width;
            pictureBox1.Height = panel1.Height;
        }
    }
}
