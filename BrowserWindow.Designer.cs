
namespace CulturedDownloaderV3
{
    partial class BrowserWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.IncludedTags = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpenInBrowser = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.ExcludedTags = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.AntiGay = new System.Windows.Forms.CheckBox();
            this.AnitFurry = new System.Windows.Forms.CheckBox();
            this.ImageStartIndex = new System.Windows.Forms.NumericUpDown();
            this.ImageEndIndex = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageStartIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageEndIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconButton1);
            this.panel5.Controls.Add(this.IncludedTags);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 34);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.panel5.Size = new System.Drawing.Size(884, 66);
            this.panel5.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 60;
            this.iconButton1.Location = new System.Drawing.Point(801, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 60);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // IncludedTags
            // 
            this.IncludedTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.IncludedTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncludedTags.Dock = System.Windows.Forms.DockStyle.Left;
            this.IncludedTags.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncludedTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IncludedTags.Location = new System.Drawing.Point(20, 3);
            this.IncludedTags.Multiline = true;
            this.IncludedTags.Name = "IncludedTags";
            this.IncludedTags.Size = new System.Drawing.Size(781, 60);
            this.IncludedTags.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(884, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Include Tags";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OpenInBrowser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(90, 20, 90, 20);
            this.panel2.Size = new System.Drawing.Size(884, 100);
            this.panel2.TabIndex = 1;
            // 
            // OpenInBrowser
            // 
            this.OpenInBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.OpenInBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenInBrowser.FlatAppearance.BorderSize = 0;
            this.OpenInBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenInBrowser.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenInBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OpenInBrowser.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.OpenInBrowser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OpenInBrowser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OpenInBrowser.IconSize = 60;
            this.OpenInBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenInBrowser.Location = new System.Drawing.Point(90, 20);
            this.OpenInBrowser.Name = "OpenInBrowser";
            this.OpenInBrowser.Padding = new System.Windows.Forms.Padding(260, 0, 260, 0);
            this.OpenInBrowser.Size = new System.Drawing.Size(704, 60);
            this.OpenInBrowser.TabIndex = 0;
            this.OpenInBrowser.Text = "Open";
            this.OpenInBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenInBrowser.UseVisualStyleBackColor = false;
            this.OpenInBrowser.Click += new System.EventHandler(this.OpenInBrowser_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 112);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label2.Size = new System.Drawing.Size(884, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exclude Tags";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.iconButton2);
            this.panel6.Controls.Add(this.ExcludedTags);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 38);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.panel6.Size = new System.Drawing.Size(884, 74);
            this.panel6.TabIndex = 4;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 60;
            this.iconButton2.Location = new System.Drawing.Point(801, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 68);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ExcludedTags
            // 
            this.ExcludedTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.ExcludedTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExcludedTags.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExcludedTags.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcludedTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ExcludedTags.Location = new System.Drawing.Point(20, 3);
            this.ExcludedTags.Multiline = true;
            this.ExcludedTags.Name = "ExcludedTags";
            this.ExcludedTags.Size = new System.Drawing.Size(781, 68);
            this.ExcludedTags.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ImageEndIndex);
            this.panel4.Controls.Add(this.ImageStartIndex);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel4.Location = new System.Drawing.Point(0, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 138);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(259, 59);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 7, 0, 10);
            this.label4.Size = new System.Drawing.Size(625, 76);
            this.label4.TabIndex = 7;
            this.label4.Text = "Image end index:";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(259, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 15, 0, 0);
            this.label3.Size = new System.Drawing.Size(625, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "Image start index:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.AntiGay);
            this.panel7.Controls.Add(this.AnitFurry);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(20, 15, 15, 30);
            this.panel7.Size = new System.Drawing.Size(259, 138);
            this.panel7.TabIndex = 2;
            // 
            // AntiGay
            // 
            this.AntiGay.AutoSize = true;
            this.AntiGay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AntiGay.Checked = true;
            this.AntiGay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AntiGay.Dock = System.Windows.Forms.DockStyle.Top;
            this.AntiGay.FlatAppearance.BorderSize = 0;
            this.AntiGay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AntiGay.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AntiGay.Location = new System.Drawing.Point(20, 59);
            this.AntiGay.Name = "AntiGay";
            this.AntiGay.Size = new System.Drawing.Size(224, 50);
            this.AntiGay.TabIndex = 1;
            this.AntiGay.Text = "Anti-Gay";
            this.AntiGay.UseVisualStyleBackColor = false;
            // 
            // AnitFurry
            // 
            this.AnitFurry.Checked = true;
            this.AnitFurry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnitFurry.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnitFurry.FlatAppearance.BorderSize = 0;
            this.AnitFurry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnitFurry.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnitFurry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.AnitFurry.Location = new System.Drawing.Point(20, 15);
            this.AnitFurry.Name = "AnitFurry";
            this.AnitFurry.Size = new System.Drawing.Size(224, 44);
            this.AnitFurry.TabIndex = 0;
            this.AnitFurry.Text = "Anit-Furry";
            this.AnitFurry.UseVisualStyleBackColor = true;
            // 
            // ImageStartIndex
            // 
            this.ImageStartIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.ImageStartIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImageStartIndex.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageStartIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ImageStartIndex.Location = new System.Drawing.Point(591, 22);
            this.ImageStartIndex.Name = "ImageStartIndex";
            this.ImageStartIndex.Size = new System.Drawing.Size(120, 34);
            this.ImageStartIndex.TabIndex = 8;
            // 
            // ImageEndIndex
            // 
            this.ImageEndIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.ImageEndIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImageEndIndex.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageEndIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ImageEndIndex.Location = new System.Drawing.Point(591, 74);
            this.ImageEndIndex.Name = "ImageEndIndex";
            this.ImageEndIndex.Size = new System.Drawing.Size(120, 34);
            this.ImageEndIndex.TabIndex = 9;
            // 
            // BrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrowserWindow";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageStartIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageEndIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox IncludedTags;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox ExcludedTags;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox AnitFurry;
        private System.Windows.Forms.CheckBox AntiGay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton OpenInBrowser;
        private System.Windows.Forms.NumericUpDown ImageEndIndex;
        private System.Windows.Forms.NumericUpDown ImageStartIndex;
    }
}