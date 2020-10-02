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
    public partial class GenarateTableStudent : UserControl
    {
        public GenarateTableStudent()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            TimeTableHtml timeTableHtml = new TimeTableHtml();
            MainControler.showControl(timeTableHtml, panel1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
