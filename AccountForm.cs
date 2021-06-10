using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace CarSales {
    public partial class AccountForm : Form {
        public AccountForm(string username, string password) {
            InitializeComponent();
            currentUser = username;
            currentPass = password;
        }

        public string currentUser {
            get;
        }
        public string currentPass {
            get;
        }

        private void AccountForm_Load(object sender, EventArgs e) {

        }
        private void deleteAccountBtn_Click(object sender, EventArgs e) {

            if (usernameTextBox.Text.Equals(currentUser) && passwordText.Text.Equals(currentPass) && confirmPassword.Text.Equals(currentPass)) {
                //all conditions met, delete account

                var connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);

                string query = "delete from Users where Username='" + currentUser + "' and Password='" + currentPass + "';";

                if (MessageBox.Show("Are you sure you want to delete your account?\nThis cannot be undone",
                      "Warning",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.Yes) {

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader;

                    connection.Open();

                    reader = cmd.ExecuteReader();

                    connection.Close();

                    LoginForm loginForm = new LoginForm();

                    usernameTextBox.Clear();
                    passwordText.Clear();
                    confirmPassword.Clear();

                    this.Hide();
                    loginForm.StartPosition = FormStartPosition.Manual;
                    loginForm.Location = Location;
                    loginForm.Size = Size;
                    loginForm.Show();
                }
                else {

                    usernameTextBox.Clear();
                    passwordText.Clear();
                    confirmPassword.Clear();
                    usernameTextBox.Focus();
                }
            }
            else if (usernameTextBox.Text == "" || passwordText.Text == "" || confirmPassword.Text == "") {

                MessageBox.Show("Please fill in all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Clear();
                passwordText.Clear();
                confirmPassword.Clear();
                usernameTextBox.Focus();
                
            } else {

                MessageBox.Show("Username or Password incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Clear();
                passwordText.Clear();
                confirmPassword.Clear();
                usernameTextBox.Focus();
            }
        }
        private void firstPasswordVisible_CheckedChanged(object sender, EventArgs e) {
            passwordText.PasswordChar = firstPassVisible.Checked ? '\0' : '*';
        }

        private void secondPasswordVisible_CheckedChanged(object sender, EventArgs e) {
            confirmPassword.PasswordChar = secondPassVisible.Checked ? '\0' : '*';
        }
    }
}
