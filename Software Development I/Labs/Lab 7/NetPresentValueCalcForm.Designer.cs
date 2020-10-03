namespace Lab7
{
    partial class NetPresentValueCalcForm
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
            this.futureValLbl = new System.Windows.Forms.Label();
            this.annIntLbl = new System.Windows.Forms.Label();
            this.yearsLbl = new System.Windows.Forms.Label();
            this.presValLbl = new System.Windows.Forms.Label();
            this.futureValueTxtBx = new System.Windows.Forms.TextBox();
            this.annualIntRateTxtbx = new System.Windows.Forms.TextBox();
            this.numOfYearsTxtbx = new System.Windows.Forms.TextBox();
            this.presValueOutptLbl = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futureValLbl
            // 
            this.futureValLbl.AutoSize = true;
            this.futureValLbl.Location = new System.Drawing.Point(28, 31);
            this.futureValLbl.Name = "futureValLbl";
            this.futureValLbl.Size = new System.Drawing.Size(139, 13);
            this.futureValLbl.TabIndex = 0;
            this.futureValLbl.Text = "Future Value:                     $";
            // 
            // annIntLbl
            // 
            this.annIntLbl.AutoSize = true;
            this.annIntLbl.Location = new System.Drawing.Point(28, 77);
            this.annIntLbl.Name = "annIntLbl";
            this.annIntLbl.Size = new System.Drawing.Size(107, 13);
            this.annIntLbl.TabIndex = 1;
            this.annIntLbl.Text = "Annual Interest Rate:";
            // 
            // yearsLbl
            // 
            this.yearsLbl.AutoSize = true;
            this.yearsLbl.Location = new System.Drawing.Point(28, 123);
            this.yearsLbl.Name = "yearsLbl";
            this.yearsLbl.Size = new System.Drawing.Size(89, 13);
            this.yearsLbl.TabIndex = 2;
            this.yearsLbl.Text = "Number of Years:";
            // 
            // presValLbl
            // 
            this.presValLbl.AutoSize = true;
            this.presValLbl.Location = new System.Drawing.Point(28, 169);
            this.presValLbl.Name = "presValLbl";
            this.presValLbl.Size = new System.Drawing.Size(76, 13);
            this.presValLbl.TabIndex = 3;
            this.presValLbl.Text = "Present Value:";
            // 
            // futureValueTxtBx
            // 
            this.futureValueTxtBx.Location = new System.Drawing.Point(168, 28);
            this.futureValueTxtBx.Name = "futureValueTxtBx";
            this.futureValueTxtBx.Size = new System.Drawing.Size(100, 20);
            this.futureValueTxtBx.TabIndex = 4;
            // 
            // annualIntRateTxtbx
            // 
            this.annualIntRateTxtbx.Location = new System.Drawing.Point(168, 74);
            this.annualIntRateTxtbx.Name = "annualIntRateTxtbx";
            this.annualIntRateTxtbx.Size = new System.Drawing.Size(100, 20);
            this.annualIntRateTxtbx.TabIndex = 5;
            // 
            // numOfYearsTxtbx
            // 
            this.numOfYearsTxtbx.Location = new System.Drawing.Point(168, 120);
            this.numOfYearsTxtbx.Name = "numOfYearsTxtbx";
            this.numOfYearsTxtbx.Size = new System.Drawing.Size(100, 20);
            this.numOfYearsTxtbx.TabIndex = 6;
            // 
            // presValueOutptLbl
            // 
            this.presValueOutptLbl.BackColor = System.Drawing.SystemColors.Window;
            this.presValueOutptLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presValueOutptLbl.Location = new System.Drawing.Point(168, 168);
            this.presValueOutptLbl.Name = "presValueOutptLbl";
            this.presValueOutptLbl.Size = new System.Drawing.Size(100, 20);
            this.presValueOutptLbl.TabIndex = 7;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(91, 213);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 8;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // NetPresentValueCalcForm
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 265);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.presValueOutptLbl);
            this.Controls.Add(this.numOfYearsTxtbx);
            this.Controls.Add(this.annualIntRateTxtbx);
            this.Controls.Add(this.futureValueTxtBx);
            this.Controls.Add(this.presValLbl);
            this.Controls.Add(this.yearsLbl);
            this.Controls.Add(this.annIntLbl);
            this.Controls.Add(this.futureValLbl);
            this.Name = "NetPresentValueCalcForm";
            this.Text = "Lab7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureValLbl;
        private System.Windows.Forms.Label annIntLbl;
        private System.Windows.Forms.Label yearsLbl;
        private System.Windows.Forms.Label presValLbl;
        private System.Windows.Forms.TextBox futureValueTxtBx;
        private System.Windows.Forms.TextBox annualIntRateTxtbx;
        private System.Windows.Forms.TextBox numOfYearsTxtbx;
        private System.Windows.Forms.Label presValueOutptLbl;
        private System.Windows.Forms.Button CalcButton;
    }
}

