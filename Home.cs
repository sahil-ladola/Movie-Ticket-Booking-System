﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public static String MovieName;
        private void btnScreen1_Click(object sender, EventArgs e)
        {
            MovieName = "RRR";
            Screen1 S1 = new Screen1();
            S1.Show();
            this.Hide();
        }

        private void btnScreen2_Click(object sender, EventArgs e)
        {
            MovieName = "Attack";
            Screen2 S2 = new Screen2();
            S2.Show();
            this.Hide();
        }

        private void btnScreen3_Click(object sender, EventArgs e)
        {
            MovieName = "Beast";
            Screen3 S3 = new Screen3();
            S3.Show();
            this.Hide();
        }
    }
}
