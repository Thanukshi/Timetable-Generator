﻿using System;
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
    public partial class DegreeDetailsView : UserControl
    {
        string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;

        public DegreeDetailsView()
        {
            InitializeComponent();
            StyleDataGrid();
            sqlCon = new SqlConnection(con);
            sqlCon.Open();


            academicDataGrid.AutoGenerateColumns = false;
            academicDataGrid.DataSource = FetchAcademicDetails();
        }

        private DataTable FetchAcademicDetails()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCom = new SqlCommand("abcDegreeProgram", sqlCon);
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Parameters.AddWithValue("@ActionType", "FetchData");
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCom);
            sqlSda.Fill(dtData);
            return dtData;
        }

        private void backBtnS_Click(object sender, EventArgs e)
        {
            DataViewUC dataViewUC = new DataViewUC();
            MainControler.showControl(dataViewUC, mainGroupDetailsPanel);
        }

        void StyleDataGrid()
        {
            academicDataGrid.BorderStyle = BorderStyle.None;
            academicDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 190, 247);
            academicDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            // academicDataGrid.DefaultCellStyle.SelectionBackColor = Color.Plum;
            academicDataGrid.DefaultCellStyle.ForeColor = Color.Black;
            academicDataGrid.BackgroundColor = Color.White;

            academicDataGrid.EnableHeadersVisualStyles = false;
            academicDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            academicDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 4, 45);
            academicDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                /*sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM DegreeDetails", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - direct method
                //academicDataGrid.AutoGenerateColumns = false;
                academicDataGrid.DataSource = dtbl;*/

            }
        }
    }
}