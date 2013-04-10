using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;


        public bool Run(int bonus = 0) // return true if winner
        {
            int distance = Randomizer.Next(1, 40+bonus);

            Location += distance;

            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;

            if (this.Location >= this.RacetrackLength)
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
            MyPictureBox.Left = this.StartingPosition;
            Location = 0;
        }
    }
}