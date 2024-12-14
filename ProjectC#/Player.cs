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
    public partial class Player : Form
    {
        private int selectedPlayerId;

        public Player()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            LoadPlayerData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void countryOfResidence_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcountryOfResidence_TextChanged(object sender, EventArgs e)
        {

        }

        private void discordId_Click(object sender, EventArgs e)
        {

        }

        private void textBoxdiscordId_TextChanged(object sender, EventArgs e)
        {

        }

        private void inGameName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxinGameName_TextChanged(object sender, EventArgs e)
        {

        }

        private void jerseySize_Click(object sender, EventArgs e)
        {

        }

        private void textBoxJerseySize_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailAdress_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMailAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void salary_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void whatsappPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBoxwhatsappPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerdateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a player's full name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the search method
            SearchPlayerByName(searchText);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            // Automatically search as the user types
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                SearchPlayerByName(searchText);
            }
            else
            {
                // Reload all data if the search box is cleared
                LoadPlayerData();
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string leagalefullname = textBoxPlayerName.Text.Trim();
            string countryOfResidence = textBoxcountryOfResidence.Text.Trim();
            string discordId = textBoxdiscordId.Text.Trim();
            string inGameName = textBoxinGameName.Text.Trim();
            string jerseySize = textBoxJerseySize.Text.Trim();
            string mailAdress = textBoxMailAdress.Text.Trim();
            string salaryText = textBoxSalary.Text.Trim();
            string whatsappPhone = textBoxwhatsappPhone.Text.Trim();
            DateTime dateOfBirth = dateTimePickerdateOfBirth.Value;

            // Get the team_idTeam value from the input field (e.g., TextBox)
            string teamIdText = textBoxTeamId.Text.Trim();  // Assuming you have a textBoxTeamId or similar

            // If the input is empty or the user types "null", we will treat it as NULL
            int? teamId = null; // Nullable int for team_idTeam
            if (!string.IsNullOrWhiteSpace(teamIdText) && teamIdText.ToLower() != "null")
            {
                if (int.TryParse(teamIdText, out int parsedTeamId))
                {
                    teamId = parsedTeamId;
                }
                else
                {
                    MessageBox.Show("Please enter a valid team ID or 'null' for no team.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Validate other inputs
            if (string.IsNullOrWhiteSpace(leagalefullname) ||
                string.IsNullOrWhiteSpace(countryOfResidence) ||
                string.IsNullOrWhiteSpace(discordId) ||
                string.IsNullOrWhiteSpace(inGameName) ||
                string.IsNullOrWhiteSpace(jerseySize) ||
                string.IsNullOrWhiteSpace(mailAdress) ||
                string.IsNullOrWhiteSpace(salaryText) ||
                string.IsNullOrWhiteSpace(whatsappPhone))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Salary must be a valid numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "INSERT INTO player (leagalefullname, countryOfResidence, discordId, inGameName, jerseySize, mailAdress, salary, whatsappPhone, dateOfBirth, team_idTeam) " +
                           "VALUES (@leagalefullname, @countryOfResidence, @discordId, @inGameName, @jerseySize, @mailAdress, @salary, @whatsappPhone, @dateOfBirth, @team_idTeam);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@leagalefullname", leagalefullname);
                        command.Parameters.AddWithValue("@countryOfResidence", countryOfResidence);
                        command.Parameters.AddWithValue("@discordId", discordId);
                        command.Parameters.AddWithValue("@inGameName", inGameName);
                        command.Parameters.AddWithValue("@jerseySize", jerseySize);
                        command.Parameters.AddWithValue("@mailAdress", mailAdress);
                        command.Parameters.AddWithValue("@salary", salary);
                        command.Parameters.AddWithValue("@whatsappPhone", whatsappPhone);
                        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

                        // If teamId is null (i.e., the user inputted "null" or left it blank)
                        command.Parameters.AddWithValue("@team_idTeam", (object)teamId ?? DBNull.Value);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Player created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields after successful insertion
                            textBoxPlayerName.Clear();
                            textBoxcountryOfResidence.Clear();
                            textBoxdiscordId.Clear();
                            textBoxinGameName.Clear();
                            textBoxJerseySize.Clear();
                            textBoxMailAdress.Clear();
                            textBoxSalary.Clear();
                            textBoxwhatsappPhone.Clear();
                            textBoxTeamId.Clear();  // Clear the team ID input field
                            dateTimePickerdateOfBirth.Value = DateTime.Now;

                            // Refresh the DataGridView to include the new player
                            LoadPlayerData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selectedPlayerId <= 0)
            {
                MessageBox.Show("Please select a player to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve input values
            string leagalefullname = textBoxPlayerName.Text;
            string countryOfResidence = textBoxcountryOfResidence.Text;
            string discordId = textBoxdiscordId.Text;
            string inGameName = textBoxinGameName.Text;
            string jerseySize = textBoxJerseySize.Text;
            string mailAddress = textBoxMailAdress.Text;
            string salary = textBoxSalary.Text;
            string whatsappPhone = textBoxwhatsappPhone.Text;
            DateTime dateOfBirth = dateTimePickerdateOfBirth.Value;

            // Validate input
            if (string.IsNullOrWhiteSpace(leagalefullname) || string.IsNullOrWhiteSpace(inGameName))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            // SQL query to update the selected player
            string query = @"UPDATE player 
                     SET leagalefullname = @leagalefullname, 
                         countryOfResidence = @countryOfResidence, 
                         discordId = @discordId, 
                         inGameName = @inGameName, 
                         jerseySize = @jerseySize, 
                         mailAdress = @mailAddress, 
                         salary = @salary, 
                         whatsappPhone = @whatsappPhone, 
                         dateOfBirth = @dateOfBirth 
                     WHERE idPlayer = @idPlayer;";

            // Connect to the database and execute the query
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@leagalefullname", leagalefullname);
                        command.Parameters.AddWithValue("@countryOfResidence", countryOfResidence);
                        command.Parameters.AddWithValue("@discordId", discordId);
                        command.Parameters.AddWithValue("@inGameName", inGameName);
                        command.Parameters.AddWithValue("@jerseySize", jerseySize);
                        command.Parameters.AddWithValue("@mailAddress", mailAddress);
                        command.Parameters.AddWithValue("@salary", salary);
                        command.Parameters.AddWithValue("@whatsappPhone", whatsappPhone);
                        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@idPlayer", selectedPlayerId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Player updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields and refresh the DataGridView
                            textBoxPlayerName.Clear();
                            textBoxcountryOfResidence.Clear();
                            textBoxdiscordId.Clear();
                            textBoxinGameName.Clear();
                            textBoxJerseySize.Clear();
                            textBoxMailAdress.Clear();
                            textBoxSalary.Clear();
                            textBoxwhatsappPhone.Clear();
                            dateTimePickerdateOfBirth.Value = DateTime.Now;
                            selectedPlayerId = 0;

                            LoadPlayerData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selectedPlayerId <= 0)
            {
                MessageBox.Show("Please select a player to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete this player?",
                                                 "Confirm Deletion",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            // SQL query to delete the selected player
            string query = "DELETE FROM player WHERE idPlayer = @idPlayer;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@idPlayer", selectedPlayerId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Player deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            textBoxPlayerName.Clear();
                            textBoxcountryOfResidence.Clear();
                            textBoxdiscordId.Clear();
                            textBoxinGameName.Clear();
                            textBoxJerseySize.Clear();
                            textBoxMailAdress.Clear();
                            textBoxSalary.Clear();
                            textBoxwhatsappPhone.Clear();
                            dateTimePickerdateOfBirth.Value = DateTime.Now;
                            selectedPlayerId = 0;

                            // Refresh the DataGridView
                            LoadPlayerData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Get the selected player's data
                selectedPlayerId = Convert.ToInt32(row.Cells["Column1"].Value); 
                textBoxPlayerName.Text = row.Cells["Column2"].Value.ToString(); 
                textBoxcountryOfResidence.Text = row.Cells["Column3"].Value.ToString(); 
                textBoxdiscordId.Text = row.Cells["Column4"].Value.ToString(); 
                textBoxinGameName.Text = row.Cells["Column5"].Value.ToString(); 
                textBoxJerseySize.Text = row.Cells["Column6"].Value.ToString(); 
                textBoxMailAdress.Text = row.Cells["Column7"].Value.ToString(); 
                textBoxSalary.Text = row.Cells["Column8"].Value.ToString(); 
                textBoxwhatsappPhone.Text = row.Cells["Column9"].Value.ToString(); 
                dateTimePickerdateOfBirth.Value = Convert.ToDateTime(row.Cells["Column10"].Value); 

                // Debugging message to confirm selection
                MessageBox.Show($"Selected Player ID: {selectedPlayerId}", "Player Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void LoadPlayerData()
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idPlayer, leagalefullname, countryOfResidence, discordId, inGameName, jerseySize, mailAdress, salary, whatsappPhone, dateOfBirth FROM player;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable playerTable = new DataTable();
                        adapter.Fill(playerTable);

                        // Prevent auto column generation
                        dataGridView1.AutoGenerateColumns = false;

                        // Bind database columns to your predefined DataGridView columns
                        dataGridView1.Columns["Column1"].DataPropertyName = "idPlayer";
                        dataGridView1.Columns["Column2"].DataPropertyName = "leagalefullname";
                        dataGridView1.Columns["Column3"].DataPropertyName = "countryOfResidence";
                        dataGridView1.Columns["Column4"].DataPropertyName = "discordId";
                        dataGridView1.Columns["Column5"].DataPropertyName = "inGameName";
                        dataGridView1.Columns["Column6"].DataPropertyName = "jerseySize";
                        dataGridView1.Columns["Column7"].DataPropertyName = "mailAdress";
                        dataGridView1.Columns["Column8"].DataPropertyName = "salary";
                        dataGridView1.Columns["Column9"].DataPropertyName = "whatsappPhone";
                        dataGridView1.Columns["Column10"].DataPropertyName = "dateOfBirth";

                        // Set the DataGridView's DataSource
                        dataGridView1.DataSource = playerTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SearchPlayerByName(string playerName)
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idPlayer, leagalefullname, countryOfResidence, discordId, inGameName, jerseySize, mailAdress, salary, whatsappPhone, dateOfBirth FROM player WHERE leagalefullname LIKE @playerName;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter with wildcard for partial matches
                        command.Parameters.AddWithValue("@playerName", "%" + playerName + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable playerTable = new DataTable();
                            adapter.Fill(playerTable);

                            if (playerTable.Rows.Count > 0)
                            {
                                // Prevent auto column generation
                                dataGridView1.AutoGenerateColumns = false;

                                // Bind database columns to your predefined DataGridView columns
                                dataGridView1.Columns["Column1"].DataPropertyName = "idPlayer";
                                dataGridView1.Columns["Column2"].DataPropertyName = "leagalefullname";
                                dataGridView1.Columns["Column3"].DataPropertyName = "countryOfResidence";
                                dataGridView1.Columns["Column4"].DataPropertyName = "discordId";
                                dataGridView1.Columns["Column5"].DataPropertyName = "inGameName";
                                dataGridView1.Columns["Column6"].DataPropertyName = "jerseySize";
                                dataGridView1.Columns["Column7"].DataPropertyName = "mailAdress";
                                dataGridView1.Columns["Column8"].DataPropertyName = "salary";
                                dataGridView1.Columns["Column9"].DataPropertyName = "whatsappPhone";
                                dataGridView1.Columns["Column10"].DataPropertyName = "dateOfBirth";

                                // Set the DataGridView's DataSource
                                dataGridView1.DataSource = playerTable;
                            }
                            else
                            {
                                MessageBox.Show("No players found matching the search term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TeamID_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTeamId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
