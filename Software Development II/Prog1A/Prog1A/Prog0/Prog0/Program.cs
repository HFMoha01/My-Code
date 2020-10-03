// Program 0
// CIS 200-01
// Grading ID: T1681
// Due: 1/12/2020

// File: Program.cs
// This file creates a simple test application class that creates
// an array of LibraryItem and associated classes objects and tests them.

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
        LibraryMovie movie1 = new LibraryMovie("the movie", "B", 1999, "a1234", 10, 120, "MR.T", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.PG13);
        LibraryMovie movie2 = new LibraryMovie("the film", "H", 2007, "ghghg1", 14, 100, "MR.A", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.R);
        LibraryJournal journal1 = new LibraryJournal("Scifi", "SCE", 2019, "f12367", 15, 201, 3, "chemistry", "uofl");
        LibraryMusic music1 = new LibraryMusic("the music", "musicpub", 1976, "z120", 12, 120, LibraryMediaItem.MediaType.CD, "the who", 12);
        LibraryMagazine mag1 = new LibraryMagazine("The Mag", "MagPub", 1989, "12ACD", 30, 2, 15);

        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G", 10);  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2000, "AG773 ZF", 10); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T", 10); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            2016, "ZZ24 4F", 10);    // 4th test book
        LibraryBook book5 = new LibraryBook("    The Big Book of Doughnuts   ", "   Homer Simpson   ", "   Doh Books   ",
            2001, "   AE842 7A   " , 10); // 5th test book - Trims?

        LibraryPatron patron1 = new LibraryPatron("Ima Reader", "123456"); // 1st test patron
        LibraryPatron patron2 = new LibraryPatron("Jane Doe", "112233");  // 2nd test patron
        LibraryPatron patron3 = new LibraryPatron("   John Smith   ", "   654321   "); // 3rd test patron - Trims?

        List<LibraryBook> theBooks = new List<LibraryBook> { book1, book2, book3, book4, book5 }; // Test list of books

        //Library Movie test
        WriteLine("Testing the LibraryMovie class");
        WriteLine("--------------------------------");
        WriteLine(movie1);
        WriteLine($"Late Fee: {movie1.CalcLateFee(15):C}");
        WriteLine($"Late Fee: {movie1.CalcLateFee(45):C}\n");
        WriteLine("_____________________________________");
        WriteLine(movie2);
        WriteLine($"Late Fee: {movie2.CalcLateFee(15):C}");
        WriteLine($"Late Fee: {movie2.CalcLateFee(45):C}");
        Pause();

        //Library Journal test
        WriteLine("Testing the LibraryJournal class");
        WriteLine("--------------------------------");
        WriteLine(journal1);
        WriteLine($"Late Fee: {journal1.CalcLateFee(15):C}");
        WriteLine($"Late Fee: {journal1.CalcLateFee(45):C}");
        Pause();

        //Library Music test
        WriteLine("Testing the LibraryMusic class");
        WriteLine("--------------------------------");
        WriteLine(music1);
        WriteLine($"Late Fee: {music1.CalcLateFee(15):C}");
        WriteLine($"Late Fee: {music1.CalcLateFee(45):C}");
        Pause();

        //Library Magazine test
        WriteLine("Testing the LibraryMagazine class");
        WriteLine("--------------------------------");
        WriteLine(mag1);
        WriteLine($"Late Fee: {mag1.CalcLateFee(15):C}");
        WriteLine($"Late Fee: {mag1.CalcLateFee(45):C}");
        Pause();


        WriteLine("Original list of books");
        WriteLine("----------------------");
        PrintBooks(theBooks);
        Pause();

        // Make changes
        book1.CheckOut(patron1);
        book2.Publisher = "Borrowed Books";
        try
        {
            book2.CheckOut(null); // Attempt invalid patron
        }
        catch (ArgumentNullException ex)
        {
            WriteLine("Caught invalid patron sent to CheckOut");
            WriteLine(ex.Message);
        }
        book3.CheckOut(patron2);
        book4.CallNumber = "    AB123 4A    ";
        book5.CheckOut(patron3);
        try
        {
            book5.CopyrightYear = -1234; // Attempt invalid year
        }
        catch (ArgumentOutOfRangeException ex)
        {
            WriteLine("Caught invalid CopyrightYear set:");
            WriteLine(ex.Message);
            WriteLine("Resetting to default year");
            book5.CopyrightYear = book5.DEFAULT_YEAR;
        }

        WriteLine("After changes");
        WriteLine("-------------");
        PrintBooks(theBooks);
        Pause();

        // Return the books
        book1.ReturnToShelf();
        book3.ReturnToShelf();
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
