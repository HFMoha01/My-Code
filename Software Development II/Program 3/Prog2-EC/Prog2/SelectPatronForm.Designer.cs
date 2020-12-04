namespace LibraryItems
{
    partial class SelectPatronForm
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
            this.components = new System.ComponentModel.Container();
            this.patronLbl = new System.Windows.Forms.Label();
            this.patrCbo = new System.Windows.Forms.ComboBox();
            this.subBttn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProviderPatron = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatron)).BeginInit();
            this.SuspendLayout();
            // 
            // patronLbl
            // 
            this.patronLbl.AutoSize = true;
            this.patronLbl.Location = new System.Drawing.Point(66, 28);
            this.patronLbl.Name = "patronLbl";
            this.patronLbl.Size = new System.Drawing.Size(74, 13);
            this.patronLbl.TabIndex = 0;
            this.patronLbl.Text = "Select Patron:";
            // 
            // patrCbo
            // 
            this.patrCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patrCbo.FormattingEnabled = true;
            this.patrCbo.Location = new System.Drawing.Point(43, 53);
            this.patrCbo.Name = "patrCbo";
            this.patrCbo.Size = new System.Drawing.Size(121, 21);
            this.patrCbo.TabIndex = 1;
            this.patrCbo.Validating += new System.ComponentModel.CancelEventHandler(this.PatrCbo_Validating_Event);
            this.patrCbo.Validated += new System.EventHandler(this.PatrCbo_Validated_Event);
            // 
            // subBttn
            // 
            this.subBttn.Location = new System.Drawing.Point(12, 119);
            this.subBttn.Name = "subBttn";
            this.subBttn.Size = new System.Drawing.Size(75, 23);
            this.subBttn.TabIndex = 2;
            this.subBttn.Text = "Submit";
            this.subBttn.UseVisualStyleBackColor = true;
            this.subBttn.Click += new System.EventHandler(this.subBttn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(110, 119);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorProviderPatron
            // 
            this.errorProviderPatron.ContainerControl = this;
            // 
            // SelectPatron
            // 
            this.AcceptButton = this.subBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 154);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.subBttn);
            this.Controls.Add(this.patrCbo);
            this.Controls.Add(this.patronLbl);
            this.Name = "SelectPatron";
            this.Text = "Select Patron";
            this.Load += new System.EventHandler(this.SelectPatron_LoadEvent);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatron)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patronLbl;
        private System.Windows.Forms.ComboBox patrCbo;
        private System.Windows.Forms.Button subBttn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProviderPatron;
    }
}