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
        string mainGroupID = "";

        public MainGroupUC()
        {
            InitializeComponent();
            fillAcDetails();
            fillDegreeDetails();
            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            sqlCon.Open();

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
                MessageBox.Show("Please Select Aademic Year And Semester.", "Academic Year And Semester", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (degreeDetailsCombo.SelectedIndex <= -1)
            {
                MessageBox.Show("Please Select Degree Program .", "Degree Program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (mainGropNo.SelectedIndex <= -1)
            {
                MessageBox.Show("Please Select Main Group Number.", "Main Group Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                try
                {
                    SqlDataAdapter YearAd = new SqlDataAdapter("SELECT AcademicDetails FROM MainGroup WHERE AcademicDetails = '" + acDetails.Text + "'", sqlCon);
                    SqlDataAdapter DegreeAd = new SqlDataAdapter("SELECT ShortDegreeName FROM DegreeDetails WHERE ShortDegreeName = '" + degreeDetailsCombo.Text + "'", sqlCon);
                    SqlDataAdapter GroupAD = new SqlDataAdapter("SELECT ShortDegreeName FROM DegreeDetails WHERE ShortDegreeName = '" + mainGropNo.Text + "'", sqlCon);

                    DataTable yearTbl = new DataTable();
                    DataTable degreeTbl = new DataTable();
                    DataTable groupTbl = new DataTable();

                    YearAd.Fill(yearTbl);
                    DegreeAd.Fill(degreeTbl);
                    GroupAD.Fill(groupTbl);

                    if (yearTbl.Rows.Count >= 1)
                    {
                        MessageBox.Show("Academic Year and Semester is already exist...", "Academic Year and Semester", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (degreeTbl.Rows.Count >= 1)
                    {
                        MessageBox.Show("Degree Program is already exist...", "Degree Program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (groupTbl.Rows.Count >= 1)
                    {
                        MessageBox.Show("Main Group is already exist...", "MAin Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        DataTable dtData = new DataTable();
                        sqlCom = new SqlCommand("abcmainGroup", sqlCon);
                        sqlCom.CommandType = CommandType.StoredProcedure;
                        sqlCom.Parameters.AddWithValue("@ActionType", "SaveData");
                        sqlCom.Parameters.AddWithValue("@MainGroupID", mainGroupID);
                        sqlCom.Parameters.AddWithValue("@AcademicD", acDetails.Text);
                        sqlCom.Parameters.AddWithValue("@DegreeD", degreeDetailsCombo.Text);
                        sqlCom.Parameters.AddWithValue("@MainGroupNu", mainGropNo.Text);

                        int numRes = sqlCom.ExecuteNonQuery();
                        if (numRes > 0)
                        {
                            MessageBox.Show("Main Group " + " " + mainGropNo.Text + " is created successfully..");
                        }
                        else
                            MessageBox.Show("Please Try Again !!!");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }
    }
}
    


