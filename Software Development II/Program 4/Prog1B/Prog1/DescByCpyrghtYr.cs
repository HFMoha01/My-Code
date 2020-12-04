// Program 4
// CIS 200-01
// Due: 4/15/2020
// Grading: T1681
//
//
//
//
//File:DescByCpyrghtYr.cs
//
//This class allows the library items in the library to be sorted in
//the descending order of the Copyright year  using the IComparer interface
//
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    public class DescByCpyrghtYr:Comparer<LibraryItem>
    {

        //PreCondition: None
        //PostCondition: Reverses Library Items sort order of Copyright years so descending  CopyRight Year
        //                When item1 < item2, method returns positive #
        //                When item1 == item2, method returns zero
        //                When item1 > item2, method returns negative #
        public override int Compare(LibraryItem item1, LibraryItem item2)
        {
            const int NEG = -1;  // denote item is less than
            const int POS = 1;  //  denote item is greater than
            const int ZERO = 0;  //denote item is equal to other item

            if (item1 == null && item2 == null)  //both null
                return ZERO;            // Equal

            else if (item1 == null)   //item 1 null?
                return NEG;           // less than

            else if (item2 == null)  //item 2 null?
                return POS;          // greater than

            else return (NEG) * item1.CopyrightYear.CompareTo(item2.CopyrightYear);  //descending order of item by copyright year
        
        }


    }
}
