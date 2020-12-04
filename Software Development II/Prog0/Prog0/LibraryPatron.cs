// Program 0
// Grading ID : T1681
// Due Date : 01/27/2019
// Course Section: CIS200-01


// File: LibraryPatron.cs
// This file creates a simple LibraryPatron class capable of tracking
// the patron's name and ID.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryPatron
{
    private string _patronName; // Name of the patron
    private string _patronID;   // ID of the patron

    // Precondition:  None
    // Postcondition: The patron has been initialized with the specified name
    //                and ID
    public LibraryPatron(string name, string id)
    {
        PatronName = name;
        PatronID = id;
    }

    public string PatronName
    {
        // Precondition:  None
        // Postcondition: The patron's name has been returned
        get
        {
            return _patronName;
        }

        // Precondition:  None
        // Postcondition: The patron's name has been set to the specified value
        set
        {
            if (String.IsNullOrWhiteSpace(value.Trim()))                     // Checks to see if user's input is a null or empty
            {
                throw new ArgumentOutOfRangeException($"{nameof(PatronName)}", value, $"Please Enter {nameof(PatronName)}");  // throws error message if user's input is invalid
            }
            else
                _patronName = value; ;
        }
    }

    public string PatronID
    {
        // Precondition:  None
        // Postcondition: The patron's ID has been returned
        get
        {
            return _patronID;
        }

        // Precondition:  None
        // Postcondition: The patron's ID has been set to the specified value
        set
        {
            if (String.IsNullOrWhiteSpace(value.Trim()))            //// Checks to see if user's input is a null or empty
            {
                throw new ArgumentOutOfRangeException($"{nameof(PatronID)}", value, $"Please Enter A {nameof(PatronID)}");    // throws error message if user's input is invalid
            }
            else
                _patronID = value;
        }
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary patron's data on
    //                separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Name: {PatronName}{NL}ID: {PatronID}";
    }

}

