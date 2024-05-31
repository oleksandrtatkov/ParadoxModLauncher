namespace ParadoxModLauncher
{
    partial class MainLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLauncher));
            transparentLabel = new Resources.scripts.TransparentLabel();
            Box = new PictureBox();
            CKButton = new Button();
            HOIButton = new Button();
            V3Button = new Button();
            CKLabel = new Resources.scripts.TransparentLabel();
            transparentLabel1 = new Resources.scripts.TransparentLabel();
            V3Label = new Resources.scripts.TransparentLabel();
            GamesLabel = new Resources.scripts.TransparentLabel();
            ((System.ComponentModel.ISupportInitialize)Box).BeginInit();
            SuspendLayout();
            // 
            // transparentLabel
            // 
            transparentLabel.AutoSize = true;
            transparentLabel.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transparentLabel.ForeColor = SystemColors.ButtonHighlight;
            transparentLabel.Location = new Point(109, 408);
            transparentLabel.Name = "transparentLabel";
            transparentLabel.Size = new Size(0, 25);
            transparentLabel.TabIndex = 9;
            // 
            // Box
            // 
            Box.BackColor = Color.Transparent;
            Box.Image = Properties.Resources.mainTranceparent;
            Box.InitialImage = null;
            Box.Location = new Point(179, -4);
            Box.Margin = new Padding(3, 2, 3, 2);
            Box.Name = "Box";
            Box.Size = new Size(749, 172);
            Box.TabIndex = 11;
            Box.TabStop = false;
            // 
            // CKButton
            // 
            CKButton.BackgroundImage = Properties.Resources.ck3;
            CKButton.BackgroundImageLayout = ImageLayout.Zoom;
            CKButton.Location = new Point(57, 271);
            CKButton.Margin = new Padding(3, 2, 3, 2);
            CKButton.Name = "CKButton";
            CKButton.Size = new Size(201, 237);
            CKButton.TabIndex = 12;
            CKButton.UseVisualStyleBackColor = true;
            CKButton.Click += CK3_OnClick;
            // 
            // HOIButton
            // 
            HOIButton.BackgroundImage = Properties.Resources.hoi4;
            HOIButton.BackgroundImageLayout = ImageLayout.Zoom;
            HOIButton.Location = new Point(436, 271);
            HOIButton.Margin = new Padding(3, 2, 3, 2);
            HOIButton.Name = "HOIButton";
            HOIButton.Size = new Size(201, 237);
            HOIButton.TabIndex = 13;
            HOIButton.UseVisualStyleBackColor = true;
            HOIButton.Click += Hoi_OnClick;
            // 
            // V3Button
            // 
            V3Button.BackgroundImage = Properties.Resources.v3;
            V3Button.BackgroundImageLayout = ImageLayout.Zoom;
            V3Button.Location = new Point(841, 271);
            V3Button.Margin = new Padding(3, 2, 3, 2);
            V3Button.Name = "V3Button";
            V3Button.Size = new Size(201, 237);
            V3Button.TabIndex = 14;
            V3Button.UseVisualStyleBackColor = true;
            V3Button.Click += V3_OnClick;
            // 
            // CKLabel
            // 
            CKLabel.AutoSize = true;
            CKLabel.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CKLabel.ForeColor = SystemColors.ButtonHighlight;
            CKLabel.Location = new Point(57, 519);
            CKLabel.Name = "CKLabel";
            CKLabel.Size = new Size(196, 25);
            CKLabel.TabIndex = 15;
            CKLabel.Text = "Crusader Kings III ";
            // 
            // transparentLabel1
            // 
            transparentLabel1.AutoSize = true;
            transparentLabel1.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            transparentLabel1.ForeColor = SystemColors.ButtonHighlight;
            transparentLabel1.Location = new Point(436, 519);
            transparentLabel1.Name = "transparentLabel1";
            transparentLabel1.Size = new Size(174, 25);
            transparentLabel1.TabIndex = 16;
            transparentLabel1.Text = "Hearts Of Iron 4 ";
            // 
            // V3Label
            // 
            V3Label.AutoSize = true;
            V3Label.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            V3Label.ForeColor = SystemColors.ButtonHighlight;
            V3Label.Location = new Point(880, 519);
            V3Label.Name = "V3Label";
            V3Label.Size = new Size(102, 25);
            V3Label.TabIndex = 17;
            V3Label.Text = "Victoria 3";
            // 
            // GamesLabel
            // 
            GamesLabel.AutoSize = true;
            GamesLabel.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GamesLabel.ForeColor = SystemColors.ButtonHighlight;
            GamesLabel.Location = new Point(263, 212);
            GamesLabel.Name = "GamesLabel";
            GamesLabel.Size = new Size(519, 25);
            GamesLabel.TabIndex = 18;
            GamesLabel.Text = "Оберіть ігри для яких ви будете переглядати моди: ";
            // 
            // MainLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 57, 55);
            BackgroundImage = Properties.Resources.mainBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1124, 578);
            Controls.Add(GamesLabel);
            Controls.Add(V3Label);
            Controls.Add(transparentLabel1);
            Controls.Add(CKLabel);
            Controls.Add(V3Button);
            Controls.Add(HOIButton);
            Controls.Add(CKButton);
            Controls.Add(Box);
            Controls.Add(transparentLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(207, 750);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainLauncher";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Головна форма";
            FormClosed += MainLauncher_FormClosed;
            Load += MainLauncher_Load;
            ((System.ComponentModel.ISupportInitialize)Box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Resources.scripts.TransparentLabel transparentLabel;
        private PictureBox Box;
        private Button CKButton;
        private Button HOIButton;
        private Button V3Button;
        private Resources.scripts.TransparentLabel CKLabel;
        private Resources.scripts.TransparentLabel transparentLabel1;
        private Resources.scripts.TransparentLabel V3Label;
        private Resources.scripts.TransparentLabel GamesLabel;
    }
}