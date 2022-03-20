
namespace Forms_Lab
{
    partial class frmCh15
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVal
            // 
            this.btnVal.Font = new System.Drawing.Font("新細明體", 36F);
            this.btnVal.Location = new System.Drawing.Point(40, 42);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(238, 128);
            this.btnVal.TabIndex = 0;
            this.btnVal.Text = "Val Type";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // btnRef
            // 
            this.btnRef.Font = new System.Drawing.Font("新細明體", 36F);
            this.btnRef.Location = new System.Drawing.Point(40, 176);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(238, 128);
            this.btnRef.TabIndex = 1;
            this.btnRef.Text = "Ref Type";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnVal);
            this.Name = "Form15";
            this.Text = "Form15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.TextBox textBox1;
    }
}