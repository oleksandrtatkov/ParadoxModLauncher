namespace ParadoxModLauncher
{
    partial class ModEditor
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
            AutorsAddBox = new TextBox();
            TagBox = new CheckedListBox();
            DescriptionBox = new RichTextBox();
            NameModBox = new TextBox();
            PinButton = new Button();
            PublichButton = new Button();
            AuthorsPanel = new FlowLayoutPanel();
            ModFileDialog = new OpenFileDialog();
            PicturePanel = new Panel();
            SuspendLayout();
            // 
            // AutorsAddBox
            // 
            AutorsAddBox.Location = new Point(713, 208);
            AutorsAddBox.Name = "AutorsAddBox";
            AutorsAddBox.Size = new Size(287, 27);
            AutorsAddBox.TabIndex = 15;
            AutorsAddBox.Text = "Додати автора(Enter)";
            AutorsAddBox.KeyDown += AutorsAddBox_KeyDown;
            // 
            // TagBox
            // 
            TagBox.FormattingEnabled = true;
            TagBox.Location = new Point(439, 149);
            TagBox.Name = "TagBox";
            TagBox.Size = new Size(220, 114);
            TagBox.TabIndex = 14;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(120, 372);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(879, 120);
            DescriptionBox.TabIndex = 13;
            DescriptionBox.Text = "";
            // 
            // NameModBox
            // 
            NameModBox.Location = new Point(439, 67);
            NameModBox.Name = "NameModBox";
            NameModBox.Size = new Size(561, 27);
            NameModBox.TabIndex = 12;
            // 
            // PinButton
            // 
            PinButton.BackgroundImage = Properties.Resources.PinFile;
            PinButton.BackgroundImageLayout = ImageLayout.Stretch;
            PinButton.FlatAppearance.BorderSize = 0;
            PinButton.FlatStyle = FlatStyle.Flat;
            PinButton.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PinButton.ForeColor = SystemColors.ControlText;
            PinButton.Location = new Point(67, 531);
            PinButton.Name = "PinButton";
            PinButton.Size = new Size(133, 53);
            PinButton.TabIndex = 17;
            PinButton.Text = "Обрати файл";
            PinButton.UseVisualStyleBackColor = true;
            PinButton.Click += PinButton_Click;
            // 
            // PublichButton
            // 
            PublichButton.BackgroundImage = Properties.Resources.pubichButton;
            PublichButton.BackgroundImageLayout = ImageLayout.Stretch;
            PublichButton.FlatAppearance.BorderSize = 0;
            PublichButton.FlatStyle = FlatStyle.Flat;
            PublichButton.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PublichButton.ForeColor = SystemColors.ControlText;
            PublichButton.Location = new Point(919, 531);
            PublichButton.Name = "PublichButton";
            PublichButton.Size = new Size(133, 53);
            PublichButton.TabIndex = 16;
            PublichButton.Text = "Опублікувати";
            PublichButton.UseVisualStyleBackColor = true;
            PublichButton.Click += PublishButton_Click;
            // 
            // AuthorsPanel
            // 
            AuthorsPanel.AutoScroll = true;
            AuthorsPanel.Location = new Point(695, 241);
            AuthorsPanel.Name = "AuthorsPanel";
            AuthorsPanel.Size = new Size(322, 103);
            AuthorsPanel.TabIndex = 18;
            // 
            // ModFileDialog
            // 
            ModFileDialog.FileName = "Mod";
            // 
            // PicturePanel
            // 
            PicturePanel.AllowDrop = true;
            PicturePanel.BackColor = SystemColors.ControlDark;
            PicturePanel.BackgroundImage = Properties.Resources.DragImage;
            PicturePanel.BackgroundImageLayout = ImageLayout.Stretch;
            PicturePanel.Location = new Point(105, 45);
            PicturePanel.Name = "PicturePanel";
            PicturePanel.Size = new Size(267, 268);
            PicturePanel.TabIndex = 19;
            PicturePanel.DragDrop += PicturePanel_DragDrop;
            PicturePanel.DragEnter += PicturePanel_DragEnter;
            // 
            // ModEditor
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 615);
            Controls.Add(PicturePanel);
            Controls.Add(AuthorsPanel);
            Controls.Add(PinButton);
            Controls.Add(PublichButton);
            Controls.Add(AutorsAddBox);
            Controls.Add(TagBox);
            Controls.Add(DescriptionBox);
            Controls.Add(NameModBox);
            Name = "ModEditor";
            Text = "ModEditor";
            FormClosed += ModEditor_FormClosed;
            Load += ModEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AutorsAddBox;
        private CheckedListBox TagBox;
        private RichTextBox DescriptionBox;
        private TextBox NameModBox;
        private Button PinButton;
        private Button PublichButton;
        private FlowLayoutPanel AuthorsPanel;
        private OpenFileDialog ModFileDialog;
        private Panel PicturePanel;
    }
}