using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTimeApp.UserControlers
{
    public partial class SubGroupUC : UserControl
    {
        public SubGroupUC()
        {
            InitializeComponent();
            fillAcDetails();
            fillDegreeDetails();
            string con = "Data Source=DESKTOP-PHJQSJE;Initial Catalog=NewTimeApp;Integrated Security=True";
            sqlCon = new SqlConnection(con);
            sqlCon.Open();
        }

        private void saveSG_Click(object sender, EventArgs e)
        {

        }
    }
}
