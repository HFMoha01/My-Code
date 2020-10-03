// Grading Id : T1681
// Lab 1
// Due Date : 02/05/2020
// CIS 200-01
//
//
// This program explores the use of LINQ to query an array of objects.
// whose class is named invoice

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Lab1
{
    public class LinqTest
    {
        public static void Main(string[] args)
        {
            // initialize array of invoices
            Invoice[] invoices = { 
                new Invoice( 83, "Electric sander", 7, 57.98M ), 
                new Invoice( 24, "Power saw", 18, 99.99M ), 
                new Invoice( 7, "Sledge hammer", 11, 21.5M ), 
                new Invoice( 77, "Hammer", 76, 11.99M ), 
                new Invoice( 39, "Lawn mower", 3, 79.5M ), 
                new Invoice( 68, "Screwdriver", 106, 6.99M ), 
                new Invoice( 56, "Jig saw", 21, 11M ), 
                new Invoice( 3, "Wrench", 34, 7.5M ) };

            // constants to be used in range limits 
                const decimal LOWLIMIT = 200;  
                const decimal HIGHLIMIT = 500;        
           


            // Display original array
            WriteLine("Original Invoice Data\n");
            WriteLine("P.Num Part Description     Quant Price"); // Column Headers
            WriteLine("----- -------------------- ----- ------");

            foreach (var inv in invoices)
                WriteLine(inv);
                WriteLine();



            // a. Sort invoices by PartDescription
                var descriptSort =                          //variable to hold the sort by Part Description
                                   from invoice in invoices
                                   orderby invoice.PartDescription
                                   select invoice;


            //Displays array sorted by by PartDescription

            WriteLine("");
            WriteLine("Sort invoices by Part Description\n");
            WriteLine("P.Num Part Description     Quant Price"); // Column Headers
            WriteLine("----- -------------------- ----- ------");

            foreach (var inv in descriptSort)       
                WriteLine(inv);
                WriteLine();


            // b. Sort invoices by Pricing
                var priceSort =                //variable to hold the sort by price
                                from invoice in invoices
                                orderby invoice.Price
                                select invoice;


            // Displays the array sorted by price

            WriteLine("");
            WriteLine("Sort invoices by Price\n");
            WriteLine("P.Num Part Description     Quant Price"); // Column Headers
            WriteLine("----- -------------------- ----- ------");

            foreach (var inv in priceSort)
                WriteLine(inv);
                WriteLine();


            // c. Sort invoices by PartDescription and Quantity 
                var quantSorted =                                //variable to hold the sort by Quantity
                                    from invoice in invoices
                                    orderby invoice.Quantity
                                    select new { invoice.PartDescription, invoice.Quantity};  // creates a new object of an anonymous type based the properties PartDescription and Quantity

            // Displays the query for that selects for PartDescription and Quantity 
            // sorted by quantity

            WriteLine("");
            WriteLine("Displays Invoice's Part Description and Quantity \n");
            WriteLine("Part Description     Quantity"); // Column Headers
            WriteLine("-----------------    ---------");
            
            

            foreach (var inv in quantSorted)
                WriteLine($"{inv.PartDescription, -20} {inv.Quantity, -6}");
                WriteLine();


            // d. Sort invoices by PartDescription and Invoice value
            var valueSorted =                                //variable to hold the sort by Quantity
                                    from invoice in invoices
                                    let  total = invoice.Price * invoice.Quantity                  //new range variable to store the calculation           
                                    orderby total
                                    select new { invoice.PartDescription, InvoiceTotal = total };  // creates a new object of an anonymous type based the properties PartDescription and range variable total


            // Displays array by PartDescription and Invoice value and sorted by Invoice value

            WriteLine("");
            WriteLine("Invoices by Part Description and Invoice Total \n");
            WriteLine("Part Description     Invoice Total"); // Column Headers
            WriteLine("-----------------    -------------");

            foreach (var inv in valueSorted)
                WriteLine($"{inv.PartDescription, -20} {inv.InvoiceTotal, -6:C}");
                WriteLine();


            // e. InvoiceTotals in the range $200 to $500
          var valueSortFilter =                                //variable to hold the filtering of the sort
                                from invoice in valueSorted
                                where (invoice.InvoiceTotal >= LOWLIMIT) && (invoice.InvoiceTotal <= HIGHLIMIT)     //boolean test to determine the range
                                select invoice;


            // Displays array by PartDescription and Invoice value and  Invoice value filtered between 200 and 500


            WriteLine("");
            WriteLine("Invoices by Part Description and Invoice Total filtered between 200 and 500 \n");
            WriteLine("Part Description     Invoice Total"); // Column Headers
            WriteLine("-----------------   -------------");

            foreach (var inv in valueSortFilter)
                WriteLine($"{inv.PartDescription,-20} {inv.InvoiceTotal,-6:C}");
                WriteLine(); 

        }
    }
}
