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
    public partial class WorkingDaysAndHoursUC : UserControl
    {
        public WorkingDaysAndHoursUC()
        {
            InitializeComponent();
        }

        private void dayBtn_Click(object sender, EventArgs e)
        {
            ViewWeekdayDetailsUC weekdayDetails = new ViewWeekdayDetailsUC();
            MainControler.showControl(weekdayDetails, panel1);
           
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            ViewWeekendDetailsUC weekdayDetails = new ViewWeekendDetailsUC();
            MainControler.showControl(weekdayDetails, panel1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
