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
        string con = "Data Source=LAPTOP-7RKTBVG9;Initial Catalog=NewTimeApp;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        string buildingId = "";

        public ShowBuildingUC()
        {
            InitializeComponent();
            StyleDataGrid();
            sqlCon = new SqlConnection(con);
            sqlCon.Open();

            buildingDGV.DataSource = FetchBuildingDetails();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            locationUC locate = new locationUC();
            MainControler.showControl(locate, showBuildingPanel);
                
        }

        void StyleDataGrid()
        {
            buildingDGV.BorderStyle = BorderStyle.None;
            buildingDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 190, 247);
            buildingDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            // buildingDGV.DefaultCellStyle.SelectionBackColor = Color.Plum;
            buildingDGV.DefaultCellStyle.ForeColor = Color.Black;
            buildingDGV.BackgroundColor = Color.White;

            buildingDGV.EnableHeadersVisualStyles = false;
            buildingDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            buildingDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 4, 45);
            buildingDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



        }

        private DataTable FetchBuildingDetails()
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
        }

    }
}
