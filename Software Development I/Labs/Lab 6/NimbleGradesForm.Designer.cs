namespace Lab_6
{
    partial class NimbleGradesForm
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
            this.wpmLbl = new System.Windows.Forms.Label();
            this.wpmTxtBx = new System.Windows.Forms.TextBox();
            this.gradeLbl = new System.Windows.Forms.Label();
            this.gradeOutptLbl = new System.Windows.Forms.Label();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wpmLbl
            // 
            this.wpmLbl.AutoSize = true;
            this.wpmLbl.Location = new System.Drawing.Point(12, 42);
            this.wpmLbl.Name = "wpmLbl";
            this.wpmLbl.Size = new System.Drawing.Size(244, 13);
            this.wpmLbl.TabIndex = 0;
            this.wpmLbl.Text = "Please enter students words per minute (numeric) :";
            // 
            // wpmTxtBx
            // 
            this.wpmTxtBx.Location = new System.Drawing.Point(262, 39);
            this.wpmTxtBx.Name = "wpmTxtBx";
            this.wpmTxtBx.Size = new System.Drawing.Size(100, 20);
            this.wpmTxtBx.TabIndex = 1;
            // 
            // gradeLbl
            // 
            this.gradeLbl.AutoSize = true;
            this.gradeLbl.Location = new System.Drawing.Point(139, 109);
            this.gradeLbl.Name = "gradeLbl";
            this.gradeLbl.Size = new System.Drawing.Size(117, 13);
            this.gradeLbl.TabIndex = 2;
            this.gradeLbl.Text = "The student\'s grade is :";
            // 
            // gradeOutptLbl
            // 
            this.gradeOutptLbl.BackColor = System.Drawing.SystemColors.Window;
            this.gradeOutptLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeOutptLbl.ForeColor = System.Drawing.Color.Black;
            this.gradeOutptLbl.Location = new System.Drawing.Point(262, 108);
            this.gradeOutptLbl.Name = "gradeOutptLbl";
            this.gradeOutptLbl.Size = new System.Drawing.Size(100, 20);
            this.gradeOutptLbl.TabIndex = 3;
            this.gradeOutptLbl.Text = "( Grade)";
            this.gradeOutptLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(181, 168);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterBtn.TabIndex = 4;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // NimbleGradesForm
            // 
            this.AcceptButton = this.EnterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 328);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.gradeOutptLbl);
            this.Controls.Add(this.gradeLbl);
            this.Controls.Add(this.wpmTxtBx);
            this.Controls.Add(this.wpmLbl);
            this.Name = "NimbleGradesForm";
            this.Text = "Lab 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wpmLbl;
        private System.Windows.Forms.TextBox wpmTxtBx;
        private System.Windows.Forms.Label gradeLbl;
        private System.Windows.Forms.Label gradeOutptLbl;
        private System.Windows.Forms.Button EnterBtn;
    }
}

