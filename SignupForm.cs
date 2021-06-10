using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace CarSales
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void backButtonSignUpForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();

            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = Location;
            loginForm.Size = Size;

            loginForm.Show();
        }
        
        private void SignUpButtonSignUpForm_Click(object sender, EventArgs e)
        {

            //get connection string from configuration file
            var connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            //SQL queries
            string query = "INSERT INTO Users(Username, Password) VALUES(@username, @password)";
            string userQuery = "SELECT count(*) FROM Users WHERE Username = @usernamecheck";
          
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlCommand checkUserExists = new MySqlCommand(userQuery, connection);

            checkUserExists.Parameters.AddWithValue("@usernamecheck", usernameTextBoxSignUpForm.Text);

            int UserExists = Convert.ToInt32(checkUserExists.ExecuteScalar());

            //if the username entered is taken already, display a message to the user
            if (UserExists > 0)
            {
                MessageBox.Show("Username is already in use!\nPlease choose another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                usernameTextBoxSignUpForm.Clear();
                passwordTextBoxSignUpForm.Clear();
                confirmPasswordTextboxSignUpForm.Clear();
                usernameTextBoxSignUpForm.Focus();

            }
            else
            {
                //checks for blank text boxes and display a message to the user
                if (usernameTextBoxSignUpForm.Text == "" || passwordTextBoxSignUpForm.Text == "" || confirmPasswordTextboxSignUpForm.Text == "")
                {
                    MessageBox.Show("Please fill in all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (passwordTextBoxSignUpForm.Text.Equals(confirmPasswordTextboxSignUpForm.Text))
                {
                    
                    //add username and password to database
                    cmd.Parameters.AddWithValue("@username", usernameTextBoxSignUpForm.Text);
                    cmd.Parameters.AddWithValue("@password", passwordTextBoxSignUpForm.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sign up Successful!\n\nHello " + usernameTextBoxSignUpForm.Text + "\n");

                    connection.Close();
                    
                    LoginForm loginForm = new LoginForm();

                    //close current form and open login form in same position
                    this.Hide();

                    loginForm.StartPosition = FormStartPosition.Manual;
                    loginForm.Location = Location;
                    loginForm.Size = Size;

                    loginForm.Show();

                }
                else
                {
                    //if passwords don't match show message to user
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
