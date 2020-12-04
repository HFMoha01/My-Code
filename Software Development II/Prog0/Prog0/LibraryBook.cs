// Program 0
// Grading ID : T1681
// Due Date : 01/27/2019
// Course Section: CIS200-01


// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public readonly int DEFAULT_YEAR = DateTime.Now.Year; // Default copyright year is current year

    private string _title;          // The book's title
    private string _author;         // The book's author
    private string _publisher;      // The book's publisher
    private int _copyrightYear;     // The book's year of copyright
    private string _callNumber;     // The book's call number in the library
    private bool _checkedOut;       // The book's checked out status
    private LibraryPatron _patron;  //The book's Patron
   


    // Precondition:  theCopyrightYear >= 0
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber)
    {
        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;
        
        ReturnToShelf(); // Make sure book is not checked out
    }

    public string Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition: String can not be null or whitespace
        // Postcondition: The title has been set to the specified value
        set
        {
            if (String.IsNullOrWhiteSpace(value.Trim()))
            {
                throw new ArgumentOutOfRangeException("Title", value, "Please Enter A Title!!");
            }

            else
                _title = value;
        }
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
            _author = value;
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
            _publisher = value;
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
            {
                throw new ArgumentOutOfRangeException("Copyright Year", value, "Please Enter A Valid Copyright Year!!"); // error message if input violates pre condition
               
            }
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

        // Precondition:  String can not be null or whitespace
        // Postcondition: The call number has been set to the specified value
        set
        {
            if (String.IsNullOrWhiteSpace(value.Trim()))
            {
                throw new ArgumentOutOfRangeException("Call Number", value, "Please Enter the Call Number!!");    // error message if input violates pre condition
            }

            else
            _callNumber = value;
        }
    }
     public LibraryPatron Patron
    {   
        //precondition : A book must be checked out by the patron
        //postcondition : returns a reference to Library Patron that the book is checked out
       
        get
        {
            if (IsCheckedOut())   //Checks to see if the book's checkout status
            {
                return _patron;   //returns the Library Patron's reference

            }

            else
                return null;      // returns a null value if the book hasn't been checked out
        }
    }
    // Precondition:  A Library Patron must check out the book
    // Postcondition: The book is checked out and is tied to the specific Patron
    public void CheckOut(LibraryPatron alPatron)
    {
        _patron = alPatron; 
        _checkedOut = true;
    }

    // Precondition:  None
    // Postcondition: The book's checked out status changes to reflect its return
    public void ReturnToShelf()
    {
        _patron = null;     // When the book is returned it's patron object returns to none
        _checkedOut = false;
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
    }

    // Precondition:  None
    // Postcondition: A string is returned representing the library book's
    //                data on separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // Newline shortcut
        string ThePatronIs;


        if (IsCheckedOut())
        {
            ThePatronIs =  NL + Patron.ToString() ;  // Uses the LibraryPatron Overrided ToString() display Patron Name and ID
        }
        else
            ThePatronIs = "Not Checked Out";


        return $"Title: {Title}{NL}Author: {Author}{NL}Publisher: {Publisher}{NL}" +
            $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}" +
            $"Checked Out By: {ThePatronIs}";
    }
}
