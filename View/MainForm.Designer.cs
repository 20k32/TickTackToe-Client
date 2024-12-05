
namespace TickTackToe
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonTableLayoutPanel3 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            showInfoButton = new Krypton.Toolkit.KryptonButton();
            logRichTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            showStatsButton = new Krypton.Toolkit.KryptonButton();
            playButton = new Krypton.Toolkit.KryptonButton();
            logListBox = new Krypton.Toolkit.KryptonListBox();
            kryptonTableLayoutPanel2 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            loginButton = new Krypton.Toolkit.KryptonButton();
            kryptonTableLayoutPanel1.SuspendLayout();
            kryptonTableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            kryptonTableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ThemeName = null;
            kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage");
            kryptonTableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel1.ColumnCount = 2;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.3333321F));
            kryptonTableLayoutPanel1.Controls.Add(kryptonTableLayoutPanel3, 0, 1);
            kryptonTableLayoutPanel1.Controls.Add(kryptonPanel1, 0, 0);
            kryptonTableLayoutPanel1.Controls.Add(logListBox, 1, 1);
            kryptonTableLayoutPanel1.Controls.Add(kryptonTableLayoutPanel2, 1, 0);
            kryptonTableLayoutPanel1.Dock = DockStyle.Fill;
            kryptonTableLayoutPanel1.Location = new Point(0, 0);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 2;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 294F));
            kryptonTableLayoutPanel1.Size = new Size(800, 450);
            kryptonTableLayoutPanel1.TabIndex = 6;
            // 
            // kryptonTableLayoutPanel3
            // 
            kryptonTableLayoutPanel3.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel3.BackgroundImage");
            kryptonTableLayoutPanel3.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel3.ColumnCount = 1;
            kryptonTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel3.Controls.Add(showInfoButton, 0, 1);
            kryptonTableLayoutPanel3.Controls.Add(logRichTextBox, 0, 0);
            kryptonTableLayoutPanel3.Dock = DockStyle.Fill;
            kryptonTableLayoutPanel3.Location = new Point(3, 159);
            kryptonTableLayoutPanel3.Name = "kryptonTableLayoutPanel3";
            kryptonTableLayoutPanel3.RowCount = 2;
            kryptonTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel3.Size = new Size(327, 288);
            kryptonTableLayoutPanel3.TabIndex = 11;
            // 
            // showInfoButton
            // 
            showInfoButton.Dock = DockStyle.Bottom;
            showInfoButton.Location = new Point(3, 205);
            showInfoButton.MaximumSize = new Size(80, 80);
            showInfoButton.MinimumSize = new Size(80, 80);
            showInfoButton.Name = "showInfoButton";
            showInfoButton.Size = new Size(80, 80);
            showInfoButton.StateCommon.Border.Rounding = 80F;
            showInfoButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showInfoButton.TabIndex = 2;
            showInfoButton.Values.DropDownArrowColor = Color.Empty;
            showInfoButton.Values.Text = "Info";
            // 
            // logRichTextBox
            // 
            logRichTextBox.Dock = DockStyle.Fill;
            logRichTextBox.Location = new Point(3, 3);
            logRichTextBox.Name = "logRichTextBox";
            logRichTextBox.ReadOnly = true;
            logRichTextBox.Size = new Size(321, 138);
            logRichTextBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logRichTextBox.TabIndex = 3;
            logRichTextBox.Text = "";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(showStatsButton);
            kryptonPanel1.Controls.Add(playButton);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Margin = new Padding(0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(333, 156);
            kryptonPanel1.TabIndex = 6;
            // 
            // showStatsButton
            // 
            showStatsButton.Dock = DockStyle.Top;
            showStatsButton.Location = new Point(0, 77);
            showStatsButton.Name = "showStatsButton";
            showStatsButton.Size = new Size(333, 77);
            showStatsButton.StateCommon.Border.Rounding = 25F;
            showStatsButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showStatsButton.TabIndex = 1;
            showStatsButton.Values.DropDownArrowColor = Color.Empty;
            showStatsButton.Values.Text = "Show Stats";
            showStatsButton.Click += OnShowStatsButtonClick;
            // 
            // playButton
            // 
            playButton.Dock = DockStyle.Top;
            playButton.Location = new Point(0, 0);
            playButton.Name = "playButton";
            playButton.Size = new Size(333, 77);
            playButton.StateCommon.Border.Rounding = 25F;
            playButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            playButton.TabIndex = 0;
            playButton.Values.DropDownArrowColor = Color.Empty;
            playButton.Values.Text = "Play";
            playButton.Click += playButton_Click;
            // 
            // logListBox
            // 
            logListBox.Dock = DockStyle.Fill;
            logListBox.Location = new Point(336, 159);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(461, 288);
            logListBox.StateCommon.Item.Content.LongText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logListBox.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logListBox.TabIndex = 7;
            // 
            // kryptonTableLayoutPanel2
            // 
            kryptonTableLayoutPanel2.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel2.BackgroundImage");
            kryptonTableLayoutPanel2.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel2.ColumnCount = 1;
            kryptonTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.Controls.Add(loginButton, 0, 0);
            kryptonTableLayoutPanel2.Dock = DockStyle.Fill;
            kryptonTableLayoutPanel2.Location = new Point(336, 3);
            kryptonTableLayoutPanel2.Name = "kryptonTableLayoutPanel2";
            kryptonTableLayoutPanel2.RowCount = 2;
            kryptonTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.Size = new Size(461, 150);
            kryptonTableLayoutPanel2.TabIndex = 8;
            // 
            // loginButton
            // 
            loginButton.Dock = DockStyle.Right;
            loginButton.Location = new Point(378, 3);
            loginButton.MaximumSize = new Size(80, 80);
            loginButton.MinimumSize = new Size(80, 80);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(80, 80);
            loginButton.StateCommon.Border.Rounding = 80F;
            loginButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginButton.TabIndex = 2;
            loginButton.ToolTipValues.Description = "Login or signup";
            loginButton.ToolTipValues.EnableToolTips = true;
            loginButton.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.Center;
            loginButton.Values.DropDownArrowColor = Color.Empty;
            loginButton.Values.Text = "Login";
            loginButton.Click += OnLoginButtonClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(kryptonTableLayoutPanel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainForm";
            Text = "TickTackToe";
            kryptonTableLayoutPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonListBox logListBox;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton showStatsButton;
        private Krypton.Toolkit.KryptonButton playButton;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton loginButton;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel3;
        private Krypton.Toolkit.KryptonButton showInfoButton;
        private Krypton.Toolkit.KryptonRichTextBox logRichTextBox;
    }
}
