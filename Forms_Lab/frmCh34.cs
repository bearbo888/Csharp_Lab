using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab
{
    public partial class frmCh34 : Form
    {
        public frmCh34()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../Reader.txt",Encoding.UTF8);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("../Writer.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
            sw.Write(textBox1.Text);
            sw.Close();
            fs.Close();
        }
    }
}
