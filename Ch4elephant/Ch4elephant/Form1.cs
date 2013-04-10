using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4elephant
{
    public partial class Form1 : Form
    {
        Elephant lucinda, lloyd;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void buttonLloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void buttonLucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            object Temp;
            Temp = lloyd;
            lloyd = lucinda;
            lucinda = (Elephant)Temp;
            MessageBox.Show("Objects Swapped!");
        }

        private void buttonAnother_Click(object sender, EventArgs e)
        {
            lloyd.SpeakTo(lucinda, "What's up?");

            //lloyd = lucinda;
            //lloyd.EarSize = 4321;
            //lloyd.WhoAmI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elephant[] elephants = new Elephant[7];

            elephants[0] = new Elephant { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant { Name = "Lucinda", EarSize = 33 };
            elephants[2] = new Elephant { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant { Name = "Lucille", EarSize = 52 };
            elephants[4] = new Elephant { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant { Name = "Humphrey", EarSize = 45 };
            
            Elephant biggestEars = elephants[0];

            for (int i=1; i < elephants.Length; i++)
            {
                if (elephants[i].EarSize > biggestEars.EarSize)
	            {
                    biggestEars = elephants[i];
	            }
            }

            MessageBox.Show("The biggest ears belong to " + biggestEars.Name);
        }
    }
}
