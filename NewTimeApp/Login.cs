using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        private void jFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {

        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Hide();
            DashBoard dash = new DashBoard();
            dash.ShowDialog();
        }
    }
    }

