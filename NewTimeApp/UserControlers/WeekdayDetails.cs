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
    public partial class WeekdayDetails : UserControl
    {
        public WeekdayDetails()
        {
            InitializeComponent();
        }

        private void jImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
           AddWeekDayUC addWeekDayUC = new AddWeekDayUC();
           MainControler.showControl(addWeekDayUC, panel1);
        }

        private void jFlatButton2_Click(object sender, EventArgs e)
        {
            ViewWeekdayDetailsUC viewWeekdayDetailsUC = new ViewWeekdayDetailsUC();
            MainControler.showControl(viewWeekdayDetailsUC, panel1);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            WorkingDaysAndHoursUC weekdayDetails = new WorkingDaysAndHoursUC();
            MainControler.showControl(weekdayDetails, panel1);
        }
    }
}
