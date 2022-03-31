
namespace HomePage
{
    partial class frmHOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOP));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnPainter = new System.Windows.Forms.Button();
            this.btnNotePad = new System.Windows.Forms.Button();
            this.btnScreenSaver = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnXO = new System.Windows.Forms.Button();
            this.btnDO = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnSGL = new System.Windows.Forms.Button();
            this.btnSG = new System.Windows.Forms.Button();
            this.btnSSF = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1484, 861);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1484, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1263, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# 作業";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.btnAlarm);
            this.splitContainer2.Panel1.Controls.Add(this.btnPainter);
            this.splitContainer2.Panel1.Controls.Add(this.btnNotePad);
            this.splitContainer2.Panel1.Controls.Add(this.btnScreenSaver);
            this.splitContainer2.Panel1.Controls.Add(this.btnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.btnXO);
            this.splitContainer2.Panel1.Controls.Add(this.btnDO);
            this.splitContainer2.Panel1.Controls.Add(this.btnCalc);
            this.splitContainer2.Panel1.Controls.Add(this.btnMethod);
            this.splitContainer2.Panel1.Controls.Add(this.btnSGL);
            this.splitContainer2.Panel1.Controls.Add(this.btnSG);
            this.splitContainer2.Panel1.Controls.Add(this.btnSSF);
            this.splitContainer2.Panel1.Controls.Add(this.btnPOS);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoan);
            this.splitContainer2.Panel1.Controls.Add(this.btnHello);
            this.splitContainer2.Panel1.Resize += new System.EventHandler(this.splitContainer2_Panel1_Resize);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Size = new System.Drawing.Size(1484, 647);
            this.splitContainer2.SplitterDistance = 373;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnAlarm
            // 
            this.btnAlarm.AutoSize = true;
            this.btnAlarm.Location = new System.Drawing.Point(14, 389);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(345, 23);
            this.btnAlarm.TabIndex = 13;
            this.btnAlarm.Text = "Alarm";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnPainter
            // 
            this.btnPainter.AutoSize = true;
            this.btnPainter.Location = new System.Drawing.Point(13, 360);
            this.btnPainter.Name = "btnPainter";
            this.btnPainter.Size = new System.Drawing.Size(345, 23);
            this.btnPainter.TabIndex = 12;
            this.btnPainter.Text = "小畫家";
            this.btnPainter.UseVisualStyleBackColor = true;
            this.btnPainter.Click += new System.EventHandler(this.btnPainter_Click);
            // 
            // btnNotePad
            // 
            this.btnNotePad.AutoSize = true;
            this.btnNotePad.Location = new System.Drawing.Point(14, 331);
            this.btnNotePad.Name = "btnNotePad";
            this.btnNotePad.Size = new System.Drawing.Size(345, 23);
            this.btnNotePad.TabIndex = 11;
            this.btnNotePad.Text = "NotePad";
            this.btnNotePad.UseVisualStyleBackColor = true;
            this.btnNotePad.Click += new System.EventHandler(this.btnNotePad_Click);
            // 
            // btnScreenSaver
            // 
            this.btnScreenSaver.AutoSize = true;
            this.btnScreenSaver.Location = new System.Drawing.Point(13, 302);
            this.btnScreenSaver.Name = "btnScreenSaver";
            this.btnScreenSaver.Size = new System.Drawing.Size(345, 23);
            this.btnScreenSaver.TabIndex = 10;
            this.btnScreenSaver.Text = "Screen Saver";
            this.btnScreenSaver.UseVisualStyleBackColor = true;
            this.btnScreenSaver.Click += new System.EventHandler(this.btnScreenSaver_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.AutoSize = true;
            this.btnGuess.Location = new System.Drawing.Point(13, 418);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(345, 23);
            this.btnGuess.TabIndex = 9;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnXO
            // 
            this.btnXO.AutoSize = true;
            this.btnXO.Location = new System.Drawing.Point(13, 273);
            this.btnXO.Name = "btnXO";
            this.btnXO.Size = new System.Drawing.Size(345, 23);
            this.btnXO.TabIndex = 8;
            this.btnXO.Text = "0716_XOGame";
            this.btnXO.UseVisualStyleBackColor = true;
            this.btnXO.Click += new System.EventHandler(this.btnXO_Click);
            // 
            // btnDO
            // 
            this.btnDO.AutoSize = true;
            this.btnDO.Location = new System.Drawing.Point(13, 244);
            this.btnDO.Name = "btnDO";
            this.btnDO.Size = new System.Drawing.Size(345, 23);
            this.btnDO.TabIndex = 7;
            this.btnDO.Text = "0712_ForDoWhile";
            this.btnDO.UseVisualStyleBackColor = true;
            this.btnDO.Click += new System.EventHandler(this.btnDO_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.AutoSize = true;
            this.btnCalc.Location = new System.Drawing.Point(13, 215);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(345, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "0711_MyClac";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.AutoSize = true;
            this.btnMethod.Location = new System.Drawing.Point(13, 186);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(345, 23);
            this.btnMethod.TabIndex = 6;
            this.btnMethod.Text = "0711_Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnSGL
            // 
            this.btnSGL.AutoSize = true;
            this.btnSGL.Location = new System.Drawing.Point(13, 157);
            this.btnSGL.Name = "btnSGL";
            this.btnSGL.Size = new System.Drawing.Size(345, 23);
            this.btnSGL.TabIndex = 5;
            this.btnSGL.Text = "0710_StudentGrade_List";
            this.btnSGL.UseVisualStyleBackColor = true;
            this.btnSGL.Click += new System.EventHandler(this.btnSGL_Click);
            // 
            // btnSG
            // 
            this.btnSG.AutoSize = true;
            this.btnSG.Location = new System.Drawing.Point(13, 128);
            this.btnSG.Name = "btnSG";
            this.btnSG.Size = new System.Drawing.Size(345, 23);
            this.btnSG.TabIndex = 4;
            this.btnSG.Text = "0709_StudentGrade";
            this.btnSG.UseVisualStyleBackColor = true;
            this.btnSG.Click += new System.EventHandler(this.btnSG_Click);
            // 
            // btnSSF
            // 
            this.btnSSF.AutoSize = true;
            this.btnSSF.Location = new System.Drawing.Point(12, 99);
            this.btnSSF.Name = "btnSSF";
            this.btnSSF.Size = new System.Drawing.Size(345, 23);
            this.btnSSF.TabIndex = 3;
            this.btnSSF.Text = "0708_Student_StructForm";
            this.btnSSF.UseVisualStyleBackColor = true;
            this.btnSSF.Click += new System.EventHandler(this.btnSSF_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.AutoSize = true;
            this.btnPOS.Location = new System.Drawing.Point(13, 70);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(345, 23);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "0705_POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.AutoSize = true;
            this.btnLoan.Location = new System.Drawing.Point(12, 41);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(345, 23);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "0704_Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnHello
            // 
            this.btnHello.AutoSize = true;
            this.btnHello.Location = new System.Drawing.Point(12, 12);
            this.btnHello.Margin = new System.Windows.Forms.Padding(0);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(345, 23);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "0703_Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // frmHOP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHOP";
            this.Text = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.frmHOP_AutoSizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnNotePad;
        private System.Windows.Forms.Button btnScreenSaver;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnXO;
        private System.Windows.Forms.Button btnDO;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnSGL;
        private System.Windows.Forms.Button btnSG;
        private System.Windows.Forms.Button btnSSF;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnPainter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

