namespace TicTacToe_WinApp
{
    public partial class Game : Form
    {
        public static string[] position = new string[9];

        internal static Players player1 = new();
        internal static Players player2 = new();


        internal static bool EndMatch = false;
        private static string CurrentPlayer = "X";
        bool repeatedPosition = false;

        public Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name1Label.Text = player1.NamePlayer;
            this.Name2Label.Text = player2.NamePlayer;
            this.CurrentName.Text = player1.NamePlayer;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerifyRepeated(0);
            if (!repeatedPosition)
            {
                position[0] = "-";
                SelectPosition();
                button1.Text = position[0];
                VerifyWinner();
                ChangeCurrentPlayer();
                ResetButtons();
                RefreshScore();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerifyRepeated(1);
            if (!repeatedPosition)
            {
                position[1] = "-";
                SelectPosition();
                button2.Text = position[1];
                VerifyWinner();
                ChangeCurrentPlayer();
                ResetButtons();
                RefreshScore();
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerifyRepeated(2);
            if (!repeatedPosition)
            {
                position[2] = "-";
                SelectPosition();
                button3.Text = position[2];
                VerifyWinner();
                ChangeCurrentPlayer();
                ResetButtons();
                RefreshScore();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerifyRepeated(3);
            if (!repeatedPosition)
            {
                position[3] = "-";
                SelectPosition();
                button4.Text = position[3];
                VerifyWinner();
                ChangeCurrentPlayer();
                ResetButtons();
                RefreshScore();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerifyRepeated(4);
            if (!repeatedPosition)
            {
                position[4] = "-";
                SelectPosition();
                button5.Text = position[4];
                VerifyWinner();
                ChangeCurrentPlayer();
                ResetButtons();
                RefreshScore();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerifyRepeated(5);
            if (!repeatedPosition)
            {
                position[5] = "-";
                SelectPosition();
                button6.Text = position[5];
                VerifyWinner();
                ChangeCurrentPlayer();
                ResetButtons();
                RefreshScore();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VerifyRepeated(6);
            if (!repeatedPosition)
            {               
                position[6] = "-";
                SelectPosition();
                button7.Text = position[6];
                VerifyWinner();
                ChangeCurrentPlayer();
                ResetButtons();
                RefreshScore();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VerifyRepeated(7);
            if (!repeatedPosition)
            {
                position[7] = "-";
                SelectPosition();
                button8.Text = position[7];
                VerifyWinner();
                ChangeCurrentPlayer();
                ResetButtons();
                RefreshScore();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VerifyRepeated(8);
            if (!repeatedPosition)
            {
                position[8] = "-";
                SelectPosition();
                button9.Text = position[8];
                VerifyWinner();
                ChangeCurrentPlayer();
                ResetButtons();
                RefreshScore();
            }
        }

        private void VerifyDraw()
        {
            byte emptyPositions = 0;

            for (byte verify = 0; verify < position.Length; verify++)
            {
                if (position[verify] == null)
                {
                    emptyPositions++;
                }
            }
            if (emptyPositions == 0 && EndMatch == false)
            {
                MessageBox.Show("Draw Game!!");

                EndMatch = true;
            }
        }

        private void VerifyRepeated(int a)
        {
            if (position[a] == "X" || position[a] == "O")
            {
                repeatedPosition = true;
            }
            else
            {
                repeatedPosition = false;
            }
        }

        private void ResetPositions()
        {
            for (byte verify = 0; verify < position.Length; verify++)
            {
                position[verify] = null;
            }

            EndMatch = false;
        }

        private void ResetButtons()
        {
            if (EndMatch)
            {
                button1.Text = button2.Text = button3.Text = button4.Text =
                button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";

                ResetPositions();
            }
        }

        private void RefreshScore()
        {
            Score1.Text = player1.Victories.ToString();
            Score2.Text = player2.Victories.ToString();
        }

        private void SelectPosition()
        {
            if (CurrentPlayer == "X")
            {
                for (byte verify = 0; verify < position.Length; verify++)
                {
                    if (position[verify] == "-")
                    {
                        position[verify] = CurrentPlayer;
                        break;
                    }
                }
            }

            else if (CurrentPlayer == "O")
            {
                for (byte verify = 0; verify < position.Length; verify++)
                {
                    if (position[verify] == "-")
                    {
                        position[verify] = CurrentPlayer;
                        break;
                    }
                }
            }
        }

        private void VerifyWinner()
        {
            if (position[0] == position[1] && position[1] == position[2] && position[1] != null ||
                position[3] == position[4] && position[4] == position[5] && position[4] != null ||
                position[6] == position[7] && position[7] == position[8] && position[7] != null ||
                position[0] == position[3] && position[3] == position[6] && position[3] != null ||
                position[1] == position[4] && position[4] == position[7] && position[4] != null ||
                position[2] == position[5] && position[5] == position[8] && position[5] != null ||
                position[0] == position[4] && position[4] == position[8] && position[4] != null ||
                position[2] == position[4] && position[4] == position[6] && position[4] != null)
            {
                if (CurrentPlayer == "X")
                {
                    MessageBox.Show($"{player1.NamePlayer} WINS!!");
                    player1.Victories++;
                    EndMatch = true;
                }
                else if (CurrentPlayer == "O")
                {
                    MessageBox.Show($"{player2.NamePlayer} WINS!!");
                    player2.Victories++;
                    EndMatch = true;
                }
            }
            else
            {
                EndMatch = false;
            }

            VerifyDraw();
        }

        private void ChangeCurrentPlayer()
        {
            if (CurrentPlayer == "X")
            {
                this.CurrentName.Text = player2.NamePlayer;
                CurrentPlayer = "O";
            }
            else if (CurrentPlayer == "O")
            {
                this.CurrentName.Text = player1.NamePlayer;
                CurrentPlayer = "X";
            }
        }
    }
}