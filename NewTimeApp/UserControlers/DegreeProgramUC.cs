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
    public partial class DegreeProgramUC : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt1, dt2, dt3;
        private SQLiteDataAdapter DBM;
        private SQLiteDataAdapter DBF;
        private SQLiteDataAdapter DBS;
        //String path = "E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
        String path = Application.StartupPath + @"\Database\TimeAppDB.db";
        String connectString;

        public DegreeProgramUC()
        {
            InitializeComponent();
            //connectString = @"Data Source = E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            sqlCon = new SQLiteConnection(connectString);
            GenerateDatabase();
        }

        private void GenerateDatabase()
        {
            //String path = "E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            if (!File.Exists(path))
            {
                sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
            }
        }

        private void backBtnD_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, degreePanel);
        }

        private void saveDe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(programNameD.Text))
            {
                CustomMessageBox.Show("Degree Full Program", "Please enter valid degree program.");
            }
            else if (string.IsNullOrWhiteSpace(preferNameD.Text))
            {
                CustomMessageBox.Show("Degree Short Program", "Please enter valid degree program short name.");
            }

            else
            {
                DegreeProgramClass dpc = new DegreeProgramClass();
                dpc.DegreeFullName = programNameD.Text;
                dpc.DegreeShortName = preferNameD.Text;

                DBM = new SQLiteDataAdapter("SELECT * FROM degreeProgram WHERE degreeName ='" + dpc.DegreeFullName + "' AND degreeShortName='" + dpc.DegreeShortName + "'", sqlCon);
                dt1 = new DataTable();
                DBM.Fill(dt1);

                DBF = new SQLiteDataAdapter("SELECT degreeName FROM degreeProgram WHERE degreeName ='" + dpc.DegreeFullName + "'", sqlCon);
                dt2 = new DataTable();
                DBF.Fill(dt2);

                DBS = new SQLiteDataAdapter("SELECT degreeShortName FROM degreeProgram WHERE degreeShortName='" + dpc.DegreeShortName + "'", sqlCon);
                dt3 = new DataTable();
                DBS.Fill(dt3);

                if (dt1.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Degree Program Name", "" + dpc.DegreeFullName + " And " + dpc.DegreeShortName + " is already saved.");
                }
                else if (dt2.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Degree Program Full Name", "" + dpc.DegreeFullName + " is already saved.");
                }
                else if (dt3.Rows.Count >= 1)
                {

                    CustomMessageBox.Show("Degree Program Short Name", "" + dpc.DegreeShortName + " is already saved.");
                }
                else
                {

                    try
                    {
                        sqlCon = new SQLiteConnection(connectString);
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"INSERT INTO degreeProgram (degreeName, degreeShortName) VALUES(@degreename, @degreeshortnme)";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.Add(new SQLiteParameter("@degreename", dpc.DegreeFullName));
                        sqlCom.Parameters.Add(new SQLiteParameter("@degreeshortnme", dpc.DegreeShortName));

                        sqlCon.Open();

                        int i = sqlCom.ExecuteNonQuery();

                        if (i == 1)
                        {
                            CustomMessageBox.Show("Academic Details", "" + dpc.DegreeFullName + " " + dpc.DegreeShortName + " is generated.");
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show("Error!", " " + ex.Message);
                    }
                }
            }

        }
        private void programNameD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
