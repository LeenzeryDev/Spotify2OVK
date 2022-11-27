using OpenVkNetApi;
using System.Configuration;

namespace Spotify2OVK
{
    public partial class LoginForm : Form
    {
        private OVkApi api = new();
        private Configuration config;
        private AppSettingsSection app;
        public LoginForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            app = config.AppSettings;
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(login.Text) && !string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(instance.Text))
            {
                app.Settings.Add("ovkToken", api.Authorization(login.Text, password.Text, instance.Text).access_token);
                app.Settings.Add("ovkInstance", instance.Text);
                config.Save(ConfigurationSaveMode.Modified);
                ToMainForm();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }
        private void ToMainForm() {
            MainForm form = new();
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}