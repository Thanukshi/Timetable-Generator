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
        }


        private void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {

            if (acUpYear.Text != "" && acUpSem.Text != "")
            {
                /*                sqlCom = new SqlCommand("update AcademicDetails set acYear=@AcademicYear, acSem=@AcademicSemester where acID=@AcademicId", cons);
                                cons.Open();
                                sqlCom.Parameters.AddWithValue("@AcademicId", acedemicID);
                                sqlCom.Parameters.AddWithValue("@AcademicYear", acUpYear.Text);
                                sqlCom.Parameters.AddWithValue("@AcademicSemester", acUpSem.Text);
                                sqlCom.ExecuteNonQuery();
                                MessageBox.Show("Record Updated Successfully");
                                cons.Close();
                                FetchAcademicDetails();
                                ClearData();*/
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void academicDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*ID = Convert.ToInt32(academicDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            acUpYear.Text = academicDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            acUpSem.Text = academicDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();*/
        }
    }
}
