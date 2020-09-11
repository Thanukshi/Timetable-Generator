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
    public partial class ViewWeekendDetailsUC : UserControl
    {
        public ViewWeekendDetailsUC()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            WeekdayDetails weekdayDetails = new WeekdayDetails();
            MainControler.showControl(weekdayDetails, panel1);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditWeekendUC editWeekendUC = new EditWeekendUC();
            MainControler.showControl(editWeekendUC, panel1);
        }
    }
}
