﻿namespace MyJukeBox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.GenreTitleTextBox = new System.Windows.Forms.TextBox();
            this.GenreListBox = new System.Windows.Forms.ListBox();
            this.SelectGenreScroll = new System.Windows.Forms.HScrollBar();
            this.NowPlayingTextBox = new System.Windows.Forms.TextBox();
            this.PlayListBox = new System.Windows.Forms.ListBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.BackColor = System.Drawing.Color.Silver;
            this.CopyrightLabel.Location = new System.Drawing.Point(152, 0);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(168, 13);
            this.CopyrightLabel.TabIndex = 0;
            this.CopyrightLabel.Text = "Copyright 2018 Rowan Cattermoul";
            // 
            // GenreTitleTextBox
            // 
            this.GenreTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GenreTitleTextBox.Enabled = false;
            this.GenreTitleTextBox.Location = new System.Drawing.Point(68, 133);
            this.GenreTitleTextBox.Name = "GenreTitleTextBox";
            this.GenreTitleTextBox.Size = new System.Drawing.Size(185, 20);
            this.GenreTitleTextBox.TabIndex = 1;
            // 
            // GenreListBox
            // 
            this.GenreListBox.Enabled = false;
            this.GenreListBox.FormattingEnabled = true;
            this.GenreListBox.Location = new System.Drawing.Point(68, 150);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.Size = new System.Drawing.Size(185, 82);
            this.GenreListBox.TabIndex = 2;
            // 
            // SelectGenreScroll
            // 
            this.SelectGenreScroll.Location = new System.Drawing.Point(70, 232);
            this.SelectGenreScroll.Name = "SelectGenreScroll";
            this.SelectGenreScroll.Size = new System.Drawing.Size(183, 23);
            this.SelectGenreScroll.TabIndex = 3;
            // 
            // NowPlayingTextBox
            // 
            this.NowPlayingTextBox.BackColor = System.Drawing.Color.Lime;
            this.NowPlayingTextBox.Enabled = false;
            this.NowPlayingTextBox.Location = new System.Drawing.Point(68, 258);
            this.NowPlayingTextBox.Name = "NowPlayingTextBox";
            this.NowPlayingTextBox.Size = new System.Drawing.Size(185, 20);
            this.NowPlayingTextBox.TabIndex = 4;
            // 
            // PlayListBox
            // 
            this.PlayListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PlayListBox.Enabled = false;
            this.PlayListBox.FormattingEnabled = true;
            this.PlayListBox.Location = new System.Drawing.Point(70, 284);
            this.PlayListBox.Name = "PlayListBox";
            this.PlayListBox.Size = new System.Drawing.Size(183, 108);
            this.PlayListBox.TabIndex = 5;
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSetup,
            this.MenuAbout});
            this.Menu.Location = new System.Drawing.Point(0, 457);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(320, 24);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "menuStrip1";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // MenuSetup
            // 
            this.MenuSetup.Name = "MenuSetup";
            this.MenuSetup.Size = new System.Drawing.Size(49, 20);
            this.MenuSetup.Text = "Setup";
            this.MenuSetup.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(52, 20);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 481);
            this.Controls.Add(this.PlayListBox);
            this.Controls.Add(this.NowPlayingTextBox);
            this.Controls.Add(this.SelectGenreScroll);
            this.Controls.Add(this.GenreListBox);
            this.Controls.Add(this.GenreTitleTextBox);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.Menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Juke Box";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.TextBox GenreTitleTextBox;
        private System.Windows.Forms.ListBox GenreListBox;
        private System.Windows.Forms.HScrollBar SelectGenreScroll;
        private System.Windows.Forms.TextBox NowPlayingTextBox;
        private System.Windows.Forms.ListBox PlayListBox;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuSetup;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
    }
}

