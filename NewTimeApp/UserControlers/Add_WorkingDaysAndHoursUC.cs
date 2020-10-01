﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using NewTimeApp.Helpers;
using System.Collections;
using System.Data.SQLite;
using System.IO;

namespace NewTimeApp.UserControlers
{
    public partial class Add_WorkingDaysAndHoursUC : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter DB;
        String connectString;

        public Add_WorkingDaysAndHoursUC()
        {
            InitializeComponent();
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3";
            sqlCon = new SQLiteConnection(connectString);
            GenerateDatabase();
        }

        private void GenerateDatabase()
        {
            String path = Application.StartupPath + @"\Database\TimeAppDB.db";
            if (!File.Exists(path))
            {
                sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
                string sql1 = "CREATE TABLE WorkingDays (" +
                    "TableType VARCHAR PRIMARY KEY ," +
                    "WorkingDays VARCHAR (20) NOT NULL," +
                    "WorkingHours VARCHAR (50) NOT NULL," +
                    "TimeSlot VARCHAR (20) NOT NULL)" ;

                string sql2 = "CREATE TABLE SelectedDays (" +
                    "TableType VARCHAR,"+
                    "SelectedDays VARCHAR (20) NOT NULL)";

              


                sqlCom = new SQLiteCommand(sql1, sqlCon);
                sqlCom.ExecuteNonQuery();
                sqlCom = new SQLiteCommand(sql2, sqlCon);
                sqlCom.ExecuteNonQuery();

                sqlCon.Close();

                
            }
        }

        private void Add_WorkingDaysAndHoursUC_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String timeSlot = "";
            if (radioButton1.Checked)
            {
                timeSlot = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                timeSlot = radioButton2.Text;
            }


            string[] SelectedDays = new string[5];

            //string[] SelectedDayslist = new string[7];

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

            List<string> SelectedDayslist = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                if (SelectedDays[i] != null)
                {
                    SelectedDayslist.Add(SelectedDays[i]);
                    
                }


            }

            MessageBox.Show("done1");
            string[] terms = SelectedDayslist.ToArray();
            //MessageBox.Show();
            WorkingDaysAndHours workingDaysAndHours = new WorkingDaysAndHours();
            workingDaysAndHours.TableType = textBox2.Text;
            workingDaysAndHours.WorkingDays = comboBox1.Text;
            workingDaysAndHours.WorkingHours = textBox1.Text;
            workingDaysAndHours.TimeSlot = timeSlot;
            workingDaysAndHours.SelectedDays = terms;
            MessageBox.Show("done2");
            //SelectedDays = terms
            int ti = 2;
            if (ti==1)
            {

            }
            else
            {
                try
                {
                    sqlCon = new SQLiteConnection(connectString);
                    sqlCom = new SQLiteCommand();

                    sqlCom.CommandText = @"INSERT INTO SelectedDays(TableType, SelectedDays) VALUES(@textBox2, @terms)";
                    sqlCom.Connection = sqlCon;
                    for (int x = 0; x < terms.Length; x++)
                    {
                        //MessageBox.Show("done4");
                        if (SelectedDays != null)
                        {
                            //sqlCom.CommandText = @"INSERT INTO SelectedDays(TableType, SelectedDays) VALUES(@textBox2, @terms)";
                            // sqlCom.Connection = sqlCon;
                            sqlCom.Parameters.Add(new SQLiteParameter("@textBox2", workingDaysAndHours.TableType));
                            sqlCom.Parameters.Add(new SQLiteParameter("@terms", workingDaysAndHours.SelectedDays[x]));
                            MessageBox.Show("done4", workingDaysAndHours.SelectedDays[x]);
                            sqlCom.ExecuteNonQuery();



                        }
                    }

                    sqlCom.CommandText = @"INSERT INTO WorkingDays(TableType, WorkingDays,WorkingHours,TimeSlot)VALUES(@textBox2, @comboBox1,@textBox1,@timeSlot)";
                    sqlCom.Connection = sqlCon;
                    sqlCom.Parameters.Add(new SQLiteParameter("@textBox2", workingDaysAndHours.TableType));
                    sqlCom.Parameters.Add(new SQLiteParameter("@comboBox1", workingDaysAndHours.WorkingDays));
                    sqlCom.Parameters.Add(new SQLiteParameter("@textBox1", workingDaysAndHours.WorkingHours));
                    sqlCom.Parameters.Add(new SQLiteParameter("@timeSlot", workingDaysAndHours.TimeSlot));
                    
                    sqlCon.Open();

                    int i = sqlCom.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Working Days And Hours", "" +workingDaysAndHours.TableType +"is saved!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!", " " + ex.Message);
                }
            }
            

           

            WorkingDaysAndHoursUC workingDaysAndHoursUC = new WorkingDaysAndHoursUC();
            MainControler.showControl(workingDaysAndHoursUC, panel1);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}