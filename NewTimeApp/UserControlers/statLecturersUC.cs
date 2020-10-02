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
    public partial class statLecturersUC : UserControl
    {
        public statLecturersUC()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            statisticsUC statUC = new statisticsUC();
            MainControler.showControl(statUC, statLecturerspanel);
        }

        private void leclevelBtn_Click(object sender, EventArgs e)
        {

        }

        private void lecprogBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
