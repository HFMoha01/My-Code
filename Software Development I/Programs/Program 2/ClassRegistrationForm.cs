// Program 2
// CIS 199-01
// Due:10/16/2019
// Grading ID : J1743

// This GUI program is designed to give a UofL student user Spring 2020 registratin window
// Once theuser has entered the first initial of their last name and their credit hours 


//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class ClassRegistrationForm : Form
    {
        public ClassRegistrationForm()
        {
            InitializeComponent();
        }


        //  This event handler takes user's inputs
        //  and then determines their registration window for undergraduates


        private void Calcbttn_Click(object sender, EventArgs e)
        {
            const float SENIOR_HRS = 90;          // This constant used represent senior hours requirement
            const float JUNIOR_HRS = 60;          // This constant used represent junior hours requirement
            const float SOPH_HRS = 30;            // This constant used represent sophomore hours requirement
            const string TIME_1 = "8:30 AM";      // First available time slot
            const string TIME_2 = "10:00 AM";     // Second available time slot
            const string TIME_3 = "11:30 AM";     // Third available time slot
            const string TIME_4 = "2:00 PM";      // Fourth available time slot
            const string TIME_5 = "4:00 PM";      // Fifth available time slot
            const string DATE_SENIOR = "Nov 4";   // First Day Senior can register
            const string DATE_JUNIOR = "Nov 5";   // First Day Junior can register
            const string DATE_SOPH_1 = "Nov 6";   // First Day the first batch Sophomore can register
            const string DATE_SOPH_2 = "Nov 7";   // First Day the second batch Sophomore can register
            const string DATE_FRESH_1 = "Nov 8";  // First Day the First batch Freshman can register 
            const string DATE_FRESH_2 = "Nov 11"; // First Day the second batch Sophomore can register
            string initial = initialTxtBx.Text;   // User entered first initial of the Last Name
            char firInitial;                      // User entered first initial of the Last Name converted to a char type
            float credHrs;                        // User entered credit hours




            if (char.TryParse(initial, out firInitial) && char.IsLetter(firInitial))   // This ensures user input for Last name Initial is valid input & converts it to a CHAR type
            {

                if (float.TryParse(credHrsTxtBx.Text, out credHrs))                    // This converts user's credit hours input into a float type 
                {
                    firInitial = Char.ToLower(firInitial);                             // This converts user's last name initial in the lowercase char of that letter

                    if (credHrs >= SENIOR_HRS)                                         // Determines if user is a Senior for Date
                    {
                        dateLbl.Text = DATE_SENIOR;                                    // Output for the date if user is a Senior
                    }
                      else
                         dateLbl.Text = DATE_JUNIOR;                                   // Output for the date if user is a Junior

                if (credHrs >= JUNIOR_HRS)                                             // This determines if user is a Senior or Junior     
                {

                   if (firInitial <= 'd')                                              // Determines if  Junior/Senior user inital is A-D 
                     timeLbl.Text = TIME_3;                                            // The time output if it meets the criteria

                     else

                     {
                         if (firInitial <= 'i')                                        // Determines if  Junior/Senior user inital is E-I 

                         {

                           timeLbl.Text = TIME_4;                                      // The time output if it meets the criteria

                         }
                           else

                           {

                               if (firInitial <= 'o')                                  // Determines if  Junior/Senior user inital is J-O 

                               { 
                                 timeLbl.Text = TIME_5;                                // The time output if it meets the criteria

                               }

                                 else
                                 {
                                     if (firInitial <= 's')                            // Determines if  Junior/Senior user inital is P-S 

                                     {
                                        timeLbl.Text = TIME_1;                         // The time output if it meets the criteria 

                                     }

                                       else
                                           timeLbl.Text = TIME_2;                      // The time output if  Junior/Senior user inital is T-Z  

                                 }
                           }
                     }

                }

                    else
                    {

                        if (credHrs < JUNIOR_HRS)

                        {
                            if (firInitial <= 'b' || (firInitial >= 'm' && firInitial <= 'o'))                      // Determines if  Freshman/Sophomore user inital is A-B or M-O 
                                timeLbl.Text = TIME_5;                                                              // The time output if it meets the criteria

                            else

                                if (firInitial <= 'd' || (firInitial >= 'p' && firInitial <= 'q'))                  // Determines if  Freshman/Sophomore user inital is C-D or P-Q 

                                         timeLbl.Text = TIME_1;                                                     // The time output if it meets the criteria

                                  else 

                                      if (firInitial <= 'f' || (firInitial >= 'r' && firInitial <= 's'))            // Determines if  Freshman/Sophomore user inital is E-F or R-S
                                             timeLbl.Text = TIME_2;                                                 // The time output if it meets the criteria

                                         else

                                             if (firInitial <= 'i' || (firInitial >= 't' && firInitial <= 'v'))     // Determines if  Freshman/Sophomore user inital is G-I or T-V 

                                             {                                                                                
                                                timeLbl.Text = TIME_3;                                              // The time output if it meets the criteria

                                             }

                                                else                                                                             

                                                    timeLbl.Text = TIME_4;                                          // The time output if if  Freshman/Sophomore user inital is W-Z or J-L   

                        }
                        

                              if (credHrs >= SOPH_HRS)                                                              // Determines if user is Sophomore

                              {
                                   if (firInitial >= 'p' || firInitial <= 'b')                                      // Determines for the date if user initial is between P-Z or A_B

                                       dateLbl.Text = DATE_SOPH_1;                                                  // Output for the date if it fits that criteria

                                    else

                                       dateLbl.Text = DATE_SOPH_2;                                                  // Output for the date if user initial is C-O
                              }


                                else

                                    if (credHrs < SOPH_HRS)                                                         // Determines if user is freshman  

                                    {
                                      if (firInitial >= 'p' || firInitial <= 'b')                                   // Determines for the date if user initial is between P-Z or A_B

                                         dateLbl.Text = DATE_FRESH_1;                                               // Output for the date if it fits that criteria

                                        else
                                
                                            dateLbl.Text = DATE_FRESH_2;                                            // Output for the date if user initial is C-O


                                    }

                    }

                }

                 else
                     MessageBox.Show("Enter valid number of credit hours");             // This message appears if user input for credit hours is not a valid input
            }
        

             else
                 MessageBox.Show("Error please enter first initial of last name");      // This message appears if user input for Last name initial is not a valid input


        }
        
    }
}
