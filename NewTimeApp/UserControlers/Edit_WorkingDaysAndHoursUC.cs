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
    public partial class Edit_WorkingDaysAndHoursUC : UserControl
    {
        public Edit_WorkingDaysAndHoursUC()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            View_WorkingDaysAndHoursUC view_workingDaysAndHoursUC = new View_WorkingDaysAndHoursUC();
            MainControler.showControl(view_workingDaysAndHoursUC, panel2);
        }
    }
}
