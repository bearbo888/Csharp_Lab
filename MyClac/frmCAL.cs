using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClac
{
    public partial class frmCAL : Form
    {
        public frmCAL()
        {
            InitializeComponent();
        }

        int x;
        int y;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculate cal = new calculate();
            cal.Add(x,y);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }
    }
}
