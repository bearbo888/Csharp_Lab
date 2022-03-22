
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
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnStaEvenOdd = new System.Windows.Forms.Button();
            this.btnInclude = new System.Windows.Forms.Button();
            this.btnLongName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnOneZero = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btbArySum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbInput.Location = new System.Drawing.Point(148, 18);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(76, 39);
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
            this.btnchk.Size = new System.Drawing.Size(229, 43);
            this.btnchk.TabIndex = 2;
            this.btnchk.Text = "奇數?偶數?";
            this.btnchk.UseVisualStyleBackColor = true;
            this.btnchk.Click += new System.EventHandler(this.btnchk_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinMax.Location = new System.Drawing.Point(28, 116);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(229, 43);
            this.btnMinMax.TabIndex = 3;
            this.btnMinMax.Text = "arr0711 最小/最大值?";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnStaEvenOdd
            // 
            this.btnStaEvenOdd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStaEvenOdd.Location = new System.Drawing.Point(28, 165);
            this.btnStaEvenOdd.Name = "btnStaEvenOdd";
            this.btnStaEvenOdd.Size = new System.Drawing.Size(229, 43);
            this.btnStaEvenOdd.TabIndex = 4;
            this.btnStaEvenOdd.Text = " arr0711 統計奇偶數";
            this.btnStaEvenOdd.UseVisualStyleBackColor = true;
            this.btnStaEvenOdd.Click += new System.EventHandler(this.btnStaEvenOdd_Click);
            // 
            // btnInclude
            // 
            this.btnInclude.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInclude.Location = new System.Drawing.Point(28, 263);
            this.btnInclude.Name = "btnInclude";
            this.btnInclude.Size = new System.Drawing.Size(229, 43);
            this.btnInclude.TabIndex = 8;
            this.btnInclude.Text = "arr0711_str[] 統計包含\'C\' ";
            this.btnInclude.UseVisualStyleBackColor = true;
            this.btnInclude.Click += new System.EventHandler(this.btnInclude_Click);
            // 
            // btnLongName
            // 
            this.btnLongName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLongName.Location = new System.Drawing.Point(28, 214);
            this.btnLongName.Name = "btnLongName";
            this.btnLongName.Size = new System.Drawing.Size(229, 43);
            this.btnLongName.TabIndex = 7;
            this.btnLongName.Text = "arr0711_str[] 最長值?";
            this.btnLongName.UseVisualStyleBackColor = true;
            this.btnLongName.Click += new System.EventHandler(this.btnLongName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 326);
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
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOne.Location = new System.Drawing.Point(299, 18);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(229, 43);
            this.btnOne.TabIndex = 12;
            this.btnOne.Text = "[10,10] 二微陣列: 邊為1 內為0";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnZero.Location = new System.Drawing.Point(299, 67);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(229, 43);
            this.btnZero.TabIndex = 13;
            this.btnZero.Text = "[10,10] 二微陣列: 邊為0 內為1";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnOneZero
            // 
            this.btnOneZero.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOneZero.Location = new System.Drawing.Point(299, 116);
            this.btnOneZero.Name = "btnOneZero";
            this.btnOneZero.Size = new System.Drawing.Size(229, 43);
            this.btnOneZero.TabIndex = 14;
            this.btnOneZero.Text = "[10,10] 二微陣列: 101010";
            this.btnOneZero.UseVisualStyleBackColor = true;
            this.btnOneZero.Click += new System.EventHandler(this.btnOneZero_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwap.Location = new System.Drawing.Point(299, 165);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(229, 43);
            this.btnSwap.TabIndex = 15;
            this.btnSwap.Text = "Swap[int,int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btbArySum
            // 
            this.btbArySum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btbArySum.Location = new System.Drawing.Point(299, 215);
            this.btbArySum.Name = "btbArySum";
            this.btbArySum.Size = new System.Drawing.Size(229, 43);
            this.btbArySum.TabIndex = 16;
            this.btbArySum.Text = "SUM ( arr0711 )";
            this.btbArySum.UseVisualStyleBackColor = true;
            this.btbArySum.Click += new System.EventHandler(this.btbArySum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMax.Location = new System.Drawing.Point(299, 264);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(229, 43);
            this.btnMax.TabIndex = 17;
            this.btnMax.Text = "MAX( arr0711 )";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMin.Location = new System.Drawing.Point(299, 313);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(229, 43);
            this.btnMin.TabIndex = 18;
            this.btnMin.Text = "Min( arr0711 )";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 622);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btbArySum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnOneZero);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInclude);
            this.Controls.Add(this.btnLongName);
            this.Controls.Add(this.btnStaEvenOdd);
            this.Controls.Add(this.btnMinMax);
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
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnStaEvenOdd;
        private System.Windows.Forms.Button btnInclude;
        private System.Windows.Forms.Button btnLongName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnOneZero;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btbArySum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
    }
}

