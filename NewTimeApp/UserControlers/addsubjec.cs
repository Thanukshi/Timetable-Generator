using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Security.Authentication;
using System.Data.SQLite;
using System.IO;

namespace NewTimeApp.UserControlers
{
    public partial class addsubjec : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter DB;
        String connectString;
        public addsubjec()
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
                string sql = "CREATE TABLE SubjectDetails (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, year VARCHAR (50) NOT NULL, semester  VARCHAR (10) NOT NULL,subname VARCHAR (50) NOT NULL,code VARCHAR (50) NOT NULL,lech VARCHAR (50) NOT NULL," +
                    "tute VARCHAR (50) NOT NULL,lab VARCHAR (50) NOT NULL,evaluation VARCHAR (50) NOT NULL)";
                sqlCom = new SQLiteCommand(sql, sqlCon);
                sqlCom.ExecuteNonQuery();
                sqlCon.Close();
            }
        }
        //IFirebaseConfig fcon = new FirebaseConfig()
        //{
        //    AuthSecret = "Onj8rh37hQONO2YXC0YncZnUy6kbXHBtxK9uCoTx",
        //    BasePath = "https://timetableapp-12161.firebaseio.com/"
        //};
        //IFirebaseClient client;
        //private void panelsubject_Paint(object sender, PaintEventArgs e)
        //{
        //    try
        //    {
        //        client = new FireSharp.FirebaseClient(fcon);

        //    }
        //    catch
        //    {
        //        MessageBox.Show("There was problem in Internet.");
        //    }

        //}

        private void buttonaddsubject_Click(object sender, EventArgs e)
        {
            if (year.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Year", "Please select Year.");
            }
            else if (semester.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Semester", "Please select Semester.");
            }
            else if (string.IsNullOrWhiteSpace(subname.Text))
            {
                CustomMessageBox.Show("Subject Name", "Please enter Subject Name.");
            }
            else if (string.IsNullOrWhiteSpace(code.Text))
            {
                CustomMessageBox.Show("Code", "Please enter Code.");
            }
            else if (string.IsNullOrWhiteSpace(lech.Text))
            {
                CustomMessageBox.Show("Lecture hours", "Please enter Lecture hours.");
            }
            else if (string.IsNullOrWhiteSpace(tute.Text))
            {
                CustomMessageBox.Show("Tute hours", "Please enter Tute hours.");
            }
            else if (string.IsNullOrWhiteSpace(lab.Text))
            {
                CustomMessageBox.Show("Lab hours", "Please enter lab hours.");
            }
            else if (string.IsNullOrWhiteSpace(evaluation.Text))
            {
                CustomMessageBox.Show("Evaluation hours", "Please enter evaluation hours.");
            }
            else
            {
                Classsub lc = new Classsub();
                lc.Offeredyear = year.Text;
                lc.Offeredsemester = semester.Text;
                lc.SubjectName = subname.Text;
                lc.SubjectCode = code.Text;
                lc.LecHours = lech.Text;
                lc.TuteHours = tute.Text;
                lc.LabHours = lab.Text;
                lc.EvaluationHours = evaluation.Text;
                DB = new SQLiteDataAdapter("SELECT * FROM SubjectDetails WHERE year='" + lc.Offeredyear + "' AND semester='" + lc.Offeredsemester + "' AND subname='" + lc.SubjectName + "' AND code='" + lc.SubjectCode + "' AND lech='" + lc.LecHours + "' AND tute='" + lc.TuteHours + "' AND lab='" + lc.LabHours + "' AND evaluation='" + lc.EvaluationHours + "'", sqlCon);
                dt = new DataTable();
                DB.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Subject Details", "" + lc.Offeredyear + "." + lc.Offeredsemester + "." + lc.SubjectName + "." + lc.SubjectCode + "." + lc.LecHours + "." + lc.TuteHours + "." + lc.LabHours + "." + lc.EvaluationHours + " is already saved.");
                }
                else
                {





                    try
                    {
                        sqlCon = new SQLiteConnection(connectString);
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"INSERT INTO SubjectDetails(year,semester,subname,code,lech,tute,lab,evaluation) VALUES(@year,@semester,@subname,@code,@lech,@tute,@lab,@evaluation)";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.Add(new SQLiteParameter("@year", lc.Offeredyear));
                        sqlCom.Parameters.Add(new SQLiteParameter("@semester", lc.Offeredsemester));
                        sqlCom.Parameters.Add(new SQLiteParameter("@subname", lc.SubjectName));
                        sqlCom.Parameters.Add(new SQLiteParameter("@code", lc.SubjectCode));
                        sqlCom.Parameters.Add(new SQLiteParameter("@lech", lc.LecHours));
                        sqlCom.Parameters.Add(new SQLiteParameter("@tute", lc.TuteHours));
                        sqlCom.Parameters.Add(new SQLiteParameter("@lab", lc.LabHours));
                        sqlCom.Parameters.Add(new SQLiteParameter("@evaluation", lc.EvaluationHours));

                        sqlCon.Open();

                        int i = sqlCom.ExecuteNonQuery();

                        if (i == 1)
                        {

                            CustomMessageBox.Show("Subject Details", " Sucessfully Added.");
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show("Error!", " " + ex.Message);
                    }
                }
            }
            //    Classsub sub = new Classsub()
            //    {
            //        Offeredyear = year.Text,
            //        Offeredsemester = semester.Text,
            //        SubjectName = subname.Text,
            //        SubjectCode = code.Text,
            //        LecHours = lech.Text,
            //        TuteHours = tute.Text,
            //        LabHours = lab.Text,
            //        EvaluationHours = evaluation.Text


            //    };
            //    var setter = client.Set("Subjectlist/" + Offeredyear.Text, sub);
            //    MessageBox.Show("Data inserted Successfully");

        }

        private void buttonselectsubject_Click(object sender, EventArgs e)
        {
            //var result = client.Get("Subjectlist/" + Offeredyear.Text);
            //Classsub sub = result.ResultAs<Classsub>();
            //year.Text = sub.Offeredyear;
            //semester.Text = sub.Offeredsemester;
            //subname.Text = sub.SubjectName;
            //code.Text = sub.SubjectCode;
            //lech.Text = sub.LecHours;
            //tute.Text = sub.TuteHours;
            //lab.Text = sub.LabHours;
            //evaluation.Text = sub.EvaluationHours;
            //MessageBox.Show("Data Rectrived Successfully");
        }

        private void buttonupdatesubject_Click(object sender, EventArgs e)
        {
            //Classsub sub = new Classsub()
            //{
            //    Offeredyear = year.Text,
            //    Offeredsemester = semester.Text,
            //    SubjectName = subname.Text,
            //    SubjectCode = code.Text,
            //    LecHours = lech.Text,
            //    TuteHours = tute.Text,
            //    LabHours = lab.Text,
            //    EvaluationHours = evaluation.Text


            //};
            //var setter = client.Update("Subjectlist/" +Offeredyear.Text, sub);
            //MessageBox.Show("Data Updated Successfully");
        }

        private void buttondeletesubject_Click(object sender, EventArgs e)
        {

        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelsubject_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
