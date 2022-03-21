
namespace StudentGrade
{
    partial class frmSGE
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
            this.btnRnd = new System.Windows.Forms.Button();
            this.btnSta = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandomAdd = new System.Windows.Forms.Button();
            this.listSub = new System.Windows.Forms.ListView();
            this.總分 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Math :";
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
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Engilsh :";
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
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chinese :";
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
            this.lbname.Size = new System.Drawing.Size(77, 22);
            this.lbname.TabIndex = 8;
            this.lbname.Text = "Name : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(12, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Student Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRnd
            // 
            this.btnRnd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRnd.Location = new System.Drawing.Point(12, 258);
            this.btnRnd.Name = "btnRnd";
            this.btnRnd.Size = new System.Drawing.Size(139, 32);
            this.btnRnd.TabIndex = 17;
            this.btnRnd.Text = "Add Random Data";
            this.btnRnd.UseVisualStyleBackColor = true;
            this.btnRnd.Click += new System.EventHandler(this.btnRnd_Click);
            // 
            // btnSta
            // 
            this.btnSta.Enabled = false;
            this.btnSta.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSta.Location = new System.Drawing.Point(12, 296);
            this.btnSta.Name = "btnSta";
            this.btnSta.Size = new System.Drawing.Size(139, 32);
            this.btnSta.TabIndex = 18;
            this.btnSta.Text = "Statistics";
            this.btnSta.UseVisualStyleBackColor = true;
            this.btnSta.Click += new System.EventHandler(this.btnSta_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(12, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 32);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRandomAdd
            // 
            this.btnRandomAdd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRandomAdd.Location = new System.Drawing.Point(12, 410);
            this.btnRandomAdd.Name = "btnRandomAdd";
            this.btnRandomAdd.Size = new System.Drawing.Size(139, 32);
            this.btnRandomAdd.TabIndex = 21;
            this.btnRandomAdd.Text = "Add 20 Random";
            this.btnRandomAdd.UseVisualStyleBackColor = true;
            this.btnRandomAdd.Click += new System.EventHandler(this.btnRandomAdd_Click);
            // 
            // listSub
            // 
            this.listSub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.總分,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listSub.GridLines = true;
            this.listSub.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listSub.HideSelection = false;
            this.listSub.Location = new System.Drawing.Point(169, 341);
            this.listSub.Name = "listSub";
            this.listSub.Size = new System.Drawing.Size(565, 97);
            this.listSub.TabIndex = 22;
            this.listSub.UseCompatibleStateImageBehavior = false;
            this.listSub.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chinese";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "English";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Math";
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
            this.listMain.Size = new System.Drawing.Size(565, 316);
            this.listMain.TabIndex = 24;
            this.listMain.UseCompatibleStateImageBehavior = false;
            this.listMain.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colChn
            // 
            this.colChn.Text = "Chinese";
            // 
            // colEng
            // 
            this.colEng.Text = "English";
            // 
            // colmath
            // 
            this.colmath.Text = "Math";
            // 
            // coltotal
            // 
            this.coltotal.Text = "Total";
            // 
            // colavg
            // 
            this.colavg.Text = "AVG.";
            // 
            // colmin
            // 
            this.colmin.Text = "Min.";
            this.colmin.Width = 100;
            // 
            // colmax
            // 
            this.colmax.Text = "Max.";
            this.colmax.Width = 100;
            // 
            // frmSGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.listMain);
            this.Controls.Add(this.listSub);
            this.Controls.Add(this.btnRandomAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSta);
            this.Controls.Add(this.btnRnd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbChn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbname);
            this.Name = "frmSGE";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btnRnd;
        private System.Windows.Forms.Button btnSta;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandomAdd;
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
        private System.Windows.Forms.ColumnHeader 總分;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

