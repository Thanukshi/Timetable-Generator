﻿using System;
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
    public partial class MainGroupUC : UserControl
    {
        SqlConnection sqlCon;
        SqlCommand sqlCom;

        public MainGroupUC()
        {
            InitializeComponent();
            fillAcDetails();
            fillDegreeDetails();
        }

        private void backBtnD_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, mgPanel);
        }

        private void acDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void fillAcDetails()
        {
            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            string qry = "SELECT * FROM AcademicDetails";
            sqlCom = new SqlCommand(qry, sqlCon);
            SqlDataReader sqlDataReader;

            try
            {
                sqlCon.Open();
                sqlDataReader = sqlCom.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string academicdetails = sqlDataReader.GetString(1);
                    acDetails.Items.Add(academicdetails);
                }
            }catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }


        public void fillDegreeDetails()
        {
            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            string qry = "SELECT * FROM AcademicDetails";
            sqlCom = new SqlCommand(qry, sqlCon);
            SqlDataReader sqlDataReader;

            try
            {
                sqlCon.Open();
                sqlDataReader = sqlCom.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string academicdetails = sqlDataReader.GetString(1);
                    acDetails.Items.Add(academicdetails);
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }

}
