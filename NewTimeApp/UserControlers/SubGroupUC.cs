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

                }

        private void backBtnS_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, subPanel);
        }
    }
}
