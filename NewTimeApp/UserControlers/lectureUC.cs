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
    public partial class lectureUC : UserControl
    {
        public lectureUC()
        {
            InitializeComponent();
        }


        private void addLec_Click(object sender, EventArgs e)
        {
            LecturerIN lec = new LecturerIN();
            MainControler.showControl(lec, lecPanel);
        }

        private void viewLec_Click(object sender, EventArgs e)
        {
            veiwlecturer lec = new veiwlecturer();
            MainControler.showControl(lec, lecPanel);
        }
    }
}
