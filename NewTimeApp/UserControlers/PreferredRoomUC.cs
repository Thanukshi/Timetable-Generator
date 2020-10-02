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
    public partial class PreferredRoomUC : UserControl
    {
        public PreferredRoomUC()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            RoomAllocationUC roomallocationUC = new RoomAllocationUC();
            MainControler.showControl(roomallocationUC, PreferredRoomPanel);
        }
    }
}
