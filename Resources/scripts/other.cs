using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace ParadoxModLauncher.Resources.scripts
{
    public static class Add
    {
        public static void DefaultText(Control[] controls)
        {
            foreach (Control control in controls)
            {
                string defaultText = control.Text;
                control.ForeColor = Color.Gray;

                control.Enter += (s, e) =>
                {
                    if (control.Text == defaultText)
                    {
                        control.Text = "";
                        control.ForeColor = Color.Black;
                    }
                };

                control.Leave += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        control.Text = defaultText;
                        control.ForeColor = Color.Gray;
                    }
                };
            }
        }
        public static async Task ChangeBoxColor(Color color, int delay = 100, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.BackColor = color;
            }

            await Task.Delay(delay);
        }
    }

    public class FormManager
    {
        public static void CenterForm(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - form.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - form.Height / 2
            );
        }

        public static string CurrentGameName { get; set; }
        public static void HandleArrowKeys(object sender, KeyEventArgs e, Form form, params Control[] controls)
        {
            int currentControlIndex = Array.IndexOf(controls, form.ActiveControl);
            if(form.Visible){
                if (e.KeyCode == Keys.Up)
                {
                    currentControlIndex--;
                    if (currentControlIndex < 0)
                    {
                        currentControlIndex = controls.Length - 1;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    currentControlIndex++;
                    if (currentControlIndex >= controls.Length)
                    {
                        currentControlIndex = 0;
                    }
                }
                controls[currentControlIndex].Focus();
            }
        }


        public static void CheckAndCloseForms(Form closingForm)
        {
            FormCollection openForms = Application.OpenForms;
            if (openForms.Count == 1 && openForms[0] == closingForm)
            {
                Application.Exit();
            }
        }

    }
    public class TextManager
    {
        public static string ETC(string input, int maxLength)
        {
            if (input == null || input.Length <= maxLength)
            {
                return input;
            }

            return input.Substring(0, maxLength) + "...";
        }
        public static string FormatText(string text, int maxLineLength)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i += maxLineLength)
            {
                if (i + maxLineLength > text.Length)
                    sb.Append(text.Substring(i));
                else
                    sb.AppendLine(text.Substring(i, maxLineLength));
            }
            return sb.ToString();
        }

    }
}
