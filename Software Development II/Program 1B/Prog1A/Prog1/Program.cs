// Program 1A
// CIS 200-01
// Due: 2/13/2020
// By: T1681

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;
using static System.Console;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested demonstrating polymorphism
    //                in CalcLateFee()
    public static void Main(string[] args)
    {
        const int DAYSLATE = 14; // Number of days late to test each object's CalcLateFee method
        const int LOANUPDATE = 7; // Number of days to increase loan period

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryMovie("   Andrew's Super-Duper Movie   ", "   UofL Movies   ", 2019, 7,
            "MM33 2D", 92.5, "   Andrew L. Wright   ", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG)); // Trims?
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2020, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2018, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2017, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMovie("the film", "H", 2007, 14, "A12345", 100, "MR.A", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.R));
        items.Add(new LibraryMusic("The Music Album", "UofL Music", 2007, 14, "B12345", 120.5, "The Who", LibraryMediaItem.MediaType.VINYL, 16));
        items.Add(new LibraryJournal("Journal of F# Goodness", "UofL Journals", 2018, 14, "JJ12 7M", 2, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2017, 14, "MA53 9A", 1, 7));
        items.Add(new LibraryBook("The Hasan BooK", "UofL Publisher", 1989, 14, "ABCDEF", "Hasan Mohammad"));



        // Add patrons
        patrons.Add(new LibraryPatron("Ima Reader", "12345"));
        patrons.Add(new LibraryPatron("Jane Doe", "11223"));
        patrons.Add(new LibraryPatron("   John Smith   ", "   654321   ")); // Trims?

        Console.WriteLine("List of items at start:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        Pause();

        // Check out some items
        items[0].CheckOut(patrons[0]);
        items[2].CheckOut(patrons[2]);
        items[4].CheckOut(patrons[1]);
        items[8].CheckOut(patrons[2]);
        items[5].CheckOut(patrons[1]);

        WriteLine("List of items after checking some out:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        Pause();


        //Print out list of only checked out Items
        var checkoutSort =
        from item in items
        where item.IsCheckedOut() != false
        select item;
        int count = checkoutSort.Count();
        WriteLine("Checkout List");
        WriteLine("--------------\n");

        foreach (var item in checkoutSort)
        {
            WriteLine(item.Title);
            WriteLine("-------------------------");
            WriteLine(item);
            WriteLine();

        }
        WriteLine($" Total Checked out : {count}\n");
        Pause();


        //Print out of checked out media items
        var fitleredCheckoutSort =
            from item in checkoutSort
            where item is LibraryMediaItem
            select item;

        WriteLine("Library Media Item Checkout List");
        WriteLine("---------------------------------\n");
        foreach (var item in fitleredCheckoutSort)
        {
            WriteLine(item.Title);
            WriteLine("------------------");
            WriteLine(item);
            WriteLine();
        }
        Pause();


        // Magazine Distinct Printout
        var magSort =
            from item in items
            where item is LibraryMagazine
            select item;

        WriteLine("Library Magazine List");
        WriteLine("-----------------------\n");
        foreach (var item in magSort.Distinct())
        {
            WriteLine(item.Title);
            WriteLine("-----------------");
            WriteLine(item);
            WriteLine();
        }
        Pause();




        //Header Display for  Late fees
        WriteLine($"Calculated late fees after {DAYSLATE} days late:\n");
        WriteLine($"{"Title",30} {"Call Number",11} {"Late Fee",8}");
        WriteLine("------------------------------ ----------- --------");


        // Calculate and display late fees for each item
        foreach (LibraryItem item in items)
            WriteLine($"{item.Title,30} {item.CallNumber,11} {item.CalcLateFee(DAYSLATE),8:C}");
        Pause();


        //Return Items

        for (int x = 0; x < items.Count(); x++)
        {
            items[x].ReturnToShelf();

        }

        // Print out of List After 
        Console.WriteLine("List of items at after returning items:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        WriteLine($" Total Checked out : {checkoutSort.Count()}\n");
        Pause();


        //Loop to change loan period

        WriteLine("Adding days to the loan Period");
        WriteLine("-------------------------------\n");
        for (int x = 0; x < items.Count(); x++)
        {
            if (items[x] is LibraryBook)
            {
                WriteLine($"Title: {items[x].Title}");
                WriteLine("-----------------------------");
                WriteLine($"The Loan Period: {items[x].LoanPeriod}");
                items[x].LoanPeriod += LOANUPDATE;
                WriteLine($"The New Loan Period: {items[x].LoanPeriod}\n");
            }
        }
        Pause();


        // Last PrintOut
        Console.WriteLine("List of items at end:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        Pause();


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