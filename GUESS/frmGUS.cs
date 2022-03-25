using System;
using System.Windows.Forms;

namespace GUESS
{
    public partial class frmGUS : Form
    {
        int ans = 0; int preAns = 0;
        int floor = 1; int celling = 100;

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
        public void chkans(string guessnumber)
        {
            if (!String.IsNullOrWhiteSpace(guessnumber))
            {
                int guessNum = int.Parse(guessnumber);
                if(guessNum < ans && floor < guessNum)
                {
                    floor = guessNum;
                    preAns = guessNum;
                }
                else if (ans < guessNum && guessNum < celling)
                {
                    celling = guessNum;
                    preAns = guessNum;
                }
                else if ((guessNum < ans && floor > guessNum) || (ans < guessNum && guessNum > celling))
                {
                    MessageBox.Show("請輸入" + floor + " ~ " + celling);
                }
                else
                {
                    MessageBox.Show("WIN");
                }
                label2.Text = floor + "  ~  " + celling;
            }
        }

        private void btnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案是: "+ ans.ToString());
        }
    }
}
