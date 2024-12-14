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
    public partial class Logiciel : Form
    {
        private int selectedLogicielId;
        public Logiciel()
        {
            InitializeComponent();
        }

        private void Logiciel_Load(object sender, EventArgs e)
        {
            LoadClubsIntoComboBox();
            LoadLogicielData();

        }

        private void LogicielName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogicielName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantite_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateCreation_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClubName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClubName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a logiciel name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the search method
            SearchLogicielByName(searchText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            // Automatically search as the user types
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                SearchLogicielByName(searchText);
            }
            else
            {
                // Reload all data if the search box is cleared
                LoadLogicielData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string logicielName = textBoxLogicielName.Text.Trim();
            int quantite;
            DateTime creationDate = dateTimePicker1.Value;

            if (!int.TryParse(textBox2.Text.Trim(), out quantite) || quantite <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxClubName.SelectedItem == null)
            {
                MessageBox.Show("Please select a club.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clubId = (int)comboBoxClubName.SelectedValue; // Ensure this matches the ValueMember of the ComboBox

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "INSERT INTO logiciel (logicielName, quantite, dateCreation, club_idClub) VALUES (@logicielName, @quantite, @creationDate, @clubId);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Bind parameters to the query
                        command.Parameters.AddWithValue("@logicielName", logicielName);
                        command.Parameters.AddWithValue("@quantite", quantite);
                        command.Parameters.AddWithValue("@creationDate", creationDate);
                        command.Parameters.AddWithValue("@clubId", clubId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Logiciel created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLogicielData(); // Refresh the data in the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the logiciel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Ensure an item is selected in the DataGridView
            if (selectedLogicielId <= 0)
            {
                MessageBox.Show("Please select a logiciel to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect updated data from form fields
            string logicielName = textBoxLogicielName.Text.Trim();
            int quantite;
            DateTime creationDate = dateTimePicker1.Value;

            if (!int.TryParse(textBox2.Text.Trim(), out quantite) || quantite <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxClubName.SelectedItem == null)
            {
                MessageBox.Show("Please select a club.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clubId = (int)comboBoxClubName.SelectedValue;

            // Database connection and query for updating the logiciel
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"UPDATE logiciel 
                     SET logicielName = @logicielName, quantite = @quantite, dateCreation = @creationDate, club_idClub = @clubId
                     WHERE idLogiciel = @idLogiciel;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@logicielName", logicielName);
                        command.Parameters.AddWithValue("@quantite", quantite);
                        command.Parameters.AddWithValue("@creationDate", creationDate);
                        command.Parameters.AddWithValue("@clubId", clubId);
                        command.Parameters.AddWithValue("@idLogiciel", selectedLogicielId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Logiciel updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLogicielData(); // Refresh the data in the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the logiciel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Ensure a logiciel is selected
            if (selectedLogicielId <= 0)
            {
                MessageBox.Show("Please select a logiciel to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this logiciel?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            // Database connection and query for deletion
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "DELETE FROM logiciel WHERE idLogiciel = @idLogiciel;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idLogiciel", selectedLogicielId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Logiciel deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLogicielData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the logiciel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                selectedLogicielId = Convert.ToInt32(row.Cells["Column1"].Value); // idLogiciel
                textBoxLogicielName.Text = row.Cells["Column2"].Value.ToString(); // logicielName
                textBox2.Text = row.Cells["Column3"].Value.ToString(); // quantite
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Column4"].Value); // dateCreation
                comboBoxClubName.Text = row.Cells["Column5"].Value.ToString(); // clubName
            }
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
        private void LoadLogicielData()
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT l.idLogiciel, l.logicielName, l.quantite, l.dateCreation, c.clubName
                             FROM logiciel l
                             INNER JOIN club c ON l.club_idClub = c.idClub;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable logicielTable = new DataTable();
                        adapter.Fill(logicielTable);

                        // Prevent auto column generation
                        dataGridView1.AutoGenerateColumns = false;

                        // Bind database columns to your predefined DataGridView columns
                        dataGridView1.Columns["Column1"].DataPropertyName = "idLogiciel";         // idTeam column
                        dataGridView1.Columns["Column2"].DataPropertyName = "LogicielName";      // teamName column
                        dataGridView1.Columns["Column3"].DataPropertyName = "Quantite";   // description column
                        dataGridView1.Columns["Column4"].DataPropertyName = "DateCreation";  // dateCreation column
                        dataGridView1.Columns["Column5"].DataPropertyName = "clubName";      // clubName (from the club table)

                        // Set the DataGridView's DataSource
                        dataGridView1.DataSource = logicielTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading logiciel data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SearchLogicielByName(string logicielName)
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT l.idLogiciel, l.logicielName, l.quantite, l.dateCreation, c.clubName
                     FROM logiciel l
                     INNER JOIN club c ON l.club_idClub = c.idClub
                     WHERE l.logicielName LIKE @logicielName;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter with wildcard for partial matches
                        command.Parameters.AddWithValue("@logicielName", "%" + logicielName + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable logicielTable = new DataTable();
                            adapter.Fill(logicielTable);

                            if (logicielTable.Rows.Count > 0)
                            {
                                // Prevent auto column generation
                                dataGridView1.AutoGenerateColumns = false;

                                // Bind database columns to your predefined DataGridView columns
                                dataGridView1.Columns["Column1"].DataPropertyName = "idLogiciel";      // idCoach column
                                dataGridView1.Columns["Column2"].DataPropertyName = "logicielName";    // coachName column
                                dataGridView1.Columns["Column3"].DataPropertyName = "quantite";  // mailAddress column
                                dataGridView1.Columns["Column4"].DataPropertyName = "dateCreation";  // dateOfBirth column
                                dataGridView1.Columns["Column5"].DataPropertyName = "clubName";     // clubName column

                                // Set the DataGridView's DataSource
                                dataGridView1.DataSource = logicielTable;
                            }
                            else
                            {
                                MessageBox.Show("No logiciels found matching the search term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
