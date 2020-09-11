using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NewTimeApp.Helpers;

namespace NewTimeApp.UserControlers
{
    public partial class SubGroupUC : UserControl
    {
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        string subGroupID = "";

        public SubGroupUC()
        {
            InitializeComponent();
            fillMainGroup();

            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            sqlCon.Open();
        }

        public void fillMainGroup()
        {
            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            string qry = "SELECT * FROM AcademicDetails";
            sqlCom = new SqlCommand(qry, sqlCon);
            SqlDataReader sqlDataReader;

            try
            {
                sqlCon.Open();
                sqlDataReader = sqlCom.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string year = sqlDataReader.GetString(1);
                    string semester = sqlDataReader.GetString(2);
                    acDetails.Items.Add(year + "." + semester);
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void saveSG_Click(object sender, EventArgs e)
        {

        }

        private void backBtnS_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, subPanel);
        }
    }
}
