namespace MediaPlayer
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
            this.components = new System.ComponentModel.Container();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CurrentTimeLbl = new System.Windows.Forms.Label();
            this.TotalTimeLbl = new System.Windows.Forms.Label();
            this.RepeatBox = new System.Windows.Forms.PictureBox();
            this.StopBox = new System.Windows.Forms.PictureBox();
            this.BackBox = new System.Windows.Forms.PictureBox();
            this.SoundBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextBox = new System.Windows.Forms.PictureBox();
            this.CoverPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToSpecificTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.AlbumName = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            this.PlayListPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBox)).BeginInit();
            this.CoverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.PlayListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.ButtonPanel.Controls.Add(this.pictureBox3);
            this.ButtonPanel.Controls.Add(this.CurrentTimeLbl);
            this.ButtonPanel.Controls.Add(this.TotalTimeLbl);
            this.ButtonPanel.Controls.Add(this.RepeatBox);
            this.ButtonPanel.Controls.Add(this.StopBox);
            this.ButtonPanel.Controls.Add(this.BackBox);
            this.ButtonPanel.Controls.Add(this.SoundBox);
            this.ButtonPanel.Controls.Add(this.pictureBox1);
            this.ButtonPanel.Controls.Add(this.NextBox);
            this.ButtonPanel.Location = new System.Drawing.Point(0, 526);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(573, 162);
            this.ButtonPanel.TabIndex = 0;
            this.ButtonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonPanel_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;
            this.pictureBox3.Location = new System.Drawing.Point(240, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // CurrentTimeLbl
            // 
            this.CurrentTimeLbl.AutoSize = true;
            this.CurrentTimeLbl.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeLbl.Location = new System.Drawing.Point(18, 2);
            this.CurrentTimeLbl.Name = "CurrentTimeLbl";
            this.CurrentTimeLbl.Size = new System.Drawing.Size(52, 25);
            this.CurrentTimeLbl.TabIndex = 8;
            this.CurrentTimeLbl.Text = "00:00";
            this.CurrentTimeLbl.Click += new System.EventHandler(this.CurrentTimeLbl_Click);
            // 
            // TotalTimeLbl
            // 
            this.TotalTimeLbl.AutoSize = true;
            this.TotalTimeLbl.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTimeLbl.Location = new System.Drawing.Point(503, 2);
            this.TotalTimeLbl.Name = "TotalTimeLbl";
            this.TotalTimeLbl.Size = new System.Drawing.Size(52, 25);
            this.TotalTimeLbl.TabIndex = 1;
            this.TotalTimeLbl.Text = "00:00";
            // 
            // RepeatBox
            // 
            this.RepeatBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepeatBox.Image = global::MediaPlayer.Properties.Resources.repeat;
            this.RepeatBox.Location = new System.Drawing.Point(13, 53);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(64, 52);
            this.RepeatBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RepeatBox.TabIndex = 7;
            this.RepeatBox.TabStop = false;
            this.RepeatBox.Click += new System.EventHandler(this.RepeatBox_Click);
            // 
            // StopBox
            // 
            this.StopBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopBox.Image = global::MediaPlayer.Properties.Resources.Stop;
            this.StopBox.Location = new System.Drawing.Point(83, 59);
            this.StopBox.Name = "StopBox";
            this.StopBox.Size = new System.Drawing.Size(46, 46);
            this.StopBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.StopBox.TabIndex = 6;
            this.StopBox.TabStop = false;
            this.StopBox.Click += new System.EventHandler(this.StopBox_Click);
            // 
            // BackBox
            // 
            this.BackBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBox.Image = global::MediaPlayer.Properties.Resources.Back;
            this.BackBox.Location = new System.Drawing.Point(141, 30);
            this.BackBox.Name = "BackBox";
            this.BackBox.Size = new System.Drawing.Size(99, 98);
            this.BackBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackBox.TabIndex = 5;
            this.BackBox.TabStop = false;
            this.BackBox.Click += new System.EventHandler(this.BackBox_Click);
            // 
            // SoundBox
            // 
            this.SoundBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SoundBox.Image = global::MediaPlayer.Properties.Resources.Volume;
            this.SoundBox.Location = new System.Drawing.Point(443, 59);
            this.SoundBox.Name = "SoundBox";
            this.SoundBox.Size = new System.Drawing.Size(61, 40);
            this.SoundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SoundBox.TabIndex = 4;
            this.SoundBox.TabStop = false;
            this.SoundBox.Click += new System.EventHandler(this.SoundBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MediaPlayer.Properties.Resources.Shuffle;
            this.pictureBox1.Location = new System.Drawing.Point(507, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // NextBox
            // 
            this.NextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBox.Image = global::MediaPlayer.Properties.Resources.Next;
            this.NextBox.Location = new System.Drawing.Point(340, 30);
            this.NextBox.Name = "NextBox";
            this.NextBox.Size = new System.Drawing.Size(97, 98);
            this.NextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NextBox.TabIndex = 2;
            this.NextBox.TabStop = false;
            this.NextBox.Click += new System.EventHandler(this.NextBox_Click);
            // 
            // CoverPanel
            // 
            this.CoverPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CoverPanel.Controls.Add(this.pictureBox4);
            this.CoverPanel.Controls.Add(this.menuStrip1);
            this.CoverPanel.Controls.Add(this.trackBar1);
            this.CoverPanel.Location = new System.Drawing.Point(0, 0);
            this.CoverPanel.Name = "CoverPanel";
            this.CoverPanel.Size = new System.Drawing.Size(573, 527);
            this.CoverPanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MediaPlayer.Properties.Resources.Fantaza2;
            this.pictureBox4.Location = new System.Drawing.Point(0, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(572, 464);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.removeSelectedSongToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mediaToolStripMenuItem.Text = "Media";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // removeSelectedSongToolStripMenuItem
            // 
            this.removeSelectedSongToolStripMenuItem.Name = "removeSelectedSongToolStripMenuItem";
            this.removeSelectedSongToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.removeSelectedSongToolStripMenuItem.Text = "Remove Selected File";
            this.removeSelectedSongToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedSongToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Checked = true;
            this.toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 22);
            this.toolStripMenuItem2.Text = "Quit at the end of Playlist";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpToSpecificTimeToolStripMenuItem,
            this.playPauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem});
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.playbackToolStripMenuItem.Text = "Playback";
            // 
            // jumpToSpecificTimeToolStripMenuItem
            // 
            this.jumpToSpecificTimeToolStripMenuItem.Name = "jumpToSpecificTimeToolStripMenuItem";
            this.jumpToSpecificTimeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.jumpToSpecificTimeToolStripMenuItem.Text = "Jump to Specific Time";
            this.jumpToSpecificTimeToolStripMenuItem.Click += new System.EventHandler(this.jumpToSpecificTimeToolStripMenuItem_Click);
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.playPauseToolStripMenuItem.Text = "Play/Pause";
            this.playPauseToolStripMenuItem.Click += new System.EventHandler(this.playPauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(0, 487);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(572, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // DataPanel
            // 
            this.DataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.DataPanel.Controls.Add(this.AlbumName);
            this.DataPanel.Controls.Add(this.SongName);
            this.DataPanel.Controls.Add(this.Artist);
            this.DataPanel.Location = new System.Drawing.Point(572, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataPanel.Size = new System.Drawing.Size(212, 187);
            this.DataPanel.TabIndex = 2;
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSize = true;
            this.AlbumName.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AlbumName.Location = new System.Drawing.Point(0, 119);
            this.AlbumName.MaximumSize = new System.Drawing.Size(212, 27);
            this.AlbumName.MinimumSize = new System.Drawing.Size(212, 27);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(212, 27);
            this.AlbumName.TabIndex = 2;
            this.AlbumName.Text = "Album Name";
            this.AlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AlbumName.Click += new System.EventHandler(this.label1_Click);
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Eras Medium ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SongName.Location = new System.Drawing.Point(0, 79);
            this.SongName.MaximumSize = new System.Drawing.Size(212, 27);
            this.SongName.MinimumSize = new System.Drawing.Size(212, 27);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(212, 27);
            this.SongName.TabIndex = 1;
            this.SongName.Text = "Song Name";
            this.SongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SongName.Click += new System.EventHandler(this.SongName_Click);
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Font = new System.Drawing.Font("Eras Medium ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Artist.Location = new System.Drawing.Point(0, 38);
            this.Artist.MaximumSize = new System.Drawing.Size(212, 27);
            this.Artist.MinimumSize = new System.Drawing.Size(212, 27);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(212, 27);
            this.Artist.TabIndex = 0;
            this.Artist.Text = "Artist";
            this.Artist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayListPanel
            // 
            this.PlayListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.PlayListPanel.Controls.Add(this.listBox1);
            this.PlayListPanel.Controls.Add(this.pictureBox2);
            this.PlayListPanel.Location = new System.Drawing.Point(572, 184);
            this.PlayListPanel.Name = "PlayListPanel";
            this.PlayListPanel.Size = new System.Drawing.Size(212, 504);
            this.PlayListPanel.TabIndex = 3;
            this.PlayListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayListPanel_Paint);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 459);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MediaPlayer.Properties.Resources.Playlist;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.trackBar2.Location = new System.Drawing.Point(452, 374);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 212);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Value = 50;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 689);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.PlayListPanel);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.CoverPanel);
            this.Controls.Add(this.ButtonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(0, 25);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                       FaNtAzA --- Fantaz Nafsk ---";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBox)).EndInit();
            this.CoverPanel.ResumeLayout(false);
            this.CoverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.PlayListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel CoverPanel;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Panel PlayListPanel;
        private System.Windows.Forms.PictureBox NextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SoundBox;
        private System.Windows.Forms.PictureBox BackBox;
        private System.Windows.Forms.PictureBox StopBox;
        private System.Windows.Forms.PictureBox RepeatBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label AlbumName;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToSpecificTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label TotalTimeLbl;
        private System.Windows.Forms.Label CurrentTimeLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedSongToolStripMenuItem;
    }
}

