using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7HouseExercise
{
    class RoomWithDoor: Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name, decoration)
        {
            this._doorDescription = doorDescription;
        }

        private string _doorDescription;
        public string DoorDescription { get { return _doorDescription; } }

        private Location _doorLocation;
        public Location DoorLocation 
        { 
            get { return _doorLocation; }
            set { _doorLocation = value; }
        }

    }
}
