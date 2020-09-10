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
    public partial class locationUC : UserControl
    {
        public locationUC()
        {
            InitializeComponent();
            
        }

        private void addBuldBtn_Click(object sender, EventArgs e)
        {
            buildingUC locatUC = new buildingUC();
            MainControler.showControl(locatUC, locationpanel);
        }

        private void addroomBtn_Click(object sender, EventArgs e)
        {
            roomUC locatUC = new roomUC();
            MainControler.showControl(locatUC, locationpanel);

        }

        private void viewbuldBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void viewroomBrn_Click(object sender, EventArgs e)
        {
            viewroomsUC locatUC = new viewroomsUC();
            MainControler.showControl(locatUC, locationpanel);

        }
    }
}
