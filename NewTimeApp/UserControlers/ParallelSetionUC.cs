﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewTimeApp.Helpers;

namespace NewTimeApp.UserControlers
{
    public partial class ParallelSetionUC : UserControl
    {
        public ParallelSetionUC()
        {
            InitializeComponent();
        }

        private void backBtnD_Click(object sender, EventArgs e)
        {
            Details studentsUC = new Details();
            MainControler.showControl(studentsUC, parallelSetionPanel);
        }
    }
}
