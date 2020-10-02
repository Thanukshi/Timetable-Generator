using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using NewTimeApp.Helpers;

namespace NewTimeApp.UserControlers
{
    public partial class veiwlecturer : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        private SQLiteDataAdapter DB;
        int id;
        bool isDoubleClick = false;
        String connectString;
        public veiwlecturer()
        {
            InitializeComponent();
            StyleDataGrid();
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            //connectString = @"Data Source = E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
        }

        void StyleDataGrid()
        {
            lecdetDataGrid.BorderStyle = BorderStyle.None;
            lecdetDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 190, 247);
            lecdetDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            lecdetDataGrid.DefaultCellStyle.ForeColor = Color.Black;
            lecdetDataGrid.BackgroundColor = Color.White;

            lecdetDataGrid.EnableHeadersVisualStyles = false;
            lecdetDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lecdetDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 4, 45);
            lecdetDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttondeletes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lecdetDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panelviewlec_Paint(object sender, PaintEventArgs e)
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
                String sql = "SELECT * FROM LecturerDetails";
                DB = new SQLiteDataAdapter(sql, sqlCon);
                ds.Reset();
                DB.Fill(ds);
                dt = ds.Tables[0];
                lecdetDataGrid.DataSource = dt;
                sqlCon.Close();
               
                lecdetDataGrid.Columns[0].Visible = false;
                lecdetDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lecdetDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lecdetDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lecdetDataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lecdetDataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lecdetDataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lecdetDataGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lecdetDataGrid.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lecdetDataGrid.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                lecdetDataGrid.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                
                lecdetDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttondeletes_Click_1(object sender, EventArgs e)
        {
            if (textBoxupdatename.Text != "" && textBoxupdateempid.Text != "" && comboBoxupdatefaculty.Text != "" && textBoxupdatedept.Text != "" && comboBoxupdatecenter.Text != "" && comboboxupdatebuilding.Text != "" && comboBoxcategory.Text != "" && comboBoxupdatelevel.Text != "" && textBoxupdaterank.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //DialogResult dialogResult = CustomMessageBox.Show("Warning", "Do you to delete this record?", MessageBoxButtons.OK);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        ClassLec lect = new ClassLec();
                        lect.Name = textBoxupdatename.Text;
                        lect.EmployeeId = textBoxupdateempid.Text;
                        lect.Faculty = comboBoxupdatefaculty.Text;
                        lect.Department = textBoxupdatedept.Text;
                        lect.Center = comboBoxupdatecenter.Text;
                        lect.Building = comboboxupdatebuilding.Text;
                        lect.Category = comboBoxcategory.Text;
                        lect.Level = comboBoxupdatelevel.Text;
                        lect.Rank = textBoxupdaterank.Text;

                        sqlCon = new SQLiteConnection(connectString);
                        sqlCon.Open();
                        sqlCom = new SQLiteCommand();
                        
                        sqlCom.CommandText = @"DELETE FROM LecturerDetails WHERE ID ='" + id + "'";
                        sqlCom.Connection = sqlCon;
                        int i = sqlCom.ExecuteNonQuery();
                        if (i == 1)
                        {
                            CustomMessageBox.Show("Delete Data",  " deleted successfully.");
                            id = 0;
                            lecdetDataGrid.ClearSelection();
                            lecdetDataGrid.CurrentCell = null;
                            ReadData();
                            lecdetDataGrid.ClearSelection();
                            lecdetDataGrid.CurrentCell = null;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxupdatename.Text != "" && textBoxupdateempid.Text != "" && comboBoxupdatefaculty.Text != "" && textBoxupdatedept.Text != "" && comboBoxupdatecenter.Text != "" && comboboxupdatebuilding.Text != "" && comboBoxcategory.Text != "" && comboBoxupdatelevel.Text != "" && textBoxupdaterank.Text != "")
            {
                if (isDoubleClick)
                {
                    ClassLec lec = new ClassLec();
                    lec.Name = textBoxupdatename.Text;
                    lec.EmployeeId = textBoxupdateempid.Text;
                    lec.Faculty =comboBoxupdatefaculty.Text;
                    lec.Department = textBoxupdatedept.Text;
                    lec.Center = comboBoxupdatecenter.Text;
                    lec.Building = comboboxupdatebuilding.Text;
                    lec.Category = comboBoxcategory.Text;
                    lec.Level = comboBoxupdatelevel.Text;
                    lec.Rank = textBoxupdaterank.Text;
                    

                    DB = new SQLiteDataAdapter("SELECT * FROM LecturerDetails WHERE nametb='" + lec.Name + "' AND empidtb='" + lec.EmployeeId + "' AND facultycb='" + lec.Faculty + "' AND deptb='" + lec.Department + "' AND centercb='" + lec.Center + "' AND buildingcb='" + lec.Building + "' AND categorycb='" + lec.Category + "' AND levelcb='" + lec.Level + "' AND ranktb='" + lec.Rank + "'", sqlCon);
                    dt = new DataTable();
                    DB.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        CustomMessageBox.Show("Lecturer Details",  "  already saved. Can not be updated.");
                    }
                    else
                    {

                        try
                        {
                           
                            
                                sqlCon.Open();
                                sqlCom = new SQLiteCommand();
                                sqlCom.CommandText = @"UPDATE LecturerDetails set nametb=@nametb, empidtb=@empidtb, facultycb=@facultycb, deptb=@deptb ,centercb=@centercb, buildingcb=@buildingcb , categorycb=@categorycb, levelcb=@levelcb , ranktb=@ranktb WHERE ID ='" + id + "'";
                                sqlCom.Connection = sqlCon;
                                sqlCom.Parameters.AddWithValue("@nametb", lec.Name);
                                sqlCom.Parameters.AddWithValue("@empidtb", lec.EmployeeId);
                                sqlCom.Parameters.AddWithValue("@facultycb", lec.Faculty);
                                sqlCom.Parameters.AddWithValue("@deptb", lec.Department);
                                sqlCom.Parameters.AddWithValue("@centercb", lec.Center);
                                sqlCom.Parameters.AddWithValue("@buildingcb", lec.Building);
                                sqlCom.Parameters.AddWithValue("@categorycb", lec.Category);
                                sqlCom.Parameters.AddWithValue("@levelcb", lec.Level);
                                sqlCom.Parameters.AddWithValue("@ranktb", lec.Rank);





                            int i = sqlCom.ExecuteNonQuery();

                            if (i == 1)
                            {
                                CustomMessageBox.Show("Lecturer Details", "  updated successfully.");
                                lec.Name = "";
                                lec.EmployeeId = "";
                                lec.Faculty = "";
                                lec.Department = "";
                                lec.Center = "";
                                lec.Building= "";
                                lec.Category = "";
                                lec.Level = "";
                                lec.Rank = "";
                               
                                ReadData();
                                id = 0;
                                lecdetDataGrid.ClearSelection();
                                lecdetDataGrid.CurrentCell = null;
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

        private void lecdetDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassLec lec = new ClassLec();
  
            lec.Name = textBoxupdatename.Text;
            lec.EmployeeId = textBoxupdateempid.Text;
            lec.Faculty = comboBoxupdatefaculty.Text;
            lec.Department = textBoxupdatedept.Text;
            lec.Center = comboBoxupdatecenter.Text;
            lec.Building = comboboxupdatebuilding.Text;
            lec.Category = comboBoxcategory.Text;
            lec.Level = comboBoxupdatelevel.Text;
            lec.Rank = textBoxupdaterank.Text;

            id = Convert.ToInt32(lecdetDataGrid.SelectedRows[0].Cells[0].Value);
            textBoxupdatename.Text = lecdetDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            textBoxupdateempid.Text = lecdetDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxupdatefaculty.Text = lecdetDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            textBoxupdatedept.Text = lecdetDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxupdatecenter.Text = lecdetDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            comboboxupdatebuilding.Text = lecdetDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            comboBoxcategory.Text = lecdetDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            comboBoxupdatelevel.Text = lecdetDataGrid.SelectedRows[0].Cells[8].Value.ToString();
            textBoxupdaterank.Text = lecdetDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            
            isDoubleClick = true;
        }

        private void comboBoxupdatefaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

