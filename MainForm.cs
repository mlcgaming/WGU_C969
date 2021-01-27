using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WGU_C969.DBItems;

namespace WGU_C969 {
    public partial class MainForm : Form {
        private UserAccount activeUser;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            Settings.Initialize();
            LoginForm loginForm = new LoginForm();

            loginForm.UserLoggedIn += OnLoginFormUserLoggedIn;
            loginForm.FormClosing += OnLoginFormClosing;
            loginForm.ShowDialog();
        }

        private void OnLoginFormUserLoggedIn(object sender, LoginFormUserLoggedInEventArgs args) {
            activeUser = args.User;
        }
        private void OnLoginFormClosing(object sender, EventArgs args) {
            if(activeUser == null) {
                Close();
            }
        }
    }
}
