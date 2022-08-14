namespace Activity13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int playerturn;
        int current_player;
        //two dimentional array that is required for assignment
        public int[,] grid = new int[3, 3];

        //making sure player 1 always go first
        private void Form1_Load(object sender, EventArgs e)
        {
            playerturn = 1;
        }
        //enables all the buttons to be pushed again and clear text
        private void startNewGame()
        {
            buttonA1.Enabled = true; buttonA1.Text = "";
            buttonA2.Enabled = true; buttonA2.Text = "";
            buttonA3.Enabled = true; buttonA3.Text = "";
            buttonB1.Enabled = true; buttonB1.Text = "";
            buttonB2.Enabled = true; buttonB2.Text = "";
            buttonB3.Enabled = true; buttonB3.Text = "";
            buttonC1.Enabled = true; buttonC1.Text = "";
            buttonC2.Enabled = true; buttonC2.Text = "";
            buttonC3.Enabled = true; buttonC3.Text = "";

            for(int i = 0; i < 3; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    grid[i, j] = 0;
                }
            }
            if(current_player == 1)
            {
                current_player = 2;
                playerturn = 2;
            }
            else
            {
                if(current_player == 2)
                {
                    current_player = 1;
                    playerturn = 1;
                }
            }
        }
        //checking for a win diagonally
        private void checkDiagonals()
        {
            //variables to keep count for each player
            int countP1 = 0;
            int countP2 = 0;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(i == j && grid[j, i] == 1)
                    {
                        countP1++;
                    }
                    if(i == j && grid[j, i] == 2)
                    {
                        countP2++;
                    }
                    //if count gets to 3 win is declared
                    if(countP1 == 3)
                    {
                        MessageBox.Show("Player 1 Wins");
                        startNewGame();
                        break;
                    }
                    if(countP2 == 3)
                    {
                        MessageBox.Show("Player 2 wins");
                        startNewGame();
                        break;
                    }
                }
            }
        }
        //checking for a win horizontally
        private void checkRows()
        {
            //variables to keep count for each player
            int countP1 = 0;
            int countP2 = 0;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(grid[i, j] == 1)
                    {
                        countP1++;
                    }
                    if(grid[i, j] == 2)
                    {
                        countP2++;
                    }
                    //if count gets to 3 win is declared
                    if (countP1 == 3)
                    {
                        MessageBox.Show("Player 1 Wins");
                        startNewGame();
                        break;
                    }
                    if(countP2 == 3)
                    {
                        MessageBox.Show("Player 2 Wins");
                        startNewGame();
                        break;
                    }
                }
            }
        }
        //checking for a win vertically
        private void checkColumns()
        {
            //variables to keep count for each player
            int countP1 = 0;
            int countP2 = 0;

            for( int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (grid[j, i] == 1)
                    {
                        countP1++;
                    }
                    if (grid[j, i] == 2)
                    {
                        countP2++;
                    }
                    //if count gets to 3 win is declared
                    if (countP1 == 3)
                    {
                        MessageBox.Show("Player 1 Wins");
                        startNewGame();
                        break;
                    }
                    if(countP2 == 3)
                    {
                        MessageBox.Show("Player 2 Wins");
                        startNewGame();
                        break;
                    }
                }
            }
        }
        //assigning all buttons grid locations to track clicks and assign X or O to players
        private void buttonA1_Click(object sender, EventArgs e)
        {
            buttonA1.Enabled = false;
            if(playerturn == 1)
            {
                grid[0, 0] = 1;
                buttonA1.Text = "X";
                playerturn = 2;
            }
            else
            {
                grid[0, 0] = 2;
                buttonA1.Text = "O";
                playerturn = 1;
            }
            checkRows(); checkColumns(); checkDiagonals();
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            buttonA2.Enabled = false;
            if (playerturn == 1)
            {
                grid[0, 1] = 1;
                buttonA2.Text = "X";
                playerturn = 2;
            }
            else
            {
                grid[0, 1] = 2;
                buttonA2.Text = "O";
                playerturn = 1;
            }
            checkRows(); checkColumns(); checkDiagonals();
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            buttonA3.Enabled = false;
            if (playerturn == 1)
            {
                grid[0, 2] = 1;
                buttonA3.Text = "X";
                playerturn = 2;
            }
            else
            {
                grid[0, 2] = 2;
                buttonA3.Text = "O";
                playerturn = 1;
            }
            checkRows(); checkColumns(); checkDiagonals();
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            buttonB1.Enabled = false;
            if (playerturn == 1)
            {
                grid[1, 0] = 1;
                buttonB1.Text = "X";
                playerturn = 2;
            }
            else
            {
                grid[1, 0] = 2;
                buttonB1.Text = "O";
                playerturn = 1;
            }
            checkRows(); checkColumns(); checkDiagonals();
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            buttonB2.Enabled = false;
            if (playerturn == 1)
            {
                grid[1, 1] = 1;
                buttonB2.Text = "X";
                playerturn = 2;
            }
            else
            {
                grid[1, 1] = 2;
                buttonB2.Text = "O";
                playerturn = 1;
            }
            checkRows(); checkColumns(); checkDiagonals();
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            buttonB3.Enabled = false;
            if (playerturn == 1)
            {
                grid[1, 2] = 1;
                buttonB3.Text = "X";
                playerturn = 2;
            }
            else
            {
                grid[1, 2] = 2;
                buttonB3.Text = "O";
                playerturn = 1;
            }
            checkRows(); checkColumns(); checkDiagonals();
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            buttonC1.Enabled = false;
            if (playerturn == 1)
            {
                grid[2, 0] = 1;
                buttonC1.Text = "X";
                playerturn = 2;
            }
            else
            {
                grid[2, 0] = 2;
                buttonC1.Text = "O";
                playerturn = 1;
            }
            checkRows(); checkColumns(); checkDiagonals();
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            buttonC2.Enabled = false;
            if (playerturn == 1)
            {
                grid[2, 1] = 1;
                buttonC2.Text = "X";
                playerturn = 2;
            }
            else
            {
                grid[2, 1] = 2;
                buttonC2.Text = "O";
                playerturn = 1;
            }
            checkRows(); checkColumns(); checkDiagonals();
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            buttonC3.Enabled = false;
            if (playerturn == 1)
            {
                grid[2, 2] = 1;
                buttonC3.Text = "X";
                playerturn = 2;
            }
            else
            {
                grid[2, 2] = 2;
                buttonC3.Text = "O";
                playerturn = 1;
            }
            checkRows(); checkColumns(); checkDiagonals();
        }
        //event to start a new game on button click
        private void NewGame_Click(object sender, EventArgs e)
        {
            startNewGame();
        }
        //event to close game on button click
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}