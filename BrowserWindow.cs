﻿using System;
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
    public partial class BrowserWindow : Form
    {
        public TagSelection InludeSlectscreen = new TagSelection();
        public TagSelection ExcludeSlectscreen = new TagSelection();
        public BrowserWindow()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MainWindow.DockChild(InludeSlectscreen, MainWindow.ActiveForm);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MainWindow.DockChild(ExcludeSlectscreen, MainWindow.ActiveForm);
        }

        private void OpenInBrowser_Click(object sender, EventArgs e)
        {
            string tags = IncludedTags.Text.Replace(" ", "_").Replace(":", "%3a").Replace("(", "%28").Replace(")", "%29").Replace("!", "%21").Replace("?", "%3f"); ;
            if (ExcludedTags.Text != "")
            {
                tags = tags +  "+-" + ExcludedTags.Text.Replace(" ", "_").Replace("+", "+-").Replace(":", "%3a").Replace("(", "%28").Replace(")", "%29").Replace("!", "%21").Replace("?", "%3f");
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

            HtmlAgilityPack.HtmlWeb webloader = new HtmlAgilityPack.HtmlWeb();
            for (int i = (int)ImageStartIndex.Value + 1; i < (int)ImageEndIndex.Value + 1; i += 42)
            {
                List<String> childSites = Rule34Grapper.GetChildPages(url + "&pid=" + i / 42 * 42,
                                                                  @"//span[@class='thumb']", "https://rule34.xxx/index.php?page=post&s=view&id=",
                                                                  webloader);

                List<String> ImageUrls = Rule34Grapper.GetImages(childSites, "//img[@id='image']", "//source[@type='video/mp4']", webloader);

                // if (i - 1 + 42 > ImageEndIndex.Value && i - 1 + 42 != (int)ImageEndIndex.Value)
                // {
                //     ImageUrls.RemoveRange(42 - (i - 1 + ImageUrls.Count - (int)ImageEndIndex.Value - 1),ImageUrls.Count - (int)ImageEndIndex.Value - i - 1);
                // }

                //if

                //Rule34Grapper.OpenImagesInBrowser(ImageUrls, true);
            }
            
            static void Test()
            {
                

            }
        }
    }
}