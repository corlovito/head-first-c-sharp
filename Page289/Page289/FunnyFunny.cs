using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page289
{
    class FunnyFunny : IClown   
    {
        public FunnyFunny(string FunnyThingIHave)
        {
            this._FunnyThingIHave = FunnyThingIHave;
        }

        private string _FunnyThingIHave;
        public string FunnyThingIHave { get { return _FunnyThingIHave; } }

        public void Honk()
        {
            System.Windows.Forms.MessageBox.Show("Honk Honk! I have a " + FunnyThingIHave);
        }

    }
}
