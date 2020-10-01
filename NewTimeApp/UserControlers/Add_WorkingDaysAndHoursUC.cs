using System;
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


namespace NewTimeApp.UserControlers
{
    public partial class Add_WorkingDaysAndHoursUC : UserControl
    {
        public Add_WorkingDaysAndHoursUC()
        {
            InitializeComponent();      
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


            string[] SelectedDays = new string[7];
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
            string[] terms = SelectedDayslist.ToArray();
            //MessageBox.Show();
            WorkingDaysAndHours workingDaysAndHours = new WorkingDaysAndHours()
            {
                TableType = textBox2.Text,
                WorkingDays = comboBox1.Text,
                WorkingHours = textBox1.Text,
                TimeSlot = timeSlot,
                SelectedDays = terms

            };

           

            WorkingDaysAndHoursUC workingDaysAndHoursUC = new WorkingDaysAndHoursUC();
            MainControler.showControl(workingDaysAndHoursUC, panel1);

        }

        
    }
}
