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
        string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
        SqlConnection sqlCon;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCom;

        public Login()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(con);
            sqlCon.Open();
        }

        private void jTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void UN_Text_Enter(object sender, EventArgs e)
        {
            if(un_Text.Text == "Username")
            {
                un_Text.Text = "";


                un_Text.ForeColor = Color.Purple;
            }
        }

        private void un_Text_Leave(object sender, EventArgs e)
        {
            if (un_Text.Text == "")
            {
                un_Text.Text = "Username";


                un_Text.ForeColor = Color.Silver;
            }
        }

        private void pw_Text_Enter(object sender, EventArgs e)
        {
            if (pw_Text.Text == "Password")
            {
                pw_Text.Text = "";


                pw_Text.ForeColor = Color.Purple;
            }
        }

        private void pw_Text_Leave(object sender, EventArgs e)
        {
            if (pw_Text.Text == "")
            {
                pw_Text.Text = "Password";


                pw_Text.ForeColor = Color.Silver;
            }
        }

        private void pw_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void visiblePW_Click(object sender, EventArgs e)
        {
            if(pw_Text.PasswordChar == '*')
            {
                visiblePW.BringToFront();
                pw_Text.PasswordChar = '\0';
            }
            else if (pw_Text.PasswordChar == '\0')
            {
                pw_Text.PasswordChar = '*';
            }
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(un_Text.Text))
            {
                MessageBox.Show("Please enter valid username.", "User Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrWhiteSpace(pw_Text.Text))
            {
                MessageBox.Show("Please enter valid password.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sqlDataAdapter = new SqlDataAdapter("select count(*) from login where userName = '" + un_Text.Text + "'and password = '" + pw_Text.Text + "'", sqlCon);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    Hide();
                    DashBoard dash = new DashBoard();
                    dash.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect... Please try again...!", "Username Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        private void un_Text_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

