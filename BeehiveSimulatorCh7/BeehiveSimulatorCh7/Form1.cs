using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveSimulatorCh7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new String[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new String[] { "Egg Care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new String[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new String[] { "Nector collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);
            queen = new Queen(workers);
        }

        Queen queen;

        private void buttonAssignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(comboBoxWorkerBeeJob.Text, (int)numericUpDownShifts.Value) == false)
                MessageBox.Show("No workers are available to do the job '" + comboBoxWorkerBeeJob.Text + "'", "The queen bee says...");
            else
                MessageBox.Show("The job '" + comboBoxWorkerBeeJob.Text + "' will be done in " + numericUpDownShifts.Value + " shifts", "The queen bee says...");                
        }

        private void buttonNextShift_Click(object sender, EventArgs e)
        {
            textBoxReport.Text = queen.WorkTheNextShift(); 
        }
    }

    

    

}
