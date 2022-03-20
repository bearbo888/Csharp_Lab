using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab
{
    public partial class frmCh02 : Form
    {
        public frmCh02()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Method();
        }

        void Method()
        {
            string msg = "John";
            MessageBox.Show("HI NICE TO MEET YOU,  " + msg);
        }

        string retunmethod(int Age)
        {
            return ((DateTime.Now.Year - Age).ToString());
        }

        private void btnreturnmethod_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            cs.method();
            MessageBox.Show("出生年為:" + retunmethod(20));
        }

        public void method5()
        {
            Method();
        }

        private void btn封裝_Click(object sender, EventArgs e)
        {
            textBox1.Text = "111111";
            //textBox1.BackColor = Color.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCh07 ch7 = new frmCh07();
            pass ps = new pass();

            ch7.Show();
        }

        private void brnAsk_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("給虧嗎?", "安安", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (msg == DialogResult.Yes)
            {
                MessageBox.Show("Nice");
            }
            else if (msg == DialogResult.No)
            {
                MessageBox.Show("QQ");
            }
        }

        private void btnShowColor_Click(object sender, EventArgs e)
        {
            this.btnNew.Click += btnNew_Click;
            this.btnDisable.Click -= btnDisable_Click;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnShowColor.BackColor = Color.DarkBlue;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {

        }
    }
}
