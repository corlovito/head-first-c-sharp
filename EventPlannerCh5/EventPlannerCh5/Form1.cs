using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPlannerCh5
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(); // { NumberOfPeople = 5 };
            dinnerParty.SetPartyOptions(5, checkBoxFancy.Checked);
            numericUpDown1.Value = dinnerParty.GetNumberOfPeople();
            dinnerParty.SetHealthyOption(checkBoxHealthy.Checked);
            //dinnerParty.CalculateCostOfDecorations(checkBoxFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOptions((int)numericUpDown1.Value, checkBoxFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBoxFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(checkBoxFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBoxHealthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBoxHealthy.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(checkBoxHealthy.Checked);
            labelCost.Text = Cost.ToString("c");
        }

    }
}
