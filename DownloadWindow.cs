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
    public partial class DownloadWindow : Form
    {
        public DownloadWindow()
        {
            InitializeComponent();
            FilePath.Text = MainWindow.settings.FolderPath.Text;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            FilePath.Text = folderBrowserDialog.SelectedPath;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            string tags = IncludedTags.Text.Replace(" ", "_").Replace(":", "%3a").Replace("(", "%28").Replace(")", "%29").Replace("!", "%21").Replace("?", "%3f"); ;
            if (ExcludedTags.Text != "")
            {
                tags = tags + "+-" + ExcludedTags.Text.Replace(" ", "_").Replace("+", "+-").Replace(":", "%3a").Replace("(", "%28").Replace(")", "%29").Replace("!", "%21").Replace("?", "%3f");
            }

            if (AnitFurry.Checked)
            {
                string furry = "+-furry+-fur+-mlp+-feline+-canine+-zoophilia+-lizard+-avian+-rodent+-marine+-dragon+" +
                   "-bovine+-knot+-furry_only+-gay-animal_*+-anthro";
                tags = tags + furry;
            }
            if (AntiGay.Checked)
            {
                string gay = "+-gay*+-solo_male+-male_only+-yaoi";      // Exclude all gay tags
                tags = tags + gay;
            }

            string url = "https://rule34.xxx/index.php?page=post&s=list&tags=" + tags;

            Rule34Grapper rule34Grapper = new Rule34Grapper(); 

            if (MainWindow.settings.SourceSelection.Text == "Rule34.xxx")
            {
                rule34Grapper = new Rule34Grapper(@"//span[@class='thumb']", "//img[@id='image']", "//source[@type='video/mp4']",
                                                            url, "https://rule34.xxx/index.php?page=post&s=view&id=");
            }
            else // !TODO: add xboru xpaths and urls!
            {
                rule34Grapper = new Rule34Grapper(@"//span[@class='thumb']", "//img[@id='image']", "//source[@type='video/mp4']",
                                                            url, "https://rule34.xxx/index.php?page=post&s=view&id=");
            }

            int count = (int)ImageEndIndex.Value - (int)ImageStartIndex.Value;
            int pageId = (int)ImageStartIndex.Value;
            for (int i = 0; i < count / 42 + 1; i++)
            {
                rule34Grapper.PageUrl = rule34Grapper.PageUrl + "&pid=" + pageId;
                string[] images;
                if (count - 42 <= 0)
                {
                    images = rule34Grapper.GetChildPages(count);
                }
                else
                {
                    images = rule34Grapper.GetChildPages(42);
                }

                pageId += 42;
                count -= 42;

                Rule34Grapper.Download(FilePath.Text,images);
            }
        }
    }
}
