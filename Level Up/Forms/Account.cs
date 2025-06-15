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
            var fullName = userData.Rows[0]["FullName"].ToString();
            var email = userData.Rows[0]["Email"].ToString(); // Changed from DateOfBirth to Email
            this.lblName.Text += fullName;
            this.lblEmail.Text = "Email: " + email; // Update label to show email
            this.lblUsername.Text += this.Username;

            UpdateOwnedGamesCount();
        }

        private void UpdateOwnedGamesCount()
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM UserLibrary WHERE Username = '{this.Username}'";
                var dt = this.DbAccess.ExecuteQueryTable(sql);
                int count = 0;
                if (dt != null && dt.Rows.Count > 0)
                {
                    count = Convert.ToInt32(dt.Rows[0][0]);
                }
                lblOwnedGame.Text = $"Owned Games: {count}";
            }
            catch (Exception ex)
            {
                lblOwnedGame.Text = "Owned Games: ?";
                MessageBox.Show("Error loading owned games count: " + ex.Message);
            }
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }

        }

     
        }
   

