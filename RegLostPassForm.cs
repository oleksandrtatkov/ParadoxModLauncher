using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParadoxModLauncher.Resources.scripts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParadoxModLauncher
{
    public partial class RegLostPassForm : Form
    {
        private MainLauncher mainLauncher = new MainLauncher();
        private LostPassForm lostPassForm = new LostPassForm();
        public RegLostPassForm()
        {
            FormManager.CenterForm(this);
            InitializeComponent();
            Add.DefaultText([RegLogBox]);
            Add.DefaultText([RegSecretBox]);
            Add.DefaultText([RegPassBox]);
        }

        private void RegLogBox_KeyDown(object sender, EventArgs e)
        {
            KeyEventArgs ke = e as KeyEventArgs;
            if (ke != null && ke.KeyCode == Keys.Enter)
            {
                SaveCredentialsIfNotEmpty();
            }
            FormManager.HandleArrowKeys(sender, ke, this, RegLogBox, RegPassBox, RegSecretBox);
        }

        private void RegPassBox_KeyDown(object sender, EventArgs e)
        {
            KeyEventArgs ke = e as KeyEventArgs;
            if (ke != null && ke.KeyCode == Keys.Enter)
            {
                SaveCredentialsIfNotEmpty();
            }
            FormManager.HandleArrowKeys(sender, ke, this, RegLogBox, RegPassBox, RegSecretBox);
        }

        private void SecretPhraseBox_KeyDown(object sender, EventArgs e)
        {
            KeyEventArgs ke = e as KeyEventArgs;
            if (ke != null && ke.KeyCode == Keys.Enter)
            {
                SaveCredentialsIfNotEmpty();
            }
            FormManager.HandleArrowKeys(sender, ke, this, RegLogBox, RegPassBox, RegSecretBox);
        }

        private async void SaveCredentialsIfNotEmpty()
        {

            string login = RegLogBox.Text;
            string password = RegPassBox.Text;
            string secret = RegSecretBox.Text;
            // Діапазон українських літер: \u0400-\u04FF
            Regex loginRegex = new Regex(@"^[a-zA-Z0-9а-яА-ЯіїєґІЇЄҐ\u0400-\u04FF]{3,}$");
            Regex passwordRegex = new Regex(@"^[a-zA-Z0-9а-яА-ЯіїєґІЇЄҐ\u0400-\u04FF]{8,}$");
            Regex secretRegex = new Regex(@"^[a-zA-Z0-9а-яА-ЯіїєґІЇЄҐ\u0400-\u04FF _!?]+$");


            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(secret) && loginRegex.IsMatch(login) && passwordRegex.IsMatch(password) && secretRegex.IsMatch(secret))
            {
                List<User> users = User.LoadUsers();
                if(users.Count > 0)
                {
                    if (users.Any(u => u.Login == login))
                    {
                        MessageBox.Show("Користувач з таким логіном вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                User user = new User(login, password, secret);;
                User.SaveCredentials(user);
                User.CurrentUser = user;
                string message = "Реєстрація пройшла успішно!";
                string title = "Успішно";
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
                this.Hide();
                mainLauncher.Show();
            }
            else if(!(loginRegex.IsMatch(login)))
            {
                MessageBox.Show("Некоректні данні - логін може містити тільки цифри, латиньські літери або кирилицю, мінімальна довжина - 3 символа", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(passwordRegex.IsMatch(password)))
            {
                MessageBox.Show("Некоректні данні - пароль може містити тільки цифри, латиньські літери або кирилицю, мінімальна довжина - 8 символів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(secretRegex.IsMatch(secret)))
            {
                MessageBox.Show("Некоректні данні - секретна фраза може містити тільки цифри, латиньські літери, кирилицю або символи: _ ? !, мінімальна довжина - 16 символів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await Add.ChangeBoxColor(Color.Red, 100, RegLogBox, RegSecretBox, RegPassBox);
                await Add.ChangeBoxColor(Color.White, 100, RegLogBox, RegSecretBox, RegPassBox);

                await Add.ChangeBoxColor(Color.Red, 100, RegLogBox, RegSecretBox, RegPassBox);
                await Add.ChangeBoxColor(Color.White, 100, RegLogBox, RegSecretBox, RegPassBox);

                await Add.ChangeBoxColor(Color.Red, 100, RegLogBox, RegSecretBox, RegPassBox);
                await Add.ChangeBoxColor(Color.White, 100, RegLogBox, RegSecretBox, RegPassBox);
            }
        }

        private void transparentLabel1_Click(object sender, EventArgs e)
        {

        }

        private void RegPassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void transparentLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void LostPassEvent(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lostPassForm.Show();
            this.Hide();
        }


        private void Back(object sender, EventArgs e)
        {

            this.Hide();
            LoginForm loginForm1 = new LoginForm();
            loginForm1.Show();
        }

        private void RegLostPassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.CheckAndCloseForms(this);
        }
    }
}

