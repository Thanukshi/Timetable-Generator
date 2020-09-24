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
    public partial class CustomMessageBox : Form
    {
        static string msgT;
        static string msgLb;

        public CustomMessageBox()
        {
            InitializeComponent();
            titleOfPages.Text = msgT; ;
            msgLable.Text = msgLb;

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal static void Show(string vt, string vm)
        {

            msgT = vt;
            msgLb = vm;
            CustomMessageBox cmb = new CustomMessageBox();
            cmb.Show();

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
