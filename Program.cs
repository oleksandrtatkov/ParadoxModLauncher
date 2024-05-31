namespace ParadoxModLauncher
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainLauncher mainLauncher = new MainLauncher();
            Application.Run(new LoginForm(mainLauncher));
        }
    }
}
