using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using NewTimeApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTimeApp
{
    public partial class Login : Form
    {
       /* string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
        SqlConnection sqlCon;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCom;*/

        public Login()
        {
            InitializeComponent();
           /* sqlCon = new SqlConnection(con);
            sqlCon.Open();*/
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Onj8rh37hQONO2YXC0YncZnUy6kbXHBtxK9uCoTx",
            BasePath = "https://timetableapp-12161.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                CustomMessageBox.Show("No Internet.", "There was problem in the internet...!");

            }
        }

        private void jTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void UN_Text_Enter(object sender, EventArgs e)
        {
            if(unT.Text == "Username")
            {
                unT.Text = "";


                unT.ForeColor = Color.Purple;
            }
        }

        private void un_Text_Leave(object sender, EventArgs e)
        {
            if (unT.Text == "")
            {
                unT.Text = "Username";


                unT.ForeColor = Color.Silver;
            }
        }

        private void pw_Text_Enter(object sender, EventArgs e)
        {
            if (pwT.Text == "Password")
            {
                pwT.Text = "";


                pwT.ForeColor = Color.Purple;
            }
        }

        private void pw_Text_Leave(object sender, EventArgs e)
        {
            if (pwT.Text == "")
            {
                pwT.Text = "Password";


                pwT.ForeColor = Color.Silver;
            }
        }

        private void pw_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void visiblePW_Click(object sender, EventArgs e)
        {
            if(pwT.PasswordChar == '*')
            {
                visiblePW.BringToFront();
                pwT.PasswordChar = '\0';
            }
            else if (pwT.PasswordChar == '\0')
            {
                pwT.PasswordChar = '*';
            }
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(unT.Text))
            {
                CustomMessageBox.Show("User Name", "Please enter valid username");
            }
            else if (string.IsNullOrEmpty(pwT.Text))
            {
                CustomMessageBox.Show("Password", "Please enter valid password");
            }
            else
            {
                FirebaseResponse response = client.Get("loginDB/");
                Dictionary<string, loginClass> result = response.ResultAs<Dictionary<string, loginClass>>();

/*                FirebaseResponse response = client.Get("loginDB/");
                Dictionary<string, loginClass> result = response.ResultAs<Dictionary<string, loginClass>>();*/

                foreach (var get in result)
                {
                    string userR = get.Value.userName;
                    string passR = get.Value.password;

                    if (unT.Text == userR)
                    {
                        if(pwT.Text == passR)
                        {
                            CustomMessageBox.Show("Login", "You were logged successfully...");
                            DashBoard dashBoard = new DashBoard();
                            this.Hide();
                            dashBoard.ShowDialog();
                        }
                        else
                        {
                            CustomMessageBox.Show("Password", "Password does not match with the username..");
                        }
                    }
                    else
                    {
                        CustomMessageBox.Show("Username", "Not a valid user..");
                    }
                }

               
            }

            /*            if (string.IsNullOrWhiteSpace(un_Text.Text))
                        {
                            MessageBox.Show("Please enter valid username.", "User Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //CustomMessageBox.Show("User Name", "Please enter valid username");
                        }
                        else if (string.IsNullOrWhiteSpace(pw_Text.Text))
                        {
                            MessageBox.Show("Please enter valid password.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
             *//*               sqlDataAdapter = new SqlDataAdapter("select count(*) from login where userName = '" + un_Text.Text + "'and password = '" + pw_Text.Text + "'", sqlCon);
                            DataTable dt = new DataTable();
                            sqlDataAdapter.Fill(dt);*/
            /*
                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                Hide();
                                DashBoard dash = new DashBoard();
                                dash.ShowDialog();
                            }*/
            /*   else
               {
                   MessageBox.Show("Username or Password is incorrect... Please try again...!", "Username Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

               }*//*
        }*/

        }


    }
    }

