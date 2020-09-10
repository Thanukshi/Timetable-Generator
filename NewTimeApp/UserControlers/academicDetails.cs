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
    public partial class academicDetails : UserControl
    {

        string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        string acedemicID = "";

        public academicDetails()
        {
            InitializeComponent();
            sqlCon = new SqlConnection();
            sqlCon.Open();
        }

        private void academicDetails_Load(object sender, EventArgs e)
        {


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, acPanel);
        }

        private void saveAcc_Click(object sender, EventArgs e)
        {
            if(acYear.SelectedIndex <= -1)
            {
                MessageBox.Show("Select Academic Year.");
            }
            else if(acSem.SelectedIndex <= -1)
            {
                MessageBox.Show("Select Academic Semester.");
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
                    sqlCom = new SqlCommand("abcAcademicDetails", sqlCon);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCom.Parameters.AddWithValue("@AcademicId", acedemicID);
                    sqlCom.Parameters.AddWithValue("@@AcademicYear", acYear.Text);
                    sqlCom.Parameters.AddWithValue("@@AcademicSemester", acSem.Text);
        
                    int numRes = sqlCom.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Academic Year and Semester is " + " " + acYear.Text + "." + " " + acSem.Text);
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
    }
}
