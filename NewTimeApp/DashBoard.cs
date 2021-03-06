﻿using NewTimeApp.Helpers;
using NewTimeApp.UserControlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTimeApp
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            //dashbordUC1.BringToFront();
            titleOfPages.Text = "Home";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dashBoard = new DashBoard();
            dashBoard.ShowDialog();
            titleOfPages.Text = "Home";
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            //details1.BringToFront();
            Details details = new Details();
            MainControler.showControl(details, panelContainer);
            titleOfPages.Text = "Allocates Details";
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            // reportsUC1.BringToFront();
            ReportsUC reportsUC = new ReportsUC();
            MainControler.showControl(reportsUC, panelContainer);
            titleOfPages.Text = "Reports";
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            //settingsUC1.BringToFront();
            SettingsUC settingsUC = new SettingsUC();
            MainControler.showControl(settingsUC, panelContainer);
            titleOfPages.Text = "Settings";
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void studentBtn_Click_1(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, panelContainer);
            titleOfPages.Text = "Students";
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tagBtn_Click(object sender, EventArgs e)
        {
            TagUC studentsUC = new TagUC();
            MainControler.showControl(studentsUC, panelContainer);
            titleOfPages.Text = "Tags";
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            locationUC lc = new locationUC();
            MainControler.showControl(lc, panelContainer);
            titleOfPages.Text = "Location";

        }

        private void statBtn_Click(object sender, EventArgs e)
        {
            statisticsUC lc = new statisticsUC();
            MainControler.showControl(lc, panelContainer);
            titleOfPages.Text = "Statistics";
        }

        private void lecBtn_Click(object sender, EventArgs e)
        {
            lectureUC lc = new lectureUC();
            MainControler.showControl(lc, panelContainer);
            titleOfPages.Text = "Lecturer Details";
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            subject lc = new subject();
            MainControler.showControl(lc, panelContainer);
            titleOfPages.Text = "Subject Details";
        }

        private void workBtn_Click(object sender, EventArgs e)
        {
            WorkingDaysAndHoursUC lc = new WorkingDaysAndHoursUC();
            MainControler.showControl(lc, panelContainer);
            titleOfPages.Text = "Working Days and Hours";
        }
    }
}
