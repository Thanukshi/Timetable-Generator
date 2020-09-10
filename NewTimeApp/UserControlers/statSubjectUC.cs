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
    public partial class statSubjectUC : UserControl
    {
        public statSubjectUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            statisticsUC statUC = new statisticsUC();
            MainControler.showControl(statUC, statSubjectpanel);
        }

        private void subyearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
