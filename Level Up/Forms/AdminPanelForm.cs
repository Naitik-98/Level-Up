﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Level_Up.Forms
{
    public partial class AdminPanelForm : Form
    {
        // Connection String
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LevelUpDB;Integrated Security=True;Encrypt=False";

        public AdminPanelForm()
        {
            InitializeComponent();
            btnAddGame.Click += btnAddGame_Click;
            LoadGames(); // <-- Add this line
        }

        //  Browse Image Button
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Game Image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxGame.ImageLocation = ofd.FileName;
                pictureBoxGame.Tag = ofd.FileName; // Store image path in Tag
            }
        }

        // Add Game Button
        private void btnAddGame_Click(object sender, EventArgs e)
        {
            string gameName = txtGameName.Text.Trim();
            string gameDescription = txtGameDescription.Text.Trim();
            string gamePriceText = txtGamePrice.Text.Trim();
            string gameImagePath = pictureBoxGame.Tag != null ? pictureBoxGame.Tag.ToString() : "";

            if (string.IsNullOrEmpty(gameName) || string.IsNullOrEmpty(gameDescription) || string.IsNullOrEmpty(gamePriceText) || string.IsNullOrEmpty(gameImagePath))
            {
                MessageBox.Show("Please fill all fields and select an image.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(gamePriceText, out decimal gamePrice))
            {
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Games (GameName, GameDescription, GameImagePath, Price) " +
                                   "VALUES (@GameName, @GameDescription, @GameImagePath, @Price)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@GameName", gameName);
                    cmd.Parameters.AddWithValue("@GameDescription", gameDescription);
                    cmd.Parameters.AddWithValue("@GameImagePath", gameImagePath);
                    cmd.Parameters.AddWithValue("@Price", gamePrice);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Game added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        // Clear the input fields after adding a game
        private void ClearFields()
        {
            txtGameName.Text = "";
            txtGameDescription.Text = "";
            txtGamePrice.Text = "";
            pictureBoxGame.Image = null;
            pictureBoxGame.Tag = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void LoadGames()
        {
            lstGames.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT GameName FROM Games";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lstGames.Items.Add(reader["GameName"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading games: " + ex.Message);
                }
            }
        }

        private void btnRemoveGame_Click(object sender, EventArgs e)
        {
            if (lstGames.SelectedItem == null)
            {
                MessageBox.Show("Please select a game to remove.");
                return;
            }

            string gameName = lstGames.SelectedItem.ToString();
            var confirm = MessageBox.Show($"Are you sure you want to remove '{gameName}'?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Games WHERE GameName = @GameName";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@GameName", gameName);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Game removed.");
                            LoadGames();
                        }
                        else
                        {
                            MessageBox.Show("No game removed. Check if the game exists.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
