using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public int boardSize = 3; // default is 3x3 board
        public bool chooseRandomStart = true; //randomly choose who starts and with what
        public bool turn = true;  //true - x, false - o
        public bool xstarts = true;
        public bool onePlayer = true; // one player - against computer, else - two player game
        public bool computerStarts = false; //if changed computer is the first to go
        public Color player1Color = System.Drawing.Color.Red; //default color for player 1
        public Color player2Color = System.Drawing.Color.Blue; //default color for player 2
        private Button lastPlay; //saves the last play of the opponent
        private int numOfTurns = 0; // saves how many turns were played so far 
        private Button[,] btns; //saves all the buttons on the screen
        public bool cancel = false;

        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
            if (this.chooseRandomStart)
                ChoosePlayers();
            if (this.computerStarts)
                ComputerTurn();
        }

        public void InitializeButtons()
        {
            this.btns = new Button[this.boardSize, this.boardSize];
            for (int i = 0; i < btns.GetLength(0); i++)
            {
                for (int j = 0; j < btns.GetLength(1); j++)
                {
                    this.btns[i, j] = new Button();

                    this.btns[i,j].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                    this.btns[i,j].AutoSize = true;
                    this.btns[i,j].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                    this.btns[i,j].Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold);
                    this.btns[i,j].Name = "btn" + j.ToString() + i.ToString();
                    this.btns[i,j].TabIndex = 6;
                    this.btns[i,j].Text = "\r\n";
                    this.btns[i,j].UseVisualStyleBackColor = true;
                    this.btns[i, j].TabStop = false;

                    this.btns[i,j].Click += new System.EventHandler(this.ButtonClicked);


                    this.tableLayoutPanel1.Controls.Add(this.btns[i,j], i+1, j);
                }
            }
        }

        public void ChoosePlayers()
        {
            Random rnd = new Random();
            this.xstarts = rnd.NextDouble() >= 0.5;
            if(this.boardSize == 3) //only in 3x3 computer plays
                this.computerStarts = rnd.NextDouble() >= 0.5;
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            AddMark(btn);
            btn.Enabled = false;
            this.lastPlay = btn;
            if (Winner())
                EndGame();
            else
            {
                this.turn = !this.turn;
                this.numOfTurns++;
                if (this.onePlayer) // against computer
                    ComputerTurn();
                if (this.numOfTurns >= Math.Pow(this.boardSize, 2))
                    MessageBox.Show("Tie!", "Game over");
            }
        }

        private void ComputerTurn()
        {
            if(this.numOfTurns == 0) //if computer starts
            {
                //start in one of the four corners or in the middle
                Random rnd = new Random();
                int x = rnd.Next(0, 2);
                if (x == 0) //place middle
                    AddMark(this.btns[(int)this.boardSize / 2, (int)this.boardSize / 2]);
                else //choose corner
                    AddMark(GetRandomPlace("corner"));
            }
            else //player made a move 
            {
                if(this.numOfTurns == 1)
                {
                    if (GetLastPlace() == "corner")
                        AddMark(this.btns[(int)this.boardSize / 2, (int)this.boardSize / 2]); //add mark to center
                    else if (GetLastPlace() == "middle")
                        AddMark(GetRandomPlace("corner")); //add mark to one of the corners
                    else //play middle
                        AddMark(this.btns[(int)this.boardSize / 2, (int)this.boardSize / 2]);
                }
                else
                {
                    if (Diagonal()) //if player choose opposite corners, and computer in the middle
                        AddMark(GetRandomPlace("edge")); //choose one of the four edges
                    else if (CornerEdge() && !this.computerStarts)
                    {
                        Button th = Threat();
                        if (th != null) //player put two in a row - block
                            AddMark(th);
                        else //make sure the player won't be able to fork
                            AddMark(CornersBeside());
                    }
                    else
                    {
                        Button cornerBlock = MiddleEdge(); //check if player put twice in edges
                        if (cornerBlock != null)
                            AddMark(cornerBlock); //block him from forking
                        else
                        {
                            Button winOrBlock = Threat();
                            if (winOrBlock != null)
                                AddMark(winOrBlock); //win the game or block a threat
                            else if (this.btns[(int)this.boardSize / 2, (int)this.boardSize / 2].Enabled) //if center hasn't been played
                                AddMark(this.btns[(int)this.boardSize / 2, (int)this.boardSize / 2]);
                            else
                            {
                                Button btn = GetRandomPlace("corner");
                                if (btn != null)
                                    AddMark(btn);
                                else
                                {
                                    Button bt = GetRandomPlace("egde");
                                    if (bt != null)
                                        AddMark(bt);
                                }
                            }
                        }
                    }
                }
            }
            if (Winner())
                EndGame();
            this.turn = !this.turn;
            this.numOfTurns++; //update num of turns including the computer's turn
        }

        private string GetLastPlace()
        {
            if (this.lastPlay != null)
            {
                TableLayoutPanelCellPosition t = this.tableLayoutPanel1.GetPositionFromControl(this.lastPlay);
                int row = t.Row-1;
                int column = t.Column;
                if ((row == 0 && column == 0) || (row == this.boardSize - 1 && column == this.boardSize - 1) ||
                    (row == 0 && column == this.boardSize - 1) || (row == this.boardSize - 1 && column == 0))
                    return "corner";
                else if (row == (int)this.boardSize / 2 && column == (int)this.boardSize / 2)
                    return "middle";
                else
                    return "edge";
            }
            return ""; //no last place
        }

        private bool Diagonal()
        {
            string computer;
            if (this.turn)
                computer = "X";
            else
                computer = "O";
            //check main diagonal
            int sum = 0;
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                if (!this.btns[i, i].Enabled)
                    sum += 1;
            }
            if (sum == this.boardSize && this.numOfTurns == this.boardSize
                && this.btns[this.boardSize/2, this.boardSize/2].Text == computer)
                return true;
            //check secondary diagonal
            sum = 0;
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                if (!this.btns[i, this.btns.GetLength(0) - 1 - i].Enabled)
                    sum += 1;
            }
            if (sum == this.boardSize && this.numOfTurns == this.boardSize
                && this.btns[this.boardSize / 2, this.boardSize / 2].Text == computer)
                return true;
            return false;
        }

        private bool CornerEdge()
        {
            int counter = 0;
            string text;
            if (this.turn)
                text = "O";
            else
                text = "X";
            Button[] buttons = { this.btns[0, 0], this.btns[0, this.boardSize - 1], this.btns[this.boardSize - 1, 0], this.btns[this.boardSize - 1, this.boardSize - 1] };
            foreach (Button btn in buttons)
            {
                if (!btn.Enabled && btn.Text == text)
                    counter++;
            }
            if (counter != 1)
                return false;
            counter = 0;
            //now check that there is also one edge
            Button[] notEdge = { this.btns[0, 0], this.btns[0, this.boardSize - 1], this.btns[this.boardSize - 1, 0], this.btns[this.boardSize - 1, this.boardSize - 1], this.btns[this.boardSize / 2, this.boardSize / 2] };
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                for (int j = 0; j < this.btns.GetLength(1); j++)
                {
                    if (!notEdge.Contains(this.btns[i, j]) && this.btns[i, j].Text == text)
                        counter++;
                }
            }
            if (counter != 1)
                return false;
            return true;
        }

        private Button MiddleEdge()
        {
            string text;
            if (this.turn)
                text = "O";
            else
                text = "X";
            if (this.btns[this.boardSize / 2, this.boardSize / 2].Text != text && this.numOfTurns == 3) //if I dominate the middle and 3 turns past
            {
                //count how many edges player has
                int row = this.boardSize / 2;
                int column = this.boardSize / 2;
                int counter = 0;
                int goodRow = 1;
                int goodColumn = 1;
                for (int i = 0; i < this.btns.GetLength(0); i++)
                {
                    for (int j = 0; j < this.btns.GetLength(1); j++)
                    {
                        if ((i == row || j == column) && !(i == row && j == column) && this.btns[i,j].Text == text)
                        {
                            counter++;
                            goodRow *= i;
                            goodColumn *= j;
                        }
                    }
                }
                if(counter == 2)
                {
                    int badRow = Math.Abs(goodRow - (this.boardSize - 1));
                    int badColumn = Math.Abs(goodColumn - (this.boardSize - 1));
                    Random rnd = new Random();
                    Button[] choices = { this.btns[0, 0], this.btns[0, this.boardSize - 1], this.btns[this.boardSize - 1, 0], this.btns[this.boardSize - 1, this.boardSize - 1] }; //all corners
                    //choose one of them except the one on the other side of the board
                    choices = choices.Except(new Button[] { this.btns[badRow, badColumn] }).ToArray(); //remove bad choice from array
                    return choices[rnd.Next(choices.Length)]; //return one of the other three corners
                }
            }
            return null;
        }

        private Button Threat()
        {
            //checks if there are two marks that can make a threat
            //checks first if the threat is mine and can win the game, if so returns the winning position
            //then checks for opponent threat and returns the place to block if threat exists, else returns null

            // opponent = -1, computer = +2 - give more weight to winning
            // if the sum is +4, then their is a winning move 
            // if sum is is equal to -2, then their is a threat accordingly
            string opponent, computer; //threat is if there are two same opponent marks
            Button blockThreat = null;
            if ((this.xstarts && this.computerStarts) || (!this.xstarts && !this.computerStarts))
            {
                computer = "X";
                opponent = "O";
            }
            else
            {
                computer = "O";
                opponent = "X";
            }
            int sum = 0;
            int place = 0;
            //check the main diagonal
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                if (this.btns[i, i].Text == opponent)
                    sum -= 1;
                else if (this.btns[i, i].Text == computer)
                    sum += 2;
                else //empty space
                    place = i;
            }
            if (sum == 4)
                return this.btns[place, place];
            else if (sum == -2)
                blockThreat = this.btns[place, place];
            sum = 0;
            // check the secondary diagonal
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                if (this.btns[i, this.btns.GetLength(0) - i - 1].Text == opponent)
                    sum -= 1;
                else if (this.btns[i, this.btns.GetLength(0) - i - 1].Text == computer)
                    sum += 2;
                else //empty space
                    place = i;
            }
            if (sum == 4)
                return this.btns[place, this.btns.GetLength(0) - place - 1];
            else if (sum == -2)
                blockThreat = this.btns[place, this.btns.GetLength(0) - place - 1];
            //check all rows and columns
            int row = 0;
            int column = 0;
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < this.btns.GetLength(1); j++)
                {
                    if (this.btns[i, j].Text == opponent)
                        sum -= 1;
                    else if (this.btns[i, j].Text == computer)
                        sum += 2;
                    else //empty space
                    { row = i; column = j; }
                }
                if (sum == 4)
                    return this.btns[row, column];
                else if (sum == -2)
                    blockThreat = this.btns[row, column];
            }
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < this.btns.GetLength(1); j++)
                {
                    if (this.btns[j, i].Text == opponent)
                        sum -= 1;
                    else if (this.btns[j, i].Text == computer)
                        sum += 2;
                    else //empty space
                    { row = j; column = i; }
                }
                if (sum == 4)
                    return this.btns[row, column];
                else if (sum == -2)
                    blockThreat = this.btns[row, column];
            }
            return blockThreat;
        }

        private Button CornersBeside()
        {
            //returns a random corner beside the last place the opponent put his mark
            //if there are no corners - returns null
            string opponent;
            if (this.turn)
               opponent = "O";
            else
               opponent = "X";

            Button[] choices = { this.btns[0, 0], this.btns[0, this.boardSize - 1], this.btns[this.boardSize - 1, 0], this.btns[this.boardSize - 1, this.boardSize - 1] };
            //check if last place isn't the corner itself
            TableLayoutPanelCellPosition t = this.tableLayoutPanel1.GetPositionFromControl(this.lastPlay);
            if (choices.Contains(this.lastPlay))
            {
                bool found = false;
                //find the edge and set it as the button t
                for (int i = 0; i < this.btns.GetLength(0) && !found; i++)
                {
                    for (int j = 0; j < this.btns.GetLength(1) && !found; j++)
                    {
                        if (this.btns[i, j] != this.lastPlay && this.btns[i, j].Text == opponent)
                        {
                            t = this.tableLayoutPanel1.GetPositionFromControl(this.btns[i, j]);
                            found = true;
                        }

                    }
                }
                if (!found)
                    return null;
            }
            int row = t.Row - 1;
            int column = t.Column;
            Random rnd = new Random();
            int x;
            x = rnd.Next(0, 2);
            if ((column == 0 || column == this.boardSize - 1) && row == this.boardSize / 2)
            {
                if (x == 0)
                    return this.btns[column, row+1];
                else
                    return this.btns[column, row-1];
            }
            else if ((row == 0 || row == this.boardSize - 1) && column == this.boardSize / 2)
            {
                if (x == 0)
                    return this.btns[column + 1, row];
                else
                {
                    return this.btns[column - 1, row];
                }
            }
            else
                return null;
        }   

        private Button GetRandomPlace(string option, Button btn=null)
        {
            Random rnd = new Random();
            if(option == "corner")
            {
                Button[] choices = { this.btns[0, 0], this.btns[0, this.boardSize-1], this.btns[this.boardSize - 1, 0], this.btns[this.boardSize - 1, this.boardSize-1] };
                Button choice = null;
                while(choice == null && choices.Length != 0)
                {
                    choice = choices[rnd.Next(choices.Length)];
                    if (!choice.Enabled) //place is already taken
                    {
                        choices = choices.Except(new Button[] { choice }).ToArray(); //remove choice from array
                        choice = null;
                    }
                }
                return choice;
            }
            else //option is egde
            {
                Button choice = null;
                Button[] choices = { this.btns[0, 0], this.btns[0, this.boardSize - 1], this.btns[this.boardSize - 1, 0], this.btns[this.boardSize - 1, this.boardSize - 1], this.btns[this.boardSize/2, this.boardSize/2] };
                while (choice == null && choices.Length != 0)
                {
                    choice = this.btns[rnd.Next(this.btns.GetLength(0)), rnd.Next(this.btns.GetLength(1))];
                    if (choices.Contains(choice) || !choice.Enabled)
                    {
                        choices = choices.Except(new Button[] { choice }).ToArray(); //remove choice from array
                        choice = null;
                    }
                }
                return choice;
            }
        }

        public void AddMark(Button btn)
        {
            if (this.turn)
                btn.Text = "X";
            else
                btn.Text = "O";
            if (this.xstarts && this.turn || !this.xstarts && !this.turn)
            {
                btn.BackColor = this.player1Color;
                btn.ForeColor = this.player1Color;
            }
            else
            {
                btn.BackColor = this.player2Color;
                btn.ForeColor = this.player2Color;
            }
            btn.Enabled = false;
        }

        public bool Winner()
        {
            //x = +1, o = -1
            // if sum in row is equal to this.boardSize or -this.boardSize, then their is a winner accordingly
            int sum = 0;
            //check the main diagonal
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                if (this.btns[i, i].Text == "X")
                    sum += 1;
                else if (this.btns[i, i].Text == "O")
                    sum -= 1;
                else
                    break; //no need to continue calculating
            }
            if (Math.Abs(sum) == this.boardSize)
                return true;
            sum = 0;
            // check the secondary diagonal
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                if (this.btns[i, this.btns.GetLength(0) - i - 1].Text == "X")
                    sum += 1;
                else if (this.btns[i, this.btns.GetLength(0) - i - 1].Text == "O")
                    sum -= 1;
                else
                    break; //no need to continue calculating
            }
            if (Math.Abs(sum) == this.boardSize)
                return true;
            //check all rows and columns
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < this.btns.GetLength(1); j++)
                {
                    if (this.btns[i, j].Text == "X")
                        sum += 1;
                    else if (this.btns[i, j].Text == "O")
                        sum -= 1;
                    else
                        break; //no need to continue calculating
                }
                if (Math.Abs(sum) == this.boardSize)
                    return true;
            }
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < this.btns.GetLength(1); j++)
                {
                    if (this.btns[j, i].Text == "X")
                        sum += 1;
                    else if (this.btns[j, i].Text == "O")
                        sum -= 1;
                    else
                        break; //no need to continue calculating
                }
                if (Math.Abs(sum) == this.boardSize)
                    return true;
            }
            return false;
        }

        public void EndGame()
        {
            if (this.turn)
                MessageBox.Show("X Won!", "Winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("O Won!", "Winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //make all buttons disabled
            for (int i = 0; i < this.btns.GetLength(0); i++)
            {
                for (int j = 0; j < this.btns.GetLength(1); j++)
                {
                    this.btns[i, j].Enabled = false;
                }
            }
        }

        private void NewGame(object sender, EventArgs e)
        {
            //make all buttons enabled and change their color and text
            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                if (c as Button != null)
                {
                    ((Button)c).Text = "";

                    ((Button)c).BackColor = SystemColors.Control;
                    ((Button)c).UseVisualStyleBackColor = true;

                    ((Button)c).Enabled = true;
                }
            }
            if (this.chooseRandomStart)
                ChoosePlayers();
            if (this.xstarts)
                this.turn = true;
            else
                this.turn = false;
            this.numOfTurns = 0;
            if (this.computerStarts)
                ComputerTurn();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void OptionDialog(object sender, EventArgs e)
        {
            Options options = new Options(this);
            options.ShowDialog();
            if (!this.cancel) //if user canceled the options dialog box no need to reset the game
            {
                this.tableLayoutPanel1.Dispose();
                this.menuStrip1.Dispose();
                InitializeComponent();
                InitializeButtons();
                NewGame(new object(), new EventArgs()); //invoke new-game method
            }
            this.cancel = false;
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gameInstructions = "Welcome to Tic-Tac-Toe!" + Environment.NewLine +
                                      "The goal of the game is to get three same marks" + Environment.NewLine +
                                      "(x or o) in the same row, column or diagonal." + Environment.NewLine +
                                      "The first one to accomplish this wins!!!!" + Environment.NewLine + Environment.NewLine +
                                      "You can go to Options->Settings in order" + Environment.NewLine +
                                      "to change some interesting settings of the" + Environment.NewLine +
                                      "game, such as multiplayer and colors." + Environment.NewLine + Environment.NewLine +
                                      "Enjoy!!";
            MessageBox.Show(gameInstructions,
                            "Game Instructions", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Made by: Yuval Stein" + Environment.NewLine +
                          "Date: 23/9/17";
            MessageBox.Show(info,
                            "About",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}