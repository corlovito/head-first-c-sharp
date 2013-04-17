using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTesting
{
    class Snake
    {
        enum movements { up, down, left, right };
        List<SnakeSegment> segments;

        public Snake()
        {
            movements direction = movements.right;
            segments = new List<SnakeSegment>();
            segments.Add(new SnakeSegment(0, 0, true, 0, 1)); // snake butt
            segments.Add(new SnakeSegment(0, 1, true, 0, 2));
            segments.Add(new SnakeSegment(0, 2, false)); // snake head
        }

        

        
    }
}
