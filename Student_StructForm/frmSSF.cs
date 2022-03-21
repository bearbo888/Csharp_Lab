using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_StructForm
{
    public partial class frmSSF : Form
    {
        enum subject 
        {
            Chinese,
            English,
            Math
        }
        public frmSSF()
        {
            InitializeComponent();
        }

        string name = "";
        int chn_score, eng_score, math_score = 0;

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            listSub.View = View.List;

            string[,] score = new string[3, 2] { {chn_score.ToString(), "Chinese"}, { eng_score.ToString(), "English" }, { math_score.ToString(), "Math" } };

            for(int i = 0; i < score.Length; i++)
            {
                for(int j = 0; j < score.GetLength(0) - 1; j++)
                {
                    if (int.Parse(score[j,0]) > int.Parse(score[j + 1,0]))
                    {
                        for(int x = 0; x < 2; x++)
                        {
                            var temp = score[j, x];
                            score[j, x] = score[j + 1, x];
                            score[j + 1, x] = temp;
                        }                       
                    }
                }
                
            }

            listSub.Items.Add("Max Score:  "+ score[2, 1] + " " + score[2,0]);
            listSub.Items.Add("Min Score:  "+ score[0, 1] + " " + score[0,0]);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            listMain.Clear();

            if (!String.IsNullOrWhiteSpace(name) || chn_score !=0 || eng_score!=0 || math_score!=0)
            {
                listMain.View = View.List;
                listMain.Items.Add("Name:" + name);
                listMain.Items.Add("Chinese:" + chn_score.ToString());
                listMain.Items.Add("English" + eng_score.ToString());
                listMain.Items.Add("Math:" + math_score.ToString());
            }
            else
            {
                MessageBox.Show("No values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbName.Text) || String.IsNullOrWhiteSpace(tbChn.Text) || String.IsNullOrWhiteSpace(tbEng.Text) || String.IsNullOrWhiteSpace(tbMath.Text))
            {
                MessageBox.Show("Please input the values", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                name = tbName.Text;
                chn_score = Convert.ToInt32(tbChn.Text);
                eng_score = Convert.ToInt32(tbEng.Text);
                math_score = Convert.ToInt32(tbMath.Text);
            }
        }

    }
}
