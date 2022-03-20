using System;
using System.Windows.Forms;

namespace StudentGrade
{
    public partial class frmSGL : Form
    {
        public frmSGL()
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
                double[] list = new double[] { stu.chn, stu.eng, stu.math };

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
                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[2].ToString());
                listMain.Items.Add(item);
                count_click++;
                btnRemove.Enabled = true;
            }          
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbName.Text) || String.IsNullOrWhiteSpace(tbChn.Text) || String.IsNullOrWhiteSpace(tbEng.Text) || String.IsNullOrWhiteSpace(tbMath.Text))
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
                double[] list = new double[] { stu.chn, stu.eng, stu.math };

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
                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[2].ToString());
                listMain.Items.Insert(0, item);

                count_click++;
                btnRemove.Enabled = true;
            }            
        } 
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.listMain.Items.Count>0)
            {
                ListViewItem item = new ListViewItem();
                listMain.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("No Content.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listMain.Items.Clear(); 
            listSub.Items.Clear();
            btnRemove.Enabled = false;

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
                double[] list = new double[] { stu.chn, stu.eng, stu.math };

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
                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[2].ToString());
                listMain.Items.Add(item);
                count_click++;
            }

            btnRemove.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for(int j=0; j < listMain.Items.Count-1; j++)
            {
                //listMain.Items[i].SubItems[1].Text CHINESE COLUMN


            }
        }
    }
}
