﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page289
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        private int numberOfScaryThings;

        
        public string ScaryThingIHave { get { return "I have " + numberOfScaryThings + " spiders"; } }

        public void ScareLittleChildren()
        {
            System.Windows.Forms.MessageBox.Show("Boo! Gotcha!");
        }

    }
}
