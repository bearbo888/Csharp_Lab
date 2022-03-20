
namespace Forms_Lab
{
    partial class frmCh16
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
            this.btnVal = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(54, 49);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(231, 72);
            this.btnVal.TabIndex = 0;
            this.btnVal.Text = "val type";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(54, 127);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(231, 72);
            this.btnRef.TabIndex = 1;
            this.btnRef.Text = "REF type";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pass String";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 72);
            this.button2.TabIndex = 3;
            this.button2.Text = "by ref";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCh16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnVal);
            this.Name = "frmCh16";
            this.Text = "frmCh16";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}