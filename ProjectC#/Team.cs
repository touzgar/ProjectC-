using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectC_
{
    public partial class Team : Form
    {
        private int selectedTeamId;
        public Team()
        {
            InitializeComponent();

        }


        private void Team_Load(object sender, EventArgs e)
        {
            LoadClubsIntoComboBox();
            LoadTeamData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TeamName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1TeamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerCreation_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClubName_Click(object sender, EventArgs e)
        {

        }

        private void textBox4ClubName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            string teamName = textBox1TeamName.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            DateTime creationDate = dateTimePickerCreation.Value;

            if (comboBoxClubName.SelectedItem == null)
            {
                MessageBox.Show("Please select a club.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clubId = (int)comboBoxClubName.SelectedValue; // Ensure this matches the ValueMember of the ComboBox

            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "INSERT INTO team (teamName, description, dateCreation, club_idClub) VALUES (@teamName, @description, @creationDate, @clubId);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teamName", teamName);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@creationDate", creationDate);
                        command.Parameters.AddWithValue("@clubId", clubId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Team created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTeamData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selectedTeamId <= 0)
            {
                MessageBox.Show("Please select a team to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect updated data from form fields
            string teamName = textBox1TeamName.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            DateTime creationDate = dateTimePickerCreation.Value;

            if (comboBoxClubName.SelectedItem == null)
            {
                MessageBox.Show("Please select a club.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clubId = (int)comboBoxClubName.SelectedValue;

            // Database connection and query
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"UPDATE team 
                     SET teamName = @teamName, description = @description, dateCreation = @creationDate, club_idClub = @clubId
                     WHERE idTeam = @idTeam;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teamName", teamName);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@creationDate", creationDate);
                        command.Parameters.AddWithValue("@clubId", clubId);
                        command.Parameters.AddWithValue("@idTeam", selectedTeamId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Team updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTeamData(); // Refresh data in DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Ensure a team is selected
            if (selectedTeamId <= 0)
            {
                MessageBox.Show("Please select a team to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this team?",
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
            string query = "DELETE FROM team WHERE idTeam = @idTeam;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idTeam", selectedTeamId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Team deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTeamData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchTeamByName(string teamName)
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idTeam, teamName, description, dateCreation FROM team WHERE teamName LIKE @teamName;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter with wildcard for partial matches
                        command.Parameters.AddWithValue("@teamName", "%" + teamName + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable teamTable = new DataTable();
                            adapter.Fill(teamTable);

                            if (teamTable.Rows.Count > 0)
                            {
                                // Prevent auto column generation
                                dataGridView1.AutoGenerateColumns = false;

                                // Bind database columns to your predefined DataGridView columns
                                dataGridView1.Columns["Column1"].DataPropertyName = "idTeam";
                                dataGridView1.Columns["Column5"].DataPropertyName = "teamName";
                                dataGridView1.Columns["Column2"].DataPropertyName = "description";
                                dataGridView1.Columns["Column3"].DataPropertyName = "dateCreation";
                                dataGridView1.Columns["Column4"].DataPropertyName = "clubName";

                                // Set the DataGridView's DataSource
                                dataGridView1.DataSource = teamTable;
                            }
                            else
                            {
                                MessageBox.Show("No teams found matching the search term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a team name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the search method
            SearchTeamByName(searchText);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            // Automatically search as the user types
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                SearchTeamByName(searchText);
            }
            else
            {
                // Reload all data if the search box is cleared
                LoadTeamData();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Retrieve data from the selected row and populate the form fields
                selectedTeamId = Convert.ToInt32(row.Cells["Column1"].Value); // idTeam
                textBox1TeamName.Text = row.Cells["Column5"].Value.ToString(); // teamName
                textBoxDescription.Text = row.Cells["Column2"].Value.ToString(); // description
                dateTimePickerCreation.Value = Convert.ToDateTime(row.Cells["Column3"].Value); // dateCreation
                comboBoxClubName.Text = row.Cells["Column4"].Value.ToString(); // clubName
            }
        }

        private void comboBoxClubName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadClubsIntoComboBox()
        {
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idClub, clubName FROM club;";

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

                        comboBoxClubName.DataSource = clubTable;
                        comboBoxClubName.DisplayMember = "clubName";
                        comboBoxClubName.ValueMember = "idClub";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading clubs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadTeamData()
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"
        SELECT t.idTeam, t.teamName, t.description, t.dateCreation, c.clubName, p.leagalefullname
        FROM team t
        INNER JOIN club c ON t.club_idClub = c.idClub
        LEFT JOIN player p ON p.team_idTeam = t.idTeam";
      



            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable teamTable = new DataTable();
                        adapter.Fill(teamTable);

                        // Prevent auto column generation
                        dataGridView1.AutoGenerateColumns = false;

                        // Bind database columns to your predefined DataGridView columns
                        dataGridView1.Columns["Column1"].DataPropertyName = "idTeam";         // idTeam column
                        dataGridView1.Columns["Column5"].DataPropertyName = "teamName";      // teamName column
                        dataGridView1.Columns["Column2"].DataPropertyName = "description";   // description column
                        dataGridView1.Columns["Column3"].DataPropertyName = "dateCreation";  // dateCreation column
                        dataGridView1.Columns["Column4"].DataPropertyName = "clubName";      // clubName (from the club table)
                        dataGridView1.Columns["Column6"].DataPropertyName = "leagalefullname"; // leagalefullname from the player table
                        dataGridView1.Columns["Column7"].DataPropertyName = "coachName"; // leagalefullname from the player table

                        // Set the DataGridView's DataSource
                        dataGridView1.DataSource = teamTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading team data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddPlayerToTeam addPlayerForm = new AddPlayerToTeam();
            addPlayerForm.RefreshTeamData += LoadTeamData;
            addPlayerForm.ShowDialog();
        }

        private void removePlayerFromTeam_Click(object sender, EventArgs e)
        {
            RemovePlayerFromTeam removePlayerForm = new RemovePlayerFromTeam();
            removePlayerForm.RefreshTeamData += LoadTeamData; // Subscribe to the event
            removePlayerForm.ShowDialog();
        }

        private void AddCoachToTeam_Click(object sender, EventArgs e)
        {
            AddCoachToTeam addCoachForm = new AddCoachToTeam();
            addCoachForm.RefreshTeamData += LoadTeamData;
            addCoachForm.ShowDialog();
        }

        private void RemoveCoachFromTeam_Click(object sender, EventArgs e)
        {
            RemoveCoachFromTeam RemoveCoachForm = new RemoveCoachFromTeam();
            RemoveCoachForm.RefreshCoachData += LoadTeamData;
            RemoveCoachForm.ShowDialog();
        }
    }
}
