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
    public partial class SubGroupDetailsUC : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt;
        DataSet ds = new DataSet();
        private SQLiteDataAdapter DB;
        int id;
        bool isDoubleClick = false;
        String connectString;

        public SubGroupDetailsUC()
        {

            InitializeComponent();
            StyleDataGrid();

            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            sqlCon = new SQLiteConnection(connectString);
        }
        private void SubGroupDetailsUC_Load(object sender, EventArgs e)
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
                String sql = "SELECT * FROM subGroupsDetails";
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
            MainControler.showControl(dataViewUC, SGDetailsPanel);
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

        private void academicDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SubGroupClass sg = new SubGroupClass();
            sg.mid = mGroup.Text;
            sg.sno = sNo.Text;

            id = Convert.ToInt32(academicDataGrid.SelectedRows[0].Cells[0].Value);
            mGroup.Text = academicDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            sNo.Text = academicDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            isDoubleClick = true;
        }

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {
            if (mGroup.Text != "" && sNo.Text != "")
            {
                if (isDoubleClick)
                {
                    SubGroupClass sg = new SubGroupClass();
                    sg.mid = mGroup.Text;
                    sg.sno = sNo.Text;

                    DB = new SQLiteDataAdapter("SELECT * FROM subGroupsDetails WHERE MID ='" + sg.mid + "' AND SNO ='" + sg.sno + "' ", sqlCon);
                    dt = new DataTable();
                    DB.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        CustomMessageBox.Show("Sub Groups", " " + sg.mid + "." + sg.sno + " is already saved.");
                    }

                    else
                    {

                        try
                        {
                            sqlCon.Open();
                            sqlCom = new SQLiteCommand();
                            sqlCom.CommandText = @"UPDATE subGroupsDetails set MID = @mid, SNO = @sno WHERE SID ='" + id + "'";
                            sqlCom.Connection = sqlCon;
                            sqlCom.Parameters.AddWithValue("@mid", sg.mid);
                            sqlCom.Parameters.AddWithValue("@sno", sg.sno);

                            int i = sqlCom.ExecuteNonQuery();

                            if (i == 1)
                            {
                                CustomMessageBox.Show("Sub Group Details", "" + sg.mid + "." + sg.sno + " is updated.");

                                sg.mid = "";
                                sg.sno = "";
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

        private void deltbtn_Click(object sender, EventArgs e)
        {
            if (mGroup.Text != "" && sNo.Text != "")

            {
                DialogResult dialogResult = MessageBox.Show("Do you to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        SubGroupClass sg = new SubGroupClass();
                        sg.mid = mGroup.Text;
                        sg.sno = sNo.Text;

                        sqlCon = new SQLiteConnection(connectString);
                        sqlCon.Open();
                        sqlCom = new SQLiteCommand();
                        sqlCom.CommandText = @"DELETE FROM subGroupsDetails WHERE SID ='" + id + "'";
                        sqlCom.Connection = sqlCon;
                        int i = sqlCom.ExecuteNonQuery();
                        if (i == 1)
                        {
                            CustomMessageBox.Show("Sub Group Details", "" + sg.mid + "." + sg.sno + " is deleted successfully.");

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
