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
    public partial class frmGUS : Form
    {
        int ans = 0; bool win = false;

        public frmGUS()
        {
            InitializeComponent();
            Random random = new Random();
            ans = random.Next(1, 100);
        }

        private string strValue;
        public string StrValue
        {
            set
            {
                strValue = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmPUT input = new frmPUT();//例項化一個Form2視窗
            input.Val = ans;//設定Form2中string1的值         
            input.Show(this);

            //frmPUT input = new frmPUT(ans,win);
            //input.Owner = this;
            //chk(strValue);
            //input.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ans.ToString());
        }

        void chk(string val)
        {
            if (!String.IsNullOrWhiteSpace(val))
            {
                if (int.Parse(val) > ans)
                {
                    label2.Text = strValue + "~100";
                }
                else if (int.Parse(val) < ans)
                {
                    label2.Text = "1~" + strValue;
                }
            }
        }

        private void frmGUS_Load(object sender, EventArgs e)
        {
            chk(strValue);
        }
    }
}
