
namespace Student_StructForm
{
    partial class frmSSF
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
            this.lbname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbChn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listSub = new System.Windows.Forms.ListView();
            this.listMain = new System.Windows.Forms.ListView();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbname.Location = new System.Drawing.Point(54, 60);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(77, 22);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Name : ";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbName.Location = new System.Drawing.Point(168, 57);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(185, 33);
            this.tbName.TabIndex = 1;
            // 
            // tbChn
            // 
            this.tbChn.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbChn.Location = new System.Drawing.Point(168, 110);
            this.tbChn.Name = "tbChn";
            this.tbChn.Size = new System.Drawing.Size(185, 33);
            this.tbChn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(54, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chinese :";
            // 
            // tbMath
            // 
            this.tbMath.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbMath.Location = new System.Drawing.Point(168, 217);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(185, 33);
            this.tbMath.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F);
            this.label2.Location = new System.Drawing.Point(54, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Math :";
            // 
            // tbEng
            // 
            this.tbEng.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbEng.Location = new System.Drawing.Point(168, 164);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(185, 33);
            this.tbEng.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F);
            this.label3.Location = new System.Drawing.Point(54, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Engilsh :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnSave.Location = new System.Drawing.Point(58, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnShowAll.Location = new System.Drawing.Point(188, 289);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(165, 41);
            this.btnShowAll.TabIndex = 9;
            this.btnShowAll.Text = "Show All Score";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listSub);
            this.panel1.Controls.Add(this.listMain);
            this.panel1.Location = new System.Drawing.Point(390, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 226);
            this.panel1.TabIndex = 10;
            // 
            // listSub
            // 
            this.listSub.HideSelection = false;
            this.listSub.Location = new System.Drawing.Point(3, 145);
            this.listSub.Name = "listSub";
            this.listSub.Size = new System.Drawing.Size(350, 76);
            this.listSub.TabIndex = 1;
            this.listSub.UseCompatibleStateImageBehavior = false;
            // 
            // listMain
            // 
            this.listMain.Font = new System.Drawing.Font("新細明體", 14F);
            this.listMain.HideSelection = false;
            this.listMain.Location = new System.Drawing.Point(3, 3);
            this.listMain.Name = "listMain";
            this.listMain.Size = new System.Drawing.Size(350, 136);
            this.listMain.TabIndex = 0;
            this.listMain.UseCompatibleStateImageBehavior = false;
            this.listMain.View = System.Windows.Forms.View.List;
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnMaxMin.Location = new System.Drawing.Point(514, 289);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(234, 41);
            this.btnMaxMin.TabIndex = 11;
            this.btnMaxMin.Text = "Display  Max/Min Score";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // frmSSF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 354);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbChn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbname);
            this.Name = "frmSSF";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbChn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listSub;
        private System.Windows.Forms.ListView listMain;
        private System.Windows.Forms.Button btnMaxMin;
    }
}

