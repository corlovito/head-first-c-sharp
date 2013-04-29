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
        public int timepast = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timepast++;
            label1.Text = timepast.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                timer1.Stop();
                timepast = 0;
                label1.Text = "0";
            }
            else
            {
                timer1.Enabled = true;
                timer1.Start();
            }

           
        }
    }
}
