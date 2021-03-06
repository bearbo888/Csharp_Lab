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

        
        void ShowEmp()
        {
            int total = 0;
            lbEmp.Text = "";

            for (int i = 0; i < list.Count; i++)
            {
                lbEmp.Text += "\nName：" + ((Emp)list[i]).Name + ", " + ((Emp)list[i]).Age;
                total += ((Emp)list[i]).Age;
            }

            int z = (list.Count <= 0) ? 1 : list.Count;

            lbEmp.Text += "\n總人數：" + list.Count + " 平均年齡：" + total / z;
        }

        ArrayList list = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            Emp emp;
            emp.Name = tbName.Text;
            emp.Age = int.Parse(tbAge.Text);

            list.Add(emp);

            ShowEmp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emp emp;
            emp.Name = tbName.Text;
            emp.Age = int.Parse(tbAge.Text);

            list.Insert(0, emp);

            ShowEmp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.RemoveAt(0);
            ShowEmp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Clear();
            ShowEmp();
        }
    }
}
