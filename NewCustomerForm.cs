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
    public partial class NewCustomerForm : Form {
        public event EventHandler<NewCustomerFormSavingEventArgs> FormSaving;

        private UserAccount activeUser;

        public TextBox TBoxCustomerID {
            get { return tboxCustomerId; }
        }
        public ComboBox CmbCustomerAddress {
            get { return cmbCustomerAddress; }
        }

        public NewCustomerForm(UserAccount activeUser) {
            InitializeComponent();

            this.activeUser = activeUser;
        }

        private void btnCancelForm_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnClearForm_Click(object sender, EventArgs e) {
            cmbCustomerAddress.SelectedIndex = 0;
            tboxCustomerName.Text = "";
            checkCustomerActive.Checked = true;
        }

        private void btnSaveForm_Click(object sender, EventArgs e) {
            string addrSubstring = cmbCustomerAddress.SelectedItem.ToString().Substring(1, cmbCustomerAddress.SelectedItem.ToString().IndexOf(']') - 1);
            int addressID = int.Parse(addrSubstring);

            Customer newCustomer = new Customer(int.Parse(tboxCustomerId.Text), tboxCustomerName.Text, addressID, checkCustomerActive.Checked, DateTime.Now, activeUser.Username, DateTime.Now, activeUser.Username);

            OnFormSaving(newCustomer);
            Close();
        }

        private void OnFormSaving(Customer customer) {
            FormSaving?.Invoke(null, new NewCustomerFormSavingEventArgs(customer));
        }
    }
}
