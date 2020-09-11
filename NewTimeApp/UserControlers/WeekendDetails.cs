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
    public partial class WeekendDetails : UserControl
    {
        public WeekendDetails()
        {
            InitializeComponent();
        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            AddWeekEndUC addWeekendUC = new AddWeekEndUC();
            MainControler.showControl(addWeekendUC, panel1);
        }

        private void jFlatButton2_Click(object sender, EventArgs e)
        {
            ViewWeekendDetailsUC viewWeekendDetailsUC = new ViewWeekendDetailsUC();
            MainControler.showControl(viewWeekendDetailsUC, panel1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void jFlatButton1_Click_1(object sender, EventArgs e)
        {
            AddWeekEndUC addWeekEndUC = new AddWeekEndUC();
            MainControler.showControl(addWeekEndUC, panel1);
        }

        private void jFlatButton2_Click_1(object sender, EventArgs e)
        {
            ViewWeekendDetailsUC viewWeekendDetailsUC = new ViewWeekendDetailsUC();
            MainControler.showControl(viewWeekendDetailsUC, panel1);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            WorkingDaysAndHoursUC weekdayDetails = new WorkingDaysAndHoursUC();
            MainControler.showControl(weekdayDetails, panel1);
        }
    }
}
