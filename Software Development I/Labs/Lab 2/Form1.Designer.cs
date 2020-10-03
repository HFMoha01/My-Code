namespace Lab2
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
            this.priceMealLbl = new System.Windows.Forms.Label();
            this.topLbl = new System.Windows.Forms.Label();
            this.priceTxtBx = new System.Windows.Forms.TextBox();
            this.topTipLbl = new System.Windows.Forms.Label();
            this.midLbl = new System.Windows.Forms.Label();
            this.midTipLbl = new System.Windows.Forms.Label();
            this.btmLbl = new System.Windows.Forms.Label();
            this.btmTipLbl = new System.Windows.Forms.Label();
            this.calcTipBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceMealLbl
            // 
            this.priceMealLbl.AutoSize = true;
            this.priceMealLbl.Location = new System.Drawing.Point(12, 21);
            this.priceMealLbl.Name = "priceMealLbl";
            this.priceMealLbl.Size = new System.Drawing.Size(98, 13);
            this.priceMealLbl.TabIndex = 0;
            this.priceMealLbl.Text = "Enter price of meal:";
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.Location = new System.Drawing.Point(46, 58);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(30, 13);
            this.topLbl.TabIndex = 1;
            this.topLbl.Text = "15 %";
            // 
            // priceTxtBx
            // 
            this.priceTxtBx.Location = new System.Drawing.Point(116, 18);
            this.priceTxtBx.Name = "priceTxtBx";
            this.priceTxtBx.Size = new System.Drawing.Size(100, 20);
            this.priceTxtBx.TabIndex = 2;
            // 
            // topTipLbl
            // 
            this.topTipLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topTipLbl.Location = new System.Drawing.Point(116, 57);
            this.topTipLbl.Name = "topTipLbl";
            this.topTipLbl.Size = new System.Drawing.Size(100, 20);
            this.topTipLbl.TabIndex = 3;
            // 
            // midLbl
            // 
            this.midLbl.AutoSize = true;
            this.midLbl.Location = new System.Drawing.Point(46, 97);
            this.midLbl.Name = "midLbl";
            this.midLbl.Size = new System.Drawing.Size(30, 13);
            this.midLbl.TabIndex = 4;
            this.midLbl.Text = "18 %";
            // 
            // midTipLbl
            // 
            this.midTipLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midTipLbl.Location = new System.Drawing.Point(116, 96);
            this.midTipLbl.Name = "midTipLbl";
            this.midTipLbl.Size = new System.Drawing.Size(100, 20);
            this.midTipLbl.TabIndex = 5;
            // 
            // btmLbl
            // 
            this.btmLbl.AutoSize = true;
            this.btmLbl.Location = new System.Drawing.Point(46, 138);
            this.btmLbl.Name = "btmLbl";
            this.btmLbl.Size = new System.Drawing.Size(30, 13);
            this.btmLbl.TabIndex = 6;
            this.btmLbl.Text = "20 %";
            // 
            // btmTipLbl
            // 
            this.btmTipLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btmTipLbl.Location = new System.Drawing.Point(116, 135);
            this.btmTipLbl.Name = "btmTipLbl";
            this.btmTipLbl.Size = new System.Drawing.Size(100, 20);
            this.btmTipLbl.TabIndex = 7;
            // 
            // calcTipBtn
            // 
            this.calcTipBtn.Location = new System.Drawing.Point(49, 185);
            this.calcTipBtn.Name = "calcTipBtn";
            this.calcTipBtn.Size = new System.Drawing.Size(100, 20);
            this.calcTipBtn.TabIndex = 8;
            this.calcTipBtn.Text = "Calculate Tip";
            this.calcTipBtn.UseVisualStyleBackColor = true;
            this.calcTipBtn.Click += new System.EventHandler(this.CalcTipBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 231);
            this.Controls.Add(this.calcTipBtn);
            this.Controls.Add(this.btmTipLbl);
            this.Controls.Add(this.btmLbl);
            this.Controls.Add(this.midTipLbl);
            this.Controls.Add(this.midLbl);
            this.Controls.Add(this.topTipLbl);
            this.Controls.Add(this.priceTxtBx);
            this.Controls.Add(this.topLbl);
            this.Controls.Add(this.priceMealLbl);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceMealLbl;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.TextBox priceTxtBx;
        private System.Windows.Forms.Label topTipLbl;
        private System.Windows.Forms.Label midLbl;
        private System.Windows.Forms.Label midTipLbl;
        private System.Windows.Forms.Label btmLbl;
        private System.Windows.Forms.Label btmTipLbl;
        private System.Windows.Forms.Button calcTipBtn;
    }
}

