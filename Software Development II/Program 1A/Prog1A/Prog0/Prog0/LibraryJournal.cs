// Program 0
// CIS 200-01
// Grading ID: T1681
// Due: 1/12/2020

// File: LibraryJournal.cs
// This file creates an Library Journal class capable of tracking
// the item's title, publisher, copyright year, call number,loan period, 
//  volume, number,discpline, editor and checked out status.
// HAS-A with LibraryPatron

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class LibraryJournal : LibraryPeriodical
    {
                private string _discipline;  // the library periodical 's volume #
                private string _editor;  // the library periodical's number

            // Precondition:  theCopyrightYear >= 0
            //                theLoanPeriod >= 0
            //                theVolume >= 1
            //                theNumber >= 1
            //                theTitle,theDiscipline, theEditor and theCallNumber may not be null or empty
            // Postcondition: The library journal item has been initialized with the specified
            //                values for title, publisher, copyright year, loan period, call number,  
            //                volume,editor,discipline and number. The item is not checked out




            public LibraryJournal(string theTitle, string thePublisher, int theCopyrightYear,
                string theCallNumber, int theLoanPeriod, int theVolume, int theNumber, string theDiscipline, string theEditor) : base(theTitle, thePublisher,
                theCopyrightYear, theCallNumber, theLoanPeriod, theVolume, theNumber)
            {
                Discipline = theDiscipline;
                Editor = theEditor;
                ReturnToShelf(); // Make sure Journal is not checked out
            }


            public string Discipline
            {
                // Precondition:  None
                // Postcondition: The discipline has been returned

                get
                {
                    return _discipline;
                }

                // Precondition:  value must not be null or empty
                // Postcondition: The discipline has been set to the specified value

                set
                {
                    if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                        throw new ArgumentOutOfRangeException($"{nameof(Discipline)}", value,
                        $"{nameof(Discipline)} must not be null or empty");

                    else
                        _discipline = value.Trim();
                }

            }



            public string Editor
            {
                    // Precondition:  None
                    // Postcondition: The editor has been returned

                    get
                    {
                        return _editor;
                    }

                    // Precondition:  value must not be null or empty
                    // Postcondition: The editor has been set to the specified value

                    set
                    {
                        if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                        throw new ArgumentOutOfRangeException($"{nameof(Editor)}", value,
                        $"{nameof(Editor)} must not be null or empty");

                    else
                            _editor = value.Trim();
                    }

            }


                // Precondition: the daysLate >= 0
                // Postcondition: late fee will be returned
            public override decimal CalcLateFee(int daysPastDue)
            {
                const decimal LATECHARGE = .75M;        // fee per day for being late            
                decimal lateFee;

                lateFee = LATECHARGE * daysPastDue;

                

               return lateFee;


            }


                // Precondition:  None
                // Postcondition: A string is returned representing the library music's
                // data on separate lines
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
                $"Editor: {Editor}{NL}Discipline: {Discipline}{NL}{checkedOutBy}";

            }

















    }

