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
    public partial class frmCh18 : Form
    {
        public frmCh18()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            Role role = Role.Admin;

            if ((int)role == 1)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        enum Role : int
        {
            User,
            Admin
        }
    }
}
