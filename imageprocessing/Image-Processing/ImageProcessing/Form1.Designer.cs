namespace ImageProcessing
{
    partial class Form1
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxProcessed = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.loadimagebtn = new System.Windows.Forms.Button();
            this.copybtn = new System.Windows.Forms.Button();
            this.invertcolorsbtn = new System.Windows.Forms.Button();
            this.sepiabtn = new System.Windows.Forms.Button();
            this.subtractimagesbtn = new System.Windows.Forms.Button();
            this.grayscalebtn = new System.Windows.Forms.Button();
            this.histogrambtn = new System.Windows.Forms.Button();
            this.saveimagebtn = new System.Windows.Forms.Button();
            this.cameratoggle = new System.Windows.Forms.Button();
            this.CountCoinsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countlabel = new System.Windows.Forms.Label();
            this.valuelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(20, 370);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(319, 247);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxProcessed
            // 
            this.pictureBoxProcessed.Location = new System.Drawing.Point(370, 370);
            this.pictureBoxProcessed.Name = "pictureBoxProcessed";
            this.pictureBoxProcessed.Size = new System.Drawing.Size(340, 247);
            this.pictureBoxProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProcessed.TabIndex = 1;
            this.pictureBoxProcessed.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(735, 370);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(343, 247);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 2;
            this.pictureBoxResult.TabStop = false;
            // 
            // loadimagebtn
            // 
            this.loadimagebtn.Location = new System.Drawing.Point(12, 12);
            this.loadimagebtn.Name = "loadimagebtn";
            this.loadimagebtn.Size = new System.Drawing.Size(109, 23);
            this.loadimagebtn.TabIndex = 3;
            this.loadimagebtn.Text = "Load Image";
            this.loadimagebtn.UseVisualStyleBackColor = true;
            this.loadimagebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // copybtn
            // 
            this.copybtn.Location = new System.Drawing.Point(197, 12);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(75, 23);
            this.copybtn.TabIndex = 4;
            this.copybtn.Text = "copy";
            this.copybtn.UseVisualStyleBackColor = true;
            this.copybtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // invertcolorsbtn
            // 
            this.invertcolorsbtn.Location = new System.Drawing.Point(178, 70);
            this.invertcolorsbtn.Name = "invertcolorsbtn";
            this.invertcolorsbtn.Size = new System.Drawing.Size(151, 23);
            this.invertcolorsbtn.TabIndex = 5;
            this.invertcolorsbtn.Text = "Invert Colors";
            this.invertcolorsbtn.UseVisualStyleBackColor = true;
            this.invertcolorsbtn.Click += new System.EventHandler(this.invertcolorsbtn_Click);
            // 
            // sepiabtn
            // 
            this.sepiabtn.Location = new System.Drawing.Point(335, 41);
            this.sepiabtn.Name = "sepiabtn";
            this.sepiabtn.Size = new System.Drawing.Size(75, 23);
            this.sepiabtn.TabIndex = 6;
            this.sepiabtn.Text = "Sepia ";
            this.sepiabtn.UseVisualStyleBackColor = true;
            this.sepiabtn.Click += new System.EventHandler(this.sepiabtn_Click);
            // 
            // subtractimagesbtn
            // 
            this.subtractimagesbtn.Location = new System.Drawing.Point(116, 12);
            this.subtractimagesbtn.Name = "subtractimagesbtn";
            this.subtractimagesbtn.Size = new System.Drawing.Size(75, 23);
            this.subtractimagesbtn.TabIndex = 7;
            this.subtractimagesbtn.Text = "Subtract Images";
            this.subtractimagesbtn.UseVisualStyleBackColor = true;
            this.subtractimagesbtn.Click += new System.EventHandler(this.subtractimagesbtn_Click);
            // 
            // grayscalebtn
            // 
            this.grayscalebtn.Location = new System.Drawing.Point(293, 12);
            this.grayscalebtn.Name = "grayscalebtn";
            this.grayscalebtn.Size = new System.Drawing.Size(166, 23);
            this.grayscalebtn.TabIndex = 8;
            this.grayscalebtn.Text = "gray scale";
            this.grayscalebtn.UseVisualStyleBackColor = true;
            this.grayscalebtn.Click += new System.EventHandler(this.grayscalebtn_Click_1);
            // 
            // histogrambtn
            // 
            this.histogrambtn.Location = new System.Drawing.Point(-2, 41);
            this.histogrambtn.Name = "histogrambtn";
            this.histogrambtn.Size = new System.Drawing.Size(150, 23);
            this.histogrambtn.TabIndex = 9;
            this.histogrambtn.Text = "Histogram ";
            this.histogrambtn.UseVisualStyleBackColor = true;
            this.histogrambtn.Click += new System.EventHandler(this.histogrambtn_Click);
            // 
            // saveimagebtn
            // 
            this.saveimagebtn.Location = new System.Drawing.Point(12, 70);
            this.saveimagebtn.Name = "saveimagebtn";
            this.saveimagebtn.Size = new System.Drawing.Size(75, 23);
            this.saveimagebtn.TabIndex = 10;
            this.saveimagebtn.Text = "Save Image";
            this.saveimagebtn.UseVisualStyleBackColor = true;
            this.saveimagebtn.Click += new System.EventHandler(this.saveimagebtn_Click);
            // 
            // cameratoggle
            // 
            this.cameratoggle.Location = new System.Drawing.Point(335, 70);
            this.cameratoggle.Name = "cameratoggle";
            this.cameratoggle.Size = new System.Drawing.Size(75, 23);
            this.cameratoggle.TabIndex = 11;
            this.cameratoggle.Text = "turn on camera";
            this.cameratoggle.UseVisualStyleBackColor = true;
            this.cameratoggle.Click += new System.EventHandler(this.cameratoggle_Click);
            // 
            // CountCoinsBtn
            // 
            this.CountCoinsBtn.Location = new System.Drawing.Point(163, 41);
            this.CountCoinsBtn.Name = "CountCoinsBtn";
            this.CountCoinsBtn.Size = new System.Drawing.Size(166, 23);
            this.CountCoinsBtn.TabIndex = 12;
            this.CountCoinsBtn.Text = "Count Coins";
            this.CountCoinsBtn.UseVisualStyleBackColor = true;
            this.CountCoinsBtn.Click += new System.EventHandler(this.CountCoinsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Value";
            // 
            // countlabel
            // 
            this.countlabel.AutoSize = true;
            this.countlabel.Location = new System.Drawing.Point(127, 652);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(14, 16);
            this.countlabel.TabIndex = 14;
            this.countlabel.Text = "0";
            // 
            // valuelabel
            // 
            this.valuelabel.AutoSize = true;
            this.valuelabel.Location = new System.Drawing.Point(452, 652);
            this.valuelabel.Name = "valuelabel";
            this.valuelabel.Size = new System.Drawing.Size(14, 16);
            this.valuelabel.TabIndex = 15;
            this.valuelabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Count";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "EmbossLaplacian";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(574, 28);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(296, 56);
            this.trackBar1.TabIndex = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(574, 90);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(296, 56);
            this.trackBar2.TabIndex = 21;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(574, 152);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(296, 56);
            this.trackBar3.TabIndex = 22;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(574, 214);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(296, 56);
            this.trackBar4.TabIndex = 23;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Smooth";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "GaussianBlur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "MeanRemoval";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sharpen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 726);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valuelabel);
            this.Controls.Add(this.countlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountCoinsBtn);
            this.Controls.Add(this.cameratoggle);
            this.Controls.Add(this.saveimagebtn);
            this.Controls.Add(this.histogrambtn);
            this.Controls.Add(this.grayscalebtn);
            this.Controls.Add(this.subtractimagesbtn);
            this.Controls.Add(this.sepiabtn);
            this.Controls.Add(this.invertcolorsbtn);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.loadimagebtn);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxProcessed);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxProcessed;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button loadimagebtn;
        private System.Windows.Forms.Button copybtn;
        private System.Windows.Forms.Button invertcolorsbtn;
        private System.Windows.Forms.Button sepiabtn;
        private System.Windows.Forms.Button subtractimagesbtn;
        private System.Windows.Forms.Button grayscalebtn;
        private System.Windows.Forms.Button histogrambtn;
        private System.Windows.Forms.Button saveimagebtn;
        private System.Windows.Forms.Button cameratoggle;
        private System.Windows.Forms.Button CountCoinsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countlabel;
        private System.Windows.Forms.Label valuelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

