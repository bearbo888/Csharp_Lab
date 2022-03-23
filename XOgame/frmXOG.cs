using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOgame
{
    public partial class frmXOG : Form
    {
        public frmXOG()
        {
            InitializeComponent();

        }

        bool val = false; int count = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = (val) ? "X" : "O";
            val = !val;
            count++;
            b.Enabled = false;
            if (count > 5) { Winner(); }
        }

        private void Winner()
        {
            bool win = false;

            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && !String.IsNullOrWhiteSpace(btn1.Text)) win = !win;
            if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && !String.IsNullOrWhiteSpace(btn4.Text)) win = !win;
            if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && !String.IsNullOrWhiteSpace(btn7.Text)) win = !win;

            if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && !String.IsNullOrWhiteSpace(btn1.Text)) win = !win;
            if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && !String.IsNullOrWhiteSpace(btn2.Text)) win = !win;
            if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && !String.IsNullOrWhiteSpace(btn3.Text)) win = !win;

            if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && !String.IsNullOrWhiteSpace(btn1.Text)) win = !win;
            if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && !String.IsNullOrWhiteSpace(btn3.Text)) win = !win;

            if (win) { MessageBox.Show("Win" + ((val) ? "O" : "X")); Reset(); }
            if (count == 9 && win==false) { MessageBox.Show("平局"); }
        }

        private void Reset()
        {
            count = 0;
            val = false;
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void frmXOG_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.R:
                    Reset();
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }
    }
}
