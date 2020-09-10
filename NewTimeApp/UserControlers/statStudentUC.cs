using System;
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
    public partial class statStudentUC : UserControl
    {
        public statStudentUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            statisticsUC statUC = new statisticsUC();
            MainControler.showControl(statUC, statStudentpanel);
        }

        private void studyearBtn_Click(object sender, EventArgs e)
        {

        }

        private void progStudBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
