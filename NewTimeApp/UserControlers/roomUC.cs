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

        public roomUC()
        {
            InitializeComponent();
            fillbuildingDetail();
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
            string con = "Data Source = LAPTOP - 7RKTBVG9; Initial Catalog = NewTimeApp; Integrated Security = True";
            sqlCon = new SqlConnection(con);
            string qry = "SELECT * FROM roomDetails";
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

        }

        private void buildingNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
