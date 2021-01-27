using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGU_C969 {
    public partial class ConnectionInfoForm : Form {
        public ConnectionInfoForm() {
            InitializeComponent();
        }

        private void ConnectionInfoForm_Load(object sender, EventArgs e) {
            tboxDBServer.Text = Settings.DBServer;
            tboxDBPort.Text = Settings.DBPort.ToString();
            tboxDBSchema.Text = Settings.DBSchema;
            tboxDBUser.Text = Settings.DBUser;

            tooltipMain.Show("Disabled in Trial Version", btnSave);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
