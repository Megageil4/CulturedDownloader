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
    public partial class MainWindow : Form
    {
        public Color basecolor = Color.FromArgb(45, 45, 48);

        public HomeWindow home = new HomeWindow();
        public BrowserWindow browser = new BrowserWindow();
        public DownloadWindow download = new DownloadWindow();
        public SettingsWindow settings = new SettingsWindow();
        public InfoWindow info = new InfoWindow();

        public MainWindow()
        {
            InitializeComponent();
            ResetBars(this);
            homeBar.Visible = true;
            DockChild(browser, this);
            DockChild(download, this);
            DockChild(settings, this);
            DockChild(info, this);
            DockChild(home,this);
        }

        public static void ResetBars(MainWindow main)
        {
            main.homeBar.Visible = false;
            main.browserBar.Visible = false;
            main.downloadBar.Visible = false;
            main.settingsBar.Visible = false;
            main.infoBar.Visible = false;
        }

        public static void DockChild(Form child, Form parent)
        {
            
            if (!parent.Controls.Contains(child))
            {
                child.TopLevel = true;
                child.Show();
                child.ControlBox = false;
                child.TopLevel = false;
                parent.Controls.Add(child);
                child.Dock = DockStyle.Fill;
                
            }
            child.BringToFront();
            parent.TopMost = true;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ResetBars(this);
            homeBar.Visible = true;
            currentPage.Text = "Home Page";

            DockChild(home, this);
        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            ResetBars(this);
            browserBar.Visible = true;
            currentPage.Text = "Open in Browser";

            DockChild(browser, this);
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            ResetBars(this);
            downloadBar.Visible = true;
            currentPage.Text = "Download";
            
            DockChild(download, this);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ResetBars(this);
            settingsBar.Visible = true;
            currentPage.Text = "Settings";

            DockChild(settings, this);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            ResetBars(this);
            infoBar.Visible = true;
            currentPage.Text = "Info";

            DockChild(info, this);
        }
    }
}
