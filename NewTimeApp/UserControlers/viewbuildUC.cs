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
    public partial class viewbuildUC : UserControl
    {
        string con = "Data Source=LAPTOP-7RKTBVG9;Initial Catalog=NewTimeApp;Integrated Security=True";
        public viewbuildUC()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            locationUC locatUC = new locationUC();
            MainControler.showControl(locatUC, viewbuildpanel);
        }

        private void buldingAddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bildingDetails",sqlCon);
                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);

                buildingDGV.DataSource = (dataTable);
            }

        }
    }
}
