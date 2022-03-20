
namespace Forms_Lab
{
    partial class frmCh12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbA = new System.Windows.Forms.TextBox();
            this.btnPreCal = new System.Windows.Forms.Button();
            this.btnPostCal = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSt = new System.Windows.Forms.Button();
            this.btnNonst = new System.Windows.Forms.Button();
            this.btnOpenForm1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(58, 32);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(131, 22);
            this.tbA.TabIndex = 0;
            // 
            // btnPreCal
            // 
            this.btnPreCal.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnPreCal.Location = new System.Drawing.Point(58, 88);
            this.btnPreCal.Name = "btnPreCal";
            this.btnPreCal.Size = new System.Drawing.Size(131, 34);
            this.btnPreCal.TabIndex = 1;
            this.btnPreCal.Text = "PreCalculate";
            this.btnPreCal.UseVisualStyleBackColor = true;
            this.btnPreCal.Click += new System.EventHandler(this.btnPreCal_Click);
            // 
            // btnPostCal
            // 
            this.btnPostCal.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnPostCal.Location = new System.Drawing.Point(58, 145);
            this.btnPostCal.Name = "btnPostCal";
            this.btnPostCal.Size = new System.Drawing.Size(131, 34);
            this.btnPostCal.TabIndex = 2;
            this.btnPostCal.Text = "PostCalculate";
            this.btnPostCal.UseVisualStyleBackColor = true;
            this.btnPostCal.Click += new System.EventHandler(this.btnPostCal_Click);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(215, 32);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(131, 22);
            this.tbB.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnSt);
            this.groupBox1.Controls.Add(this.btnNonst);
            this.groupBox1.Location = new System.Drawing.Point(412, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 15F);
            this.textBox2.Location = new System.Drawing.Point(176, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 31);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 15F);
            this.textBox1.Location = new System.Drawing.Point(176, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 31);
            this.textBox1.TabIndex = 5;
            // 
            // btnSt
            // 
            this.btnSt.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnSt.Location = new System.Drawing.Point(16, 113);
            this.btnSt.Name = "btnSt";
            this.btnSt.Size = new System.Drawing.Size(131, 34);
            this.btnSt.TabIndex = 4;
            this.btnSt.Text = "Static";
            this.btnSt.UseVisualStyleBackColor = true;
            this.btnSt.Click += new System.EventHandler(this.btnSt_Click);
            // 
            // btnNonst
            // 
            this.btnNonst.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnNonst.Location = new System.Drawing.Point(16, 56);
            this.btnNonst.Name = "btnNonst";
            this.btnNonst.Size = new System.Drawing.Size(131, 34);
            this.btnNonst.TabIndex = 3;
            this.btnNonst.Text = "NonStatic";
            this.btnNonst.UseVisualStyleBackColor = true;
            this.btnNonst.Click += new System.EventHandler(this.btnNonst_Click);
            // 
            // btnOpenForm1
            // 
            this.btnOpenForm1.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnOpenForm1.Location = new System.Drawing.Point(428, 240);
            this.btnOpenForm1.Name = "btnOpenForm1";
            this.btnOpenForm1.Size = new System.Drawing.Size(291, 34);
            this.btnOpenForm1.TabIndex = 5;
            this.btnOpenForm1.Text = "OPEN Form1";
            this.btnOpenForm1.UseVisualStyleBackColor = true;
            this.btnOpenForm1.Click += new System.EventHandler(this.btnOpenForm1_Click);
            // 
            // frmCh12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenForm1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.btnPostCal);
            this.Controls.Add(this.btnPreCal);
            this.Controls.Add(this.tbA);
            this.Name = "frmCh12";
            this.Text = "frmCh12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Button btnPreCal;
        private System.Windows.Forms.Button btnPostCal;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSt;
        private System.Windows.Forms.Button btnNonst;
        private System.Windows.Forms.Button btnOpenForm1;
    }
}