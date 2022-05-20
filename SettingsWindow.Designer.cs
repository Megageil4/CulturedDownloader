
namespace CulturedDownloaderV3
{
    partial class SettingsWindow
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SourceSelection = new System.Windows.Forms.ComboBox();
            this.Source = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.OpenFolderDialog = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BrowserPath = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Incognito = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DiscordRichPresence = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Source);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(11, 239);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.panel2.Size = new System.Drawing.Size(892, 85);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SourceSelection);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(228, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.panel3.Size = new System.Drawing.Size(467, 78);
            this.panel3.TabIndex = 3;
            // 
            // SourceSelection
            // 
            this.SourceSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.SourceSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SourceSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SourceSelection.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SourceSelection.FormattingEnabled = true;
            this.SourceSelection.Items.AddRange(new object[] {
            "Rule34.xxx",
            "Xbooru.com"});
            this.SourceSelection.Location = new System.Drawing.Point(0, 0);
            this.SourceSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourceSelection.Name = "SourceSelection";
            this.SourceSelection.Size = new System.Drawing.Size(387, 53);
            this.SourceSelection.TabIndex = 2;
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Dock = System.Windows.Forms.DockStyle.Left;
            this.Source.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Source.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Source.Location = new System.Drawing.Point(0, 7);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(228, 46);
            this.Source.TabIndex = 3;
            this.Source.Text = "Image source:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FolderPath);
            this.panel1.Controls.Add(this.OpenFolderDialog);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 113);
            this.panel1.TabIndex = 2;
            // 
            // FolderPath
            // 
            this.FolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.FolderPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FolderPath.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FolderPath.Location = new System.Drawing.Point(207, 28);
            this.FolderPath.Margin = new System.Windows.Forms.Padding(34, 40, 34, 40);
            this.FolderPath.Multiline = true;
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(587, 76);
            this.FolderPath.TabIndex = 5;
            // 
            // OpenFolderDialog
            // 
            this.OpenFolderDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpenFolderDialog.FlatAppearance.BorderSize = 0;
            this.OpenFolderDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolderDialog.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.OpenFolderDialog.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OpenFolderDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OpenFolderDialog.IconSize = 60;
            this.OpenFolderDialog.Location = new System.Drawing.Point(806, 0);
            this.OpenFolderDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenFolderDialog.Name = "OpenFolderDialog";
            this.OpenFolderDialog.Padding = new System.Windows.Forms.Padding(11, 11, 0, 0);
            this.OpenFolderDialog.Size = new System.Drawing.Size(86, 113);
            this.OpenFolderDialog.TabIndex = 6;
            this.OpenFolderDialog.UseVisualStyleBackColor = true;
            this.OpenFolderDialog.Click += new System.EventHandler(this.OpenFolderDialog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.label1.Size = new System.Drawing.Size(213, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "Default path:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BrowserPath);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(11, 126);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(892, 113);
            this.panel4.TabIndex = 3;
            // 
            // BrowserPath
            // 
            this.BrowserPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.BrowserPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrowserPath.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrowserPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BrowserPath.Location = new System.Drawing.Point(207, 20);
            this.BrowserPath.Margin = new System.Windows.Forms.Padding(34, 40, 34, 40);
            this.BrowserPath.Multiline = true;
            this.BrowserPath.Name = "BrowserPath";
            this.BrowserPath.Size = new System.Drawing.Size(587, 76);
            this.BrowserPath.TabIndex = 5;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 60;
            this.iconButton1.Location = new System.Drawing.Point(806, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(11, 11, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(86, 113);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.label2.Size = new System.Drawing.Size(224, 77);
            this.label2.TabIndex = 4;
            this.label2.Text = "Browser path:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Incognito);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(11, 324);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(892, 100);
            this.panel5.TabIndex = 4;
            // 
            // Incognito
            // 
            this.Incognito.Checked = true;
            this.Incognito.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Incognito.Dock = System.Windows.Forms.DockStyle.Left;
            this.Incognito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Incognito.FlatAppearance.BorderSize = 0;
            this.Incognito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Incognito.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Incognito.Location = new System.Drawing.Point(170, 0);
            this.Incognito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Incognito.Name = "Incognito";
            this.Incognito.Padding = new System.Windows.Forms.Padding(3, 0, 0, 40);
            this.Incognito.Size = new System.Drawing.Size(39, 100);
            this.Incognito.TabIndex = 5;
            this.Incognito.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incognito:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.panel6.Size = new System.Drawing.Size(914, 600);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DiscordRichPresence);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(11, 424);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(892, 100);
            this.panel7.TabIndex = 5;
            // 
            // DiscordRichPresence
            // 
            this.DiscordRichPresence.Dock = System.Windows.Forms.DockStyle.Left;
            this.DiscordRichPresence.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DiscordRichPresence.FlatAppearance.BorderSize = 0;
            this.DiscordRichPresence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscordRichPresence.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiscordRichPresence.Location = new System.Drawing.Point(356, 0);
            this.DiscordRichPresence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiscordRichPresence.Name = "DiscordRichPresence";
            this.DiscordRichPresence.Padding = new System.Windows.Forms.Padding(3, 0, 0, 40);
            this.DiscordRichPresence.Size = new System.Drawing.Size(39, 100);
            this.DiscordRichPresence.TabIndex = 5;
            this.DiscordRichPresence.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discord Rich Presence:";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Source;
        public System.Windows.Forms.ComboBox SourceSelection;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton OpenFolderDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox BrowserPath;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox Incognito;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.CheckBox DiscordRichPresence;
        private System.Windows.Forms.Label label4;
    }
}