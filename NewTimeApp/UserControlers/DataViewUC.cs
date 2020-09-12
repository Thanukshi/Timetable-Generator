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

        private void degreeBtn_Click(object sender, EventArgs e)
        {
            DegreeDetailsView degreeDetailsView = new DegreeDetailsView();
            MainControler.showControl(degreeDetailsView, viewPanel);
        }

        private void mainGrpBtn_Click(object sender, EventArgs e)
        {
            MainGroupDetaisUC mainGroupDetaisUC = new MainGroupDetaisUC();
            MainControler.showControl(mainGroupDetaisUC, viewPanel);
        }

        private void subGroupBrn_Click(object sender, EventArgs e)
        {
            SubGroupDetailsUC subGroupDetaisUC = new SubGroupDetailsUC();
            MainControler.showControl(subGroupDetaisUC, viewPanel);
        }
    }
}
