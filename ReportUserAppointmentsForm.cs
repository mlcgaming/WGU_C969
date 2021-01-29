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
    public partial class ReportUserAppointmentsForm : Form {
        private List<UserAccount> allUsers;
        private List<Appointment> allAppointments;

        public ReportUserAppointmentsForm(List<UserAccount> allUsers, List<Appointment> allAppointments) {
            InitializeComponent();

            this.allUsers = new List<UserAccount>(allUsers);
            this.allAppointments = new List<Appointment>(allAppointments);

            foreach(var user in allUsers) {
                cmbReportUsers.Items.Add(user.Username.ToUpper());
            }

            cmbReportUsers.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            IEnumerable<Appointment> appointments =
                from appt in allAppointments
                join apptUser in (from user in allUsers
                                  where user.Username.ToUpper() == cmbReportUsers.SelectedItem.ToString()
                                  select user)
                                  on appt.UserID equals apptUser.ID
                select appt;

            StringBuilder reportStringBuilder = new StringBuilder();

            if(appointments.Count() > 0) {
                reportStringBuilder.Append($"All Appointments for User {cmbReportUsers.SelectedItem.ToString()}:");
                reportStringBuilder.Append("\r\n");

                foreach(var appt in appointments) {
                    reportStringBuilder.Append($"{appt.StartTime} - {appt.EndTime} : {appt.Title}");
                    reportStringBuilder.Append("\r\n");
                }
            }
            else {
                reportStringBuilder.Append($"No Appointments found for User {cmbReportUsers.SelectedItem.ToString()}");
            }

            MessageBox.Show(reportStringBuilder.ToString());
        }
    }
}
