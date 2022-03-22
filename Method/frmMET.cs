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
        string[] array_str = new string[] { "mother張", "emma","迪克蕭","J40","Candy","coco","Motherfacker"};

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

        private void btnMinMax_Click(object sender, EventArgs e)
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

        private void btnStaEvenOdd_Click(object sender, EventArgs e)
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
            lbResult.Text = "array0711_str [ ";

            for (int i = 0; i < array_str.Length; i++)
            {
                lbResult.Text += array_str[i] + "  ";
            }

            lbResult.Text += "]\n";

            string name = "";

            for (int i = 0; i < array_str.Length - 1; i++)
            {
                if (array_str[i].Length < array_str[i + 1].Length)
                {
                    name =  array_str[i + 1];
                }
                else
                {
                    name = array_str[i];
                }
            }

            lbResult.Text += "Long Name: "+name;
        }

        private void btnInclude_Click(object sender, EventArgs e)
        {
            int a = 0;
            lbResult.Text = "array0711_str[";

            for (int i = 0; i < array_str.Length; i++)
            {
                lbResult.Text += array_str[i] + " ";
            }

            lbResult.Text += "]\n";
            lbResult.Text += "包含 C or c : ";

            for (int i = 0; i < array_str.Length - 1; i++)
            {
                if (array_str[i].Contains('c')|| array_str[i].Contains('C'))
                {
                    a++;
                    lbResult.Text += array_str[i] + " ";
                }    
            }

            lbResult.Text += ", 總共 " + a + " 個";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            int[,] arr = new int[10, 10];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i%9==0 || j%9==0 ) 
                    { 
                        lbResult.Text += "1   ";
                        
                    }
                    else 
                    {
                        lbResult.Text += "0   ";
                    }

                    if (j == 9)
                    {
                        lbResult.Text += "\n";
                    }

                }
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            int[,] arr = new int[10, 10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i % 9 == 0 || j % 9 == 0)
                    {
                        lbResult.Text += "0   ";

                    }
                    else
                    {
                        lbResult.Text += "1   ";
                    }

                    if (j == 9)
                    {
                        lbResult.Text += "\n";
                    }

                }
            }
        }

        private void btnOneZero_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            int[,] arr = new int[10, 10];
            bool val = true;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    lbResult.Text += (val) ? "1   " : "0   ";
                    val= !val;

                    if (j == 9)
                    {
                        lbResult.Text += "\n";
                        val = !val;
                    }
                        
                }
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100; int n2 = 200;
            lbResult.Text = "換位前: n1= " + n1 + ", n2= " + n2 + "\n";
            int T = n1;
            n1 = n2;
            n2 = T;
            lbResult.Text += "換位前: n1= " + n1 + ", n2= " + n2 + "\n";

        }

        private void btbArySum_Click(object sender, EventArgs e)
        {
            lbResult.Text = "int array[";

            for (int i = 0; i < array.Length; i++)
            {
                lbResult.Text += array[i] + " ";
            }

            lbResult.Text += "]\n加總為: " + array.Sum().ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            lbResult.Text = "int array[";

            for (int i = 0; i < array.Length; i++)
            {
                lbResult.Text += array[i] + " ";
            }

            lbResult.Text += "]\n最大值為: " + array.Max().ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            lbResult.Text = "int array[";

            for (int i = 0; i < array.Length; i++)
            {
                lbResult.Text += array[i] + " ";
            }

            lbResult.Text += "]\n最小值為: " + array.Min().ToString();
        }
    }
}
