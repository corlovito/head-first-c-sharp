using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page289
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IScaryClown fingersTheClown = new ScaryScary("rubber chicken", 3);

            //ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            //FunnyFunny someFunnyClown = fingersTheClown;
            //IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            //someOtherScaryClown.Honk();

            fingersTheClown.Honk();

            fingersTheClown.ScareLittleChildren();

            int k;
            k = int.MaxValue;
            
        }
    }
}
