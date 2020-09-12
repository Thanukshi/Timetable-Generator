using NewTimeApp.Helpers;
using NewTimeApp.UserControlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace NewTimeApp.UserControlers
{
    public partial class ViewWeekendDetailsUC : UserControl
    {
        public ViewWeekendDetailsUC()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            WeekdayDetails weekdayDetails = new WeekdayDetails();
            MainControler.showControl(weekdayDetails, panel1);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditWeekdayUC editWeekendUC = new EditWeekdayUC();
            MainControler.showControl(editWeekendUC, panel1);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void button_WOC1_Click(object sender, EventArgs e)
        {


        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            label5.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            richTextBox1.Visible = true;
            editBtn.Visible = true;
            deleteBtn.Visible = true;



            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-MRMR\MSSQLSERVER_MISH;Initial Catalog=NewTimeApp;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand comando6 = new SqlCommand();
                SqlConnection conn1 = new SqlConnection(connetionString);
                comando6.Connection = conn1;
                comando6.CommandText = "SELECT COUNT(DISTINCT 'DaysAndHours') FROM information_schema.COLUMNS  WHERE 'table_schema' = 'NewTimeApp'";
                conn1.Open();

                conn1.Close();
                SqlCommand comando1 = new SqlCommand();
                SqlConnection conn8 = new SqlConnection(connetionString);
                comando1.Connection = conn8;
                comando1.CommandText = "Select TableType from DaysAndHours Where TableType='WeekEnd'";
                conn8.Open();
                textBox5.Text = comando1.ExecuteScalar().ToString();
                conn8.Close();

                SqlConnection conn = new SqlConnection(connetionString);
                comando1.Connection = conn;
                comando1.CommandText = "Select NoOfDays from DaysAndHours Where TableType='WeekEnd'";
                conn.Open();
                textBox1.Text = comando1.ExecuteScalar().ToString();
                conn.Close();

                SqlCommand comando2 = new SqlCommand();
                comando2.Connection = conn;
                comando2.CommandText = "Select HoursPerDay from DaysAndHours  Where TableType='WeekEnd'";
                conn.Open();
                textBox2.Text = comando2.ExecuteScalar().ToString();
                conn.Close();

                SqlCommand comando3 = new SqlCommand();
                comando3.Connection = conn;
                comando3.CommandText = "Select TimeSlot from DaysAndHours  Where TableType='WeekEnd'";
                conn.Open();
                textBox3.Text = comando3.ExecuteScalar().ToString();
                conn.Close();

                SqlCommand comando4 = new SqlCommand();
                comando4.Connection = conn;
                string[] SelectedDays = new string[7];
                
                    



                        using (SqlConnection connection = new SqlConnection(connetionString))
                        {

                            //sqlCmd2 = new SqlCommand("spDaysAndHours", cnn);
                           // sqlCmd2.CommandType = CommandType.StoredProcedure;
                           // sqlCmd2.Parameters.AddWithValue("@ActionType", "SaveData");

                            comando4.CommandText = "Select * from SelectedDays s, DaysAndHours d Where d.TableType='WeekEnd' AND d.TableID =s.TableID";
                            conn.Open();
                            richTextBox1.Text = comando4.ExecuteScalar().ToString();
                            richTextBox1.Text = Environment.NewLine;
                            conn.Close();


                            SqlCommand myCommand4 = new SqlCommand("insert into SelectedDays(TableID, SelectedDays)select(MAX(TableID))  FROM DaysAndHours; ", cnn);
                            myCommand4.ExecuteNonQuery();

                            connection.Close();


                        }




                    
                


                
            }catch(Exception ex)
            {
                Console.WriteLine("Something went wrong." + ex);

            }
            
       
    
}
            
        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-MRMR\MSSQLSERVER_MISH;Initial Catalog=NewTimeApp;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                //SqlCommand sqlCmd3 = new SqlCommand("", cnn);
                //sqlCmd3.CommandType = CommandType.StoredProcedure;
                //sqlCmd3.Parameters.AddWithValue("@ActionType", "DeleteData");

                SqlCommand sqlCmd3 = new SqlCommand("Delete from DaysAndHours where TableType = 'WeekEnd'",cnn);
                //SqlCommand sqlCmd4 = new SqlCommand ("Delete From SelectedDays",cnn);
                sqlCmd3.ExecuteNonQuery();
                //sqlCmd4.ExecuteNonQuery();


            cnn.Close();
                MessageBox.Show("Data deleted!!!");
                WeekdayDetails weekdayDetails = new WeekdayDetails();
                MainControler.showControl(weekdayDetails, panel1);
            
        }
    }
}
