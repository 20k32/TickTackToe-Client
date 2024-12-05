
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            RatingLabel = new Krypton.Toolkit.KryptonLabel();
            userRatingLabel = new Krypton.Toolkit.KryptonLabel();
            DisplayNameLabel = new Krypton.Toolkit.KryptonLabel();
            userNameLabel = new Krypton.Toolkit.KryptonLabel();
            ListOfGamesLabel = new Krypton.Toolkit.KryptonLabel();
            statsGrid = new Krypton.Toolkit.KryptonDataGridView();
            OpponentColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            RatingColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            TimeTakenColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)statsGrid).BeginInit();
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
            // userRatingLabel
            // 
            userRatingLabel.Location = new Point(103, 12);
            userRatingLabel.Name = "userRatingLabel";
            userRatingLabel.Size = new Size(17, 20);
            userRatingLabel.TabIndex = 1;
            userRatingLabel.Values.Text = "0";
            // 
            // DisplayNameLabel
            // 
            DisplayNameLabel.Location = new Point(12, 38);
            DisplayNameLabel.Name = "DisplayNameLabel";
            DisplayNameLabel.Size = new Size(86, 20);
            DisplayNameLabel.TabIndex = 2;
            DisplayNameLabel.Values.Text = "Display name:";
            // 
            // userNameLabel
            // 
            userNameLabel.Location = new Point(104, 38);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(26, 20);
            userNameLabel.TabIndex = 3;
            userNameLabel.Values.Text = "___";
            // 
            // ListOfGamesLabel
            // 
            ListOfGamesLabel.Location = new Point(12, 64);
            ListOfGamesLabel.Name = "ListOfGamesLabel";
            ListOfGamesLabel.Size = new Size(50, 20);
            ListOfGamesLabel.TabIndex = 6;
            ListOfGamesLabel.Values.Text = "Games:";
            // 
            // statsGrid
            // 
            statsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            statsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            statsGrid.BorderStyle = BorderStyle.None;
            statsGrid.Columns.AddRange(new DataGridViewColumn[] { OpponentColumn, RatingColumn, TimeTakenColumn });
            statsGrid.Location = new Point(12, 104);
            statsGrid.Name = "statsGrid";
            statsGrid.Size = new Size(460, 345);
            statsGrid.TabIndex = 7;
            // 
            // OpponentColumn
            // 
            OpponentColumn.DefaultCellStyle = dataGridViewCellStyle1;
            OpponentColumn.HeaderText = "Opponent";
            OpponentColumn.Name = "OpponentColumn";
            OpponentColumn.ReadOnly = true;
            OpponentColumn.Resizable = DataGridViewTriState.True;
            OpponentColumn.Width = 140;
            // 
            // RatingColumn
            // 
            RatingColumn.DefaultCellStyle = dataGridViewCellStyle2;
            RatingColumn.HeaderText = "Points received";
            RatingColumn.Name = "RatingColumn";
            RatingColumn.ReadOnly = true;
            RatingColumn.Width = 139;
            // 
            // TimeTakenColumn
            // 
            TimeTakenColumn.DefaultCellStyle = dataGridViewCellStyle3;
            TimeTakenColumn.HeaderText = "TimeTaken";
            TimeTakenColumn.Name = "TimeTakenColumn";
            TimeTakenColumn.ReadOnly = true;
            TimeTakenColumn.Width = 140;
            // 
            // StatsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(statsGrid);
            Controls.Add(ListOfGamesLabel);
            Controls.Add(userNameLabel);
            Controls.Add(DisplayNameLabel);
            Controls.Add(userRatingLabel);
            Controls.Add(RatingLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StatsForm";
            ((System.ComponentModel.ISupportInitialize)statsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel RatingLabel;
        private Krypton.Toolkit.KryptonLabel userRatingLabel;
        private Krypton.Toolkit.KryptonLabel DisplayNameLabel;
        private Krypton.Toolkit.KryptonLabel userNameLabel;
        private Krypton.Toolkit.KryptonLabel ListOfGamesLabel;
        private Krypton.Toolkit.KryptonDataGridView statsGrid;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn OpponentColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn RatingColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn TimeTakenColumn;
    }
}