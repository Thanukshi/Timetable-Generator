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
using System.Data.SQLite;

namespace NewTimeApp.UserControlers
{
    public partial class AcademicDetailsViewUC : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        private SQLiteDataAdapter DB;
        int id;
        bool isDoubleClick = false;
        String connectString;

        public AcademicDetailsViewUC()
        {
            InitializeComponent();
            StyleDataGrid();
            connectString = @"Data Source = E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
        }

        private void backBtnS_Click(object sender, EventArgs e)
        {
            DataViewUC dataViewUC = new DataViewUC();
            MainControler.showControl(dataViewUC, academicViewPanel);
        }

        private void academicViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        void StyleDataGrid()
        {
            academicDataGrid.BorderStyle = BorderStyle.None;
            academicDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 190, 247);
            academicDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            academicDataGrid.DefaultCellStyle.ForeColor = Color.Black;
            academicDataGrid.BackgroundColor = Color.White;

            academicDataGrid.EnableHeadersVisualStyles = false;
            academicDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            academicDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 4, 45);
            academicDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void AcademicDetailsViewUC_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void ReadData()
        {
            try
            {
                sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
                sqlCom = new SQLiteCommand();
                String sql = "SELECT * FROM academicDetails";
                DB = new SQLiteDataAdapter(sql, sqlCon);
                ds.Reset();
                DB.Fill(ds);
                dt = ds.Tables[0];
                academicDataGrid.DataSource = dt;
                sqlCon.Close();
                /*academicDataGrid.Columns[1].HeaderText = "Firstname";
                academicDataGrid.Columns[2].HeaderText = "Lastname";
                academicDataGrid.Columns[3].HeaderText = "Address";*/
                academicDataGrid.Columns[0].Visible = false;
                academicDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                academicDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                /*academicDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
                academicDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {

            if (acUpYear.Text != "" && acUpSem.Text != "")
            {
                if (isDoubleClick)
                {
                    try
                    {
                        sqlCon.Open();
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"UPDATE member set firstname=@firstname, lastname=@lastname, address=@address WHERE ID='" + id + "'";
                        sqlCom.Connection = sqlCon;
                        sqlCom.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                        sqlCom.Parameters.AddWithValue("@lastname", txt_lastname.Text);

                        int i = cmd.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Successfully Updated!");
                            txt_firstname.Text = "";
                            txt_lastname.Text = "";
                            txt_address.Text = "";
                            ReadData();
                            id = 0;
                            dataGridView1.ClearSelection();
                            dataGridView1.CurrentCell = null;
                            isDoubleClick = false;
                        }

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("Error!", "Please Select Record to Update");
            }
        }

        private void academicDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AcademicDetailsClass academic = new AcademicDetailsClass();
            academic.AcYear = acUpYear.Text;
            academic.AcSEM = acUpSem.Text;

            id = Convert.ToInt32(academicDataGrid.SelectedRows[0].Cells[0].Value);
            acUpYear.Text = academicDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            acUpSem.Text = academicDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            isDoubleClick = true;
        }
    }
}
