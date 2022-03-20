using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab
{
    class Class1
    {
        internal void method()
        {
            MessageBox.Show("1");
        }
    }

    class Member
    {
        public string Name;
        public int Age;
    }

    class pass
    {
        public string Val(string val) {

            string val_amount = val;            
            return val_amount;
        }
    }
}
