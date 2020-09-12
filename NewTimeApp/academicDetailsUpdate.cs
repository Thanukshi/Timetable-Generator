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

namespace NewTimeApp
{
    public partial class academicDetailsUpdate : UserControl
    {
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        string mainGroupID = "";

        public academicDetailsUpdate()
        {
            InitializeComponent();
            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            sqlCon.Open();
            fillAcDetails();
        }

        private void saveAcc_Click(object sender, EventArgs e)
        {

        }

        public void fillAcDetails()
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
                    acUpYear.Text = year;
                    acUpSem.Text = semester;
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
