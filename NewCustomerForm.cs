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

        private bool ValidateCustomerTextboxes() {
            string name = tboxCustomerName.Text;
            string addr = cmbCustomerAddress.SelectedItem.ToString();

            if(name.Replace(" ", "").Length == 0) {
                return false;
            }
            if(addr.Replace(" ", "").Length == 0) {
                return false;
            }

            return true;
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

        private void tboxCustomerName_TextChanged(object sender, EventArgs e) {
            if(ValidateCustomerTextboxes() == true) {
                btnSaveForm.Enabled = true;
            }
            else {
                btnSaveForm.Enabled = false;
            }
        }

        private void cmbCustomerAddress_SelectedIndexChanged(object sender, EventArgs e) {
            if(ValidateCustomerTextboxes() == true) {
                btnSaveForm.Enabled = true;
            }
            else {
                btnSaveForm.Enabled = false;
            }
        }

        private void checkCustomerActive_CheckedChanged(object sender, EventArgs e) {
            if(ValidateCustomerTextboxes() == true) {
                btnSaveForm.Enabled = true;
            }
            else {
                btnSaveForm.Enabled = false;
            }
        }
    }
}
