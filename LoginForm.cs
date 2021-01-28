using System;
using System.Windows.Forms;
using WGU_C969.DBItems;
using WGU_C969.C969Exceptions;
using MySql.Data.MySqlClient;

namespace WGU_C969 {
    public partial class LoginForm : Form {
        public event EventHandler<LoginFormUserLoggedInEventArgs> UserLoggedIn;

        public LoginForm() {
            InitializeComponent();

            lblFormTitle.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_TITLE];
            lblUsername.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_LOGIN_BUTTON];
            lblPassword.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_PASSWORD];
            btnCancel.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_CANCEL_BUTTON];
            btnLogin.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_LOGIN_BUTTON];
        }

        private void ValidateForm() {
            bool formValid = true;

            string username = tboxUsername.Text;
            string password = tboxPassword.Text;

            if(username.Replace(" ", "").Length == 0) {
                formValid = false;
            }

            if(password.Replace(" ", "").Length == 0) {
                formValid = false;
            }

            if(formValid == true) {
                btnLogin.Enabled = true;
            }
            else {
                btnLogin.Enabled = false;
            }
        }

        private void btnConnectionInfo_Click(object sender, EventArgs e) {
            ConnectionInfoForm connForm = new ConnectionInfoForm();
            connForm.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            UserAccount potentialLogin = null;

            MySqlConnection connection = new MySqlConnection(Settings.DBConnectionString);

            try {
                connection.Open();
                string query = $"SELECT * FROM user WHERE userName = \"{tboxUsername.Text}\"";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read()) {
                    if(reader.HasRows) {
                        potentialLogin = new UserAccount(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), reader.GetDateTime(4), reader.GetString(5));
                    }
                }
            }
            catch (MySqlException ex) {
                EventLogger.LogConnectionIssue();
                MessageBox.Show(Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_EXCEPTION_MYSQL]);
            }
            finally {
                connection.Close();
            }

            try {
                if(potentialLogin != null && potentialLogin.Password == tboxPassword.Text) {
                    OnUserLoggedIn(potentialLogin);
                    EventLogger.LogSuccessfulLogin(potentialLogin);
                    Close();
                }
                else {
                    EventLogger.LogUnsuccessfulLogin(tboxUsername.Text);
                    throw new LoginInvalidException(Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_EXCEPTION_INVALID_LOGIN]);
                }
            }
            catch(LoginInvalidException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
        private void tboxUsername_TextChanged(object sender, EventArgs e) {
            ValidateForm();
        }
        private void tboxPassword_TextChanged(object sender, EventArgs e) {
            ValidateForm();
        }

        private void OnUserLoggedIn(UserAccount user) {
            UserLoggedIn?.Invoke(null, new LoginFormUserLoggedInEventArgs(user));
        }
    }
}
