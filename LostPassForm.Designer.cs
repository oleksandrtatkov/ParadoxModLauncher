using ParadoxModLauncher.Resources.scripts;

namespace ParadoxModLauncher
{
    partial class LostPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LostPassForm));
            BackgroundPanel = new TransparentPanel();
            BackButton = new Button();
            LoginBox = new TextBox();
            OrLabel = new TransparentLabel();
            NewPassBox = new TextBox();
            OldPassBox = new TextBox();
            SecretPhraseBox = new TextBox();
            PassRecoveryLabel = new TransparentLabel();
            BackgroundPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.BackColor = SystemColors.ActiveCaptionText;
            BackgroundPanel.Controls.Add(BackButton);
            BackgroundPanel.Controls.Add(LoginBox);
            BackgroundPanel.Controls.Add(OrLabel);
            BackgroundPanel.Controls.Add(NewPassBox);
            BackgroundPanel.Controls.Add(OldPassBox);
            BackgroundPanel.Controls.Add(SecretPhraseBox);
            BackgroundPanel.Controls.Add(PassRecoveryLabel);
            BackgroundPanel.Dock = DockStyle.Fill;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.Size = new Size(632, 493);
            BackgroundPanel.TabIndex = 0;
            // 
            // BackButton
            // 
            BackButton.BackgroundImage = Properties.Resources.back;
            BackButton.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Location = new Point(40, 25);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(32, 32);
            BackButton.TabIndex = 8;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += Back;
            // 
            // LoginBox
            // 
            LoginBox.Location = new Point(225, 85);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(204, 27);
            LoginBox.TabIndex = 5;
            LoginBox.Text = "Логін";
            LoginBox.KeyDown += LoginBox_KeyDown;
            // 
            // OrLabel
            // 
            OrLabel.AutoSize = true;
            OrLabel.BackColor = SystemColors.ButtonHighlight;
            OrLabel.Font = new Font("Garamond", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrLabel.ForeColor = SystemColors.ButtonHighlight;
            OrLabel.Location = new Point(307, 191);
            OrLabel.Name = "OrLabel";
            OrLabel.Size = new Size(47, 26);
            OrLabel.TabIndex = 4;
            OrLabel.Text = "або";
            // 
            // NewPassBox
            // 
            NewPassBox.Location = new Point(225, 317);
            NewPassBox.Name = "NewPassBox";
            NewPassBox.Size = new Size(204, 27);
            NewPassBox.TabIndex = 3;
            NewPassBox.Text = "Новий пароль";
            NewPassBox.KeyDown += NewPassBox_KeyDown;
            // 
            // OldPassBox
            // 
            OldPassBox.Location = new Point(225, 229);
            OldPassBox.Name = "OldPassBox";
            OldPassBox.Size = new Size(204, 27);
            OldPassBox.TabIndex = 2;
            OldPassBox.Text = "Старий пароль";
            OldPassBox.KeyDown += OldPassBox_KeyDown;
            // 
            // SecretPhraseBox
            // 
            SecretPhraseBox.Location = new Point(225, 147);
            SecretPhraseBox.Name = "SecretPhraseBox";
            SecretPhraseBox.Size = new Size(204, 27);
            SecretPhraseBox.TabIndex = 1;
            SecretPhraseBox.Text = "Секретна фраза";
            SecretPhraseBox.KeyDown += SecretPhraseBox_KeyDown;
            // 
            // PassRecoveryLabel
            // 
            PassRecoveryLabel.AutoSize = true;
            PassRecoveryLabel.BackColor = SystemColors.ButtonHighlight;
            PassRecoveryLabel.Font = new Font("Garamond", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PassRecoveryLabel.ForeColor = SystemColors.ButtonHighlight;
            PassRecoveryLabel.Location = new Point(211, 18);
            PassRecoveryLabel.Name = "PassRecoveryLabel";
            PassRecoveryLabel.Size = new Size(218, 26);
            PassRecoveryLabel.TabIndex = 0;
            PassRecoveryLabel.Text = "Відновлення пароля";
            // 
            // LostPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.paradox_interactive_997263;
            ClientSize = new Size(632, 493);
            Controls.Add(BackgroundPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(100, 100);
            MaximizeBox = false;
            Name = "LostPassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Відновлення паролю";
            FormClosing += LostPassForm_FormClosing;
            BackgroundPanel.ResumeLayout(false);
            BackgroundPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Resources.scripts.TransparentPanel BackgroundPanel;
        private Resources.scripts.TransparentLabel PassRecoveryLabel;
        private TextBox OldPassBox;
        private TextBox SecretPhraseBox;
        private TextBox NewPassBox;
        private Resources.scripts.TransparentLabel OrLabel;
        private TextBox LoginBox;
        private Button BackButton;
    }
}