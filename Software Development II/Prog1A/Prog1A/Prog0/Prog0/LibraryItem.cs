// Program 0
// CIS 200-01
// Grading ID: T1681
// Due: 1/12/2020

// File: LibraryMediaItem.cs
// This file creates an abstract LibraryItem class capable of tracking
// the item's title, publisher, copyright year, call number,loan period, 
//  loan period and checked out status.
// HAS-A with LibraryPatron


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public abstract class LibraryItem
    {
        public readonly int DEFAULT_YEAR = DateTime.Now.Year; // Default copyright year is current year

        private string _title;      // The item's title
        private string _publisher;  // The item's publisher
        private int _copyrightYear; // The item's year of copyright
        private string _callNumber; // The item's call number in the library
        private int _loanPeriod;    // The item's loan period


        // Precondition:  theCopyrightYear >= 0
        //                theLoanPeriod >= 0
        //                theTitle, theCallNumber may not be null or empty
        // Postcondition: The library item has been initialized with the specified
        //                values for title, publisher, copyright year, and
        //                call number and loan period. The item is not checked out.
        public LibraryItem(String theTitle, String thePublisher,
            int theCopyrightYear, String theCallNumber, int theLoanPeriod )
        {
            Title = theTitle;
            Publisher = thePublisher;
            CopyrightYear = theCopyrightYear;
            CallNumber = theCallNumber;
            LoanPeriod = theLoanPeriod;

            ReturnToShelf(); // Make sure item is not checked out
        }

        public string Title
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get
            {
                return _title;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The title has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Title)}", value,
                        $"{nameof(Title)} must not be null or empty");
                else
                    _title = value.Trim();
            }
        }


        public string Publisher
        {
            // Precondition:  None
            // Postcondition: The publisher has been returned
            get
            {
                return _publisher;
            }

            // Precondition:  None
            // Postcondition: The publisher has been set to the specified value
            set
            {
                // Since empty publisher is OK, just change null to empty string
                _publisher = (value == null ? string.Empty : value.Trim());
            }
        }

        public int CopyrightYear
        {
            // Precondition:  None
            // Postcondition: The copyright year has been returned
            get
            {
                return _copyrightYear;
            }

            // Precondition:  value >= 0
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 0)
                    _copyrightYear = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                        $"{nameof(CopyrightYear)} must be >= 0");
            }
        }

        public string CallNumber
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return _callNumber;
            }

            // Precondition:  None
            // Postcondition: The call number has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(CallNumber)}", value,
                        $"{nameof(CallNumber)} must not be null or empty");
                else
                    _callNumber = value.Trim();
            }
        }

         public int LoanPeriod
         {

                // Precondition:  None
                // Postcondition: The loan period has been returned
                get
                {
                    return _loanPeriod;
                }

                // Precondition:  value >= 0
                // Postcondition: The loan period has been set to the specified value
                set
                {
                    if (value >= 0)
                        _loanPeriod = value;

                    else
                        throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                        $"{nameof(LoanPeriod)} must be >= 0");
                }
         }


        // Create HAS-A
        public LibraryPatron Patron
        {
            // Precondition:  None
            // Postcondition: The book's patron has been returned
            get; // Auto-implement is fine

            // Helper
            // Precondition:  None
            // Postcondition: The book's patron has been set to the specified value
            private set; // Auto-implement is fine 
        }

        public void CheckOut(LibraryPatron thePatron)
        {
            if (thePatron != null)
                Patron = thePatron;
            else
                throw new ArgumentNullException($"{nameof(thePatron)}", $"{nameof(thePatron)} must not be null");
        }

        // Precondition:  None
        // Postcondition: The book is not checked out
        public void ReturnToShelf()
        {
            Patron = null; // Remove previously stored reference to patron
        }

        // Precondition:  None
        // Postcondition: true is returned if the item is checked out,
        //                otherwise false is returned
        public bool IsCheckedOut()
        {
            return Patron != null; // The item is checked out if there is a Patron
        }
         


        // Precondition: the daysLate >= 0
        // Postcondition: late fee will be returned
        public abstract decimal CalcLateFee(int daysPastDue);




        // Precondition:  None
        // Postcondition: A string is returned representing the library item's
        //                data on separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut
        string checkedOutBy; // Holds checked out message

        if (IsCheckedOut())
            checkedOutBy = $"Checked Out By: {NL}{Patron}";
        else
            checkedOutBy = "Not Checked Out";

        return $"Title: {Title}{NL}Publisher: {Publisher}{NL}Copyright: {CopyrightYear}{NL}" +
            $"Call Number: {CallNumber}{NL}{checkedOutBy}{NL}Loan Period:{LoanPeriod}";
    }







}

