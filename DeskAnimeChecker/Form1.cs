using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using VkNet;
using VkNet.AudioBypassService.Extensions;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;
using Application = System.Windows.Forms.Application;

namespace DeskAnimeChecker
{
    public partial class Form1 : Form
    {
        private VkApi _client;
        public Form1()
        {
            InitializeComponent();
            var service = new ServiceCollection();
            service.AddAudioBypass();
            _client = new VkApi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_GetApps_Click(object sender, EventArgs e)
        {
            if (!_client.IsAuthorized) return;
            try
            {
                var apps = _client.Apps.Get(new AppGetParams
                {
                    AppIds = new ulong[] {6978390, 5099068, 2427019, 5492280, 6908748},
                    ReturnFriends = true
                });
                foreach (var app in apps.Apps)
                {
                    listBox_Apps.Items.Add($"App: {app.Title}");
                    listBox_Apps.Items.Add($"Author App: {app.AuthorId}");
                    foreach (var friend in app.Friends)
                    {
                        User frUser = _client.Users.Get(new long[1] {friend}, ProfileFields.FirstName | ProfileFields.LastName).First();
                        listBox_Apps.Items.Add($"Friend: {frUser.FirstName} {frUser.LastName}");
                    }
                }
                //listBox_Apps.Items.Add($"App: {apps.Apps.First().Title}");
                //_client.Apps.GetCatalog()
            } catch (Exception exception) {Console.WriteLine(exception.Message);}
        }

        private void button_Auth_Click(object sender, EventArgs e)
        {
            _client = new VkApi();
            try
            {
                _client.Authorize(new ApiAuthParams
                {
                    ApplicationId = 7267974,
                    Login = textBox_Login.Text,
                    Password = textBox_Password.Text,
                    Settings = Settings.All
                });
                label_Error.ForeColor = Color.Lime;
                label_Error.Text = "Всё чётко";
            }
            catch (Exception exception)
            {
                if (!_client.IsAuthorized)
                {
                    label_Error.ForeColor = Color.Red;
                    label_Error.Text = "Что-то не так";
                }
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            label_Error.Text = " ";
        }

        private void button_GetAppsById_Click(object sender, EventArgs e)
        {
            if (!_client.IsAuthorized) return;
            try
            {
                var apps = _client.Apps.Get(new AppGetParams
                {
                    AppIds = new ulong[] {6978390, 5099068, 2427019, 5492280},
                    ReturnFriends = true
                });
                foreach (var app in apps.Apps)
                {
                    listBox_Apps.Items.Add($"App: {app.Title}");
                    listBox_Apps.Items.Add($"Author App: {app.AuthorId}");
                    foreach (var friend in app.Friends)
                    {
                        User frUser = _client.Users.Get(new long[] {friend}, ProfileFields.FirstName | ProfileFields.LastName).First();
                        listBox_Apps.Items.Add($"Friend: {frUser.FirstName} {frUser.LastName}");
                    }
                }
            } catch (Exception exception) {Console.WriteLine(exception.Message);}
        }
    }
}