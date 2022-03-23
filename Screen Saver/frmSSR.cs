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
            //得到計算機螢幕的工作區域
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

            //if (pictureBox1.Location.X > width - pictureBox1.Width) //to check condition if pic box is touch the boundroy of form width
            //{
            //    pictureBox1.Location = new Point(1, pictureBox1.Location.Y); // pic box is set to the new point. here 1 is indicate of X coordinate.
            //}
            //else
            //{
            //     // to move picture box from x coordinate by 100 Point.
            //}

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

            if (pictureBox1.Location.X > windows.Width || pictureBox1.Location.Y > windows.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 20, pictureBox1.Location.Y - 20);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 90, pictureBox1.Location.Y + 90);
            }





            //Move text to new location
            //pictureBox1.Left = rand.Next(Math.Max(1, Bounds.Width - pictureBox1.Width));
            //pictureBox1.Top = rand.Next(Math.Max(1, Bounds.Height - pictureBox1.Height));
        }

    }
}
