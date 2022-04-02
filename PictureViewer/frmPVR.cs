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
    public partial class frmPVR : Form
    {
        string path = "..\\..\\picc\\";
        List<string> list = new List<string>();
        string name = ".jpg";
        public frmPVR()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 17; i++)
            {
                list.Add(i + name);
            }

            ImageList imglist = new ImageList();
            imglist.ImageSize = new Size(150, 150);
            imglist.ColorDepth = ColorDepth.Depth32Bit;
            foreach (var fileName in list)
            {
                imglist.Images.Add(Image.FromFile(path + fileName));
            }
            listView1.LargeImageList = imglist;

            for (int i = 0; i < imglist.Images.Count; i++)
            {
                var lvi = new ListViewItem();
                lvi.ImageIndex = i;
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            frmSHW s = new frmSHW();
            s.sendPath(list[this.listView1.SelectedItems[0].Index]);
            s.Show();
        }
    }
}
