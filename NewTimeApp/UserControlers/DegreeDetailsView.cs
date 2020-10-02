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
    public partial class DegreeDetailsView : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt, dtm, dtf, dts;
        DataSet ds = new DataSet();
        private SQLiteDataAdapter DB, DBM, DBF, DBS;
        int id;
        bool isDoubleClick = false;
        String connectString;

        public DegreeDetailsView()
        {
            InitializeComponent();
            StyleDataGrid();
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            //connectString = @"Data Source = E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);

        }

        private void DegreeDetailsView_Load(object sender, EventArgs e)
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
                String sql = "SELECT * FROM degreeProgram";
                DB = new SQLiteDataAdapter(sql, sqlCon);
                ds.Reset();
                DB.Fill(ds);
                dt = ds.Tables[0];
                academicDataGrid.DataSource = dt;
                sqlCon.Close();
                academicDataGrid.Columns[0].Visible = false;
                academicDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                academicDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                academicDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error!", "" + ex.Message);
            }
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
            if (dFullName.Text != "" && dShortName.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //DialogResult dialogResult = CustomMessageBox.Show("Warning", "Do you to delete this record?", MessageBoxButtons.OK);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        DegreeProgramClass dp = new DegreeProgramClass();
                        dp.DegreeFullName = dFullName.Text;
                        dp.DegreeShortName = dShortName.Text;
                        /*AcademicDetailsClass academic = new AcademicDetailsClass();
                        academic.AcYear = acUpYear.Text;
                        academic.AcSEM = acUpSem.Text;*/

                        sqlCon = new SQLiteConnection(connectString);
                        sqlCon.Open();
                        sqlCom = new SQLiteCommand();
                        //id = Convert.ToInt32(academicDataGrid.SelectedRows[0].Cells[0].Value);
                        sqlCom.CommandText = @"DELETE FROM degreeProgram WHERE degreeID ='" + id + "'";
                        sqlCom.Connection = sqlCon;
                        int i = sqlCom.ExecuteNonQuery();
                        if (i == 1)
                        {
                            CustomMessageBox.Show("Delete Data", "" + dp.DegreeFullName + "and" + dp.DegreeShortName + " is deleted successfully.");
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

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {
            if (dFullName.Text != "" && dShortName.Text != "")
            {
                if (isDoubleClick)
                {
                    DegreeProgramClass dp = new DegreeProgramClass();
                    dp.DegreeFullName = dFullName.Text;
                    dp.DegreeShortName = dShortName.Text;

                    DBM = new SQLiteDataAdapter("SELECT * FROM degreeProgram WHERE degreeName='" + dp.DegreeFullName + "' AND degreeShortName ='" + dp.DegreeShortName + "'", sqlCon);
                    dtm = new DataTable();
                    DBM.Fill(dtm);

                    DBF = new SQLiteDataAdapter("SELECT degreeName FROM degreeProgram WHERE degreeName ='" + dp.DegreeFullName + "'", sqlCon);
                    dtf = new DataTable();
                    DBF.Fill(dtf);

                    DBS = new SQLiteDataAdapter("SELECT degreeShortName FROM degreeProgram WHERE degreeShortName='" + dp.DegreeShortName + "'", sqlCon);
                    dts = new DataTable();
                    DBS.Fill(dts);

                    if (dtm.Rows.Count >= 1)
                    {
                        CustomMessageBox.Show("Degree Details", "" + dp.DegreeFullName + " " + dp.DegreeShortName + " is already saved. Can not be updated.");
                    }
                    else if (dtf.Rows.Count >= 1)
                    {
                        CustomMessageBox.Show("Degree Program Full Name", "" + dp.DegreeFullName + " is already saved.");
                    }
                    else if (dts.Rows.Count >= 1)
                    {

                        CustomMessageBox.Show("Degree Program Short Name", "" + dp.DegreeShortName + " is already saved.");
                    }
                    else
                    {

                        try
                        {
                            sqlCon.Open();
                            sqlCom = new SQLiteCommand();
                            sqlCom.CommandText = @"UPDATE degreeProgram set degreeName = @degreename, degreeShortName = @degreeshortname WHERE degreeID ='" + id + "'";
                            sqlCom.Connection = sqlCon;
                            sqlCom.Parameters.AddWithValue("@degreename", dp.DegreeFullName);
                            sqlCom.Parameters.AddWithValue("@degreeshortname", dp.DegreeShortName);

                            int i = sqlCom.ExecuteNonQuery();

                            if (i == 1)
                            {
                                CustomMessageBox.Show("Degree Details", "" + dp.DegreeFullName + " and " + dp.DegreeShortName + " is updated successfully.");
                                dp.DegreeFullName = "";
                                dp.DegreeShortName = "";
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
            DegreeProgramClass dp = new DegreeProgramClass();
            dp.DegreeFullName = dFullName.Text;
            dp.DegreeShortName = dShortName.Text;

            id = Convert.ToInt32(academicDataGrid.SelectedRows[0].Cells[0].Value);
            dFullName.Text = academicDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            dShortName.Text = academicDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            isDoubleClick = true;
        }
    }
}
