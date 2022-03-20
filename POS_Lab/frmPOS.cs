using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Lab
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        int total = 0;
        string[] name  = new string[] { "007:皇家賭場","紅心","鑽石","人生逆轉","給開司一杯啤酒","SHOT","進口瓶裝水" };
        int[]    count = new int[]    { 0,0,0,0,0,0,0};

        void caltotal()
        {
            tbtotal.Text = total.ToString();
        }
        void deletelist(string stringToDelete, ListView listBoxToDeleteItem)
        {
            for (int i = 0; i < listBoxToDeleteItem.Items.Count; i++)
            {
                if (stringToDelete == listBoxToDeleteItem.Items[i].Text)
                {
                    listBoxToDeleteItem.Items[i].Remove();
                }
            }
        }
        string combination(int i, int price)
        {
            return name[i].ToString() + " x" + count[i] + ",共NT$ " + count[i] * price + "元";
        }

        private void btnCreidtcard_Click(object sender, EventArgs e)
        {
            if(total > 0)
            {
                MessageBox.Show("總金額: " + total + "\n" + "折扣後金額: " + total * 0.9, "確認付款");
            }
            else
            {
                MessageBox.Show("尚未點餐");
            }
            
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            if (total > 0)
            {
                MessageBox.Show("總金額: " + total, "確認付款");
            }
            else
            {
                MessageBox.Show("尚未點餐");
            }
        }
        private void btncasino_Click(object sender, EventArgs e)
        {
            int price = 350;
            string str = combination(0, price);

            ListViewItem item = new ListViewItem();
            this.lstshopping.View = View.List;

            if (lstshopping.FindItemWithText(name[0]) != null)
                deletelist(combination(0, price), lstshopping);

            count[0]++;
            total += price;
            caltotal();
            item.SubItems[0].Text = combination(0, price);
            lstshopping.Items.Add(item);
        }
        private void btnheart_Click(object sender, EventArgs e)
        {
            int price = 300;
            ListViewItem item = new ListViewItem();
            this.lstshopping.View = View.List;

            if (lstshopping.FindItemWithText(name[1]) != null)
                deletelist(combination(1,price), lstshopping);

            count[1]++;
            total += price;
            caltotal();
            item.SubItems[0].Text = combination(1, price);
            lstshopping.Items.Add(item);
        }
        private void btndimond_Click(object sender, EventArgs e)
        {
            int price = 350;
            ListViewItem item = new ListViewItem();
            this.lstshopping.View = View.List;

            if (lstshopping.FindItemWithText(name[2]) != null)
                deletelist(combination(2, price), lstshopping);

            count[2]++;
            total += price;

            caltotal();
            item.SubItems[0].Text = combination(2, price);
            lstshopping.Items.Add(item);
        }
        private void btnnewlife_Click(object sender, EventArgs e)
        {
            int price = 400;
            ListViewItem item = new ListViewItem();
            this.lstshopping.View = View.List;

            if (lstshopping.FindItemWithText(name[3]) != null)
                deletelist(combination(3, price), lstshopping);

            count[3]++;
            total += price;
            caltotal();
            item.SubItems[0].Text = combination(3, price);
            lstshopping.Items.Add(item);
        }
        private void btnbeer_Click(object sender, EventArgs e)
        {
            int price = 400;
            ListViewItem item = new ListViewItem();
            this.lstshopping.View = View.List;

            if (lstshopping.FindItemWithText(name[4]) != null)
                deletelist(combination(4, price), lstshopping);

            count[4]++;
            total += price;
            caltotal();
            item.SubItems[0].Text = combination(4, price);
            lstshopping.Items.Add(item);
        }
        private void btnshot_Click(object sender, EventArgs e)
        {
            int price = 1500;
            ListViewItem item = new ListViewItem();
            this.lstshopping.View = View.List;

            if (lstshopping.FindItemWithText(name[5]) != null)
                deletelist(combination(5, price), lstshopping);

            count[5]++;
            total += price;
            caltotal();
            item.SubItems[0].Text = combination(5, price);
            lstshopping.Items.Add(item);
        }

        private void btnwater_Click(object sender, EventArgs e)
        {
            int price = 150;
            ListViewItem item = new ListViewItem();
            this.lstshopping.View = View.List;

            if (lstshopping.FindItemWithText(name[6]) != null)
                deletelist(combination(6, price), lstshopping);

            count[6]++;
            total += price;
            caltotal();
            item.SubItems[0].Text = combination(6, price);
            lstshopping.Items.Add(item);
        }
        private void btndimond_MouseHover(object sender, EventArgs e)
        {
            picbox.Image = Image.FromFile("../../pic/dimond.jpg");
        }
        private void btnheart_MouseHover(object sender, EventArgs e)
        {
            picbox.Image = Image.FromFile("../../pic/heart.jpg");
        }
        private void btncasino_MouseHover(object sender, EventArgs e)
        {
            picbox.Image = Image.FromFile("../../pic/casino.jpg");
        }
        private void btnnewlife_MouseHover(object sender, EventArgs e)
        {
            picbox.Image = Image.FromFile("../../pic/life.jpg");
        }
        private void btnbeer_MouseHover(object sender, EventArgs e)
        {
            picbox.Image = Image.FromFile("../../pic/beer.jpg");
        }
        private void btnshot_MouseHover(object sender, EventArgs e)
        {
            picbox.Image = Image.FromFile("../../pic/shot.jpg");
        }
        private void btnwater_MouseHover(object sender, EventArgs e)
        {
            picbox.Image = Image.FromFile("../../pic/water.jpg");
        }
        
        private void btnclear_Click(object sender, EventArgs e)
        {
            lstshopping.Clear();
            total = 0;
            for(int i=0; i<count.Length;i++)
            {
                count[i] = 0;
            }
        }
    }
}
