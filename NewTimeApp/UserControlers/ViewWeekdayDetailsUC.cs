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
using System.Linq.Expressions;

namespace NewTimeApp.UserControlers
{
    public partial class ViewWeekdayDetailsUC : UserControl
    {


        public ViewWeekdayDetailsUC()
        {
            InitializeComponent();
            //sqlCon = new SqlConnection(conString);
            //sqlCon.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            WeekdayDetails weekdayDetails = new WeekdayDetails();
            MainControler.showControl(weekdayDetails, panel1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditWeekdayUC editWeekdayUC = new EditWeekdayUC();
            MainControler.showControl(editWeekdayUC, panel1);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-MRMR\MSSQLSERVER_MISH;Initial Catalog=NewTimeApp;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
           //SqlCommand sqlCmd3 = new SqlCommand("DaysAndHours", cnn);

            //sqlCmd3.CommandType = CommandType.StoredProcedure;
            //sqlCmd3.Parameters.AddWithValue("@ActionType", "DeleteData");

           // SqlCommand sqlCmd3 = new SqlCommand("", cnn);
            //sqlCmd3.ExecuteNonQuery();
            SqlCommand sqlCmd3 = new SqlCommand("Delete from DaysAndHours where TableType = 'WeekDay'",cnn);
            sqlCmd3.ExecuteNonQuery();
            //SqlCommand sqlCmd4 = new SqlCommand("Delete From SelectedDays",cnn);
            //sqlCmd4.ExecuteNonQuery();


            cnn.Close();
            MessageBox.Show("Data deleted!!!");
            WeekdayDetails weekdayDetails = new WeekdayDetails();
            MainControler.showControl(weekdayDetails, panel1);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            richTextBox1.Visible = true;
            textBox5.Visible = true;
            editBtn.Visible = true;
            deleteBtn.Visible = true;


            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-MRMR\MSSQLSERVER_MISH;Initial Catalog=NewTimeApp;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            try
            {

                SqlCommand comando1 = new SqlCommand();
                SqlConnection conn8 = new SqlConnection(connetionString);
                comando1.Connection = conn8;
                comando1.CommandText = "Select TableType from DaysAndHours Where TableType='WeekDay'";
                conn8.Open();
                textBox5.Text = comando1.ExecuteScalar().ToString();
                conn8.Close();

                SqlConnection conn = new SqlConnection(connetionString);
                comando1.Connection = conn;
                comando1.CommandText = "Select NoOfDays from DaysAndHours Where TableType='WeekDay'";
                conn.Open();
                textBox1.Text = comando1.ExecuteScalar().ToString();
                conn.Close();

                SqlCommand comando2 = new SqlCommand();
                comando2.Connection = conn;
                comando2.CommandText = "Select HoursPerDay from DaysAndHours  Where TableType='WeekDay'";
                conn.Open();
                textBox2.Text = comando2.ExecuteScalar().ToString();
                conn.Close();

                SqlCommand comando3 = new SqlCommand();
                comando3.Connection = conn;
                comando3.CommandText = "Select TimeSlot from DaysAndHours  Where TableType='WeekDay'";
                conn.Open();
                textBox3.Text = comando3.ExecuteScalar().ToString();
                conn.Close();

                SqlCommand comando4 = new SqlCommand();
                comando4.Connection = conn;
                
                comando4.CommandText = "Select s.SelectedDays from SelectedDays s, DaysAndHours d Where d.TableType='WeekDay' AND d.TableID =s.TableID";
                conn.Open();
                richTextBox1.Text = comando4.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong."+ ex);
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

