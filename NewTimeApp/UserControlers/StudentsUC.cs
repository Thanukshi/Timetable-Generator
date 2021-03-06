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
    public partial class StudentsUC : UserControl
    {
        public StudentsUC()
        {
            InitializeComponent();
        }

        private void studentBtn_Click_1(object sender, EventArgs e)
        {
            ReportsUC studentsUC = new ReportsUC();
            MainControler.showControl(studentsUC, studentPanel);
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            academicDetails academicD = new academicDetails();
            MainControler.showControl(academicD, studentPanel);
        }

        private void degreeBtn_Click(object sender, EventArgs e)
        {
            DegreeProgramUC degreeProgramUC = new DegreeProgramUC();
            MainControler.showControl(degreeProgramUC, studentPanel);
        }

        private void mainGrpBtn_Click(object sender, EventArgs e)
        {
            MainGroupUC mainGroupUC = new MainGroupUC();
            MainControler.showControl(mainGroupUC, studentPanel);
        }

        private void subGroupBrn_Click(object sender, EventArgs e)
        {
            SubGroupUC subGroupUC = new SubGroupUC();
            MainControler.showControl(subGroupUC, studentPanel);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            DataViewUC dataViewUC = new DataViewUC();
            MainControler.showControl(dataViewUC, studentPanel);
        }
    }
}
