using ParadoxModLauncher.Resources.scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParadoxModLauncher
{
    public partial class ModPage : Form
    {
        public Form Parent;
        public Mod mod { get; set; }
        public ModPage()
        {
            FormManager.CenterForm(this);
            InitializeComponent();
        }

        public ModPage(Mod mod)
        {
            FormManager.CenterForm(this);
            this.mod = mod;
            InitializeComponent();

            if (mod != null)
            {
                this.BackgroundImage = Image.FromFile($@"..\..\..\Resources\images\forms\{FormManager.CurrentGameName}.jpg");
                ModPictureBox.BackgroundImage = mod.Image;
                NameLabel.Text = $"Назва моду: {mod.Name}";
                AutorsLabel.Text = $"{TextManager.FormatText("Автори: " + TextManager.ETC(string.Join(", ", mod.Authors), 410).Trim('{', '}'), 84)}";
                DateLabel.Text = $"Дата опублікування: {Environment.NewLine + mod.Date}";
                SizeLabel.Text = $"Розмір: {mod.Size}";
                DescLabel.Text = $"{TextManager.FormatText("Опис моду: " + TextManager.ETC(mod.Desc, 410), 87)}";
            }
        }

        private void FavoriteBox_DoubleClick(object sender, EventArgs e)
        {

            foreach (var mod in User.CurrentUser.Favorite)
            {
                if (this.mod.Name == mod)
                {
                    MessageBox.Show("Модифікація вже знаходиться у улюбленому.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //isInFavoriteList = true;
                    return;
                }
                
            }
            User.CurrentUser.AddModByCategory(1, this.mod);
            MessageBox.Show("Модифікацію додано до улюбленого.", "Модіфікацію додано до улюбленого", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DownloadsBox_DoubleClick(object sender, EventArgs e)
        {
            User.CurrentUser.AddModByCategory(2, this.mod);
            this.mod.SaveTo(@"..\..\..\Resources\downloads");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Search search = new Search(FormManager.CurrentGameName);
            this.Hide();
            search.Show();
        }

        private void ModPage_Load(object sender, EventArgs e)
        {
        }

        private void ModPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            { Parent.Show(); }
            catch { }
        }
    }
}
