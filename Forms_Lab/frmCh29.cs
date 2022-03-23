using System;
using System.Collections;
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
    public partial class frmCh29 : Form
    {
        public frmCh29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Name = tbName.Text;
            emp.Age = int.Parse(tbAge.Text);

            ArrayList list = new ArrayList();
            list.Add(emp);

            for (int i = 0; i < list.Count; i++)
            {
                lbEmp.Text += "\nName："+((Emp)list[0]).Name + ", " + ((Emp)list[0]).Age;
            }
        }
    }
}
