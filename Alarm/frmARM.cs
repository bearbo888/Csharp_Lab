using System;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Windows.Media;

namespace Alarm
{
    public partial class frmARM : Form
    {
        bool start = false;
        DateTime dt; 

        public frmARM()
        {
            InitializeComponent();
            lbtime.Text = DateTime.Now.ToLocalTime().ToString("HH:mm:ss");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(moveTimer_Tick);
            timer1.Start();
        }
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (((int)(numericUpDown1.Value) <= DateTime.Now.Hour && (int)(numericUpDown2.Value) < DateTime.Now.Minute))
                {     
                    dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)(numericUpDown1.Value), (int)numericUpDown2.Value, 0).AddDays(1);
                    lb.Visible = true;
                }
                else
                {
                    dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)(numericUpDown1.Value), (int)numericUpDown2.Value, 0);
                }
                
                lbAlarm.Text = dt.ToString("HH:mm:ss"); ;
                start = !start;
                numericUpDown1.Enabled = numericUpDown2.Enabled = false;
            }
            else
            {
                lb.Visible = false;
                start = false;
                numericUpDown1.Enabled = numericUpDown2.Enabled = true;
                lbWake.Text = "00:00:00";
                MessageBox.Show("鬧鐘取消");
            }
        }
        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            DateTime nt = DateTime.Now;
            lbtime.Text = nt.ToString("HH:mm:ss");
            if (start)
            {
                TimeSpan ts = dt - nt;
                if (ts.TotalSeconds < 0)
                {
                    start = !start;
                    lbWake.Text = "00:00:00";
                    axWindowsMediaPlayer1.URL = "blueming.wav";
                    MessageBox.Show("時間到囉~","鬧鐘",MessageBoxButtons.OK);
                    axWindowsMediaPlayer1.close();
                }
                else
                {
                    int ch = ts.Hours;
                    int cm = ts.Minutes;
                    int cs = ts.Seconds;

                    DateTime lt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, ch, cm, cs);
                    lbWake.Text = lt.ToString("HH:mm:ss");
                }
            }
        }
    }
}
