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
    public partial class DegreeProgramUC : UserControl
    {
        string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        string degreeID = "";

        public DegreeProgramUC()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(con);
            sqlCon.Open();
        }

        private void backBtnD_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, degreePanel);
        }

        private void saveDe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(programNameD.Text))
            {
                MessageBox.Show("Please Enter Valid Degree Program.", "Degree Program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(string.IsNullOrWhiteSpace(preferNameD.Text))
            {
                MessageBox.Show("Please Enter Valid Degree Program Short Name.", "Degree Program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    sqlCom = new SqlCommand("abcDegreeProgram", sqlCon);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCom.Parameters.AddWithValue("@DegreeID", degreeID);
                    sqlCom.Parameters.AddWithValue("@DegreeName", programNameD.Text);
                    sqlCom.Parameters.AddWithValue("@ShortDegreeName", preferNameD.Text);

                    int numRes = sqlCom.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Degree Program of" + " " + programNameD.Text + "." + " " + preferNameD.Text);
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
