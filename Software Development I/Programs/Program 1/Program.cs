// Program 1
// CIS 199-01
// Due:9/23/2019
// Grading ID : J1743

// This program calculates total number of gallons of paint 
// needed to paint room based on the user inputs.
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // the variables and constants that will be needed in order to calculate the total
            // gallons of paint needed to paint a room


            double totWalLgh,   // Total length of the walls in feet
                   totHghtLgh,  // Total height of the walls in feet
                   minGals,     // Minimum gallons needed to pain the room
                   totSqPt;     // Total sqft of paint needed

            int totDoors,    // Total number of doors (interger non-negative)
                totWinds,    // Total number of windows (interger non-negative)
                totCoatsPnt, // Total number of coats of paint
                totGalNd;    // Total gallons needed (rounded)

            const int DoorSqFt = 21;    // The constant in sq ft used to subtract the area a door occupies
            const int WindowSqFt = 12; // The constant in sq ft used to subtract the area a window occupies 
            const int SqFtPtCn = 400;  // Represent the area in sqft each paint can should cover


            //Inputs the user will enter
            WriteLine("Welcome to the Handy-Dandy Paint Estimator \n");
            WriteLine("");

            Write("Enter the total length of all walls (in feet): ");
            totWalLgh = double.Parse(ReadLine());

            Write("Enter the height of the walls (in feet): ");
            totHghtLgh = double.Parse(ReadLine());

            Write("Enter the number of doors (non-neg int): ");
            totDoors = int.Parse(ReadLine());

            Write("Enter the number of windows (non-neg int): ");
            totWinds = int.Parse(ReadLine());

            Write("Enter the number of coats of paint (non-neg int): ");
            totCoatsPnt = int.Parse(ReadLine());


            // Calculation used to determine amount gallons of paint necessary

            totSqPt = totWalLgh * totHghtLgh;          // square footage
            totSqPt -= totDoors * DoorSqFt;            // Removes the sqft for the doors
            totSqPt -= totWinds * WindowSqFt;          // Removes the sqft for the windows
            totSqPt *= totCoatsPnt;                    // Adds the # of coats required
            minGals = totSqPt / SqFtPtCn;              // Minimum Gallons needed
            totGalNd = (int)Math.Ceiling(minGals);     // Round to largest whole number

            // Output the calculations 

            WriteLine($"You need a minimum of {minGals:F1} gallons of paint");
            WriteLine($"You will need to buy {totGalNd} gallons, though");














        }
    }
}
