using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ParadoxModLauncher.Resources.scripts
{
    public class User
    {
        public string filePath = @"..\..\..\Resources\data\users.txt";
        public string Login { get; set; }
        public static User CurrentUser { get; set; }
        public string Pass { get; set; }
        public string Secret { get; set; }
        public string Game { get; set; }
        public List<string> Downloads { get; set; }
        public List<string> Uploads { get; set; }
        public List<string> Favorite { get; set; }
       
        public User() 
        {
            
        }

        public static void UpdateCurrentUser()
        {
            CurrentUser = LoadUsers().FirstOrDefault(u => u.Login == CurrentUser.Login);
        }

        public User(string login, string pass, string secret)
        {
            Login = login;
            Pass = pass;
            Secret = secret;
            Downloads = new List<string>();
            Uploads = new List<string>();
            Favorite = new List<string>();
        }

        public static List<User> LoadUsers(string filePath = @"..\..\..\Resources\data\users.txt")
        {
            filePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath));
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length == 0)
            {
                return new List<User>();
            }

            List<User> users = new List<User>();

            foreach (var line in lines)
            {
                User user = new User();
                var parts = line.Split("┃");
                user.Login = parts[0];
                user.Pass = parts[1];   
                user.Secret = parts[2];
                user.Favorite = parts[3].Split("◙").ToList();
                user.Downloads = parts[4].Split("◙").ToList();
                user.Uploads =  parts[5].Split("◙").ToList();
                users.Add(user);
            }
            return users;
        }

        public void AddModByCategory(int category, Mod mod)
        {
            List<User> users = LoadUsers();
            User currentUser = users.FirstOrDefault(u => u.Login == CurrentUser.Login);

            if (currentUser == null)
            {
                SaveCredentials(CurrentUser);
                currentUser = CurrentUser;
            }

            string modName = mod.Name;

            switch (category)
            {
                case 1:
                    if (!currentUser.Favorite.Contains(modName))
                    {
                        currentUser.Favorite.Add(modName);
                        CurrentUser.Favorite.Add(modName); 
                    }
                    break;
                case 2:
                    if (!currentUser.Downloads.Contains(modName))
                    {
                        currentUser.Downloads.Add(modName);
                        CurrentUser.Downloads.Add(modName); 
                    }
                    break;
                case 3:
                    if (!currentUser.Uploads.Contains(modName))
                    {
                        currentUser.Uploads.Add(modName);
                        CurrentUser.Uploads.Add(modName); 
                    }
                    break;
                case >3:
                    MessageBox.Show("Непередбачувана помилка.", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default: break;
            }

            var updatedLine = $"{currentUser.Login}┃{currentUser.Pass}┃{currentUser.Secret}┃{string.Join("◙", currentUser.Favorite)}┃{string.Join("◙", currentUser.Downloads)}┃{string.Join("◙", currentUser.Uploads)}";
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split("┃");
                if (parts[0] == currentUser.Login)
                {
                    lines[i] = updatedLine;
                    break;
                }
            }
            File.WriteAllLines(filePath, lines);
        }

        public void RemoveModByCategory(int category, string modName)
        {
            List<User> users = LoadUsers();
            User currentUser = users.FirstOrDefault(u => u.Login == this.Login);

            if (currentUser == null)
            {
                return;
            }

            switch (category)
            {
                case 1:
                    currentUser.Favorite.Remove(modName);
                    break;
                case 2:
                    currentUser.Downloads.Remove(modName);
                    break;
                case 3:
                    currentUser.Uploads.Remove(modName);
                    break;
                default: return;
            }

            var updatedLine = $"{currentUser.Login}┃{currentUser.Pass}┃{currentUser.Secret}┃{string.Join("◙", currentUser.Favorite)}┃{string.Join("◙", currentUser.Downloads)}┃{string.Join("◙", currentUser.Uploads)}";
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split("┃");
                if (parts[0] == currentUser.Login)
                {
                    lines[i] = updatedLine;
                    break;
                }
            }
            File.WriteAllLines(filePath, lines);
            UpdateCurrentUser();
        }

        public static void SaveCredentials(User user, string filePath = @"..\..\..\Resources\data\users.txt")
        {
            filePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath));
            user.Login = user.Login.Replace("\n", "").Replace("\r", "");
            user.Pass = user.Pass.Replace("\n", "").Replace("\r", "");
            user.Secret = user.Secret.Replace("\n", "").Replace("\r", "");
            var fav = user.Favorite.Count == 0 ? "" : user.Favorite.ToString();
            var down = user.Downloads.Count == 0 ? "" : user.Downloads.ToString();
            var upl = user.Uploads.Count == 0 ? "" : user.Uploads.ToString();
            string credentials = $"{user.Login}┃{user.Pass}┃{user.Secret}┃{fav}┃{down}┃{upl}";
            File.AppendAllText(path: filePath, contents: credentials + Environment.NewLine);
        }
        
    }

    public class Mod
    {
        public string Name { get; set; }
        public List<string> Authors { get; set; } = new List<string>();
        public string Date { get; set; }
        public string Size { get; set; }
        public string Desc { get; set; }
        public Dictionary<string, bool> Tags { get; set; } = new Dictionary<string, bool>();
        public string Game { get; set; }
        public Image Image { get; set; }

        public Mod() 
        {
           
        }

        public void DeleteModFromFile()
        {
            string modsFilePath = @"..\..\..\Resources\data\mods.txt";
            var lines = File.ReadAllLines(modsFilePath).ToList();
            bool modDeleted = false;

            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split("┃");
                if (parts[0].Trim() == this.Name && parts[2].Trim() == this.Date && parts[6].Trim() == this.Game)
                {
                    // Check if authors match
                    var savedAuthors = parts[1].Split("◙").Select(author => author.Trim());
                    if (savedAuthors.SequenceEqual(this.Authors))
                    {
                        lines.RemoveAt(i);
                        modDeleted = true;
                        break;
                    }
                }
            }

            if (modDeleted)
            {
                File.WriteAllLines(modsFilePath, lines);
                string imagePath = $@"..\..\..\Resources\images\mods\{this.Game}\{this.Name}.jpg";
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }
                UpdateModNameInUsersFile(this.Name, string.Empty); 
                MessageBox.Show("Мод було успішно видалено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Мод не знайдено для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static List<Mod> LoadMods(string modsFilePath = null, string tagsFilePath = null)
        {
            List<Mod> modData = new List<Mod>();
            modsFilePath ??= @"..\..\..\Resources\data\mods.txt";
            tagsFilePath ??= @"..\..\..\Resources\data\tags.txt";

            string[] tagLines = File.ReadAllLines(tagsFilePath);
            Dictionary<string, List<string>> gameTags = new Dictionary<string, List<string>>();
            foreach (string tagLine in tagLines)
            {
                string[] gameAndTags = tagLine.Split("◙");
                string game = gameAndTags[0].Trim();
                List<string> tags = gameAndTags[1].Split("┃").Select(t => t.Trim()).ToList();
                gameTags[game] = tags;
            }
            string[] modLines = File.ReadAllLines(modsFilePath);
            foreach (string modLine in modLines)
            {
                string[] parts = modLine.Split("┃");
                Mod mod = new Mod
                {
                    Name = parts[0].Trim(),
                    Authors = parts[1].Split("◙").ToList(),
                    Date = parts[2].Trim(),
                    Size = parts[3].Trim(),
                    Desc = parts[4].Trim(),
                    Game = parts[6].Trim(),
                    Tags = new Dictionary<string, bool>(),
                    
                };
                try{
                    using (FileStream fileStream = new FileStream($@"..\..\..\Resources\images\mods\{mod.Game}\{mod.Name.Replace(":", "")}.jpg", FileMode.Open, FileAccess.Read))
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        fileStream.CopyTo(memoryStream);
                        memoryStream.Position = 0;
                        mod.Image = Image.FromStream(memoryStream);
                    }
                }
                catch {
                    using (FileStream fileStream = new FileStream($@"..\..\..\Resources\images\interface\DragImage.jpg", FileMode.Open, FileAccess.Read))
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        fileStream.CopyTo(memoryStream);
                        memoryStream.Position = 0; 
                        mod.Image = Image.FromStream(memoryStream);
                    }
                }
                if (gameTags.TryGetValue(mod.Game, out List<string> gameSpecificTags))
                {
                    string[] tagValues = parts[5].Split('‖');
                    for (int i = 0; i < gameSpecificTags.Count - 1; i++)
                    {
                        mod.Tags[gameSpecificTags[i]] = tagValues[i] == "1";
                    }
                }

                modData.Add(mod);
            }


            return modData;
        }

        public Mod DeepCopy()
        {
            Mod copy = new Mod
            {
                Name = this.Name,
                Authors = new List<string>(this.Authors),
                Date = this.Date,
                Size = this.Size,
                Desc = this.Desc,
                Tags = new Dictionary<string, bool>(this.Tags),
                Game = this.Game,
                Image = (Image)this.Image.Clone()
            };
            return copy;
        }


        public Mod(string name, List<string> authors, string date, string size, string desc, Dictionary<string, bool> tags, Image image)
        {
            Name = name;
            Authors = authors ?? new List<string>();
            Authors.Insert(0, User.CurrentUser.Login);
            Date = date;
            Size = size;
            Image = image;
            Tags = tags;
            Desc = desc;
        }

        public static(List<Mod> downloadedMods, List<Mod> uploadedMods, List<Mod> favoriteMods) GetModsForUser(User user)
        {
            List<Mod> allMods = LoadMods(); 
            List<Mod> downloadedMods = new List<Mod>();
            List<Mod> uploadedMods = new List<Mod>();
            List<Mod> favoriteMods = new List<Mod>();

            if(downloadedMods != null && uploadedMods != null && favoriteMods != null)
            {
                foreach (Mod mod in allMods)
                {
                    if (user.Downloads.Contains(mod.Name))
                        downloadedMods.Add(mod);

                    if (user.Uploads.Contains(mod.Name))
                        uploadedMods.Add(mod);

                    if (user.Favorite.Contains(mod.Name))
                        favoriteMods.Add(mod);
                }
                return (downloadedMods, uploadedMods, favoriteMods);
            }
            else
            {
                return (downloadedMods, uploadedMods, favoriteMods);
            }
        }

        public static List<Mod> TagSearch(Dictionary<string, bool> searchingTags)
        {
            List<Mod> mods = LoadMods();
            RemoveModsByGame(mods, FormManager.CurrentGameName);
            List<Mod> result = new List<Mod>();

            foreach (Mod mod in mods)
            {
                int matchingTags = 0;
                foreach (KeyValuePair<string, bool> tag in searchingTags)
                {
                    if (tag.Value && mod.Tags.ContainsKey(tag.Key) && mod.Tags[tag.Key])
                    {
                        matchingTags++;
                    }
                }
                if (matchingTags >= 3)
                {
                    result.Add(mod);
                }
            }
            return result;
        }

        public static List<Mod> Search(List<Mod> mods, string searchText)
        {
            return mods.Where(m =>
                (m.Name.Contains(searchText) || m.Authors.Any(a => a.Contains(searchText)) ||
                m.Date.Contains(searchText) || m.Size.Contains(searchText) || m.Desc.Contains(searchText)) &&
                m.Game == FormManager.CurrentGameName)
                .ToList();
        }

        public static void RemoveModsByGame(List<Mod> mods, string game)
        {
            List<Mod> modsToRemove = mods.Where(m => m.Game != game).ToList();

            foreach (Mod mod in modsToRemove)
            {
                mods.Remove(mod);
            }
        }

        public void Save()
        {
            string tagsString = string.Join('‖', Tags.Select(t => t.Value ? "1" : "0"));
            DateTime date = DateTime.ParseExact(Date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string formattedDate = date.ToString("dd MMM yyyy 'о' HH:mm", new CultureInfo("uk-UA"));
            string modDataLine = $"{Name}┃{string.Join("◙", Authors)}┃{formattedDate}┃{Size}┃{Desc}┃{tagsString}┃{FormManager.CurrentGameName}";
            string modsFilePath = @"..\..\..\Resources\data\mods.txt";
            File.AppendAllText(modsFilePath, modDataLine + Environment.NewLine);
            string imagePath = $@"..\..\..\Resources\images\mods\{FormManager.CurrentGameName}\{Name}.jpg";
            Image.Save(imagePath, ImageFormat.Jpeg);
        }
        public void EditSave(Mod CurrentMod, Panel PicturePanel)
        {
            string modsFilePath = @"..\..\..\Resources\data\mods.txt";

            var lines = File.ReadAllLines(modsFilePath).ToList();
            bool found = false;
            string sanitizedDesc = this.Desc.Replace("\n", " ");

            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split("┃");
                if (parts[0].Trim() == CurrentMod.Name && parts[6].Trim() == CurrentMod.Game)
                {
                    found = true;
                    lines[i] = $"{this.Name}┃{string.Join("◙", this.Authors)}┃{this.Date}┃{this.Size}┃{sanitizedDesc}┃{string.Join('‖', this.Tags.Select(t => t.Value ? "1" : "0"))}┃{this.Game}";
                    break;
                }
            }

            if (found)
            {
                if (PicturePanel.BackgroundImage != null)
                {
                    this.Image = PicturePanel.BackgroundImage;
                   
                }
                File.WriteAllLines(modsFilePath, lines);
                if (this.Image != null)
                {
                    string imagePath = $@"..\..\..\Resources\images\mods\{this.Game}\{this.Name}.jpg";
                    string directoryPath = Path.GetDirectoryName(imagePath);
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    this.Image.Save(imagePath, ImageFormat.Jpeg);
                    PicturePanel.BackgroundImage.Dispose();
                    PicturePanel.BackgroundImage = null;
                }
                UpdateModNameInUsersFile(CurrentMod.Name, this.Name);
            }
            else
            {
                MessageBox.Show("Мод не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateModNameInUsersFile(string oldModName, string newModName)
        {
            string usersFilePath = @"..\..\..\Resources\data\users.txt";
            var lines = File.ReadAllText(usersFilePath);
            File.WriteAllText(usersFilePath, lines.Replace(oldModName, newModName));
        }


        public void SaveTo(string path)
        {
            string tagsString = string.Join('‖', Tags.Values.Select(b => b ? "1" : "0"));
            Directory.CreateDirectory(path);
            string validName = Regex.Replace(Name, @"[<>:""/\\|?*]", "");

            string zipFileName = Path.Combine(path, $"{validName}.zip");
            if (!File.Exists(zipFileName))
            {
                MessageBox.Show("Модіфікацію завантажено.", "Модіфікацію завантажено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (var zipArchive = ZipFile.Open(zipFileName, ZipArchiveMode.Create))
                {
                    var entry = zipArchive.CreateEntry("mods.txt");
                    using (var streamWriter = new StreamWriter(entry.Open()))
                    {
                        string modDataLine = $"\r\n{Name}┃{string.Join("◙", Authors)}┃{Date}┃{Size}┃{Desc}┃{tagsString}┃{FormManager.CurrentGameName}";
                        streamWriter.Write(modDataLine);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл вже завантажено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public (PictureBox, TransparentLinkLabel) ToLink(SearchResults sr)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(48, 48);
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.BackgroundImage = Image;

            TransparentLinkLabel label = new TransparentLinkLabel();
            label.Parent = sr;
            label.Click += (s,e) => {
                ModPage modPage = new ModPage(this) { Parent = (s as Control).Parent.Parent as Form};
                modPage.Show();
            };
            label.AutoSize = true;
            var activeTags = Tags.Where(t => t.Value).Select(t => t.Key);
            label.Text = $"Ім'я моду:{Name} Автори: {string.Join(", ", Authors)} Дата опублікування: {Date} Розмір моду: {Size} Теги: {string.Join(", ", activeTags)}";
            label.Font = new Font("Garamond", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.ForeColor = Color.White;
            label.BackColor = Color.Transparent;
            label.Tag = Name;

            return (pictureBox, label);
        }
    }
}
