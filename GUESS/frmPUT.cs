using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUESS
{
    public partial class frmPUT : Form
    {
        int x = 0;
        public frmPUT()
        {
            InitializeComponent();
        }
        public frmPUT(int ans, bool win)
        {
            x = ans;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGUS guess = (frmGUS)this.Owner;
            //guess.StrValue = textBox1.Text;//使用父視窗指標賦值

            //((TextBox)guess.Controls["textBox1"]).Text = this.textBox1.Text;

            guess.StrValue = this.textBox1.Text;
            this.Close();
        }

        private int val;
        public int Val
        {
            set
            {
                val = value;
            }
        }
        /*public void SetValue()
        {
            this.textBox1.Text = val.ToString();
        }*/
    }
}
