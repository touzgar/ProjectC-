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
    public partial class AddPlayerToTeam : Form
    {
        public event Action RefreshTeamData;
        public AddPlayerToTeam()
        {
            InitializeComponent();
        }

        private void AddPlayerToTeam_Load(object sender, EventArgs e)
        {
            LoadTeams();
            LoadPlayers();


        }

        private void teamName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playerName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPlayerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (comboBoxTeamName.SelectedItem == null || comboBoxPlayerName.SelectedItem == null)
            {
                MessageBox.Show("Please select both a team and a player.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int teamId = (int)comboBoxTeamName.SelectedValue;
            int playerId = (int)comboBoxPlayerName.SelectedValue;

            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "UPDATE player SET team_idTeam = @teamId WHERE idPlayer = @playerId;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teamId", teamId);
                        command.Parameters.AddWithValue("@playerId", playerId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Player added to the team successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the form after saving
                            RefreshTeamData?.Invoke();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the player to the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the player: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadTeams()
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

        private void LoadPlayers()
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

    }
}
