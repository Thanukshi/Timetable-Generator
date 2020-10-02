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
    public partial class roomUC : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter DB;
        String connectString;

        public roomUC()
        {
            InitializeComponent();
            //fillbuildingDetail();
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
                string sql = "CREATE TABLE roomDetails(ID INTEGER PRIMARY KEY ASC AUTOINCREMENT, buildingName VARCHAR (50) NOT NULL, roomName VARCHAR (50) NOT NULL, roomType VARCHAR (20) NOT NULL, capasity INT.Parse(Console.ReadLine()) NOT NULL )";
                sqlCom = new SQLiteCommand(sql, sqlCon);
                sqlCom.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            locationUC locatUC = new locationUC();
            MainControler.showControl(locatUC, roompanel);
        }

        public void fillbuildingDetail()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString); 
            string sql = "SELECT * FROM buildingDetails";
            sqlCom = new SQLiteCommand(sql, sqlCon);
            SQLiteDataReader sqliteDataReader;

            try
            {
                sqlCon.Open();
                sqliteDataReader = sqlCom.ExecuteReader();
                while (sqliteDataReader.Read())
                {
                    string buildingName = sqliteDataReader.GetString(1);
                    buildingNameCB.Items.Add(buildingName);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("There is not already added buildings", " " + ex.Message);
            }
        }


        private void roomAddBtn_Click(object sender, EventArgs e)
        {
            if (buildingNameCB.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Building Name", "Please select Building name.");
            }
            else if (string.IsNullOrWhiteSpace(RoomNameTB.Text))
            {
                 CustomMessageBox.Show("Room Name", "Please  enter valid Room Name.");
            }
            else if (RoomTypeTB.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Room Type", "Please select Room Type.");
                
            }
            else if (capacityCB.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Capacity", "Please select capasity.");
                
            }
            else
            {
                RoomClass room = new RoomClass();
                    room.buildingName = buildingNameCB.Text;
                    room.roomName = RoomNameTB.Text;
                    room.roomType = RoomTypeTB.Text;
                    room.capasity = capacityCB.Text;

                DB = new SQLiteDataAdapter("SELECT * FROM roomDetails WHERE buildingName='" + room.buildingName + "' AND roomName='" + room.roomName + "' AND roomType='" + room.roomType + "'AND capasity='" + room.capasity + "'", sqlCon);
                dt = new DataTable();
                DB.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    CustomMessageBox.Show("Room Details", "" + room.roomName + " is already saved.");
                }
                else
                {

                    try
                    {
                        sqlCon = new SQLiteConnection(connectString);
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"INSERT INTO roomDetails (buildingName, roomName,roomType, capasity) VALUES(@buildingName, @roomName, @roomType, @capasity)";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.Add(new SQLiteParameter("@buildingName", room.buildingName));
                        sqlCom.Parameters.Add(new SQLiteParameter("@roomName", room.roomName));
                        sqlCom.Parameters.Add(new SQLiteParameter("@roomType", room.roomType));
                        sqlCom.Parameters.Add(new SQLiteParameter("@capasity", room.capasity));

                        sqlCon.Open();

                        int i = sqlCom.ExecuteNonQuery();

                        if (i == 1)
                        {
                            CustomMessageBox.Show("Room Details", "" + room.roomName + " is saved.");
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show("Error!", " " + ex.Message);
                    }
                }
            }
        }

        private void buildingNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void capacityCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
