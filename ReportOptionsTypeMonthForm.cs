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
    public partial class ReportOptionsTypeMonthForm : Form {
        private List<Appointment> allAppointments;

        public ComboBox CmbAppointmentTypes {
            get { return cmbAppointmentType; }
        }

        public ReportOptionsTypeMonthForm(List<Appointment> allAppointments) {
            InitializeComponent();

            this.allAppointments = new List<Appointment>(allAppointments);
        }

        private void ReportOptionsTypeMonthForm_Load(object sender, EventArgs e) {
            List<string> months = new List<string>() {
                { new DateTime(DateTime.Now.Year, 1, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 2, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 3, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 4, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 5, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 6, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 7, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 8, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 9, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 10, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 11, 1).ToString("MMMM") },
                { new DateTime(DateTime.Now.Year, 12, 1).ToString("MMMM") },
            };

            foreach(string month in months) {
                cmbAppointmentMonth.Items.Add(month);
            }

            cmbAppointmentMonth.SelectedIndex = 0;
            cmbAppointmentType.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            string queryType, queryMonth;

            queryType = cmbAppointmentType.SelectedItem.ToString();
            queryMonth = cmbAppointmentMonth.SelectedItem.ToString();

            IEnumerable<Appointment> appointments =
                from appt in allAppointments
                where appt.Type == queryType && (appt.StartTime.ToString("MMMM")) == queryMonth
                select appt;

            StringBuilder reportStringBuilder = new StringBuilder();

            if(appointments.Count() > 0) {
                reportStringBuilder.Append("Found appointments matching your request:");
                reportStringBuilder.Append("\r\n");

                foreach(var appt in appointments) {
                    reportStringBuilder.Append($"{appt.StartTime} - {appt.EndTime} : {appt.Title}");
                    reportStringBuilder.Append("\r\n");
                }
            }
            else {
                reportStringBuilder.Append("No Appointments found using your query");
            }

            MessageBox.Show(reportStringBuilder.ToString());
        }
    }
}
