
namespace Forms_Lab
{
    partial class frmCh02
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnreturnmethod = new System.Windows.Forms.Button();
            this.btn封裝 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.brnAsk = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnShowColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnOpen.Location = new System.Drawing.Point(472, 35);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(213, 49);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open Form1";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(472, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreturnmethod
            // 
            this.btnreturnmethod.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnreturnmethod.Location = new System.Drawing.Point(472, 186);
            this.btnreturnmethod.Name = "btnreturnmethod";
            this.btnreturnmethod.Size = new System.Drawing.Size(213, 49);
            this.btnreturnmethod.TabIndex = 2;
            this.btnreturnmethod.Text = "Return Method";
            this.btnreturnmethod.UseVisualStyleBackColor = true;
            this.btnreturnmethod.Click += new System.EventHandler(this.btnreturnmethod_Click);
            // 
            // btn封裝
            // 
            this.btn封裝.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn封裝.Location = new System.Drawing.Point(472, 266);
            this.btn封裝.Name = "btn封裝";
            this.btn封裝.Size = new System.Drawing.Size(213, 49);
            this.btn封裝.TabIndex = 3;
            this.btn封裝.Text = "封裝";
            this.btn封裝.UseVisualStyleBackColor = true;
            this.btn封裝.Click += new System.EventHandler(this.btn封裝_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F);
            this.button2.Location = new System.Drawing.Point(472, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "REPORT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // brnAsk
            // 
            this.brnAsk.Font = new System.Drawing.Font("新細明體", 12F);
            this.brnAsk.Location = new System.Drawing.Point(53, 125);
            this.brnAsk.Name = "brnAsk";
            this.brnAsk.Size = new System.Drawing.Size(213, 49);
            this.brnAsk.TabIndex = 7;
            this.brnAsk.Text = "Ask Question";
            this.brnAsk.UseVisualStyleBackColor = true;
            this.brnAsk.Click += new System.EventHandler(this.brnAsk_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDisable.Location = new System.Drawing.Point(53, 333);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(213, 49);
            this.btnDisable.TabIndex = 8;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnNew.Location = new System.Drawing.Point(53, 278);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(213, 49);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnShowColor
            // 
            this.btnShowColor.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnShowColor.Location = new System.Drawing.Point(53, 223);
            this.btnShowColor.Name = "btnShowColor";
            this.btnShowColor.Size = new System.Drawing.Size(213, 49);
            this.btnShowColor.TabIndex = 10;
            this.btnShowColor.UseVisualStyleBackColor = true;
            this.btnShowColor.Click += new System.EventHandler(this.btnShowColor_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowColor);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.brnAsk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn封裝);
            this.Controls.Add(this.btnreturnmethod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnreturnmethod;
        private System.Windows.Forms.Button btn封裝;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button brnAsk;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnShowColor;
    }
}