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
using NewTimeApp.UserControlers;

namespace NewTimeApp
{
    public partial class RoomUC : UserControl
    {
        public RoomUC()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            locationUC locate = new locationUC();
            MainControler.showControl(locate, roomPanel);
        }
    }
}
