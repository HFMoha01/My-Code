// Program 4
// CIS 199-01
// Due: 12/03/2019
// Grading ID : J1743

//  This application  Each LibaryBook object will keep track of some basic information: 
//  the book's title, author, publisher, 
//  copyright year, call number, and checked out status. 

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creates 5 new objects of librarybook class

            LibraryBook book_1 = new LibraryBook("Dune", "Frank Herbert", "Penguin Books", 1965, "00000");
            LibraryBook book_2 = new LibraryBook("Dune Messiah", "Frank Herbert", "Penguin Books", 1969, "11111");
            LibraryBook book_3 = new LibraryBook("Childern of Dune", "Frank Herbert", "Penguin Books", 1976, "22222");
            LibraryBook book_4 = new LibraryBook("God Emperor of Dune", "Frank Herbert", "Penguin Books", 1981, "33333");
            LibraryBook book_5 = new LibraryBook("Heretics of Dune", "Frank Herbert", "Penguin Books", 1984, "44444");

            // Array that stores the objects
            LibraryBook[] bookInventory = { book_1, book_2, book_3, book_4, book_5 }; 

            //Printout of the inventory
            WriteLine("Current Book Inventory and Status" + Environment.NewLine);   // displays a message
            PrintOut(bookInventory);      // calls Printout method display current inventory and relevant information


            //changing either the book's publisher or call number or check out the book 
            book_1.CheckOut();
            book_2.CheckOut();
            book_3.Publisher = "Hasan's Books";
            book_4.CallNumber = "1234";
            book_5.Publisher = "Mohammad's Books";

            // Printout of the inventory
            WriteLine("Updated Book Inventory and Status #1" + Environment.NewLine);   // displays a message
            PrintOut(bookInventory);        // calls Printout method display current inventory and relevant information


            //The books returning  
            book_1.ReturnToShelf();
            book_2.ReturnToShelf();

            //Printout of the inventory
            WriteLine("Updated Book Inventory and Status #2" + Environment.NewLine);   // displays a message
            PrintOut(bookInventory);        // calls Printout method display current inventory and relevant information



        }



        //Precondition: a valid array of LibraryBook objects must be used
        //Postcondition: It will print out current inventory of books and associated information
        public static void PrintOut( LibraryBook [] bookarray )
        {
            for(int x = 0; x < bookarray.Length; ++x)
            {
                WriteLine($"Book #:{x + 1}");
                WriteLine($"{bookarray[x]}");


            }
            WriteLine("End of List");
            WriteLine("");

        }

    }

}   

