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
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            //String path = "E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            if (!File.Exists(path))
            {
                sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
                string sql = "CREATE TABLE academicDetails (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, acYear VARCHAR (10) NOT NULL, acSem  VARCHAR (10) NOT NULL)";
                sqlCom = new SQLiteCommand(sql, sqlCon);
                sqlCom.ExecuteNonQuery();
                sqlCon.Close();
            }
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





