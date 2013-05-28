using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleTallGuy2Ch7
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            System.Windows.Forms.MessageBox.Show("My name is " + Name + " and I'm " + Height + " inches tall.");
        }

        public void Honk()
        {
            System.Windows.Forms.MessageBox.Show("Honk!");
        }

        private string _funnyThingIHave = "big shoes";
        public string FunnyThingIHave { get { return _funnyThingIHave; } }
    }
}
