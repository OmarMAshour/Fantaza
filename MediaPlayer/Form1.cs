using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;


namespace MediaPlayer
{
    public partial class Form1 : Form
    {

        Equal songEqualizer;
        EqualizerHandler songEqualizerHandler;

        private Boolean Shuffle = false;
        private Boolean Repeat = false;
        private Boolean Vol = false;


        private AudioFileReader afr;
        private IWavePlayer iwp;
        private ISampleProvider sampleProvider;



        private Timer timer; //i know it starts with capital

        private Random Rand;
        private SoundFile[] Sound = new SoundFile[50];
        private int i = 0;
        private string currentFilePath;
        Boolean stop = false;
        Boolean paused = true;


        public Form1()
        {

            InitializeComponent();

            iwp = new WaveOutEvent();

            Rand = new Random();
            songEqualizerHandler = new EqualizerHandler();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            //set time view
            if (iwp.PlaybackState == PlaybackState.Playing)
            {
                CurrentTimeLbl.Text = String.Format("{0:00}:{1:00}", (int)afr.CurrentTime.TotalMinutes, (int)afr.CurrentTime.Seconds);
                trackBar1.Value = (int)afr.CurrentTime.TotalSeconds;
            }


            if (stop == false)
            {
                //generate Shuffle
                if (iwp.PlaybackState == PlaybackState.Stopped && Shuffle == true && Repeat == false)
                {
                    int i = Rand.Next(listBox1.Items.Count);
                    while (i == listBox1.SelectedIndex)
                    {
                        i = Rand.Next(listBox1.Items.Count);
                    }
                    listBox1.SelectedIndex = i;
                    PlaySelected();
                }
                //generate repeat same sound
                else if (iwp.PlaybackState == PlaybackState.Stopped && Repeat == true)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex;
                    PlaySelected();
                }
                else if (iwp.PlaybackState == PlaybackState.Stopped && !Repeat && !Shuffle && listBox1.Items.Count != 0 && listBox1.SelectedIndex == listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = 0;
                    StopPlaying();
                }

                //continue normally to the next sound
                else if (!stop && listBox1.SelectedIndex + 1 < listBox1.Items.Count && iwp.PlaybackState == PlaybackState.Stopped && !Repeat && !Shuffle)
                {
                    listBox1.SelectedIndex++;
                    PlaySelected();
                }
            }


            //set time label  and track bar  if stop is pressed
            if (iwp.PlaybackState == PlaybackState.Stopped)
            {
                CurrentTimeLbl.Text = "00:00";
                trackBar1.Value = 1;
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;
            }
            // set pause image while playing
            if (iwp.PlaybackState == PlaybackState.Playing)
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Pause;
        }



        // return to the previous song
        private void BackBox_Click(object sender, EventArgs e)
        {
            PreviousSong();
        }

