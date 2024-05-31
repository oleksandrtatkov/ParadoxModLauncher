using System;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
using ParadoxModLauncher.Resources.scripts;

namespace ParadoxModLauncher
{
    public partial class LoginForm : Form
    {

        public MainLauncher mainLauncher = new MainLauncher();
        public Dictionary<string, string> users = new Dictionary<string, string>();

        public LoginForm(MainLauncher mainLauncher)
        {
            InitializeComponent();
            this.mainLauncher = mainLauncher;
            Add.DefaultText([LoginTextBox]);
            Add.DefaultText([PassTextBox]);
        }

        public LoginForm()
        {
            InitializeComponent();
            Add.DefaultText([LoginTextBox]);
            Add.DefaultText([PassTextBox]);
        }

        private async void CheckLoginAndPassword()
        {
            string login = LoginTextBox.Text;
            string password = PassTextBox.Text;
            List<User> loadedUsers = User.LoadUsers();

            User user = loadedUsers.FirstOrDefault(u => u.Login == login);

            if (user != null && user.Pass == password)
            {
                User.CurrentUser = user;
                this.Hide();
                mainLauncher.Show();
            }
            else
            {
                await Add.ChangeBoxColor(Color.Red, 100, LoginTextBox, PassTextBox);
                await Add.ChangeBoxColor(Color.White, 100, LoginTextBox, PassTextBox);

                await Add.ChangeBoxColor(Color.Red, 100, LoginTextBox, PassTextBox);
                await Add.ChangeBoxColor(Color.White, 100, LoginTextBox, PassTextBox);

                await Add.ChangeBoxColor(Color.Red, 100, LoginTextBox, PassTextBox);
                await Add.ChangeBoxColor(Color.White, 100, LoginTextBox, PassTextBox);
            }
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckLoginAndPassword();
            }
            FormManager.HandleArrowKeys(sender, e, this, LoginTextBox, PassTextBox);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckLoginAndPassword();
            }
            FormManager.HandleArrowKeys(sender, e, this, LoginTextBox, PassTextBox);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegLostPassForm regLostPassForm = new RegLostPassForm();
            
            regLostPassForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
