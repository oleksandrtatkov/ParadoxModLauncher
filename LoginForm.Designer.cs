using System.Windows.Forms;
using ParadoxModLauncher.Resources.scripts;


namespace ParadoxModLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginTextBox = new TextBox();
            PassTextBox = new TextBox();
            LoginLabel = new TransparentLabel();
            RegLostPassFormLink = new TransparentLinkLabel();
            BackPanel = new TransparentPanel();
            label2 = new TransparentLabel();
            BackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Cursor = Cursors.IBeam;
            LoginTextBox.Location = new Point(230, 181);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(174, 27);
            LoginTextBox.TabIndex = 0;
            LoginTextBox.Text = "Логін...";
            LoginTextBox.KeyDown += textBox1_KeyDown;
            // 
            // PassTextBox
            // 
            PassTextBox.Cursor = Cursors.IBeam;
            PassTextBox.Location = new Point(230, 244);
            PassTextBox.Name = "PassTextBox";
            PassTextBox.Size = new Size(174, 27);
            PassTextBox.TabIndex = 1;
            PassTextBox.Text = "Пароль...";
            PassTextBox.UseSystemPasswordChar = true;
            PassTextBox.KeyDown += textBox2_KeyDown;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginLabel.ForeColor = SystemColors.Control;
            LoginLabel.Location = new Point(288, 137);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(57, 26);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Вхід";
            // 
            // RegLostPassFormLink
            // 
            RegLostPassFormLink.ActiveLinkColor = Color.Red;
            RegLostPassFormLink.AutoSize = true;
            RegLostPassFormLink.BackColor = Color.Transparent;
            RegLostPassFormLink.DisabledLinkColor = Color.Transparent;
            RegLostPassFormLink.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegLostPassFormLink.ForeColor = Color.Cyan;
            RegLostPassFormLink.LinkBehavior = LinkBehavior.NeverUnderline;
            RegLostPassFormLink.LinkColor = Color.Cyan;
            RegLostPassFormLink.Location = new Point(178, 304);
            RegLostPassFormLink.Name = "RegLostPassFormLink";
            RegLostPassFormLink.Size = new Size(286, 26);
            RegLostPassFormLink.TabIndex = 4;
            RegLostPassFormLink.TabStop = true;
            RegLostPassFormLink.Text = "Забули пароль/Реєстрація";
            RegLostPassFormLink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // BackPanel
            // 
            BackPanel.BackColor = Color.Black;
            BackPanel.Controls.Add(label2);
            BackPanel.Controls.Add(RegLostPassFormLink);
            BackPanel.Controls.Add(LoginLabel);
            BackPanel.Controls.Add(PassTextBox);
            BackPanel.Controls.Add(LoginTextBox);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Name = "BackPanel";
            BackPanel.Size = new Size(632, 493);
            BackPanel.TabIndex = 0;
            BackPanel.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(192, 155);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.paradox_interactive_997263;
            ClientSize = new Size(632, 493);
            Controls.Add(BackPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(500, 700);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вхід";
            Load += LoginForm_Load;
            BackPanel.ResumeLayout(false);
            BackPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PassTextBox;
        private TransparentLabel LoginLabel;
        private TransparentLinkLabel RegLostPassFormLink;
        private TransparentPanel BackPanel;
        private TransparentLabel label2;
    }
}