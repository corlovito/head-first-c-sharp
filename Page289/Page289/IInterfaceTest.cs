using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Just testing my skills

namespace Page289
{
    internal class IInterfaceTest : FunnyFunny, IScaryClown
    {
        public IInterfaceTest(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            base.ToString();
        }

        public string ScaryThingIHave
        {
            get { throw new NotImplementedException(); }
        }

        public void ScareLittleChildren()
        {
            throw new NotImplementedException();
        }

        internal void FireGun()
        {
            throw new NotImplementedException();
        }

    }
}
