
namespace Loan_Lab
{
    partial class frmLON
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
            this.tbamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbapr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbperiod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbinterest_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.期數 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.償還本金 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.償還利息 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.本期應繳金額 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbamount
            // 
            this.tbamount.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbamount.Location = new System.Drawing.Point(275, 36);
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(271, 42);
            this.tbamount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "貸款金額($):";
            // 
            // tbapr
            // 
            this.tbapr.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbapr.Location = new System.Drawing.Point(275, 101);
            this.tbapr.Name = "tbapr";
            this.tbapr.Size = new System.Drawing.Size(271, 42);
            this.tbapr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "年利率(%):";
            // 
            // tbperiod
            // 
            this.tbperiod.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbperiod.Location = new System.Drawing.Point(275, 174);
            this.tbperiod.Name = "tbperiod";
            this.tbperiod.Size = new System.Drawing.Size(271, 42);
            this.tbperiod.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(50, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "期限(年):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(50, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "總付金額($):";
            // 
            // tbinterest_total
            // 
            this.tbinterest_total.Enabled = false;
            this.tbinterest_total.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbinterest_total.Location = new System.Drawing.Point(275, 301);
            this.tbinterest_total.Name = "tbinterest_total";
            this.tbinterest_total.Size = new System.Drawing.Size(271, 42);
            this.tbinterest_total.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(50, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "全部利息($):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(269, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 12;
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsend.Location = new System.Drawing.Point(56, 387);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(123, 59);
            this.btnsend.TabIndex = 13;
            this.btnsend.Text = "計算";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(588, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "每期應繳金額($)";
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.期數,
            this.償還本金,
            this.償還利息,
            this.本期應繳金額});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(594, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 345);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // 期數
            // 
            this.期數.Text = "期數";
            // 
            // 償還本金
            // 
            this.償還本金.Text = "償還本金";
            // 
            // 償還利息
            // 
            this.償還利息.Text = "償還利息";
            // 
            // 本期應繳金額
            // 
            this.本期應繳金額.Text = "本期應繳金額";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(235, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 59);
            this.button1.TabIndex = 17;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreport
            // 
            this.btnreport.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnreport.Location = new System.Drawing.Point(423, 387);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(123, 59);
            this.btnreport.TabIndex = 18;
            this.btnreport.Text = "報告";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // tbtotal
            // 
            this.tbtotal.Enabled = false;
            this.tbtotal.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbtotal.Location = new System.Drawing.Point(275, 240);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(271, 42);
            this.tbtotal.TabIndex = 19;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 482);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbinterest_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbperiod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbapr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbamount);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbapr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbperiod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbinterest_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 期數;
        private System.Windows.Forms.ColumnHeader 償還本金;
        private System.Windows.Forms.ColumnHeader 償還利息;
        private System.Windows.Forms.ColumnHeader 本期應繳金額;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.TextBox tbtotal;
    }
}

