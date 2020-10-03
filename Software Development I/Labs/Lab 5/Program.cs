// Lab 5
// CIS 199-01
// Grading ID: J1743
// Due : 10/20/2019
//
//
// this program makes 4 different patterns of asterisks(*)
// using a series of nested statements
//
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 



namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MAX_ROWS = 10;                     // This variable is used as the Sentinel Variable for the loops
            const int MIN_ROWS = 1;                      // This variable is used as the Sentinel Variable for the loops



            WriteLine("Pattern A \n");                   // Outputs the name of the pattern

            for (int row = 1; row <= MAX_ROWS; row++)    // This statement loop acts a Sentinel for nested loop
            {
                for (int star = 1; star <= row; star++)  // This nested loop statement outputs the asterisks(*) for the pattern
                    Write("*");
                    WriteLine("");
                   
            }

            WriteLine();
            WriteLine("Pattern B \n");                     // Outputs the name of the pattern  

            for (int row = 1; row <= MAX_ROWS; row++)      // This statement loop acts a Sentinel for nested loop  
            {
                for (int star = 10; star >= row; star--)   // This nested loop statement outputs the asterisks(*) for the pattern
                    Write("*");
                    WriteLine("");

            }

            WriteLine();
            WriteLine("Pattern C \n");                                        // Outputs the name of the pattern 

            for (int row = MAX_ROWS; row >= MIN_ROWS; row--)                  // This statement loop acts a Sentinel for nested loop
            {
                for (int space = 1; space <= MAX_ROWS - row; space++)         // This nested loop determiner output of spaces
                {
                    Write(" ");
                }

                for (int star = 1; star <= row; star++)                       // This nested loop statement outputs the asterisks(*) for the pattern

                    Write("*");
                    WriteLine("");


            }

            WriteLine();
            WriteLine("Pattern D \n");                                        // Outputs the name of the pattern 

            for (int row = 1; row <= MAX_ROWS; row++)                         // This statement loop acts a Sentinel for nested loop
            {
                for(int space = 1; space <= MAX_ROWS - row; space++)          // This nested loop determiner output of spaces
                {
                    Write(" ");
                }

                for (int star = 1; star <= row; star++)                      // This nested loop statement outputs the asterisks(*) for the pattern
                
                    Write("*");
                    WriteLine("");
                

            }

        }

    }
}
 