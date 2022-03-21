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
    public partial class frmCh19 : Form
    {
        public frmCh19()
        {
            InitializeComponent();
        }

        string result = "";
        int count = 0; int total = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product P;

            P.Name = tbName.Text;
            P.Price = int.Parse(tbPrice.Text);
            count++;
            total += P.Price;

            result += "\nName: " + P.Name + " ,Price: " + P.Price;
            MessageBox.Show("Add Success!");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            label1.Text = result;
            label1.Text += "\nTotal Prouct:" + count + " ,Total Price:" + total;
        }
    }
}
