using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectC_


{
    public partial class utilisateur : Form


    {
        public utilisateur()
        {
            InitializeComponent();
        }
        private int selectedUserId = -1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void utilisateur_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void buttonLoadUsers_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers(string searchQuery = "")
        {
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Adjust query to include search filtering if a search query is provided
                    string query = "SELECT idUser, username, password, role, email FROM user";
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query += " WHERE username LIKE @searchQuery OR email LIKE @searchQuery OR role LIKE @searchQuery";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchQuery))
                        {
                            command.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dataTable;

                                // Rename columns and adjust widths
                                dataGridView1.Columns["Column1"].HeaderText = "User ID";
                                dataGridView1.Columns["Column2"].HeaderText = "Username";
                                dataGridView1.Columns["Column3"].HeaderText = "Password";
                                dataGridView1.Columns["Column4"].HeaderText = "Role";
                                dataGridView1.Columns["Column5"].HeaderText = "Email";

                                dataGridView1.Columns["Column1"].Width = 50;
                            }
                            else
                            {
                                dataGridView1.DataSource = null;
                                MessageBox.Show("No users found matching your query.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Form field values
            string username = Username.Text.Trim(); // Assuming this is for username
            string password = Password.Text.Trim(); // Assuming this is for password
            string role = Role.Text.Trim(); // Assuming this is for role
            string email = Email.Text.Trim(); // Assuming this is for email

            // Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insert query
                    string query = "INSERT INTO user (UserName, Password, Email, role) VALUES (@username, @password, @email, @role)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@role", role);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Send email
                            SendEmail(email, username, password);

                            // Show success message
                            MessageBox.Show("User saved and email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView to include the new user
                            LoadUsers();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get updated values from input fields
            string username = Username.Text.Trim();
            string password = Password.Text.Trim();
            string role = Role.Text.Trim();
            string email = Email.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Update query
                    string query = "UPDATE user SET UserName = @username, Password = @password, Email = @email, role = @role WHERE idUser = @idUser";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Bind parameters
                        command.Parameters.AddWithValue("@idUser", selectedUserId);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@role", role);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Send email with updated details
                            SendEmail(email, username, password);

                            MessageBox.Show("User updated successfully and email sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView to reflect changes
                            LoadUsers();

                            // Clear the form
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            selectedUserId = -1;
            Username.Clear();
            Password.Clear();
            Role.Clear();
            Email.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Server=localhost;Port=3306;Database=projectc#;Uid=root;Pwd=Mysql123@;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Delete query
                    string query = "DELETE FROM user WHERE idUser = @idUser";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idUser", selectedUserId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView to remove the deleted user
                            LoadUsers();

                            // Clear the form
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        // Method to send email
        private void SendEmail(string email, string username, string password)
        {
            try
            {
                var fromAddress = new MailAddress("ghaithslama115@gmail.com", "Your App Name");
                var toAddress = new MailAddress(email);
                const string fromPassword = "wiye xoxl tdjp rqbj";
                const string subject = "Your Account Details Have Been Updated";
                string body = $"Hello,\n\nYour account details have been updated successfully. Here are your updated login credentials:\n\n" +
                              $"Username: {username}\nPassword: {password}\n\n" +
                              "Please log in to your account to verify these changes.\n\nThank you!";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Debugging line to check the content of the cell
                MessageBox.Show($"Selected User ID: {row.Cells["Column1"].Value}");

                //// Store the selected user's ID
                selectedUserId = Convert.ToInt32(row.Cells["Column1"].Value);

                // Populate input fields with the row's data
                Username.Text = row.Cells["Column2"].Value.ToString();
                Password.Text = row.Cells["Column3"].Value.ToString();
                Role.Text = row.Cells["Column4"].Value.ToString();
                Email.Text = row.Cells["Column5"].Value.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox3.Text.Trim();

            // Only search if DataGridView is initialized
            if (dataGridView1 != null)
            {
                LoadUsers(searchQuery);
            }
            else
            {
                MessageBox.Show("The user list is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
