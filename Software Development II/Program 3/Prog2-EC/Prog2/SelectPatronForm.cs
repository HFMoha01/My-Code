// Program 3
// CIS 200-01
// Due: 4/02/2020
// Grading: T1681

// File: SelectPatronForm.cs
// This class creates the  GUI  form to select the LibraryBook from the library the user
// wishes to be edited.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class SelectPatronForm : Form
    {
        private List<LibraryPatron> _patrons;   // List of patrons

        // Precondition:  Lists patronList are populated with the available
        //                LibraryPatrons, respectively, to choose from
        // Postcondition: The form's GUI is prepared for display.
        public SelectPatronForm(List<LibraryPatron> patronList)
        {
            InitializeComponent();
            _patrons = patronList;
        }


        internal int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected patron combo box has been returned
            get
            {
                return patrCbo.SelectedIndex;
            }
        }



        // Precondition:  None
        // Postcondition: The lists of patrons are used to populate the
        //                patron combo boxes, respectively
        private void SelectPatron_LoadEvent(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in _patrons)
                patrCbo.Items.Add($"{patron.PatronName}, {patron.PatronID}");
        }



        // Precondition:  Focus is shifting from patrCbo
        // Postcondition: If selection is invalid, focus remains and error provider
        //                highlights the field
        private void PatrCbo_Validating_Event(object sender, CancelEventArgs e)
        {
            if (patrCbo.SelectedIndex == -1) // Nothing selected
            {
                e.Cancel = true;
                errorProviderPatron.SetError(patrCbo, "Must select Patron");
            }

        }

        // Precondition:  Validating of patrCbo not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void PatrCbo_Validated_Event(object sender, EventArgs e)
        {
            errorProviderPatron.SetError(patrCbo, "");
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes and sends Cancel result
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;

        }

        // Precondition:  User clicked on okBtn
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void subBttn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // If all controls validate
            {
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result

            }
        }
    }



   
    









}

