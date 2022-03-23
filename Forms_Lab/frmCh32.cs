using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab
{
    public partial class frmCh32 : Form
    {
        public frmCh32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "AAAAA";
            string b = a;
            a = "BBBBB";

            MessageBox.Show(a + ",  " + b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder a = new StringBuilder();
            a.Append("AAAAA");
            StringBuilder b = a;
            b.Append("BBBBB");

            MessageBox.Show(a.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button item = new Button();
            if (item.GetType() != typeof(Button))
            {
                foreach(Control c in Controls)
                {
                    c.Top--;
                    c.Left--;
                }
            }
        }


        bool result = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            result = Regex.IsMatch(textBox2.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");

            label3.Text = (result==true) ? "正確" : "錯誤";


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (result==true)
            {
                label3.BackColor = Color.AliceBlue;
                label3.ForeColor = Color.White;
            }
            else
            {
                label3.BackColor = Color.Red;
                label3.ForeColor = Color.Black;
            }
        }
    }
}
