using ParadoxModLauncher.Resources.scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParadoxModLauncher
{
    public partial class LostPassForm : Form
    {
        User loginManager = new User();
        public MainLauncher mainLauncher = new MainLauncher();
        public event EventHandler ButtonClicked;
        public LostPassForm()
        {
            FormManager.CenterForm(this);
            InitializeComponent();
            Add.DefaultText([LoginBox]);
            Add.DefaultText([NewPassBox]);
            Add.DefaultText([SecretPhraseBox]);
            Add.DefaultText([OldPassBox]);
        }

        private void Back(object sender, EventArgs e)
        {
            RegLostPassForm regLostPassForm = new RegLostPassForm();
            this.Hide();
            regLostPassForm.Show();
        }

        public async void CheckCredentials()
        {
            string login = LoginBox.Text;
            string secretPhrase = SecretPhraseBox.Text;
            string oldPassword = OldPassBox.Text;
            string newPassword = NewPassBox.Text;

            string[] lines = File.ReadAllLines(@"..\..\..\Resources\data\users.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] credentials = lines[i].Split("┃");

                if (credentials[0] == login && (credentials[1] == oldPassword || credentials[2] == secretPhrase))
                {
                    credentials[1] = newPassword;
                    lines[i] = string.Join("┃", credentials);
                    File.WriteAllLines(loginManager.filePath, lines);
                    mainLauncher.Show();
                    this.Close();
                    string message = "Пароль змінено успішно!";
                    string title = "Успішно";
                    List<User> loadedUsers = User.LoadUsers();
                    User user = loadedUsers.FirstOrDefault(u => u.Login == login);
                    User.CurrentUser = user;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
                    return;
                }
            }

            await Add.ChangeBoxColor(Color.Red, 100, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);
            await Add.ChangeBoxColor(Color.White, 100, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);

            await Add.ChangeBoxColor(Color.Red, 100, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);
            await Add.ChangeBoxColor(Color.White, 100, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);

            await Add.ChangeBoxColor(Color.Red, 100, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);
            await Add.ChangeBoxColor(Color.White, 100, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);
        }


        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs ke = e as KeyEventArgs;
            if (ke != null && ke.KeyCode == Keys.Enter)
            {
                CheckCredentials();
            }
            FormManager.HandleArrowKeys(sender, e, this, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);
        }

        private void SecretPhraseBox_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs ke = e as KeyEventArgs;
            if (ke != null && ke.KeyCode == Keys.Enter)
            {
                CheckCredentials();
            }
            FormManager.HandleArrowKeys(sender, e, this, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);
        }

        private void OldPassBox_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs ke = e as KeyEventArgs;
            if (ke != null && ke.KeyCode == Keys.Enter)
            {
                CheckCredentials();
            }
            FormManager.HandleArrowKeys(sender, e, this, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);
        }

        private void NewPassBox_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs ke = e as KeyEventArgs;
            if (ke != null && ke.KeyCode == Keys.Enter)
            {
                CheckCredentials();
            }
            FormManager.HandleArrowKeys(sender, e, this, LoginBox, SecretPhraseBox, OldPassBox, NewPassBox);
        }

        private void LostPassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.CheckAndCloseForms(this);
        }
    }
}
