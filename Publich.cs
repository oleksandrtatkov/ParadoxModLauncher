using ParadoxModLauncher.Resources.scripts;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ParadoxModLauncher
{
    public partial class Publich : Form
    {
        private List<string> authorsList = new List<string>();
        private string currentSize;
        Dictionary<string, bool> currentTags = new Dictionary<string, bool>();
        public Search Parent;

        public Publich(string gameName)
        {
            FormManager.CenterForm(this);
            InitializeComponent();
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources\images\forms", gameName + ".jpg");
            this.BackgroundImage = Image.FromFile(imagePath);
            Add.DefaultText([NameModBox, AutorsAddBox, DescriptionBox]);
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

        private async void PublichButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ModFileDialog.FileName) && System.IO.File.Exists(ModFileDialog.FileName))
            {
                foreach (string item in TagBox.Items)
                {
                    currentTags[item] = TagBox.GetItemChecked(TagBox.Items.IndexOf(item));
                }
                Mod mod = new Mod(NameModBox.Text.Trim(' ').Replace("◙", "").Replace("┃", ""), authorsList, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), currentSize, string.Join(' ', DescriptionBox.Lines), currentTags, PicturePanel.BackgroundImage);
                mod.Save();
                User.CurrentUser.AddModByCategory(3, mod);
                MessageBox.Show("Модіфікацію опубліковано успішно.", "Модіфікацію опубліковано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Файл з модом не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await Add.ChangeBoxColor(Color.Red, 100, NameModBox, AutorsAddBox, DescriptionBox);
                await Add.ChangeBoxColor(Color.White, 100, NameModBox, AutorsAddBox, DescriptionBox);
                await Add.ChangeBoxColor(Color.Red, 100, NameModBox, AutorsAddBox, DescriptionBox);
                await Add.ChangeBoxColor(Color.White, 100, NameModBox, AutorsAddBox, DescriptionBox);
                await Add.ChangeBoxColor(Color.Red, 100, NameModBox, AutorsAddBox, DescriptionBox);
                await Add.ChangeBoxColor(Color.White, 100, NameModBox, AutorsAddBox, DescriptionBox);
            }

        }

        private void Publich_Load(object sender, EventArgs e)
        {
            LoadTagsFromFile(TagBox);
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


        private async void AutorsAddBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(AutorsAddBox.Text))
                {
                    authorsList.Add(AutorsAddBox.Text);
                    AutorsAddBox.Clear();
                    e.SuppressKeyPress = true;
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
                currentSize = sizeInBytes.ToString().Replace(',', '.') + " B";
                if (sizeInBytes >= 1024)
                {
                    double sizeInKB = sizeInBytes / 1024.0;
                    currentSize = sizeInKB.ToString("0.00").Replace(',', '.') + " KB";
                    if (sizeInKB >= 1024)
                    {
                        double sizeInMB = sizeInKB / 1024.0;
                        currentSize = sizeInMB.ToString("0.00").Replace(',', '.') + " MB";
                        if (sizeInMB >= 1024)
                        {
                            double sizeInGB = sizeInMB / 1024.0;
                            currentSize = sizeInGB.ToString("0.00").Replace(',', '.') + " GB";
                            if (sizeInGB >= 1024)
                            {
                                double sizeInTB = sizeInGB / 1024.0;
                                currentSize = sizeInTB.ToString("0.00").Replace(',', '.') + " TB";
                            }
                        }
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Search search = new Search(FormManager.CurrentGameName);
            search.Show();
            this.Hide();
        }

        private void Publich_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Show(); 
        }
    }
}
