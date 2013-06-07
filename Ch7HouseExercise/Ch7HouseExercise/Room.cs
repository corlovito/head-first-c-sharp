using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7HouseExercise
{
    class Room : Location
    {
        public Room(string name, string decoration)
            : base(name)
        {
            this._decoration = decoration;
        }

        private string _decoration;
        public string Decoration { get { return _decoration; } }

        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (_decoration != "")
                    NewDescription += "You see " + _decoration + " here.";
                return base.Description;
            }
        }

    }
}
