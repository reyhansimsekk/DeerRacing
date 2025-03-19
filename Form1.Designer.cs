namespace RacingFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            startButton = new Button();
            resultLabel = new Label();
            guessComboBox = new ComboBox();
            guessLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 58);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 173);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Lavender;
            startButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            startButton.ForeColor = Color.Olive;
            startButton.Location = new Point(384, 371);
            startButton.Margin = new Padding(4, 3, 4, 3);
            startButton.Name = "startButton";
            startButton.Size = new Size(175, 35);
            startButton.TabIndex = 2;
            startButton.Text = "Start Race";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(233, 300);
            resultLabel.Margin = new Padding(4, 0, 4, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 3;
            // 
            // guessComboBox
            // 
            guessComboBox.BackColor = Color.Lavender;
            guessComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            guessComboBox.FormattingEnabled = true;
            guessComboBox.Items.AddRange(new object[] { "1", "2" });
            guessComboBox.Location = new Point(175, 14);
            guessComboBox.Margin = new Padding(4, 3, 4, 3);
            guessComboBox.Name = "guessComboBox";
            guessComboBox.Size = new Size(69, 23);
            guessComboBox.TabIndex = 1;
            // 
            // guessLabel
            // 
            guessLabel.AutoSize = true;
            guessLabel.ForeColor = Color.Olive;
            guessLabel.Location = new Point(14, 17);
            guessLabel.Margin = new Padding(4, 0, 4, 0);
            guessLabel.Name = "guessLabel";
            guessLabel.Size = new Size(117, 15);
            guessLabel.TabIndex = 0;
            guessLabel.Text = "Select a Deer (1 or 2):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(933, 418);
            Controls.Add(guessLabel);
            Controls.Add(guessComboBox);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(startButton);
            Controls.Add(resultLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Picture Race";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
