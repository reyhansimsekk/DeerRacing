using System;
using System.Windows.Forms;

namespace racingFinal
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        // Belirsiz Timer referans�n� �nlemek i�in tam nitelikli Timer kullan�yoruz.
        private System.Windows.Forms.Timer raceTimer;
        private int finishLine = 700; // Biti� �izgisi X koordinat�
        private int userGuess = 0;     // Kullan�c�n�n se�ti�i geyik numaras� (1 veya 2)

        public Form1()
        {
            InitializeComponent();
            InitializeRaceTimer();
        }

        private void InitializeRaceTimer()
        {
            // Daha ak�c� hareket i�in interval 50 ms olarak ayarland�.
            raceTimer = new System.Windows.Forms.Timer
            {
                Interval = 50
            };
            raceTimer.Tick += RaceTimer_Tick;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Kullan�c�n�n se�im yap�p yapmad���n� kontrol ediyoruz.
            if (guessComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("L�tfen 1 veya 2 numaral� geyik se�iniz.");
                return;
            }
            userGuess = int.Parse(guessComboBox.SelectedItem.ToString());

            // Yar��a ba�lamadan �nce resimlerin pozisyonlar�n� s�f�rla.
            pictureBox1.Left = 12;
            pictureBox2.Left = 12;
            resultLabel.Text = "";
            raceTimer.Start();
        }

        private void RaceTimer_Tick(object sender, EventArgs e)
        {
            // Hareket miktar�n� 5 ile 15 aras�nda rastgele belirliyoruz.
            int move1 = rand.Next(5, 15);
            int move2 = rand.Next(5, 15);

            pictureBox1.Left += move1;
            pictureBox2.Left += move2;

            // E�er herhangi biri biti� �izgisine ula�t�ysa yar��� durdur.
            if (pictureBox1.Left >= finishLine || pictureBox2.Left >= finishLine)
            {
                raceTimer.Stop();

                // Her iki geyik de ayn� anda ula��rsa berabere.
                if (pictureBox1.Left >= finishLine && pictureBox2.Left >= finishLine)
                {
                    resultLabel.Text = "Berabere!";
                }
                else
                {
                    // Hangisi �nce biti�e ula�t�ysa o kazanan.
                    int winningDeer = (pictureBox1.Left >= finishLine) ? 1 : 2;
                    // Kullan�c�n�n se�imi ile kar��la�t�r.
                    if (winningDeer == userGuess)
                    {
                        resultLabel.Text = $"{winningDeer}. Geyik kazand�! Do�ru tahmin: Kazand�n�z!";
                    }
                    else
                    {
                        resultLabel.Text = $"{winningDeer}. Geyik kazand�! Yanl�� tahmin: Kaybettiniz!";
                    }
                }
            }
        }
    }
}
