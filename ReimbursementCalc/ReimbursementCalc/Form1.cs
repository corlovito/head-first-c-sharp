using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReimbursementCalc
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
            labelAmount.Text = "";
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDownStart.Value;
            endingMileage = (int)numericUpDownEnd.Value;

            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = reimburseRate * milesTraveled;
                labelAmount.Text = "$" + amountOwed.ToString();
            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot Calculate");
            }

        }

        private void buttonDisplayMiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}
