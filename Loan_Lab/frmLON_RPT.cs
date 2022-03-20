using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Lab
{
    public partial class frmLON_RPT : Form
    {
        public frmLON_RPT(string amt, string period, string arp,string ins_tol,string repay_mon,string repay_tol)
        {
            InitializeComponent();
            lbamount.Text = amt;
            lbperiod.Text = period;
            lbarp.Text = arp;
            lbinterest_total.Text = ins_tol;
            lbrepay_month.Text = repay_mon;
            lbrepay_total.Text = repay_tol;
        }
    }
}
