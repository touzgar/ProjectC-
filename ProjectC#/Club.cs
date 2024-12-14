using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectC_
{
    public partial class Club : Form
    {
        private int selectedClubId;
        
        public Club()
        {
            InitializeComponent();
        }

        private void Club_Load(object sender, EventArgs e)
        {
            LoadClubData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clubtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateCreation_Click(object sender, EventArgs e)
        {

        }

        private void dateTxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = searchtxt.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a club name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the search method
            SearchClubByName(searchText);
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchtxt.Text.Trim();

            // Automatically search as the user types
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                SearchClubByName(searchText);
            }
            else
            {
                // Reload all data if the search box is cleared
                LoadClubData();
            }
        }

        private void SearchClubByName(string clubName)
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idClub, clubName, description, dateCreation FROM club WHERE clubName LIKE @clubName;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter with wildcard for partial matches
                        command.Parameters.AddWithValue("@clubName", "%" + clubName + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable clubTable = new DataTable();
                            adapter.Fill(clubTable);

                            if (clubTable.Rows.Count > 0)
                            {
                                // Prevent auto column generation
                                dataGridView1.AutoGenerateColumns = false;

                                // Bind database columns to your predefined DataGridView columns
                                dataGridView1.Columns["Column2"].DataPropertyName = "idClub";
                                dataGridView1.Columns["Column3"].DataPropertyName = "clubName";
                                dataGridView1.Columns["Column4"].DataPropertyName = "description";
                                dataGridView1.Columns["Column5"].DataPropertyName = "dateCreation";

                                // Set the DataGridView's DataSource
                                dataGridView1.DataSource = clubTable;
                            }
                            else
                            {
                                MessageBox.Show("No clubs found matching the search term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.DataSource = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during the search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Create_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            string clubName = clubtxt.Text;
            string description = descriptionTxt.Text;
            DateTime creationDate = dateTxt.Value;

            // Validate input
            if (string.IsNullOrWhiteSpace(clubName) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            // SQL query to insert a new club
            string query = "INSERT INTO club (clubName, description, dateCreation) VALUES (@clubName, @description, @creationDate);";

            // Connect to the database and execute the query
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@clubName", clubName);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@creationDate", creationDate);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Club created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            clubtxt.Clear();
                            descriptionTxt.Clear();
                            dateTxt.Value = DateTime.Now;

                            // Refresh the DataGridView
                            LoadClubData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the club.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Update_Click(object sender, EventArgs e)
        {
            if (selectedClubId <= 0)
            {
                MessageBox.Show("Please select a club to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve input values
            string clubName = clubtxt.Text;
            string description = descriptionTxt.Text;
            DateTime creationDate = dateTxt.Value;

            // Validate input
            if (string.IsNullOrWhiteSpace(clubName) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            // SQL query to update the selected club
            string query = "UPDATE club SET clubName = @clubName, description = @description, dateCreation = @creationDate WHERE idClub = @idClub;";

            // Connect to the database and execute the query
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@clubName", clubName);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@creationDate", creationDate);
                        command.Parameters.AddWithValue("@idClub", selectedClubId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Club updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields and refresh the DataGridView
                            clubtxt.Clear();
                            descriptionTxt.Clear();
                            dateTxt.Value = DateTime.Now;
                            selectedClubId = 0;

                            LoadClubData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the club.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            if (selectedClubId <= 0)
            {
                MessageBox.Show("Please select a club to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete this club?",
                                                "Confirm Deletion",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            // SQL query to delete the selected club
            string query = "DELETE FROM club WHERE idClub = @idClub;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@idClub", selectedClubId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Club deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            clubtxt.Clear();
                            descriptionTxt.Clear();
                            dateTxt.Value = DateTime.Now;
                            selectedClubId = 0;

                            // Refresh the DataGridView
                            LoadClubData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the club.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Get the selected club's data
                selectedClubId = Convert.ToInt32(row.Cells["Column2"].Value); 
                clubtxt.Text = row.Cells["Column3"].Value.ToString();        
                descriptionTxt.Text = row.Cells["Column4"].Value.ToString(); 
                dateTxt.Value = Convert.ToDateTime(row.Cells["Column5"].Value); 

                // Debugging message to confirm selection
                MessageBox.Show($"Selected Club ID: {selectedClubId}", "Club Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void LoadClubData()
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idClub, clubName, description, dateCreation FROM club;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable clubTable = new DataTable();
                        adapter.Fill(clubTable);

                        // Prevent auto column generation
                        dataGridView1.AutoGenerateColumns = false;

                        // Bind database columns to your predefined DataGridView columns
                        dataGridView1.Columns["Column2"].DataPropertyName = "idClub";
                        dataGridView1.Columns["Column3"].DataPropertyName = "clubName";
                        dataGridView1.Columns["Column4"].DataPropertyName = "description";
                        dataGridView1.Columns["Column5"].DataPropertyName = "dateCreation";

                        // Set the DataGridView's DataSource
                        dataGridView1.DataSource = clubTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





    }
}
