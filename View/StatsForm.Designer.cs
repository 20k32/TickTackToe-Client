
namespace TickTackToe.View
{
    partial class StatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RatingLabel = new Krypton.Toolkit.KryptonLabel();
            CurrentRatingValue = new Krypton.Toolkit.KryptonLabel();
            DisplayNameLabel = new Krypton.Toolkit.KryptonLabel();
            DisplayNameValueLabel = new Krypton.Toolkit.KryptonLabel();
            EmailLabel = new Krypton.Toolkit.KryptonLabel();
            EmailValueLabel = new Krypton.Toolkit.KryptonLabel();
            ListOfGamesLabel = new Krypton.Toolkit.KryptonLabel();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            SuspendLayout();
            // 
            // RatingLabel
            // 
            RatingLabel.Location = new Point(12, 12);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(85, 20);
            RatingLabel.TabIndex = 0;
            RatingLabel.Values.Text = "Curent rating:";
            // 
            // CurrentRatingValue
            // 
            CurrentRatingValue.Location = new Point(103, 12);
            CurrentRatingValue.Name = "CurrentRatingValue";
            CurrentRatingValue.Size = new Size(17, 20);
            CurrentRatingValue.TabIndex = 1;
            CurrentRatingValue.Values.Text = "0";
            // 
            // DisplayNameLabel
            // 
            DisplayNameLabel.Location = new Point(12, 38);
            DisplayNameLabel.Name = "DisplayNameLabel";
            DisplayNameLabel.Size = new Size(86, 20);
            DisplayNameLabel.TabIndex = 2;
            DisplayNameLabel.Values.Text = "Display name:";
            // 
            // DisplayNameValueLabel
            // 
            DisplayNameValueLabel.Location = new Point(104, 38);
            DisplayNameValueLabel.Name = "DisplayNameValueLabel";
            DisplayNameValueLabel.Size = new Size(26, 20);
            DisplayNameValueLabel.TabIndex = 3;
            DisplayNameValueLabel.Values.Text = "___";
            // 
            // EmailLabel
            // 
            EmailLabel.Location = new Point(12, 64);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(42, 20);
            EmailLabel.TabIndex = 4;
            EmailLabel.Values.Text = "Email:";
            // 
            // EmailValueLabel
            // 
            EmailValueLabel.Location = new Point(104, 64);
            EmailValueLabel.Name = "EmailValueLabel";
            EmailValueLabel.Size = new Size(26, 20);
            EmailValueLabel.TabIndex = 5;
            EmailValueLabel.Values.Text = "___";
            // 
            // ListOfGamesLabel
            // 
            ListOfGamesLabel.Location = new Point(12, 90);
            ListOfGamesLabel.Name = "ListOfGamesLabel";
            ListOfGamesLabel.Size = new Size(50, 20);
            ListOfGamesLabel.TabIndex = 6;
            ListOfGamesLabel.Values.Text = "Games:";
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Location = new Point(12, 116);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new Size(460, 333);
            kryptonListBox1.TabIndex = 7;
            // 
            // StatsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(kryptonListBox1);
            Controls.Add(ListOfGamesLabel);
            Controls.Add(EmailValueLabel);
            Controls.Add(EmailLabel);
            Controls.Add(DisplayNameValueLabel);
            Controls.Add(DisplayNameLabel);
            Controls.Add(CurrentRatingValue);
            Controls.Add(RatingLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StatsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel RatingLabel;
        private Krypton.Toolkit.KryptonLabel CurrentRatingValue;
        private Krypton.Toolkit.KryptonLabel DisplayNameLabel;
        private Krypton.Toolkit.KryptonLabel DisplayNameValueLabel;
        private Krypton.Toolkit.KryptonLabel EmailLabel;
        private Krypton.Toolkit.KryptonLabel EmailValueLabel;
        private Krypton.Toolkit.KryptonLabel ListOfGamesLabel;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
    }
}