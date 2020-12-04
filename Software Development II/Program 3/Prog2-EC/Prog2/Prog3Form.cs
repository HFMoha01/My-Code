// Program 3
// CIS 200-01
// Due: 4/02/2020
// Grading: T1681

// File: Prog3Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, a
// Report menu with Patron List, Item List, and Checked Out Items items and
// Edit Menu with Patron and Book items.
// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace LibraryItems
{
    public partial class Prog3Form : Form
    {
        private Library _lib; // The library

        // Object for seralizing the file in binary form
        private BinaryFormatter formatter = new BinaryFormatter();
        private BinaryFormatter reader = new BinaryFormatter();
        private FileStream output; // stream for writing to  a file
        private FileStream input; // stream for reading from a file

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog3Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library

           /* // Insert test data - Magic numbers allowed here
            _lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14, "ZZ25 3G", "Andrew Wright");
            _lib.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21, "AB73 ZF", "IP Thief");
            _lib.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG);
            _lib.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            _lib.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            _lib.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            _lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2017, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            _lib.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA53 9A", 16, 7);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA53 9B", 16, 8);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA53 9C", 16, 9);
            _lib.AddLibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14, "MA21 5V", 1, 1);

            // Add 5 Patrons
            _lib.AddPatron("Ima Reader", "12345");
            _lib.AddPatron("Jane Doe", "11223");
            _lib.AddPatron("   John Smith   ", "   654321   ");
            _lib.AddPatron("James T. Kirk", "98765");
            _lib.AddPatron("Jean-Luc Picard", "33456");
            */

        }


        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 3{NL}Grading ID: T1681{NL}CIS 200-01{NL}Spring 2020",
                "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons;     // List of patrons
            string NL = Environment.NewLine; // NewLine shortcut

            patrons = _lib.GetPatronsList();

            reportTxt.Text = $"Patron List - {patrons.Count} patrons{NL}{NL}";

            foreach (LibraryPatron p in patrons)
                reportTxt.AppendText($"{p}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;         // List of library items
            string NL = Environment.NewLine; // NewLine shortcut

            items = _lib.GetItemsList();

            reportTxt.Text = $"Item List - {items.Count} items{NL}{NL}";

            foreach (LibraryItem item in items)
                reportTxt.AppendText($"{item}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;         // List of library items
            string NL = Environment.NewLine; // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            reportTxt.Text = $"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}";

            foreach (LibraryItem item in checkedOutItems)
                reportTxt.AppendText($"{item}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items
            List<LibraryPatron> patrons; // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();

            if (((items.Count - _lib.GetCheckedOutCount()) == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(items, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.CheckOut(checkoutForm.ItemIndex, checkoutForm.PatronIndex);
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();

            if ((_lib.GetCheckedOutCount() == 0)) // Must have items to return
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(items); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.ReturnToShelf(returnForm.ItemIndex);
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        //Pre Condition: invoked when Open File, File menu is activated
        // Post Condition: The file is opened
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create and show dialog box enabling user to open file
            DialogResult result;     // result of Open file dialog
            string fileName;        //name of the file to open


            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();  // sets  the result
                fileName = fileChooser.FileName;    // gets specified file name
            }


            //ensures that user clicked OK
            if (result == DialogResult.OK)
                reportTxt.Clear();  // Clears the Report field from previous file

            // show error message if user specified invalid file
            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Error! Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                try
                {
                    // creates filestream to obtain read/wrie access to the file
                    input = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
                    _lib = (Library)reader.Deserialize(input);
                }

                catch (IOException)
                {
                    MessageBox.Show("File Could Not Be Open, Restart Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (SerializationException)
                {
                    MessageBox.Show("Error Opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                catch (ArgumentException)
                {
                    MessageBox.Show("Argument Exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    input?.Close();  //Closes stream file
                }

            }


        }

        //Pre Condition: invoked when Save File, File menu is activated
        // Post Condition: The file is saved
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create and show dialog box enabling user to save file
            DialogResult result;     // result of Save file dialog
            string fileName;        //name of the file to save data


            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; //To let user create file

                // retrieves the result of the dialog box
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;      //get specified file name
            }
                // ensure that user clicked Ok
                if (result == DialogResult.OK)
                {
                    // Shows error if file is invalid
                    if (string.IsNullOrWhiteSpace(fileName))
                    {
                        MessageBox.Show("Please Enter A File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        // save file via filestream if file is valid

                        try
                        {

                            //open file with write access
                            output = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                        }

                        catch (IOException)
                        {
                            // notifies if file could not be opened
                            MessageBox.Show("File Could Not Be Opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        catch (ArgumentException)
                        {
                            MessageBox.Show("Argument Exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        catch (SystemException)
                        {
                            MessageBox.Show("File Not Supported or Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        

                    }


                }


                try
                {
                    // Serializes the object
                    formatter.Serialize(output,_lib);
                }

                catch (IOException)
                {
                         // notifies if file could not be opened
                    MessageBox.Show("File Could Not Be Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                catch (SerializationException)
                {
                    MessageBox.Show("Error Writing to file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
                catch (ArgumentException)
                {
                    MessageBox.Show("Argument Exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                catch (SystemException)
                {
                MessageBox.Show("Do not have permission to open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    output?.Close();  // Closes the file stream
                }


        

        }

        //Pre Condition: invoked when Patron, Edit menu is activated
        // Post Condition: The file is opened
        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons; // List of patrons
            patrons = _lib.GetPatronsList();


            if ((patrons.Count() == 0)) // Must have patrons
                MessageBox.Show("Must have patrons to edit!", "Edit Patron Error");
            else
            {
                SelectPatronForm selectPatronForm = new SelectPatronForm(patrons); // The Select Patron dialog box form

                DialogResult result = selectPatronForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        PatronForm patronForm = new PatronForm(); // The patron dialog box form


                        LibraryPatron selected = patrons[selectPatronForm.PatronIndex]; //carry over the selection into the form

                        patronForm.PatronName = selected.PatronName;  // sets Forms Patron Name property  to one the user selects
                        patronForm.PatronID = selected.PatronID;     // sets Form's Patron Id property to one the user selects
                        patronForm.ShowDialog(); // Show form as dialog and store result

                        if (result == DialogResult.OK) // Only add if OK
                        {
                            // Uses the forms properties to edit patron 
                            selected.PatronName = patronForm.PatronName;  // set patron's name to user's input
                            selected.PatronID = patronForm.PatronID;        // set patron's id to user's input
                        }

                        patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway

                    }

                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Enter Input into the Proper Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("Please Enter Correct Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                selectPatronForm.Dispose(); // Good .NET practice - will get garbage collected anyway

            }

        }

        private void BookToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            List<LibraryItem> items; // List of items
            items = _lib.GetItemsList();


            if (items.Count() == 0) // Must have items 
                MessageBox.Show("Must have books to edit!", "Edit Patron Error");
            else
            {



                SelectBookForm selectBookForm = new SelectBookForm(items); // The Select Book dialog box form load with items

                DialogResult result = selectBookForm.ShowDialog(); // Show form as dialog and stores result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        BookForm bookForm = new BookForm(); // The patron dialog box form


                        LibraryBook selected = (LibraryBook)items[selectBookForm.BookIndex];         //carryovers the selected book's properties into the new form
                        bookForm.ItemTitle = selected.Title;                            // sets itemTitle property to one the user selected
                        bookForm.ItemPublisher = selected.Publisher;                    // sets ItemPublisherTxt property to one the user selected
                        bookForm.ItemCopyrightYear = selected.CopyrightYear.ToString(); // sets ItemCopyrightYearsTxt property to one the user selected
                        bookForm.ItemLoanPeriod = selected.LoanPeriod.ToString();       // sets LoanPeriodTxt property to one the user selected
                        bookForm.ItemCallNumber = selected.CallNumber;                  // sets ItemCallNumberTxt  property to one user selected
                        bookForm.BookAuthor = selected.Author;                          // sets bookAuthorTxt property to one user selected



                        bookForm.ShowDialog(); // Show form as dialog and store result
                        if (result == DialogResult.OK) // Only add if OK
                        {
                            selected.Title = bookForm.ItemTitle;                           // sets Title to input
                            selected.Publisher = bookForm.ItemPublisher;                    // sets Publisher to input
                            selected.CopyrightYear = int.Parse(bookForm.ItemCopyrightYear); // sets CopyrightYears to input
                            selected.LoanPeriod = int.Parse(bookForm.ItemLoanPeriod);       // sets Loan Period to input
                            selected.CallNumber = bookForm.ItemCallNumber;                  // sets Call Number to input
                            selected.Author = bookForm.BookAuthor;                          // sets Call Number to input

                        }

                        bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway

                    }

                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Enter Input into the Proper Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("Please Enter Correct Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                selectBookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
                
            }

        }

        //Pre condition: File is already open
        //Post Condition: File is Closed
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input?.Close(); // closes the stream file
            _lib = new Library(); // empties the library
            reportTxt.Clear();   // clears the report box

        }
    }
}
