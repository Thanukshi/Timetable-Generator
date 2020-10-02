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
    public partial class WorkingDaysAndHoursUC : UserControl
    {
        public WorkingDaysAndHoursUC()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add_WorkingDaysAndHoursUC add_workingDaysAndHoursUC = new Add_WorkingDaysAndHoursUC();
            MainControler.showControl(add_workingDaysAndHoursUC, panel1);
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            Genarate add_workingDaysAndHoursUC = new Genarate();
            MainControler.showControl(add_workingDaysAndHoursUC, panel1);
        }
    }
}
