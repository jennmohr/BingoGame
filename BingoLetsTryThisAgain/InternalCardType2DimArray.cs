// Jennifer Mohr
// CIS 3309 Section 001
// Wednesday, February 5th, 2020
// FINAL BINGO Project - Internal Card/Board Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoLetsTryThisAgain
{

    // Keeps track of the state of the viewable board in order to effectively determmmine when the player has a BINGO
    public class InternalCardType2DimArray
    {
        public int[] rowCounts; // array that keeps track of the called numbers in the rows
        public int[] colCounts; // array that keeps track of the called numbers in the rows
        public int frwdDiag;    // int that keeps track of the called numbers in the forward diagonal
        public int bkwdDiag;    // int that keeps track of the called numbers in the backwards diagonal
        

        // initializes the boardstate values to 0, except for the free space, which has a 1
        public InternalCardType2DimArray(int BINGOCARDSIZE)
        {
            this.rowCounts = new int[5]{0,0,1,0,0};
            this.colCounts = new int[5] {0,0,1,0,0};
            this.frwdDiag = 1;
            this.bkwdDiag = 1;
        }

        // when given the xx, y coordinates of the cell clicked, marks that cell by incrementing the value at the appropriate index of the
        // array/the diagonals(if applicable)
        public void markCell(int x, int y)
        {

            rowCounts[y]++;
            colCounts[x]++;

            if (x == y)
            {
                bkwdDiag++;
            }

            if(x + y == 4)
            {
                frwdDiag++;
            }

            
        }

        // goes through the arrays/ints and tries to find a value that is equal to 5, which would return true indicating that BINGO has occured
        // and the player has won
        public Boolean checkForBingo()
        {
            for(int i = 0; i < 5; i++)
            {
                if (rowCounts[i] == 5)
                    return true;
                if (colCounts[i] == 5)
                    return true;
            }

            if(bkwdDiag == 5 || frwdDiag == 5)
            {
                return true;
            }

            return false;
        }
    } // end InternalCardType2DimArray class
} // end namespace
