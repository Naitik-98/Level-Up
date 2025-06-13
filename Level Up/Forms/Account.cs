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
    public partial class Account : Form
    {
        public DbAccess DbAccess { get; set; }
        public string Username { get; set; }
        public LoginForm LoginForm { get; set; }
        public DashboardForm DashboardForm { get; set; }
        public Account()
        {
            InitializeComponent();
        }

        public Account(LoginForm loginForm, DashboardForm dashboardForm, DbAccess dbAccess, string username) : this()
        {
            this.LoginForm = loginForm;
            this.DashboardForm = dashboardForm;
            this.DbAccess = dbAccess;
            this.Username = username;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM Users WHERE Username = '" + this.Username + "';";
            var userData = this.DbAccess.ExecuteQueryTable(sql);
            var fullName= userData.Rows[0]["FullName"].ToString();
            var dateOfBirth = userData.Rows[0]["DateOfBirth"].ToString();
            this.lblName.Text += fullName;
            this.lblDOB.Text += dateOfBirth;
            this.lblUsername.Text += this.Username;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTop_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStore_Click(object sender, EventArgs e)
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

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }
    }
}
