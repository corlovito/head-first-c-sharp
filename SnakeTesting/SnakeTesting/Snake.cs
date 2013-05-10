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
            segments.Add(new SnakeSegment(0, 2, true, false)); // snake head
            segments.Add(new SnakeSegment(0, 1, false, false));
            segments.Add(new SnakeSegment(0, 0, false, false));
        }
        
        public void Slither(Utility.Movements direction = Utility.Movements.same)
        {
            int snakeLength = segments.Count;
            for (int i = snakeLength - 1; i >= 0; i--) // Move each segment starting at END OF TAIL
            {
                if (!segments[i].IsNew) // move it if not new
                {
                    segments[i].AnnounceLocation();
                    if (segments[i].IsHead)
                    {
                        if (direction == Utility.Movements.same)
                            direction = this.UserGivenDirection; // use previous direction

                        this.UserGivenDirection = direction; // store new direction

                        // TODO: Do move
                        switch (direction)
                        {
                            case Utility.Movements.up:
                                // TODO: boundary check
                                segments[i].X = segments[i].X;
                                segments[i].Y += 1;
                                break;
                            case Utility.Movements.down:
                                // TODO: boundary check
                                segments[i].X = segments[i].X;
                                segments[i].Y -= 1;
                                break;
                            case Utility.Movements.left:
                                // TODO: boundary check
                                segments[i].X -= 1;
                                segments[i].Y = segments[i].Y;
                                break;
                            case Utility.Movements.right:
                                // TODO: boundary check
                                segments[i].X += 1;
                                segments[i].Y = segments[i].Y;
                                break;
                            default:
                                break;
                        }
                    }
                    else // not head
                    { // move to same spot as leading segment 
                        segments[i].X = segments[i - 1].X;
                        segments[i].Y = segments[i - 1].Y;
                    }

                }
                else
                {
                    segments[i].IsNew = false;
                }

            }
        }

        public void GrowSegment()
        {
            int numSegments = segments.Count;
            int leaderX = segments[numSegments - 1].X;
            int leaderY = segments[numSegments - 1].Y;

            // add segment to list
            // give it same location as butt
            segments.Add(new SnakeSegment(leaderX, leaderY));
            // don't move it on next slither (implemented in slither method)
            System.Windows.Forms.MessageBox.Show(segments.Count.ToString());
        }

        
    }
}
