using NewTimeApp.Helpers;
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

namespace NewTimeApp.UserControlers
{
    public partial class statisticsUC : UserControl
    {
        public statisticsUC()
        {
            InitializeComponent();
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            statStudentUC statUC = new statStudentUC();
            MainControler.showControl(statUC, statpanel);
        }

        private void lecturersBtn_Click(object sender, EventArgs e)
        {
            statLecturersUC statUC = new statLecturersUC();
            MainControler.showControl(statUC, statpanel);

        }

        private void subjectsBtn_Click(object sender, EventArgs e)
        {
            statSubjectUC statUC = new statSubjectUC();
            MainControler.showControl(statUC, statpanel);

        }
    }
}
