using System;
using System.Windows.Forms;

namespace GUESS
{
    public partial class frmGUS : Form
    {
        int ans = 0; int preAns = 0; bool chk = true;

        public frmGUS()
        {
            InitializeComponent();
            Random random = new Random();
            ans = random.Next(1, 100);
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            frmPUT input = new frmPUT();
            input.Owner = this;      
            input.Show(this);
        }
        public void chkans(string strValue)
        {
            if (!String.IsNullOrWhiteSpace(strValue))
            {
                if (int.Parse(strValue) > ans && preAns == 0 )
                {
                    label2.Text = "TO LARGE!!!!\n1~" + strValue;
                }
                else if (int.Parse(strValue) < ans && preAns == 0)
                {
                    label2.Text = "TO SMALL!!!!\n" + strValue + "~100";
                }
                else if (int.Parse(strValue) < ans && preAns > 0 && int.Parse(strValue)> preAns)
                {
                    label2.Text = "TO !!!!\n" + preAns + "~" + strValue;

                }
                else if (int.Parse(strValue) > ans && preAns > 0 && int.Parse(strValue) < preAns)
                {
                    label2.Text = "TO!!!!\n" + strValue + "~" + preAns;
                }
                else if(int.Parse(strValue) == ans)
                {
                    label2.Text = "";
                    MessageBox.Show("WINNNNNNNNNNNNNNNNNNNNNNNNNN");
                }
                else
                {
                    chk = !chk;
                    MessageBox.Show("XXX:"+preAns.ToString());
                }
                if (chk) { 
                    preAns = int.Parse(strValue);
                    MessageBox.Show(preAns.ToString());
                }
                
            }
        }

        private void btnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案是: "+ ans.ToString());
        }
    }
}
