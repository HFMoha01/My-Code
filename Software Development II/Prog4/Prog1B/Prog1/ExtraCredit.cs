// Program 4
// CIS 200-01
// Due: 4/15/2020
// Grading: T1681
//
//
//
//
//File:ExtraCredit.cs
//
//This class allows the library items in the library to be sorted in
//the ascending order of item type and then in ascending order of the 
// item's tile using the IComparer interface
//
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    public class ExtraCredit: Comparer<LibraryItem>
    {
        //PreCondition: None
        //PostCondition: Sorts Library items by type and title in 
        //                ascending order
        //                When item1 < item2, method returns negative #
        //                When item1 == item2, method returns zero
        //                When item1 > item2, method returns postive #
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
             
            // Gets the types of items
            Type item1Type = item1.GetType();
            Type item2Type = item2.GetType();

           
            if (item1Type != item2Type)     //if items type are not the same 
            {
                return item1Type.ToString().CompareTo(item2Type.ToString());
            }
            else 
            
                //if not then sort by ascending title order
                return item1.Title.CompareTo(item2.Title);
            
        }
















    }
}
