namespace Program_2
{
    partial class ClassRegistrationForm
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
            this.initialLbl = new System.Windows.Forms.Label();
            this.credHrsLbl = new System.Windows.Forms.Label();
            this.initialTxtBx = new System.Windows.Forms.TextBox();
            this.Calcbttn = new System.Windows.Forms.Button();
            this.credHrsTxtBx = new System.Windows.Forms.TextBox();
            this.regLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // initialLbl
            // 
            this.initialLbl.AutoSize = true;
            this.initialLbl.Location = new System.Drawing.Point(10, 32);
            this.initialLbl.Name = "initialLbl";
            this.initialLbl.Size = new System.Drawing.Size(208, 13);
            this.initialLbl.TabIndex = 0;
            this.initialLbl.Text = "Enter the first initial of your last name here :";
            // 
            // credHrsLbl
            // 
            this.credHrsLbl.AutoSize = true;
            this.credHrsLbl.Location = new System.Drawing.Point(75, 100);
            this.credHrsLbl.Name = "credHrsLbl";
            this.credHrsLbl.Size = new System.Drawing.Size(143, 13);
            this.credHrsLbl.TabIndex = 1;
            this.credHrsLbl.Text = "Enter your credit hours here :";
            // 
            // initialTxtBx
            // 
            this.initialTxtBx.Location = new System.Drawing.Point(226, 29);
            this.initialTxtBx.Name = "initialTxtBx";
            this.initialTxtBx.Size = new System.Drawing.Size(100, 20);
            this.initialTxtBx.TabIndex = 2;
            // 
            // Calcbttn
            // 
            this.Calcbttn.Location = new System.Drawing.Point(143, 236);
            this.Calcbttn.Name = "Calcbttn";
            this.Calcbttn.Size = new System.Drawing.Size(75, 23);
            this.Calcbttn.TabIndex = 3;
            this.Calcbttn.Text = "Enter ";
            this.Calcbttn.UseVisualStyleBackColor = true;
            this.Calcbttn.Click += new System.EventHandler(this.Calcbttn_Click);
            // 
            // credHrsTxtBx
            // 
            this.credHrsTxtBx.Location = new System.Drawing.Point(226, 97);
            this.credHrsTxtBx.Name = "credHrsTxtBx";
            this.credHrsTxtBx.Size = new System.Drawing.Size(100, 20);
            this.credHrsTxtBx.TabIndex = 4;
            // 
            // regLbl
            // 
            this.regLbl.AutoSize = true;
            this.regLbl.Location = new System.Drawing.Point(50, 175);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(168, 13);
            this.regLbl.TabIndex = 5;
            this.regLbl.Text = "Your registeration window begins ;";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.BackColor = System.Drawing.SystemColors.Window;
            this.dateLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLbl.Location = new System.Drawing.Point(226, 175);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(32, 15);
            this.dateLbl.TabIndex = 6;
            this.dateLbl.Text = "Date";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.SystemColors.Window;
            this.timeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLbl.Location = new System.Drawing.Point(276, 175);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(32, 15);
            this.timeLbl.TabIndex = 7;
            this.timeLbl.Text = "Time";
            // 
            // ClassRegistrationForm
            // 
            this.AcceptButton = this.Calcbttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 288);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.regLbl);
            this.Controls.Add(this.credHrsTxtBx);
            this.Controls.Add(this.Calcbttn);
            this.Controls.Add(this.initialTxtBx);
            this.Controls.Add(this.credHrsLbl);
            this.Controls.Add(this.initialLbl);
            this.Name = "ClassRegistrationForm";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initialLbl;
        private System.Windows.Forms.Label credHrsLbl;
        private System.Windows.Forms.TextBox initialTxtBx;
        private System.Windows.Forms.Button Calcbttn;
        private System.Windows.Forms.TextBox credHrsTxtBx;
        private System.Windows.Forms.Label regLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label timeLbl;
    }
}

