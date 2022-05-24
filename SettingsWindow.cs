using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulturedDownloaderV3
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        { 
            InitializeComponent();
            SourceSelection.SelectedItem = SourceSelection.Items[0];
            FolderPath.Text = @"C:\Users\Public\Pictures";
            BrowserPath.Text = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
        }

        private void OpenFolderDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            FolderPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            BrowserPath.Text = folderBrowserDialog1.SelectedPath;
        }

        public void DRichPresence(int count)
        {
            DiscordRichPresence.client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = "Settings",
                State = $"Changing settings",
                Assets = new Assets()
                {
                    LargeImageKey = "ico",
                    SmallImageKey = "gear-white",
                }
            });
        }

        private void DiscordRichPresenceButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DiscordRichPresenceButton.Checked)
            {
                if (!DiscordRichPresence.client.IsInitialized)
                {
                    DiscordRichPresence.client.Initialize();
                    DRichPresence(0);
                }
            }
            else
            {
                DiscordRichPresence.client.ClearPresence();
            }
        }
    }
}
