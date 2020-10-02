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
    public partial class buildingUC : UserControl
    {

        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter DB;
        String connectString;

        public buildingUC()
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
                string sql = "CREATE TABLE buildingDetails(ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, buildingName VARCHAR (50) NOT NULL)";

                string sql1 = "CREATE TABLE roomDetails(ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, buildingName VARCHAR (50) NOT NULL, roomName VARCHAR (50) NOT NULL, roomType VARCHAR (20) NOT NULL, capasity VARCHAR (50) NOT NULL )";

                string sql2 = "CREATE TABLE LecturerDetails (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, nametb VARCHAR (50) NOT NULL, empidtb  VARCHAR (10) NOT NULL,facultycb VARCHAR (50) NOT NULL,deptb VARCHAR (50) NOT NULL,centercb VARCHAR (50) NOT NULL," +
                "buildingcb VARCHAR (50) NOT NULL,categorycb VARCHAR (50) NOT NULL,levelcb VARCHAR (50) NOT NULL,ranktb VARCHAR (50) NOT NULL)";

                string sql3 = "CREATE TABLE SubjectDetails (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, year VARCHAR (50) NOT NULL, semester  VARCHAR (10) NOT NULL,subname VARCHAR (50) NOT NULL,code VARCHAR (50) NOT NULL,lech VARCHAR (50) NOT NULL," +
                    "tute VARCHAR (50) NOT NULL,lab VARCHAR (50) NOT NULL,evaluation VARCHAR (50) NOT NULL)";

                string sql5 = "CREATE TABLE tags (TID INTEGER PRIMARY KEY ASC AUTOINCREMENT, tags VARCHAR (20) NOT NULL)";

                string sql6 = "CREATE TABLE academicDetails (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, acYear VARCHAR (10) NOT NULL, acSem  VARCHAR (10) NOT NULL)";

                string sql7 = "CREATE TABLE degreeProgram (degreeID INTEGER PRIMARY KEY ASC AUTOINCREMENT, degreeName VARCHAR (100) NOT NULL, degreeShortName  VARCHAR (100) NOT NULL)";
                //string sql = "CREATE TABLE degreeProgram(degreeID INTEGER PRIMARY KEY ASC AUTOINCREMENT, degreeName VARCHAR (100) NOT NULL, degreeShortName VARCHAR (100) NOT NULL)";

                string sql8 = "CREATE TABLE mainGroupsDetails (MID INTEGER PRIMARY KEY ASC AUTOINCREMENT, macademicDetails VARCHAR (20) NOT NULL, mDegereeName  VARCHAR (20) NOT NULL, mGroupNo VARCHAR (20) NOT NULL )";

                string sql9 = "CREATE TABLE subGroupsDetails (SID INTEGER PRIMARY KEY ASC AUTOINCREMENT, MID VARCHAR (20) NOT NULL, SNO  VARCHAR (20) NOT NULL)";

                string sql10 = "CREATE TABLE WorkingDays (" +
                   "TableType VARCHAR PRIMARY KEY ," +
                   "WorkingDays VARCHAR (20) NOT NULL," +
                   "WorkingHours VARCHAR (50) NOT NULL," +
                   "TimeSlot VARCHAR (20) NOT NULL)";

                string sql11 = "CREATE TABLE SelectedDays (" +
                    "TableType VARCHAR ," +
                    "SelectedDays VARCHAR (20) NOT NULL)";

                sqlCom = new SQLiteCommand(sql, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql1, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql2, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql3, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql5, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql6, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql7, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql8, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql9, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql10, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCom = new SQLiteCommand(sql1, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCon.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            locationUC locatUC = new locationUC();
            MainControler.showControl(locatUC, buildingpanel);
        }

        private void buldingAddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(buildingNameTB.Text))
            {
                CustomMessageBox.Show("Building Name", "Please  enter valid Building Name.");
            }
            else
            {
                BuildingClass building = new BuildingClass();
                building.buildingName = buildingNameTB.Text;
                DB = new SQLiteDataAdapter("SELECT * FROM buildingDetails WHERE buildingName='" + building.buildingName + "' ", sqlCon);
                dt = new DataTable();
                DB.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Building Details", "" + building.buildingName + " is already saved.");
                }
                else
                {

                    try
                    {
                        sqlCon = new SQLiteConnection(connectString);
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"INSERT INTO buildingDetails (buildingName) VALUES(@buildingName)";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.Add(new SQLiteParameter("@buildingName", building.buildingName));
                        sqlCon.Open();

                        int i = sqlCom.ExecuteNonQuery();

                        if (i == 1)
                        {
                            CustomMessageBox.Show("Building Details", "" + building.buildingName + " is saved.");
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show("Error!", " " + ex.Message);
                    }
                }
            }

        }

        private void buildingNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
