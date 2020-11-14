// Jennifer Mohr
// CIS 3309 Section 001
// Wednesday, February 5th, 2020
// FINAL BINGO Project - Player Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoLetsTryThisAgain
{
    // keeps track of the player's information
    public class Player
    {

        public static string name;    // player's name is the only information about them recorded

        public Player(string name)
        {
            Player.name = name;   // sets the players name with the name text entered when new player is created
        }

        // getter method for name
        public static String getName()
        {
            return name;
        }
    } // end Player class
} // end namespace
