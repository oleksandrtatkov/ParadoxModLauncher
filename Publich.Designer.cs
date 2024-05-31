namespace ParadoxModLauncher
{
    partial class Publich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publich));
            PicturePanel = new Panel();
            NameModBox = new TextBox();
            DescriptionBox = new RichTextBox();
            PublichButton = new Button();
            TagBox = new CheckedListBox();
            AutorsAddBox = new TextBox();
            ModFileDialog = new OpenFileDialog();
            PinButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // PicturePanel
            // 
            PicturePanel.AllowDrop = true;
            PicturePanel.BackColor = SystemColors.ControlDark;
            PicturePanel.BackgroundImage = Properties.Resources.DragImage;
            PicturePanel.BackgroundImageLayout = ImageLayout.Stretch;
            PicturePanel.Location = new Point(107, 28);
            PicturePanel.Margin = new Padding(3, 2, 3, 2);
            PicturePanel.Name = "PicturePanel";
            PicturePanel.Size = new Size(234, 201);
            PicturePanel.TabIndex = 0;
            PicturePanel.DragDrop += PicturePanel_DragDrop;
            PicturePanel.DragEnter += PicturePanel_DragEnter;
            // 
            // NameModBox
            // 
            NameModBox.Location = new Point(386, 28);
            NameModBox.Margin = new Padding(3, 2, 3, 2);
            NameModBox.Name = "NameModBox";
            NameModBox.Size = new Size(491, 23);
            NameModBox.TabIndex = 1;
            NameModBox.Text = "Назва моду";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(107, 258);
            DescriptionBox.Margin = new Padding(3, 2, 3, 2);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(770, 91);
            DescriptionBox.TabIndex = 5;
            DescriptionBox.Text = "Опис моду";
            // 
            // PublichButton
            // 
            PublichButton.BackgroundImage = Properties.Resources.pubichButton;
            PublichButton.BackgroundImageLayout = ImageLayout.Stretch;
            PublichButton.FlatAppearance.BorderSize = 0;
            PublichButton.FlatStyle = FlatStyle.Flat;
            PublichButton.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PublichButton.ForeColor = SystemColors.ControlText;
            PublichButton.Location = new Point(811, 360);
            PublichButton.Margin = new Padding(3, 2, 3, 2);
            PublichButton.Name = "PublichButton";
            PublichButton.Size = new Size(116, 40);
            PublichButton.TabIndex = 8;
            PublichButton.Text = "Опублікувати";
            PublichButton.UseVisualStyleBackColor = true;
            PublichButton.Click += PublichButton_Click;
            // 
            // TagBox
            // 
            TagBox.FormattingEnabled = true;
            TagBox.Location = new Point(386, 91);
            TagBox.Margin = new Padding(3, 2, 3, 2);
            TagBox.Name = "TagBox";
            TagBox.Size = new Size(193, 112);
            TagBox.TabIndex = 9;
            // 
            // AutorsAddBox
            // 
            AutorsAddBox.Location = new Point(626, 135);
            AutorsAddBox.Margin = new Padding(3, 2, 3, 2);
            AutorsAddBox.Name = "AutorsAddBox";
            AutorsAddBox.Size = new Size(252, 23);
            AutorsAddBox.TabIndex = 10;
            AutorsAddBox.Text = "Додати автора(додавання на Enter)";
            AutorsAddBox.KeyDown += AutorsAddBox_KeyDown;
            // 
            // ModFileDialog
            // 
            ModFileDialog.FileName = "Mod";
            ModFileDialog.Filter = "Archive Files(*.zip;*.rar)|*.zip,*.rar|All files (*.*)|*.*";
            // 
            // PinButton
            // 
            PinButton.BackgroundImage = Properties.Resources.PinFile;
            PinButton.BackgroundImageLayout = ImageLayout.Stretch;
            PinButton.FlatAppearance.BorderSize = 0;
            PinButton.FlatStyle = FlatStyle.Flat;
            PinButton.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PinButton.ForeColor = SystemColors.ControlText;
            PinButton.Location = new Point(66, 360);
            PinButton.Margin = new Padding(3, 2, 3, 2);
            PinButton.Name = "PinButton";
            PinButton.Size = new Size(116, 40);
            PinButton.TabIndex = 11;
            PinButton.Text = "Обрати файл";
            PinButton.UseVisualStyleBackColor = true;
            PinButton.Click += PinButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackgroundImage = Properties.Resources.back;
            BackButton.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Location = new Point(438, 525);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(28, 24);
            BackButton.TabIndex = 12;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Publich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 424);
            Controls.Add(BackButton);
            Controls.Add(PinButton);
            Controls.Add(AutorsAddBox);
            Controls.Add(TagBox);
            Controls.Add(PublichButton);
            Controls.Add(DescriptionBox);
            Controls.Add(NameModBox);
            Controls.Add(PicturePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Publich";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Опублікувати модифікацію";
            FormClosed += Publich_FormClosed;
            Load += Publich_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PicturePanel;
        private TextBox NameModBox;
        private RichTextBox DescriptionBox;
        private Button PublichButton;
        private CheckedListBox TagBox;
        private TextBox AutorsAddBox;
        private OpenFileDialog ModFileDialog;
        private Button PinButton;
        private Button BackButton;
    }
}