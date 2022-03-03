using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CulturedDownloader
{
    public partial class Tags : Form
    {
        public static string path = Directory.GetCurrentDirectory() + "\\tags.txt";
        string elArray = File.ReadAllText(path);
        public Tags()
        {
            InitializeComponent();
            //checkedListBox1.Items.AddRange(elArray.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 2)
            {
                checkedListBox1.Items.Clear();
                string[] tags = elArray.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                textBox1.Text = textBox1.Text.Replace(" ", "_");
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
                int length = tags.Length;
                for (int i = 0; i < length; i++)
                {
                    if (tags[i].Contains(textBox1.Text))
                    {
                        checkedListBox1.Items.Add(tags[i]);
                    }
                }
            }
        }

        private void checkedListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void checkedListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var tag in checkedListBox1.CheckedItems)
            {
                bool exsists = false;
                foreach (var checkedTag in checkedListBox2.Items)
                {
                    if (tag.ToString() == checkedTag.ToString())
                    {
                        exsists = true;
                    }
                }
                if (!exsists)
                {
                    checkedListBox2.Items.Add(tag.ToString(), true);
                }
            }
        }
    }
}
