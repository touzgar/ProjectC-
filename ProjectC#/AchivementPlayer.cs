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
    public partial class AchivementPlayer : Form
    {
        private int selectedAchivementPlayerId;
        public AchivementPlayer()
        {
            InitializeComponent();
        }

        private void AchivementPlayer_Load(object sender, EventArgs e)
        {
            LoadAchivementPlayerData();
            LoadPlayersIntoComboBox();
        }

        private void trophie_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTrophie_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateAchived_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void playerName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPlayerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim(); // Assuming textBox1 is your search textbox

            // Validate input
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a player name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the search method
            SearchAchievementByPlayerName(searchText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            // Automatically search as the user types
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                SearchAchievementByPlayerName(searchText);
            }
            else
            {
                // Reload all data if the search box is cleared
                LoadAchivementPlayerData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Retrieve data from the selected row and populate the form fields
                selectedAchivementPlayerId = Convert.ToInt32(row.Cells["Column1"].Value);

                textBoxTrophie.Text = row.Cells["Column2"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Column3"].Value);
                comboBoxPlayerName.Text = row.Cells["Column4"].Value.ToString();
            }
        }
        private void LoadPlayersIntoComboBox()
        {
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idPlayer, leagalefullname FROM player;";

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

                        comboBoxPlayerName.DataSource = playerTable;
                        comboBoxPlayerName.DisplayMember = "leagalefullname";
                        comboBoxPlayerName.ValueMember = "idPlayer";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading teams: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string trophie = textBoxTrophie.Text.Trim();
            DateTime dateAchived = dateTimePicker1.Value;

            if (comboBoxPlayerName.SelectedItem == null)
            {
                MessageBox.Show("Please select a player.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int playerId = (int)comboBoxPlayerName.SelectedValue; 

            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "INSERT INTO achivementPlayer (trophie, dateAchived, player_idPlayer) VALUES (@trophie, @dateAchived, @playerId);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@trophie", trophie);
                        command.Parameters.AddWithValue("@dateAchived", dateAchived);
                        command.Parameters.AddWithValue("@playerId", playerId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("AchivementTeam created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAchivementPlayerData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the AchivementTeam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selectedAchivementPlayerId <= 0)
            {
                MessageBox.Show("Please select an achievement to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect updated data from form fields
            string trophie = textBoxTrophie.Text.Trim();
            DateTime dateAchived = dateTimePicker1.Value;

            if (comboBoxPlayerName.SelectedItem == null)
            {
                MessageBox.Show("Please select a player.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int playerId = (int)comboBoxPlayerName.SelectedValue; // Ensure correct assignment here

            // Database connection and query
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"UPDATE achivementPlayer 
                     SET trophie = @trophie, dateAchived = @dateAchived, player_idPlayer = @playerId
                     WHERE idAchivementPlayer = @idAchivementPlayer;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@trophie", trophie);
                        command.Parameters.AddWithValue("@dateAchived", dateAchived);
                        command.Parameters.AddWithValue("@playerId", playerId);
                        command.Parameters.AddWithValue("@idAchivementPlayer", selectedAchivementPlayerId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Achievement updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAchivementPlayerData(); // Refresh data in DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the achievement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selectedAchivementPlayerId <= 0)
            {
                MessageBox.Show("Please select a achivementPlayer to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this AchivementPlayer?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            // Database connection and query
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "DELETE FROM achivementPlayer WHERE idAchivementPlayer = @idAchivementPlayer;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idAchivementPlayer", selectedAchivementPlayerId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("AchivementPlayer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAchivementPlayerData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the AchivementPlayer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadAchivementPlayerData()
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT ap.idAchivementPlayer, ap.trophie, ap.dateAchived, p.leagalefullname
                             FROM achivementPlayer ap
                             INNER JOIN player p ON ap.player_idPlayer = p.idPlayer;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable achivementPlayerTable = new DataTable();
                        adapter.Fill(achivementPlayerTable);

                        // Prevent auto column generation
                        dataGridView1.AutoGenerateColumns = false;

                        // Bind database columns to your predefined DataGridView columns
                        dataGridView1.Columns["Column1"].DataPropertyName = "idAchivementPlayer";
                        dataGridView1.Columns["Column2"].DataPropertyName = "trophie";
                        dataGridView1.Columns["Column3"].DataPropertyName = "dateAchived";
                        dataGridView1.Columns["Column4"].DataPropertyName = "leagalefullname";

                        // Set the DataGridView's DataSource
                        dataGridView1.DataSource = achivementPlayerTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading achivementPlayer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SearchAchievementByPlayerName(string playerName)
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"
        SELECT ap.idAchivementPlayer, ap.trophie, ap.dateAchived, p.leagalefullname
        FROM achivementPlayer ap
        INNER JOIN player p ON ap.player_idPlayer = p.idPlayer
        WHERE p.leagalefullname LIKE @playerName;";

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
                            DataTable searchResultsTable = new DataTable();
                            adapter.Fill(searchResultsTable);

                            if (searchResultsTable.Rows.Count > 0)
                            {
                                // Prevent auto column generation
                                dataGridView1.AutoGenerateColumns = false;

                                // Bind database columns to your predefined DataGridView columns
                                dataGridView1.Columns["Column1"].DataPropertyName = "idAchivementPlayer";
                                dataGridView1.Columns["Column2"].DataPropertyName = "trophie";
                                dataGridView1.Columns["Column3"].DataPropertyName = "dateAchived";
                                dataGridView1.Columns["Column4"].DataPropertyName = "leagalefullname";

                                // Set the DataGridView's DataSource
                                dataGridView1.DataSource = searchResultsTable;
                            }
                            else
                            {
                                MessageBox.Show("No achievements found for the given player name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
