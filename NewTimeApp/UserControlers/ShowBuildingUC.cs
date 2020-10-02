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
    public partial class ShowBuildingUC : UserControl
    {
        //string con = "Data Source=LAPTOP-7RKTBVG9;Initial Catalog=NewTimeApp;Integrated Security=True";
        //SqlConnection sqlCon;
        //SqlCommand sqlCom;
        //string buildingId = "";

        public ShowBuildingUC()
        {
            InitializeComponent();
            StyleDataGrid();
            //sqlCon = new SqlConnection(con);
            //sqlCon.Open();

            dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = FetchBuildingDetails();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            locationUC locate = new locationUC();
            MainControler.showControl(locate, showBuildingPanel);
                
        }

        void StyleDataGrid()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 190, 247);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            // buildingDGV.DefaultCellStyle.SelectionBackColor = Color.Plum;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 4, 45);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



        }

        /*private DataTable FetchBuildingDetails()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCom = new SqlCommand("buildDetail", sqlCon);
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Parameters.AddWithValue("@ActionType", "FetchData");
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCom);
            sqlSda.Fill(dtData);
            return dtData;
        }*/

        private void showbuildingBtn_Click(object sender, EventArgs e)
        {

        }

        private void showBuildingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
