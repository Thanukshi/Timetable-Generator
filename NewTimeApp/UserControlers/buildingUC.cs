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
    public partial class buildingUC : UserControl
    {

        string con = "Data Source=LAPTOP-7RKTBVG9;Initial Catalog=NewTimeApp;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        string buildingID = "";

        public buildingUC()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(con);
            sqlCon.Open();
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
                MessageBox.Show("Enter Building Name !!!");
                buildingNameTB.Select();
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
                    sqlCom = new SqlCommand("buildDetail", sqlCon);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCom.Parameters.AddWithValue("@buildingID", buildingID);
                    sqlCom.Parameters.AddWithValue("@buildingName", buildingNameTB.Text);
                    int numRes = sqlCom.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Added Successfully !!!");
                        
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

        private void buildingNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
