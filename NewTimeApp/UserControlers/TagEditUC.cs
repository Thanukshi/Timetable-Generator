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
using System.Data.SQLite;

namespace NewTimeApp.UserControlers
{
    public partial class TagEditUC : UserControl
    {

        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt;
        DataSet ds = new DataSet();
        private SQLiteDataAdapter DB;
        int id;
        bool isDoubleClick = false;
        String connectString;
        public TagEditUC()
        {
            InitializeComponent();
            StyleDataGrid();
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            sqlCon = new SQLiteConnection(connectString);
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

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {
            if (tName.Text != "")
            {
                if (isDoubleClick)
                {
                    TagClass dp = new TagClass();
                    dp.tags = tName.Text;

                    DB = new SQLiteDataAdapter("SELECT * FROM tags WHERE tags='" + dp.tags + "'", sqlCon);
                    dt = new DataTable();
                    DB.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        CustomMessageBox.Show("Tags Details", "" + dp.tags + " tag is already saved.");

                    }
                    else
                    {

                        try
                        {
                            sqlCon.Open();
                            sqlCom = new SQLiteCommand();
                            sqlCom.CommandText = @"UPDATE tags set tags = @t WHERE TID ='" + id + "'";
                            sqlCom.Connection = sqlCon;
                            sqlCom.Parameters.AddWithValue("@t", dp.tags);

                            int i = sqlCom.ExecuteNonQuery();

                            if (i == 1)
                            {
                                CustomMessageBox.Show("Tags Details", "" + dp.tags + " is updated successfully.");
                                dp.tags = "";
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


        private void backBtnS_Click(object sender, EventArgs e)
        {
            TagUC dataViewUC = new TagUC();
            MainControler.showControl(dataViewUC, tpanel);
        }

        private void TagEditUC_Load(object sender, EventArgs e)
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
                String sql = "SELECT * FROM tags";
                DB = new SQLiteDataAdapter(sql, sqlCon);
                ds.Reset();
                DB.Fill(ds);
                dt = ds.Tables[0];
                academicDataGrid.DataSource = dt;
                sqlCon.Close();
                academicDataGrid.Columns[0].Visible = false;
                academicDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                academicDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error!", "" + ex.Message);
            }
        }

        private void academicDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TagClass dp = new TagClass();
            dp.tags = tName.Text;

            id = Convert.ToInt32(academicDataGrid.SelectedRows[0].Cells[0].Value);
            tName.Text = academicDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            isDoubleClick = true;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (tName.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //DialogResult dialogResult = CustomMessageBox.Show("Warning", "Do you to delete this record?", MessageBoxButtons.OK);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        TagClass dp = new TagClass();
                        dp.tags = tName.Text;
                        /*AcademicDetailsClass academic = new AcademicDetailsClass();
                        academic.AcYear = acUpYear.Text;
                        academic.AcSEM = acUpSem.Text;*/

                        sqlCon = new SQLiteConnection(connectString);
                        sqlCon.Open();
                        sqlCom = new SQLiteCommand();
                        //id = Convert.ToInt32(academicDataGrid.SelectedRows[0].Cells[0].Value);
                        sqlCom.CommandText = @"DELETE FROM tags WHERE TID ='" + id + "'";
                        sqlCom.Connection = sqlCon;
                        int i = sqlCom.ExecuteNonQuery();
                        if (i == 1)
                        {
                            CustomMessageBox.Show("Delete Tag", "" + dp.tags + " tag is deleted successfully.");
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
