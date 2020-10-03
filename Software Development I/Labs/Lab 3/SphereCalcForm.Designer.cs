namespace Lab_3
{
    partial class SphereCalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SphereCalcForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radLbl = new System.Windows.Forms.Label();
            this.radTxtBx = new System.Windows.Forms.TextBox();
            this.diaLbl = new System.Windows.Forms.Label();
            this.surfAreaLbl = new System.Windows.Forms.Label();
            this.volLbl = new System.Windows.Forms.Label();
            this.diaOutptLbl = new System.Windows.Forms.Label();
            this.surfAreaOutptLbl = new System.Windows.Forms.Label();
            this.volOutptLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // radLbl
            // 
            this.radLbl.AutoSize = true;
            this.radLbl.Location = new System.Drawing.Point(169, 32);
            this.radLbl.Name = "radLbl";
            this.radLbl.Size = new System.Drawing.Size(99, 13);
            this.radLbl.TabIndex = 3;
            this.radLbl.Text = "Radius of a sphere:";
            // 
            // radTxtBx
            // 
            this.radTxtBx.Location = new System.Drawing.Point(272, 29);
            this.radTxtBx.Name = "radTxtBx";
            this.radTxtBx.Size = new System.Drawing.Size(100, 20);
            this.radTxtBx.TabIndex = 4;
            // 
            // diaLbl
            // 
            this.diaLbl.AutoSize = true;
            this.diaLbl.Location = new System.Drawing.Point(13, 199);
            this.diaLbl.Name = "diaLbl";
            this.diaLbl.Size = new System.Drawing.Size(49, 13);
            this.diaLbl.TabIndex = 5;
            this.diaLbl.Text = "Diameter";
            // 
            // surfAreaLbl
            // 
            this.surfAreaLbl.AutoSize = true;
            this.surfAreaLbl.Location = new System.Drawing.Point(13, 249);
            this.surfAreaLbl.Name = "surfAreaLbl";
            this.surfAreaLbl.Size = new System.Drawing.Size(69, 13);
            this.surfAreaLbl.TabIndex = 6;
            this.surfAreaLbl.Text = "Surface Area";
            // 
            // volLbl
            // 
            this.volLbl.AutoSize = true;
            this.volLbl.Location = new System.Drawing.Point(13, 299);
            this.volLbl.Name = "volLbl";
            this.volLbl.Size = new System.Drawing.Size(42, 13);
            this.volLbl.TabIndex = 7;
            this.volLbl.Text = "Volume";
            // 
            // diaOutptLbl
            // 
            this.diaOutptLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diaOutptLbl.Location = new System.Drawing.Point(88, 198);
            this.diaOutptLbl.Name = "diaOutptLbl";
            this.diaOutptLbl.Size = new System.Drawing.Size(100, 20);
            this.diaOutptLbl.TabIndex = 8;
            // 
            // surfAreaOutptLbl
            // 
            this.surfAreaOutptLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfAreaOutptLbl.Location = new System.Drawing.Point(88, 248);
            this.surfAreaOutptLbl.Name = "surfAreaOutptLbl";
            this.surfAreaOutptLbl.Size = new System.Drawing.Size(100, 20);
            this.surfAreaOutptLbl.TabIndex = 10;
            // 
            // volOutptLbl
            // 
            this.volOutptLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volOutptLbl.Location = new System.Drawing.Point(88, 298);
            this.volOutptLbl.Name = "volOutptLbl";
            this.volOutptLbl.Size = new System.Drawing.Size(100, 20);
            this.volOutptLbl.TabIndex = 12;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(281, 65);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 13;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // SphereCalcForm
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.volOutptLbl);
            this.Controls.Add(this.surfAreaOutptLbl);
            this.Controls.Add(this.diaOutptLbl);
            this.Controls.Add(this.volLbl);
            this.Controls.Add(this.surfAreaLbl);
            this.Controls.Add(this.diaLbl);
            this.Controls.Add(this.radTxtBx);
            this.Controls.Add(this.radLbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SphereCalcForm";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label radLbl;
        private System.Windows.Forms.TextBox radTxtBx;
        private System.Windows.Forms.Label diaLbl;
        private System.Windows.Forms.Label surfAreaLbl;
        private System.Windows.Forms.Label volLbl;
        private System.Windows.Forms.Label diaOutptLbl;
        private System.Windows.Forms.Label surfAreaOutptLbl;
        private System.Windows.Forms.Label volOutptLbl;
        private System.Windows.Forms.Button calcBtn;
    }
}

