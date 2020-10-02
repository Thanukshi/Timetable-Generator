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

        public void fillAcDetails()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
            string qry = "SELECT * FROM academicDetails";
            sqlCom = new SQLiteCommand(qry, sqlCon);
            SQLiteDataReader sldr;

            try
            {
                sqlCon.Open();
                sldr = sqlCom.ExecuteReader();
                while (sldr.Read())
                {
                    string year = sldr.GetString(1);
                    string sem = sldr.GetString(2);
                    acDetails.Items.Add(year + "." + sem);
                    string maID = "SELECT ID FROM academicDetails WHERE acYear ='" + year + "'And acSem ='" + sem + "'";
                }
            }
            catch (SQLiteException x)
            {
                CustomMessageBox.Show("Error!", "" + x.Message);
            }
        }

        public void fillDegreeDetails()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
            string qry = "SELECT * FROM degreeProgram";
            sqlCom = new SQLiteCommand(qry, sqlCon);
            SQLiteDataReader sldr;

            try
            {
                sqlCon.Open();
                sldr = sqlCom.ExecuteReader();
                while (sldr.Read())
                {
                    string dn = sldr.GetString(2);
                    degreeDetailsCombo.Items.Add(dn);
                }
            }
            catch (SQLiteException x)
            {
                CustomMessageBox.Show("Error!", "" + x.Message);
            }
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
                /*sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
                string sql = "CREATE TABLE mainGroupsDetails (MID INTEGER PRIMARY KEY ASC AUTOINCREMENT, macademicDetails VARCHAR (20) NOT NULL, mDegereeName  VARCHAR (20) NOT NULL, mGroupNo VARCHAR (20) NOT NULL )";
                sqlCom = new SQLiteCommand(sql, sqlCon);*/
                /*sqlCom.ExecuteNonQuery();
                sqlCon.Close();*/

                sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
            }
        }

        private void saveMG_Click(object sender, EventArgs e)
        {
            if (acDetails.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Academic Year And Semester", "Please Select Aademic Year And Semester.");
            }
            else if (degreeDetailsCombo.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Degree Program", "Please Select Degree Program .");
            }
            else if (mainGropNo.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Main Group Number", "Please Select Main Group Number.");

            }
            else
            {
                MainGroupClass mg = new MainGroupClass();
                mg.MAcDetails = acDetails.Text;
                mg.MDegreeDetails = degreeDetailsCombo.Text;
                mg.MGroupNo = mainGropNo.Text;

                DB = new SQLiteDataAdapter("SELECT * FROM mainGroupsDetails WHERE macademicDetails ='" + mg.MAcDetails + "' AND mDegereeName ='" + mg.MDegreeDetails + "' AND mGroupNo ='" + mg.MGroupNo + "' ", sqlCon);
                dt = new DataTable();
                DB.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Maing Groups", " " + mg.MAcDetails + "." + mg.MDegreeDetails + "." + mg.MGroupNo + " is already saved.");
                }

                else
                {

                    try
                    {
                        sqlCon = new SQLiteConnection(connectString);
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"INSERT INTO mainGroupsDetails (macademicDetails, mDegereeName, mGroupNo) VALUES(@macac, @mdegree, @mgno)";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.Add(new SQLiteParameter("@macac", mg.MAcDetails));
                        sqlCom.Parameters.Add(new SQLiteParameter("@mdegree", mg.MDegreeDetails));
                        sqlCom.Parameters.Add(new SQLiteParameter("@mgno", mg.MGroupNo));

                        sqlCon.Open();

                        int i = sqlCom.ExecuteNonQuery();

                        if (i == 1)
                        {
                            CustomMessageBox.Show("Main Group Details", "" + mg.MAcDetails + "." + mg.MDegreeDetails + "." + mg.MGroupNo + " is generated.");
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



