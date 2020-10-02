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
    public partial class RoomAllocationUC : UserControl
    {
        public RoomAllocationUC()
        {
            InitializeComponent();
        }

        private void sutRoomBtn_Click(object sender, EventArgs e)
        {
            SuitableRoomUC roomallocationUC = new SuitableRoomUC();
            MainControler.showControl(roomallocationUC, RoomAllocationPanel);
        }

        private void PreRoomBtn_Click(object sender, EventArgs e)
        {
            PreferredRoomUC roomallocationUC = new PreferredRoomUC();
            MainControler.showControl(roomallocationUC, RoomAllocationPanel);
        }

        private void TimeRoomBtn_Click(object sender, EventArgs e)
        {
            ReservedRoomUC roomallocationUC = new ReservedRoomUC();
            MainControler.showControl(roomallocationUC, RoomAllocationPanel);
        }

        private void LecGroupRBtn_Click(object sender, EventArgs e)
        {
            LecturerAndGroupsRoomUC roomallocationUC = new LecturerAndGroupsRoomUC();
            MainControler.showControl(roomallocationUC, RoomAllocationPanel);
        }

        private void sessConRBtn_Click(object sender, EventArgs e)
        {
            AddRoomSessionsUC roomallocationUC = new AddRoomSessionsUC();
            MainControler.showControl(roomallocationUC, RoomAllocationPanel);
        }
    }
}
