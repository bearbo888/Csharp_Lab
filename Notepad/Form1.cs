using Microsoft.Win32;
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
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Dock = DockStyle.Fill;
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Title = "選擇要開啟的文字檔案";
                openFileDialog1.Filter = " txt files(*.txt)|*.txt|All files(*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.Multiselect = true;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    Encoding enc = Encoding.GetEncoding("UTF-8");
                    FileStream fs = new FileStream(path, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripDropDownButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripDropDownButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    FileStream fs = new FileStream(path,FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
