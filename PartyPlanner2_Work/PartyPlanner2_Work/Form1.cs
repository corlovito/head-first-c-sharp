using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner2_Work
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
                    
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(checkBoxDinnerHealthy.Checked, checkBoxDinnerFancy.Checked, (int)numericUpDownDinner.Value);
            birthdayParty = new BirthdayParty(textBoxCakeWriting.Text);
            DisplayDinnerPartyCost();
            DisplayBirthdayPartyCost();
        }

        #region Birthday_Party

        private void numericUpDownBirthday_ValueChanged(object sender, EventArgs e)
        {
            recalculateBirthdayEverything();
            DisplayBirthdayPartyCost();
        }

        private void checkBoxBirthdayFancy_CheckedChanged(object sender, EventArgs e)
        {
            DisplayBirthdayPartyCost();
        }

        private void recalculateBirthdayEverything()
        {
            
        }

        private void DisplayBirthdayPartyCost()
        {
            labelBirthdayCost.Text = (birthdayParty.CalculateCost()).ToString("c");
        }


        #endregion


        #region Dinner_Party

        private void numericUpDownDinner_ValueChanged(object sender, EventArgs e)
        {
            recalculateDinnerEverything();
            DisplayDinnerPartyCost();
        }

        private void checkBoxDinnerFancy_CheckedChanged(object sender, EventArgs e)
        {
            recalculateDinnerEverything();
            DisplayDinnerPartyCost();
        }

        private void checkBoxDinnerHealthy_CheckedChanged(object sender, EventArgs e)
        {
            recalculateDinnerEverything();
            DisplayDinnerPartyCost();
        }

        private void recalculateDinnerEverything()
        {
            dinnerParty.NumberOfPeople = (int)numericUpDownDinner.Value;
            dinnerParty.HealthyOption = checkBoxDinnerHealthy.Checked;
            dinnerParty.FancyDecorations = checkBoxDinnerFancy.Checked;
        }

        private void DisplayDinnerPartyCost()
        {
            labelDinnerCost.Text = (dinnerParty.CalculateCost()).ToString("c");
        }

        #endregion

 


    }
}
