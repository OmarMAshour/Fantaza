using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Controls;
using WMPLib;
using IEXTagLib;
using NAudio;
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

                TagLib.File tagFile = TagLib.File.Create(currentFilePath);
                Artist.Text = tagFile.Tag.FirstAlbumArtist;
                AlbumName.Text = tagFile.Tag.Album;
                SongName.Text = tagFile.Tag.Title;

                TotalTimeLbl.Text = String.Format("{0:00}:{1:00}", (int)afr.TotalTime.TotalMinutes, (int)afr.TotalTime.Seconds);
                CurrentTimeLbl.Text = String.Format("{0:00}:{1:00}", (int)afr.CurrentTime.TotalMinutes, (int)afr.CurrentTime.Seconds);

                trackBar1.Minimum = 0;
                trackBar1.Maximum = (int)afr.TotalTime.TotalSeconds + 1;
                trackBar1.Value = (int)afr.CurrentTime.TotalSeconds;
            }

            //generate Shuffle
            if (iwp.PlaybackState == PlaybackState.Stopped && Shuffle == true && Repeat == false)
            {
                // listBox1.SelectedIndex = Rand.Next(listBox1.Items.Count);

                int i = Rand.Next(listBox1.Items.Count);
                while (i == listBox1.SelectedIndex)
                {
                    i = Rand.Next(listBox1.Items.Count);
                }
                listBox1.SelectedIndex = i;
                iwp.Stop();
                string NewSoundName = listBox1.GetItemText(listBox1.SelectedItem);
                foreach (SoundFile S in Sound)
                {
                    if (S != null && NewSoundName == S.Name)
                    {
                        iwp = new WaveOutEvent();

                        currentFilePath = S.Path;
                        sampleProvider = CreateInputStream(S.Path);

                        songEqualizer = new Equal(sampleProvider, songEqualizerHandler.Bands);
                        songEqualizerHandler.SongEqualizer = songEqualizer;

                        iwp.Init(songEqualizer);
                        iwp.Play();

                        break;

                    }
                }
            }

            //generate repeat same sound
            else if (iwp.PlaybackState == PlaybackState.Stopped && Repeat == true)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex;
                iwp.Stop();
                string NewSoundName = listBox1.GetItemText(listBox1.SelectedItem);
                foreach (SoundFile S in Sound)
                {
                    if (S != null && NewSoundName == S.Name)
                    {
                        iwp = new WaveOutEvent();
                        currentFilePath = S.Path;

                        sampleProvider = CreateInputStream(S.Path);
                        songEqualizer = new Equal(sampleProvider, songEqualizerHandler.Bands);
                        songEqualizerHandler.SongEqualizer = songEqualizer;

                        iwp.Init(songEqualizer);
                        iwp.Play();
                        break;
                    }
                }
            }
            else
            {
                //continue normally to the next sound
                if (listBox1.SelectedIndex + 1 < listBox1.Items.Count && iwp.PlaybackState == PlaybackState.Stopped && !Repeat && !Shuffle)
                {

                    listBox1.SelectedIndex++;
                    iwp.Stop();
                    string NewSoundName = listBox1.GetItemText(listBox1.SelectedItem);
                    foreach (SoundFile S in Sound)
                    {
                        if (S != null && NewSoundName == S.Name)
                        {

                            iwp = new WaveOutEvent();
                            currentFilePath = S.Path;
                            sampleProvider = CreateInputStream(S.Path);

                            songEqualizer = new Equal(sampleProvider, songEqualizerHandler.Bands);
                            songEqualizerHandler.SongEqualizer = songEqualizer;

                            iwp.Init(songEqualizer);
                            iwp.Play();
                            break;
                        }
                    }
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
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
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
                playSelected();
            }
        }


        private void StopBox_Click(object sender, EventArgs e)
        {
            afr.CurrentTime = TimeSpan.FromSeconds(1.0);
            iwp.Pause();
            CurrentTimeLbl.Text = "00:00";
            trackBar1.Value = 1;
            this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;

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
            Environment.Exit(0);
        }


        private void NextBox_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex + 1 != listBox1.Items.Count)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
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
            if (iwp.PlaybackState == PlaybackState.Playing)
            {
                iwp.Pause();
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;

            }
            else if (iwp.PlaybackState == PlaybackState.Paused)
            {
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Pause;

                iwp.Play();
            }

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
            if (iwp.PlaybackState == PlaybackState.Playing)
            {
                iwp.Pause();
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;

            }
            else if (iwp.PlaybackState == PlaybackState.Paused)
            {
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Pause;

                iwp.Play();
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iwp.Stop();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex + 1 != listBox1.Items.Count)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
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
            Environment.Exit(0);
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
                    string path = file;
                    Sound[i] = new SoundFile();
                    Sound[i].Path = path;
                    Sound[i].Name = System.IO.Path.GetFileNameWithoutExtension(Sound[i].Path);
                    listBox1.Items.Add(Sound[i].Name);
                    i++;
                }
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                playSelected();
            }
        }

        private void playSelected() {
            iwp.Stop();
            waveformPainter1.Visible = true;
            waveformPainter2.Visible = true;
            waveformPainter1.Controls.Clear();
            waveformPainter2.Controls.Clear();
            string newSoundName = listBox1.GetItemText(listBox1.SelectedItem);
            foreach (SoundFile s in Sound)
            {
                if (s != null && newSoundName == s.Name)
                {
                    iwp = new WaveOutEvent();
                    currentFilePath = s.Path;

                    sampleProvider = CreateInputStream(s.Path);

                    songEqualizer = new Equal(sampleProvider, songEqualizerHandler.Bands);
                    songEqualizerHandler.SongEqualizer = songEqualizer;

                    iwp.Init(songEqualizer);
                    iwp.Play();
                    break;
                }
            }
        }
    }
}


