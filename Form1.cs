using System;
using System.Windows.Forms;

namespace RacingFinal
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        // Use the fully qualified Timer to avoid ambiguous Timer references.
        private System.Windows.Forms.Timer raceTimer;
        private int finishLine = 700; // X coordinate of the finish line.
        private int userGuess = 0;    // The deer number selected by the user (1 or 2).

        public Form1()
        {
            InitializeComponent();
            InitializeRaceTimer();
        }

        private void InitializeRaceTimer()
        {
            // Set the interval to 50 ms for smoother movement.
            raceTimer = new System.Windows.Forms.Timer
            {
                Interval = 50
            };
            raceTimer.Tick += RaceTimer_Tick;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Check if the user has made a selection.
            if (guessComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select deer number 1 or 2.");
                return;
            }
            userGuess = int.Parse(guessComboBox.SelectedItem.ToString());

            // Reset the positions of the images before starting the race.
            pictureBox1.Left = 12;
            pictureBox2.Left = 12;
            resultLabel.Text = "";
            raceTimer.Start();
        }

        private void RaceTimer_Tick(object sender, EventArgs e)
        {
            // Randomly determine the movement amount between 5 and 15.
            int move1 = rand.Next(5, 15);
            int move2 = rand.Next(5, 15);

            pictureBox1.Left += move1;
            pictureBox2.Left += move2;

            // If either picture reaches the finish line, stop the race.
            if (pictureBox1.Left >= finishLine || pictureBox2.Left >= finishLine)
            {
                raceTimer.Stop();

                // If both deer reach the finish line at the same time, it's a tie.
                if (pictureBox1.Left >= finishLine && pictureBox2.Left >= finishLine)
                {
                    resultLabel.Text = "Tie!";
                }
                else
                {
                    // Determine which deer reached the finish line first.
                    int winningDeer = (pictureBox1.Left >= finishLine) ? 1 : 2;
                    // Compare with the user's selection.
                    if (winningDeer == userGuess)
                    {
                        resultLabel.Text = $"Deer {winningDeer} won! Correct guess: You won!";
                    }
                    else
                    {
                        resultLabel.Text = $"Deer {winningDeer} won! Wrong guess: You lost!";
                    }
                }
            }
        }
    }
}
