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
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            //connectString = @"Data Source = E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
            academicDataGrid.AutoGenerateColumns = false;
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

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {

            if (acUpYear.Text != "" && acUpSem.Text != "")
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
                                sqlCom.CommandText = @"UPDATE academicDetails set acYear=@acyear, acSem=@acsem WHERE ID ='" + id + "'";
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

        private void dltBtn_Click(object sender, EventArgs e)
        {
            if (acUpYear.Text != "" && acUpSem.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //DialogResult dialogResult = CustomMessageBox.Show("Warning", "Do you to delete this record?", MessageBoxButtons.OK);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        AcademicDetailsClass academic = new AcademicDetailsClass();
                        academic.AcYear = acUpYear.Text;
                        academic.AcSEM = acUpSem.Text;

                        sqlCon = new SQLiteConnection(connectString);
                        sqlCon.Open();
                        sqlCom = new SQLiteCommand();
                        //id = Convert.ToInt32(academicDataGrid.SelectedRows[0].Cells[0].Value);
                        sqlCom.CommandText = @"DELETE FROM academicDetails WHERE ID ='" + id + "'";
                        sqlCom.Connection = sqlCon;
                        int i = sqlCom.ExecuteNonQuery();
                        if (i == 1)
                        {
                            CustomMessageBox.Show("Delete Data", "" + academic.AcYear + "." + academic.AcSEM + " is deleted successfully.");
                            id = 0;
                            academicDataGrid.ClearSelection();
                            academicDataGrid.CurrentCell = null;
                            ReadData();
                            academicDataGrid.ClearSelection();
                            academicDataGrid.CurrentCell = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show("Error!", "" + ex.Message);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                CustomMessageBox.Show("Error!", "Please Select Record to Delete");
            }
        }
    }
}
