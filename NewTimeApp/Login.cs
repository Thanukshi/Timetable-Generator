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

        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void jTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void UN_Text_Enter(object sender, EventArgs e)
        {
            if (unT.Text == "Username")
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
            if (pwT.PasswordChar == '*')
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
            if (unT.Text == "admin" && pwT.Text == "admin1234")
            {
                //CustomMessageBox.Show("Login Credentials.", "You were logged successfully...");
                DashBoard dashBoard = new DashBoard();
                this.Hide();
                dashBoard.ShowDialog();
            }
            else
            {
                if (unT.Text == "admin" && pwT.Text != "admin1234")
                {
                    CustomMessageBox.Show("Login Credentials", "Password is incorrect....!");
                }
                else
                {
                    CustomMessageBox.Show("Login Credentials", "Not a valid user....!");
                }

            }
        }
    };
}









