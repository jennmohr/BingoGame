// Jennifer Mohr
// CIS 3309 Section 001
// Wednesday, February 5th, 2020
// FINAL BINGO Project - Form Class

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoLetsTryThisAgain
{
    // Form Class!
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Named constants
        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;

        // This next statement does three things.  See if you can figure out what they are
        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];

        int countOfCalledNumbers;
        char nextCalledLetter;
        int nextCalledNumber;

        private InternalCardType2DimArray internalCardRep2DArray =
             new InternalCardType2DimArray(BINGOCARDSIZE);
        private RNGType RNGObj = new RNGType();

        private string bingoLetters = "BINGO";
        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;


        
       // Click handler for lets play the game
        private void btnLetsGo_Click(object sender, EventArgs e)
        {

            if (txtNameEntry.Text == "")
            {
                MessageBox.Show("No name was entered.  Try again.", "Missing Name");
                txtNameEntry.Focus();
            }
            else
            {
                lblHowToPlay.Visible = true;
                lblWhatWeDo.Visible = true;
                txtNumberCalled.Visible = true;
                lblBingoCard.Visible = true;
                lblDontHave.Visible = true;
                btnDontHave.Visible = true;

                createBingoCardOnForm();
                playTheGame();
            }  // end if
        }   



        // makes visible the BINGO card's panel and creates the BINGO card within the panel
        private void createBingoCardOnForm()
        {
            pnlCard.Visible = true;
            createCard();
        }  // end createBingoCardOnForm




        // Creates the Bingo Card for Play
        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form

            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Enabled = true;

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                        newButton[row, col].Enabled = false;
                    }
                    else
                    {
                     
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                        
                    }  // end if    

                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
            Globals.selectedNumbersListObj.reset();
        } // end createBoard



        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels



        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar



        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar



        // This is the handler for all Bingo Card Buttons
        // It uses sender argument to determine which Bingo Card button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
            //int bingoCount2D;  I didn't use these... not sure what they were for
            //int bingoCountWO2D;
            int selectedNumber;  // number randomly selected

            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID; 

            // gets the value on the button pressed
            int buttonNum = Int32.Parse(this.newButton[rowID, colID].Text);
            selectedNumber = nextCalledNumber;

            // checks to see if the user pressed the correct button
            if(buttonNum == selectedNumber) {
                internalCardRep2DArray.markCell(colID, rowID);
                this.newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                playTheGame();
            }
            else {
                MessageBox.Show("You have selected the incorrect number. Try again.");
            }



        } // end button clickhandler 

        // converts type char to int
        public int convertCharToInt(char c)
        {
            return ((int)(c) - (int)('0'));
        } // end convertCharToInt

        // puts the game into motion, checks if the user has a bingo before executing IF there have been more than 3 numbers called
        // (can't have bingo if only three numbers were called)
        public void playTheGame()
        {
            if (countOfCalledNumbers >= 4)
            {
                if (internalCardRep2DArray.checkForBingo())
                {
                    userWins();
                    return;
                }
            }

            // gets the number called from the RNGType Class
            RNGType random = new RNGType();
            nextCalledNumber = random.callNumber();
            int letter = random.getLetterCol(nextCalledNumber);
            nextCalledLetter = bingoLetters[letter];

            String called = String.Concat(nextCalledLetter, nextCalledNumber);

            // shows the number called to the user
            txtNumberCalled.Text = called;
            countOfCalledNumbers++;
                 
        }

        // method that checks if the user has the number that was called, returns true if they do, false if they don't
        public bool checkIfHas()
        {
            int column = 0;
            RNGType random = new RNGType();
            column = random.getLetterCol(nextCalledNumber);

            for (int i = 0; i < 5; i++)
            {
                if (this.newButton[i, column].Text != "Free \n Space")
                {
                    if (nextCalledNumber == Int32.Parse(this.newButton[i, column].Text))
                    {
                        return true;
                    }
                }
                
            }
            
            return false;
        }
        

        // event handler for clicking the lets go button
        private void btnLetsGo_Click_1(object sender, EventArgs e)
        {
            // only lets you play game if you have a name, if you do it makes the rest of the card visible
            // and plays the game
            if (txtNameEntry.Text == "")
            {
                MessageBox.Show("Please enter a name to play!");
                txtNameEntry.Focus();
            } else
            {
                string name = txtNameEntry.Text;
                Player player1 = new Player(name);
                lblHowToPlay.Visible = true;
                lblWhatWeDo.Visible = true;
                lblDontHave.Visible = true;
                txtNumberCalled.Visible = true;
                btnDontHave.Visible = true;
                lblBingoCard.Visible = true;
                pnlCard.Visible = true;

                createBingoCardOnForm();
                countOfCalledNumbers = 0;
                playTheGame();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the program
            this.Close();
        }

        // event handler for clicking the 'Don't Have' button, if they clicked the button and they do have it
        // it displays a message for them to check again, if they clicked it and they don't have it, the game continues
        private void btnDontHave_Click(object sender, EventArgs e)
        {
            if (checkIfHas())
            {
                MessageBox.Show("Are you sure about that? Check again if you have that number!");
            }
            else
            {
                playTheGame();
            }

        }

        // method that runs when the user wins! displays a message letting them know they won and disables the buttons that have no
        // function when the game is over
        private void userWins()
        {
            MessageBox.Show("BINGO!!! You won with " + countOfCalledNumbers + " numbers called. Congrats " + Player.getName() + "!", "BINGO");
            btnDontHave.Enabled = false;
            btnLetsGo.Enabled = false;
            pnlCard.Enabled = false;
            txtNameEntry.Enabled = false;
            txtNumberCalled.Enabled = false;
            btnExit.Text = "Exit Game";
            btnExit.Focus();
        }

        private void txtNameEntry_TextChanged(object sender, EventArgs e)
        {

        }
    } // end Forms class
} // end namespace
