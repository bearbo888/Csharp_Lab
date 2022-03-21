using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrade
{
    public partial class frmSGE : Form
    {
        public frmSGE()
        {
            InitializeComponent();
            ListViewSet();
        }

        int i = 0;
        int count_click = 0;

        private void ListViewSet()
        {
            //ListView顯示方式
            listMain.View = View.Details;
            listSub.View = View.Details;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbName.Text)||String.IsNullOrWhiteSpace(tbChn.Text)|| String.IsNullOrWhiteSpace(tbEng.Text)|| String.IsNullOrWhiteSpace(tbMath.Text))
            {
                MessageBox.Show("尚未輸入值");
            }
            else
            {
                Sort sort = new Sort();
                Student stu = new Student()
                {
                    chn = Convert.ToDouble(tbChn.Text),
                    eng = Convert.ToDouble(tbEng.Text),
                    math = Convert.ToDouble(tbMath.Text)
                };
                string[,] list = new string[3,2] { { stu.chn.ToString(), "Chinese"}, { stu.eng.ToString(), "English"}, { stu.math.ToString(), "Math"} };

                stu.CalculateTol();
                stu.CalculateAvg();

                Sort.BubbleSort(list);

                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = tbName.Text;
                item.SubItems.Add(stu.chn.ToString());
                item.SubItems.Add(stu.eng.ToString());
                item.SubItems.Add(stu.math.ToString());
                item.SubItems.Add(stu.tol.ToString());
                item.SubItems.Add(stu.avg.ToString());
                item.SubItems.Add(list[0, 1] + " " + list[0, 0]);
                item.SubItems.Add(list[2, 1] + " " + list[2, 0]);
                listMain.Items.Add(item);
                count_click++;
                btnSta.Enabled = true;
            }          
        }
        private void btnRnd_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Sort sort = new Sort();
            Student stu = new Student()
            {
                chn = rnd.Next(0, 100),
                eng = rnd.Next(0, 100),
                math = rnd.Next(0, 100)
            };
            string[,] list = new string[3, 2] { { stu.chn.ToString(), "Chinese" }, { stu.eng.ToString(), "English" }, { stu.math.ToString(), "Math" } };

            stu.CalculateTol();
            stu.CalculateAvg();
            Sort.BubbleSort(list);


            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = i++.ToString();
            item.SubItems.Add(stu.chn.ToString());
            item.SubItems.Add(stu.eng.ToString());
            item.SubItems.Add(stu.math.ToString());
            item.SubItems.Add(stu.tol.ToString());
            item.SubItems.Add(stu.avg.ToString());
            item.SubItems.Add(list[0, 1] + " " + list[0, 0]);
            item.SubItems.Add(list[2, 1] + " " + list[2, 0]);
            listMain.Items.Add(item);
            count_click++;
            btnSta.Enabled = true;
        }
        private void btnSta_Click(object sender, EventArgs e)
        {
            listSub.Items.Clear();
            int suject_tol = 0;
            int eng_tol = 0;
            int ch_tol = 0;
            int math_tol = 0;
            double ch_avg, eng_avg, math_avg = 0;
            int i = 0;
            int[] arry_chn = new int[count_click];
            int[] arry_eng = new int[count_click];
            int[] arry_math = new int[count_click];

            for (; i < listMain.Items.Count; i++)
            {
                ch_tol += Convert.ToInt32(listMain.Items[i].SubItems[1].Text);
                arry_chn[i] = Convert.ToInt32(listMain.Items[i].SubItems[1].Text);
                eng_tol += Convert.ToInt32(listMain.Items[i].SubItems[2].Text);
                arry_eng[i] = Convert.ToInt32(listMain.Items[i].SubItems[2].Text);
                math_tol += Convert.ToInt32(listMain.Items[i].SubItems[3].Text);
                arry_math[i] = Convert.ToInt32(listMain.Items[i].SubItems[3].Text);
            }

            Sort.BubbleSort(arry_chn);
            Sort.BubbleSort(arry_eng);
            Sort.BubbleSort(arry_math);


            suject_tol = ch_tol + eng_tol + math_tol;
            ch_avg = ch_tol / i;
            eng_avg = eng_tol / i;
            math_avg = math_tol / i;

            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = "總分";
            item.SubItems.Add(ch_tol.ToString());
            item.SubItems.Add(eng_tol.ToString());
            item.SubItems.Add(math_tol.ToString());
            listSub.Items.Add(item);

            ListViewItem item1 = new ListViewItem();
            item1.SubItems[0].Text = "平均";
            item1.SubItems.Add(ch_avg.ToString());
            item1.SubItems.Add(eng_avg.ToString());
            item1.SubItems.Add(math_avg.ToString());
            listSub.Items.Add(item1);

            ListViewItem item11 = new ListViewItem();
            item11.SubItems[0].Text = "最高";
            item11.SubItems.Add(arry_chn[arry_chn.Length-1].ToString());
            item11.SubItems.Add(arry_eng[arry_eng.Length-1].ToString());
            item11.SubItems.Add(arry_math[arry_math.Length-1].ToString());
            listSub.Items.Add(item11);

            ListViewItem item111 = new ListViewItem();
            item111.SubItems[0].Text = "最低";
            item111.SubItems.Add(arry_chn[0].ToString());
            item111.SubItems.Add(arry_eng[0].ToString());
            item111.SubItems.Add(arry_math[0].ToString());
            listSub.Items.Add(item111);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listMain.Items.Clear();
            listSub.Items.Clear();
            btnSta.Enabled = false;
        }

        private void btnRandomAdd_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int num = 0; num < 20; num++)
            {
                Sort sort = new Sort();
                Student stu = new Student()
                {
                    chn = rnd.Next(0, 100),
                    eng = rnd.Next(0, 100),
                    math = rnd.Next(0, 100)
                };
                string[,] list = new string[3, 2] { { stu.chn.ToString(), "Chinese" }, { stu.eng.ToString(), "English" }, { stu.math.ToString(), "Math" } };

                stu.CalculateTol();
                stu.CalculateAvg();
                Sort.BubbleSort(list);


                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = i++.ToString();
                item.SubItems.Add(stu.chn.ToString());
                item.SubItems.Add(stu.eng.ToString());
                item.SubItems.Add(stu.math.ToString());
                item.SubItems.Add(stu.tol.ToString());
                item.SubItems.Add(stu.avg.ToString());
                item.SubItems.Add(list[0, 1] + " " + list[0, 0]);
                item.SubItems.Add(list[2, 1] + " " + list[2, 0]);
                listMain.Items.Add(item);
                count_click++;
            }

            btnSta.Enabled = true;
        }
    }
}
