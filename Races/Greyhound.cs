using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Races
{
    class Greyhound
    {
        public int StartingPosition = 20;
        public int RacetrackLength = 450;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random ran;

        public Greyhound(PictureBox picture, Random r)
        {
            MyPictureBox = picture;
            this.ran = r;
        }

        public bool Run()
        {
            int step = ran.Next(4)+1;
            Point p = MyPictureBox.Location;
            p.X += step;
            MyPictureBox.Location = p;
            if (p.X >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void TakeStartingPosition()
        {
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}
