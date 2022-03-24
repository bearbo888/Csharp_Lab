using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab
{
    public partial class frmHLO : Form
    {
        public frmHLO()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string name = tbname.Text;
            string eng = tbname_eng.Text;
            string sex ;
            string star ;

            if (drpsex.SelectedText.Length!=0 || drpstar.SelectedText.Length!=0 || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(eng))
            {
                MessageBox.Show("請完整填寫所有欄位");
            }
            else
            {
                sex = drpsex.SelectedItem.ToString();
                star = drpstar.SelectedItem.ToString();
                MessageBox.Show("中文名: " + name + Environment.NewLine + "英文名: " + eng + Environment.NewLine + "性別: " + sex + Environment.NewLine + "星座: " + star);
                MessageBox.Show(member.count2.ToString()) ;
            }

        }


    }
}
