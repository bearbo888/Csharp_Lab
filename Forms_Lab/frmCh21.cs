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
    public partial class frmCh21 : Form
    {
        public frmCh21()
        {
            InitializeComponent();
        }

        bool flag = true;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = flag ? Color.Red : Color.AliceBlue;
            flag = !flag;
        }
    }
}
