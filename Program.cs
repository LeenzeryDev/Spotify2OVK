using System.Configuration;

namespace Spotify2OVK
{
    internal static class Program
    {
        private static Configuration config;
        private static AppSettingsSection app;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            app = config.AppSettings;
            if (app.Settings.Count != 0)
            {
                Application.Run(new MainForm());
            }
            else {
                Application.Run(new LoginForm());
            }
        }
    }
}