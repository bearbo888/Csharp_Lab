using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class show : Form
    {
        string path = "";
        public show()
        {
            InitializeComponent();
        }

        private void show_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Image.FromFile(path);
        }

        public string sendPath(string spath)
        {

            return path = spath;
        }
    }
}
