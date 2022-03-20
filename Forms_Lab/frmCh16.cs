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
    public partial class frmCh16 : Form
    {
        public frmCh16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            valtype(a);
            MessageBox.Show(a.ToString());

        }

        void valtype(int i)
        {
            i = 200000;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Member mem = new Member()
            {
                Name = "Hanks",
                Age = 99
            };
            MessageBox.Show(mem.Name + mem.Age);
            reftype(mem);
            MessageBox.Show(mem.Name + mem.Age);
        }

        void reftype(Member m)
        {
            m.Age = 22;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 100;
            MessageBox.Show(a.ToString());
            byRef(ref a);
            MessageBox.Show(a.ToString());
        }
        void byRef (ref int i)
        {
            i = 9999;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string a = "XXX";
            MessageBox.Show(a);
            passString(a);
            MessageBox.Show(a);
        }

        void passString(string str)
        {
            str = "ZZZZZZZZZZ";
        }
    }
}
