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
    public partial class InfoWindow : Form
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        public void DRichPresence(int count)
        {
            DiscordRichPresence.client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = "Info",
                State = $"Viewing info",
                Assets = new Assets()
                {
                    LargeImageKey = "ico",
                    SmallImageKey = "info-white",
                }
            });
        }
    }
}
