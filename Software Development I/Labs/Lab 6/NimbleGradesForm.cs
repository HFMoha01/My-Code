// Lab 6
// CIS 199-01
// Due:10/27/2019
// Grading ID : J1743

// This GUI program is designed to allw user to enter a student's 
// numbers of words typed per minute (wpm) in a numeric format and outputs the student's grade 



// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Array;
using static System.Console;
namespace Lab_6
{
    public partial class NimbleGradesForm : Form
    {
        public NimbleGradesForm()
        {
            InitializeComponent();
        }

        // This event handler takes user's  wpm input and outputs the grade


        private void EnterBtn_Click(object sender, EventArgs e)
        {


            double wrdsPerMin;                                      // User's input
            int[] wordsPerMinuteRange = { 0, 16, 31, 51, 76 };      // Array that holds words per minute range begin points    
            string [] letterGrade = { "F", "D", "C", "B", "A" };    // Array that holds to letters grade
            bool found = false;                                     // used to search index
            string userGrad = "";                                   // user's grade output


            if (double.TryParse(wpmTxtBx.Text, out wrdsPerMin))     // Takes user's input and turns it to double

            {
                int index = wordsPerMinuteRange.Length - 1;         // sets index to last value in wordsPerMinuteRange since lower limits are all values
                                                            
                while (index >= 0 && !found)                        // Setups coditions to search the WordsPerMinuteRange array
                {
                    if (wrdsPerMin >= wordsPerMinuteRange[index])   // Setup if a match  that is  greater than or equals to is found
                        found = true;
                    else
                        --index;                                    // Decrement Counter to prevent an infinite loop
                }

                if (found)                                         // If user input fits between two values within WordsPerMinuteRange array
                    userGrad = letterGrade[index];                 // Output variable is set to corresponding string within letterGrade array

                gradeOutptLbl.Text = userGrad;                     // Output
            }

            else
            MessageBox.Show("Please enter valid input!!");        // Error Message







        }
    }
}
