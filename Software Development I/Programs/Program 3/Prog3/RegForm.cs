// Program 3
// CIS 199-01
// Due: 10/16/2019
// Grading ID : J1743

// This application calculates the earliest registration date
// and time for an undergraduate student given their class standing
// and last name.
// Decisions based on UofL Spring 2020 Priority Registration Schedule

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Console;
using static System.Array;
namespace Prog3
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        // Find and display earliest registration time
        private void FindRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "November 4"; // 1st day of registration
            const string DAY2 = "November 5"; // 2nd day of registration
            const string DAY3 = "November 6"; // 3rd day of registration
            const string DAY4 = "November 7";  // 4th day of registration
            const string DAY5 = "November 8";  // 5th day of registration
            const string DAY6 = "November 11";  // 6th day of registration
            const float SOPHOMORE = 30; // Hours needed to be sophomore
            const float JUNIOR = 60;    // Hours needed to be junior
            const float SENIOR = 90;    // Hours needed to be senior
            char[] lastNameInitialSRJR = { 'D', 'I', 'O', 'S', 'Z' };                                                                                              // Array that holds to last name Initials Seniors and Juniors
            string[] timeBlockSrJr = { "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM", "10:00 AM" };                                                                  // Array that holds the time block Seniors and Juniors
            char[] lastNameInitialSoFr = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W'};                                                                      // Array that holds to last name Initials Sophmores and Freshman
            string[] timeBlockSoFr = { "4:00 PM", "8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM" };         // Array that holds the time block Sophmores and Freshman
            string lastNameStr;         // Entered last name
            char lastNameLetterCh;      // First letter of last name, as char
            string dateStr = "Error";   // Holds date of registration
            string timeStr = "Error";   // Holds time of registration
            float creditHours;          // Previously earned credit hours
            bool isUpperClass;          // Upperclass or not?
            bool found = false;        // searching the arrays





            lastNameStr = lastNameTxt.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name
                lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                if (float.TryParse(creditHoursTxt.Text, out creditHours) && creditHours >= 0)
                {
                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        isUpperClass = (creditHours >= JUNIOR);

                        // Juniors and Seniors share same schedule but different days
                        if (isUpperClass)
                        {
                            if (creditHours >= SENIOR)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;


                            int index = 0;                  // sets index to last value in lastNameInitialSRJR

                            while (index <= lastNameInitialSRJR.Length && !found)                                 // Setups coditions to search the lastNameInitialSRJR array
                            {
                                if (lastNameLetterCh <= lastNameInitialSRJR[index])      // Setup if a match  that is  greater than or equals to is found
                                {
                                    found = true;
                                                                                         // ends loop if match is found
                                }
                                else
                                    ++index;                                             // Decrement Counter to prevent an infinite loop
                            }

                            if (found)                                                   // If user input fits between two values within lastNameInitialSRJR array
                                timeStr = timeBlockSrJr[index];                          // Output variable is set to corresponding string within time block array

                            dateTimeLbl.Text = $"{dateStr} at {timeStr}";                // Output
                        }


                    
                    // Sophomores and Freshmen
                    else // Must be soph/fresh
                    {
                            if (creditHours >= SOPHOMORE)
                            {
                                // A-B, P-Z on day one
                                if ((lastNameLetterCh <= 'B') ||  // <= B
                                    (lastNameLetterCh >= 'P'))    // >= P
                                    dateStr = DAY3;
                                else // All other letters on next day
                                    dateStr = DAY4;
                            }
                            else // must be freshman
                            {
                                // A-B, P-Z on day one
                                if ((lastNameLetterCh <= 'B') ||  // <= B
                                    (lastNameLetterCh >= 'P'))    // >= P
                                    dateStr = DAY5;
                                else // All other letters on next day
                                    dateStr = DAY6;
                            }

                            int index = lastNameInitialSoFr.Length - 1;                // sets index to last value in lastNameInitialSoFr

                            while (index >= 0 && !found)                               // Setups coditions to search the lastNameInitialSoFr array
                            {
                                if (lastNameLetterCh >= lastNameInitialSoFr[index])    // Setup if a match  that is  greater than or equals to is found
                                    found = true;

                                else
                                    --index;                                           // Decrement Counter to prevent an infinite loop
                            }

                            if (found)                                                 // If user input fits between two values within lastNameInitialSoFr array
                                timeStr = timeBlockSoFr[index];                        // Output variable is set to corresponding string within time block array

                            dateTimeLbl.Text = $"{dateStr} at {timeStr}";                     // Output
                        


                    }

                 
                  
                }
                else // Not A-Z
                    MessageBox.Show("Make sure last name starts with a letter!");
            }
            else
                MessageBox.Show("Enter a valid number of credit hours!");
            }
             else // Empty textbox
                 MessageBox.Show("Please enter last name!");
      

        }
    }
}
