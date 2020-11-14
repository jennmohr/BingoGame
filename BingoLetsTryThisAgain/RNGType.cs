// Jennifer Mohr
// CIS 3309 Section 001
// Wednesday, February 5th, 2020
// FINAL BINGO Project - Random Number Generator Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoLetsTryThisAgain
{
    // Random Number Generator Class -- 
    //    Encapsulates all data and methods associated with the generation of 
    //        Random Numbers
    //    
    //    by Frank Friedman
    //        Version 1.2 - October 12, 2017

    // Contains all of the attributes and methods associated with the generation of random numbers in the program 
    public class RNGType
    {
        private Random RandomObj;      // Type random object

        // Constructor -- Creates and seeds a type random object
        public RNGType()
        {
            RandomObj = new Random();  // Creates and seeds (using current time) random object 
        }  // end RNGType

        // Get Random Value
        // Gets next random value and ensures it is in the correct range for the column
        //    involved
        // Returns a valid random number
        public int getRandomValue(char columnHeader)
        {
            int r;   // Random number generated

            switch (columnHeader)
            {
                case 'B':
                    r = getNextUniqueRandomValue(1, 15);
                    if (r < 1 || r > 15)
                    {
                        MessageBox.Show("Program Error! Selected random number out of range 1-15",
                             "Click to terminate program.", MessageBoxButtons.OK);
                        return -1;
                    }  // end if
                    break;
                case 'I':
                    r = getNextUniqueRandomValue(16, 30);
                    if (r < 16 || r > 30)
                    {
                        MessageBox.Show("Program Error! Selected random number out of range 16-30",
                             "Click to terminate program.", MessageBoxButtons.OK);
                        return -1;
                    }  // end if
                    break;
                case 'N':
                    r = getNextUniqueRandomValue(31, 45);
                    if (r < 31 || r > 45)
                    {
                        MessageBox.Show("Program Error! Selected random number out of range 31-45",
                             "Click to terminate program.", MessageBoxButtons.OK);
                        return -1;
                    } // end if
                    break;
                case 'G':
                    r = getNextUniqueRandomValue(46, 60);
                    if (r < 46 || r > 60)
                    {
                        MessageBox.Show("Program Error! Selected random number out of range 46-60",
                             "Click to terminate program.", MessageBoxButtons.OK);
                        return -1;
                    } // end if
                    break;
                case 'O':
                    r = getNextUniqueRandomValue(61, 75);
                    if (r < 61 || r > 75)
                    {
                        MessageBox.Show("Program Error! Selected random number out of range 61-75",
                             "Click to terminate program.", MessageBoxButtons.OK);
                        return -1;
                    } // end if
                    break;
                default:
                    MessageBox.Show("Program Error! Selected Letter no B I N G or O!",
                        "Click to terminate program.", MessageBoxButtons.OK);
                    return -1;
            } // end switch
            return r;
        } //  end getRandomValue


        // Creates the next set of random values (from 1 to diceToBeRolled values)  
        public int getNextUniqueRandomValue(int minVal, int maxVal)
        {
            Boolean isUnique;
            int rn = 0; // random number obtained
            // Assume number is not unique
            isUnique = false;

            while (isUnique == false)
            {
                rn = RandomObj.Next(minVal, maxVal);
                if (!Globals.selectedNumbersListObj.isNumberUsed(rn))
                {
                    isUnique = true;
                    Globals.selectedNumbersListObj.setUsedNumber(rn);
                } // end if
            } // end while                
            return rn;
        } // end getNextRandomValue

        // method that calls the next unique random number and returns it
        public int callNumber()
        {
            int numCalled = getNextUniqueRandomValue(1, 75);
            return numCalled;
             
        }

        // method that takes the number called and determines which column it is, in order to sort it into BINGO letters 
        public int getLetterCol(int nextCalledNumber)
        {
            int letter = ((nextCalledNumber - 1) / 15);
            return letter;
        }
    } //  end RNGType Class

} // end namespace
