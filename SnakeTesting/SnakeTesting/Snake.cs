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
            segments.Add(new SnakeSegment(0, 2, false)); // snake head
            segments.Add(new SnakeSegment(0, 1, true, 0, 2));
            segments.Add(new SnakeSegment(0, 0, true, 0, 1)); // snake butt
        }

        public void Slither(Utility.Movements direction = Utility.Movements.same)
        {
            foreach (SnakeSegment seg in segments)
            {
                //seg.AnnounceLocation();
                if (direction == Utility.Movements.same)
                    direction = this.UserGivenDirection; // use previous direction

                this.UserGivenDirection = direction; // store new direction
                seg.Move(direction);
            }
        }

        public void AddSegment()
        {
            int numSegments = segments.Count;
            int leaderX = segments[numSegments - 1].x;
            int leaderY = segments[numSegments - 1].y;

            // add segment to list
            // give it same location as butt
            segments.Add(new SnakeSegment(leaderX, leaderY, true, leaderX, leaderY));
            // don't move it on next slither
            // TODO
            System.Windows.Forms.MessageBox.Show(segments.Count.ToString());
        }

        
    }
}
