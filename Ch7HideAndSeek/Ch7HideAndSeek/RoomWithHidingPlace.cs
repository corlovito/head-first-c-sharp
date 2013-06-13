using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7HideAndSeek
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace)
            : base(name, decoration)
        {
            this._hidingPlace = hidingPlace;
        }

        private string _hidingPlace;
        public string HidingPlace { get { return _hidingPlace; } }

        public override string Description
        {
            get
            {
                return base.Description + "Someone could hide " + HidingPlace + ".";
            }
        }

    }
}
