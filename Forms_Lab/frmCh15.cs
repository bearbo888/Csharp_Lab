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
    public partial class frmCh15 : Form
    {
        public frmCh15()
        {
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = a;
            MessageBox.Show("a: " + a + " ,b: " + b);
            b = 200;
            MessageBox.Show("a: " + a + " ,b: " + b);
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            TextBox tb = textBox1;
            tb.Text = "REF TYPE";
            tb.ForeColor = Color.BlueViolet;
            tb.BackColor = Color.YellowGreen;
        }
    }
}
