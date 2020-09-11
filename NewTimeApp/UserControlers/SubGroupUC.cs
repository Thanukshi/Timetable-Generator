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

namespace NewTimeApp.UserControlers
{
    public partial class SubGroupUC : UserControl
    {
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        string subGroupID = "";

        public SubGroupUC()
        {
            InitializeComponent();
            fillMainGroup();

            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            sqlCon.Open();
        }

        public void fillMainGroup()
        {
            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            string qry = "SELECT * FROM MainGroup";
            sqlCom = new SqlCommand(qry, sqlCon);
            SqlDataReader sqlDataReader;

            try
            {
                sqlCon.Open();
                sqlDataReader = sqlCom.ExecuteReader();
                while (sqlDataReader.Read())
                {

                    string academic = sqlDataReader.GetString(1);
                    string degree = sqlDataReader.GetString(2);
                    string MainGroupNo = sqlDataReader.GetString(3);

                    mainGroupCombo.Items.Add(academic+"."+degree+"."+MainGroupNo);
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
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
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCom = new SqlCommand("abcSubGroupDetails", sqlCon);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCom.Parameters.AddWithValue("@SubID", subGroupID);
                    sqlCom.Parameters.AddWithValue("@MainGroupID", mainGroupCombo.Text);
                    sqlCom.Parameters.AddWithValue("@SubGroupNo", subGroupCombo.Text);
                   

                    int numRes = sqlCom.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Sub Group  ID is " + " " + mainGroupCombo.Text + ". " + subGroupCombo.Text + " is created successfully..");
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

        private void backBtnS_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, subPanel);
        }
    }
}
