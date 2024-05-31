using ParadoxModLauncher.Resources.scripts;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ParadoxModLauncher
{
    public partial class SearchResults : Form
    {
        public Search Parent;
        public SearchResults()
        {
            InitializeComponent();
            FormManager.CenterForm(this);
        }
        public SearchResults(List<Mod> searchResults, int cathegory)
        {
            this.Size = new Size(1110, 540);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(0, 30, 0, 0);
            this.Text = "Search Results";
            this.ControlBox = false;

            Panel titleBarPanel = new Panel();
            titleBarPanel.Dock = DockStyle.Top;
            titleBarPanel.Height = 30;
            titleBarPanel.BackColor = Color.Gray;

            Button closeButton = new Button();
            closeButton.Text = "X";
            closeButton.Dock = DockStyle.Right;
            closeButton.Width = 30;
            closeButton.Height = 30;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Click += (s, e) => { Parent.Show();this.Close(); };

            Button minimizeButton = new Button();
            minimizeButton.Text = "-";
            minimizeButton.Dock = DockStyle.Right;
            minimizeButton.Width = 30;
            minimizeButton.Height = 30;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            titleBarPanel.Controls.Add(minimizeButton);
            titleBarPanel.Controls.Add(closeButton);
            this.Controls.Add(titleBarPanel);

            TableLayoutPanel panel = new TableLayoutPanel();
            panel.BackColor = SystemColors.ControlDark;
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            panel.Padding = new Padding(0, 40, 0, 0);

            if (searchResults.Count > 0)
            {
                for (int i = 0; i < searchResults.Count; i++)
                {
                    Mod mod = searchResults[i];
                    (PictureBox pictureBox, TransparentLinkLabel label) = mod.ToLink(this);

                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    label.AutoSize = true;
                    label.MaximumSize = new Size(950, 0);
                    Button editButton = new Button();
                    Button removeButton = new Button();
                    removeButton.BackgroundImage = Properties.Resources._6807341;
                    removeButton.BackgroundImageLayout = ImageLayout.Zoom;
                    removeButton.FlatAppearance.BorderSize = 0;
                    removeButton.FlatStyle = FlatStyle.Flat;
                    removeButton.Location = new Point(490, 220);
                    removeButton.Name = "button1";
                    removeButton.Size = new Size(24, 24);
                    removeButton.TabIndex = 10;

                    removeButton.UseVisualStyleBackColor = true;
                    removeButton.Tag = new Tuple<PictureBox, TransparentLinkLabel>(pictureBox, label);
                    removeButton.Click += (sender, e) =>
                    {
                        if (cathegory == 1)
                        {
                            Button btn = sender as Button;
                            var controls = btn.Tag as Tuple<PictureBox, TransparentLinkLabel>;
                            PictureBox picBox = controls.Item1;
                            TransparentLinkLabel lbl = controls.Item2;

                            panel.Controls.Remove(picBox);
                            panel.Controls.Remove(lbl);
                            panel.Controls.Remove(lbl);
                            panel.Controls.Remove(editButton);
                            panel.Controls.Remove(removeButton);
                            MessageBox.Show("Модіфікацію видалено з категорії.", "Модіфікацію видалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            User.CurrentUser.RemoveModByCategory(cathegory, mod.Name);
                        }
                        if(cathegory == 3)
                        {
                            var result = MessageBox.Show("Ви дійсно хочете видалити модифікацію?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                    Button btn = sender as Button;
                                    var controls = btn.Tag as Tuple<PictureBox, TransparentLinkLabel>;
                                    PictureBox picBox = controls.Item1;
                                    TransparentLinkLabel lbl = controls.Item2;

                                    panel.Controls.Remove(picBox);
                                    panel.Controls.Remove(lbl);
                                    panel.Controls.Remove(lbl);
                                    mod.DeleteModFromFile();
                                    panel.Controls.Remove(editButton);
                                    panel.Controls.Remove(removeButton);
                                    MessageBox.Show("Модіфікацію видалено з категорії.", "Модіфікацію видалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    User.CurrentUser.RemoveModByCategory(cathegory, mod.Name);
                            }
                        }
                        if(cathegory == 2)
                        {
                                Button btn = sender as Button;
                                var controls = btn.Tag as Tuple<PictureBox, TransparentLinkLabel>;
                                PictureBox picBox = controls.Item1;
                                TransparentLinkLabel lbl = controls.Item2;

                                panel.Controls.Remove(picBox);
                                panel.Controls.Remove(lbl);
                                panel.Controls.Remove(lbl);
                                if (File.Exists(@"..\..\..\Resources\downloads\" + mod.Name.Replace(":", "") + ".zip"))
                                {
                                    File.Delete(@"..\..\..\Resources\downloads\" + mod.Name.Replace(":", "") + ".zip");
                                }
                                panel.Controls.Remove(editButton);
                                panel.Controls.Remove(removeButton);
                                MessageBox.Show("Модіфікацію видалено з категорії, а також з папки.", "Модіфікацію видалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                User.CurrentUser.RemoveModByCategory(cathegory, mod.Name);
                        }
                    };

                    pictureBox.Margin = new Padding(10, 10, 10, 10);
                    label.Margin = new Padding(10, 10, 10, 10);
                    removeButton.Margin = new Padding(10, 10, 10, 10);

                    panel.Controls.Add(pictureBox, 0, i);
                    panel.Controls.Add(label, 1, i);

                    if (cathegory == 3)
                    {
                        editButton.BackgroundImage = Properties.Resources.edit2;
                        editButton.BackgroundImageLayout = ImageLayout.Zoom;
                        editButton.FlatAppearance.BorderSize = 0;
                        editButton.FlatStyle = FlatStyle.Flat;
                        editButton.Location = new Point(965, 12);
                        editButton.Name = "EditButton";
                        editButton.Size = new Size(24, 24);
                        editButton.TabIndex = 10;
                        editButton.UseVisualStyleBackColor = true;
                        editButton.Click += (sender, e) =>
                        {
                            ModEditor modEditor = new ModEditor(mod) { Parent = this };
                            modEditor.Show();
                            this.Hide();
                        };

                        panel.Controls.Add(editButton, 2, i);
                        panel.Controls.Add(removeButton, 3, i);
                    }
                    else
                    {
                        panel.Controls.Add(removeButton, 2, i);
                    }
                }

            }
            else
            {
                TransparentLabel NoneLabel = new TransparentLabel();
                NoneLabel.AutoSize = true;
                NoneLabel.BackColor = SystemColors.Control;
                NoneLabel.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
                NoneLabel.ForeColor = Color.Red;
                NoneLabel.Location = new Point(318, 399);
                NoneLabel.Name = "NoneLabel";
                NoneLabel.Text = "Нічого не знайдено.";
                NoneLabel.Size = new Size(0, 31);
                NoneLabel.TabIndex = 5;
                panel.Controls.Add(NoneLabel);
            }
            this.Controls.Add(panel);
            FormManager.CenterForm(this);
            this.VisibleChanged += (sender, e) =>
            {
                if (!this.Visible)
                {
                    ReleaseImages(this);
                }
            };
        }

        private void ReleaseImages(Control control)
        {
            foreach (Control child in control.Controls)
            {
                if (child is PictureBox pictureBox && pictureBox.BackgroundImage != null)
                {
                    pictureBox.BackgroundImage.Dispose();
                    pictureBox.BackgroundImage = null;
                }
                if (child.Controls.Count > 0)
                {
                    ReleaseImages(child);
                }
            }
        }

        public SearchResults(List<Mod> searchResults) : this()
        {
            if (searchResults.Count == 0)
            {
                return;
            }
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.BackColor = SystemColors.ControlDark;
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
            for (int i = 0; i < searchResults.Count; i++)
            {
                Mod mod = searchResults[i];
                (PictureBox pictureBox, TransparentLinkLabel label) = mod.ToLink(this);

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                label.AutoSize = true;
                label.MaximumSize = new Size(950, 0);

                panel.Controls.Add(pictureBox, 0, i);
                panel.Controls.Add(label, 1, i);
            }
            panel.BringToFront();
            FormManager.CenterForm(this);
        }


        public SearchResults(TextBox textBox) : this()
        {
            string searchText = textBox.Text;
            List<Mod> mods = Mod.LoadMods();
            List<Mod> searchResults = Mod.Search(mods, searchText);
            if (searchResults.Count == 0)
            {
                return;
            }

            TableLayoutPanel panel = new TableLayoutPanel();
            panel.BackColor = SystemColors.ControlDark;
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);

            for (int i = 0; i < searchResults.Count; i++)
            {
                Mod mod = searchResults[i];
                (PictureBox pictureBox, TransparentLinkLabel label) = mod.ToLink(this);

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                label.AutoSize = true;
                label.MaximumSize = new Size(950, 0);

                panel.Controls.Add(pictureBox, 0, i);
                panel.Controls.Add(label, 1, i);
            }
            panel.BringToFront();
            FormManager.CenterForm(this);
        }
        public void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void SearchResults_Load(object sender, EventArgs e)
        {

        }

        private void SearchResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Show();
        }
    }
}
