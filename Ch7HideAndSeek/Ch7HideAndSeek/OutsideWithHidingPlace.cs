using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7HideAndSeek
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace)
            : base(name, hot)
        {
            this._hidingPlace = hidingPlace;
        }

        private string _hidingPlace;
        public string HidingPlace { get { return _hidingPlace; } }

        public override string Description
        {
            get
            {
                return base.Description + "Someone could hide " + _hidingPlace + ".";
            }
        }

    }
}
