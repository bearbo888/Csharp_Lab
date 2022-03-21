using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] array = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] array_str = new string[] { "mother張", "emma","迪克蕭","J40","Candy","Motherfacker"};

        private void btnchk_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(tbInput.Text);
                if (input % 2 == 0)
                {
                    MessageBox.Show(input + " is even number.");
                }
                else
                {
                    MessageBox.Show(input + " is odd number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input intger number");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            lbResult.Text = "Bubble Sort : array[";

            for (int i=0;i<array.Length;i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                lbResult.Text += array[i]+" ";
            }
            lbResult.Text += "]" + "\n";
            lbResult.Text += "Max val : " + array[array.Length-1] + "\n";
            lbResult.Text += "Min val : " + array[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int odd = 0, even = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            lbResult.Text = "int array[";

            for (int i = 0; i < array.Length; i++)
            {
                lbResult.Text += array[i]+" ";
            }

            lbResult.Text += "]\nOdd Number: " + odd + "\nEven Number: "+ even;
        }

        private void btnLongName_Click(object sender, EventArgs e)
        {
            
        }
    }
}
