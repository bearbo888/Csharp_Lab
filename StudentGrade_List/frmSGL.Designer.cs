﻿
namespace StudentGrade_List
{
    partial class frmSGL
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
            this.tbMath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.listSub = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMain = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colavg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchMin = new System.Windows.Forms.TextBox();
            this.tbSearchMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.brnStatistics = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMath
            // 
            this.tbMath.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbMath.Location = new System.Drawing.Point(94, 172);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(57, 33);
            this.tbMath.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F);
            this.label2.Location = new System.Drawing.Point(11, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "數學：";
            // 
            // tbEng
            // 
            this.tbEng.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbEng.Location = new System.Drawing.Point(94, 119);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(57, 33);
            this.tbEng.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F);
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "英文：";
            // 
            // tbChn
            // 
            this.tbChn.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbChn.Location = new System.Drawing.Point(94, 65);
            this.tbChn.Name = "tbChn";
            this.tbChn.Size = new System.Drawing.Size(57, 33);
            this.tbChn.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "國文：";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbName.Location = new System.Drawing.Point(94, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(57, 33);
            this.tbName.TabIndex = 9;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbname.Location = new System.Drawing.Point(11, 15);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(82, 22);
            this.lbname.TabIndex = 8;
            this.lbname.Text = "姓名： ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(12, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "新增一筆";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInsert.Location = new System.Drawing.Point(12, 258);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(139, 32);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "插入一筆";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(12, 296);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(139, 32);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "移除一筆";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(12, 341);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 32);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "清除所有";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listSub
            // 
            this.listSub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listSub.GridLines = true;
            this.listSub.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listSub.HideSelection = false;
            this.listSub.Location = new System.Drawing.Point(169, 341);
            this.listSub.Name = "listSub";
            this.listSub.Size = new System.Drawing.Size(564, 190);
            this.listSub.TabIndex = 22;
            this.listSub.UseCompatibleStateImageBehavior = false;
            this.listSub.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "科目";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "國文";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "英文";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "數學";
            // 
            // listMain
            // 
            this.listMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colChn,
            this.colEng,
            this.colmath,
            this.coltotal,
            this.colavg,
            this.colmin,
            this.colmax});
            this.listMain.GridLines = true;
            this.listMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listMain.HideSelection = false;
            this.listMain.Location = new System.Drawing.Point(169, 12);
            this.listMain.Name = "listMain";
            this.listMain.Size = new System.Drawing.Size(564, 316);
            this.listMain.TabIndex = 24;
            this.listMain.UseCompatibleStateImageBehavior = false;
            this.listMain.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "姓名";
            // 
            // colChn
            // 
            this.colChn.Text = "國文";
            // 
            // colEng
            // 
            this.colEng.Text = "英文";
            // 
            // colmath
            // 
            this.colmath.Text = "數學";
            // 
            // coltotal
            // 
            this.coltotal.Text = "總分";
            // 
            // colavg
            // 
            this.colavg.Text = "平均";
            // 
            // colmin
            // 
            this.colmin.Text = "最低分科目";
            this.colmin.Width = 100;
            // 
            // colmax
            // 
            this.colmax.Text = "最高分科目";
            this.colmax.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "搜尋科目";
            // 
            // tbSearchMin
            // 
            this.tbSearchMin.Location = new System.Drawing.Point(3, 30);
            this.tbSearchMin.Name = "tbSearchMin";
            this.tbSearchMin.Size = new System.Drawing.Size(49, 22);
            this.tbSearchMin.TabIndex = 26;
            // 
            // tbSearchMax
            // 
            this.tbSearchMax.Location = new System.Drawing.Point(85, 30);
            this.tbSearchMax.Name = "tbSearchMax";
            this.tbSearchMax.Size = new System.Drawing.Size(49, 22);
            this.tbSearchMax.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F);
            this.label5.Location = new System.Drawing.Point(59, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(3, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 32);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // brnStatistics
            // 
            this.brnStatistics.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.brnStatistics.Location = new System.Drawing.Point(12, 499);
            this.brnStatistics.Name = "brnStatistics";
            this.brnStatistics.Size = new System.Drawing.Size(139, 32);
            this.brnStatistics.TabIndex = 30;
            this.brnStatistics.Text = "各科統計";
            this.brnStatistics.UseVisualStyleBackColor = true;
            this.brnStatistics.Click += new System.EventHandler(this.brnStatistics_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbSearchMax);
            this.panel1.Controls.Add(this.tbSearchMin);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 100);
            this.panel1.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "國文",
            "英文",
            "數學"});
            this.comboBox1.Location = new System.Drawing.Point(77, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 20);
            this.comboBox1.TabIndex = 30;
            // 
            // frmSGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 549);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.brnStatistics);
            this.Controls.Add(this.listMain);
            this.Controls.Add(this.listSub);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbChn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbname);
            this.Name = "frmSGL";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView listSub;
        private System.Windows.Forms.ListView listMain;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colChn;
        private System.Windows.Forms.ColumnHeader colEng;
        private System.Windows.Forms.ColumnHeader colmath;
        private System.Windows.Forms.ColumnHeader coltotal;
        private System.Windows.Forms.ColumnHeader colavg;
        private System.Windows.Forms.ColumnHeader colmin;
        private System.Windows.Forms.ColumnHeader colmax;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSearchMin;
        private System.Windows.Forms.TextBox tbSearchMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button brnStatistics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

