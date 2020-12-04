// Program 0
// CIS 200-01
// Grading ID: T1681
// Due: 1/12/2020

// File: LibraryMagazine.cs
// This file createsLibraryMagzine class capable of tracking
// the item's title, publisher, copyright year, call number,loan period, 
//  volume, number and checked out status.
// HAS-A with LibraryPatron



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class LibraryMagazine:LibraryPeriodical
    {
        // Precondition:  theCopyrightYear >= 0
        //                theLoanPeriod >= 0
        //                theVolume >= 1
        //                theNumber >= 1
        //                theTitle, theCallNumber may not be null or empty
        // Postcondition: The library periodical item has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, call number,  
        //                volume and number. The item is not checked out
            public LibraryMagazine (string theTitle, string thePublisher, int theCopyrightYear,
            string theCallNumber, int theLoanPeriod, int theVolume, int theNumber) : base(theTitle, thePublisher,
            theCopyrightYear, theCallNumber, theLoanPeriod, theVolume, theNumber)
            {
        
                    ReturnToShelf(); // Make sure Magazine is not checked out
            }


                // Precondition: the daysLate >= 0
                // Postcondition: late fee will be returned
            public override decimal CalcLateFee(int daysPastDue)
            {
                 const decimal LATECHARGE = .75M;        // fee per day for being late            
                 const decimal MAXFEE = 20;             // Max fee that can be charged
                        decimal lateFee;
                      
                    lateFee = LATECHARGE * daysPastDue;


                        if (lateFee > MAXFEE)
                        {
                            lateFee = MAXFEE;
                        }

                            return lateFee;
            }


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