        // choosing file from the fileDialogue
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files|*.mp3;*.wav";
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                iwp.Stop();
                listBox1.Items.Clear();
                foreach (String file in dialog.FileNames)
                {
                    string path = file;
                    Sound[i] = new SoundFile();
                    Sound[i].Path = path;
                    Sound[i].Name = System.IO.Path.GetFileNameWithoutExtension(Sound[i].Path);
                    listBox1.Items.Add(Sound[i].Name);
                    i++;
                }
                listBox1.SelectedIndex = 0;
                PlaySelected();
            }
        }


        private void StopBox_Click(object sender, EventArgs e)
        {
            StopPlaying();
        }

        private ISampleProvider CreateInputStream(string fileName)
        {
            afr = new AudioFileReader(fileName);

            var sampleChannel = new SampleChannel(afr, true);
            sampleChannel.PreVolumeMeter += OnPreVolumeMeter;

            var postVolumeMeter = new MeteringSampleProvider(sampleChannel);


            return postVolumeMeter;
        }
        void OnPreVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            // we know it is stereo
            waveformPainter1.AddMax(e.MaxSampleValues[0]);
            waveformPainter2.AddMax(e.MaxSampleValues[1]);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void NextBox_Click(object sender, EventArgs e)
        {
            NextSong();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (iwp.PlaybackState == PlaybackState.Playing)
            {
                afr.CurrentTime = TimeSpan.FromSeconds((double)trackBar1.Value);
            }
            else trackBar1.Value = 1;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (Shuffle == true)
            {
                Shuffle = false;
                this.pictureBox1.Image = global::MediaPlayer.Properties.Resources.Shuffle;
            }
            else
            {
                Shuffle = true;
                this.pictureBox1.Image = global::MediaPlayer.Properties.Resources.Shuffle_selected;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void RepeatBox_Click(object sender, EventArgs e)
        {
            if (Repeat == true)
            {
                Repeat = false;
                this.RepeatBox.Image = global::MediaPlayer.Properties.Resources.repeat;
            }
            else
            {
                Repeat = true;
                this.RepeatBox.Image = global::MediaPlayer.Properties.Resources.repeat_selected;

            }
        }

        private void SoundBox_Click(object sender, EventArgs e)
        {
            if (Vol == true)
            {
                Vol = false;
                trackBar2.Visible = false;
            }
            else
            {
                Vol = true;
                trackBar2.Visible = true;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            afr.Volume = trackBar2.Value;
        }

        private void playPauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopPlaying();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextSong();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreviousSong();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                   FaNtAzA\n\n       Simply a tarweesha style xD\n\n              Developed By:\n\n              Ahmed ElNokrashi\n              Farida Abouish\n              Omar Ashour");
        }

        private void removeSelectedSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                equalizationToolStripMenuItem.Checked = true;
            }
            else
            {
                panel1.Visible = false;
                equalizationToolStripMenuItem.Checked = false;
            }
        }

        private void BandBar1_Scroll(object sender, EventArgs e)
        {
            songEqualizerHandler.Band1 = (float)BandBar1.Value;
        }

        private void BandBar2_Scroll(object sender, EventArgs e)
        {
            songEqualizerHandler.Band2 = (float)BandBar2.Value;

        }

        private void BandBar6_Scroll(object sender, EventArgs e)
        {
            songEqualizerHandler.Band3 = (float)BandBar6.Value;

        }

        private void BandBar3_Scroll(object sender, EventArgs e)
        {
            songEqualizerHandler.Band4 = (float)BandBar3.Value;

        }

        private void BandBar8_Scroll(object sender, EventArgs e)
        {
            songEqualizerHandler.Band5 = (float)BandBar8.Value;

        }

        private void BandBar4_Scroll(object sender, EventArgs e)
        {
            songEqualizerHandler.Band6 = (float)BandBar4.Value;

        }

        private void BandBar7_Scroll(object sender, EventArgs e)
        {
            songEqualizerHandler.Band7 = (float)BandBar7.Value;

        }

        private void BandBar5_Scroll(object sender, EventArgs e)
        {
            songEqualizerHandler.Band8 = (float)BandBar5.Value;

        }

        private void BandBar2_Scroll_1(object sender, EventArgs e)
        {
            songEqualizerHandler.Band2 = (float)BandBar2.Value;
        }

        private void BandBar6_Scroll_1(object sender, EventArgs e)
        {
            songEqualizerHandler.Band3 = BandBar6.Value;
        }

        private void BandBar3_Scroll_1(object sender, EventArgs e)
        {
            songEqualizerHandler.Band4 = BandBar3.Value;
        }

        private void BandBar8_Scroll_1(object sender, EventArgs e)
        {
            songEqualizerHandler.Band5 = BandBar8.Value;
        }

        private void BandBar4_Scroll_1(object sender, EventArgs e)
        {
            songEqualizerHandler.Band6 = BandBar4.Value;
        }

        private void BandBar7_Scroll_1(object sender, EventArgs e)
        {
            songEqualizerHandler.Band7 = BandBar7.Value;
        }

        private void BandBar5_Scroll_1(object sender, EventArgs e)
        {
            songEqualizerHandler.Band8 = BandBar5.Value;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files|*.mp3;*.wav";
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in dialog.FileNames)
                {
                    addToPlaylist(file);
                }
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                PlaySelected();
            }
        }

        private void PlaySelected()
        {
            iwp.Stop();
            waveformPainter1.Controls.Clear();
            waveformPainter2.Controls.Clear();
            string selectedSoundItem = listBox1.GetItemText(listBox1.SelectedItem);
            foreach (SoundFile s in Sound)
            {
                if (s != null && selectedSoundItem == s.Name)
                {
                    iwp = new WaveOutEvent();
                    currentFilePath = s.Path;

                    sampleProvider = CreateInputStream(s.Path);

                    songEqualizer = new Equal(sampleProvider, songEqualizerHandler.Bands);
                    songEqualizerHandler.SongEqualizer = songEqualizer;

                    iwp.Init(songEqualizer);
                    iwp.Play();
                    LoadSong();
                    break;
                }
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                addToPlaylist(file);
        }

        private void addToPlaylist(String file)
        {
            string path = file;
            Boolean alreadyInPlaylist = false;
            foreach (SoundFile s in Sound)
            {
                if (s != null)
                {
                    if (s.Path == path)
                    {
                        alreadyInPlaylist = true;
                    }
                }

            }
            if (alreadyInPlaylist == false)
            {
                Sound[i] = new SoundFile
                {
                    Path = path
                };
                Sound[i].Name = System.IO.Path.GetFileNameWithoutExtension(Sound[i].Path);
                listBox1.Items.Add(Sound[i].Name);
                i++;
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void LoadSong()
        {
            stop = false;
            TagLib.File tagFile = TagLib.File.Create(currentFilePath);

            // load album/song artist
            Artist.Text = tagFile.Tag.FirstAlbumArtist;
            if (tagFile.Tag.FirstAlbumArtist == null)
            {
                Artist.Text = tagFile.Tag.FirstPerformer;
            }

            // load album & song name
            AlbumName.Text = tagFile.Tag.Album;
            SongName.Text = tagFile.Tag.Title;

            // load album cover/art if found
            if (tagFile.Tag.Pictures.Length >= 1)
            {
                waveformPainter1.Hide();
                waveformPainter2.Hide();

                var bin = (byte[])(tagFile.Tag.Pictures[0].Data.Data);
                pictureBox4.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(573, 573, null, IntPtr.Zero);
            }
            else
            {
                pictureBox4.Image = Properties.Resources.Fantaza2;
                waveformPainter1.Show();
                waveformPainter2.Show();
            }

            // load song duration
            TotalTimeLbl.Text = String.Format("{0:00}:{1:00}", (int)afr.TotalTime.TotalMinutes, (int)afr.TotalTime.Seconds);
            CurrentTimeLbl.Text = String.Format("{0:00}:{1:00}", (int)afr.CurrentTime.TotalMinutes, (int)afr.CurrentTime.Seconds);
            trackBar1.Minimum = 0;
            trackBar1.Maximum = (int)afr.TotalTime.TotalSeconds + 1;
            trackBar1.Value = (int)afr.CurrentTime.TotalSeconds;
        }

        private void StopPlaying()
        {
            paused = false;
            iwp.Stop();
            stop = true;
            afr.CurrentTime = TimeSpan.FromSeconds(0.0);
            this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;
            pictureBox4.Image = Properties.Resources.Fantaza2;
        }

        private void PlayPause() {
            if (iwp.PlaybackState == PlaybackState.Playing)
            {
                iwp.Pause();
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;
                paused = true;
            }
            else
            {
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Pause;

                if (paused)
                {
                    LoadSong();
                    iwp.Play();
                }
                else
                {
                    PlaySelected();
                }

            }
        }

        private void NextSong() {
            if (listBox1.SelectedIndex + 1 != listBox1.Items.Count)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
            else
            {
                listBox1.SelectedIndex = 0;
            }
            PlaySelected();
        }

        private void PreviousSong() {
            if (listBox1.SelectedIndex == 0)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            else
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
            PlaySelected();
        }
    }
}


