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
    public partial class AddTeamToTournament : Form
    {
        public event Action RefreshTournamentData;
        public AddTeamToTournament()
        {
            InitializeComponent();
        }

        private void AddTeamToTournament_Load(object sender, EventArgs e)
        {
            LoadTournaments();
            LoadTeams();

        }

        private void TeamName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTournamentName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Accept_Click(object sender, EventArgs e)
        {
            // Get the selected values from ComboBoxes
            int tournamentId = (int)comboBoxTournamentName.SelectedValue;
            int teamId = (int)comboBoxTeamName.SelectedValue;

            // SQL query to insert into the junction table (assumed name: tournament_team)
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "INSERT INTO tournament_has_team (tournament_idTournament, team_idTeam) VALUES (@tournamentId, @teamId)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tournamentId", tournamentId);
                        command.Parameters.AddWithValue("@teamId", teamId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Team added to tournament successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh the data in the main form
                            RefreshTournamentData?.Invoke();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add team to tournament.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void LoadTournaments()
        {
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idTournament, tournamentName FROM tournament";

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
                        comboBoxTournamentName.DataSource = tournamentTable;
                        comboBoxTournamentName.DisplayMember = "tournamentName";
                        comboBoxTournamentName.ValueMember = "idTournament";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading tournaments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadTeams()
        {
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idTeam, teamName FROM team";

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
