
namespace Method
{
    partial class Form1
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnchk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnLongName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbInput.Location = new System.Drawing.Point(148, 18);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(114, 39);
            this.tbInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number :";
            // 
            // btnchk
            // 
            this.btnchk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnchk.Location = new System.Drawing.Point(28, 63);
            this.btnchk.Name = "btnchk";
            this.btnchk.Size = new System.Drawing.Size(250, 43);
            this.btnchk.TabIndex = 2;
            this.btnchk.Text = "Even number?  Odd number?";
            this.btnchk.UseVisualStyleBackColor = true;
            this.btnchk.Click += new System.EventHandler(this.btnchk_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(28, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "arr0711 min/Max";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(28, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = " arr0711 statistics even and odd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(28, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 43);
            this.button5.TabIndex = 8;
            this.button5.Text = "arr0711_str  How many char\'c\' ?";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnLongName
            // 
            this.btnLongName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLongName.Location = new System.Drawing.Point(28, 237);
            this.btnLongName.Name = "btnLongName";
            this.btnLongName.Size = new System.Drawing.Size(250, 43);
            this.btnLongName.TabIndex = 7;
            this.btnLongName.Text = "arr0711_str  longest name?";
            this.btnLongName.UseVisualStyleBackColor = true;
            this.btnLongName.Click += new System.EventHandler(this.btnLongName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(23, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Result:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.SystemColors.Info;
            this.lbResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbResult.Location = new System.Drawing.Point(28, 383);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 20);
            this.lbResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnLongName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnchk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnchk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnLongName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResult;
    }
}

