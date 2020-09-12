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

namespace NewTimeApp.UserControlers
{
    public partial class AcademicDetailsViewUC : UserControl
    {
        string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlConnection cons = new SqlConnection("Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True");
        string acedemicID = "";
        int ID = 0;

        public AcademicDetailsViewUC()
        {
            InitializeComponent();
            StyleDataGrid();
            sqlCon = new SqlConnection(con);
            sqlCon.Open();
            FetchAcademicDetails();

            academicDataGrid.AutoGenerateColumns = false;
            academicDataGrid.DataSource = FetchAcademicDetails();
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
           // academicDataGrid.DefaultCellStyle.SelectionBackColor = Color.Plum;
            academicDataGrid.DefaultCellStyle.ForeColor = Color.Black;
            academicDataGrid.BackgroundColor = Color.White;

            academicDataGrid.EnableHeadersVisualStyles = false;
            academicDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            academicDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 4, 45);
            academicDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

       

        }

        private void AcademicDetailsViewUC_Load(object sender, EventArgs e)
        {
            //academicDataGrid.AutoGenerateColumns = false;
            //academicDataGrid.DataSource = FetchAcademicDetails();

        }


        private void viewBtn_Click(object sender, EventArgs e)
        {
       

        }

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {

            if (acUpYear.Text != "" && acUpSem.Text != "")
            {
                sqlCom = new SqlCommand("update AcademicDetails set acYear=@AcademicYear, acSem=@AcademicSemester where acID=@AcademicId", cons);
                cons.Open();
                sqlCom.Parameters.AddWithValue("@AcademicId", acedemicID);
                sqlCom.Parameters.AddWithValue("@AcademicYear", acUpYear.Text);
                sqlCom.Parameters.AddWithValue("@AcademicSemester", acUpSem.Text);
                sqlCom.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                cons.Close();
                FetchAcademicDetails();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private DataTable FetchAcademicDetails()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCom = new SqlCommand("abcAcademicDetails", sqlCon);
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Parameters.AddWithValue("@ActionType", "FetchData");
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCom);
            sqlSda.Fill(dtData);
            return dtData;
        }

        private void ClearData()
        {
            acUpYear.Text = "";
            acUpSem.Text = "";
            ID = 0;
        }

        private void academicDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(academicDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            acUpYear.Text = academicDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            acUpSem.Text = academicDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        }

/*        private void academicDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                updateDetailsBtn.Text = "Update";
                acedemicID = academicDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable dtData = FetchAllRecords(acedemicID);
                if (dtData.Rows.Count > 0)
                {
                    acedemicID = dtData.Rows[0][0].ToString();
                    acUpYear.Text = dtData.Rows[0][1].ToString();
                    acUpSem.Text = dtData.Rows[0][2].ToString();

                }
                else
                {
                    //ClearAllData(); // For clear all control and refresh DataGridView data.  
                }
            }
        }*/
    
}
