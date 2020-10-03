// Lab 3
// CIS 199-01
// Due:9/22/2019
// By : J1743

// This program calculates a sphere's diameter, 
// surface area, and volume based on the radius user enters.
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

using System;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class SphereCalcForm : Form
    {
        public SphereCalcForm()
        {
            InitializeComponent();
        }
        // The event handler take the radius entered by user and
        // calculates the diameter, surface area, and volume
     
        private void calcBtn_Click(object sender, EventArgs e)
        {
            double radius,    // User entered radius of the sphere
                               dia,       // the diameter of the sphere 
                               surfArea,  // the surface area of the sphere
                               volume;    // the volume of the sphere

            // Convert input into a decimal

            radius = double.Parse(radTxtBx.Text);

            // Calculate the diameter of sphere

            dia = 2 * radius;

            // Calculate the surface area of the sphere

            surfArea = 4.00 * Math.PI * Math.Pow(radius, 2);

            // Calculate the volume of sphere

            volume = (4.00 * Math.PI * Math.Pow(radius, 3)) / 3.00;

            // Display the calculations 

            diaOutptLbl.Text = $"{dia:f2}";
            surfAreaOutptLbl.Text = $"{surfArea:f2}";
            volOutptLbl.Text = $"{volume:f2}";

        }

      
    }
}
