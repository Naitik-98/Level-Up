using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Up.Forms
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
           
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
