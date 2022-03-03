using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulturedDownloader
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string include = textBox1.Text.Replace(" ", "_").Replace(":", "%3a").Replace("(", "%28").Replace(")","%29").Replace("!", "%21").Replace("?", "%3f");
            // Formats inculeded tags

            string exclude = textBox3.Text.Replace(" ", "_").Replace(":", "%3a").Replace("(", "%28").Replace(")", "%29").Replace("!", "%21").Replace("?", "%3f");

            if (exclude != "") // If there are any excluded tags
            {
                exclude = "+-" + textBox3.Text.Replace(" ", "_").Replace("+", "+-").Replace(":", "%3a").Replace("(", "%28").Replace(")", "%29").Replace("!", "%21").Replace("?", "%3f");
                // Format
            }

            if (checkBox3.Checked) // Anti Furry Button
            {
                string furry = "+-furry+-fur+-mlp+-feline+-canine+-zoophilia+-lizard+-avian+-rodent+-marine+-dragon+" +
                    "-bovine+-knot+-furry_only+-gay-animal_*+-anthro";      // Exclude all furry realeted tags
                exclude = exclude + furry;
            }

            if (checkBox1.Checked)
            {
                string furry = "+-gay*+-solo_male+-male_only+-yaoi";      // Exclude all gay tags
                exclude = exclude + furry;
            }

            int page = (int)numericUpDown1.Value / 42 * 42; // Current Page = page % 42 (why?)
            decimal nummber = numericUpDown1.Value; // Current image
            decimal maxnummber = numericUpDown2.Value; // Selected image count

            try
            {
                while (nummber <= maxnummber)
                {
                    HtmlAgilityPack.HtmlWeb website = new HtmlAgilityPack.HtmlWeb(); // Create new html objekt
                    HtmlAgilityPack.HtmlDocument mainpage = website.Load("https://rule34.xxx/index.php?page=post&s=list&tags=" + include + exclude + "&pid=" + page); //Loads url with tags

                    foreach (var previewImage in mainpage.DocumentNode.SelectNodes("//span[@class='thumb']")) // for every image on the page
                    {
                        if (nummber <= maxnummber) // Have I done enough images already ?
                        {
                            string imageSource = previewImage.InnerHtml; // Html of the Image
                            var subsiteUrl = "https://rule34.xxx/index.php?page=post&s=view&id=" + getBetween(imageSource, "p", "\""); // Url of the preview image
                            HtmlAgilityPack.HtmlDocument subpage = website.Load(subsiteUrl); // Load preview image

                            foreach (var image in subpage.DocumentNode.SelectNodes("//div[@class='flexi']"))  // for every 'flexi' div
                            {
                                string mainImageUrl = getBetween(image.InnerHtml, "src=\"", "\""); // get the url of image
                                if (mainImageUrl.Contains("wimg") || mainImageUrl.Contains("rule34")) // check if ^^ is an image
                                {
                                     
                                    if (SelectedType.Text == "Open in Browser") // 'Open in Browser' checkbox
                                    {
                                        using (var process = new Process())
                                        {
                                            process.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe"; 
                                            process.StartInfo.Arguments = mainImageUrl + " --incognito";                               // Open in Incognito

                                            process.Start();
                                        }
                                    }
                                    if (SelectedType.Text == "Download") // Download checkbox
                                    {
                                        System.Drawing.Image png = DownloadImageFromUrl(mainImageUrl.Trim());
                                        string rootPath = textBox2.Text;                                           // Download as png
                                        string fileName = System.IO.Path.Combine(rootPath, nummber + ".png");
                                        png.Save(fileName);
                                    }

                                }
                            }
                            nummber++; // Increases tracker for current iamge count
                        }
                    }
                    page += 42; // Increases page
                }
            }
            catch
            {
                MessageBox.Show("Invalid input or bad programming", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error); // Throw error
            }

        }

        private void ITags_Click(object sender, EventArgs e)
        {
            textBox1.Text = TagDialog("+"); // Calls "TagDialog to open new dialog and add selected tags"
        }

        private void ETags_Click(object sender, EventArgs e)
        {
            textBox3.Text = TagDialog("+-"); // Calls "TagDialog to open new dialog and remove selected tags"
        }

        private static string TagDialog(string type)
        {
            string returntags = ""; // Contains selected Tags
            Tags tags = new Tags(); //  
            tags.ShowDialog();      // New Tag Dialog
            foreach (var tag in tags.checkedListBox2.CheckedItems) // For every item in the selected Box (Box on the left)
            {
                returntags += tag.ToString() + type; // adds tags to string
            }
            if (returntags != "")
            {
                returntags = returntags.Substring(0, returntags.Length - type.Length); // remove last "+" from tags
            }

            return returntags;
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
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
        public System.Drawing.Image DownloadImageFromUrl(string imageUrl)
        {
            System.Drawing.Image image = null;

            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                System.Net.WebResponse webResponse = webRequest.GetResponse();

                System.IO.Stream stream = webResponse.GetResponseStream();

                image = System.Drawing.Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.Description = "Select Folder";
            fdb.ShowNewFolderButton = false;

            if (fdb.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fdb.SelectedPath;
            }
        }

        private void SelectedType_TextChanged(object sender, EventArgs e)
        {
            if (SelectedType.Text == "Open in Browser")
            {
                button2.Enabled = false;
                textBox2.Enabled = false;
            }
            if (SelectedType.Text == "Download")
            {
                button2.Enabled = true;
                textBox2.Enabled = true;
            }
        }
    }
}
