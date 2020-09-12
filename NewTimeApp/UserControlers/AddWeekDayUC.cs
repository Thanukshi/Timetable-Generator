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
    
    public partial class AddWeekDayUC : UserControl
    {
        public AddWeekDayUC()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            WeekdayDetails weekdayDetails = new WeekdayDetails();
            MainControler.showControl(weekdayDetails, panel1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-MRMR\MSSQLSERVER_MISH;Initial Catalog=NewTimeApp;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
           

            SqlCommand sqlCmd, sqlCmd2;
            string TableID="";

            String timeSlot = "";
            if (radioButton1.Checked)
            {
                timeSlot = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                timeSlot = radioButton2.Text;
            }

            

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Enter Working Days !!!");
                comboBox1.Select();
            }
            else if(string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Enter Working Days !!!");
                comboBox1.Select();
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter Working Hours !!!");
                textBox1.Select();
            }
            
            else if ((comboBox1.SelectedIndex <= -1))
            {
                MessageBox.Show("Enter Working Days !!!");
                comboBox1.Select();
            }
            else if ((comboBox2.SelectedIndex <= -1))
            {
                MessageBox.Show("Enter Working Days !!!");
                comboBox1.Select();
            }
            else
            {
                try
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }

                    using (SqlConnection connection4 = new SqlConnection(connetionString))
                    {
                        DataTable dtData = new DataTable();
                        sqlCmd = new SqlCommand("spDaysAndHours", cnn);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                        sqlCmd.Parameters.AddWithValue("@TableID", TableID);
                        sqlCmd.Parameters.AddWithValue("@NoOfDays", comboBox1.Text);
                        sqlCmd.Parameters.AddWithValue("@HoursPerDay", textBox1.Text);
                        sqlCmd.Parameters.AddWithValue("@TimeSlot", timeSlot);
                        sqlCmd.Parameters.AddWithValue("@TableType", comboBox2.Text);


                        connection4.Open();
                        sqlCmd.ExecuteNonQuery();
                        connection4.Close();


                    }



                   
                    string[] SelectedDays = new string[7];

                    if (checkBox1.Checked)
                    {
                        SelectedDays[0] = checkBox1.Text;
                    }
                    if (checkBox2.Checked)
                    {
                        SelectedDays[1] = checkBox2.Text;
                    }
                    if (checkBox3.Checked)
                    {
                        SelectedDays[2] = checkBox3.Text;
                    }
                    if (checkBox4.Checked)
                    {
                        SelectedDays[3] = checkBox4.Text;
                    }
                    if (checkBox5.Checked)
                    {
                        SelectedDays[4] = checkBox5.Text;
                    }
                    if (checkBox6.Checked)
                    {
                        SelectedDays[5] = checkBox5.Text;
                    }
                    if (checkBox7.Checked)
                    {
                        SelectedDays[6] = checkBox5.Text;
                    }


                    for (int i = 0; i < 7; i++)
                    {

                        if (SelectedDays[i] != null)
                        {
                            
                            

                            using (SqlConnection connection = new SqlConnection(connetionString))
                            {
                                
                                sqlCmd2 = new SqlCommand("spDaysAndHours", cnn);
                                sqlCmd2.CommandType = CommandType.StoredProcedure;
                                sqlCmd2.Parameters.AddWithValue("@ActionType", "SaveData");
                                
                                SqlCommand myCommand4 = new SqlCommand("insert into SelectedDays(TableID, SelectedDays)select(MAX(TableID)),'"+SelectedDays[i]+"' FROM DaysAndHours; ", cnn);
                                myCommand4.ExecuteNonQuery();
                                                          
                                connection.Close();
                                

                            }
                            



                        }
                    }

                    int numRes = 2;
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Saved Successfully !!!");
                        WeekdayDetails weekdayDetails = new WeekdayDetails();
                        MainControler.showControl(weekdayDetails, panel1);

                    }
                    else
                        MessageBox.Show("Please Try Again !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
