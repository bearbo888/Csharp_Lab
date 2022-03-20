using System;
using System.Windows.Forms;

namespace Forms_Lab
{
    public partial class frmCh07 : Form
    {
        public frmCh07()
        {
            InitializeComponent();
        }
        private void btnNewClass_Click(object sender, EventArgs e)
        {
            Member mem = new Member();
            mem.Name = "John";
            mem.Age = 44;

            MessageBox.Show("Name: "+ mem.Name + "   Age: "+ mem.Age);
        }
    }
}
