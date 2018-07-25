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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.BackBox = new System.Windows.Forms.PictureBox();
            this.SoundBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextBox = new System.Windows.Forms.PictureBox();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.AlbumName = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            this.PlayListPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.waveformPainter2 = new NAudio.Gui.WaveformPainter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BandBar7 = new System.Windows.Forms.TrackBar();
            this.BandBar8 = new System.Windows.Forms.TrackBar();
            this.BandBar5 = new System.Windows.Forms.TrackBar();
            this.BandBar4 = new System.Windows.Forms.TrackBar();
            this.BandBar6 = new System.Windows.Forms.TrackBar();
            this.BandBar3 = new System.Windows.Forms.TrackBar();
            this.BandBar2 = new System.Windows.Forms.TrackBar();
            this.BandBar1 = new System.Windows.Forms.TrackBar();
            this.CoverPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBox)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.PlayListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar1)).BeginInit();
            this.CoverPanel.SuspendLayout();
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
            this.ButtonPanel.Controls.Add(this.trackBar1);
            this.ButtonPanel.Controls.Add(this.BackBox);
            this.ButtonPanel.Controls.Add(this.SoundBox);
            this.ButtonPanel.Controls.Add(this.pictureBox1);
            this.ButtonPanel.Controls.Add(this.NextBox);
            this.ButtonPanel.Location = new System.Drawing.Point(0, 592);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(573, 162);
            this.ButtonPanel.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;
            this.pictureBox3.Location = new System.Drawing.Point(240, 53);
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
            this.CurrentTimeLbl.Location = new System.Drawing.Point(16, 35);
            this.CurrentTimeLbl.Name = "CurrentTimeLbl";
            this.CurrentTimeLbl.Size = new System.Drawing.Size(52, 25);
            this.CurrentTimeLbl.TabIndex = 8;
            this.CurrentTimeLbl.Text = "00:00";
            // 
            // TotalTimeLbl
            // 
            this.TotalTimeLbl.AutoSize = true;
            this.TotalTimeLbl.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTimeLbl.Location = new System.Drawing.Point(501, 35);
            this.TotalTimeLbl.Name = "TotalTimeLbl";
            this.TotalTimeLbl.Size = new System.Drawing.Size(52, 25);
            this.TotalTimeLbl.TabIndex = 1;
            this.TotalTimeLbl.Text = "00:00";
            // 
            // RepeatBox
            // 
            this.RepeatBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepeatBox.Image = global::MediaPlayer.Properties.Resources.repeat;
            this.RepeatBox.Location = new System.Drawing.Point(13, 76);
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
            this.StopBox.Location = new System.Drawing.Point(83, 82);
            this.StopBox.Name = "StopBox";
            this.StopBox.Size = new System.Drawing.Size(46, 46);
            this.StopBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.StopBox.TabIndex = 6;
            this.StopBox.TabStop = false;
            this.StopBox.Click += new System.EventHandler(this.StopBox_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(0, 8);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(572, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // BackBox
            // 
            this.BackBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBox.Image = global::MediaPlayer.Properties.Resources.Back;
            this.BackBox.Location = new System.Drawing.Point(141, 53);
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
            this.SoundBox.Location = new System.Drawing.Point(443, 82);
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
            this.pictureBox1.Location = new System.Drawing.Point(507, 82);
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
            this.NextBox.Location = new System.Drawing.Point(340, 53);
            this.NextBox.Name = "NextBox";
            this.NextBox.Size = new System.Drawing.Size(97, 98);
            this.NextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NextBox.TabIndex = 2;
            this.NextBox.TabStop = false;
            this.NextBox.Click += new System.EventHandler(this.NextBox_Click);
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
            this.PlayListPanel.Size = new System.Drawing.Size(212, 567);
            this.PlayListPanel.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 524);
            this.listBox1.TabIndex = 1;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
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
            this.trackBar2.Maximum = 40;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 212);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Value = 20;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.addFileToolStripMenuItem,
            this.removeSelectedSongToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mediaToolStripMenuItem.Text = "Media";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addFileToolStripMenuItem.Text = "Add File...";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // removeSelectedSongToolStripMenuItem
            // 
            this.removeSelectedSongToolStripMenuItem.Name = "removeSelectedSongToolStripMenuItem";
            this.removeSelectedSongToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.removeSelectedSongToolStripMenuItem.Text = "Remove Selected File";
            this.removeSelectedSongToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedSongToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playPauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem});
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.playbackToolStripMenuItem.Text = "Playback";
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.playPauseToolStripMenuItem.Text = "Play/Pause";
            this.playPauseToolStripMenuItem.Click += new System.EventHandler(this.playPauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equalizationToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // equalizationToolStripMenuItem
            // 
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.equalizationToolStripMenuItem.Text = "Equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
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
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MediaPlayer.Properties.Resources.Fantaza2;
            this.pictureBox4.Location = new System.Drawing.Point(0, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(572, 572);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // waveformPainter1
            // 
            this.waveformPainter1.BackColor = System.Drawing.Color.White;
            this.waveformPainter1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.waveformPainter1.Location = new System.Drawing.Point(258, 149);
            this.waveformPainter1.Name = "waveformPainter1";
            this.waveformPainter1.Size = new System.Drawing.Size(313, 69);
            this.waveformPainter1.TabIndex = 2;
            this.waveformPainter1.Text = "waveformPainter1";
            // 
            // waveformPainter2
            // 
            this.waveformPainter2.BackColor = System.Drawing.Color.White;
            this.waveformPainter2.ForeColor = System.Drawing.Color.DeepPink;
            this.waveformPainter2.Location = new System.Drawing.Point(222, 315);
            this.waveformPainter2.Name = "waveformPainter2";
            this.waveformPainter2.Size = new System.Drawing.Size(351, 73);
            this.waveformPainter2.TabIndex = 3;
            this.waveformPainter2.Text = "waveformPainter2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.BandBar7);
            this.panel1.Controls.Add(this.BandBar8);
            this.panel1.Controls.Add(this.BandBar5);
            this.panel1.Controls.Add(this.BandBar4);
            this.panel1.Controls.Add(this.BandBar6);
            this.panel1.Controls.Add(this.BandBar3);
            this.panel1.Controls.Add(this.BandBar2);
            this.panel1.Controls.Add(this.BandBar1);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 572);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // BandBar7
            // 
            this.BandBar7.LargeChange = 1;
            this.BandBar7.Location = new System.Drawing.Point(440, 127);
            this.BandBar7.Maximum = 30;
            this.BandBar7.Minimum = -30;
            this.BandBar7.Name = "BandBar7";
            this.BandBar7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BandBar7.Size = new System.Drawing.Size(45, 300);
            this.BandBar7.TabIndex = 23;
            this.BandBar7.Scroll += new System.EventHandler(this.BandBar7_Scroll_1);
            // 
            // BandBar8
            // 
            this.BandBar8.LargeChange = 1;
            this.BandBar8.Location = new System.Drawing.Point(300, 127);
            this.BandBar8.Maximum = 30;
            this.BandBar8.Minimum = -30;
            this.BandBar8.Name = "BandBar8";
            this.BandBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BandBar8.Size = new System.Drawing.Size(45, 300);
            this.BandBar8.TabIndex = 22;
            this.BandBar8.Scroll += new System.EventHandler(this.BandBar8_Scroll_1);
            // 
            // BandBar5
            // 
            this.BandBar5.LargeChange = 1;
            this.BandBar5.Location = new System.Drawing.Point(506, 127);
            this.BandBar5.Maximum = 30;
            this.BandBar5.Minimum = -30;
            this.BandBar5.Name = "BandBar5";
            this.BandBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BandBar5.Size = new System.Drawing.Size(45, 300);
            this.BandBar5.TabIndex = 21;
            this.BandBar5.Scroll += new System.EventHandler(this.BandBar5_Scroll_1);
            // 
            // BandBar4
            // 
            this.BandBar4.LargeChange = 1;
            this.BandBar4.Location = new System.Drawing.Point(367, 127);
            this.BandBar4.Maximum = 30;
            this.BandBar4.Minimum = -30;
            this.BandBar4.Name = "BandBar4";
            this.BandBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BandBar4.Size = new System.Drawing.Size(45, 300);
            this.BandBar4.TabIndex = 20;
            this.BandBar4.Scroll += new System.EventHandler(this.BandBar4_Scroll_1);
            // 
            // BandBar6
            // 
            this.BandBar6.LargeChange = 1;
            this.BandBar6.Location = new System.Drawing.Point(158, 127);
            this.BandBar6.Maximum = 30;
            this.BandBar6.Minimum = -30;
            this.BandBar6.Name = "BandBar6";
            this.BandBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BandBar6.Size = new System.Drawing.Size(45, 300);
            this.BandBar6.TabIndex = 19;
            this.BandBar6.Scroll += new System.EventHandler(this.BandBar6_Scroll_1);
            // 
            // BandBar3
            // 
            this.BandBar3.LargeChange = 1;
            this.BandBar3.Location = new System.Drawing.Point(230, 127);
            this.BandBar3.Maximum = 30;
            this.BandBar3.Minimum = -30;
            this.BandBar3.Name = "BandBar3";
            this.BandBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BandBar3.Size = new System.Drawing.Size(45, 300);
            this.BandBar3.TabIndex = 18;
            this.BandBar3.Scroll += new System.EventHandler(this.BandBar3_Scroll_1);
            // 
            // BandBar2
            // 
            this.BandBar2.LargeChange = 1;
            this.BandBar2.Location = new System.Drawing.Point(92, 127);
            this.BandBar2.Maximum = 30;
            this.BandBar2.Minimum = -30;
            this.BandBar2.Name = "BandBar2";
            this.BandBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BandBar2.Size = new System.Drawing.Size(45, 300);
            this.BandBar2.TabIndex = 17;
            this.BandBar2.Scroll += new System.EventHandler(this.BandBar2_Scroll_1);
            // 
            // BandBar1
            // 
            this.BandBar1.LargeChange = 1;
            this.BandBar1.Location = new System.Drawing.Point(31, 127);
            this.BandBar1.Maximum = 30;
            this.BandBar1.Minimum = -30;
            this.BandBar1.Name = "BandBar1";
            this.BandBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BandBar1.Size = new System.Drawing.Size(45, 300);
            this.BandBar1.TabIndex = 16;
            this.BandBar1.Scroll += new System.EventHandler(this.BandBar1_Scroll);
            // 
            // CoverPanel
            // 
            this.CoverPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.CoverPanel.Controls.Add(this.panel1);
            this.CoverPanel.Controls.Add(this.waveformPainter2);
            this.CoverPanel.Controls.Add(this.waveformPainter1);
            this.CoverPanel.Controls.Add(this.pictureBox4);
            this.CoverPanel.Controls.Add(this.menuStrip1);
            this.CoverPanel.Location = new System.Drawing.Point(0, 0);
            this.CoverPanel.Name = "CoverPanel";
            this.CoverPanel.Size = new System.Drawing.Size(573, 594);
            this.CoverPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 751);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBox)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.PlayListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBar1)).EndInit();
            this.CoverPanel.ResumeLayout(false);
            this.CoverPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPanel;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label TotalTimeLbl;
        private System.Windows.Forms.Label CurrentTimeLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private NAudio.Gui.WaveformPainter waveformPainter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar BandBar7;
        private System.Windows.Forms.TrackBar BandBar8;
        private System.Windows.Forms.TrackBar BandBar5;
        private System.Windows.Forms.TrackBar BandBar4;
        private System.Windows.Forms.TrackBar BandBar6;
        private System.Windows.Forms.TrackBar BandBar3;
        private System.Windows.Forms.TrackBar BandBar2;
        private System.Windows.Forms.TrackBar BandBar1;
        private System.Windows.Forms.Panel CoverPanel;
    }
}

