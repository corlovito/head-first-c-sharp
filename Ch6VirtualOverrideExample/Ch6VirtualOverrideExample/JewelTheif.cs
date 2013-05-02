using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6VirtualOverrideExample
{
    class JewelThief : LockSmith
    {
        private Jewels stolenJewels = null;

        override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! " + stolenJewels.Sparkle());
        }
       
    }
}
