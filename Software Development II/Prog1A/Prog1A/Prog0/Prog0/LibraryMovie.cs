// Program 0
// CIS 200-01
// Grading ID: T1681
// Due: 1/12/2020

// File: LibraryMovie.cs
// This file creates an  LibraryMovie class capable of tracking
// the item's title, director, publisher, copyright year, call number,loan period, 
//  duration, medium, rating and checked out status.
// HAS-A with LibraryPatron


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class LibraryMovie: LibraryMediaItem
    {
            public enum MPAARatings { G, PG, PG13, R, NC17, U }  //movie's rating
            private string _director;    // the movie's director           
            private MediaType _medium;   // the movie's medium 
            private MPAARatings _rating; // the movie's rating

         // Precondition:  theCopyrightYear >= 0
         //                theLoanPeriod >= 0
         //                theDuration >= 0
         //                theTitle,theDirector, and theCallNumber may not be null or empty
         // Postcondition: The library movie item has been initialized with the specified
         //                values for title, publisher, copyright year, loan period, call number,  
         //                duration. The item is not checked out
                public LibraryMovie(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber,
                       int theLoanPeriod, double theDuration, string theDirector, MediaType theMedium, MPAARatings theRating) : base(theTitle, thePublisher,
                        theCopyrightYear, theCallNumber, theLoanPeriod, theDuration)
                {
                        Medium = theMedium;
                        Director = theDirector;
                        Rating = theRating; 
        
                    ReturnToShelf(); // Make sure movie is not checked out
    
                }

        public string Director 
        {
            // Precondition:  None
            // Postcondition: The director has been returned

                get
                {
                    return _director;
                }

                // Precondition:  value must not be null or empty
                // Postcondition: The director has been set to the specified value
                set
                {
                    if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                        throw new ArgumentOutOfRangeException($"{nameof(Director)}", value,
                            $"{nameof(Director)} must not be null or empty");
                    else
                        _director = value.Trim();
                }

        } 

        public override MediaType Medium
        {
                // Precondition:  None
                // Postcondition: The medium has been returned
                get
                {
                 return _medium;
                }

                // Precondition:  value = DVD or BLURAY or VHS 
                // Postcondition: The medium has been set to the specified value
                set
                {
                     if (value == MediaType.DVD || value == MediaType.BLURAY ||  value == MediaType.VHS)
                        _medium = value;
                     else
                        throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                             $"{nameof(Medium)} must be either DVD, BlueRay or VHS");
                }       

        }


                public MPAARatings Rating
                {
                    // Precondition:  None
                    // Postcondition: The rating has been returned
                    get
                    {
                     return _rating;
                    }

                    // Precondition:  value must  = G, PG, PG13, R, NC17, U
                    // Postcondition: The rating has been set to the specified value
                        set
                        {
                            if (value == MPAARatings.G || value == MPAARatings.PG || value == MPAARatings.PG13 || value == MPAARatings.R
                            || value == MPAARatings.NC17 || value == MPAARatings.U)
                            
                            _rating = value;
                            
                            else
                                throw new ArgumentOutOfRangeException($"{nameof(Rating)}", value,
                                    $"{nameof(Rating)} must be either G, PG, PG13, R, NC17, or U");
                        }

                }


                    // Precondition: the daysLate >= 0
                    // Postcondition: late fee will be returned
                        public override decimal CalcLateFee(int daysPastDue )
                        {
                            const decimal LATECHARGEVHSDVD = 1;     // fee per day being late VHS or DVD
                            const decimal LATECHARGEBLURAY = 1.25M;                     // fee per day being late Blu Ray
                            const decimal MAXFEE = 25;                                  // Max Late Fee Charge
                                  decimal lateFee;
                            if(this.Medium == MediaType.DVD || this.Medium == MediaType.VHS)
                            {
                                lateFee = LATECHARGEVHSDVD * daysPastDue;                                                                
                            }

                            else
                            lateFee = LATECHARGEBLURAY * daysPastDue;


                            if (lateFee > MAXFEE)
                            {
                                lateFee = MAXFEE;
                            }
                            
                                return lateFee;


                        }




                // Precondition:  None
                // Postcondition: A string is returned representing the library movie's
                //                data on separate lines
                public override string ToString()
                {
                    string NL = Environment.NewLine; // NewLine shortcut
                    string checkedOutBy; // Holds checked out message

                        if (IsCheckedOut())
                        checkedOutBy = $"Checked Out By: {NL}{Patron}";
                        else
                        checkedOutBy = "Not Checked Out";

                        return $"Title: {Title}{NL}Publisher: {Publisher}{NL}Copyright: {CopyrightYear}{NL}" +
                        $"Call Number: {CallNumber}{NL}Loan Period: {LoanPeriod}{NL}Duration: {Duration}{NL}" +
                        $"Director: {Director}{NL}Medium: {Medium}{NL}Rating: {Rating}{NL}{checkedOutBy}";

                }








    }

