
namespace Forms_Lab
{
    partial class frmHLO
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.tbname_eng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drpsex = new System.Windows.Forms.ComboBox();
            this.drpstar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "中文名";
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbname.Location = new System.Drawing.Point(140, 45);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(271, 42);
            this.tbname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(36, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "英文名";
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsend.Location = new System.Drawing.Point(140, 349);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(270, 59);
            this.btnsend.TabIndex = 6;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // tbname_eng
            // 
            this.tbname_eng.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbname_eng.Location = new System.Drawing.Point(140, 114);
            this.tbname_eng.Name = "tbname_eng";
            this.tbname_eng.Size = new System.Drawing.Size(271, 42);
            this.tbname_eng.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "星座";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(36, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "性別";
            // 
            // drpsex
            // 
            this.drpsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpsex.Font = new System.Drawing.Font("新細明體", 22F);
            this.drpsex.FormattingEnabled = true;
            this.drpsex.Items.AddRange(new object[] {
            "男性",
            "女性",
            "中性"});
            this.drpsex.Location = new System.Drawing.Point(140, 181);
            this.drpsex.Name = "drpsex";
            this.drpsex.Size = new System.Drawing.Size(270, 37);
            this.drpsex.TabIndex = 12;
            // 
            // drpstar
            // 
            this.drpstar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpstar.Font = new System.Drawing.Font("新細明體", 22F);
            this.drpstar.FormattingEnabled = true;
            this.drpstar.Items.AddRange(new object[] {
            "水瓶座",
            "双鱼座",
            "白羊座",
            "金牛座",
            "双子座"});
            this.drpstar.Location = new System.Drawing.Point(140, 256);
            this.drpstar.Name = "drpstar";
            this.drpstar.Size = new System.Drawing.Size(270, 37);
            this.drpstar.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.drpstar);
            this.Controls.Add(this.drpsex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbname_eng);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox tbname_eng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drpsex;
        private System.Windows.Forms.ComboBox drpstar;
    }
}

