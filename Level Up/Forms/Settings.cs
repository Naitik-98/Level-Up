﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Level_Up.Forms
{
    public partial class Settings : Form
    {
        private string username;

        public Settings(string username)
        {
            InitializeComponent();
            this.username = username;
            Logoutbtn.Click += Logoutbtn_Click;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text.Trim();
            string newEmail = txtEmail.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string currentPassword = txtCurrentPassword.Text;
            string newUsername = txtUsername.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newEmail) ||
                string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("Name, Email, Username, and Current Password are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Current username is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new DbAccess())
            {
                // Check current password
                string sql = $"SELECT Password FROM Users WHERE Username = '{username.Replace("'", "''")}'";
                var dt = db.ExecuteQueryTable(sql);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dbPassword = dt.Rows[0]["Password"].ToString();
                if (dbPassword != currentPassword)
                {
                    MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if new username is already taken (if changed)
                if (!string.Equals(username, newUsername, StringComparison.OrdinalIgnoreCase))
                {
                    string checkUserSql = $"SELECT COUNT(*) FROM Users WHERE Username = '{newUsername.Replace("'", "''")}'";
                    var userCheckDt = db.ExecuteQueryTable(checkUserSql);
                    if (userCheckDt != null && userCheckDt.Rows.Count > 0 && Convert.ToInt32(userCheckDt.Rows[0][0]) > 0)
                    {
                        MessageBox.Show("The new username is already taken. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Build update query for Users table
                string updateSql = $"UPDATE Users SET FullName = @FullName, Email = @Email, Username = @NewUsername";
                if (!string.IsNullOrWhiteSpace(newPassword))
                    updateSql += ", Password = @Password";
                updateSql += " WHERE Username = @Username";

                using (var cmd = new System.Data.SqlClient.SqlCommand(updateSql, db.Sqlcon))
                {
                    cmd.Parameters.AddWithValue("@FullName", newName);
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                    cmd.Parameters.AddWithValue("@Username", username);
                    if (!string.IsNullOrWhiteSpace(newPassword))
                        cmd.Parameters.AddWithValue("@Password", newPassword);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        // If username changed, update related tables (e.g., UserLibrary)
                        if (!string.Equals(username, newUsername, StringComparison.OrdinalIgnoreCase))
                        {
                            string updateLibrarySql = "UPDATE UserLibrary SET Username = @NewUsername WHERE Username = @OldUsername";
                            using (var cmdLib = new System.Data.SqlClient.SqlCommand(updateLibrarySql, db.Sqlcon))
                            {
                                cmdLib.Parameters.AddWithValue("@NewUsername", newUsername);
                                cmdLib.Parameters.AddWithValue("@OldUsername", username);
                                cmdLib.ExecuteNonQuery();
                            }
                            // Update the local username field for the session
                            this.username = newUsername;
                        }

                        MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var accountForm = new Account(null, null, null, username);
            accountForm.FormClosed += (s, args) => this.Show();
            accountForm.Show();
            this.Hide();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            var storeForm = new Store(username);
            storeForm.FormClosed += (s, args) => this.Show();
            storeForm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings(username);
            settingsForm.FormClosed += (s, args) => this.Show();
            settingsForm.Show();
            this.Hide();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            var libraryForm = new Library(username);
            libraryForm.FormClosed += (s, args) => this.Show();
            libraryForm.Show();
            this.Hide();
        }


    }
}

