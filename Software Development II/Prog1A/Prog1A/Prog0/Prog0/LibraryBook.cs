// Program 0
// CIS 200-01
// Grading ID: T1681
// Due: 1/12/2020

// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// loan period and checked out status.
// Added HAS-A with LibraryPatron
// Removed bool backing field for checked out status

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook : LibraryItem
{
    private string _author; // the book's author

    // Precondition:  theCopyrightYear >= 0
    //                theLoanPeriod >= 0
    //                theTitle, theCallNumber may not be null or empty
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, 
    //                call number, and loan period. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber, int theLoanPeriod) : base(theTitle,thePublisher,
            theCopyrightYear, theCallNumber, theLoanPeriod)
    {
        
        Author = theAuthor; 
        ReturnToShelf(); // Make sure book is not checked out
    }

    public string Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            // Since empty author is OK, just change null to empty string
            _author = (value == null ? string.Empty : value.Trim());
        }
    }


    // Precondition: the daysLate >= 0
    // Postcondition: late fee will be returned
    public override decimal CalcLateFee(int daysPastDue)
    {
        const decimal LATECHARGE = .25M;   // fee of being late per day
        decimal lateFee = daysPastDue * LATECHARGE; 

        return lateFee;
    

    }


    // Precondition:  None
    // Postcondition: A string is returned representing the library book's
    //                data on separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut
        string checkedOutBy; // Holds checked out message

        if (IsCheckedOut())
            checkedOutBy = $"Checked Out By: {NL}{Patron}";
        else
            checkedOutBy = "Not Checked Out";

        return $"Title: {Title}{NL}Author: {Author}{NL}Publisher: {Publisher}{NL}" +
            $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}Loan Period: {LoanPeriod}{NL}{checkedOutBy}";
    }
}
