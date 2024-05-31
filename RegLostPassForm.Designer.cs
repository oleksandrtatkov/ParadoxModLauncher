using ParadoxModLauncher.Resources.scripts;

namespace ParadoxModLauncher
{
    partial class RegLostPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegLostPassForm));
            RegBG = new TransparentPanel();
            BackButton = new Button();
            warning2 = new TransparentLabel();
            warning = new TransparentLabel();
            RegSecretBox = new TextBox();
            NewPassLink = new TransparentLinkLabel();
            RegPassBox = new TextBox();
            RegLogBox = new TextBox();
            Reg = new TransparentLabel();
            transparentLabel1 = new TransparentLabel();
            RegBG.SuspendLayout();
            SuspendLayout();
            // 
            // RegBG
            // 
            RegBG.BackColor = Color.Black;
            RegBG.Controls.Add(transparentLabel1);
            RegBG.Controls.Add(BackButton);
            RegBG.Controls.Add(warning2);
            RegBG.Controls.Add(warning);
            RegBG.Controls.Add(RegSecretBox);
            RegBG.Controls.Add(NewPassLink);
            RegBG.Controls.Add(RegPassBox);
            RegBG.Controls.Add(RegLogBox);
            RegBG.Controls.Add(Reg);
            RegBG.Dock = DockStyle.Fill;
            RegBG.Location = new Point(0, 0);
            RegBG.Name = "RegBG";
            RegBG.Size = new Size(632, 493);
            RegBG.TabIndex = 0;
            // 
            // BackButton
            // 
            BackButton.BackgroundImage = Properties.Resources.back;
            BackButton.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Image = (Image)resources.GetObject("BackButton.Image");
            BackButton.Location = new Point(40, 25);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(32, 32);
            BackButton.TabIndex = 7;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += Back;
            // 
            // warning2
            // 
            warning2.AutoSize = true;
            warning2.BackColor = Color.LightCoral;
            warning2.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            warning2.ForeColor = Color.Coral;
            warning2.Location = new Point(138, 347);
            warning2.Name = "warning2";
            warning2.Size = new Size(380, 19);
            warning2.TabIndex = 6;
            warning2.Text = "ви не ЗМОЖЕТЕ відновити доступ до акаунтуу.";
            warning2.Click += transparentLabel1_Click_1;
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.BackColor = Color.LightCoral;
            warning.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            warning.ForeColor = Color.Coral;
            warning.Location = new Point(144, 310);
            warning.Name = "warning";
            warning.Size = new Size(360, 19);
            warning.TabIndex = 5;
            warning.Text = "Увага! При втраті пароля та секретної фразии\r\n";
            // 
            // RegSecretBox
            // 
            RegSecretBox.ForeColor = SystemColors.MenuBar;
            RegSecretBox.Location = new Point(228, 254);
            RegSecretBox.Name = "RegSecretBox";
            RegSecretBox.Size = new Size(176, 27);
            RegSecretBox.TabIndex = 4;
            RegSecretBox.Text = "Секретна фраза";
            RegSecretBox.KeyDown += SecretPhraseBox_KeyDown;
            // 
            // NewPassLink
            // 
            NewPassLink.ActiveLinkColor = Color.Red;
            NewPassLink.AutoSize = true;
            NewPassLink.BackColor = Color.Black;
            NewPassLink.DisabledLinkColor = Color.Cyan;
            NewPassLink.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NewPassLink.ForeColor = Color.Transparent;
            NewPassLink.LinkBehavior = LinkBehavior.NeverUnderline;
            NewPassLink.LinkColor = Color.Cyan;
            NewPassLink.Location = new Point(228, 395);
            NewPassLink.Name = "NewPassLink";
            NewPassLink.Size = new Size(173, 26);
            NewPassLink.TabIndex = 3;
            NewPassLink.TabStop = true;
            NewPassLink.Text = "Змінити пароль";
            NewPassLink.LinkClicked += LostPassEvent;
            // 
            // RegPassBox
            // 
            RegPassBox.ForeColor = SystemColors.MenuBar;
            RegPassBox.Location = new Point(228, 185);
            RegPassBox.Name = "RegPassBox";
            RegPassBox.Size = new Size(176, 27);
            RegPassBox.TabIndex = 2;
            RegPassBox.Text = "Пароль";
            RegPassBox.TextChanged += RegPassBox_TextChanged;
            RegPassBox.KeyDown += RegPassBox_KeyDown;
            // 
            // RegLogBox
            // 
            RegLogBox.ForeColor = SystemColors.MenuBar;
            RegLogBox.Location = new Point(228, 115);
            RegLogBox.Name = "RegLogBox";
            RegLogBox.Size = new Size(176, 27);
            RegLogBox.TabIndex = 1;
            RegLogBox.Text = "Логін";
            RegLogBox.KeyDown += RegLogBox_KeyDown;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Reg.ForeColor = SystemColors.ButtonHighlight;
            Reg.Location = new Point(258, 68);
            Reg.Name = "Reg";
            Reg.Size = new Size(123, 26);
            Reg.TabIndex = 0;
            Reg.Text = "Реестрація";
            Reg.Click += transparentLabel1_Click;
            // 
            // transparentLabel1
            // 
            transparentLabel1.AutoSize = true;
            transparentLabel1.BackColor = Color.LightCoral;
            transparentLabel1.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            transparentLabel1.ForeColor = Color.IndianRed;
            transparentLabel1.Location = new Point(138, 296);
            transparentLabel1.Name = "transparentLabel1";
            transparentLabel1.Size = new Size(0, 19);
            transparentLabel1.TabIndex = 8;
            // 
            // RegLostPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.paradox_interactive_997263;
            ClientSize = new Size(632, 493);
            Controls.Add(RegBG);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(500, 700);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegLostPassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реестрація";
            FormClosing += RegLostPassForm_FormClosing;
            RegBG.ResumeLayout(false);
            RegBG.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private TransparentPanel RegBG;
        private TransparentLabel Reg;
        private TextBox RegPassBox;
        private TextBox RegLogBox;
        private TransparentLinkLabel NewPassLink;
        private TextBox RegSecretBox;
        private TransparentLabel warning;
        private TransparentLabel warning2;
        private Button BackButton;
        private TransparentLabel transparentLabel1;
    }
}