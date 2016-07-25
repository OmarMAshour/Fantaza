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
using System.Windows.Controls;
using IEXTagLib;
//using System.Threading;
namespace MediaPlayer
{
    public partial class Form1 : Form
    {

        private Boolean Shuffle = false;
        private Boolean Repeat = false;
        private Boolean Vol = false;
        private WindowsMediaPlayer Wm;

        private Timer timer; //i know it starts with capital
       
        private Random Rand;
        private SoundFile[] Sound = new SoundFile[20];
        private int i = 0;
        public Form1()
        {
            
            InitializeComponent();
            Wm = new WindowsMediaPlayer();

            Rand = new Random();
        

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();


        }
    
        private void Timer_Tick(object sender, EventArgs e)
        {
            //set time view
            if (Wm.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                TagLib.File tagFile = TagLib.File.Create(Wm.currentMedia.sourceURL);
                Artist.Text = tagFile.Tag.FirstAlbumArtist;
                AlbumName.Text = tagFile.Tag.Album;
                SongName.Text = tagFile.Tag.Title;

                TotalTimeLbl.Text = Wm.currentMedia.durationString;
                CurrentTimeLbl.Text = Wm.controls.currentPositionString;

                trackBar1.Minimum = 0;
                trackBar1.Maximum = (int)Wm.currentMedia.duration+1;
                trackBar1.Value = (int)Wm.controls.currentPosition;
            }

            //generate Shuffle
            if (Wm.playState == WMPLib.WMPPlayState.wmppsStopped && Shuffle==true && Repeat==false)
            {
                listBox1.SelectedIndex = Rand.Next(listBox1.Items.Count);
                Wm.controls.stop();
                string NewSoundName = listBox1.GetItemText(listBox1.SelectedItem);
                foreach (SoundFile S in Sound)
                {
                    if (S != null && NewSoundName == S.Name)
                    {
                        Wm.URL = @"" + S.Path;
                        Wm.controls.play();
                        break;
                        
                    }
                }
            }

            //generate repeat same sound
            else if (Wm.playState == WMPLib.WMPPlayState.wmppsStopped && Repeat == true && Shuffle==false)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex;
                Wm.controls.stop();
                string NewSoundName = listBox1.GetItemText(listBox1.SelectedItem);
                foreach (SoundFile S in Sound)
                {
                    if (S != null && NewSoundName == S.Name)
                    {
                        Wm.URL = @"" + S.Path;
                        Wm.controls.play();
                        break;
                    }
                }
            }
            else
            {
                //continue normally to the next sound
                if (listBox1.SelectedIndex + 1 < listBox1.Items.Count && Wm.playState == WMPLib.WMPPlayState.wmppsStopped && !Repeat && !Shuffle  )
                {
                    listBox1.SelectedIndex ++;
                    Wm.controls.stop();
                    string NewSoundName = listBox1.GetItemText(listBox1.SelectedItem);
                    foreach (SoundFile S in Sound)
                    {
                        if (S != null && NewSoundName == S.Name)
                        {
                            Wm.URL = @"" + S.Path;
                            Wm.controls.play();
                            break;
                        }
                    }
                }
            }

            //set time label  and track bar  if stop is pressed
            if (Wm.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                CurrentTimeLbl.Text="00:00";
                trackBar1.Value = 0;
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;
            }
            // set pause image while playing
            if (Wm.playState == WMPLib.WMPPlayState.wmppsPlaying)
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Pause;



        }


        
        private void setSoundPath(string path)
        {
            
            Wm.URL=@"" + path;
         
        }

              private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

   
    
        // return to the previous song
        private void BackBox_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // choosing file from the fileDialogue
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
              OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 Files (.mp3)|*.mp3";


           if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                setSoundPath(path);
                Sound[i] = new SoundFile();
                Sound[i].Path = path;
                Sound[i].Name = System.IO.Path.GetFileNameWithoutExtension(Sound[i].Path);
                listBox1.Items.Add(Sound[i].Name);
                i++;

            }
            

    }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

           if(Wm.playState == WMPLib.WMPPlayState.wmppsStopped && listBox1.SelectedIndex == listBox1.Items.Count - 1 && toolStripMenuItem2.Checked==true)
            {
                Environment.Exit(0);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void StopBox_Click(object sender, EventArgs e)
        {
            Wm.controls.stop();
            Wm.close();
            CurrentTimeLbl.Text = "00:00";
            trackBar1.Value = 0;
            this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;

        }

        private void PlayListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Wm.controls.stop();
            string newSoundName = listBox1.GetItemText(listBox1.SelectedItem);
            foreach(SoundFile s in Sound)
            {
                if ( s!=null && newSoundName == s.Name)
                {
                    Wm.URL = @"" + s.Path;
                    Wm.controls.play();
                    break;
                }
            }
         
        }

        private void NextBox_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex +1!=listBox1.Items.Count)            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Wm.controls.currentPosition = (double)trackBar1.Value;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if(Shuffle == true)
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
            if (Wm.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Wm.controls.pause();
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;

            }
            else if (Wm.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Pause;

                Wm.controls.play();
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
             if(Vol == true)
            {
                Vol = false;
                trackBar2.Visible=false;
            }
            else
            {
                Vol = true;
                trackBar2.Visible = true;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Wm.settings.volume = trackBar2.Value;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void CurrentTimeLbl_Click(object sender, EventArgs e)
        {

        }

        private void playPauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Wm.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Wm.controls.pause();
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Play;

            }
            else if (Wm.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                this.pictureBox3.Image = global::MediaPlayer.Properties.Resources.Pause;

                Wm.controls.play();
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wm.controls.stop();
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

        private void jumpToSpecificTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                   FaNtAzA\n\n       Simply a tarweesha style xD\n\n              Developed By:\n\n              Ahmed ElNokrashi\n              Farida Abouish\n              Omar Ashour");
        }

        private void removeSelectedSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wm.controls.stop();
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void SongName_Click(object sender, EventArgs e)
        {
        }
    }
    }
    

