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
            ShowBuildingUC locatUC = new ShowBuildingUC();
            MainControler.showControl(locatUC, locationpanel);

        }

        private void viewroomBrn_Click(object sender, EventArgs e)
        {
            showroomUC locatUC = new showroomUC();
            MainControler.showControl(locatUC, locationpanel);

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            /*RoomAllocationUC roomallocationUC = new RoomAllocationUC();
            RoomAllocationUC locatUC = new RoomAllocationUC();
            MainControler.showControl(locatUC, locationpanel);*/
        }
    }
}
