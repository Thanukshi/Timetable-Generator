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
namespace NewTimeApp.UserControlers
{
    public partial class View_WorkingDaysAndHoursUC : UserControl
    {
        public View_WorkingDaysAndHoursUC()
        {
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Edit_WorkingDaysAndHoursUC edit_workingDaysAndHoursUC = new Edit_WorkingDaysAndHoursUC();
            MainControler.showControl(edit_workingDaysAndHoursUC, panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
           Edit_WorkingDaysAndHoursUC edit_workingDaysAndHoursUC = new Edit_WorkingDaysAndHoursUC();
            MainControler.showControl(edit_workingDaysAndHoursUC, panel1);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void editBtn_Click_2(object sender, EventArgs e)
        {
            Edit_WorkingDaysAndHoursUC edit_workingDaysAndHoursUC = new Edit_WorkingDaysAndHoursUC();
            MainControler.showControl(edit_workingDaysAndHoursUC, panel1);
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            label5.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;

            radioButton1.Visible = true;
            radioButton2.Visible = true;


            editBtn.Visible = true;
            deleteBtn.Visible = true;

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
