using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTesting
{
    class Snake
    {
        public enum Movements { up, down, left, right, same };
        private Movements direction;

        List<SnakeSegment> segments;

        public Snake()
        {
            direction = Movements.right;
            segments = new List<SnakeSegment>();
            segments.Add(new SnakeSegment(0, 2, false)); // snake head
            segments.Add(new SnakeSegment(0, 1, true, 0, 2));
            segments.Add(new SnakeSegment(0, 0, true, 0, 1)); // snake butt
        }

        public void Slither(Movements direction = Movements.same)
        {
            foreach (SnakeSegment seg in segments)
            {
                //seg.AnnounceLocation();
                if (direction == Movements.same)
                    direction = this.direction; // use previous direction

                this.direction = direction; // store new direction
                seg.Move(direction);
            }
        }

        public void AddSegment()
        {

        }

        
    }
}
