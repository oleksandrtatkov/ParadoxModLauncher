using ParadoxModLauncher.Resources.scripts;

namespace ParadoxModLauncher
{
    public partial class MainLauncher : Form
    {
        public MainLauncher()
        {
            InitializeComponent();
            FormManager.CenterForm(this);
        }

        private void MainLauncher_Load(object sender, EventArgs e)
        {

        }

        private void Hoi_OnClick(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.CurrentGameName = "Hoi4";
            Search Search = new Search(FormManager.CurrentGameName) { Parent = this };
            Search.Show();
        }

        private void V3_OnClick(object sender, EventArgs e)
        {
            FormManager.CurrentGameName = "V3";
            Search Search = new Search(FormManager.CurrentGameName) { Parent = this };
            this.Hide();
            Search.Show();
        }

        private void CK3_OnClick(object sender, EventArgs e)
        {
            FormManager.CurrentGameName = "Ck3";
            Search Search = new Search(FormManager.CurrentGameName) { Parent = this };
            this.Hide();
            Search.Show();
        }

        private void MainLauncher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
