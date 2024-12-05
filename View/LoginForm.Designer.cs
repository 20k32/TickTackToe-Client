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
            loginButton = new Krypton.Toolkit.KryptonButton();
            registerButton = new Krypton.Toolkit.KryptonButton();
            statusLabel = new Krypton.Toolkit.KryptonLabel();
            statusValueLabel = new Krypton.Toolkit.KryptonWrapLabel();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            kryptonLabel1.Location = new Point(83, 42);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(100, 36);
            kryptonLabel1.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Name:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(33, 86);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(150, 36);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Password:";
            // 
            // userNameTextBlock
            // 
            userNameTextBlock.Location = new Point(210, 40);
            userNameTextBlock.Name = "userNameTextBlock";
            userNameTextBlock.Size = new Size(180, 38);
            userNameTextBlock.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userNameTextBlock.StateNormal.Content.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            userNameTextBlock.TabIndex = 2;
            // 
            // userPasswordMaskedTextBlock
            // 
            userPasswordMaskedTextBlock.Location = new Point(210, 84);
            userPasswordMaskedTextBlock.Name = "userPasswordMaskedTextBlock";
            userPasswordMaskedTextBlock.Size = new Size(180, 38);
            userPasswordMaskedTextBlock.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userPasswordMaskedTextBlock.StateNormal.Content.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            userPasswordMaskedTextBlock.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(33, 140);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(180, 51);
            loginButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginButton.TabIndex = 5;
            loginButton.Values.DropDownArrowColor = Color.Empty;
            loginButton.Values.Text = "Login";
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(219, 140);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(171, 51);
            registerButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerButton.TabIndex = 6;
            registerButton.Values.DropDownArrowColor = Color.Empty;
            registerButton.Values.Text = "Register";
            registerButton.Click += registerButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.Location = new Point(33, 208);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(106, 36);
            statusLabel.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            statusLabel.TabIndex = 7;
            statusLabel.Values.Text = "Status:";
            // 
            // statusValueLabel
            // 
            statusValueLabel.AutoSize = false;
            statusValueLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            statusValueLabel.ForeColor = Color.FromArgb(30, 57, 91);
            statusValueLabel.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            statusValueLabel.Location = new Point(160, 208);
            statusValueLabel.MaximumSize = new Size(230, 130);
            statusValueLabel.MinimumSize = new Size(230, 130);
            statusValueLabel.Name = "statusValueLabel";
            statusValueLabel.Size = new Size(230, 130);
            statusValueLabel.StateCommon.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 353);
            Controls.Add(statusValueLabel);
            Controls.Add(statusLabel);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(userPasswordMaskedTextBlock);
            Controls.Add(userNameTextBlock);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(431, 392);
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
        private Krypton.Toolkit.KryptonButton loginButton;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel statusLabel;
        private Krypton.Toolkit.KryptonWrapLabel statusValueLabel;
        private Krypton.Toolkit.KryptonButton registerButton;
    }
}