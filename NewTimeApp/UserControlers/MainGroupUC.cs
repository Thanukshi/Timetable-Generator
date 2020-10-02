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
using System.Data.SQLite;
using System.IO;

namespace NewTimeApp.UserControlers
{
    public partial class MainGroupUC : UserControl
    {
        /*SqlConnection sqlCon;
        SqlCommand sqlCom;
        string mainGroupID = "";*/
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter DB;
        String connectString;

        public MainGroupUC()
        {
            InitializeComponent();
            /* fillAcDetails();
             fillDegreeDetails();
             string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
             sqlCon = new SqlConnection(con);
             sqlCon.Open();*/
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            sqlCon = new SQLiteConnection(connectString);
            GenerateDatabase();
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
        private void GenerateDatabase()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            //String path = "E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            if (!File.Exists(path))
            {
                sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
                string sql = "CREATE TABLE mainGroupsDetails (MID INTEGER PRIMARY KEY ASC AUTOINCREMENT, macademicDetails VARCHAR (20) NOT NULL, mDegereeName  VARCHAR (20) NOT NULL)";
                sqlCom = new SQLiteCommand(sql, sqlCon);
                sqlCom.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public void fillAcDetails()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            //string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            SQLiteConnection con = new SQLiteConnection(path);
            string qry = "SELECT * FROM academicDetails";
            sqlCom = new SQLiteCommand(qry, con);
            SQLiteDataReader sqlDataReader;
            con.Open();
            try
            {
                con.Open();
                sqlDataReader = sqlCom.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string year = sqlDataReader.GetString(1);
                    string semester = sqlDataReader.GetString(2);
                    acDetails.Items.Add(year + "." + semester);
                }
                /*sqlCon.Open();
                sqlDataReader = sqlCom.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string year = sqlDataReader.GetString(1);
                    string semester = sqlDataReader.GetString(2);
                    acDetails.Items.Add(year + "." + semester);
                }*/
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }


        public void fillDegreeDetails()
        {
            /*String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            //string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SQLiteConnection(path);
            string qry = "SELECT * FROM degreeProgram";
            sqlCom = new SQLiteCommand(qry, sqlCon);
            SQLiteDataReader sqlDataReader;

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
            }*/
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
                /*try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }

                    DataTable dtData = new DataTable();
                    sqlCom = new SQLiteCommand("abcmainGroup", sqlCon);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCom.Parameters.AddWithValue("@MainGroupID", mainGroupID);
                    sqlCom.Parameters.AddWithValue("@AcademicD", acDetails.Text);
                    sqlCom.Parameters.AddWithValue("@DegreeD", degreeDetailsCombo.Text);
                    sqlCom.Parameters.AddWithValue("@MainGroupNu", mainGropNo.Text);

                    int numRes = sqlCom.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Main Group  ID is " + " " + acDetails.Text + ". " + degreeDetailsCombo.Text + ". " + mainGropNo.Text + " is created successfully..");
                    }
                    else
                        MessageBox.Show("Please Try Again !!!");
                }
                // }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }*/
                /*try
                {

                    sqlCon = new SQLiteConnection(connectString);
                    sqlCom = new SQLiteCommand();
                    sqlCom.CommandText = @"INSERT INTO academicDetails (acYear, acSem) VALUES(@acyear, @acsem)";
                    sqlCom.Connection = sqlCon;
                    sqlCom.Parameters.Add(new SQLiteParameter("@acyear", academic.AcYear));
                    sqlCom.Parameters.Add(new SQLiteParameter("@acsem", academic.AcSEM));

                    sqlCon.Open();

                    int i = sqlCom.ExecuteNonQuery();

                    if (i == 1)
                    {
                        CustomMessageBox.Show("Academic Details", "" + academic.AcYear + "." + academic.AcSEM + " is generated.");
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Error!", " " + ex.Message);
                }*/
            }
        }

    }
}



