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

namespace NewTimeApp.UserControlers
{
    public partial class roomUC : UserControl
    {
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        string roomID = "";

        public roomUC()
        {
            InitializeComponent();
            fillbuildingDetail();
            
            sqlCon.Open();
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
            string con = "Data Source=LAPTOP-7RKTBVG9;Initial Catalog=NewTimeApp;Integrated Security=True"; 
            sqlCon = new SqlConnection(con);
            string qry = "SELECT * FROM buildingDetails";
            sqlCom = new SqlCommand(qry, sqlCon);
            SqlDataReader sqlDataReader;

            try
            {
                sqlCon.Open();
                sqlDataReader = sqlCom.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string buildingName = sqlDataReader.GetString(1);
                    buildingNameCB.Items.Add(buildingName);
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }


        private void roomAddBtn_Click(object sender, EventArgs e)
        {
            if (buildingNameCB.SelectedIndex <= -1)
            {
                MessageBox.Show("Select Building Name !!!");
                buildingNameCB.Select();
            }
            else if (string.IsNullOrWhiteSpace(RoomNameTB.Text))
            {
                MessageBox.Show("Enter Room Name !!!");
                RoomNameTB.Select();
            }
            else if (RoomTypeTB.SelectedIndex <= -1)
            {
                MessageBox.Show("Select Room Type !!!");
                RoomTypeTB.Select();
            }
            else if (capacityCB.SelectedIndex <= -1)
            {
                MessageBox.Show("Select Room Capacity !!!");
                capacityCB.Select();
            }
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCom = new SqlCommand("spRoomDetail", sqlCon);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCom.Parameters.AddWithValue("@roomID", roomID);
                    sqlCom.Parameters.AddWithValue("@buildingName", buildingNameCB.Text);
                    sqlCom.Parameters.AddWithValue("@roomName", RoomNameTB.Text);
                    sqlCom.Parameters.AddWithValue("@roomType", RoomNameTB.Text);
                    sqlCom.Parameters.AddWithValue("@capacity", capacityCB.Text);
                    int numRes = sqlCom.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Saved Successfully !!!");
                   
                    }
                    else
                        MessageBox.Show("Please Try Again !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }

        private void buildingNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
