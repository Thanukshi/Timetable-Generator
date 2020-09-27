using System;
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
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp;
using FireSharp.Response;
using System.Data.SQLite;

namespace NewTimeApp.UserControlers
{
    public partial class academicDetails : UserControl
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCom;
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        private SQLiteDataAdapter DB;

        public academicDetails()
        {
            InitializeComponent();
        }


        /*IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Onj8rh37hQONO2YXC0YncZnUy6kbXHBtxK9uCoTx",
            BasePath = "https://timetableapp-12161.firebaseio.com/"
        };

        IFirebaseClient client;
*/
        private void academicDetails_Load(object sender, EventArgs e)
        {
            /*try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                CustomMessageBox.Show("Interrupt", "There was problem in the internet..");
            }
*/
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentsUC studentsUC = new StudentsUC();
            MainControler.showControl(studentsUC, acPanel);
        }

        private async void saveAcademic_Click(object sender, EventArgs e)
        {
            if (acYear.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Academic Year", "Please select academic year.");
            }
            else if (acSem.SelectedIndex <= -1)
            {
                CustomMessageBox.Show("Academic Semester", "Please select academic semester.");
            }

            else
            {
                AcademicDetailsClass academic = new AcademicDetailsClass();

                academic.AcYear = acYear.Text;
                academic.AcSEM = acSem.Text;


                /* var setter = client.Set("AcademicDetails/", academic);*/

                /*if (academic.AcYear == acYear.Text && academic.AcSEM == acSem.Text)
                {
                    CustomMessageBox.Show("Academic Details", "" + acYear.Text + "." + acSem.Text + " is already saved.");

                }
                else
                {
                    PushResponse response = await client.PushAsync("AcademicDetails", academic);
                    CustomMessageBox.Show("Academic Details", "" + acYear.Text + "." + acSem.Text + " is generated.");
                }*/



            }
        }

    }
}


