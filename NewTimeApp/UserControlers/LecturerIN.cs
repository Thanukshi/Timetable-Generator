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
    public partial class LecturerIN : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter DB;
        String connectString;

        public LecturerIN()
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
                string sql = "CREATE TABLE LecturerDetails (ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, nametb VARCHAR (50) NOT NULL, empidtb  VARCHAR (10) NOT NULL,facultycb VARCHAR (50) NOT NULL,deptb VARCHAR (50) NOT NULL,centercb VARCHAR (50) NOT NULL," +
                    "buildingcb VARCHAR (50) NOT NULL,categorycb VARCHAR (50) NOT NULL,levelcb VARCHAR (50) NOT NULL,ranktb VARCHAR (50) NOT NULL)";
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
        //private void Insertlecpanel_Paint(object sender, PaintEventArgs e)
        //{
        //   try
        //    {
        //        client = new FireSharp.FirebaseClient(fcon);

        //    }
        //    catch
        //    {
        //        MessageBox.Show("There was problem in Internet.");
        //    }
        //}

        private void buttonaddlec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametb.Text))
            {
                CustomMessageBox.Show("Name", "Please enter Name.");
            }
            else if (string.IsNullOrWhiteSpace(empidtb.Text))
            {
                CustomMessageBox.Show("Employee Id", "Please enter Employee Id.");
            }
            else if (facultycb.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Faculty", "Please select Faculty.");
            }
            else if (string.IsNullOrWhiteSpace(deptb.Text))
            {
                CustomMessageBox.Show("Department", "Please enter Department.");
            }
            else if (centercb.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Center", "Please select Semester.");
            }
            else if (buildingcb.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Building", "Please select Building.");
            }
            else if (categorycb.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Category", "Please select Category.");
            }
            else if (levelcb.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Level", "Please select Level.");
            }
            else if (string.IsNullOrWhiteSpace(ranktb.Text))
            {
                CustomMessageBox.Show("Rank", "Please enter Rank.");
            }

            else
            {
                ClassLec dpc = new ClassLec();
                dpc.Name = nametb.Text;
                dpc.EmployeeId = empidtb.Text;
                dpc.Faculty = facultycb.Text;
                dpc.Department = deptb.Text;
                dpc.Center = centercb.Text;
                dpc.Building = buildingcb.Text;
                dpc.Category = categorycb.Text;
                dpc.Level = levelcb.Text;
                dpc.Rank = ranktb.Text;

                DB = new SQLiteDataAdapter("SELECT * FROM LecturerDetails WHERE nametb='" + dpc.Name + "' AND empidtb='" + dpc.EmployeeId + "' AND facultycb='" + dpc.Faculty + "' AND deptb='" + dpc.Department + "' AND centercb='" + dpc.Center + "' AND buildingcb='" + dpc.Building + "' AND categorycb='" + dpc.Category + "' AND levelcb='" + dpc.Level + "' AND ranktb='" + dpc.Rank + "'", sqlCon);
                dt = new DataTable();
                DB.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Lecturer Details", "" + dpc.Name + "." + dpc.EmployeeId + "." + dpc.Faculty + "." + dpc.Department + "." + dpc.Center + "." + dpc.Building + "." + dpc.Category + "." + dpc.Level + "." + dpc.Rank + " is already saved.");
                }
                else
                {





                    try
                    {
                        sqlCon = new SQLiteConnection(connectString);
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"INSERT INTO LecturerDetails (nametb,empidtb,facultycb,deptb,centercb,buildingcb,categorycb,levelcb,ranktb) VALUES(@nametb,@empidtb,@facultycb,@deptb,@centercb,@buildingcb,@categorycb,@levelcb,@ranktb)";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.Add(new SQLiteParameter("@nametb", dpc.Name));
                        sqlCom.Parameters.Add(new SQLiteParameter("@empidtb", dpc.EmployeeId));
                        sqlCom.Parameters.Add(new SQLiteParameter("@facultycb", dpc.Faculty));
                        sqlCom.Parameters.Add(new SQLiteParameter("@deptb", dpc.Department));
                        sqlCom.Parameters.Add(new SQLiteParameter("@centercb", dpc.Center));
                        sqlCom.Parameters.Add(new SQLiteParameter("@buildingcb", dpc.Building));
                        sqlCom.Parameters.Add(new SQLiteParameter("@categorycb", dpc.Category));
                        sqlCom.Parameters.Add(new SQLiteParameter("@levelcb", dpc.Level));
                        sqlCom.Parameters.Add(new SQLiteParameter("@ranktb", dpc.Rank));

                        sqlCon.Open();

                        int i = sqlCom.ExecuteNonQuery();

                        if (i == 1)
                        {

                            CustomMessageBox.Show("Academic Details", "Sucessfully Added.");
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show("Error!", " " + ex.Message);
                    }
                }
            }

            //    ClassLec lec = new ClassLec()
            //    {
            //        Name = nametb.Text,
            //        EmployeeId = empidtb.Text,
            //        Faculty = facultycb.Text,
            //        Department = deptb.Text,
            //        Center = centercb.Text,
            //        Building = buildingcb.Text,
            //        Category = categorycb.Text,
            //        Level = levelcb.Text,
            //        Rank = ranktb.Text

            //    };

            //    var setter = client.Set("lecturerList/"+empidtb.Text, lec);
            //    MessageBox.Show("Data inserted Successfully");

        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonselectlec_Click(object sender, EventArgs e)
        {
            //var result = client.Get("lecturerList/" + empidtb.Text);
            //ClassLec lec = result.ResultAs<ClassLec>();
            //nametb.Text = lec.Name;
            //empidtb.Text = lec.EmployeeId;
            //facultycb.Text = lec.Faculty;
            //deptb.Text = lec.Department;
            //centercb.Text = lec.Center;
            //buildingcb.Text = lec.Building;
            //categorycb.Text = lec.Category;
            //levelcb.Text = lec.Level;
            //ranktb.Text = lec.Rank;
            //MessageBox.Show("Data Rectrived Successfully");
        }

        private void buttonupdatelec_Click(object sender, EventArgs e)
        {
            //ClassLec lec = new ClassLec()
            //{
            //    Name = nametb.Text,
            //    EmployeeId = empidtb.Text,
            //    Faculty = facultycb.Text,
            //    Department = deptb.Text,
            //    Center = centercb.Text,
            //    Building = buildingcb.Text,
            //    Category = categorycb.Text,
            //    Level = levelcb.Text,
            //    Rank = ranktb.Text

            //};
            //var setter = client.Update("lecturerList/" + empidtb.Text, lec);
            //MessageBox.Show("Data Updated Successfully");
        }

        private void buttondeletelec_Click(object sender, EventArgs e)
        {
            //var setter = client.Delete("lecturerList/" + empidtb.Text);
            //MessageBox.Show("Data Deleted Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void lecturer_Click(object sender, EventArgs e)
        {

        }

        private void Insertlecpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}