﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTimeApp.UserControlers
{
    public partial class Details : UserControl
    {
        public Details()
        {
            InitializeComponent();
        }

        private void backBtnS_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.ShowDialog();
            this.Hide();
        }

        private void backBtnS_Click_1(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.ShowDialog();
            this.Hide();
        }
    }
}
