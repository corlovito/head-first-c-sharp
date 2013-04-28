using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTesting
{
    class Snake
    {
        List<SnakeSegment> segments;

        public Utility.Movements UserGivenDirection { set; private get; }

        public Snake()
        {
            UserGivenDirection = Utility.Movements.right;
            segments = new List<SnakeSegment>();
            segments.Add(new SnakeSegment(0, 2, true)); // snake head
            segments.Add(new SnakeSegment(0, 1));
            segments.Add(new SnakeSegment(0, 0));
        }
        
        public void Slither(Utility.Movements direction = Utility.Movements.same)
        {
            int snakeLength = segments.Count;
            for (int i = snakeLength - 1; i >= 0; i--) // start at tail
            {
                if (segments[i].IsHead)
                {
                    //seg.AnnounceLocation();
                    if (direction == Utility.Movements.same)
                        direction = this.UserGivenDirection; // use previous direction

                    this.UserGivenDirection = direction; // store new direction

                    // do move

                }
                else // not head
                { // move to same spot as leading segment 
                    segments[i].X = segments[i - 1].X;
                    segments[i].Y = segments[i - 1].Y;
                }
                    


            }
        }

        public void AddSegment()
        {
            int numSegments = segments.Count;
            int leaderX = segments[numSegments - 1].X;
            int leaderY = segments[numSegments - 1].Y;

            // add segment to list
            // give it same location as butt
            segments.Add(new SnakeSegment(leaderX, leaderY));
            // don't move it on next slither
            // TODO
            System.Windows.Forms.MessageBox.Show(segments.Count.ToString());
        }

        
    }
}
