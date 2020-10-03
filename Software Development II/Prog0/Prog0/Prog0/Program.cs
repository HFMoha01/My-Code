// Program 0
// Grading ID : T1681
// Due Date : 01/27/2019
// Course Section: CIS200-01

// File: Program.cs
// This file creates a simple test application class that creates
// an array of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2011, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2001, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1986, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            2019, "ZZ24 4F");  // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2004, "AE842 7A"); // 5th test book

        // LibraryBook[] theBooks = { book1, book2, book3, book4, book5 }; // Test array of books
        
        //Creates a List of a books
        List<LibraryBook> theBooks = new List<LibraryBook>();

         theBooks.Add(book1);    // adds book1 to the list
         theBooks.Add(book2);    // adds book1 to the list
         theBooks.Add(book3);    // adds book1 to the list
         theBooks.Add(book4);    // adds book1 to the list
         theBooks.Add(book5);    // adds book1 to the list


        WriteLine("Original list of books");
        WriteLine("----------------------");
        PrintBooks(theBooks);
        Pause();

        LibraryPatron patron1 = new LibraryPatron("Harry", "H00001");   //Creates 1st Library Patron
        LibraryPatron patron2 = new LibraryPatron("Larry", "L00001");   //Creates 2nd Library Patron
        LibraryPatron patron3 = new LibraryPatron("Moe", "M00001");     //Creates 3rd Library Patron
       
        
        // Make changes
        book1.CheckOut(patron1);
        book2.Publisher = "Borrowed Books";
        book2.CheckOut(patron2);
        book3.CheckOut(patron2);
        book4.CheckOut(patron1);
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(patron3);
        // book5.CopyrightYear = -2024; //Test 




        WriteLine("After changes");
        WriteLine("-------------");
        PrintBooks(theBooks);
        Pause();

       // Return the books
        book1.ReturnToShelf();
        book2.ReturnToShelf();
        book3.ReturnToShelf();
        book4.ReturnToShelf();
        book5.ReturnToShelf();

        WriteLine("After returning the books");
        WriteLine("-------------------------");
        PrintBooks(theBooks);
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List<LibraryBook> books)
    {
        foreach (LibraryBook b in books)
        {
            WriteLine(b);
            WriteLine();
        }
    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        WriteLine("Press Enter to Continue...");
        ReadLine();

        Clear(); // Clear screen
    }
}
