// Program 2
// CIS 200-01
// Due: 3/09/2020
// By: T1681
//
// File:Checkout.cs
// This file creates a GUI interface that allows a user to Checkout an item from the library 
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
    public partial class CheckoutForm : Form
    {
        internal List<LibraryItem> _items;     // List of items stored in Library
        internal List<LibraryPatron> _patrons; // List of patrons of Library

        // Precondition:  None
        // Postcondition: The List of items and patrons have  been initialized
        public CheckoutForm(List<LibraryItem> items, List<LibraryPatron> patrons)   //constructor
        {
            InitializeComponent();
            _items = items; 
            _patrons = patrons; 
        }

        internal int UserItemSelected
        {
            // Precondition: None
            // Postcondition: Will return the index num of that the user selects from the combo box
            get
            {
                return itemComboBx.SelectedIndex;
            }
        }

        internal int UserPatronSelected
        {
            // Precondition: None
            // Postcondition: Will return the index num of that the user selects from the combo box
            get
            {
                return patrnComboBx.SelectedIndex;
            }
        }


        // Precondition: None
        // Postcondition: Loads the combo boxes with items and patrons from the lists
        private void CheckoutWindowLoad(object sender, EventArgs e)
        {
            //Populates item combo box with items not checked out for the item's list
            foreach (var item in _items)
                if (item.IsCheckedOut() != true)
                    itemComboBx.Items.Add(item.Title + ", " + item.CallNumber);            // Formats what information is displayed about the Items


            //Populates patron combo box with patrons for the patron's list
            foreach (var patron in _patrons) 
                patrnComboBx.Items.Add(patron.PatronName + ", " + patron.PatronID);     // Formats what information is displayed about the Patrons
        }


        // Precondition: User attempts to change the focus of the Item combo box
        // Postcondition: Validates the User's selection and an error causes exclamation mark to flash
        private void itemComboBx_Validating(object sender, CancelEventArgs e)
        {
            
            if (itemComboBx.SelectedItem == null )
            {
                e.Cancel = true;                     
             
                errorProviderItem.SetError(itemComboBx, "Select an item!"); 
            }
        }

        //Precondition: Validating succeeds
        //Postcondition: Clears the Item combo box error message
        private void itemComboBx_Validated(object sender, EventArgs e)
        {
            errorProviderItem.SetError(itemComboBx, "");
        }

        // Precondition: User attempts to change the focus of the Patron combo box
        // Postcondition: Validates the User's selection and an error causes exclamation mark to flash
        private void patrnComboBx_Validating(object sender, CancelEventArgs e)
        {
            if (patrnComboBx.SelectedItem == null)
            {
                e.Cancel = true;

                errorProviderPatron.SetError(patrnComboBx, "Select a Patron!");
            }
        }

        //Precondition: Validating succeeds
        //Postcondition: Clears the Patron combo box error message
        private void patrnComboBx_Validated(object sender, EventArgs e)
        {
            errorProviderPatron.SetError(patrnComboBx, "");
        }


        // Precondition: Ok button is clicked
        // Postcondition: Validates the Checkout form and updates the main form
        private void enterBttn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        // Precondition: The cancel button is clicked
        // Postcondition: closes the form
        private void CancelBttn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DialogResult = DialogResult.Cancel;
        }

        
    }
}
