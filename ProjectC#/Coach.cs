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
    public partial class Coach : Form
    {
        private int selectedCoachId;
        public Coach()
        {
            InitializeComponent();
        }

        private void Coach_Load(object sender, EventArgs e)
        {
            LoadClubsIntoComboBox();
            LoadCoachData();

        }

        private void coachName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCoachName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailAddress_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
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
                MessageBox.Show("Please enter a coach name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the search method
            SearchCoachByName(searchText);
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            // Automatically search as the user types
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                SearchCoachByName(searchText);
            }
            else
            {
                // Reload all data if the search box is cleared
                LoadCoachData();
            }
        }


        private void Create_Click(object sender, EventArgs e)
        {
            string coachName = textBoxCoachName.Text.Trim();
            string mailAddress = textBoxMailAddress.Text.Trim();
            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;

            if (comboBoxClubName.SelectedItem == null)
            {
                MessageBox.Show("Please select a club.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email validation using a regular expression
            if (!IsValidEmail(mailAddress))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clubId = (int)comboBoxClubName.SelectedValue; // Ensure this matches the ValueMember of the ComboBox

            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = "INSERT INTO coach (coachName, mailAddress, dateOfBirth, club_idClub) VALUES (@coachName, @mailAddress, @dateOfBirth, @clubId);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@coachName", coachName);
                        command.Parameters.AddWithValue("@mailAddress", mailAddress);
                        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@clubId", clubId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Coach created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCoachData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the coach.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Validates if the provided email address is in a correct format.
        /// </summary>
        /// <param name="email">The email address to validate.</param>
        /// <returns>True if valid, otherwise false.</returns>
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        private void Update_Click(object sender, EventArgs e)
        {
            if (selectedCoachId <= 0) // Ensure a coach is selected
            {
                MessageBox.Show("Please select a coach to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect updated data from form fields
            string coachName = textBoxCoachName.Text.Trim();
            string mailAddress = textBoxMailAddress.Text.Trim();
            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;

            if (comboBoxClubName.SelectedItem == null)
            {
                MessageBox.Show("Please select a club.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clubId = (int)comboBoxClubName.SelectedValue;

            // Validate email address format
            if (!IsValidEmail(mailAddress))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection and query
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"UPDATE coach 
                     SET coachName = @coachName, mailAddress = @mailAddress, dateOfBirth = @dateOfBirth, club_idClub = @clubId
                     WHERE idCoach= @idCoach;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@coachName", coachName);
                        command.Parameters.AddWithValue("@mailAddress", mailAddress);
                        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@clubId", clubId);
                        command.Parameters.AddWithValue("@idCoach", selectedCoachId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Coach updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCoachData(); // Refresh data in DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the coach.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Ensure a coach is selected
            if (selectedCoachId <= 0)
            {
                MessageBox.Show("Please select a coach to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this coach?",
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
            string query = "DELETE FROM coach WHERE idCoach = @idCoach;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idCoach", selectedCoachId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Coach deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCoachData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the coach.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                selectedCoachId = Convert.ToInt32(row.Cells["Column1"].Value); // idCoach
                textBoxCoachName.Text = row.Cells["Column2"].Value.ToString(); // coachName
                textBoxMailAddress.Text = row.Cells["Column3"].Value.ToString(); // mailAddress
                dateTimePickerDateOfBirth.Value = Convert.ToDateTime(row.Cells["Column4"].Value); // dateOfBirth
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
        private void LoadCoachData()
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT co.idCoach, co.coachName, co.mailAddress, co.dateOfBirth, c.clubName
                             FROM coach co
                             INNER JOIN club c ON co.club_idClub = c.idClub;";

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

                        // Prevent auto column generation
                        dataGridView1.AutoGenerateColumns = false;

                        // Bind database columns to your predefined DataGridView columns
                        dataGridView1.Columns["Column1"].DataPropertyName = "idCoach";         // idTeam column
                        dataGridView1.Columns["Column2"].DataPropertyName = "CoachName";      // teamName column
                        dataGridView1.Columns["Column3"].DataPropertyName = "MailAddress";   // description column
                        dataGridView1.Columns["Column4"].DataPropertyName = "DateOfBirth";  // dateCreation column
                        dataGridView1.Columns["Column5"].DataPropertyName = "clubName";      // clubName (from the club table)

                        // Set the DataGridView's DataSource
                        dataGridView1.DataSource = coachTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading coach data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SearchCoachByName(string coachName)
        {
            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            string query = @"SELECT co.idCoach, co.coachName, co.mailAddress, co.dateOfBirth, c.clubName
                     FROM coach co
                     INNER JOIN club c ON co.club_idClub = c.idClub
                     WHERE co.coachName LIKE @coachName;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter with wildcard for partial matches
                        command.Parameters.AddWithValue("@coachName", "%" + coachName + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable coachTable = new DataTable();
                            adapter.Fill(coachTable);

                            if (coachTable.Rows.Count > 0)
                            {
                                // Prevent auto column generation
                                dataGridView1.AutoGenerateColumns = false;

                                // Bind database columns to your predefined DataGridView columns
                                dataGridView1.Columns["Column1"].DataPropertyName = "idCoach";      // idCoach column
                                dataGridView1.Columns["Column2"].DataPropertyName = "coachName";    // coachName column
                                dataGridView1.Columns["Column3"].DataPropertyName = "mailAddress";  // mailAddress column
                                dataGridView1.Columns["Column4"].DataPropertyName = "dateOfBirth";  // dateOfBirth column
                                dataGridView1.Columns["Column5"].DataPropertyName = "clubName";     // clubName column

                                // Set the DataGridView's DataSource
                                dataGridView1.DataSource = coachTable;
                            }
                            else
                            {
                                MessageBox.Show("No coaches found matching the search term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
