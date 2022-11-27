using OpenVkNetApi;
using OpenVkNetApi.Models;
using System.Configuration;
using System.Diagnostics;

namespace Spotify2OVK
{
    public partial class MainForm : Form
    {
        private Configuration config;
        private AppSettingsSection app;
        private string firstSongName;
        private string status;
        private AuthorizedUser user;
        private OVkApi api = new();
        
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            app = config.AppSettings;
            var token = ConfigurationManager.AppSettings["ovkToken"];
            var instance = ConfigurationManager.AppSettings["ovkInstance"];
            user =  new AuthorizedUser(token, instance);
            status = $"{user.account.GetProfileInfo().status}";
            FormClosing += new FormClosingEventHandler(AppClosing);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            song.Text = GetSpotifySongName();
            songChecker.Start();
        }
        private string? GetSpotifySongName()
        {
            try
            {
                var proc = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));
                return proc.MainWindowTitle.Equals("Spotify Free") || proc.MainWindowTitle.Equals("Spotify Premium") ? null : proc.MainWindowTitle;
            }
            catch
            {
                MessageBox.Show("Spotify не запущен");
                return null;
            }
        }

        private void songChecker_Tick(object sender, EventArgs e)
        {
            if (firstSongName != GetSpotifySongName())
            {
                song.Text = GetSpotifySongName();
                firstSongName = GetSpotifySongName();
                if (GetSpotifySongName() != null) { 
                    user.account.SaveProfileInfo(status: $"Слушает в Spotify: {GetSpotifySongName()}");
                }
                else
                {
                    user.account.SaveProfileInfo(status: status);
                }
            }
        }

        private void AppClosing(object sender, FormClosingEventArgs e)
        {
            user.account.SaveProfileInfo(status: status);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            user.account.SaveProfileInfo(status: status);
            app.Settings.Remove("ovkToken");
            app.Settings.Remove("ovkInstance");
            config.Save(ConfigurationSaveMode.Modified);
            LoginForm form = new();
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
