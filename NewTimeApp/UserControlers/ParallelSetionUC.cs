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
using System.Data.SQLite;
using System.IO;

namespace NewTimeApp.UserControlers
{
    public partial class ParallelSetionUC : UserControl
    {

        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter DB;
        String connectString;

        public ParallelSetionUC()
        {
            InitializeComponent();

            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            sqlCon = new SQLiteConnection(connectString);
            FillLecDetails();
            FillSubDetails();
            FillTagDetails();
            FillMainGroup();
            FillSubGroup();
        }

        private void GenerateDatabase()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            //String path = "E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            if (!File.Exists(path))
            {
                sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
            }
        }

        public void FillLecDetails()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
            string qry = "SELECT * FROM LecturerDetails";
            sqlCom = new SQLiteCommand(qry, sqlCon);
            SQLiteDataReader sldr;

            try
            {
                sqlCon.Open();
                sldr = sqlCom.ExecuteReader();
                while (sldr.Read())
                {
                    string lec = sldr.GetString(1);
                    LecNotA.Items.Add(lec);
                    //string maID = "SELECT ID FROM academicDetails WHERE acYear ='" + year + "'And acSem ='" + sem + "'";
                }
            }
            catch (SQLiteException x)
            {
                CustomMessageBox.Show("Error!", "" + x.Message);
            }
        }

        public void FillSubDetails()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
            string qry = "SELECT * FROM SubjectDetails";
            sqlCom = new SQLiteCommand(qry, sqlCon);
            SQLiteDataReader sldr;

            try
            {
                sqlCon.Open();
                sldr = sqlCom.ExecuteReader();
                while (sldr.Read())
                {
                    string sub = sldr.GetString(3);
                    SubNotA.Items.Add(sub);
                    //string maID = "SELECT ID FROM academicDetails WHERE acYear ='" + year + "'And acSem ='" + sem + "'";
                }
            }
            catch (SQLiteException x)
            {
                CustomMessageBox.Show("Error!", "" + x.Message);
            }
        }

        public void FillTagDetails()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
            string qry = "SELECT * FROM tags";
            sqlCom = new SQLiteCommand(qry, sqlCon);
            SQLiteDataReader sldr;

            try
            {
                sqlCon.Open();
                sldr = sqlCom.ExecuteReader();
                while (sldr.Read())
                {
                    string sub = sldr.GetString(1);
                    TagNotA.Items.Add(sub);
                    //string maID = "SELECT ID FROM academicDetails WHERE acYear ='" + year + "'And acSem ='" + sem + "'";
                }
            }
            catch (SQLiteException x)
            {
                CustomMessageBox.Show("Error!", "" + x.Message);
            }
        }

        public void FillMainGroup()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
            string qry = "SELECT * FROM mainGroupsDetails";
            sqlCom = new SQLiteCommand(qry, sqlCon);
            SQLiteDataReader sldr;

            try
            {
                sqlCon.Open();
                sldr = sqlCom.ExecuteReader();
                while (sldr.Read())
                {
                    string year = sldr.GetString(1);
                    string dname = sldr.GetString(2);
                    string gno = sldr.GetString(3);
                    mainGNotA.Items.Add(year + "." + dname + "." + gno);
                    //string maID = "SELECT ID FROM academicDetails WHERE acYear ='" + year + "'And acSem ='" + sem + "'";
                }
            }
            catch (SQLiteException x)
            {
                CustomMessageBox.Show("Error!", "" + x.Message);
            }

        }


        public void FillSubGroup()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
            string qry = "SELECT * FROM subGroupsDetails";
            sqlCom = new SQLiteCommand(qry, sqlCon);
            SQLiteDataReader sldr;

            try
            {
                sqlCon.Open();
                sldr = sqlCom.ExecuteReader();
                while (sldr.Read())
                {
                    string mg = sldr.GetString(1);
                    string sg = sldr.GetString(2);
                    subgNota.Items.Add(mg + "." + sg);
                    //string maID = "SELECT ID FROM academicDetails WHERE acYear ='" + year + "'And acSem ='" + sem + "'";
                }
            }
            catch (SQLiteException x)
            {
                CustomMessageBox.Show("Error!", "" + x.Message);
            }

        }

        private void backBtnD_Click(object sender, EventArgs e)
        {
            Details studentsUC = new Details();
            MainControler.showControl(studentsUC, parallelSetionPanel);
        }

        private void saveMG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(timeP.Text))
            {
                CustomMessageBox.Show("Time", "Please enter valid time slot.");
            }
            else if (string.IsNullOrWhiteSpace(dateP.Text))
            {
                CustomMessageBox.Show("Date", "Please enter valid Date.");
            }
            else if (string.IsNullOrWhiteSpace(durationP.Text))
            {
                CustomMessageBox.Show("Duration", "Please enter valid Duration.");
            }
            else if (LecNotA.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Lecturer", "Please Select Lecturer Name.");
            }
            else if (SubNotA.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Subject Name", "Please Select Subject Name.");
            }
            else if (TagNotA.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Tags", "Please Select Tag.");

            }
            else
            {
                ParallelSessionClass ps = new ParallelSessionClass();
                ps.time = timeP.Text;
                ps.date = dateP.Text;
                ps.duration = durationP.Text;
                ps.lec = LecNotA.Text;
                ps.sub = SubNotA.Text;
                ps.tag = TagNotA.Text;
                ps.mg = mainGNotA.Text;
                ps.sg = subgNota.Text;

                DB = new SQLiteDataAdapter("SELECT * FROM parellelSession WHERE time ='" + ps.time + "' AND date ='" + ps.date + "' AND duration ='" + ps.duration + "' AND lec ='" + ps.lec + "' AND subj ='" + ps.sub + "' AND tag ='" + ps.tag + "' AND mg ='" + ps.mg + "' AND sg ='" + ps.sg + "' ", sqlCon);
                dt = new DataTable();
                DB.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Parellel Sessions", "This not parellel sessionss are already saved.");
                }

                else
                {

                    try
                    {
                        sqlCon = new SQLiteConnection(connectString);
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"INSERT INTO parellelSession (time, date, duration, lec, subj, tag, mg, sg) VALUES(@time, @date, @duration, @lec, @subj, @tag, @mg, @sg)";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.Add(new SQLiteParameter("@time", ps.time));
                        sqlCom.Parameters.Add(new SQLiteParameter("@date", ps.date));
                        sqlCom.Parameters.Add(new SQLiteParameter("@duration", ps.duration));
                        sqlCom.Parameters.Add(new SQLiteParameter("@lec", ps.lec));
                        sqlCom.Parameters.Add(new SQLiteParameter("@subj", ps.sub));
                        sqlCom.Parameters.Add(new SQLiteParameter("@tag", ps.tag));
                        sqlCom.Parameters.Add(new SQLiteParameter("@mg", ps.mg));
                        sqlCom.Parameters.Add(new SQLiteParameter("@sg", ps.sg));

                        sqlCon.Open();

                        int i = sqlCom.ExecuteNonQuery();

                        if (i == 1)
                        {
                            CustomMessageBox.Show("Not Allocate Details", "This not allocated details are saved.");
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
