﻿using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace CarSales
{
    public partial class LoginForm : Form
    {
        int count = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginFormButton_Click(object sender, EventArgs e)
        {
            // Checks for blank text boxes.
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                usernameTextBox.Focus();

                return;
            }

            try
            {
                // Get connection string from configuration file.
                var connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);

                string query = "Select * from Users where Username=@user and Password=@pass";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@user", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text);

                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Succesful!\n\nHello " + reader["Username"].ToString());

                    AccountForm accountForm = new AccountForm(reader["Username"].ToString(), reader["Password"].ToString());
                    connection.Close();

                    this.Hide();

                    accountForm.StartPosition = FormStartPosition.Manual;
                    accountForm.Location = Location;
                    accountForm.Size = Size;
                    accountForm.Show();

                }
                else if (count == 2)
                {
                    MessageBox.Show("Maximum login attempts reached!\n\nExiting program", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect!\n\nNumber of attempts remaining: " + (2-count), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    usernameTextBox.Focus();
                    count++;
                }
            }
            catch
            {
                MessageBox.Show("An unknown error has occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear inputs?",
                      "Clear Input",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.Yes)
            {
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                usernameTextBox.Focus();
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();

            this.Hide();

            signupForm.StartPosition = FormStartPosition.Manual;
            signupForm.Location = Location;
            signupForm.Size = Size;

            signupForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                      "Exit Dialog",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void passwordVisible_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = passwordVisible.Checked ? '\0' : '*';
        }
    }
}

