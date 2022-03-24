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
        public frmGUS(int guess)
        {
            if (guess > ans)
            {
                label2.Text = guess + "~100";
            }else if (guess < ans)
            {
                label2.Text = "1~" + guess;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmPUT input = new frmPUT(ans,win);
            input.Show();
        }
    }
}
