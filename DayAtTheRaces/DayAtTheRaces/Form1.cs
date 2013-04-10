using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];

        int finishLineWidth = 75;

        
        public Form1()
        {
            InitializeComponent();

            dogs[0] = new Greyhound() { MyPictureBox = this.pictureBoxDog0, RacetrackLength = pictureBoxTrack.Width - finishLineWidth - this.pictureBoxDog0.Width, StartingPosition = 25 };
            dogs[1] = new Greyhound() { MyPictureBox = this.pictureBoxDog1, RacetrackLength = pictureBoxTrack.Width - finishLineWidth - this.pictureBoxDog1.Width, StartingPosition = 25 };
            dogs[2] = new Greyhound() { MyPictureBox = this.pictureBoxDog2, RacetrackLength = pictureBoxTrack.Width - finishLineWidth - this.pictureBoxDog2.Width, StartingPosition = 25 };
            dogs[3] = new Greyhound() { MyPictureBox = this.pictureBoxDog3, RacetrackLength = pictureBoxTrack.Width - finishLineWidth - this.pictureBoxDog3.Width, StartingPosition = 25 };

            Random theRandomizer = new Random();
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Randomizer = theRandomizer;
            }

            guys[0] = new Guy() { Name = "Joe", Cash = 100, MyLabel = this.labelJoeBet, MyRadioButton = this.radioButtonJoe, MyBet = null };
            guys[1] = new Guy() { Name = "Bob", Cash = 100, MyLabel = this.labelBobBet, MyRadioButton = this.radioButtonBob, MyBet = null };
            guys[2] = new Guy() { Name = "Mac", Cash = 100, MyLabel = this.labelMacBet, MyRadioButton = this.radioButtonMac, MyBet = null };

            guys[0].UpdateLabels();
            guys[1].UpdateLabels();
            guys[2].UpdateLabels();
        }

        private void buttonBets_Click(object sender, EventArgs e)
        {
            int Dog = (int)numericUpDownDog.Value;
            int Bet = (int)numericUpDownBet.Value;

            if (radioButtonJoe.Checked)
            {
                if (!guys[0].PlaceBet(Bet, Dog))
                {
                    MessageBox.Show("Not enough cash");
                }
            }

            else if (radioButtonBob.Checked)
            {
                if (!guys[1].PlaceBet(Bet, Dog))
                {
                    MessageBox.Show("Not enough cash");
                }
            }

            else if (radioButtonMac.Checked)
            {
                if (!guys[2].PlaceBet(Bet, Dog))
                {
                    MessageBox.Show("Not enough cash");
                }
            }
            
        }

        private void radioButtonJoe_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = "Joe";
        }

        private void radioButtonBob_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = "Bob";
        }

        private void radioButtonMac_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = "Mac";
        }

        private void buttonRace_Click(object sender, EventArgs e)
        {
            timer1.Start();

            groupBox1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int bonus = 0; // handicap cheat

            for (int i = 0; i < dogs.Length; i++)
            {
                //if (i == 0) bonus = 5; else bonus = 0; // give handicap to dog #0

                if (dogs[i].Run(bonus))
                {
                    timer1.Stop();
                    MessageBox.Show("Dog #" + i + " won the race!");

                    for (int k = 0; k < guys.Length; k++)
                    {
                        guys[k].Collect(i);
                        guys[k].UpdateLabels();
                    }

                    // reset dogs
                    for (int j = 0; j < dogs.Length; j++)
                    {
                        dogs[j].TakeStartingPosition();
                    }

                    // reset guys
                    for (int n = 0; n < guys.Length; n++)
                    {
                        guys[n].ClearBet();
                    }
                    
                    groupBox1.Enabled = true;
                    
                    return;

                    
                }
            }
        }

    }
}
