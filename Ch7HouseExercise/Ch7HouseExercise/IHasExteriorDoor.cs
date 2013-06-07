using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7HouseExercise
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; } // location that door leads to
    }
}
