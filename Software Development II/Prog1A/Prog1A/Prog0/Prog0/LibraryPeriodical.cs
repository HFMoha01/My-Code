// Program 0
// CIS 200-01
// Grading ID: T1681
// Due: 1/12/2020

// File: LibraryPeriodical.cs
// This file creates an abstract LibraryPeriodical class capable of tracking
// the item's title, publisher, copyright year, call number,loan period, 
//  volume, number and checked out status.
// HAS-A with LibraryPatron


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


   public abstract class LibraryPeriodical : LibraryItem
    {
            private int _volume;  // the library periodical 's volume #
            private int _number;  // the library periodical's number

            // Precondition:  theCopyrightYear >= 0
            //                theLoanPeriod >= 0
            //                theVolume >= 1
            //                theNumber >= 1
            //                theTitle, theCallNumber may not be null or empty
            // Postcondition: The library periodical item has been initialized with the specified
            //                values for title, publisher, copyright year, loan period, call number,  
            //                volume and number. The item is not checked out
        public LibraryPeriodical(string theTitle, string thePublisher, int theCopyrightYear,
                string theCallNumber, int theLoanPeriod, int theVolume, int theNumber) : base(theTitle, thePublisher,
                theCopyrightYear, theCallNumber, theLoanPeriod)
        {
                    Volume = theVolume;
                    Number = theNumber;
                    ReturnToShelf(); // Make sure Periodical is not checked out
        }


                public int Volume
                {
                    // Precondition:  None
                    // Postcondition: The volume has been returned
                    get
                    {
                        return _volume;
                    }

                        // Precondition:  value >= 1
                        // Postcondition: The volume has been set to the specified value
                     set
                     {
                        if (value >= 1)
                            _volume = value;
                        else
                            throw new ArgumentOutOfRangeException($"{nameof(Volume)}", value,
                            $"{nameof(Volume)} must be >= 0");
                     }
                }

                public int Number
                {
                     // Precondition:  None
                     // Postcondition: The number has been returned
                        get
                        {
                            return _number;
                        }

                    // Precondition:  value >= 1
                    // Postcondition: The number has been set to the specified value
                        set
                        {
                            if (value >= 1)
                                _number = value;
                            else
                                throw new ArgumentOutOfRangeException($"{nameof(Number)}", value,
                                $"{nameof(Number)} must be >= 0");
                        }
                }


                    // Precondition:  None
                    // Postcondition: A string is returned representing the library music's
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
                    $"Call Number: {CallNumber}{NL}Loan Period: {LoanPeriod}{NL}" +
                    $"Volume: {Volume}{NL}Number: {Number}{NL}{checkedOutBy}";

                }






   }

