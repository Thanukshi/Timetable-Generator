using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using NewTimeApp.Helpers;

namespace NewTimeApp.UserControlers
{
    public partial class TagUC : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt;
        private SQLiteDataAdapter DB;
        String path = Application.StartupPath + @"\Database\TimeAppDB.db";
        String connectString;

        public TagUC()
        {
            InitializeComponent();
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

        private void saveAcademic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tagname.Text))
            {
                CustomMessageBox.Show("Tags", "Please enter valid tag name.");
            }
            else
            {
                TagClass t = new TagClass();
                t.tags = tagname.Text;

                DB = new SQLiteDataAdapter("SELECT * FROM tags WHERE tags ='" + t.tags + "'", sqlCon);
                dt = new DataTable();
                DB.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Tag Name", "" + t.tags + " is already saved.");
                }
                else
                {

                    try
                    {
                        sqlCon = new SQLiteConnection(connectString);
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"INSERT INTO tags (tags) VALUES(@t)";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.Add(new SQLiteParameter("@t", t.tags));

                        sqlCon.Open();

                        int i = sqlCom.ExecuteNonQuery();

                        if (i == 1)
                        {
                            CustomMessageBox.Show("Tag Details", "" + t.tags + " is saved.");
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show("Error!", " " + ex.Message);
                    }
                }
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.ShowDialog();
            this.Hide();
        }

        private void ebtn_Click(object sender, EventArgs e)
        {
            TagEditUC dataViewUC = new TagEditUC();
            MainControler.showControl(dataViewUC, tagpanel1);

        }
    }
}
