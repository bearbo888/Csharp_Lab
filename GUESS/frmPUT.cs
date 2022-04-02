using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Guess
{
    public partial class frmPUT : Form
    {
        public frmPUT()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendans_Click(object sender, EventArgs e)
        {
            frmGUS guess = (frmGUS)this.Owner;
            if ((Regex.IsMatch(textBox1.Text, @"^(?=.*\d).{1,3}$")) == true)
            {
                guess.chkans(this.textBox1.Text);
            }
            else
            {
                textBox1.Text = ""; MessageBox.Show("請輸入範圍內數字");
            }   
        }
    }
}
