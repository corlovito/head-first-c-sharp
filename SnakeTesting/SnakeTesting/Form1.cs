﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeTesting
{
    public partial class Form1 : Form
    {
        Snake freddie;

        public Form1()
        {
            InitializeComponent();
            freddie = new Snake();
                        
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            Utility.Movements direction = Utility.Movements.right;
            freddie.Slither(direction);
        }

        private void buttonAddSegment_Click(object sender, EventArgs e)
        {
            freddie.AddSegment();
        }


    }
}
