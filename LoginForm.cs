﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGU_C969 {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btnConnectionInfo_Click(object sender, EventArgs e) {
            ConnectionInfoForm connForm = new ConnectionInfoForm();
            connForm.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e) {

        }
        private void btnCancel_Click(object sender, EventArgs e) {

        }
        private void tboxUsername_TextChanged(object sender, EventArgs e) {

        }
        private void tboxPassword_TextChanged(object sender, EventArgs e) {

        }
    }
}