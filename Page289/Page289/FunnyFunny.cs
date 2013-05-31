using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page289
{
    internal class FunnyFunny : IClown   
    {
        public FunnyFunny(string FunnyThingIHave)
        {
            this._funnyThingIHave = FunnyThingIHave;
        }

        private string _funnyThingIHave;
        public string FunnyThingIHave { get { return _funnyThingIHave; } }

        public void Honk()
        {
            System.Windows.Forms.MessageBox.Show("Honk Honk! I have " + FunnyThingIHave);
        }

    }
}
