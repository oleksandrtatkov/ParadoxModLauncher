namespace ParadoxModLauncher
{
    partial class SearchResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResults));
            transparentLabel1 = new Resources.scripts.TransparentLabel();
            SuspendLayout();
            // 
            // transparentLabel1
            // 
            transparentLabel1.AutoSize = true;
            transparentLabel1.Font = new Font("Garamond", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            transparentLabel1.ForeColor = Color.Black;
            transparentLabel1.Location = new Point(347, 187);
            transparentLabel1.Name = "transparentLabel1";
            transparentLabel1.Size = new Size(360, 34);
            transparentLabel1.TabIndex = 0;
            transparentLabel1.Text = "Нажаль нічого не знайдено!";
            // 
            // SearchResults
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.ck3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1047, 473);
            Controls.Add(transparentLabel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(500, 700);
            Name = "SearchResults";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Результати пошуку";
            TransparencyKey = Color.Azure;
            FormClosed += SearchResults_FormClosed;
            Load += SearchResults_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Resources.scripts.TransparentLabel transparentLabel1;
    }
}