using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Up.Forms
{
    public partial class Library : Form
    {
        private string username;
        private SqlConnection connection;

        public Library(string username)
        {
            InitializeComponent();
            this.username = username;
            connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=LevelUpDB;Integrated Security=True");
            panelMain.AutoScroll = true;
            LoadUserLibrary();
        }

        private void LoadUserLibrary()
        {
            panelMain.Controls.Clear();
            try
            {
                connection.Open();
                // Join with Games table to get image and description
                string query = @"SELECT g.GameName, g.GameImagePath, g.GameDescription
                                 FROM UserLibrary ul
                                 INNER JOIN Games g ON ul.GameName = g.GameName
                                 WHERE ul.Username = @Username";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                int y = 10;
                while (reader.Read())
                {
                    string gameName = reader["GameName"].ToString();
                    string imagePath = reader["GameImagePath"].ToString();
                    string description = reader["GameDescription"].ToString();

                    // Create game card panel
                    Panel gameCard = new Panel();
                    gameCard.Size = new Size(520, 150);
                    gameCard.BackColor = Color.FromArgb(30, 30, 30);
                    gameCard.Location = new Point(10, y);

                    // Game image
                    PictureBox pic = new PictureBox();
                    pic.Size = new Size(120, 120);
                    pic.Location = new Point(15, 15);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        pic.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pic.Image = null; // or set a default image
                    }

                    // Game name label
                    Label lblName = new Label();
                    lblName.Text = gameName;
                    lblName.ForeColor = Color.White;
                    lblName.Font = new Font("Arial", 13, FontStyle.Bold);
                    lblName.Location = new Point(150, 15);
                    lblName.MaximumSize = new Size(340, 0);
                    lblName.AutoSize = true;

                    // Description label
                    Label lblDesc = new Label();
                    lblDesc.Text = description;
                    lblDesc.ForeColor = Color.LightGray;
                    lblDesc.Font = new Font("Arial", 9, FontStyle.Regular);
                    lblDesc.Location = new Point(150, 45);
                    lblDesc.Size = new Size(340, 40);
                    lblDesc.AutoEllipsis = true;

                    // Play button
                    Button btnPlay = new Button();
                    btnPlay.Text = "Play";
                    btnPlay.BackColor = Color.DodgerBlue;
                    btnPlay.ForeColor = Color.White;
                    btnPlay.Size = new Size(80, 30);
                    btnPlay.Location = new Point(150, 100);
                    btnPlay.Click += (s, e) => MessageBox.Show($"Launching {gameName}... (not implemented)", "Play", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Delete button
                    Button btnDelete = new Button();
                    btnDelete.Text = "Delete";
                    btnDelete.BackColor = Color.Firebrick;
                    btnDelete.ForeColor = Color.White;
                    btnDelete.Size = new Size(80, 30);
                    btnDelete.Location = new Point(250, 100);
                    btnDelete.Click += (s, e) => DeleteGameFromLibrary(gameName);

                    gameCard.Controls.Add(pic);
                    gameCard.Controls.Add(lblName);
                    gameCard.Controls.Add(lblDesc);
                    gameCard.Controls.Add(btnPlay);
                    gameCard.Controls.Add(btnDelete);

                    panelMain.Controls.Add(gameCard);

                    y += gameCard.Height + 10;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading library: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // Helper method to delete a game from the user's library
        private void DeleteGameFromLibrary(string gameName)
        {
            var confirm = MessageBox.Show($"Are you sure you want to remove '{gameName}' from your library?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM UserLibrary WHERE Username = @Username AND GameName = @GameName", connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@GameName", gameName);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Game removed from your library.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserLibrary(); // Refresh the library view
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting game: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void BuyGame(string gameName, string price)
        {
            try
            {
                connection.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM UserLibrary WHERE Username = @Username AND GameName = @GameName", connection);
                checkCmd.Parameters.AddWithValue("@Username", username);
                checkCmd.Parameters.AddWithValue("@GameName", gameName);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("You already own this game!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Insert into user library
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO UserLibrary (Username, GameName, PurchaseDate) VALUES (@Username, @GameName, @PurchaseDate)", connection);
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@GameName", gameName);
                insertCmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Game purchased successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Library form and show the updated library
                var libraryForm = new Library(username);
                libraryForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while purchasing game: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            var dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
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
