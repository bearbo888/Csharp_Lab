using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUESS
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
            guess.chkans(this.textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if((Regex.IsMatch(textBox1.Text, @"^(?=.*\d).{1,3}$")) == false)
            //{
            //    textBox1.Text = "";
            //    MessageBox.Show("請輸入1~100數字");
            //}
        }
    }
}
