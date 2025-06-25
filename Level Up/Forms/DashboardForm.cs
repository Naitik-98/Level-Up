using Level_Up.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Up
{
    public partial class DashboardForm : Form
    {
        public DbAccess DbAccess { get; set; }
        public string Username { get; set; }
        public LoginForm LoginForm { get; set; }
        public DashboardForm()
        {
            InitializeComponent();
            this.DbAccess = new DbAccess();
        }

        public DashboardForm(LoginForm loginForm, string username) : this()
        {
            this.LoginForm = loginForm;
            this.Username = username;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
<<<<<<< HEAD

=======
            
>>>>>>> parent of 1809319 (solve)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

<<<<<<< HEAD

=======
     
>>>>>>> parent of 1809319 (solve)
        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void labelTop_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var accountForm = new Account(LoginForm, this, DbAccess, Username);
            accountForm.Show();
            accountForm.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings(Username); // Pass the Username property
            settingsForm.Show();
            settingsForm.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            var storeForm = new Store(Username); // Pass the username property from DashboardForm
            storeForm.FormClosed += (s, args) => this.Show();
            storeForm.Show();
            this.Hide();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            var libraryForm = new Library(Username); // Pass the Username property
            libraryForm.Show();
            libraryForm.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }
    }
}
//fnnf