using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7HideAndSeek
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, string doorDescription, bool hot)
            : base(name, hot)
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
