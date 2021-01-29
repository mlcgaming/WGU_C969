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
using WGU_C969.C969Exceptions;

namespace WGU_C969 {
    public partial class NewAppointmentForm : Form {
        public event EventHandler<NewAppointmentFormSavingEventArgs> FormSaving;

        private List<AppointmentListing> userAppointments;
        private UserAccount activeUser;

        public TextBox TBoxAppointmentID {
            get { return tboxApptId; }
        }
        public ComboBox CmbCustomerId {
            get { return cmbApptCustomers; }
        }
        public ComboBox CmbUserId {
            get { return cmbApptUsers; }
        }
        public ComboBox CmbApptType {
            get { return cmbApptType; }
        }

        public NewAppointmentForm(List<AppointmentListing> userAppointments, UserAccount activeUser) {
            InitializeComponent();

            this.userAppointments = new List<AppointmentListing>(userAppointments);
            this.activeUser = activeUser;
        }

        private void btnCancelForm_Click(object sender, EventArgs e) {
            Close();
        }
        private void btnResetForm_Click(object sender, EventArgs e) {
            cmbApptCustomers.SelectedIndex = 0;
            cmbApptType.SelectedIndex = 0;
            cmbApptUsers.SelectedIndex = 0;

            tboxApptContact.Text = "";
            tboxApptTitle.Text = "";
            tboxApptDescription.Text = "";
            tboxApptLocation.Text = "";
            tboxApptUrl.Text = "";

            dtpApptStart.Value = DateTime.Now;
            dtpApptEnd.Value = DateTime.Now.AddDays(1);
        }

        private void btnSaveForm_Click(object sender, EventArgs e) {
            string custSubstring = cmbApptCustomers.SelectedItem.ToString().Substring(1, cmbApptCustomers.SelectedItem.ToString().IndexOf(']') - 1);
            int customerID = int.Parse(custSubstring);

            string userSubstring = cmbApptUsers.SelectedItem.ToString().Substring(1, cmbApptUsers.SelectedItem.ToString().IndexOf(']') - 1);
            int userID = int.Parse(userSubstring);

            Appointment newAppointment = new Appointment(int.Parse(TBoxAppointmentID.Text), customerID, userID, tboxApptTitle.Text, tboxApptDescription.Text, tboxApptLocation.Text,
                tboxApptContact.Text, CmbApptType.SelectedItem.ToString(), tboxApptUrl.Text, dtpApptStart.Value, dtpApptEnd.Value, DateTime.Now, activeUser.Username, DateTime.Now, activeUser.Username);

            bool datesValid = ValidateAppointmentTimes(newAppointment);

            if(datesValid) {
                OnFormSaving(newAppointment);
                Close();
            }
        }

        private bool ValidateTextboxes() {
            string title = tboxApptTitle.Text;
            string type = cmbApptType.SelectedItem.ToString();

            if(title.Replace(" ", "").Length == 0) {
                return false;
            }
            if(type.Replace(" ", "").Length == 0) {
                return false;
            }

            return true;
        }
        private bool ValidateAppointmentTimes(Appointment appointment) {
            try {
                if(appointment.StartTime.Hour < 8 || appointment.StartTime.Hour > 17) {
                    throw new InvalidAppointmentDateTimeException("StartTime scheduled outside of business hours");
                }

                if(appointment.EndTime.Hour < 8 || appointment.EndTime.Hour > 17) {
                    throw new InvalidAppointmentDateTimeException("EndTime scheduled outside of business hours");
                }

                if(appointment.StartTime > appointment.EndTime) {
                    throw new InvalidAppointmentDateTimeException("EndTime must come after StartTime");
                }

                IEnumerable<AppointmentListing> apptQuery =
                    from appt in userAppointments
                    where appt.StartDate.Date == appointment.StartTime.Date || appt.EndDate.Date == appointment.EndTime.Date
                    select appt;

                foreach(var appt in apptQuery) {
                    if((appt.StartDate >= appointment.StartTime && appt.StartDate <= appointment.EndTime)
                        || (appt.EndDate >= appointment.StartTime && appt.EndDate <= appointment.EndTime)
                        || (appointment.StartTime >= appt.StartDate && appointment.StartTime <= appt.EndDate)
                        || (appointment.EndTime >= appt.StartDate && appointment.EndTime <= appt.EndDate)) {
                        throw new InvalidAppointmentDateTimeException($"Appointment overlaps with another appointment [ApptID #{appt.ID}]");
                    }
                }
            }
            catch(InvalidAppointmentDateTimeException ex) {
                MessageBox.Show(ex.Message, ex.InnerMessage);
            }

            return true;
        }

        private void OnFormSaving(Appointment appointment) {
            FormSaving?.Invoke(null, new NewAppointmentFormSavingEventArgs(appointment));
        }

        private void tboxApptTitle_TextChanged(object sender, EventArgs e) {
            if(ValidateTextboxes() == true) {
                btnSaveForm.Enabled = true;
            }
            else {
                btnSaveForm.Enabled = false;
            }
        }

        private void cmbApptType_SelectedIndexChanged(object sender, EventArgs e) {
            if(ValidateTextboxes() == true) {
                btnSaveForm.Enabled = true;
            }
            else {
                btnSaveForm.Enabled = false;
            }
        }
    }
}
