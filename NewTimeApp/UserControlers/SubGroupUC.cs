using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NewTimeApp.Helpers;
using System.Data.SQLite;

namespace NewTimeApp.UserControlers
{
    public partial class SubGroupUC : UserControl
    {

        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter DB;
        String connectString;

        public SubGroupUC()
        {
            InitializeComponent();
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            sqlCon = new SQLiteConnection(connectString);
            GenerateDatabase();
            fillMainGroup();


        }

        public void GenerateDatabase()
        {
            sqlCon = new SQLiteConnection(connectString);
            sqlCon.Open();
        }

        public void fillMainGroup()
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
                    mainGroupCombo.Items.Add(year + "." + dname + "." + gno);
                    //string maID = "SELECT ID FROM academicDetails WHERE acYear ='" + year + "'And acSem ='" + sem + "'";
                }
            }
            catch (SQLiteException x)
            {
                CustomMessageBox.Show("Error!", "" + x.Message);
            }

        }

        private void saveSG_Click(object sender, EventArgs e)
        {
            if (mainGroupCombo.SelectedIndex <= -1)
            {
                MessageBox.Show("Please Select Main Group ID.", "Main Group ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (subGroupCombo.SelectedIndex <= -1)
            {
                MessageBox.Show("Please Select Sub Group Number.", "Sub Group Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SubGroupClass sg = new SubGroupClass();
                sg.mid = mainGroupCombo.Text;
                sg.sno = subGroupCombo.Text;

                DB = new SQLiteDataAdapter("SELECT * FROM subGroupsDetails WHERE MID ='" + sg.mid + "' AND SNO ='" + sg.sno + "' ", sqlCon);
                dt = new DataTable();
                DB.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Sub Group", " " + sg.mid + "." + sg.sno + " is already saved.");
                }

                else
                {

                    try
                    {
                        sqlCon = new SQLiteConnection(connectString);
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"INSERT INTO subGroupsDetails (MID, SNO) VALUES(@mid, @sid)";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.Add(new SQLiteParameter("@mid", sg.mid));
                        sqlCom.Parameters.Add(new SQLiteParameter("@sid", sg.sno));

                        sqlCon.Open();

                        int i = sqlCom.ExecuteNonQuery();

                        if (i == 1)
                        {
                            CustomMessageBox.Show("Sub Group Details", "" + sg.mid + "." + sg.sno + " is generated.");
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show("Error!", " " + ex.Message);
                    }
                }
            }
        }

        private void backBtnS_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, subPanel);
        }
    }
}
