using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroPressTimer
{

    public partial class Form1 : Form
    {
        public int Seconds = 0;
        public int Interval = Properties.Settings.Default.Interval;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            numericUpDown1.Value = Properties.Settings.Default.Interval;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Seconds == 99)
                Seconds = -1;

            Seconds++;
            labelSeconds.Text = Seconds.ToString("00");
            if (Seconds == Properties.Settings.Default.Interval)
                System.Media.SystemSounds.Beep.Play();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            numericUpDown1.Visible = false;
            buttonOK.Visible = false;
            label1.Visible = true;

            Properties.Settings.Default.Interval = (int)numericUpDown1.Value;
        }

        private void labelSeconds_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                timer1.Start();
                Seconds = 0;
                labelSeconds.Text = "00";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            numericUpDown1.Visible = true;
            buttonOK.Visible = true;
        }
    }

}
