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
    public partial class MainGroupUC : UserControl
    {
        string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        string mainGroupID = "";

        public MainGroupUC()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(con);
            sqlCon.Open();
        }

        private void backBtnD_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, mgPanel);
        }

        private void acDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(con);
                sqlCon.Open();
                string qry = "SELECT acYear FROM AcademicDetails";
                SqlDataReader sqlDataReader = new SqlCommand(qry,sqlCon).ExecuteReader();
                while (sqlDataReader.Read())
                {
                    acDetails.Items.Add(sqlDataReader.GetValue(0).ToString());
                }
                sqlDataReader.Close();
            }catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
       
        }
    }
}
