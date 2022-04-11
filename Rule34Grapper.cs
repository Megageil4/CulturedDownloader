using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturedDownloaderV3
{
    class Rule34Grapper
    {
        public string XPath { get; set; }
        public string ImageXpath { get; set; }
        public string VideoXpath { get; set; }
        public string PageUrl { get; set; }
        public string ImagePrefix { get; set; }

        private HtmlAgilityPack.HtmlWeb webloader = new HtmlAgilityPack.HtmlWeb();

        public string[] GetChildPages(int count)
        {
            string[] pages = new string[42];
            HtmlAgilityPack.HtmlDocument parentpage = webloader.Load(PageUrl);

            var imagePreviews = parentpage.DocumentNode.SelectNodes(XPath);


            for (int i = 0; i < count; i++)
            {
                if (i >= imagePreviews.Count)
                    break;

                string imagePost = imagePreviews[i].InnerHtml;
                imagePost = ImagePrefix + getBetween(imagePost, "id=\"", "\"").Substring(1);

                HtmlAgilityPack.HtmlDocument website = webloader.Load(imagePost);

                try
                {
                    pages[i] = website.DocumentNode.SelectNodes(ImageXpath)[0].OuterHtml;
                }
                catch
                {
                    pages[i] = website.DocumentNode.SelectSingleNode(VideoXpath).OuterHtml;
                }

                pages[i] = getBetween(pages[i], "src=\"", "\"");
            }

            return pages;
        }

        //public static List<string> GetImages(List<string> childUrls,string imageXpath, string videoXpath, HtmlAgilityPack.HtmlWeb webloader)
        //{
        //    List<string> images = new List<string>();

        //    for (int i = 0; i < childUrls.Count; i++)
        //    {
        //        HtmlAgilityPack.HtmlDocument website = webloader.Load(childUrls[i]);
        //        string imageUrl = "";
        //        try
        //        {
        //            imageUrl = website.DocumentNode.SelectNodes(imageXpath)[0].OuterHtml;
        //        }
        //        catch
        //        {
        //            imageUrl = website.DocumentNode.SelectSingleNode(videoXpath).OuterHtml;
        //        }
        //        imageUrl = getBetween(imageUrl, "src=\"", "\"");
        //        images.Add(imageUrl);

        //    }

        //    return images;
        //}

        public static void OpenImagesInBrowser(string[] images)
        {
            for (int i = 0; i < images.Length; i++)
            {
                if (images[i] != null)
                {
                    using (var process = new Process())
                    {
                        process.StartInfo.FileName = MainWindow.settings.BrowserPath.Text;
                        if (MainWindow.settings.Incognito.Checked)
                        {
                            process.StartInfo.Arguments = images[i] + " --incognito";
                        }
                        process.Start();
                    }
                }
            }
        }

        private static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

        public Rule34Grapper(string xpath, string imageXpath, string videoXpath, string pageUrl, string imagePrefix)
        {
            XPath = xpath;
            ImageXpath = imageXpath;
            VideoXpath = videoXpath;
            PageUrl = pageUrl;
            ImagePrefix = imagePrefix;
        }
    }
}
