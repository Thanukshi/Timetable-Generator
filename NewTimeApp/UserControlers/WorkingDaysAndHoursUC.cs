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
            //commit
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add_WorkingDaysAndHoursUC add_workingDaysAndHoursUC = new Add_WorkingDaysAndHoursUC();
            MainControler.showControl(add_workingDaysAndHoursUC, panel1);
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            View_WorkingDaysAndHoursUC view_workingDaysAndHoursUC = new View_WorkingDaysAndHoursUC();
            MainControler.showControl(view_workingDaysAndHoursUC, panel1);
        }
    }
}
