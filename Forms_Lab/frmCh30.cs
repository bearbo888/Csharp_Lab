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
    public partial class frmCh30 : Form
    {
        public frmCh30()
        {
            InitializeComponent();
        }
        List<Emp> list= new List<Emp>();
        void ShowEmp()
        {
            int total = 0;
            lbEmp.Text = "";

            /*foreach (int item in list)
            {
                lbEmp.Text += "\nName：" + list[item].Name + ", " + ((Emp)list[i]).Age;
                total += ((Emp)list[item.]).Age;
            }*/



            /*for (int i = 0; i < list.Count; i++)
            {
                
            }*/

            int z = (list.Count <= 0) ? 1 : list.Count;

            lbEmp.Text += "\n總人數：" + list.Count + " 平均年齡：" + total / z;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Emp mem;
            mem.Name = tbName.Text;
            mem.Age = int.Parse(tbAge.Text);

            list.Add(mem);
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
            if (list.Count>0)
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
