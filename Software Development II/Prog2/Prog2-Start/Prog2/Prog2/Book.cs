// Program 2
// CIS 200-01
// Due: 3/09/2020
// By: T1681
//
// File: Book.cs
// This file creates a GUI interface that adds books to a library 
//
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class BookForm : Form
    {

        const int MIN = 0; //named constant to for negative numbers
        public BookForm()
        {
            InitializeComponent();
        }

        internal string UserTitleInput
        {
            // Precondition: None
            // Postcondition: Returns User's Input  from the Title text box
            get
            {
                return titleTxtBx.Text;
            }
        }

        internal string UserPublisherInput
        {
            // Precondition: None
            // Postcondition: Returns User's Input from the Publisher text box
            get
            {
                return publisherTxtBx.Text;
            }
        }

        internal string UserCopyrightYearInput
        {
            // Precondition: None
            // Postcondition: Returns User's Input  from the Copyright Year text box
            get
            {
                return cpRgtYrTxt.Text;
            }
        }

        internal string UserLoanPeriodInput
        {
            // Precondition: None
            // Postcondition: Returns User's Input  from the Loan Period text box
            get
            {
                return loanPdTxtBx.Text;
            }
        }

        internal string UserCallNumberInput
        {
            // Precondition: None
            // Postcondition: Returns User's Input  from the Call Number text box
            get
            {
                return callNumTxtBx.Text;
            }
        }

        internal string UserAuthorInput
        {
            // Precondition: None
            // Postcondition: Returns User's Input  from the Author text box
            get
            {
                return authTxtBx.Text;
            }
        }





        // Precondition: User attempts to change the focus of the title text box
        // Postcondition: Validates the title text box and an error causes exclamation mark to flash 
        private void TitleTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTxtBx.Text))
            {
                e.Cancel = true;

                errorTitleProvider.SetError(titleTxtBx, "Please enter the Title!");

                titleTxtBx.SelectAll();
            }

        }


        

        private void TitleTxtBx_Validated(object sender, EventArgs e)
        {
            errorTitleProvider.SetError(titleTxtBx, "");
        }


        // Precondition: User attempts to change the focus of the publisher text box
        // Postcondition: Validates the publisher text box and an error causes exclamation mark to flash
        private void PublisherTxtBxValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(publisherTxtBx.Text))
            {
                e.Cancel = true;

                errorTitleProvider.SetError(publisherTxtBx, "Please enter the Publisher Name!");

                publisherTxtBx.SelectAll();
            }
        }

        //Precondition: Validating succeeds
        //Postcondition: Clears the Publisher text box Error Message
        private void PublisherTxtBxValidated(object sender, EventArgs e)
        {
            errorPubProvider.SetError(publisherTxtBx, "");
        }



        // Precondition: User attempts to change the focus of the Copyright Year text box
        // Postcondition: Validates the Copyright Year text box and an error causes exclamation mark to flash
        private void CpRgtYrTxtbx_Validating(object sender, CancelEventArgs e)
        {
            int cpRghtYear;         // holds user input for copyright year

            if (!int.TryParse(cpRgtYrTxt.Text, out cpRghtYear) ||
                Convert.ToInt32(cpRgtYrTxt.Text) < MIN)
            {
                e.Cancel = true;

                errorCpyRghtProvider.SetError(cpRgtYrTxt, "Enter the Copyright Year!");  

                cpRgtYrTxt.SelectAll();
            }
        }



        //Precondition: Validating succeeds
        //Postcondition: Clears the Copyright Year textbox Error Message
        private void CpRgtYrTxtbx_Validated(object sender, EventArgs e)
        {
            errorCpyRghtProvider.SetError(cpRgtYrTxt, "");
        }



        // Precondition: User attempts to change the focus of the Loan Period text box
        // Postcondition: Validates the Loan Period text box and an error causes exclamation mark to flash 
        private void LoanPdTxtBx_Validating(object sender, CancelEventArgs e)
        {
            int loanPeriod; //holds the loanperiod

            if (!int.TryParse(loanPdTxtBx.Text, out loanPeriod) ||
                Convert.ToInt32(loanPdTxtBx.Text) < MIN)
            {
                e.Cancel = true;

                errorLnPdProvider.SetError(loanPdTxtBx, "Enter the Loan Period!");

                loanPdTxtBx.SelectAll();
            }
        }


        //Precondition: Validating succeeds 
        //Postcondition: Clears the Loan Period text box Error Message
        private void LoanPdTxtBx_Validated(object sender, EventArgs e)
        {
            errorLnPdProvider.SetError(loanPdTxtBx, "");
        }


        // Precondition: User attempts to change the focus of the Call Number text box
        // Postcondition: Validates the Call Number text box and an error causes exclamation mark to flash 

        private void callNumberTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(callNumTxtBx.Text))
            {
                e.Cancel = true;

                errorCallNumProvider.SetError(callNumTxtBx, "Enter the Call Number!");

                callNumTxtBx.SelectAll();
            }
        }

        //Precondition: Validating succeeds
        //Postcondition: Clears the Call Number text box  Error Message
        private void callNumTxtBx_Validated(object sender, EventArgs e)
        {
            errorCallNumProvider.SetError(callNumTxtBx, "");
        }


        // Precondition: User attempts to change the focus of the Author text box
        // Postcondition: Validates the Author text box and an error causes exclamation mark to flash 
        private void authTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authTxtBx.Text))
            {
                e.Cancel = true;

                errorCallNumProvider.SetError(authTxtBx, "Enter the Book's Author !");

                authTxtBx.SelectAll();
            }
        }



        //Precondition: Validating succeeds
        //Postcondition: Clears the Author text box Error Message
        private void authTxtBx_Validated(object sender, EventArgs e)
        {
            errorAuthProvider.SetError(authTxtBx, "");
        }


        // Precondition: OK button is clicked
        // Postcondition: Validates the Book form and updates the main form

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition: The cancel button is clicked
        // Postcondition: closes the form
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        

        

        
    }
}
