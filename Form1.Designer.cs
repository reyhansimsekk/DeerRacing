namespace racingFinal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox guessComboBox;
        private System.Windows.Forms.Label guessLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.guessComboBox = new System.Windows.Forms.ComboBox();
            this.guessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();

            // guessLabel
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(12, 15);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(160, 13);
            this.guessLabel.TabIndex = 0;
            this.guessLabel.Text = "Geyik Seçiniz (1 veya 2):";

            // guessComboBox
            this.guessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guessComboBox.FormattingEnabled = true;
            this.guessComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.guessComboBox.Location = new System.Drawing.Point(180, 12);
            this.guessComboBox.Name = "guessComboBox";
            this.guessComboBox.Size = new System.Drawing.Size(60, 21);
            this.guessComboBox.TabIndex = 1;

            // pictureBox1
            this.pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\Reyhan\Desktop\deer.png");
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // pictureBox2
            this.pictureBox2.Image = System.Drawing.Image.FromFile(@"C:\Users\Reyhan\Desktop\deer.png");
            this.pictureBox2.Location = new System.Drawing.Point(12, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // startButton
            this.startButton.Location = new System.Drawing.Point(12, 250);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 30);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Yarışı Başlat";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);

            // resultLabel
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(200, 260);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 3;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.guessComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resultLabel);
            this.Name = "Form1";
            this.Text = "Resim Yarışı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
