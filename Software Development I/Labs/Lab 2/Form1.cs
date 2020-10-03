// Lab 2
// CIS 199-01
// Due:9/15/2019
// By : J1743

// This program calculates user’s tip for meal 
// based on the price of meal user enters.
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The event handler take the price entered by user and
        // calculates three tip levels
        private void CalcTipBtn_Click(object sender, EventArgs e)
        {
            double priceMeal,       // the price of the meal entered
                   topTipRate = .15,    // the rate at which the top tip is calculated
                   midTipRate = .18,    // the rate at which the middle tip is calculated
                   btmTipRate = .20;    // the rate at which the bottom tip is calculated

            priceMeal = double.Parse(priceTxtBx.Text);

            double topTip = priceMeal * topTipRate;  // the result of the calculation will appear topTipLbl
            double midTip = priceMeal * midTipRate;  // the result of the calculation will appear midTipLbl
            double btmTip = priceMeal * btmTipRate;  // the result of the calculation will appear btmTipLbl

            topTipLbl.Text = $"{topTip:c2}";
            midTipLbl.Text = $"{midTip:c2}";
            btmTipLbl.Text = $"{btmTip:c2}";
        }
    }
}
