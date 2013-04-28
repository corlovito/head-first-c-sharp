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

        public SnakeSegment(int x, int y, bool isHead = false, bool isNew = true)
        {
            this.X = x;
            this.Y = y;
            this.IsHead = isHead;
            this.IsNew = isNew;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public bool IsHead { get; set; }
        public bool IsNew { get; set; }

        public Utility.Movements Direction { get; set; }

        //public void Move(Utility.Movements direction)
        //{
        //    if (leaderExists)
        //    {
        //        x = leaderX;
        //        y = leaderY;
        //        System.Windows.Forms.MessageBox.Show("follower " + x + ", " + y);
        //    }
        //    else // This segment is the head, go where user instructed
        //    {
        //        switch (direction)
        //        {
        //            // TODO: boundary checks
        //            case Utility.Movements.up:
        //                y -= 1;
        //                break;
        //            case Utility.Movements.down:
        //                y += 1;
        //                break;
        //            case Utility.Movements.left:
        //                x -= 1;
        //                break;
        //            case Utility.Movements.right:
        //                x += 1;
        //                break;
        //            case Utility.Movements.same:
        //                break;
        //            default:
        //                break;
        //        }
        //        System.Windows.Forms.MessageBox.Show("leader " + x + ", " + y);
        //    }
        //}

        public void AnnounceLocation()
        {
            System.Windows.Forms.MessageBox.Show("x = " + X + "\ny =" + Y + "\nIsHead: " + IsHead.ToString());
        }

    }
}
