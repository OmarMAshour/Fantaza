using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MediaPlayer
{
    public partial class Intro : Form
    {
        private Timer timer;
        Form1 Fantaza = new Form1();


        public Intro()
        {
            InitializeComponent();
            //     Thread.Sleep(5);
            timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += Timer_Tick;
            timer.Start();


            this.Visible = false;
            Fantaza.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
            Fantaza.Visible = true;

            timer.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
