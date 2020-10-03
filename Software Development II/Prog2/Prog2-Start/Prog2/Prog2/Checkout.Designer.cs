namespace LibraryItems
{
    partial class CheckoutForm
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
            this.itemComboBx = new System.Windows.Forms.ComboBox();
            this.itemchklbl = new System.Windows.Forms.Label();
            this.patronLbl = new System.Windows.Forms.Label();
            this.patrnComboBx = new System.Windows.Forms.ComboBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProviderItem = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPatron = new System.Windows.Forms.ErrorProvider(this.components);
            this.hintToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatron)).BeginInit();
            this.SuspendLayout();
            // 
            // itemComboBx
            // 
            this.itemComboBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemComboBx.FormattingEnabled = true;
            this.itemComboBx.Location = new System.Drawing.Point(75, 22);
            this.itemComboBx.MaxDropDownItems = 15;
            this.itemComboBx.Name = "itemComboBx";
            this.itemComboBx.Size = new System.Drawing.Size(148, 21);
            this.itemComboBx.TabIndex = 0;
            this.itemComboBx.Text = "        Select Item";
            this.hintToolTip.SetToolTip(this.itemComboBx, "Select  a Library Item Here");
            this.itemComboBx.Validating += new System.ComponentModel.CancelEventHandler(this.itemComboBx_Validating);
            this.itemComboBx.Validated += new System.EventHandler(this.itemComboBx_Validated);
            // 
            // itemchklbl
            // 
            this.itemchklbl.AutoSize = true;
            this.itemchklbl.Location = new System.Drawing.Point(25, 25);
            this.itemchklbl.Name = "itemchklbl";
            this.itemchklbl.Size = new System.Drawing.Size(30, 13);
            this.itemchklbl.TabIndex = 1;
            this.itemchklbl.Text = "Item:";
            // 
            // patronLbl
            // 
            this.patronLbl.AutoSize = true;
            this.patronLbl.Location = new System.Drawing.Point(18, 63);
            this.patronLbl.Name = "patronLbl";
            this.patronLbl.Size = new System.Drawing.Size(44, 13);
            this.patronLbl.TabIndex = 2;
            this.patronLbl.Text = "Patron: ";
            // 
            // patrnComboBx
            // 
            this.patrnComboBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.patrnComboBx.FormattingEnabled = true;
            this.patrnComboBx.Location = new System.Drawing.Point(75, 60);
            this.patrnComboBx.Name = "patrnComboBx";
            this.patrnComboBx.Size = new System.Drawing.Size(148, 21);
            this.patrnComboBx.TabIndex = 3;
            this.patrnComboBx.Text = "        Select Patron";
            this.hintToolTip.SetToolTip(this.patrnComboBx, "Select a Patron Here");
            this.patrnComboBx.Validating += new System.ComponentModel.CancelEventHandler(this.patrnComboBx_Validating);
            this.patrnComboBx.Validated += new System.EventHandler(this.patrnComboBx_Validated);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(18, 149);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(96, 25);
            this.enterBtn.TabIndex = 4;
            this.enterBtn.Text = "OK";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBttn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(154, 150);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(96, 25);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CancelBttn_MouseDown);
            // 
            // errorProviderItem
            // 
            this.errorProviderItem.ContainerControl = this;
            // 
            // errorProviderPatron
            // 
            this.errorProviderPatron.ContainerControl = this;
            // 
            // CheckoutForm
            // 
            this.AcceptButton = this.enterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 252);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.patrnComboBx);
            this.Controls.Add(this.patronLbl);
            this.Controls.Add(this.itemchklbl);
            this.Controls.Add(this.itemComboBx);
            this.Name = "CheckoutForm";
            this.Text = "Checkout Items";
            this.Load += new System.EventHandler(this.CheckoutWindowLoad);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatron)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label itemchklbl;
        private System.Windows.Forms.Label patronLbl;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProviderItem;
        private System.Windows.Forms.ErrorProvider errorProviderPatron;
        internal System.Windows.Forms.ComboBox itemComboBx;
        internal System.Windows.Forms.ComboBox patrnComboBx;
        private System.Windows.Forms.ToolTip hintToolTip;
    }
}