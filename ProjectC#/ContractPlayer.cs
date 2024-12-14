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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectC_
{
    public partial class ContractPlayer : Form
    {
        private int selectedContractPlayerId;
        public ContractPlayer()
        {
            InitializeComponent();
        }

        private void ContractPlayer_Load(object sender, EventArgs e)
        {
            LoadContractPlayerData();
            LoadPlayersIntoComboBox();
        }

        private void contractName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContractName_TextChanged(object sender, EventArgs e)
        {

        }

        private void termesFinanciere_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTermesFinanciere_TextChanged(object sender, EventArgs e)
        {

        }

        private void objective_Click(object sender, EventArgs e)
        {

        }

        private void textBoxObjective_TextChanged(object sender, EventArgs e)
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

        private void playerName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPlayerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim(); // Assuming textBox1 is your search textbox

            // Validate input
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a player name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the search method
            SearchContractplayerByPlayerName(searchText);


        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            // Automatically search as the user types
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                SearchContractplayerByPlayerName(searchText);
            }
            else
            {
                // Reload all data if the search box is cleared
                LoadContractPlayerData();
            }

        }

        private void Create_Click(object sender, EventArgs e)
        {
            string contractName = textBoxContractName.Text.Trim();
            string termesFinanciere = textBoxTermesFinanciere.Text.Trim();
            string objective = textBoxObjective.Text.Trim();
            DateTime dateStart = dateTimePickerDateStart.Value;
            DateTime dateEnd = dateTimePickerDateEnd.Value;

            if (comboBoxPlayerName.SelectedItem == null)
            {
                MessageBox.Show("Please select a player.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int playerId = (int)comboBoxPlayerName.SelectedValue; // Ensure this matches the ValueMember of the ComboBox

            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "INSERT INTO contractPlayer (contractName, termesFinanciere,objective, dateStart,dateEnd, player_idPlayer) VALUES (@contractName, @termesFinanciere,@objective, @dateStart,@dateEnd, @playerId);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@contractName", contractName);
                        command.Parameters.AddWithValue("@termesFinanciere", termesFinanciere);
                        command.Parameters.AddWithValue("@objective", objective);

                        command.Parameters.AddWithValue("@dateStart", dateStart);
                        command.Parameters.AddWithValue("@dateEnd", dateEnd);

                        command.Parameters.AddWithValue("@playerId", playerId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ContractPlayer created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadContractPlayerData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the ContractPlayer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selectedContractPlayerId <= 0)
            {
                MessageBox.Show("Please select a contractPlayer to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contractName = textBoxContractName.Text.Trim();
            string termesFinanciere = textBoxTermesFinanciere.Text.Trim();
            string objective = textBoxObjective.Text.Trim();
            DateTime dateStart = dateTimePickerDateStart.Value;
            DateTime dateEnd = dateTimePickerDateEnd.Value;

            if (comboBoxPlayerName.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid player.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateEnd < dateStart)
            {
                MessageBox.Show("End date must be later than the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int playerId = (int)comboBoxPlayerName.SelectedValue;

            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"UPDATE contractPlayer 
                     SET contractName = @contractName, termesFinanciere = @termesFinanciere, objective = @objective, 
                         dateStart = @dateStart, dateEnd = @dateEnd, player_idPlayer = @playerId
                     WHERE idcontractPlayer = @idContractPlayer;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@contractName", contractName);
                        command.Parameters.AddWithValue("@termesFinanciere", termesFinanciere);
                        command.Parameters.AddWithValue("@objective", objective);
                        command.Parameters.AddWithValue("@dateStart", dateStart);
                        command.Parameters.AddWithValue("@dateEnd", dateEnd);
                        command.Parameters.AddWithValue("@playerId", playerId);
                        command.Parameters.AddWithValue("@idContractPlayer", selectedContractPlayerId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ContractPlayer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadContractPlayerData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the contractPlayer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Ensure a contract player is selected
            if (selectedContractPlayerId <= 0)
            {
                MessageBox.Show("Please select a contract player to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this contract player?",
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
            string query = "DELETE FROM contractPlayer WHERE idcontractPlayer = @idContractPlayer;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idContractPlayer", selectedContractPlayerId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Contract player deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadContractPlayerData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the contract player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Retrieve data from the selected row and populate the form fields
                selectedContractPlayerId = Convert.ToInt32(row.Cells["Column1"].Value); 
                textBoxContractName.Text = row.Cells["Column2"].Value.ToString(); 
                textBoxTermesFinanciere.Text = row.Cells["Column3"].Value.ToString(); 
                textBoxObjective.Text = row.Cells["Column4"].Value.ToString(); 

                dateTimePickerDateStart.Value = Convert.ToDateTime(row.Cells["Column5"].Value);
                dateTimePickerDateEnd.Value = Convert.ToDateTime(row.Cells["Column6"].Value); 

                comboBoxPlayerName.Text = row.Cells["Column7"].Value.ToString(); 
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
                    MessageBox.Show($"An error occurred while loading players: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadContractPlayerData()
        {
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT cp.idContractPlayer, cp.contractName, cp.termesFinanciere, cp.objective, cp.dateStart, cp.dateEnd, p.leagalefullname
                     FROM contractPlayer cp
                     INNER JOIN player p ON cp.player_idPlayer = p.idPlayer;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable contractPlayerTable = new DataTable();
                        adapter.Fill(contractPlayerTable);

                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.Columns["Column1"].DataPropertyName = "idContractPlayer";
                        dataGridView1.Columns["Column2"].DataPropertyName = "contractName";
                        dataGridView1.Columns["Column3"].DataPropertyName = "termesFinanciere";
                        dataGridView1.Columns["Column4"].DataPropertyName = "objective";
                        dataGridView1.Columns["Column5"].DataPropertyName = "dateStart";  // Corrected
                        dataGridView1.Columns["Column6"].DataPropertyName = "dateEnd";
                        dataGridView1.Columns["Column7"].DataPropertyName = "leagalefullname";

                        dataGridView1.DataSource = contractPlayerTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading contractPlayer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SearchContractplayerByPlayerName(string playerName)
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"
        SELECT ac.idcontractPlayer,ac.contractName, ac.termesFinanciere, ac.objective,ac.dateStart,ac.dateEnd, p.leagalefullname
        FROM contractPlayer ac
        INNER JOIN player p ON ac.player_idPlayer = p.idPlayer
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
                                dataGridView1.Columns["Column1"].DataPropertyName = "idcontractPlayer";
                                dataGridView1.Columns["Column2"].DataPropertyName = "contractPlayer";
                                dataGridView1.Columns["Column3"].DataPropertyName = "termesFinanciere";
                                dataGridView1.Columns["Column4"].DataPropertyName = "objective";
                                dataGridView1.Columns["Column5"].DataPropertyName = "dateStart";
                                dataGridView1.Columns["Column6"].DataPropertyName = "dateEnd";

                                dataGridView1.Columns["Column7"].DataPropertyName = "leagalefullname";

                                // Set the DataGridView's DataSource
                                dataGridView1.DataSource = searchResultsTable;
                            }
                            else
                            {
                                MessageBox.Show("No contractPlayers found for the given player name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
