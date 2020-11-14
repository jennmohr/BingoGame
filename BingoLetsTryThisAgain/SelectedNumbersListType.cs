// Jennifer Mohr
// CIS 3309 Section 001
// Wednesday, February 5th, 2020
// FINAL BINGO Project - Selected Numbers List Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoLetsTryThisAgain
{

    // A class containing methods and attributes associated with keeping track of numbers that were already selected in the 
    // process of generating a board and selecting numbers during the game
    public class SelectedNumbersListType
    {

        int[] numbersList;  // array of integers used to keep track of numbers used
        int position;   // keeps track of where in the array we are at while adding numbers into it, is incremented after setUsedNumber
                        // method is called

        public SelectedNumbersListType()
        {
            this.numbersList = new int[75];
            this.position = 0;
        }


        // initializes the class once the card is filled with numbers, so that the array can be used again to keep track of the numbers selected
        // during the game
         public void reset()
        {
            int[] reset = new int[75];
            numbersList = reset;
            position = 0;
        }

        // checks the list for whether or not the rando number is in the numbersList array
         public Boolean isNumberUsed(int rn)
        {
           for(int i = 0; i <= position; i++)
            {
                if (numbersList[i] == rn)
                    return true;
            }
        
            return false;
        }

        // adds the unique random number generated to the numbersList array and increments the position integer
        public void setUsedNumber(int rn)
        {
            numbersList[position] = rn;
            position++;
        }
    } // end SelectedNumbersListType class
} // end namespace