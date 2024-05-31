using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using ParadoxModLauncher.Resources.scripts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParadoxModLauncher
{
    public partial class Search : Form
    {
        public MainLauncher Parent;
        public Search()
        {
            InitializeComponent();
            FormManager.CenterForm(this);
        }
        public Search(string gameName)
        {
            InitializeComponent();
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources\images\forms", gameName + ".jpg");
            this.BackgroundImage = Image.FromFile(imagePath);
            FormManager.CenterForm(this);
        }

        private void Downloads_OnDoubleClick(object sender, EventArgs e)
        {
            List<Resources.scripts.User> loadedUsers = Resources.scripts.User.LoadUsers();
            Resources.scripts.User user = loadedUsers.FirstOrDefault(u => u.Login == Resources.scripts.User.CurrentUser.Login);
            (List<Mod> downloadedMods, List<Mod> uploadedMods, List<Mod> favoriteMods) = Mod.GetModsForUser(user);
            Mod.RemoveModsByGame(downloadedMods, FormManager.CurrentGameName);
            SearchResults results = new SearchResults(downloadedMods, 2) { Parent = this };
            results.Show();
            this.Hide();
        }

        private void Uploads_OnDoubleClick(object sender, EventArgs e)
        {
            List<Resources.scripts.User> loadedUsers = Resources.scripts.User.LoadUsers();
            Resources.scripts.User user = loadedUsers.FirstOrDefault(u => u.Login == Resources.scripts.User.CurrentUser.Login);
            (List<Mod> downloadedMods, List<Mod> uploadedMods, List<Mod> favoriteMods) = Mod.GetModsForUser(user);
            Mod.RemoveModsByGame(uploadedMods, FormManager.CurrentGameName);
            SearchResults results = new SearchResults(uploadedMods, 3) { Parent = this };
            results.Show();
            this.Hide();
        }

        private void Favorite_OnDoubleClick(object sender, EventArgs e)
        {
            List<Resources.scripts.User> loadedUsers = Resources.scripts.User.LoadUsers();
            (List<Mod> downloadedMods, List<Mod> uploadedMods, List<Mod> favoriteMods) = Mod.GetModsForUser(Resources.scripts.User.CurrentUser);
            Mod.RemoveModsByGame(favoriteMods, FormManager.CurrentGameName);
            SearchResults results = new SearchResults(favoriteMods, 1) { Parent = this };
            this.Hide();
            results.Show();
        }


        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs ke = e;
            if (ke != null && ke.KeyCode == Keys.Enter)
            {
                this.Hide();
                SearchResults searchResult = new SearchResults(SearchBox) { Parent = this };
                searchResult.Show();
            }
        }

        private void Back(object sender, EventArgs e)
        {
            MainLauncher mainLauncher = new MainLauncher();
            this.Hide();
            mainLauncher.Show();
        }

        private void PublichButton_Click(object sender, EventArgs e)
        {
            Publich NewModForm = new Publich(FormManager.CurrentGameName) { Parent = this };
            this.Hide();
            NewModForm.Show();
        }

        private int buttonFunction = 0;
        private CheckedListBox checkedListBox;

        private void TagSeachButton_Click(object sender, EventArgs e)
        {
            if (buttonFunction == 0)
            {
                checkedListBox = new CheckedListBox();
                checkedListBox.Location = new Point(97, 130);
                checkedListBox.Size = new Size(200, 200);

                if (File.Exists($@"..\..\..\Resources\data\tags.txt"))
                {
                    var text = File.ReadAllText($@"..\..\..\Resources\data\tags.txt");
                    var gamestags = text.Split('\n');
                    string[] tagsAndName = new string[gamestags.Length];
                    for(int i = 0;i< gamestags.Length;i++)
                    {
                        tagsAndName[i] = gamestags[i].Split("◙")[1];
                    }
                    
                    string[] tags;
                    switch (FormManager.CurrentGameName)
                    {
                        case "Hoi4":
                            tags = tagsAndName[0].Split("┃");
                            break;
                        case "V3":
                            tags = tagsAndName[2].Split("┃");
                            break;
                        case "Ck3":
                            tags = tagsAndName[1].Split("┃");
                            break;
                        default:
                            tags = new string[0];
                            break;
                    }
                    checkedListBox.Items.AddRange(tags);
                    this.Controls.Add(checkedListBox);
                    TagSeachButton.Text = "Здійснити пошук";
                    buttonFunction++;
                }
                else
                {
                    MessageBox.Show("Файл с тегами не найден.");
                }
            }
            else if (buttonFunction >= 1)
            {
                Dictionary<string, bool> currentTags = new Dictionary<string, bool>();
                foreach (string item in checkedListBox.Items)
                {
                    currentTags[item] = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(item));
                }
                List<Mod> SearchedList = Mod.TagSearch(currentTags);
                SearchResults searchResult = new SearchResults(SearchedList) { Parent = this };
                searchResult.Show();
                this.Hide();
                buttonFunction = 0;
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Parent != null)
                Parent.Show();
            else
                Environment.Exit(0);
        }
    }
}
