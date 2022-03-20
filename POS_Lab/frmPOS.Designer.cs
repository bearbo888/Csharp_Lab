
namespace POS_Lab
{
    partial class frmPOS
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.btnshot = new System.Windows.Forms.Button();
            this.btnbeer = new System.Windows.Forms.Button();
            this.btnwater = new System.Windows.Forms.Button();
            this.btndimond = new System.Windows.Forms.Button();
            this.btnnewlife = new System.Windows.Forms.Button();
            this.btnheart = new System.Windows.Forms.Button();
            this.btncasino = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreidtcard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.lstshopping = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picbox);
            this.panel1.Controls.Add(this.btnshot);
            this.panel1.Controls.Add(this.btnbeer);
            this.panel1.Controls.Add(this.btnwater);
            this.panel1.Controls.Add(this.btndimond);
            this.panel1.Controls.Add(this.btnnewlife);
            this.panel1.Controls.Add(this.btnheart);
            this.panel1.Controls.Add(this.btncasino);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(35, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 551);
            this.panel1.TabIndex = 0;
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(26, 306);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(220, 220);
            this.picbox.TabIndex = 10;
            this.picbox.TabStop = false;
            // 
            // btnshot
            // 
            this.btnshot.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnshot.Location = new System.Drawing.Point(26, 236);
            this.btnshot.Name = "btnshot";
            this.btnshot.Size = new System.Drawing.Size(220, 29);
            this.btnshot.TabIndex = 9;
            this.btnshot.Text = "SHOT 6杯1500";
            this.btnshot.UseVisualStyleBackColor = true;
            this.btnshot.Click += new System.EventHandler(this.btnshot_Click);
            this.btnshot.MouseHover += new System.EventHandler(this.btnshot_MouseHover);
            // 
            // btnbeer
            // 
            this.btnbeer.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnbeer.Location = new System.Drawing.Point(26, 201);
            this.btnbeer.Name = "btnbeer";
            this.btnbeer.Size = new System.Drawing.Size(220, 29);
            this.btnbeer.TabIndex = 8;
            this.btnbeer.Text = "給開司一杯啤酒 $400";
            this.btnbeer.UseVisualStyleBackColor = true;
            this.btnbeer.Click += new System.EventHandler(this.btnbeer_Click);
            this.btnbeer.MouseHover += new System.EventHandler(this.btnbeer_MouseHover);
            // 
            // btnwater
            // 
            this.btnwater.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnwater.Location = new System.Drawing.Point(26, 271);
            this.btnwater.Name = "btnwater";
            this.btnwater.Size = new System.Drawing.Size(220, 29);
            this.btnwater.TabIndex = 7;
            this.btnwater.Text = "進口瓶裝水 $150";
            this.btnwater.UseVisualStyleBackColor = true;
            this.btnwater.Click += new System.EventHandler(this.btnwater_Click);
            this.btnwater.MouseHover += new System.EventHandler(this.btnwater_MouseHover);
            // 
            // btndimond
            // 
            this.btndimond.Font = new System.Drawing.Font("新細明體", 12F);
            this.btndimond.Location = new System.Drawing.Point(26, 131);
            this.btndimond.Name = "btndimond";
            this.btndimond.Size = new System.Drawing.Size(220, 29);
            this.btndimond.TabIndex = 5;
            this.btndimond.Text = "鑽石 $350";
            this.btndimond.UseVisualStyleBackColor = true;
            this.btndimond.Click += new System.EventHandler(this.btndimond_Click);
            this.btndimond.MouseHover += new System.EventHandler(this.btndimond_MouseHover);
            // 
            // btnnewlife
            // 
            this.btnnewlife.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnnewlife.Location = new System.Drawing.Point(26, 166);
            this.btnnewlife.Name = "btnnewlife";
            this.btnnewlife.Size = new System.Drawing.Size(220, 29);
            this.btnnewlife.TabIndex = 4;
            this.btnnewlife.Text = "人生逆轉 $400";
            this.btnnewlife.UseVisualStyleBackColor = true;
            this.btnnewlife.Click += new System.EventHandler(this.btnnewlife_Click);
            this.btnnewlife.MouseHover += new System.EventHandler(this.btnnewlife_MouseHover);
            // 
            // btnheart
            // 
            this.btnheart.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnheart.Location = new System.Drawing.Point(26, 96);
            this.btnheart.Name = "btnheart";
            this.btnheart.Size = new System.Drawing.Size(220, 29);
            this.btnheart.TabIndex = 3;
            this.btnheart.Text = "紅心 $300";
            this.btnheart.UseVisualStyleBackColor = true;
            this.btnheart.Click += new System.EventHandler(this.btnheart_Click);
            this.btnheart.MouseHover += new System.EventHandler(this.btnheart_MouseHover);
            // 
            // btncasino
            // 
            this.btncasino.Font = new System.Drawing.Font("新細明體", 12F);
            this.btncasino.Location = new System.Drawing.Point(26, 61);
            this.btncasino.Name = "btncasino";
            this.btncasino.Size = new System.Drawing.Size(220, 29);
            this.btncasino.TabIndex = 2;
            this.btncasino.Text = "007 皇家賭場 $350";
            this.btncasino.UseVisualStyleBackColor = true;
            this.btncasino.Click += new System.EventHandler(this.btncasino_Click);
            this.btncasino.MouseHover += new System.EventHandler(this.btncasino_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 22F);
            this.label3.Location = new System.Drawing.Point(21, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Menu";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCreidtcard);
            this.panel2.Controls.Add(this.btnCash);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(330, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 60);
            this.panel2.TabIndex = 1;
            // 
            // btnCreidtcard
            // 
            this.btnCreidtcard.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnCreidtcard.Location = new System.Drawing.Point(319, 13);
            this.btnCreidtcard.Name = "btnCreidtcard";
            this.btnCreidtcard.Size = new System.Drawing.Size(119, 29);
            this.btnCreidtcard.TabIndex = 2;
            this.btnCreidtcard.Text = "信用卡";
            this.btnCreidtcard.UseVisualStyleBackColor = true;
            this.btnCreidtcard.Click += new System.EventHandler(this.btnCreidtcard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnCash.Location = new System.Drawing.Point(170, 13);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(119, 29);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 22F);
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "付款方式";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnclear);
            this.panel3.Controls.Add(this.lstshopping);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(330, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 316);
            this.panel3.TabIndex = 2;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnclear.Location = new System.Drawing.Point(20, 271);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(106, 29);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lstshopping
            // 
            this.lstshopping.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstshopping.HideSelection = false;
            this.lstshopping.Location = new System.Drawing.Point(20, 61);
            this.lstshopping.Name = "lstshopping";
            this.lstshopping.Size = new System.Drawing.Size(430, 204);
            this.lstshopping.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstshopping.TabIndex = 2;
            this.lstshopping.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 22F);
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shopping List";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(50, 50);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(330, 418);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(479, 97);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tbtotal);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(330, 521);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(479, 60);
            this.panel6.TabIndex = 4;
            // 
            // tbtotal
            // 
            this.tbtotal.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbtotal.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbtotal.ForeColor = System.Drawing.SystemColors.Window;
            this.tbtotal.Location = new System.Drawing.Point(132, 13);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(318, 33);
            this.tbtotal.TabIndex = 1;
            this.tbtotal.Text = "0";
            this.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 22F);
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "總金額:";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 593);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmPOS";
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreidtcard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnnewlife;
        private System.Windows.Forms.Button btnheart;
        private System.Windows.Forms.Button btncasino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListView lstshopping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button btnshot;
        private System.Windows.Forms.Button btnbeer;
        private System.Windows.Forms.Button btnwater;
        private System.Windows.Forms.Button btndimond;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label6;
    }
}

