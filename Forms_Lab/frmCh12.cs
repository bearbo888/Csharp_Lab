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
    public partial class frmCh12 : Form
    {
        public frmCh12()
        {
            InitializeComponent();
        }

        private int count = 0;

        private void btnPreCal_Click(object sender, EventArgs e)
        {
            int b = ++count;
            tbA.Text = count.ToString();
            tbB.Text = b.ToString();
        }

        private void btnPostCal_Click(object sender, EventArgs e)
        {
            int b = count++;
            tbA.Text = count.ToString();
            tbB.Text = b.ToString();
        }
        member mem = new member();
        private void btnNonst_Click(object sender, EventArgs e)
        {
            textBox1.Text = (mem.count += 1).ToString();
        }

        private void btnSt_Click(object sender, EventArgs e)
        {
            textBox2.Text = (member.count2 += 1).ToString();
        }

        private void btnOpenForm1_Click(object sender, EventArgs e)
        {
            frmHLO fm = new frmHLO();
            fm.Show();
        }
    }

    class member
    {
        public int count;
        static public int count2;
    }
}
