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
    public partial class MainGroupDetaisUC : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt;
        DataSet ds = new DataSet();
        private SQLiteDataAdapter DB;
        int id;
        bool isDoubleClick = false;
        String connectString;

        public MainGroupDetaisUC()
        {
            InitializeComponent();
            StyleDataGrid();
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            sqlCon = new SQLiteConnection(connectString);

        }

        private void MainGroupDetaisUC_Load(object sender, EventArgs e)
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
                String sql = "SELECT * FROM mainGroupsDetails";
                DB = new SQLiteDataAdapter(sql, sqlCon);
                ds.Reset();
                DB.Fill(ds);
                dt = ds.Tables[0];
                academicDataGrid.DataSource = dt;
                sqlCon.Close();
                academicDataGrid.Columns[0].Visible = false;
                academicDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                academicDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                academicDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                academicDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error!", "" + ex.Message);
            }
        }

        private void academicDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            MainGroupClass mgc = new MainGroupClass();
            mgc.MAcDetails = acsem.Text;
            mgc.MDegreeDetails = dname.Text;
            mgc.MDegreeDetails = gNo.Text;

            id = Convert.ToInt32(academicDataGrid.SelectedRows[0].Cells[0].Value);
            acsem.Text = academicDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            dname.Text = academicDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            gNo.Text = academicDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            isDoubleClick = true;

        }

        private void backBtnS_Click(object sender, EventArgs e)
        {
            DataViewUC dataViewUC = new DataViewUC();
            MainControler.showControl(dataViewUC, mGDetailsPanel);
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
        private void academicDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mGDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateDetailsBtn_Click_1(object sender, EventArgs e)
        {
            if (acsem.Text != "" && dname.Text != "" && gNo.Text != "")
            {
                if (isDoubleClick)
                {
                    MainGroupClass mg = new MainGroupClass();
                    mg.MAcDetails = acsem.Text;
                    mg.MDegreeDetails = dname.Text;
                    mg.MGroupNo = gNo.Text;

                    DB = new SQLiteDataAdapter("SELECT * FROM mainGroupsDetails WHERE macademicDetails ='" + mg.MAcDetails + "' AND mDegereeName ='" + mg.MDegreeDetails + "' AND mGroupNo ='" + mg.MGroupNo + "' ", sqlCon);
                    dt = new DataTable();
                    DB.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        CustomMessageBox.Show("Maing Groups", " " + mg.MAcDetails + "." + mg.MDegreeDetails + "." + mg.MGroupNo + " is already saved.");
                    }

                    else
                    {

                        try
                        {
                            sqlCon.Open();
                            sqlCom = new SQLiteCommand();
                            sqlCom.CommandText = @"UPDATE mainGroupsDetails set macademicDetails = @acdetails, mDegereeName = @mdegree, mGroupNo = @gno WHERE MID ='" + id + "'";
                            sqlCom.Connection = sqlCon;
                            sqlCom.Parameters.AddWithValue("@acdetails", mg.MAcDetails);
                            sqlCom.Parameters.AddWithValue("@mdegree", mg.MDegreeDetails);
                            sqlCom.Parameters.AddWithValue("@gno", mg.MGroupNo);

                            int i = sqlCom.ExecuteNonQuery();

                            if (i == 1)
                            {
                                CustomMessageBox.Show("Main Group Details", "" + mg.MAcDetails + "." + mg.MDegreeDetails + "." + mg.MGroupNo + " is updated.");

                                mg.MAcDetails = "";
                                mg.MDegreeDetails = "";
                                mg.MGroupNo = "";
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (acsem.Text != "" && dname.Text != "" && gNo.Text != "")

            {
                DialogResult dialogResult = MessageBox.Show("Do you to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        MainGroupClass mg = new MainGroupClass();
                        mg.MAcDetails = acsem.Text;
                        mg.MDegreeDetails = dname.Text;
                        mg.MGroupNo = gNo.Text;

                        sqlCon = new SQLiteConnection(connectString);
                        sqlCon.Open();
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"DELETE FROM mainGroupsDetails WHERE MID ='" + id + "'";
                        sqlCom.Connection = sqlCon;
                        int i = sqlCom.ExecuteNonQuery();
                        if (i == 1)
                        {
                            CustomMessageBox.Show("Main Group Details", "" + mg.MAcDetails + "." + mg.MDegreeDetails + "." + mg.MGroupNo + " is deleted successfully.");

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
