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
    public partial class frmLON : Form
    {
        int repay_month = 0; //月付額
        int interest_total = 0; //總利息
        int total = 0; //總支付金額
        public frmLON()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;

            int amount = Convert.ToInt32(tbamount.Text); //貸款金額
            int period = Convert.ToInt32(tbperiod.Text)*12; //年限
            int apr = Convert.ToInt32(tbapr.Text); //年利率
            int repay = Convert.ToInt32(tbamount.Text) / period; //每月本金
            int interest = 0; //利息

            for (int i = 1; i <= period; i++)
            {
                var item = new ListViewItem($"{i}");
                interest = (int)Math.Ceiling(amount * (apr * 0.01)/12); 
                amount = amount - repay;
                repay_month = repay + interest;
                interest_total += interest;
                total += repay_month;

                item.SubItems.Add($"{repay}");
                item.SubItems.Add($"{interest}");
                item.SubItems.Add($"{repay_month}");
                listView1.Items.Add(item);
            }

            tbinterest_total.Text = interest_total.ToString();
            tbtotal.Text = total.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem();
            listView1.Clear();
            tbtotal.Text = tbinterest_total.Text = " ";
        }

        private void btnreport_Click(object sender, EventArgs e)
        {

            frmLON_RPT report = new frmLON_RPT(tbamount.Text,tbperiod.Text,tbapr.Text, interest_total.ToString(), repay_month.ToString(), total.ToString());
            report.Show();
        }
    }

    
}
