namespace TickTackToe.View
{
    partial class LoginForm
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
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            userNameTextBlock = new Krypton.Toolkit.KryptonTextBox();
            userPasswordMaskedTextBlock = new Krypton.Toolkit.KryptonMaskedTextBox();
            cancelButton = new Krypton.Toolkit.KryptonButton();
            loginButton = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            statusLabel = new Krypton.Toolkit.KryptonLabel();
            statusValueLabel = new Krypton.Toolkit.KryptonWrapLabel();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(170, 139);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(46, 20);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Name:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(151, 180);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(65, 20);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Password:";
            // 
            // userNameTextBlock
            // 
            userNameTextBlock.Location = new Point(245, 136);
            userNameTextBlock.Name = "userNameTextBlock";
            userNameTextBlock.Size = new Size(100, 23);
            userNameTextBlock.TabIndex = 2;
            // 
            // userPasswordMaskedTextBlock
            // 
            userPasswordMaskedTextBlock.Location = new Point(245, 180);
            userPasswordMaskedTextBlock.Name = "userPasswordMaskedTextBlock";
            userPasswordMaskedTextBlock.Size = new Size(100, 23);
            userPasswordMaskedTextBlock.TabIndex = 3;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(255, 235);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 56);
            cancelButton.TabIndex = 4;
            cancelButton.Values.DropDownArrowColor = Color.Empty;
            cancelButton.Values.Text = "Cancel";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(151, 235);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(90, 25);
            loginButton.TabIndex = 5;
            loginButton.Values.DropDownArrowColor = Color.Empty;
            loginButton.Values.Text = "Login";
            loginButton.Click += loginButton_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(151, 266);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(90, 25);
            kryptonButton1.TabIndex = 6;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Register";
            // 
            // statusLabel
            // 
            statusLabel.Location = new Point(194, 313);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(47, 20);
            statusLabel.TabIndex = 7;
            statusLabel.Values.Text = "Status:";
            // 
            // statusValueLabel
            // 
            statusValueLabel.AutoSize = false;
            statusValueLabel.Font = new Font("Segoe UI", 9F);
            statusValueLabel.ForeColor = Color.FromArgb(30, 57, 91);
            statusValueLabel.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            statusValueLabel.Location = new Point(255, 313);
            statusValueLabel.MaximumSize = new Size(200, 100);
            statusValueLabel.MinimumSize = new Size(200, 100);
            statusValueLabel.Name = "statusValueLabel";
            statusValueLabel.Size = new Size(200, 100);
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(statusValueLabel);
            Controls.Add(statusLabel);
            Controls.Add(kryptonButton1);
            Controls.Add(loginButton);
            Controls.Add(cancelButton);
            Controls.Add(userPasswordMaskedTextBlock);
            Controls.Add(userNameTextBlock);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox userNameTextBlock;
        private Krypton.Toolkit.KryptonMaskedTextBox userPasswordMaskedTextBlock;
        private Krypton.Toolkit.KryptonButton cancelButton;
        private Krypton.Toolkit.KryptonButton loginButton;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel statusLabel;
        private Krypton.Toolkit.KryptonWrapLabel statusValueLabel;
    }
}