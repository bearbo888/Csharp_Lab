using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doForWhile
{
    public partial class frmDFW : Form
    {
        public frmDFW()
        {
            InitializeComponent();
        }

        private void btnXmas_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbXmas.Text))
            {
                int input = int.Parse(tbXmas.Text);
                for(int i=0; i < input; i++)
                {
                    for (int j=0; j <i+1; j++)
                    {
                        lbResult.Text += "*  ";
                    }
                    lbResult.Text += "\n";
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lbResult.Text = "九九乘法表\n";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    lbResult.Text += (i * (j+1) < 10) ? (j + 1) + "X" + i + "=  " + i * (j + 1) + " | " : (j + 1) + "X" + i + "=" + i * (j + 1) + " | ";              
                }
                lbResult.Text += "\n";
            }
        }

        private void btnLotto_Click(object sender, EventArgs e)
        {
            int[] array = new int[6];
            lbResult.Text = "樂透號碼:\n";
            int i = 0;
            Class1 cs = new Class1();

            while (true)
            {
                Random random = new Random();
                int z = random.Next(1, 49);

                if (cs.check(array, z))
                {
                    array[i] = z;
                    i++;
                }
                if (array[5] > 0) break;
            };

            for (int j = 0; j < 6; j++)
            {
                lbResult.Text += (array[j]<10)? "0"+array[j] + " ": array[j] + " ";
            }
        }
    }
}
