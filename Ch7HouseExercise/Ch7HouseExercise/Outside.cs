using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7HouseExercise
{
    class Outside : Location
    {
        public Outside(string name, bool hot)
            : base(name)
        {
            this._hot = hot;
        }

        private bool _hot;
        public bool Hot { get { return _hot; } }

        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (_hot)
                    NewDescription += " It's very hot.";
                return NewDescription;
            }
        }


    }
}
