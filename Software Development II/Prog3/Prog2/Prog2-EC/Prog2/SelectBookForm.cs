// Program 3
// CIS 200-01
// Due: 4/02/2020
// Grading: T1681

// File: SelectBookForm.cs
// This class creates the  GUI  form to select the LibraryPatron from the library the user
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
    public partial class SelectBookForm : Form
    {
        private List<LibraryItem> _items;       // List of library items
        private List<int> isABookIndices; // List of index values of books 


        // Precondition:  Lists itemList are populated with the available
        //                LibraryItems respectively, to choose from
        // Postcondition: The form's GUI is prepared for display.
        public SelectBookForm(List<LibraryItem> itemList)
        {
            InitializeComponent();
            _items = itemList;
            isABookIndices = new List<int>();

        }


        // Precondition:  None
        // Postcondition: The lists of item used to populate the
        //                item , respectively
        private void SelectBookFormLoad(object sender, EventArgs e)
        {
            for (int i = 0; i < _items.Count; ++i)
            {                
                    if (_items[i] is LibraryBook)
                    {
                        bookCbo.Items.Add($"{_items[i].Title}, {_items[i].CallNumber}");
                        isABookIndices.Add(i); // Keep track of location

                    }
                
            }

        }

        internal int BookIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item combo box has been returned
            get
            {
                if (bookCbo.SelectedIndex != -1)
                    return isABookIndices[bookCbo.SelectedIndex]; // Lookup correct index

                // Should never happen if validation works
                return -1;
            }
        }

        // Precondition:  Focus is shifting from bookCbo
        // Postcondition: If selection is invalid, focus remains and error provider
        //                highlights the field
        private void bookCbo_Validating(object sender, CancelEventArgs e)
        {
            if (bookCbo.SelectedIndex == -1) // Nothing selected
            {
                e.Cancel = true;
                errorProviderEditBook.SetError(bookCbo, "Must select a Book");
            }

        }

        // Precondition:  Validating of bookCbo not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void bookCbo_Validated(object sender, EventArgs e)
        {
            errorProviderEditBook.SetError(bookCbo, "");
        }


        // Precondition:  User clicked on okBtn
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // If all controls validate
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes and sends Cancel result
        private void CancelBttn_Mouse_Down_Event(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        

    }
}
