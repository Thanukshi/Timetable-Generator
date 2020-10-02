using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Data.SQLite;
using NewTimeApp.Helpers;

namespace NewTimeApp.UserControlers
{
    public partial class editsub : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        private SQLiteDataAdapter DB;
        int id;
        bool isDoubleClick = false;
        String connectString;
        public editsub()
        {
            InitializeComponent();
            StyleDataGrid();
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            //connectString = @"Data Source = E:\\3rdYear\\2ndSemester\\SPM\\Project\\NewTimeApp\\NewTimeApp\\bin\\Debug\\TimeAppDB.db";
            sqlCon = new SQLiteConnection(connectString);
        }
        void StyleDataGrid()
        {
            subdetDataGrid.BorderStyle = BorderStyle.None;
            subdetDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 190, 247);
            subdetDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            subdetDataGrid.DefaultCellStyle.ForeColor = Color.Black;
            subdetDataGrid.BackgroundColor = Color.White;

            subdetDataGrid.EnableHeadersVisualStyles = false;
            subdetDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            subdetDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 4, 45);
            subdetDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        //IFirebaseConfig fcon = new FirebaseConfig()
        //{
        //    AuthSecret = "Onj8rh37hQONO2YXC0YncZnUy6kbXHBtxK9uCoTx",
        //    BasePath = "https://timetableapp-12161.firebaseio.com/"
        //};
        //IFirebaseClient client;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ReadData();
            //try
            //{
            //    client = new FireSharp.FirebaseClient(fcon);

            //}
            //catch
            //{
            //    MessageBox.Show("There was problem in Internet.");
            //}
        }
        private void ReadData()
        {
            try
            {
                sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
                sqlCom = new SQLiteCommand();
                String sql = "SELECT * FROM SubjectDetails";
                DB = new SQLiteDataAdapter(sql, sqlCon);
                ds.Reset();
                DB.Fill(ds);
                dt = ds.Tables[0];
                subdetDataGrid.DataSource = dt;
                sqlCon.Close();

                subdetDataGrid.Columns[0].Visible = false;
                subdetDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                subdetDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                subdetDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                subdetDataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                subdetDataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                subdetDataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                subdetDataGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                subdetDataGrid.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                


                subdetDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonselectsubjecte_Click(object sender, EventArgs e)
        {

            //var result = client.Get("Subjectlist/" + Offeredyear.Text);
            //Classsub sub = result.ResultAs<Classsub>();
            //yeare.Text = sub.Offeredyear;
            //semestere.Text = sub.Offeredsemester;
            //subnamee.Text = sub.SubjectName;
            //codee.Text = sub.SubjectCode;
            //leche.Text = sub.LecHours;
            //tutee.Text = sub.TuteHours;
            //labe.Text = sub.LabHours;
            //evaluatione.Text = sub.EvaluationHours;

            //MessageBox.Show("Data Rectrived Successfully");
        }

        private void leche_TextChanged(object sender, EventArgs e)
        {

        }

        private void labe_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttondeletesub_Click(object sender, EventArgs e)
        {
            if (yearup.Text != "" && semup.Text != "" && subnup.Text != "" && subup.Text != "" && lecup.Text != "" && tutee.Text != "" && labe.Text != "" && evaluatione.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //DialogResult dialogResult = CustomMessageBox.Show("Warning", "Do you to delete this record?", MessageBoxButtons.OK);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        Classsub subj = new Classsub();
                        subj.Offeredyear = yearup.Text;
                        subj.Offeredsemester = semup.Text;
                        subj.SubjectName = subnup.Text;
                        subj.SubjectCode = subup.Text;
                        subj.LecHours = lecup.Text;
                        subj.TuteHours = tutee.Text;
                        subj.LabHours = labe.Text;
                        subj.EvaluationHours = evaluatione.Text;
                        

                        sqlCon = new SQLiteConnection(connectString);
                        sqlCon.Open();
                        sqlCom = new SQLiteCommand();

                        sqlCom.CommandText = @"DELETE FROM SubjectDetails WHERE ID ='" + id + "'";
                        sqlCom.Connection = sqlCon;
                        int i = sqlCom.ExecuteNonQuery();
                        if (i == 1)
                        {
                            CustomMessageBox.Show("Delete Data", " deleted successfully.");
                            id = 0;
                            subdetDataGrid.ClearSelection();
                            subdetDataGrid.CurrentCell = null;
                            ReadData();
                            subdetDataGrid.ClearSelection();
                            subdetDataGrid.CurrentCell = null;
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

        private void buttoneditsub_Click(object sender, EventArgs e)
        {
            if (yearup.Text != "" && semup.Text != "" && subnup.Text != "" && subup.Text != "" && lecup.Text != "" && tutee.Text != "" && labe.Text != "" && evaluatione.Text != "")
            {
                if (isDoubleClick)
                {
                    Classsub subj = new Classsub();
                    subj.Offeredyear = yearup.Text;
                    subj.Offeredsemester = semup.Text;
                    subj.SubjectName = subnup.Text;
                    subj.SubjectCode = subup.Text;
                    subj.LecHours = lecup.Text;
                    subj.TuteHours = tutee.Text;
                    subj.LabHours = labe.Text;
                    subj.EvaluationHours = evaluatione.Text;


                    DB = new SQLiteDataAdapter("SELECT * FROM SubjectDetails WHERE year='" + subj.Offeredyear + "' AND semester ='" + subj.Offeredsemester + "' AND subname ='" + subj.SubjectName + "' AND code='" + subj.SubjectCode + "' AND lech='" + subj.LecHours + "' AND tute='" + subj.TuteHours + "' AND lab='" + subj.LabHours + "' AND evaluation='" + subj.EvaluationHours  + "'", sqlCon);
                    dt = new DataTable();
                    DB.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        CustomMessageBox.Show("Subject Details", "  already saved. Can not be updated.");
                    }
                    else
                    {

                        try
                        {


                            sqlCon.Open();
                            sqlCom = new SQLiteCommand();
                            sqlCom.CommandText = @"UPDATE SubjectDetails set year=@year, semester=@semester, subname=@subname, code=@code ,lech=@lech, tute=@tute , lab=@lab, evaluation=@evaluation  WHERE ID ='" + id + "'";
                            sqlCom.Connection = sqlCon;
                            sqlCom.Parameters.AddWithValue("@year", subj.Offeredyear);
                            sqlCom.Parameters.AddWithValue("@semester", subj.Offeredsemester);
                            sqlCom.Parameters.AddWithValue("@subname", subj.SubjectName);
                            sqlCom.Parameters.AddWithValue("@code", subj.SubjectCode);
                            sqlCom.Parameters.AddWithValue("@lech", subj.LecHours);
                            sqlCom.Parameters.AddWithValue("@tute", subj.TuteHours);
                            sqlCom.Parameters.AddWithValue("@lab", subj.LabHours);
                            sqlCom.Parameters.AddWithValue("@evaluation", subj.EvaluationHours);
                           





                            int i = sqlCom.ExecuteNonQuery();

                            if (i == 1)
                            {
                                CustomMessageBox.Show("Lecturer Details", "  updated successfully.");
                                subj.Offeredyear = "";
                                subj.Offeredsemester= "";
                                subj.SubjectName = "";
                                subj.SubjectCode = "";
                                subj.LecHours = "";
                                subj.TuteHours = "";
                                subj.LabHours = "";
                                subj.EvaluationHours= "";

                                ReadData();
                                id = 0;
                                subdetDataGrid.ClearSelection();
                                subdetDataGrid.CurrentCell = null;
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
        private void subdetDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    

        private void subdetDataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Classsub su = new Classsub();

            su.Offeredyear = yearup.Text;
            su.Offeredsemester = semup.Text;
            su.SubjectName = subnup.Text;
            su.SubjectCode = subup.Text;
            su.LecHours = lecup.Text;
            su.TuteHours = tutee.Text;
            su.LabHours = labe.Text;
            su.EvaluationHours = evaluatione.Text;

            id = Convert.ToInt32(subdetDataGrid.SelectedRows[0].Cells[0].Value);
            yearup.Text = subdetDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            semup.Text = subdetDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            subnup.Text = subdetDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            subup.Text = subdetDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            lecup.Text = subdetDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            tutee.Text = subdetDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            labe.Text = subdetDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            evaluatione.Text = subdetDataGrid.SelectedRows[0].Cells[8].Value.ToString();


            isDoubleClick = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            subject subje = new subject();
            MainControler.showControl(subje, panelsubb);
        }
    }
}
