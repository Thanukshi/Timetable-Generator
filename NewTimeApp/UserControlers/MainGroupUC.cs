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
using System.Data.SqlClient;

namespace NewTimeApp.UserControlers
{
    public partial class MainGroupUC : UserControl
    {
        SqlConnection sqlCon;
        SqlCommand sqlCom;

        public MainGroupUC()
        {
            InitializeComponent();
            fillAcDetails();
            fillDegreeDetails();

        }

        private void backBtnD_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, mgPanel);
        }

        private void acDetails_SelectedIndexChanged(object sender, EventArgs e)
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
                    acDetails.Items.Add(year+"."+semester);
                }
            }catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }


        public void fillDegreeDetails()
        {
            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            string qry = "SELECT * FROM DegreeDetails";
            sqlCom = new SqlCommand(qry, sqlCon);
            SqlDataReader sqlDataReader;

            try
            {
                sqlCon.Open();
                sqlDataReader = sqlCom.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string degreedetails = sqlDataReader.GetString(2);
                    degreeDetailsCombo.Items.Add(degreedetails);
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void saveMG_Click(object sender, EventArgs e)
        {
            if (acDetails.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select academic Year and semester.", "Academic Year And Semester", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (acSem.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select Academic Semester.", "Academic Semester", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCom = new SqlCommand("abcAcademicDetails", sqlCon);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCom.Parameters.AddWithValue("@AcademicId", acedemicID);
                    sqlCom.Parameters.AddWithValue("@AcademicYear", acYear.Text);
                    sqlCom.Parameters.AddWithValue("@AcademicSemester", acSem.Text);

                    int numRes = sqlCom.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Academic Year and Semester is " + " " + acYear.Text + "." + " " + acSem.Text);
                    }
                    else
                        MessageBox.Show("Please Try Again !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }
    }
}
    }

}
