using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7HideAndSeek
{
    class Opponent
    {
        public Opponent(Location myLocation)
        {
            this.myLocation = myLocation;
            random = new Random();
        }

        private Location myLocation;
        private Random random;

        public void Move()
        {
            if (myLocation is RoomWithDoor)
            {
                if (random.Next(2) == 1) // go through door?
                {
                    RoomWithDoor nextLocation = myLocation as RoomWithDoor;
                    myLocation = nextLocation.DoorLocation;
                }
            }

            do
            {
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)]; // go through a random exit
            } while (!(myLocation is IHidingPlace)); // repeat if no hiding place
        }

        public bool Check(Location locationToCheck)
        {
            if (myLocation == locationToCheck)
                return true;
            else
                return false;
        }

    }
}
