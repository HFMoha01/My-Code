// Program 4
// CIS 199-01
// Due: 12/03/2019
// Grading ID : J1743

// This file creates the class library Book and creates the means of 
// to create the instance of the class

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Program_4
{//this class declaration has a user created constructor
    class LibraryBook
    {
        public const int BEGCE = 0;     //  Begining constraint for copyright year
        public const int ENDCE = 9999;  //  Ending connstraint for copyright year
        private int _copyrightYear;     //  backing field used for book's copy right year
        private bool checkedOut;        //  used for the check out status of the book


        //Precondition:  _copyrightYear must in four digit julian year format  0<=_copyrightYear <= 9999
        //Postcondition: Instance of Libary book will be created

        public LibraryBook(string title, string author, string publisher, int copyrightYear, string callNumber)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            CopyrightYear = copyrightYear;  
            CallNumber = callNumber;
        }

        //Precondition: Should only be used to reflect whether a book has been checked out
        //Postcondition: Will change the books checked out status to true
        public void CheckOut()
        {
            checkedOut = true;
        }

        //Precondition: Should only be used to reflect whether a book has been returned
        //Postcondition: Will change the books checked out status to false
        public void ReturnToShelf()
        {
            checkedOut = false;
        }

        //Precondition: none
        //Postcondition: Will return the current checkout status of the book
        public bool IsCheckedOut()
        {
            return checkedOut;
        }

        public string Title
        {

            //Precondition: none
            //Postcondition: The Title has been returned 
            get;


            //Precondition: none
            //Postcondition: The Title has been set
            set;
        }

        public string Author
        {
            //Precondition: none
            //Postcondition: The Author has been returned
            get;

            //Precondition: none
            //Postcondition: The Author has been set
            set;
        }

        public string Publisher
        {
            //Precondition: none
            //Postcondition: The Publisher has been returned
            get;

            //Precondition: none
            //Postcondition: The Publisher has been set
            set;
        }

        public int CopyrightYear
        {
            //Precondition: none
            //Postcondition: The Copyright Year has been returned
            get
            {
                return _copyrightYear;
            }

            //Precondition: 0 =< value < the current year
            //Postcondition: The copyright year has been set
            set
            {
                if (value >= BEGCE && value <= ENDCE)
                {
                    _copyrightYear = value;
                }
                else  // if entry is invalid
                {
                    _copyrightYear = 2019;
                }
                //_copyrightYear = value >= BEGCE && value < ENDCE ? value : 2019;
            }
        }

        public string CallNumber
        {

            //Precondition: none
            //Postcondition: The Call Number has been returned
            get;

            //Precondition: none
            //Postcondition: The Call Number has been set
            set;
        }


        //Precondition: none
        //Postcondition : will create a string that displays the Books Title, Author, Publisher, Copyright Year,
        // CallNumber and checked out status
        public override string ToString()
        {
            string result; //Builds results in steps

            result = $"Title: {Title}" + Environment.NewLine;
            result += $"Author: {Author}" + Environment.NewLine;
            result += $"Publisher: {Publisher}" + Environment.NewLine;
            result += $"Copyright Year: {CopyrightYear}" + Environment.NewLine;
            result += $"CallNumber: {CallNumber}" + Environment.NewLine;
            result += $"Is the book checked out: {checkedOut}" + Environment.NewLine;
            return result;
        }





    }
}
