// Lab 4
// CIS 199-01
// Grading ID: J1743
// Due : 9/29/2019
//
// This progam makes college admission desicion for a student
// Based on the critiera of the student's High School GPA and Admission Test Score
// A student may gain admission if their scores and gpa satisfy either
// A grade point average of 3.0 or higher and an admission test score of at least 60
// or
// A grade point average of less than 3.0 and an admission test score of at least 80
// If student's score and GPA doesn't fit either critieria, they are rejected.
// This program all keeps a running total of those accepted and those rejected
//
//
// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class AdmissionDecisionForm : Form
    {
        private uint acceptCounter = 0,            //   This variable will be used to keep a running total of the accepted 
                     rejectCounter = 0;            //   This variable will be used to keep a running total of the accepted
        private byte testScore;                    //   This Variable represents the user entered testScore 
        private float gPA;                         //   This variable represents the user enter GPA

        
      
        public AdmissionDecisionForm()
        {
            InitializeComponent();
            

        }
         
        //  This event handler takes user's inputted GPA and Test score
        //  and then determines admission status
        
        private void DecBtn_Click(object sender, EventArgs e)
        {
            
            

            if (float.TryParse(gpaInTxtBx.Text, out gPA) && (gPA >= 1.0 && gPA <= 4.0))    // This ensures the User enters a valid GPA within the accepted range 

            {

                if (byte.TryParse(testScorInTxtBx.Text, out testScore) && (testScore <= 100 && testScore >= 0))  // This ensures User enters valid Test Score within the accepted range
                {

                    if (gPA >= 3.0 && testScore >= 60 || gPA <= 3.0 && testScore >= 80)   // This Boolean Statement sets the conditions for Acceptance

                    {
                        admissOutptLbl.Text = "Accepted";                                 // If User's input does fall within the criteria, Accepted is displayed in the admission output label                      
                        acceptCounter++;                                                  // This adds a value of 1 to the running total of accepted every time the event determines the student is accepted  
                        acptOutptLbl.Text = $"{acceptCounter:f0}";                        // This displays the running total of accepted

                    }


                    else                                                                  // If the students GPA and Test Score do not fit the criiteria this is action that wil be taken
                    {
                        admissOutptLbl.Text = "Rejected";                                 // If User's input  does not fit the criteria, rejected is displayed in admission output label
                        rejectCounter++;                                                  // This adds a value of 1 to the running total of rejected every time the event determines the student is rejected
                        rejectOutptLbl.Text = $"{rejectCounter:f0}";                      // This displays the running total of the rejected 

                    }


                }

                else                                                                     // If User enters an invalid Test Score 

                {
                    MessageBox.Show("Enter Valid Test Score ");                          // This Displays a dialog box telling the user to enter valid test score   

                }



            }

            else                                                                         // If User enters an invalid GPA 
            {
                MessageBox.Show("Enter Valid Test GPA");                                 // This Displays a dialog box telling the user to enter valid GPA score 
            }







        }
    }
}


    


