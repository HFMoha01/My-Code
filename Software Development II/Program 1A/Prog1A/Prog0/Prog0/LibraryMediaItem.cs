// Program 0
// CIS 200-01
// Grading ID: T1681
// Due: 1/12/2020

// File: LibraryMediaItem.cs
// This file creates an abstract LibraryMediaItem class capable of tracking
// the item's title, publisher, copyright year, call number,loan period, 
//  duration and checked out status.
// HAS-A with LibraryPatron




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public abstract class LibraryMediaItem: LibraryItem
    {
        private double _duration;  // The media item's duration   
        public enum MediaType {DVD, BLURAY, VHS, CD, SACD, VINYL } // The media item's medium

        // Precondition:  theCopyrightYear >= 0
        //                theLoanPeriod >= 0
        //                theDuration >= 0
        //                theTitle, theCallNumber may not be null or empty
        // Postcondition: The library media item has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, call number,  
        //                duration. The item is not checked out
        public LibraryMediaItem(string theTitle,  string thePublisher, int theCopyrightYear,
            string theCallNumber, int theLoanPeriod, double theDuration) : base(theTitle, thePublisher,
                theCopyrightYear, theCallNumber, theLoanPeriod)
        {
             
             Duration = theDuration;
             ReturnToShelf(); // Make sure media item is not checked out
        }

        public double Duration
        {
            // Precondition:  None
            // Postcondition: The duration has been returned
            get
            {
            return _duration;
            }

            // Precondition:  value >= 0
            // Postcondition: The duration has been set to the specified value
            set
            {
                if (value >= 0)
                    _duration = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Duration)}", value,
                         $"{nameof(Duration)} must be >= 0");
            }
        }

            // Abstract Property
            public abstract MediaType Medium { get; set; }


            // Precondition:  None
            // Postcondition: A string is returned representing the library media item's
            //                data on separate lines
            public override string ToString()
            {
                string NL = Environment.NewLine; // NewLine shortcut
               
                    return $"Title: {Title}{NL}Publisher: {Publisher}{NL}Copyright: {CopyrightYear}{NL}" +
                    $"Call Number: {CallNumber}{NL}Loan Period: {LoanPeriod}{NL}Duration: {Duration}";
                
            }















    }

