// Lab 7
// CIS 199-01
// Due:11/10/2019
// Grading ID : J1743

// This GUI program is designed  to calculate the present value that you'd need to invest today to earn the
// desired amount of money in the future, when the user enters the future value desired, the interest rate per annum 
// and numbers years the user wants the return in
// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using static System.Array;

namespace Lab7
{
    public partial class NetPresentValueCalcForm : Form
    {
        public NetPresentValueCalcForm()
        {
            InitializeComponent();
        }

        // Pre Condition: User must hits enter or clicks the button 
        // Post Condition: Takes the user's inputs and if they are valid calculates the present value
        private void CalcButton_Click(object sender, EventArgs e)
        {
            double futureValue;                  // Variable represents the future value the user inputs
            double annualRateOfInterest;         // Variable represents the annual rate interest the user inputs
            double presentValue;                 // Variable that represents the output
            int numOfYears;                      // Variable represents the number of years the user inputs


            if (double.TryParse(futureValueTxtBx.Text, out futureValue))                                 // User input Validation
            {
                if (double.TryParse(annualIntRateTxtbx.Text, out annualRateOfInterest))                  // User input Validation
                {
                    if(int.TryParse(numOfYearsTxtbx.Text, out numOfYears))                               // User input Validation   
                    {
                       presentValue = CalcPresentValue(futureValue, annualRateOfInterest, numOfYears);   //  calling the method 

                        presValueOutptLbl.Text = ($"{presentValue:C2}");                                 // Displays the results of  the called method       


                    }

                    else
                        MessageBox.Show("Error!! Please enter valid interger values only !!");           // Error Message for invalid input 



                }

                else
                    MessageBox.Show("Error!! Please enter interest rate in decimal format only");        // Error Message for invalid input    


            }

            else
                MessageBox.Show("Error!! Please enter numeric values only");                             // Error Message for invalid input 



        }

        // Pre Condition: futureVal and intRate must be doubles and intRate must be in decinal format. 
        // years optimized to be an interger
        // Post Condition: The method will return a double to any calls.
        private static double CalcPresentValue(double futureVal, double intRate, int years)       // This the method that will calculate the present value
        {
            double presValue;                                                                     // This variable that represents the output of the Method

            presValue = futureVal / (Math.Pow((1 + intRate), years));                             // Calculates the Present Value

            return presValue;                                                                     // returns  the Present Value

        }






        
    }
}
