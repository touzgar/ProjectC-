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
    public partial class Tournament : Form
    {
        private int selectedTournamentId;
        public Tournament()
        {
            InitializeComponent();

        }

        private void Tournament_Load(object sender, EventArgs e)
        {
            LoadTournamentData();
        }

        private void tournamentName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTournamentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Format_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFormat_TextChanged(object sender, EventArgs e)
        {

        }

        private void prize_pool_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrize_Pool_TextChanged(object sender, EventArgs e)
        {

        }

        private void capacity_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateStart_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEnd_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a tournament name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the search method
            SearchTournamentByName(searchText);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            // Automatically search as the user types
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                SearchTournamentByName(searchText);
            }
            else
            {
                // Reload all data if the search box is cleared
                LoadTournamentData();
            }

        }

        private void Create_Click(object sender, EventArgs e)
        {
            string tournamentName = textBoxTournamentName.Text.Trim();
            string format = textBoxFormat.Text.Trim();
            double prizePool;
            int capacity;

            DateTime dateStart = dateTimePickerDateStart.Value;
            DateTime dateEnd = dateTimePickerDateEnd.Value;

            // Validate input
            if (string.IsNullOrWhiteSpace(tournamentName) || string.IsNullOrWhiteSpace(format))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBoxPrize_Pool.Text, out prizePool) || prizePool <= 0)
            {
                MessageBox.Show("Please enter a valid numeric value for the prize pool.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxCapacity.Text, out capacity) || capacity <= 0)
            {
                MessageBox.Show("Please enter a valid numeric value for capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateEnd < dateStart)
            {
                MessageBox.Show("End date must be later than or equal to the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            // SQL query to insert a new tournament
            string query = @"INSERT INTO tournament (tournamentName, format, prize_pool, capacity, dateStart, dateEnd)
                     VALUES (@tournamentName, @format, @prize_pool, @capacity, @dateStart, @dateEnd);";

            // Connect to the database and execute the query
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@tournamentName", tournamentName);
                        command.Parameters.AddWithValue("@format", format);
                        command.Parameters.AddWithValue("@prize_pool", prizePool);
                        command.Parameters.AddWithValue("@capacity", capacity);
                        command.Parameters.AddWithValue("@dateStart", dateStart);
                        command.Parameters.AddWithValue("@dateEnd", dateEnd);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tournament created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            textBoxTournamentName.Clear();
                            textBoxFormat.Clear();
                            textBoxPrize_Pool.Clear();
                            textBoxCapacity.Clear();
                            dateTimePickerDateStart.Value = DateTime.Now;
                            dateTimePickerDateEnd.Value = DateTime.Now;

                            // Refresh the DataGridView (if applicable)
                             LoadTournamentData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the tournament.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selectedTournamentId <= 0)
            {
                MessageBox.Show("Please select a tournament to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve input values
            string tournamentName = textBoxTournamentName.Text.Trim();
            string format = textBoxFormat.Text.Trim();
            double prizePool;
            int capacity;
            DateTime dateStart = dateTimePickerDateStart.Value;
            DateTime dateEnd = dateTimePickerDateEnd.Value;

            // Validate input
            if (string.IsNullOrWhiteSpace(tournamentName) || string.IsNullOrWhiteSpace(format))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBoxPrize_Pool.Text, out prizePool) || prizePool <= 0)
            {
                MessageBox.Show("Please enter a valid numeric value for the prize pool.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxCapacity.Text, out capacity) || capacity <= 0)
            {
                MessageBox.Show("Please enter a valid numeric value for capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateEnd < dateStart)
            {
                MessageBox.Show("End date must be later than or equal to the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            // SQL query to update the selected tournament
            string query = @"UPDATE tournament 
                     SET tournamentName = @tournamentName, format = @format, 
                         prize_pool = @prizePool, capacity = @capacity, 
                         dateStart = @dateStart, dateEnd = @dateEnd 
                     WHERE idTournament = @idTournament;";

            // Connect to the database and execute the query
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@tournamentName", tournamentName);
                        command.Parameters.AddWithValue("@format", format);
                        command.Parameters.AddWithValue("@prizePool", prizePool);
                        command.Parameters.AddWithValue("@capacity", capacity);
                        command.Parameters.AddWithValue("@dateStart", dateStart);
                        command.Parameters.AddWithValue("@dateEnd", dateEnd);
                        command.Parameters.AddWithValue("@idTournament", selectedTournamentId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tournament updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields and refresh the DataGridView
                            textBoxTournamentName.Clear();
                            textBoxFormat.Clear();
                            textBoxPrize_Pool.Clear();
                            textBoxCapacity.Clear();
                            dateTimePickerDateStart.Value = DateTime.Now;
                            dateTimePickerDateEnd.Value = DateTime.Now;
                            selectedTournamentId = 0;

                            LoadTournamentData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the tournament.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selectedTournamentId <= 0)
            {
                MessageBox.Show("Please select a tournament to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete this tournament?",
                                                "Confirm Deletion",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            // SQL query to delete the selected tournament
            string query = "DELETE FROM tournament WHERE idTournament = @idTournament;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@idTournament", selectedTournamentId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tournament deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            textBoxTournamentName.Clear();
                            textBoxFormat.Clear();
                            textBoxPrize_Pool.Clear();
                            textBoxCapacity.Clear();
                            dateTimePickerDateStart.Value = DateTime.Now;
                            dateTimePickerDateEnd.Value = DateTime.Now;
                            selectedTournamentId = 0;

                            // Refresh the DataGridView
                            LoadTournamentData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the tournament.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Get the selected tournament's data
                selectedTournamentId = Convert.ToInt32(row.Cells["Column1"].Value); // Assumes "Column1" maps to `idTournament`
                textBoxTournamentName.Text = row.Cells["Column2"].Value.ToString(); // Assumes "Column2" maps to `tournamentName`
                textBoxFormat.Text = row.Cells["Column3"].Value.ToString();         // Assumes "Column3" maps to `format`
                textBoxPrize_Pool.Text = row.Cells["Column4"].Value.ToString();     // Assumes "Column4" maps to `prize_pool`
                textBoxCapacity.Text = row.Cells["Column5"].Value.ToString();       // Assumes "Column5" maps to `capacity`
                dateTimePickerDateStart.Value = Convert.ToDateTime(row.Cells["Column6"].Value); // Assumes "Column6" maps to `dateStart`
                dateTimePickerDateEnd.Value = Convert.ToDateTime(row.Cells["Column7"].Value);   // Assumes "Column7" maps to `dateEnd`

                // Debugging message to confirm selection
                MessageBox.Show($"Selected Tournament ID: {selectedTournamentId}", "Tournament Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadTournamentData()
        {
            // Existing code to load data into the DataGridView
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idTournament, tournamentName, format, prize_pool, capacity, dateStart, dateEnd FROM tournament;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable tournamentTable = new DataTable();
                        adapter.Fill(tournamentTable);

                        // Prevent auto column generation
                        dataGridView1.AutoGenerateColumns = false;

                        // Bind database columns to your predefined DataGridView columns
                        dataGridView1.Columns["Column1"].DataPropertyName = "idTournament";
                        dataGridView1.Columns["Column2"].DataPropertyName = "tournamentName";
                        dataGridView1.Columns["Column3"].DataPropertyName = "format";
                        dataGridView1.Columns["Column4"].DataPropertyName = "prize_pool";
                        dataGridView1.Columns["Column5"].DataPropertyName = "capacity";
                        dataGridView1.Columns["Column6"].DataPropertyName = "dateStart";
                        dataGridView1.Columns["Column7"].DataPropertyName = "dateEnd";

                        // Set the DataGridView's DataSource
                        dataGridView1.DataSource = tournamentTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SearchTournamentByName(string tournamentName)
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idTournament, tournamentName, format, prize_pool, capacity, dateStart, dateEnd FROM tournament WHERE tournamentName LIKE @tournamentName;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter with wildcard for partial matches
                        command.Parameters.AddWithValue("@tournamentName", "%" + tournamentName + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable tournamentTable = new DataTable();
                            adapter.Fill(tournamentTable);

                            if (tournamentTable.Rows.Count > 0)
                            {
                                // Prevent auto column generation
                                dataGridView1.AutoGenerateColumns = false;

                                // Bind database columns to your predefined DataGridView columns
                                dataGridView1.Columns["Column1"].DataPropertyName = "idTournament";   // Tournament ID
                                dataGridView1.Columns["Column2"].DataPropertyName = "tournamentName"; // Tournament Name
                                dataGridView1.Columns["Column3"].DataPropertyName = "format";         // Format
                                dataGridView1.Columns["Column4"].DataPropertyName = "prize_pool";     // Prize Pool
                                dataGridView1.Columns["Column5"].DataPropertyName = "capacity";       // Capacity
                                dataGridView1.Columns["Column6"].DataPropertyName = "dateStart";      // Start Date
                                dataGridView1.Columns["Column7"].DataPropertyName = "dateEnd";
                                dataGridView1.Columns["Column8"].DataPropertyName = "TeamName";        // End Date
                                                                                                      // End Date

                                // Set the DataGridView's DataSource
                                dataGridView1.DataSource = tournamentTable;
                            }
                            else
                            {
                                MessageBox.Show("No tournaments found matching the search term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void addTeamToTournament_Click(object sender, EventArgs e)
        {
            AddTeamToTournament AddTeamToTournamentForm = new AddTeamToTournament();
            AddTeamToTournamentForm.RefreshTournamentData += LoadTournamentData; // Subscribe to the event
            AddTeamToTournamentForm.ShowDialog(); // Show the form
        }

        private void RemoveTeamFromTournament_Click(object sender, EventArgs e)
        {
            RemoveTeamFromTournament RemoveTeamFromTournamentForm = new RemoveTeamFromTournament();
            RemoveTeamFromTournamentForm.RefreshTournamentData += LoadTournamentData; // Subscribe to the event
            RemoveTeamFromTournamentForm.ShowDialog(); // Show the form
        }
    }
    }

