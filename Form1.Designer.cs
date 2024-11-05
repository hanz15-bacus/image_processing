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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(41, 104);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(319, 247);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxProcessed
            // 
            this.pictureBoxProcessed.Location = new System.Drawing.Point(383, 104);
            this.pictureBoxProcessed.Name = "pictureBoxProcessed";
            this.pictureBoxProcessed.Size = new System.Drawing.Size(340, 247);
            this.pictureBoxProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProcessed.TabIndex = 1;
            this.pictureBoxProcessed.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(749, 58);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(343, 293);
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
            this.copybtn.Location = new System.Drawing.Point(180, 12);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(75, 23);
            this.copybtn.TabIndex = 4;
            this.copybtn.Text = "copy";
            this.copybtn.UseVisualStyleBackColor = true;
            this.copybtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // invertcolorsbtn
            // 
            this.invertcolorsbtn.Location = new System.Drawing.Point(465, 12);
            this.invertcolorsbtn.Name = "invertcolorsbtn";
            this.invertcolorsbtn.Size = new System.Drawing.Size(151, 23);
            this.invertcolorsbtn.TabIndex = 5;
            this.invertcolorsbtn.Text = "Invert Colors";
            this.invertcolorsbtn.UseVisualStyleBackColor = true;
            this.invertcolorsbtn.Click += new System.EventHandler(this.invertcolorsbtn_Click);
            // 
            // sepiabtn
            // 
            this.sepiabtn.Location = new System.Drawing.Point(662, 12);
            this.sepiabtn.Name = "sepiabtn";
            this.sepiabtn.Size = new System.Drawing.Size(75, 23);
            this.sepiabtn.TabIndex = 6;
            this.sepiabtn.Text = "Sepia ";
            this.sepiabtn.UseVisualStyleBackColor = true;
            this.sepiabtn.Click += new System.EventHandler(this.sepiabtn_Click);
            // 
            // subtractimagesbtn
            // 
            this.subtractimagesbtn.Location = new System.Drawing.Point(180, 58);
            this.subtractimagesbtn.Name = "subtractimagesbtn";
            this.subtractimagesbtn.Size = new System.Drawing.Size(75, 23);
            this.subtractimagesbtn.TabIndex = 7;
            this.subtractimagesbtn.Text = "Subtract Images";
            this.subtractimagesbtn.UseVisualStyleBackColor = true;
            this.subtractimagesbtn.Click += new System.EventHandler(this.subtractimagesbtn_Click);
            // 
            // grayscalebtn
            // 
            this.grayscalebtn.Location = new System.Drawing.Point(255, 12);
            this.grayscalebtn.Name = "grayscalebtn";
            this.grayscalebtn.Size = new System.Drawing.Size(166, 23);
            this.grayscalebtn.TabIndex = 8;
            this.grayscalebtn.Text = "gray scale";
            this.grayscalebtn.UseVisualStyleBackColor = true;
            this.grayscalebtn.Click += new System.EventHandler(this.grayscalebtn_Click_1);
            // 
            // histogrambtn
            // 
            this.histogrambtn.Location = new System.Drawing.Point(12, 58);
            this.histogrambtn.Name = "histogrambtn";
            this.histogrambtn.Size = new System.Drawing.Size(150, 23);
            this.histogrambtn.TabIndex = 9;
            this.histogrambtn.Text = "Histogram ";
            this.histogrambtn.UseVisualStyleBackColor = true;
            this.histogrambtn.Click += new System.EventHandler(this.histogrambtn_Click);
            // 
            // saveimagebtn
            // 
            this.saveimagebtn.Location = new System.Drawing.Point(308, 58);
            this.saveimagebtn.Name = "saveimagebtn";
            this.saveimagebtn.Size = new System.Drawing.Size(75, 23);
            this.saveimagebtn.TabIndex = 10;
            this.saveimagebtn.Text = "Save Image";
            this.saveimagebtn.UseVisualStyleBackColor = true;
            this.saveimagebtn.Click += new System.EventHandler(this.saveimagebtn_Click);
            // 
            // cameratoggle
            // 
            this.cameratoggle.Location = new System.Drawing.Point(821, 11);
            this.cameratoggle.Name = "cameratoggle";
            this.cameratoggle.Size = new System.Drawing.Size(75, 23);
            this.cameratoggle.TabIndex = 11;
            this.cameratoggle.Text = "turn on camera";
            this.cameratoggle.UseVisualStyleBackColor = true;
            this.cameratoggle.Click += new System.EventHandler(this.cameratoggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);

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
    }
}
