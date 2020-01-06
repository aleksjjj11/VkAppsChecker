using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Threading;
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
        private List<ulong> AppsId = new List<ulong>{6978390, 5099068, 2427019, 5492280, 6908748};
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
            Thread gettingApps = new Thread(LoadAppsInTextBox);
            gettingApps.IsBackground = true;
            gettingApps.Name = "Getting apps";
            gettingApps.Start();
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
        
        private void LoadAppsInTextBox()
        {
            if (!_client.IsAuthorized) return;
            try
            {
                var apps = _client.Apps.Get(new AppGetParams
                {
                    AppIds = AppsId,
                    ReturnFriends = true
                });
                listBox_Apps.Text = "";
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

        private void LoadCurrentApps()
        {
            if (!_client.IsAuthorized) return;
            try
            {
                var apps = _client.Apps.Get(new AppGetParams
                {
                    AppIds = AppsId,
                    ReturnFriends = false
                });
                listBox_AppsId.Text = "";
                listBox_AppsTitle.Text = "";
                foreach (var app in apps.Apps)
                {
                    listBox_AppsTitle.Items.Add($"App:{app.Title}");
                    listBox_AppsId.Items.Add($"Id:{app.Id}");
                }
            } catch (Exception exception) {Console.WriteLine(exception.Message);}
        }

        private void textBox_NewApp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    AppsId.Add(Convert.ToUInt64(textBox_NewApp.Text));
                    var apps = _client.Apps.Get(new AppGetParams
                    {
                        AppIds = new ulong[] {Convert.ToUInt64(textBox_NewApp.Text)}
                    });
                    if (apps.Apps.First() is null) throw new Exception();
                    textBox_NewApp.Text = "";
                    Thread gettingCurrentApps = new Thread(LoadCurrentApps);
                    gettingCurrentApps.IsBackground = true;
                    gettingCurrentApps.Name = "Getting apps";
                    gettingCurrentApps.Start();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Incorrect ID. Repeat please.");
                }
            }
        }

        private void Pasring()
        {
            listBox_AppsId.Text = "";
            listBox_AppsTitle.Text = "";
            for (ulong i = 1; i < 10000000; i++)
            {
                try
                {
                    var apps = _client.Apps.Get(new AppGetParams
                    {
                        AppIds = new ulong[] {i}
                    });
                    if (apps.Apps.First() is null) continue;

                    listBox_AppsTitle.Items.Add($"App:{apps.Apps.First()?.Title}");
                    listBox_AppsId.Items.Add($"Id:{apps.Apps.First()?.Id}");
                }
                catch (Exception exception)
                {
                    listBox_AppsTitle.Items.Add("Error");
                    listBox_AppsId.Items.Add("Error");
                }
            }
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Pasring);
            thread.IsBackground = true;
            thread.Start();
        }
    }
}