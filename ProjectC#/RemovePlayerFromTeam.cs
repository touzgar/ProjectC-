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
    public partial class RemovePlayerFromTeam : Form
    {
        public event Action RefreshTeamData;
        public RemovePlayerFromTeam()
        {
            InitializeComponent();
        }

        private void RemovePlayerFromTeam_Load(object sender, EventArgs e)
        {
            LoadPlayersIntoComboBox();
            LoadTeamsIntoComboBox();
        }

        private void TeamName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlayerName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPlayerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Accept_Click(object sender, EventArgs e)
        {
            int playerId = (int)comboBoxPlayerName.SelectedValue;
            int teamId = (int)comboBoxTeamName.SelectedValue;

            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "UPDATE player SET team_idTeam = 0 WHERE idPlayer = @playerId AND team_idTeam = @teamId;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@playerId", playerId);
                        command.Parameters.AddWithValue("@teamId", teamId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Player removed from team successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                            // Notify the Team form to refresh the data
                            RefreshTeamData?.Invoke();
                        }
                        else
                        {
                            MessageBox.Show("Player was not removed. Please check the data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while removing the player: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
