using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner_Ch6_Mods
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
                    
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(checkBoxDinnerHealthy.Checked, checkBoxDinnerFancy.Checked, (int)numericUpDownDinner.Value);
            birthdayParty = new BirthdayParty(textBoxCakeWriting.Text, checkBoxBirthdayFancy.Checked, (int)numericUpDownBirthday.Value);
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
            recalculateBirthdayEverything();
            DisplayBirthdayPartyCost();
        }

        private void textBoxCakeWriting_TextChanged(object sender, EventArgs e)
        {
            recalculateBirthdayEverything();
            DisplayBirthdayPartyCost();
        }

        private void recalculateBirthdayEverything()
        {
            birthdayParty.NumberOfPeople = (int)numericUpDownBirthday.Value;
            birthdayParty.CakeWriting = textBoxCakeWriting.Text;
            textBoxCakeWriting.Text = birthdayParty.CakeWriting; // copies valid text back to textbox in case user goes over limit
            birthdayParty.FancyDecorations = checkBoxBirthdayFancy.Checked;
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
