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
using System.Data.SQLite;

namespace NewTimeApp.UserControlers
{
    public partial class showroomUC : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        private SQLiteDataAdapter DB;
        int id;
        bool isDoubleClick = false;
        String connectString;


        public showroomUC()
        {
            InitializeComponent();
            StyleDataGrid();
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            //connectString = @"Data Source = E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            locationUC locate = new locationUC();
            MainControler.showControl(locate, showRoomPanel);
        }

        void StyleDataGrid()
        {
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 190, 247);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            // buildingDGV.DefaultCellStyle.SelectionBackColor = Color.Plum;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 4, 45);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void showRoomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showroomUC_Load(object sender, EventArgs e)
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
                String sql = "SELECT * FROM roomDetails";
                DB = new SQLiteDataAdapter(sql, sqlCon);
                ds.Reset();
                DB.Fill(ds);
                dt = ds.Tables[0];
                dataGridView2.DataSource = dt;
                sqlCon.Close();
                /*academicDataGrid.Columns[1].HeaderText = "Firstname";
                academicDataGrid.Columns[2].HeaderText = "Lastname";
                academicDataGrid.Columns[3].HeaderText = "Address";*/
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                /*academicDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void roomAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void roomUpdatebtn_Click(object sender, EventArgs e)
        {
            /*if (UpbuildingName.Text != "")
            {
                if (isDoubleClick)
                {
                    AcademicDetailsClass academic = new AcademicDetailsClass();
                    academic.AcYear = acUpYear.Text;
                    academic.AcSEM = acUpSem.Text;

                    DB = new SQLiteDataAdapter("SELECT * FROM academicDetails WHERE acYear='" + academic.AcYear + "' AND acSem='" + academic.AcSEM + "'", sqlCon);
                    dt = new DataTable();
                    DB.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        CustomMessageBox.Show("Academic Details", "" + academic.AcYear + "." + academic.AcSEM + " is already saved. Can not be updated.");
                    }
                    else
                    {

                        try
                        {
                            if ((academic.AcYear == "Y1" || academic.AcYear == "Y2" || academic.AcYear == "Y3" || academic.AcYear == "Y4") && (academic.AcSEM == "S1" || academic.AcSEM == "S2"))
                            {
                                sqlCon.Open();
                                sqlCom = new SQLiteCommand();
                                sqlCom.CommandText = @"UPDATE academicDetails set acYear=@acyear, acSem=@acsem WHERE acID ='" + id + "'";
                                sqlCom.Connection = sqlCon;
                                sqlCom.Parameters.AddWithValue("@acyear", academic.AcYear);
                                sqlCom.Parameters.AddWithValue("@acsem", academic.AcSEM);
                            }

                            else
                            {
                                CustomMessageBox.Show("Error!", "Academic Year or Semester not in valid range.");
                            }

                            int i = sqlCom.ExecuteNonQuery();

                            if (i == 1)
                            {
                                CustomMessageBox.Show("Academic Details", "" + academic.AcYear + "." + academic.AcSEM + " is updated successfully.");
                                academic.AcYear = "";
                                academic.AcSEM = "";
                                ReadData();
                                id = 0;
                                academicDataGrid.ClearSelection();
                                academicDataGrid.CurrentCell = null;
                                isDoubleClick = false;
                            }

                            sqlCon.Close();
                        }
                        catch (Exception ex)
                        {
                            CustomMessageBox.Show("Error!", "" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("Error!", "Please Select Record to Update");
            }*/
        
    }

        /*private DataTable FetchRoomDetails()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCom = new SqlCommand("spRoomDetail", sqlCon);
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Parameters.AddWithValue("@ActionType", "FetchData");
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCom);
            sqlSda.Fill(dtData);
            return dtData;
        }*/

    }
}
