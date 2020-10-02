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
    }
}
