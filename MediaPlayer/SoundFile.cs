using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class SoundFile
    {
        private string name;
        private string path;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Path
        {
            set { path = value; }
            get { return path; }
        }


    }
}
