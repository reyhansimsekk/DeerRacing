using System;
using System.Windows.Forms;

namespace racingFinal
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        // Belirsiz Timer referansýný önlemek için tam nitelikli Timer kullanýyoruz.
        private System.Windows.Forms.Timer raceTimer;
        private int finishLine = 700; // Bitiþ çizgisi X koordinatý
        private int userGuess = 0;     // Kullanýcýnýn seçtiði geyik numarasý (1 veya 2)

        public Form1()
        {
            InitializeComponent();
            InitializeRaceTimer();
        }

        private void InitializeRaceTimer()
        {
            // Daha akýcý hareket için interval 50 ms olarak ayarlandý.
            raceTimer = new System.Windows.Forms.Timer
            {
                Interval = 50
            };
            raceTimer.Tick += RaceTimer_Tick;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Kullanýcýnýn seçim yapýp yapmadýðýný kontrol ediyoruz.
            if (guessComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen 1 veya 2 numaralý geyik seçiniz.");
                return;
            }
            userGuess = int.Parse(guessComboBox.SelectedItem.ToString());

            // Yarýþa baþlamadan önce resimlerin pozisyonlarýný sýfýrla.
            pictureBox1.Left = 12;
            pictureBox2.Left = 12;
            resultLabel.Text = "";
            raceTimer.Start();
        }

        private void RaceTimer_Tick(object sender, EventArgs e)
        {
            // Hareket miktarýný 5 ile 15 arasýnda rastgele belirliyoruz.
            int move1 = rand.Next(5, 15);
            int move2 = rand.Next(5, 15);

            pictureBox1.Left += move1;
            pictureBox2.Left += move2;

            // Eðer herhangi biri bitiþ çizgisine ulaþtýysa yarýþý durdur.
            if (pictureBox1.Left >= finishLine || pictureBox2.Left >= finishLine)
            {
                raceTimer.Stop();

                // Her iki geyik de ayný anda ulaþýrsa berabere.
                if (pictureBox1.Left >= finishLine && pictureBox2.Left >= finishLine)
                {
                    resultLabel.Text = "Berabere!";
                }
                else
                {
                    // Hangisi önce bitiþe ulaþtýysa o kazanan.
                    int winningDeer = (pictureBox1.Left >= finishLine) ? 1 : 2;
                    // Kullanýcýnýn seçimi ile karþýlaþtýr.
                    if (winningDeer == userGuess)
                    {
                        resultLabel.Text = $"{winningDeer}. Geyik kazandý! Doðru tahmin: Kazandýnýz!";
                    }
                    else
                    {
                        resultLabel.Text = $"{winningDeer}. Geyik kazandý! Yanlýþ tahmin: Kaybettiniz!";
                    }
                }
            }
        }
    }
}
