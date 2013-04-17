using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTesting
{
    // A segment of the snake. The snake is made up of multiple segments. There is a head and butt segment.
    // All segments between the head and butt have a Leader and Follower. The head only has a Follower. The
    // butt only has a Leader.

    class SnakeSegment
    {
        public SnakeSegment(int x, int y, bool leaderExists = false, int leaderX = 0, int leaderY = 0)
        {
            this.x = x;
            this.y = y;
            if (leaderExists)
            {
                this.leaderExists = leaderExists;
                this.leaderX = leaderX;
                this.leaderY = leaderY;
            }
        }

        int x;
        int y;

        bool leaderExists;  // Segment uses Leader location to know where to move next
        int leaderX;
        int leaderY;

        //bool followerExists;    // TODO: Do I even need to know the follower?
        //int followerX;
        //int followerY;

        private void move()
        {
            if (leaderExists)
            {
                x = leaderX;
                y = leaderY;
            }
            else // This segment is the head, go where user instructed
            {

            }
        }
    }
}
