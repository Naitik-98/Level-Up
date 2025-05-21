using System;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Level_Up
{
    public partial class RegisterForm : Form
    {
       private readonly string connectionString = Properties.Settings.Default.LevelUpDBConnectionString;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnRegister_Click(object sender, EventArgs e)
            {
                string name = txtName.Text.Trim();
                string username = txtUsername.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;
                string gender = cmbGender.SelectedItem?.ToString();
                DateTime dob = dtpDOB.Value;
                string userId = Guid.NewGuid().ToString(); // Unique ID for user

                // Basic validation
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = @"INSERT INTO Users (UserID, Name, Username, Email, Password, Gender, DateOfBirth)
                                     VALUES (@UserID, @Name, @Username, @Email, @Password, @Gender, @DOB)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Password", password);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@DOB", dob);

                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                new LoginForm().Show(); // Redirect to login form
                            }
                            else
                            {
                                MessageBox.Show("Registration failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:\n" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnToLogin_Click(object sender, EventArgs e)
            {
                this.Hide();
                new LoginForm().Show(); // Redirect to login form
            }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }



