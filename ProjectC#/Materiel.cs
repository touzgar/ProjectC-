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
    public partial class Materiel : Form
    {
        private int selectedMateriellId;
        public Materiel()
        {
            InitializeComponent();
        }

        private void Materiel_Load(object sender, EventArgs e)
        {
            LoadClubsIntoComboBox();
            LoadMaterielData();

        }

        private void MaterielName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaterielName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantite_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateCreation_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateCreation_ValueChanged(object sender, EventArgs e)
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
            string searchText = textBoxSearch.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a materiel name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the search method
            SearchMaterielByName(searchText);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            // Automatically search as the user types
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                SearchMaterielByName(searchText);
            }
            else
            {
                // Reload all data if the search box is cleared
                LoadMaterielData();
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string materielName = textBoxMaterielName.Text.Trim();
            int quantite;
            DateTime creationDate = dateTimePickerDateCreation.Value;

            if (string.IsNullOrEmpty(materielName))
            {
                MessageBox.Show("Please enter a valid material name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxQuantite.Text.Trim(), out quantite) || quantite <= 0)
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
            string query = "INSERT INTO materiel (materielName, quantite, dateCreation, club_idClub) VALUES (@materielName, @quantite, @creationDate, @clubId);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Bind parameters to the query
                        command.Parameters.AddWithValue("@materielName", materielName);
                        command.Parameters.AddWithValue("@quantite", quantite);
                        command.Parameters.AddWithValue("@creationDate", creationDate);
                        command.Parameters.AddWithValue("@clubId", clubId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Materiel created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMaterielData(); // Refresh the data in the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the materiel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selectedMateriellId <= 0)
            {
                MessageBox.Show("Please select a materiel to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect updated data from form fields
            string materielName = textBoxMaterielName.Text.Trim();
            int quantite;
            DateTime creationDate = dateTimePickerDateCreation.Value;

            if (string.IsNullOrEmpty(materielName))
            {
                MessageBox.Show("Please enter a valid materiel name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxQuantite.Text.Trim(), out quantite) || quantite <= 0)
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

            // Database connection and query for updating the materiel
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"UPDATE materiel 
                     SET MaterielName = @materielName, quantite = @quantite, dateCreation = @creationDate, club_idClub = @clubId
                     WHERE idMateriel = @idMateriel;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@materielName", materielName);
                        command.Parameters.AddWithValue("@quantite", quantite);
                        command.Parameters.AddWithValue("@creationDate", creationDate);
                        command.Parameters.AddWithValue("@clubId", clubId);
                        command.Parameters.AddWithValue("@idMateriel", selectedMateriellId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Materiel updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMaterielData(); // Refresh the data in the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the materiel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Ensure a materiel is selected
            if (selectedMateriellId <= 0)
            {
                MessageBox.Show("Please select a materiel to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this materiel?",
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
            string query = "DELETE FROM materiel WHERE idMateriel = @idMateriel;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idMateriel", selectedMateriellId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Materiel deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMaterielData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the materiel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                selectedMateriellId = Convert.ToInt32(row.Cells["Column1"].Value); // idMateriel
                textBoxMaterielName.Text = row.Cells["Column2"].Value.ToString(); // MaterielName
                textBoxQuantite.Text = row.Cells["Column3"].Value.ToString(); // quantite
                dateTimePickerDateCreation.Value = Convert.ToDateTime(row.Cells["Column4"].Value); // dateCreation
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
        private void LoadMaterielData()
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT m.idMateriel, m.MaterielName, m.quantite, m.dateCreation, c.clubName
                             FROM materiel m
                             INNER JOIN club c ON m.club_idClub = c.idClub;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable MaterielTable = new DataTable();
                        adapter.Fill(MaterielTable);

                        // Prevent auto column generation
                        dataGridView1.AutoGenerateColumns = false;

                        // Bind database columns to your predefined DataGridView columns
                        dataGridView1.Columns["Column1"].DataPropertyName = "idMateriel";         // idTeam column
                        dataGridView1.Columns["Column2"].DataPropertyName = "MaterielName";      // teamName column
                        dataGridView1.Columns["Column3"].DataPropertyName = "Quantite";   // description column
                        dataGridView1.Columns["Column4"].DataPropertyName = "DateCreation";  // dateCreation column
                        dataGridView1.Columns["Column5"].DataPropertyName = "clubName";      // clubName (from the club table)

                        // Set the DataGridView's DataSource
                        dataGridView1.DataSource = MaterielTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading Materiel data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SearchMaterielByName(string materielName)
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT m.idMateriel, m.materielName, m.quantite, m.dateCreation, c.clubName
                     FROM materiel m
                     INNER JOIN club c ON m.club_idClub = c.idClub
                     WHERE m.materielName LIKE @materielName;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter with wildcard for partial matches
                        command.Parameters.AddWithValue("@materielName", "%" + materielName + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable logicielTable = new DataTable();
                            adapter.Fill(logicielTable);

                            if (logicielTable.Rows.Count > 0)
                            {
                                // Prevent auto column generation
                                dataGridView1.AutoGenerateColumns = false;

                                // Bind database columns to your predefined DataGridView columns
                                dataGridView1.Columns["Column1"].DataPropertyName = "idMateriel";      // idCoach column
                                dataGridView1.Columns["Column2"].DataPropertyName = "materielName";    // coachName column
                                dataGridView1.Columns["Column3"].DataPropertyName = "quantite";  // mailAddress column
                                dataGridView1.Columns["Column4"].DataPropertyName = "dateCreation";  // dateOfBirth column
                                dataGridView1.Columns["Column5"].DataPropertyName = "clubName";     // clubName column

                                // Set the DataGridView's DataSource
                                dataGridView1.DataSource = logicielTable;
                            }
                            else
                            {
                                MessageBox.Show("No materiels found matching the search term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
