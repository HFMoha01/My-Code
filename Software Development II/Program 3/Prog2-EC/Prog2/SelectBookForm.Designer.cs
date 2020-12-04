namespace LibraryItems
{
    partial class SelectBookForm
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
            this.bookLbl = new System.Windows.Forms.Label();
            this.bookCbo = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.errorProviderEditBook = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditBook)).BeginInit();
            this.SuspendLayout();
            // 
            // bookLbl
            // 
            this.bookLbl.AutoSize = true;
            this.bookLbl.Location = new System.Drawing.Point(17, 26);
            this.bookLbl.Name = "bookLbl";
            this.bookLbl.Size = new System.Drawing.Size(68, 13);
            this.bookLbl.TabIndex = 1;
            this.bookLbl.Text = "Select Book:";
            // 
            // bookCbo
            // 
            this.bookCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookCbo.FormattingEnabled = true;
            this.bookCbo.Location = new System.Drawing.Point(23, 47);
            this.bookCbo.Name = "bookCbo";
            this.bookCbo.Size = new System.Drawing.Size(230, 21);
            this.bookCbo.TabIndex = 17;
            this.bookCbo.Validating += new System.ComponentModel.CancelEventHandler(this.bookCbo_Validating);
            this.bookCbo.Validated += new System.EventHandler(this.bookCbo_Validated);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(135, 93);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CancelBttn_Mouse_Down_Event);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(43, 93);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 18;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // errorProviderEditBook
            // 
            this.errorProviderEditBook.ContainerControl = this;
            // 
            // SelectBookForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.bookCbo);
            this.Controls.Add(this.bookLbl);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SelectBookForm";
            this.Text = "Select Book ";
            this.Load += new System.EventHandler(this.SelectBookFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookLbl;
        private System.Windows.Forms.ComboBox bookCbo;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ErrorProvider errorProviderEditBook;
    }
}