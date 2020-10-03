namespace LibraryItems
{
    partial class BookForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.copyRightLbl = new System.Windows.Forms.Label();
            this.loanPdLbl = new System.Windows.Forms.Label();
            this.callNumLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.titleTxtBx = new System.Windows.Forms.TextBox();
            this.publisherTxtBx = new System.Windows.Forms.TextBox();
            this.cpRgtYrTxt = new System.Windows.Forms.TextBox();
            this.loanPdTxtBx = new System.Windows.Forms.TextBox();
            this.callNumTxtBx = new System.Windows.Forms.TextBox();
            this.authTxtBx = new System.Windows.Forms.TextBox();
            this.okBttn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorTitleProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCpyRghtProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLnPdProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCallNumProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.hintToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorPubProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAuthProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorTitleProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCpyRghtProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLnPdProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCallNumProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPubProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(47, 35);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(33, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title: ";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(37, 69);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(53, 13);
            this.publisherLbl.TabIndex = 1;
            this.publisherLbl.Text = "Publisher:";
            // 
            // copyRightLbl
            // 
            this.copyRightLbl.AutoSize = true;
            this.copyRightLbl.Location = new System.Drawing.Point(24, 105);
            this.copyRightLbl.Name = "copyRightLbl";
            this.copyRightLbl.Size = new System.Drawing.Size(79, 13);
            this.copyRightLbl.TabIndex = 2;
            this.copyRightLbl.Text = "Copyright Year:";
            // 
            // loanPdLbl
            // 
            this.loanPdLbl.AutoSize = true;
            this.loanPdLbl.Location = new System.Drawing.Point(30, 136);
            this.loanPdLbl.Name = "loanPdLbl";
            this.loanPdLbl.Size = new System.Drawing.Size(67, 13);
            this.loanPdLbl.TabIndex = 3;
            this.loanPdLbl.Text = "Loan Period:";
            // 
            // callNumLbl
            // 
            this.callNumLbl.AutoSize = true;
            this.callNumLbl.Location = new System.Drawing.Point(30, 169);
            this.callNumLbl.Name = "callNumLbl";
            this.callNumLbl.Size = new System.Drawing.Size(67, 13);
            this.callNumLbl.TabIndex = 4;
            this.callNumLbl.Text = "Call Number:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(43, 203);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(41, 13);
            this.authorLbl.TabIndex = 5;
            this.authorLbl.Text = "Author:";
            // 
            // titleTxtBx
            // 
            this.titleTxtBx.Location = new System.Drawing.Point(109, 31);
            this.titleTxtBx.Name = "titleTxtBx";
            this.titleTxtBx.Size = new System.Drawing.Size(100, 20);
            this.titleTxtBx.TabIndex = 6;
            this.hintToolTip.SetToolTip(this.titleTxtBx, "Enter Title Here");
            this.titleTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.TitleTxtBx_Validating);
            this.titleTxtBx.Validated += new System.EventHandler(this.TitleTxtBx_Validated);
            // 
            // publisherTxtBx
            // 
            this.publisherTxtBx.Location = new System.Drawing.Point(109, 65);
            this.publisherTxtBx.Name = "publisherTxtBx";
            this.publisherTxtBx.Size = new System.Drawing.Size(100, 20);
            this.publisherTxtBx.TabIndex = 7;
            this.hintToolTip.SetToolTip(this.publisherTxtBx, "Enter Publisher\'s Name Here");
            this.publisherTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.PublisherTxtBxValidating);
            this.publisherTxtBx.Validated += new System.EventHandler(this.PublisherTxtBxValidated);
            // 
            // cpRgtYrTxt
            // 
            this.cpRgtYrTxt.Location = new System.Drawing.Point(109, 101);
            this.cpRgtYrTxt.Name = "cpRgtYrTxt";
            this.cpRgtYrTxt.Size = new System.Drawing.Size(100, 20);
            this.cpRgtYrTxt.TabIndex = 8;
            this.hintToolTip.SetToolTip(this.cpRgtYrTxt, "Enter Copyright Year Here");
            this.cpRgtYrTxt.Validating += new System.ComponentModel.CancelEventHandler(this.CpRgtYrTxtbx_Validating);
            this.cpRgtYrTxt.Validated += new System.EventHandler(this.CpRgtYrTxtbx_Validated);
            // 
            // loanPdTxtBx
            // 
            this.loanPdTxtBx.Location = new System.Drawing.Point(109, 132);
            this.loanPdTxtBx.Name = "loanPdTxtBx";
            this.loanPdTxtBx.Size = new System.Drawing.Size(100, 20);
            this.loanPdTxtBx.TabIndex = 9;
            this.hintToolTip.SetToolTip(this.loanPdTxtBx, "Enter the Loan Period Here");
            this.loanPdTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.LoanPdTxtBx_Validating);
            this.loanPdTxtBx.Validated += new System.EventHandler(this.LoanPdTxtBx_Validated);
            // 
            // callNumTxtBx
            // 
            this.callNumTxtBx.Location = new System.Drawing.Point(109, 165);
            this.callNumTxtBx.Name = "callNumTxtBx";
            this.callNumTxtBx.Size = new System.Drawing.Size(100, 20);
            this.callNumTxtBx.TabIndex = 10;
            this.hintToolTip.SetToolTip(this.callNumTxtBx, "Enter Call Number Here");
            this.callNumTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.callNumberTxt_Validating);
            this.callNumTxtBx.Validated += new System.EventHandler(this.callNumTxtBx_Validated);
            // 
            // authTxtBx
            // 
            this.authTxtBx.Location = new System.Drawing.Point(109, 199);
            this.authTxtBx.Name = "authTxtBx";
            this.authTxtBx.Size = new System.Drawing.Size(100, 20);
            this.authTxtBx.TabIndex = 11;
            this.hintToolTip.SetToolTip(this.authTxtBx, "Enter The Book\'s Author");
            this.authTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.authTxtBx_Validating);
            this.authTxtBx.Validated += new System.EventHandler(this.authTxtBx_Validated);
            // 
            // okBttn
            // 
            this.okBttn.Location = new System.Drawing.Point(24, 270);
            this.okBttn.Name = "okBttn";
            this.okBttn.Size = new System.Drawing.Size(90, 23);
            this.okBttn.TabIndex = 12;
            this.okBttn.Text = "Ok";
            this.okBttn.UseVisualStyleBackColor = true;
            this.okBttn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(154, 270);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorTitleProvider
            // 
            this.errorTitleProvider.ContainerControl = this;
            // 
            // errorCpyRghtProvider
            // 
            this.errorCpyRghtProvider.ContainerControl = this;
            // 
            // errorLnPdProvider
            // 
            this.errorLnPdProvider.ContainerControl = this;
            // 
            // errorCallNumProvider
            // 
            this.errorCallNumProvider.ContainerControl = this;
            // 
            // errorPubProvider
            // 
            this.errorPubProvider.ContainerControl = this;
            // 
            // errorAuthProvider
            // 
            this.errorAuthProvider.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 338);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBttn);
            this.Controls.Add(this.authTxtBx);
            this.Controls.Add(this.callNumTxtBx);
            this.Controls.Add(this.loanPdTxtBx);
            this.Controls.Add(this.cpRgtYrTxt);
            this.Controls.Add(this.publisherTxtBx);
            this.Controls.Add(this.titleTxtBx);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.callNumLbl);
            this.Controls.Add(this.loanPdLbl);
            this.Controls.Add(this.copyRightLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "BookForm";
            this.Text = "New Book";
            ((System.ComponentModel.ISupportInitialize)(this.errorTitleProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCpyRghtProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLnPdProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCallNumProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPubProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label copyRightLbl;
        private System.Windows.Forms.Label loanPdLbl;
        private System.Windows.Forms.Label callNumLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox titleTxtBx;
        private System.Windows.Forms.TextBox publisherTxtBx;
        private System.Windows.Forms.TextBox cpRgtYrTxt;
        private System.Windows.Forms.TextBox loanPdTxtBx;
        private System.Windows.Forms.TextBox callNumTxtBx;
        private System.Windows.Forms.TextBox authTxtBx;
        private System.Windows.Forms.Button okBttn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorTitleProvider;
        private System.Windows.Forms.ErrorProvider errorCpyRghtProvider;
        private System.Windows.Forms.ErrorProvider errorLnPdProvider;
        private System.Windows.Forms.ErrorProvider errorCallNumProvider;
        private System.Windows.Forms.ToolTip hintToolTip;
        private System.Windows.Forms.ErrorProvider errorPubProvider;
        private System.Windows.Forms.ErrorProvider errorAuthProvider;
    }
}