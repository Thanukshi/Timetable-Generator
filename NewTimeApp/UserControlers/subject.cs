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
    public partial class subject : UserControl
    {
        public subject()
        {
            InitializeComponent();
        }

        private void buttonaddsub_Click(object sender, EventArgs e)
        {
            addsubjec sub = new addsubjec();
            MainControler.showControl(sub, panelsubb);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonviewsub_Click(object sender, EventArgs e)
        {
            editsub su = new editsub();
            MainControler.showControl(su, panelsubb);
        }
    }
}
