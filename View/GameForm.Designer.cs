
namespace TickTackToe.View
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            statusLabel = new Krypton.Toolkit.KryptonLabel();
            timerLabel = new Krypton.Toolkit.KryptonLabel();
            kryptonTableLayoutPanel2 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            game22Button = new Krypton.Toolkit.KryptonButton();
            game21Button = new Krypton.Toolkit.KryptonButton();
            game20Button = new Krypton.Toolkit.KryptonButton();
            game12Button = new Krypton.Toolkit.KryptonButton();
            game11Button = new Krypton.Toolkit.KryptonButton();
            game10Button = new Krypton.Toolkit.KryptonButton();
            game00button = new Krypton.Toolkit.KryptonButton();
            game02Button = new Krypton.Toolkit.KryptonButton();
            game01Button = new Krypton.Toolkit.KryptonButton();
            statusTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonTableLayoutPanel1.SuspendLayout();
            kryptonTableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage");
            kryptonTableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel1.ColumnCount = 3;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            kryptonTableLayoutPanel1.Controls.Add(statusLabel, 0, 0);
            kryptonTableLayoutPanel1.Controls.Add(timerLabel, 1, 0);
            kryptonTableLayoutPanel1.Controls.Add(kryptonTableLayoutPanel2, 1, 1);
            kryptonTableLayoutPanel1.Controls.Add(statusTextBox, 0, 1);
            kryptonTableLayoutPanel1.Dock = DockStyle.Fill;
            kryptonTableLayoutPanel1.Location = new Point(0, 0);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 3;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            kryptonTableLayoutPanel1.Size = new Size(800, 450);
            kryptonTableLayoutPanel1.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Location = new Point(3, 3);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(114, 61);
            statusLabel.TabIndex = 3;
            statusLabel.Values.Text = "_";
            // 
            // timerLabel
            // 
            timerLabel.Dock = DockStyle.Fill;
            timerLabel.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            timerLabel.Location = new Point(123, 3);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(554, 61);
            timerLabel.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            timerLabel.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            timerLabel.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            timerLabel.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            timerLabel.TabIndex = 0;
            timerLabel.Values.Text = "00:00";
            // 
            // kryptonTableLayoutPanel2
            // 
            kryptonTableLayoutPanel2.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel2.BackgroundImage");
            kryptonTableLayoutPanel2.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel2.ColumnCount = 3;
            kryptonTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            kryptonTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            kryptonTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            kryptonTableLayoutPanel2.Controls.Add(game22Button, 2, 2);
            kryptonTableLayoutPanel2.Controls.Add(game21Button, 1, 2);
            kryptonTableLayoutPanel2.Controls.Add(game20Button, 0, 2);
            kryptonTableLayoutPanel2.Controls.Add(game12Button, 2, 1);
            kryptonTableLayoutPanel2.Controls.Add(game11Button, 1, 1);
            kryptonTableLayoutPanel2.Controls.Add(game10Button, 0, 1);
            kryptonTableLayoutPanel2.Controls.Add(game00button, 0, 0);
            kryptonTableLayoutPanel2.Controls.Add(game02Button, 2, 0);
            kryptonTableLayoutPanel2.Controls.Add(game01Button, 1, 0);
            kryptonTableLayoutPanel2.Dock = DockStyle.Fill;
            kryptonTableLayoutPanel2.Location = new Point(123, 70);
            kryptonTableLayoutPanel2.Name = "kryptonTableLayoutPanel2";
            kryptonTableLayoutPanel2.RowCount = 3;
            kryptonTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            kryptonTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            kryptonTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            kryptonTableLayoutPanel2.Size = new Size(554, 309);
            kryptonTableLayoutPanel2.TabIndex = 1;
            // 
            // game22Button
            // 
            game22Button.Dock = DockStyle.Fill;
            game22Button.Location = new Point(371, 209);
            game22Button.Name = "game22Button";
            game22Button.Size = new Size(180, 97);
            game22Button.TabIndex = 8;
            game22Button.Values.DropDownArrowColor = Color.Empty;
            game22Button.Values.Text = "";
            game22Button.Click += game22Button_Click;
            // 
            // game21Button
            // 
            game21Button.Dock = DockStyle.Fill;
            game21Button.Location = new Point(187, 209);
            game21Button.Name = "game21Button";
            game21Button.Size = new Size(178, 97);
            game21Button.TabIndex = 7;
            game21Button.Values.DropDownArrowColor = Color.Empty;
            game21Button.Values.Text = "";
            game21Button.Click += game21Button_Click;
            // 
            // game20Button
            // 
            game20Button.Dock = DockStyle.Fill;
            game20Button.Location = new Point(3, 209);
            game20Button.Name = "game20Button";
            game20Button.Size = new Size(178, 97);
            game20Button.TabIndex = 6;
            game20Button.Values.DropDownArrowColor = Color.Empty;
            game20Button.Values.Text = "";
            game20Button.Click += game20Button_Click;
            // 
            // game12Button
            // 
            game12Button.Dock = DockStyle.Fill;
            game12Button.Location = new Point(371, 106);
            game12Button.Name = "game12Button";
            game12Button.Size = new Size(180, 97);
            game12Button.TabIndex = 5;
            game12Button.Values.DropDownArrowColor = Color.Empty;
            game12Button.Values.Text = "";
            game12Button.Click += game12Button_Click;
            // 
            // game11Button
            // 
            game11Button.Dock = DockStyle.Fill;
            game11Button.Location = new Point(187, 106);
            game11Button.Name = "game11Button";
            game11Button.Size = new Size(178, 97);
            game11Button.TabIndex = 4;
            game11Button.Values.DropDownArrowColor = Color.Empty;
            game11Button.Values.Text = "";
            game11Button.Click += game11Button_Click;
            // 
            // game10Button
            // 
            game10Button.Dock = DockStyle.Fill;
            game10Button.Location = new Point(3, 106);
            game10Button.Name = "game10Button";
            game10Button.Size = new Size(178, 97);
            game10Button.TabIndex = 3;
            game10Button.Values.DropDownArrowColor = Color.Empty;
            game10Button.Values.Text = "";
            game10Button.Click += game10Button_Click;
            // 
            // game00button
            // 
            game00button.Dock = DockStyle.Fill;
            game00button.Location = new Point(3, 3);
            game00button.Name = "game00button";
            game00button.Size = new Size(178, 97);
            game00button.TabIndex = 0;
            game00button.Values.DropDownArrowColor = Color.Empty;
            game00button.Values.Text = "";
            game00button.Click += game00button_Click;
            // 
            // game02Button
            // 
            game02Button.Dock = DockStyle.Fill;
            game02Button.Location = new Point(371, 3);
            game02Button.Name = "game02Button";
            game02Button.Size = new Size(180, 97);
            game02Button.TabIndex = 1;
            game02Button.Values.DropDownArrowColor = Color.Empty;
            game02Button.Values.Text = "";
            game02Button.Click += game02Button_Click;
            // 
            // game01Button
            // 
            game01Button.Dock = DockStyle.Fill;
            game01Button.Location = new Point(187, 3);
            game01Button.Name = "game01Button";
            game01Button.Size = new Size(178, 97);
            game01Button.TabIndex = 2;
            game01Button.Values.DropDownArrowColor = Color.Empty;
            game01Button.Values.Text = "";
            game01Button.Click += game01Button_Click;
            // 
            // statusTextBox
            // 
            statusTextBox.Dock = DockStyle.Fill;
            statusTextBox.Location = new Point(3, 70);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(114, 309);
            statusTextBox.TabIndex = 4;
            statusTextBox.Text = "";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kryptonTableLayoutPanel1);
            Name = "GameForm";
            Text = "GameForm";
            kryptonTableLayoutPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel1.PerformLayout();
            kryptonTableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel timerLabel;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton game22Button;
        private Krypton.Toolkit.KryptonButton game21Button;
        private Krypton.Toolkit.KryptonButton game20Button;
        private Krypton.Toolkit.KryptonButton game12Button;
        private Krypton.Toolkit.KryptonButton game11Button;
        private Krypton.Toolkit.KryptonButton game10Button;
        private Krypton.Toolkit.KryptonButton game00button;
        private Krypton.Toolkit.KryptonButton game02Button;
        private Krypton.Toolkit.KryptonButton game01Button;
        private Krypton.Toolkit.KryptonLabel statusLabel;
        private Krypton.Toolkit.KryptonRichTextBox statusTextBox;
    }
}