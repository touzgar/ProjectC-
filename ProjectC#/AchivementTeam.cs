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
    public partial class AchivementTeam : Form
    {
        private int selectedAchivementTeamId;
        public AchivementTeam()
        {
            InitializeComponent();
        }

        private void AchivementTeam_Load(object sender, EventArgs e)
        {
            LoadTeamsIntoComboBox();
            LoadAchivementTeamData();
        }

        private void Trophie_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTrophie_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateAchived_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerAchived_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TeamName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Search_Click(object sender, EventArgs e)
        {
            string searchTeamName = textBox1.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(searchTeamName))
            {
                MessageBox.Show("Please enter a team name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT at.idAchivementTeam, at.trophie, at.dateAchived, t.teamName
                     FROM achivementteam at
                     INNER JOIN team t ON at.team_idTeam = t.idTeam
                     WHERE t.teamName LIKE @teamName;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teamName", $"%{searchTeamName}%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable searchResults = new DataTable();
                            adapter.Fill(searchResults);

                            // Bind the search results to the DataGridView
                            dataGridView1.DataSource = searchResults;

                            if (searchResults.Rows.Count == 0)
                            {
                                MessageBox.Show("No matching achievements found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"{searchResults.Rows.Count} matching records found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadAchivementTeamData(); // Reload all data
        }


        private void Create_Click(object sender, EventArgs e)
        {
            string trophie = textBoxTrophie.Text.Trim();
            DateTime dateAchived = dateTimePickerAchived.Value;

            if (comboBoxTeamName.SelectedItem == null)
            {
                MessageBox.Show("Please select a team.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int teamId = (int)comboBoxTeamName.SelectedValue; // Ensure this matches the ValueMember of the ComboBox

            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "INSERT INTO achivementteam (trophie, dateAchived, team_idTeam) VALUES (@trophie, @dateAchived, @teamId);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@trophie", trophie);
                        command.Parameters.AddWithValue("@dateAchived", dateAchived);
                        command.Parameters.AddWithValue("@teamId", teamId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("AchivementTeam created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAchivementTeamData();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedAchivementTeamId <= 0)
            {
                MessageBox.Show("Please select an achievement to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect updated data from form fields
            string trophie = textBoxTrophie.Text.Trim();
            DateTime dateAchived = dateTimePickerAchived.Value;

            if (comboBoxTeamName.SelectedItem == null)
            {
                MessageBox.Show("Please select a team.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int teamId = (int)comboBoxTeamName.SelectedValue; // Ensure correct assignment here

            // Database connection and query
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"UPDATE achivementteam 
                     SET trophie = @trophie, dateAchived = @dateAchived, team_idTeam = @teamId
                     WHERE idAchivementTeam = @idAchivementTeam;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@trophie", trophie);
                        command.Parameters.AddWithValue("@dateAchived", dateAchived);
                        command.Parameters.AddWithValue("@teamId", teamId);
                        command.Parameters.AddWithValue("@idAchivementTeam", selectedAchivementTeamId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Achievement updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAchivementTeamData(); // Refresh data in DataGridView
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
            if (selectedAchivementTeamId <= 0)
            {
                MessageBox.Show("Please select a achivementTeam to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this AchivementTeam?",
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
            string query = "DELETE FROM achivementteam WHERE idAchivementTeam = @idAchivementTeam;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idAchivementTeam", selectedAchivementTeamId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("AchivementTeam deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAchivementTeamData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the AchivementTeam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            

        }
        private void LoadTeamsIntoComboBox()
        {
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idTeam, teamName FROM team;";

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

                        comboBoxTeamName.DataSource = teamTable;
                        comboBoxTeamName.DisplayMember = "teamName";
                        comboBoxTeamName.ValueMember = "idTeam";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading teams: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Retrieve data from the selected row and populate the form fields
                selectedAchivementTeamId = Convert.ToInt32(row.Cells["Column1"].Value);

                textBoxTrophie.Text = row.Cells["Column2"].Value.ToString();
                dateTimePickerAchived.Value = Convert.ToDateTime(row.Cells["Column3"].Value);
                comboBoxTeamName.Text = row.Cells["Column4"].Value.ToString();
            }
        }
        private void LoadAchivementTeamData()
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT at.idAchivementTeam, at.trophie, at.dateAchived, t.teamName
                             FROM achivementteam at
                             INNER JOIN team t ON at.team_idTeam = t.idTeam;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable achivementTeamTable = new DataTable();
                        adapter.Fill(achivementTeamTable);

                        // Prevent auto column generation
                        dataGridView1.AutoGenerateColumns = false;

                        // Bind database columns to your predefined DataGridView columns
                        dataGridView1.Columns["Column1"].DataPropertyName = "idAchivementTeam";         
                        dataGridView1.Columns["Column2"].DataPropertyName = "trophie";     
                        dataGridView1.Columns["Column3"].DataPropertyName = "dateAchived";  
                        dataGridView1.Columns["Column4"].DataPropertyName = "teamName";     

                        // Set the DataGridView's DataSource
                        dataGridView1.DataSource = achivementTeamTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading achivementTeam data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
