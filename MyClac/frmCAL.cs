using System;
using System.Windows.Forms;

namespace MyClac
{
    public partial class frmCAL : Form
    {
        public frmCAL()
        {
            InitializeComponent();
        }

        calculate cal = new calculate();
        double total = 0; int staute = 0; int click = 0;

        enum fun
        {
            Add, Minus, Multiply, Divide,Mod
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            staute = ((int)fun.Add);
            label3.Text = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            staute = ((int)fun.Minus);
            label3.Text = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            staute = ((int)fun.Multiply);
            label3.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            staute = ((int)fun.Divide);
            label3.Text = "/";
        }

        private void btnEuq_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(tbX.Text)&& !String.IsNullOrWhiteSpace(tbY.Text))
            {
                double x = int.Parse(tbX.Text);
                int y = int.Parse(tbY.Text);

                click++;

                switch (staute)
                {
                    case 0:
                        if (click != 0)
                        {
                            total = cal.Add(total, y);
                        }
                        else
                        {
                            total = cal.Add(x, y);
                        }
                        break;
                    case 1:
                        if (click != 0)
                        {
                            total = cal.Minus(total, y);
                        }
                        else
                        {
                            total = cal.Minus(x, y);
                        }
                        break;
                    case 2:
                        if (total != 0)
                        {
                            total = cal.Multiply(total, y);
                        }
                        else
                        {
                            total = cal.Multiply(x, y);
                        }
                        break;
                    case 3:
                        if (total != 0)
                        {
                            total = cal.Divide(total, y);
                        }
                        else
                        {
                            total = cal.Divide(x, y);
                        }
                        break;
                    case 4:
                        if (total != 0)
                        {
                            total = cal.Mod(total, y);
                        }
                        else
                        {
                            total = cal.Mod(x, y);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("No values");
            }

            tbResult.Text = total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            click = 0;
            label3.Text = "";
            tbResult.Text = tbX.Text = tbY.Text = "";
        }
    }
}
