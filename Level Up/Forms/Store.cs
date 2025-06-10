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
            var accountForm = new Account();
            accountForm.Show();
            this.Hide();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            var storeForm = new Store();
            storeForm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings();
            settingsForm.Show();
            this.Hide();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            var libraryForm = new Library();
            libraryForm.Show();
            this.Hide();
        }
    }
}
