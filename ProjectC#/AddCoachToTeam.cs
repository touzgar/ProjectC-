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
    public partial class AddCoachToTeam : Form
    {
        public event Action RefreshTeamData;
        public AddCoachToTeam()
        {
            InitializeComponent();
        }

        private void AddCoachToTeam_Load(object sender, EventArgs e)
        {
                LoadCoachs();
                LoadTeams();
        }

        private void teamName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CoachName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCoachName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Accept_Click(object sender, EventArgs e)
        {
            // Get the selected values from ComboBoxes
            int coachId = (int)comboBoxCoachName.SelectedValue;
            int teamId = (int)comboBoxTeamName.SelectedValue;

            // SQL query to insert into the junction table (assumed name: tournament_team)
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "INSERT INTO coach_has_team (coach_idCoach, team_idTeam) VALUES (@coachId, @teamId)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@coachId", coachId);
                        command.Parameters.AddWithValue("@teamId", teamId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Coach added to Team successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh the data in the main form
                           // RefreshTournamentData?.Invoke();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add coach to team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LoadCoachs()
        {
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "SELECT idCoach, coachName FROM coach";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable coachTable = new DataTable();
                        adapter.Fill(coachTable);
                        comboBoxCoachName.DataSource = coachTable;
                        comboBoxCoachName.DisplayMember = "coachName";
                        comboBoxCoachName.ValueMember = "idCoach";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading coachs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
