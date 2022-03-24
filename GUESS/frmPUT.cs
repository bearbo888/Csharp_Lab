using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUESS
{
    public partial class frmPUT : Form
    {
        int x = 0;
        public frmPUT(int ans, bool win)
        {
            InitializeComponent();
            x = ans;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGUS guess = new frmGUS(int.Parse(textBox1.Text));
            
        }
    }
}
