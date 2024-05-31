namespace ParadoxModLauncher
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            SearchBox = new TextBox();
            DownloadsBox = new PictureBox();
            FavoriteBox = new PictureBox();
            UploadsBox = new PictureBox();
            DownloadsLabel = new Resources.scripts.TransparentLabel();
            transparentLabel1 = new Resources.scripts.TransparentLabel();
            FavoriteLabel = new Resources.scripts.TransparentLabel();
            transparentLabel2 = new Resources.scripts.TransparentLabel();
            BackButton = new Button();
            PublichButton = new Button();
            TagSeachButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DownloadsBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FavoriteBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UploadsBox).BeginInit();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(196, 71);
            SearchBox.Margin = new Padding(3, 2, 3, 2);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(291, 23);
            SearchBox.TabIndex = 0;
            SearchBox.KeyDown += Search_KeyDown;
            // 
            // DownloadsBox
            // 
            DownloadsBox.BackColor = Color.Transparent;
            DownloadsBox.BackgroundImage = Properties.Resources.downloads;
            DownloadsBox.BackgroundImageLayout = ImageLayout.Stretch;
            DownloadsBox.Location = new Point(30, 246);
            DownloadsBox.Margin = new Padding(3, 2, 3, 2);
            DownloadsBox.Name = "DownloadsBox";
            DownloadsBox.Size = new Size(172, 76);
            DownloadsBox.TabIndex = 1;
            DownloadsBox.TabStop = false;
            DownloadsBox.Tag = "User_Tag";
            DownloadsBox.DoubleClick += Downloads_OnDoubleClick;
            // 
            // FavoriteBox
            // 
            FavoriteBox.BackColor = Color.Transparent;
            FavoriteBox.BackgroundImage = Properties.Resources.favorite;
            FavoriteBox.BackgroundImageLayout = ImageLayout.Stretch;
            FavoriteBox.Location = new Point(557, 246);
            FavoriteBox.Margin = new Padding(3, 2, 3, 2);
            FavoriteBox.Name = "FavoriteBox";
            FavoriteBox.Size = new Size(172, 76);
            FavoriteBox.TabIndex = 2;
            FavoriteBox.TabStop = false;
            FavoriteBox.Tag = "User_Tag";
            FavoriteBox.DoubleClick += Favorite_OnDoubleClick;
            // 
            // UploadsBox
            // 
            UploadsBox.BackColor = Color.Transparent;
            UploadsBox.BackgroundImage = Properties.Resources.uploads;
            UploadsBox.BackgroundImageLayout = ImageLayout.Stretch;
            UploadsBox.Location = new Point(278, 248);
            UploadsBox.Margin = new Padding(3, 2, 3, 2);
            UploadsBox.Name = "UploadsBox";
            UploadsBox.Size = new Size(172, 76);
            UploadsBox.TabIndex = 3;
            UploadsBox.TabStop = false;
            UploadsBox.Tag = "User_Tag";
            UploadsBox.DoubleClick += Uploads_OnDoubleClick;
            // 
            // DownloadsLabel
            // 
            DownloadsLabel.AutoSize = true;
            DownloadsLabel.BackColor = SystemColors.Control;
            DownloadsLabel.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DownloadsLabel.ForeColor = SystemColors.ButtonHighlight;
            DownloadsLabel.Location = new Point(30, 334);
            DownloadsLabel.Name = "DownloadsLabel";
            DownloadsLabel.Size = new Size(92, 25);
            DownloadsLabel.TabIndex = 4;
            DownloadsLabel.Text = "Скачані";
            // 
            // transparentLabel1
            // 
            transparentLabel1.AutoSize = true;
            transparentLabel1.BackColor = SystemColors.Control;
            transparentLabel1.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            transparentLabel1.ForeColor = SystemColors.ButtonHighlight;
            transparentLabel1.Location = new Point(278, 299);
            transparentLabel1.Name = "transparentLabel1";
            transparentLabel1.Size = new Size(0, 25);
            transparentLabel1.TabIndex = 5;
            // 
            // FavoriteLabel
            // 
            FavoriteLabel.AutoSize = true;
            FavoriteLabel.BackColor = SystemColors.Control;
            FavoriteLabel.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FavoriteLabel.ForeColor = SystemColors.ButtonHighlight;
            FavoriteLabel.Location = new Point(557, 334);
            FavoriteLabel.Name = "FavoriteLabel";
            FavoriteLabel.Size = new Size(105, 25);
            FavoriteLabel.TabIndex = 6;
            FavoriteLabel.Text = "Улюблені";
            // 
            // transparentLabel2
            // 
            transparentLabel2.AutoSize = true;
            transparentLabel2.BackColor = SystemColors.Control;
            transparentLabel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            transparentLabel2.ForeColor = SystemColors.ButtonHighlight;
            transparentLabel2.Location = new Point(268, 334);
            transparentLabel2.Name = "transparentLabel2";
            transparentLabel2.Size = new Size(144, 25);
            transparentLabel2.TabIndex = 7;
            transparentLabel2.Text = "Опубліковані";
            // 
            // BackButton
            // 
            BackButton.BackgroundImage = Properties.Resources.back;
            BackButton.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Image = (Image)resources.GetObject("BackButton.Image");
            BackButton.Location = new Point(30, 19);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(28, 24);
            BackButton.TabIndex = 8;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += Back;
            // 
            // PublichButton
            // 
            PublichButton.BackgroundImage = Properties.Resources.pubichButton;
            PublichButton.FlatAppearance.BorderSize = 0;
            PublichButton.FlatStyle = FlatStyle.Flat;
            PublichButton.Font = new Font("Garamond", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PublichButton.Location = new Point(505, 64);
            PublichButton.Margin = new Padding(3, 2, 3, 2);
            PublichButton.Name = "PublichButton";
            PublichButton.Size = new Size(97, 33);
            PublichButton.TabIndex = 9;
            PublichButton.Text = "Опублікувати";
            PublichButton.UseVisualStyleBackColor = true;
            PublichButton.Click += PublichButton_Click;
            // 
            // TagSeachButton
            // 
            TagSeachButton.AccessibleRole = AccessibleRole.Text;
            TagSeachButton.BackgroundImage = Properties.Resources.tagSearch;
            TagSeachButton.BackgroundImageLayout = ImageLayout.Stretch;
            TagSeachButton.FlatAppearance.BorderSize = 0;
            TagSeachButton.FlatStyle = FlatStyle.Flat;
            TagSeachButton.Font = new Font("Garamond", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TagSeachButton.Location = new Point(85, 65);
            TagSeachButton.Margin = new Padding(3, 2, 3, 2);
            TagSeachButton.Name = "TagSeachButton";
            TagSeachButton.Size = new Size(97, 33);
            TagSeachButton.TabIndex = 10;
            TagSeachButton.Text = "Пошук то тегам";
            TagSeachButton.UseVisualStyleBackColor = true;
            TagSeachButton.Click += TagSeachButton_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ck3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 373);
            Controls.Add(TagSeachButton);
            Controls.Add(PublichButton);
            Controls.Add(BackButton);
            Controls.Add(transparentLabel2);
            Controls.Add(FavoriteLabel);
            Controls.Add(transparentLabel1);
            Controls.Add(DownloadsLabel);
            Controls.Add(UploadsBox);
            Controls.Add(FavoriteBox);
            Controls.Add(DownloadsBox);
            Controls.Add(SearchBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(500, 700);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "Search";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Пошук моду";
            FormClosed += Search_FormClosed;
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)DownloadsBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FavoriteBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UploadsBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private PictureBox DownloadsBox;
        private PictureBox FavoriteBox;
        private PictureBox UploadsBox;
        private Resources.scripts.TransparentLabel DownloadsLabel;
        private Resources.scripts.TransparentLabel transparentLabel1;
        private Resources.scripts.TransparentLabel FavoriteLabel;
        private Resources.scripts.TransparentLabel transparentLabel2;
        private Button BackButton;
        private Button PublichButton;
        private Button TagSeachButton;
    }
}