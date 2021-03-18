using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace CarSales {
    public partial class SignupForm : Form {
        public SignupForm() {
            InitializeComponent();
        }

        private void backButtonSignUpForm_Click(object sender, EventArgs e) {
            LoginForm loginForm = new LoginForm();

            this.Hide();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = Location;
            loginForm.Size = Size;
            loginForm.Show();
        }
        
        private void SignUpButtonSignUpForm_Click(object sender, EventArgs e) {
            var connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = "INSERT INTO Users(Username, Password) VALUES(@username, @password)";
            string userQuery = "SELECT count(*) FROM Users WHERE Username = @usernamecheck";
          
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlCommand checkUserExists = new MySqlCommand(userQuery, connection);

            checkUserExists.Parameters.AddWithValue("@usernamecheck", usernameTextBoxSignUpForm.Text);

            int UserExists = Convert.ToInt32(checkUserExists.ExecuteScalar());

            if (UserExists > 0) {
                MessageBox.Show("Username taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBoxSignUpForm.Clear();
                passwordTextBoxSignUpForm.Clear();
                confirmPasswordTextboxSignUpForm.Clear();
                usernameTextBoxSignUpForm.Focus();
            } else {
                if (usernameTextBoxSignUpForm.Text == "" && passwordTextBoxSignUpForm.Text == "") {
                    MessageBox.Show("Please enter a username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBoxSignUpForm.Focus();
                    return;
                }
                if (usernameTextBoxSignUpForm.Text == "") {
                    MessageBox.Show("Please enter a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBoxSignUpForm.Focus();
                    return;
                }
                if (passwordTextBoxSignUpForm.Text == "") {
                    MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBoxSignUpForm.Focus();
                    return;
                }

                if (passwordTextBoxSignUpForm.Text.Equals(confirmPasswordTextboxSignUpForm.Text))
                {

                    cmd.Parameters.AddWithValue("@username", usernameTextBoxSignUpForm.Text);
                    cmd.Parameters.AddWithValue("@password", passwordTextBoxSignUpForm.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign up Successful!\n\nHello " + usernameTextBoxSignUpForm.Text + "\n");

                    connection.Close();

                    LoginForm loginForm = new LoginForm();

                    this.Hide();
                    loginForm.StartPosition = FormStartPosition.Manual;
                    loginForm.Location = Location;
                    loginForm.Size = Size;
                    loginForm.Show();

                }
                else {
                    MessageBox.Show("Passwords do not match!");
                    usernameTextBoxSignUpForm.Clear();
                    passwordTextBoxSignUpForm.Clear();
                    confirmPasswordTextboxSignUpForm.Clear();
                }


            }
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void password1Visible_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBoxSignUpForm.PasswordChar = password1Visible.Checked ? '\0' : '*';
        }

        private void password2Visible_CheckedChanged(object sender, EventArgs e)
        {
            confirmPasswordTextboxSignUpForm.PasswordChar = password2Visible.Checked ? '\0' : '*';
        }
    }
}
