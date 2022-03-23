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
    public partial class frmCh28 : Form
    {
        public frmCh28()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member mem = new Member();
            mem.Name = "Hanks";
            mem.Age = 66;
            MessageBox.Show(mem.Name+", "+mem.Age);
        }

        Member Create(string name ,int age=22)
        {
            Member mem = new Member();
            mem.Name = name;
            mem.Age = age;
            return mem;
        }
    }
}
