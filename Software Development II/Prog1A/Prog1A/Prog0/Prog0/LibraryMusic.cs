// Program 0
// CIS 200-01
// Grading ID: T1681
// Due: 1/12/2020

// File: LibraryMusic.cs
// This file creates an  LibraryMusic class capable of tracking
// the item's title, director, publisher, copyright year, call number,loan period, 
//  duration, medium, artist, number of tracks and checked out status.
// HAS-A with LibraryPatron

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


     public class LibraryMusic : LibraryMediaItem
     {
            private string _artist;             //the music item's artist
            private int _numberOfTracks;        // the music item's track number
            private MediaType _medium;          // the music item's medium

            // Precondition:  theCopyrightYear >= 0
            //                theLoanPeriod >= 0
            //                theDuration >= 0
            //                theNumberOfTracks >=1
            //                theTitle, theArtist, theCallNumber may not be null or empty
            // Postcondition: The library music item has been initialized with the specified
            //                values for title, publisher, copyright year, loan period, call number,  
            //                duration, medium, artist and number of tracks. The item is not checked out

            public LibraryMusic(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber,
                            int theLoanPeriod, double theDuration, MediaType theMedium, string theArtist, int theNumberOfTracks ) : base(theTitle, thePublisher,
                            theCopyrightYear, theCallNumber, theLoanPeriod, theDuration)
            {
                Medium = theMedium;
                Artist = theArtist;
                NumberOfTracks = theNumberOfTracks;
                ReturnToShelf(); // Make sure music is not checked out

            }

            public override MediaType Medium
            {
                // Precondition:  None
                // Postcondition: The medium has been returned
                get
                {
                    return _medium;
                }

                // Precondition:  value = CD, or SACD or VINYL
                // Postcondition: The medium has been set to the specified value
                set
                {
                    if (value == MediaType.CD || value == MediaType.SACD || value == MediaType.VINYL)
                        _medium = value;
                    else
                        throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                            $"{nameof(Medium)} must be either CD, SACD, or VINYL");
                }

            }

            public string Artist
            {
                // Precondition:  None
                // Postcondition: The artist has been returned

                    get
                    {
                        return _artist;
                    }

                // Precondition:  value must not be null or empty
                // Postcondition: The artist has been set to the specified value
        
                    set
                    {
                        if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                        throw new ArgumentOutOfRangeException($"{nameof(Artist)}", value,
                            $"{nameof(Artist)} must not be null or empty");
                            
                        else
                            _artist = value.Trim();
                    }

            }


             public int NumberOfTracks
             {
                // Precondition:  None
                // Postcondition: The number of tracks has been returned
                   get
                   {
                     return _numberOfTracks;
                   }

                 // Precondition:  value >= 1
                 // Postcondition: The number of tracks has been set to the specified value
                    set
                    {
                       if (value >= 0)
                         _numberOfTracks = value;
                       else
                            throw new ArgumentOutOfRangeException($"{nameof(NumberOfTracks)}", value,
                            $"{nameof(NumberOfTracks)} must be >= 0");
                    }
             }


             // Precondition: the daysLate >= 0
             // Postcondition: late fee will be returned
             public override decimal CalcLateFee(int daysPastDue)
             {
                     const decimal LATECHARGE = .5M;        // fee per day for being late             
                     const decimal MAXFEE = 20;             // Max Late charge Possible
                     decimal lateFee = 0;
                    
                      lateFee = LATECHARGE * daysPastDue;

                      if (lateFee > MAXFEE)
                      {
                        lateFee = MAXFEE;
                      }

                            return lateFee;


             }




                    // Precondition:  None
                    // Postcondition: A string is returned representing the library music's
                    // data on separate lines
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
                            $"Artist: {Artist}{NL}Medium: {Medium}{NL}Number Of Tracks: {NumberOfTracks}{NL}{checkedOutBy}";

                }







     }

