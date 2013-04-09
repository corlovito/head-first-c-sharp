using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlannerFixedCh5
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(checkBoxHealthy.Checked, checkBoxFancy.Checked, (int)numericUpDown1.Value);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            recalculateEverything();
            DisplayDinnerPartyCost();
        }

        private void checkBoxFancy_CheckedChanged(object sender, EventArgs e)
        {
            recalculateEverything();
            DisplayDinnerPartyCost();
        }

        private void checkBoxHealthy_CheckedChanged(object sender, EventArgs e)
        {
            recalculateEverything();
            DisplayDinnerPartyCost();
        }

        private void recalculateEverything()
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            dinnerParty.HealthyOption = checkBoxHealthy.Checked;
            dinnerParty.FancyDecorations = checkBoxFancy.Checked; 
        }

        private void DisplayDinnerPartyCost()
        {
            labelCost.Text = (dinnerParty.CalculateCost()).ToString("c");
        }
    }
}
