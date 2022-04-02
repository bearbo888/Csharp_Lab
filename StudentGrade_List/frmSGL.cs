using StudentGrade;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentGrade_List
{
    public partial class frmSGL : Form
    {
        public frmSGL()
        {
            InitializeComponent();
            ListViewSet();
        }

        int i = 0;
        bool chk = false;
        int count_click = 0;
        string[,] array;

        private void ListViewSet()
        {
            //ListView顯示方式
            listMain.View = View.Details;
            listSub.View = View.Details;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                string[,] list = new string[3, 2] { { stu.chn.ToString(), "國文" }, { stu.eng.ToString(), "英文" }, { stu.math.ToString(), "數學" } };
                stu.CalculateTol();
                stu.CalculateAvg();
                Sort.BubbleSort(list);

                if (chk)
                {
                    listMain.Items.Clear();
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        ListViewItem item_old = new ListViewItem();
                        item_old.SubItems[0].Text = array[j, 0];
                        for (int y = 1; y < 8; y++)
                        {
                            item_old.SubItems.Add(array[j, y]);
                        }
                        listMain.Items.Add(item_old);
                    }
                    chk = !chk;
                }

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

                item.UseItemStyleForSubItems = false;
                if (stu.chn < 60)
                {
                    item.SubItems[1].ForeColor = Color.Red;
                }
                if (stu.eng < 60)
                {
                    item.SubItems[2].ForeColor = Color.Red;
                }
                if (stu.math < 60)
                {
                    item.SubItems[3].ForeColor = Color.Red;
                }
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
                string[,] list = new string[3, 2] { { stu.chn.ToString(), "國文" }, { stu.eng.ToString(), "英文" }, { stu.math.ToString(), "數學" } };

                stu.CalculateTol();
                stu.CalculateAvg();
                Sort.BubbleSort(list);

                if (chk)
                {
                    listMain.Items.Clear();
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        ListViewItem item_old = new ListViewItem();
                        item_old.SubItems[0].Text = array[j, 0];
                        for (int y = 1; y < 8; y++)
                        {
                            item_old.SubItems.Add(array[j, y]);
                        }
                        listMain.Items.Add(item_old);
                    }
                    chk = !chk;
                }

                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = tbName.Text;
                item.SubItems.Add(stu.chn.ToString());
                item.SubItems.Add(stu.eng.ToString());
                item.SubItems.Add(stu.math.ToString());
                item.SubItems.Add(stu.tol.ToString());
                item.SubItems.Add(stu.avg.ToString());
                item.SubItems.Add(list[0, 1] + " " + list[0, 0]);
                item.SubItems.Add(list[2, 1] + " " + list[2, 0]);
                listMain.Items.Insert(0, item);

                item.UseItemStyleForSubItems = false;
                if (stu.chn < 60)
                {
                    item.SubItems[1].ForeColor = Color.Red;
                }
                if (stu.eng < 60)
                {
                    item.SubItems[2].ForeColor = Color.Red;
                }
                if (stu.math < 60)
                {
                    item.SubItems[3].ForeColor = Color.Red;
                }

                count_click++;
                btnRemove.Enabled = true;
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.listMain.Items.Count > 0)
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
            array = new string[3, 2];
            btnRemove.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(tbSearchMin.Text) || String.IsNullOrWhiteSpace(tbSearchMax.Text)|| comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("搜尋欄位未填寫完整");
                }
                else if (int.Parse(tbSearchMin.Text) > int.Parse(tbSearchMax.Text))
                {
                    MessageBox.Show("最低設定分數高於最高設定分數");
                }
                else
                {
                    array = new string[listMain.Items.Count, 8];
                    for (int j = 0; j < listMain.Items.Count; j++)
                    {
                        for (int x = 0; x < 8; x++)
                        {
                            array[j, x] = listMain.Items[j].SubItems[x].Text;
                        }
                    }

                    listMain.Items.Clear();

                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        int num = 0;

                        switch (comboBox1.SelectedItem.ToString())
                        {
                            case "國文":
                                num = int.Parse(array[j, 1]);
                                break;
                            case "英文":
                                num = int.Parse(array[j, 2]);
                                break;
                            case "數學":
                                num = int.Parse(array[j, 3]);
                                break;
                        }

                        if (num > int.Parse(tbSearchMin.Text) && num < int.Parse(tbSearchMax.Text))
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = array[j, 0];
                            for (int y = 1; y < 8; y++)
                            {
                                item.SubItems.Add(array[j, y]);
                            }
                            listMain.Items.Add(item);
                        }
                    }
                    chk = !chk;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void brnStatistics_Click(object sender, EventArgs e)
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
            item11.SubItems.Add(arry_chn[arry_chn.Length - 1].ToString());
            item11.SubItems.Add(arry_eng[arry_eng.Length - 1].ToString());
            item11.SubItems.Add(arry_math[arry_math.Length - 1].ToString());
            listSub.Items.Add(item11);

            ListViewItem item111 = new ListViewItem();
            item111.SubItems[0].Text = "最低";
            item111.SubItems.Add(arry_chn[0].ToString());
            item111.SubItems.Add(arry_eng[0].ToString());
            item111.SubItems.Add(arry_math[0].ToString());
            listSub.Items.Add(item111);
        }

    }
}
