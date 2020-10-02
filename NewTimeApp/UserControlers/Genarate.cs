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
    public partial class Genarate : UserControl
    {
        public Genarate()
        {
            InitializeComponent();
        }

        private void lec_Click(object sender, EventArgs e)
        {
            GenarateTableLecturer add_workingDaysAndHoursUC = new GenarateTableLecturer();
            MainControler.showControl(add_workingDaysAndHoursUC, panel1);
        }

        private void std_Click(object sender, EventArgs e)
        {
            GenarateTableStudent add_workingDaysAndHoursUC = new GenarateTableStudent();
            MainControler.showControl(add_workingDaysAndHoursUC, panel1);
        }

        private void hall_Click(object sender, EventArgs e)
        {
            GenarateTableHall add_workingDaysAndHoursUC = new GenarateTableHall();
            MainControler.showControl(add_workingDaysAndHoursUC, panel1);
        }
    }
}
