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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Logoutbtn.Click += Logoutbtn_Click;
        }

        private void labelTop_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

