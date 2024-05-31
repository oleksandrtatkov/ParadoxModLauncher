using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParadoxModLauncher.Resources.scripts;

namespace ParadoxModLauncher
{
    public partial class ModEditor : Form
    {
        public Mod EditedMod { get; set; }
        public Mod CurrentMod { get; set; }
        public SearchResults Parent;
        public ModEditor()
        {
            InitializeComponent();
        }

        public ModEditor(Mod mod)
        {
            InitializeComponent();
            this.CurrentMod = mod.DeepCopy();
            this.EditedMod = mod;

            Add.DefaultText([AutorsAddBox]);
            this.BackgroundImage = Image.FromFile($@"..\..\..\Resources\images\forms\{FormManager.CurrentGameName}.jpg");
            NameModBox.Text = this.EditedMod.Name;
            DescriptionBox.Text = string.Join(' ', this.EditedMod.Desc);
            PicturePanel.BackgroundImage = this.EditedMod.Image.Clone() as Image;
            List<string> authors = new List<string>(this.EditedMod.Authors);
            foreach (string author in authors)
            {
                AddAuthorWithDeleteButton(author);
            }

        }


        private void LoadTagsFromFile(CheckedListBox checkedListBox)
        {
            string filePath = @"..\..\..\Resources\data\tags.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split("◙");
                string gameName = parts[0];
                string[] tags = parts[1].Split("┃");
                if (gameName.Trim() == FormManager.CurrentGameName)
                {
                    checkedListBox.Items.AddRange(tags);
                    break;
                }
            }
        }

        private void AddAuthorWithDeleteButton(string author)
        {
            Panel panel = new Panel();
            panel.Size = new Size(287, 30);
            Label label = new Label();
            label.Text = author;
            label.Location = new Point(0, 0);
            label.AutoSize = true;
            label.Font = new Font(label.Font.FontFamily, 7);
            this.AuthorsPanel.Controls.Add(panel);
            panel.Controls.Add(label);

        }
        private async void AutorsAddBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(AutorsAddBox.Text))
                {
                    AddAuthorWithDeleteButton(AutorsAddBox.Text);
                    e.SuppressKeyPress = true;
                    this.EditedMod.Authors.Add(AutorsAddBox.Text);
                    AutorsAddBox.Clear();
                }
                else
                {
                    await Add.ChangeBoxColor(Color.Red, 100, AutorsAddBox);
                    await Add.ChangeBoxColor(Color.White, 100, AutorsAddBox);
                    await Add.ChangeBoxColor(Color.Red, 100, AutorsAddBox);
                    await Add.ChangeBoxColor(Color.White, 100, AutorsAddBox);
                    await Add.ChangeBoxColor(Color.Red, 100, AutorsAddBox);
                    await Add.ChangeBoxColor(Color.White, 100, AutorsAddBox);
                }
            }
        }

        private void PinButton_Click(object sender, EventArgs e)
        {
            if (ModFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = ModFileDialog.FileName;
                FileInfo fileInfo = new FileInfo(filePath);
                long sizeInBytes = fileInfo.Length;
                this.EditedMod.Size = sizeInBytes.ToString().Replace(',', '.') + " B";
                if (sizeInBytes >= 1024)
                {
                    double sizeInKB = sizeInBytes / 1024.0;
                    this.EditedMod.Size = sizeInKB.ToString("0.00").Replace(',', '.') + " KB";
                    if (sizeInKB >= 1024)
                    {
                        double sizeInMB = sizeInKB / 1024.0;
                        this.EditedMod.Size = sizeInMB.ToString("0.00").Replace(',', '.') + " MB";
                        if (sizeInMB >= 1024)
                        {
                            double sizeInGB = sizeInMB / 1024.0;
                            this.EditedMod.Size = sizeInGB.ToString("0.00").Replace(',', '.') + " GB";
                            if (sizeInGB >= 1024)
                            {
                                double sizeInTB = sizeInGB / 1024.0;
                                this.EditedMod.Size = sizeInTB.ToString("0.00").Replace(',', '.') + " TB";
                            }
                        }
                    }
                }
            }
        }

        private void PublishButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ModFileDialog.FileName) && System.IO.File.Exists(ModFileDialog.FileName))
            {
                this.EditedMod.Image = PicturePanel.BackgroundImage;
                foreach (string item in TagBox.Items)
                {
                    this.EditedMod.Tags[item] = TagBox.GetItemChecked(TagBox.Items.IndexOf(item));
                }
                this.EditedMod.Date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss").Replace("◙", "").Replace("┃", "");
                this.EditedMod.Desc = DescriptionBox.Text.Replace("◙", "").Replace("┃", "");
                this.EditedMod.Name = NameModBox.Text.Replace("◙", "").Replace("┃", "");
                this.EditedMod.Game = FormManager.CurrentGameName.Replace("◙", "").Replace("┃", "");
                this.EditedMod.EditSave(this.CurrentMod, PicturePanel);
                this.Close();
            }
            else
            {
                MessageBox.Show("Файл з модом не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ModEditor_Load(object sender, EventArgs e)
        {
            LoadTagsFromFile(TagBox);
            var index = 0;
            foreach (var item in CurrentMod.Tags)
            {
                TagBox.SetItemChecked(index, item.Value);
                index++;
            }
        }



        private void PicturePanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void PicturePanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (Path.GetExtension(file).ToLower() == ".jpg")
                {
                    PicturePanel.BackgroundImage = Image.FromFile(file);
                }
            }
        }
        private void ModEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.BackButton_Click(null, null);
            new Search(CurrentMod.Game).Show();

        }
    }
}