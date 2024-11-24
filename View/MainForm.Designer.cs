
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
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            showStatsButton = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
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
            kryptonTableLayoutPanel1.Controls.Add(kryptonListBox1, 1, 1);
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
            kryptonTableLayoutPanel3.Controls.Add(kryptonButton4, 0, 1);
            kryptonTableLayoutPanel3.Dock = DockStyle.Fill;
            kryptonTableLayoutPanel3.Location = new Point(3, 159);
            kryptonTableLayoutPanel3.Name = "kryptonTableLayoutPanel3";
            kryptonTableLayoutPanel3.RowCount = 2;
            kryptonTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel3.Size = new Size(327, 288);
            kryptonTableLayoutPanel3.TabIndex = 11;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Dock = DockStyle.Bottom;
            kryptonButton4.Location = new Point(3, 205);
            kryptonButton4.MaximumSize = new Size(80, 80);
            kryptonButton4.MinimumSize = new Size(80, 80);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(80, 80);
            kryptonButton4.StateCommon.Border.Rounding = 80F;
            kryptonButton4.TabIndex = 2;
            kryptonButton4.Values.DropDownArrowColor = Color.Empty;
            kryptonButton4.Values.Text = "Info";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(showStatsButton);
            kryptonPanel1.Controls.Add(kryptonButton1);
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
            showStatsButton.TabIndex = 1;
            showStatsButton.Values.DropDownArrowColor = Color.Empty;
            showStatsButton.Values.Text = "Show Stats";
            showStatsButton.Click += OnShowStatsButtonClick;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Dock = DockStyle.Top;
            kryptonButton1.Location = new Point(0, 0);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(333, 77);
            kryptonButton1.StateCommon.Border.Rounding = 25F;
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Play";
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Dock = DockStyle.Fill;
            kryptonListBox1.Location = new Point(336, 159);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new Size(461, 288);
            kryptonListBox1.TabIndex = 7;
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
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton showStatsButton;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton loginButton;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
    }
}
