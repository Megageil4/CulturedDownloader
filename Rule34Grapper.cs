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

        public static List<string> GetChildPages(string parentUrl, string xPath, string childSubstring,HtmlAgilityPack.HtmlWeb webloader)
        {
            HtmlAgilityPack.HtmlDocument parentpage = webloader.Load(parentUrl);
            List<string> childUrls = new List<string>();

            foreach (var imagePreview in parentpage.DocumentNode.SelectNodes(xPath))
            {
                string imageSource = imagePreview.InnerHtml;
                imageSource = childSubstring + getBetween(imageSource,"id=\"","\"").Substring(1);
                childUrls.Add(imageSource);
            }

            return childUrls;
        }

        public static List<string> GetImages(List<string> childUrls,string imageXpath, string videoXpath, HtmlAgilityPack.HtmlWeb webloader)
        {
            List<string> images = new List<string>();

            for (int i = 0; i < childUrls.Count; i++)
            {
                HtmlAgilityPack.HtmlDocument website = webloader.Load(childUrls[i]);
                string imageUrl = "";
                try
                {
                    imageUrl = website.DocumentNode.SelectNodes(imageXpath)[0].OuterHtml;
                }
                catch
                {
                    imageUrl = website.DocumentNode.SelectSingleNode(videoXpath).OuterHtml;
                }
                imageUrl = getBetween(imageUrl, "src=\"", "\"");
                images.Add(imageUrl);

            }

            return images;
        }

        public static void OpenImagesInBrowser(List<string> images, bool incognito)
        {
            for (int i = 0; i < images.Count; i++)
            {
                using (var process = new Process())
                {
                    process.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
                    if (incognito)
                    {
                        process.StartInfo.Arguments = images[i] + " --incognito";
                    }
                    process.Start();
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
    }
}
