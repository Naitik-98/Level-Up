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
    public partial class Store : Form
    {
        private string username; // To know who is logged in
        private SqlConnection connection;

        public Store(string username)
        {
            InitializeComponent();
            this.username = username;
            connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=LevelUpDB;Integrated Security=True");
            LoadStoreItems(); // Load store items on form load
        }

        private Store() { }

        private void LoadStoreItems()
        {
            panelMain.Controls.Clear();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT GameName, Price, GameImagePath, GameDescription FROM Games", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                int y = 10;
                while (reader.Read())
                {
                    string gameName = reader["GameName"].ToString();
                    string price = reader["Price"].ToString();
                    string imagePath = reader["GameImagePath"].ToString();
                    string description = reader["GameDescription"].ToString();

                    // Create game card panel (list style)
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
                    lblName.MaximumSize = new Size(340, 0); // Wrap if too long
                    lblName.AutoSize = true;

                    // Description label
                    Label lblDesc = new Label();
                    lblDesc.Text = description;
                    lblDesc.ForeColor = Color.LightGray;
                    lblDesc.Font = new Font("Arial", 9, FontStyle.Regular);
                    lblDesc.Location = new Point(150, 45);
                    lblDesc.Size = new Size(340, 40);
                    lblDesc.AutoEllipsis = true;

                    // Price label
                    Label lblPrice = new Label();
                    lblPrice.Text = "Price: BDT" + price;
                    lblPrice.ForeColor = Color.White;
                    lblPrice.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblPrice.Location = new Point(150, 90);
                    lblPrice.AutoSize = true;

                    // Buy button (bottom center)
                    Button btnBuy = new Button();
                    btnBuy.Text = "Buy";
                    btnBuy.BackColor = Color.DarkGreen;
                    btnBuy.ForeColor = Color.White;
                    btnBuy.Size = new Size(80, 30);
                    btnBuy.Location = new Point((gameCard.Width - btnBuy.Width) / 2, gameCard.Height - btnBuy.Height - 10);
                    btnBuy.Click += (s, e) => BuyGame(gameName, price);

                    gameCard.Controls.Add(pic);
                    gameCard.Controls.Add(lblName);
                    gameCard.Controls.Add(lblDesc);
                    gameCard.Controls.Add(lblPrice);
                    gameCard.Controls.Add(btnBuy);

                    panelMain.Controls.Add(gameCard);

                    y += gameCard.Height + 10; // Spacing between cards
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading store items: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BuyGame(string gameName, string price)
        {
            try
            {
                connection.Open();

                // Check if user already bought the game
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
                SqlCommand insertCmd = new SqlCommand("INSERT INTO UserLibrary (Username, GameName, PurchaseDate) VALUES (@Username, @GameName, @PurchaseDate)", connection);
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@GameName", gameName);
                insertCmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Game purchased successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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