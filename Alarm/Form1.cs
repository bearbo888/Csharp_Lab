using System;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        string Hour; string Min; string Sec = "00"; bool tomorrow = false;
        DateTime dt = new DateTime();
        
        public Form1()
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
        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLocalTime().ToString("HH:mm:ss");
            AAA();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (numericUpDown1.Value < DateTime.Now.Hour) { tomorrow = !tomorrow; label1.Visible = true; }

                if (numericUpDown1.Value < 10) { Hour = "0" + numericUpDown1.Value; } else { Hour = numericUpDown1.Value.ToString(); }
                if (numericUpDown2.Value < 10) { Min = "0" + numericUpDown2.Value; } else { Min = numericUpDown2.Value.ToString(); }

                lbAlarm.Text = Hour + ":" + Min + ":" + Sec;
            }
            else
            {
                Hour = Min = Sec = "00";
                lbAlarm.Text = "00:00:00";
                lbWake.Text = "00:00:00";
                label1.Visible = false;
            }
        }
        void AAA()
        {
            dt = DateTime.Now;

            int h = (int)numericUpDown1.Value; int m = (int)numericUpDown2.Value; int s;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (tomorrow)
                {
                    label1.Visible = true;
                    h = (24 - dt.Hour) + int.Parse(Hour);
                    m = (24 - dt.Minute) - int.Parse(Min)-1;
                    s = 60 - dt.Second;                    
                }
                else
                {
                    h = int.Parse(Hour) - dt.Hour;
                    m = int.Parse(Min) - dt.Minute-1;
                    s = 60 - dt.Second;
                }

                string hh = (h < 10) ? "0" + h : h.ToString();
                string mm = (m < 10) ? "0" + m : m.ToString();
                string ss = (s < 10) ? "0" + s : s.ToString();

                lbWake.Text = hh + ":" + mm + ":" + ss;
            }
        }
    }
}
