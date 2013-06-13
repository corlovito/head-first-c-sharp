using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7HideAndSeek
{
    abstract class Location
    {
        public Location(string name)
        {
            this._name = name;
        }

        private string _name;
        public string Name { get { return _name; } }

        public Location[] Exits;

        public virtual string Description
        {
            get 
            {
                String description = "You're standing in the " + _name + ".\r\n\r\nYou see exits to the following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".\r\n\r\n";
                return description;
            }
        }

    }
}
