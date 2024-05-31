namespace ParadoxModLauncher
{
    partial class ModPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModPage));
            ModPictureBox = new PictureBox();
            NameLabel = new Resources.scripts.TransparentLabel();
            DateLabel = new Resources.scripts.TransparentLabel();
            SizeLabel = new Resources.scripts.TransparentLabel();
            DescLabel = new Resources.scripts.TransparentLabel();
            DownloadsBox = new PictureBox();
            FavoriteBox = new PictureBox();
            FavoriteLabel = new Resources.scripts.TransparentLabel();
            DownloadLabel = new Resources.scripts.TransparentLabel();
            AutorsLabel = new Resources.scripts.TransparentLabel();
            ((System.ComponentModel.ISupportInitialize)ModPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DownloadsBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FavoriteBox).BeginInit();
            SuspendLayout();
            // 
            // ModPictureBox
            // 
            ModPictureBox.Location = new Point(54, 36);
            ModPictureBox.Margin = new Padding(3, 2, 3, 2);
            ModPictureBox.Name = "ModPictureBox";
            ModPictureBox.Size = new Size(234, 201);
            ModPictureBox.TabIndex = 0;
            ModPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.ForeColor = SystemColors.ButtonFace;
            NameLabel.Location = new Point(380, 48);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(57, 18);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Назва:";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DateLabel.ForeColor = SystemColors.ButtonFace;
            DateLabel.Location = new Point(78, 255);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(154, 18);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "Дата опублікування:";
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SizeLabel.ForeColor = SystemColors.ButtonFace;
            SizeLabel.Location = new Point(78, 360);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(64, 18);
            SizeLabel.TabIndex = 3;
            SizeLabel.Text = "Розмір: ";
            // 
            // DescLabel
            // 
            DescLabel.AutoSize = true;
            DescLabel.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DescLabel.ForeColor = SystemColors.ButtonFace;
            DescLabel.Location = new Point(380, 176);
            DescLabel.Name = "DescLabel";
            DescLabel.Size = new Size(89, 18);
            DescLabel.TabIndex = 4;
            DescLabel.Text = "Опис моду:\r\n";
            // 
            // DownloadsBox
            // 
            DownloadsBox.BackColor = Color.Transparent;
            DownloadsBox.BackgroundImage = Properties.Resources.downloads;
            DownloadsBox.BackgroundImageLayout = ImageLayout.Stretch;
            DownloadsBox.Location = new Point(786, 328);
            DownloadsBox.Margin = new Padding(3, 2, 3, 2);
            DownloadsBox.Name = "DownloadsBox";
            DownloadsBox.Size = new Size(172, 76);
            DownloadsBox.TabIndex = 5;
            DownloadsBox.TabStop = false;
            DownloadsBox.DoubleClick += DownloadsBox_DoubleClick;
            // 
            // FavoriteBox
            // 
            FavoriteBox.BackColor = Color.Transparent;
            FavoriteBox.BackgroundImage = Properties.Resources.favorite;
            FavoriteBox.BackgroundImageLayout = ImageLayout.Stretch;
            FavoriteBox.Location = new Point(411, 328);
            FavoriteBox.Margin = new Padding(3, 2, 3, 2);
            FavoriteBox.Name = "FavoriteBox";
            FavoriteBox.Size = new Size(172, 76);
            FavoriteBox.TabIndex = 6;
            FavoriteBox.TabStop = false;
            FavoriteBox.DoubleClick += FavoriteBox_DoubleClick;
            // 
            // FavoriteLabel
            // 
            FavoriteLabel.AutoSize = true;
            FavoriteLabel.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FavoriteLabel.ForeColor = SystemColors.ButtonFace;
            FavoriteLabel.Location = new Point(427, 414);
            FavoriteLabel.Name = "FavoriteLabel";
            FavoriteLabel.Size = new Size(124, 18);
            FavoriteLabel.TabIndex = 7;
            FavoriteLabel.Text = "До улюбленного";
            // 
            // DownloadLabel
            // 
            DownloadLabel.AutoSize = true;
            DownloadLabel.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DownloadLabel.ForeColor = SystemColors.ButtonFace;
            DownloadLabel.Location = new Point(786, 414);
            DownloadLabel.Name = "DownloadLabel";
            DownloadLabel.Size = new Size(104, 18);
            DownloadLabel.TabIndex = 8;
            DownloadLabel.Text = "Завантажити";
            // 
            // AutorsLabel
            // 
            AutorsLabel.AutoSize = true;
            AutorsLabel.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AutorsLabel.ForeColor = SystemColors.ButtonFace;
            AutorsLabel.Location = new Point(380, 112);
            AutorsLabel.Name = "AutorsLabel";
            AutorsLabel.Size = new Size(64, 18);
            AutorsLabel.TabIndex = 9;
            AutorsLabel.Text = "Автори:";
            // 
            // ModPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1060, 464);
            Controls.Add(AutorsLabel);
            Controls.Add(DownloadLabel);
            Controls.Add(FavoriteLabel);
            Controls.Add(FavoriteBox);
            Controls.Add(DownloadsBox);
            Controls.Add(DescLabel);
            Controls.Add(SizeLabel);
            Controls.Add(DateLabel);
            Controls.Add(NameLabel);
            Controls.Add(ModPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModPage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Сторінка моду";
            FormClosed += ModPage_FormClosed;
            Load += ModPage_Load;
            ((System.ComponentModel.ISupportInitialize)ModPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DownloadsBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FavoriteBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ModPictureBox;
        private Resources.scripts.TransparentLabel NameLabel;
        private Resources.scripts.TransparentLabel DateLabel;
        private Resources.scripts.TransparentLabel SizeLabel;
        private Resources.scripts.TransparentLabel DescLabel;
        private PictureBox DownloadsBox;
        private PictureBox FavoriteBox;
        private Resources.scripts.TransparentLabel FavoriteLabel;
        private Resources.scripts.TransparentLabel DownloadLabel;
        private Resources.scripts.TransparentLabel AutorsLabel;
    }
}