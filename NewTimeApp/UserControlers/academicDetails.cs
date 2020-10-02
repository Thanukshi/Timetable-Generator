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
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp;
using FireSharp.Response;
using System.Data.SQLite;
using System.IO;

namespace NewTimeApp.UserControlers
{
    public partial class academicDetails : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter DB;
        String connectString;

        public academicDetails()
        {
            InitializeComponent();
            //connectString = @"Data Source=" + Application.StartupPath + @"\NewTimeApp\bin\Debug\TimeAppDB.db; version=3";
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            //connectString = @"Data Source = E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
            GenerateDatabase();
        }

        private void GenerateDatabase()
        {
            sqlCon = new SQLiteConnection(connectString);
            sqlCon.Open();
            string sql1 = "CREATE TABLE academicDetails (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, acYear VARCHAR (10) NOT NULL, acSem  VARCHAR (10) NOT NULL)";

            string sql2 = "CREATE TABLE degreeProgram (degreeID INTEGER PRIMARY KEY ASC AUTOINCREMENT, degreeName VARCHAR (100) NOT NULL, degreeShortName  VARCHAR (100) NOT NULL)";
            //string sql = "CREATE TABLE degreeProgram(degreeID INTEGER PRIMARY KEY ASC AUTOINCREMENT, degreeName VARCHAR (100) NOT NULL, degreeShortName VARCHAR (100) NOT NULL)";

            string sql3 = "CREATE TABLE mainGroupsDetails (MID INTEGER PRIMARY KEY ASC AUTOINCREMENT, macademicDetails VARCHAR (20) NOT NULL, mDegereeName  VARCHAR (20) NOT NULL, mGroupNo VARCHAR (20) NOT NULL )";

            string sql4 = "CREATE TABLE subGroupsDetails (SID INTEGER PRIMARY KEY ASC AUTOINCREMENT, MID VARCHAR (20) NOT NULL, SNO  VARCHAR (20) NOT NULL)";

            string sql5 = "CREATE TABLE tags (TID INTEGER PRIMARY KEY ASC AUTOINCREMENT, tags VARCHAR (20) NOT NULL)";

            sqlCom = new SQLiteCommand(sql1, sqlCon);
            sqlCom.ExecuteNonQuery();

            sqlCom = new SQLiteCommand(sql2, sqlCon);
            sqlCom.ExecuteNonQuery();

            sqlCom = new SQLiteCommand(sql3, sqlCon);
            sqlCom.ExecuteNonQuery();

            sqlCom = new SQLiteCommand(sql4, sqlCon);
            sqlCom.ExecuteNonQuery();

            sqlCom = new SQLiteCommand(sql5, sqlCon);
            sqlCom.ExecuteNonQuery();

            sqlCon.Close();
        }

        private void academicDetails_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, acPanel);
        }

        private void saveAcademic_Click(object sender, EventArgs e)
        {
            if (acYear.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Academic Year", "Please select academic year.");
            }
            else if (acSem.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Academic Semester", "Please select academic semester.");
            }

            else
            {
                AcademicDetailsClass academic = new AcademicDetailsClass();
                academic.AcYear = acYear.Text;
                academic.AcSEM = acSem.Text;

                DB = new SQLiteDataAdapter("SELECT * FROM academicDetails WHERE acYear='" + academic.AcYear + "' AND acSem='" + academic.AcSEM + "'", sqlCon);
                dt = new DataTable();
                DB.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Academic Details", "" + academic.AcYear + "." + academic.AcSEM + " is already saved.");
                }
                else
                {

                    try
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
                    }
                }
            }

        }
    }
}





