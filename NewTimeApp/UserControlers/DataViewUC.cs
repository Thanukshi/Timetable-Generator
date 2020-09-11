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
    public partial class DataViewUC : UserControl
    {
        public DataViewUC()
        {
            InitializeComponent();
        }

        private void backBtnS_Click(object sender, EventArgs e)
        {

            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, viewPanel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            AcademicDetailsViewUC academicDetailsViewUC = new AcademicDetailsViewUC();
            MainControler.showControl(academicDetailsViewUC, viewPanel);
        }
    }
}
