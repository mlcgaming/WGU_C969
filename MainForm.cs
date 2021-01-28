﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WGU_C969.DBItems;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace WGU_C969 {
    public partial class MainForm : Form {
        private UserAccount activeUser;

        private List<UserAccount> allUsers;
        private List<Appointment> allAppointments;
        private List<Customer> allCustomers;
        private List<Address> allAddresses;
        private List<City> allCities;
        private List<Country> allCountries;

        private List<AppointmentListing> userAppointments;

        private DateTime earliestAppointmentViewDate;
        private DateTime latestAppointmentViewDate;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            Settings.Initialize();

            allUsers = new List<UserAccount>();
            allAppointments = new List<Appointment>();
            allCustomers = new List<Customer>();
            allAddresses = new List<Address>();
            allCities = new List<City>();
            allCountries = new List<Country>();
            userAppointments = new List<AppointmentListing>();

            earliestAppointmentViewDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            latestAppointmentViewDate = earliestAppointmentViewDate.AddMonths(1).AddTicks(-1);

            LoginForm loginForm = new LoginForm();

            loginForm.UserLoggedIn += OnLoginFormUserLoggedIn;
            loginForm.FormClosing += OnLoginFormClosing;
            loginForm.ShowDialog();
        }

        private void LoadDataFromDatabase() {
            string allUsersQuery = "SELECT * FROM user";
            string allAppointmentsQuery = "SELECT * FROM appointment";
            string allCustomersQuery = "SELECT * FROM customer";
            string allAddressesQuery = "SELECT * FROM address";
            string allCitiesQuery = "SELECT * FROM city";
            string allCountriesQuery = "SELECT * FROM country";

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);

            MySqlCommand allUsersCommand = new MySqlCommand(allUsersQuery, dbConnection);
            MySqlCommand allAppointmentsCommand = new MySqlCommand(allAppointmentsQuery, dbConnection);
            MySqlCommand allCustomersCommand = new MySqlCommand(allCustomersQuery, dbConnection);
            MySqlCommand allAddressesCommand = new MySqlCommand(allAddressesQuery, dbConnection);
            MySqlCommand allCitiesCommand = new MySqlCommand(allCitiesQuery, dbConnection);
            MySqlCommand allCountriesCommand = new MySqlCommand(allCountriesQuery, dbConnection);

            try {
                dbConnection.Open();

                MySqlDataReader reader = allUsersCommand.ExecuteReader();

                while(reader.Read()) {
                    UserAccount user = new UserAccount(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), reader.GetDateTime(4), reader.GetString(5));

                    allUsers.Add(user);
                }
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }

            try {
                dbConnection.Open();

                MySqlDataReader reader = allAppointmentsCommand.ExecuteReader();

                while(reader.Read()) {
                    Appointment appointment = new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                        reader.GetString(7), reader.GetString(8), reader.GetDateTime(9), reader.GetDateTime(10), reader.GetDateTime(11), reader.GetString(12), reader.GetDateTime(13), reader.GetString(14));

                    allAppointments.Add(appointment);
                }
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }

            try {
                dbConnection.Open();

                MySqlDataReader reader = allCustomersCommand.ExecuteReader();

                while(reader.Read()) {
                    Customer customer = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetBoolean(3), reader.GetDateTime(4), reader.GetString(5),
                        reader.GetDateTime(6), reader.GetString(7));

                    allCustomers.Add(customer);
                }
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }

            try {
                dbConnection.Open();

                MySqlDataReader reader = allAddressesCommand.ExecuteReader();

                while(reader.Read()) {
                    Address address = new Address(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6),
                        reader.GetString(7), reader.GetDateTime(8), reader.GetString(9));

                    allAddresses.Add(address);
                }
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }

            try {
                dbConnection.Open();

                MySqlDataReader reader = allCitiesCommand.ExecuteReader();

                while(reader.Read()) {
                    City city = new City(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetString(4), reader.GetDateTime(5), reader.GetString(6));

                    allCities.Add(city);
                }
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }

            try {
                dbConnection.Open();

                MySqlDataReader reader = allCountriesCommand.ExecuteReader();

                while(reader.Read()) {
                    Country country = new Country(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5));

                    allCountries.Add(country);
                }
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }
        }
        private void ReloadComboboxes() {
            cmbApptCustomers.Items.Clear();
            cmbApptType.Items.Clear();
            cmbApptUsers.Items.Clear();

            cmbCustomerId.Items.Clear();
            cmbCustomerAddress.Items.Clear();

            foreach(var customer in allCustomers) {
                string customerEntry = $"[{customer.CustomerID}] {customer.Name}";
                cmbApptCustomers.Items.Add(customerEntry);
                cmbCustomerId.Items.Add(customerEntry);
            }

            foreach(var user in allUsers) {
                string userEntry = $"[{user.ID}] {user.Username}";
                cmbApptUsers.Items.Add(userEntry);
            }

            foreach(var address in allAddresses) {
                string addressEntry = $"[{address.ID}] {address.Address1}, {allCities.Where(city => city.ID == address.CityID).ElementAt(0).Name}, {address.PostalCode}";
                cmbCustomerAddress.Items.Add(addressEntry);
            }

            cmbApptType.Items.Add("Meeting");
            cmbApptType.Items.Add("Presentation");
            cmbApptType.Items.Add("Scrum");
        }
        private void ReloadAppointmentCalander() {
            if(userAppointments.Count > 0) {
                userAppointments.Clear();
                dataAppointmentView.DataSource = null;
                dataAppointmentView.Rows.Clear();
            }

            IEnumerable<Appointment> filteredAppointments =
                    from appt in allAppointments
                    where appt.UserID == activeUser.ID
                    select appt;

            foreach(var appt in filteredAppointments) {
                if(appt.StartTime >= earliestAppointmentViewDate &&
                    appt.EndTime <= latestAppointmentViewDate) {
                    // It is cleaner and more straightforward to use these lambdas with LINQ to select the items we need, rather than build a wholly separate function for these
                    string userName = allUsers.Where(name => name.ID == appt.UserID).Select(name => name.Username).ElementAt(0);
                    string customerName = allCustomers.Where(name => name.CustomerID == appt.CustomerID).Select(name => name.Name).ElementAt(0);

                    DateTime apptStart = appt.StartTime;
                    DateTime apptEnd = appt.EndTime;

                    if(radioTimeViewLocal.Checked == true) {
                        apptStart = apptStart.ToLocalTime();
                        apptEnd = apptEnd.ToLocalTime();
                    }
                    else {
                        apptStart = apptStart.ToUniversalTime();
                        apptEnd = apptEnd.ToUniversalTime();
                    }

                    AppointmentListing listing = new AppointmentListing(appt.ID, userName, customerName, appt.Title, appt.Description, appt.Type, apptStart, apptEnd);
                    userAppointments.Add(listing);
                }
            }

            dataAppointmentView.DataSource = userAppointments;
            dataAppointmentView.CurrentCell = dataAppointmentView[0, 0];
            dataAppointmentView.SelectionChanged += OnAppointmentViewSelectionChanged;
        }

        private void OnLoginFormUserLoggedIn(object sender, LoginFormUserLoggedInEventArgs args) {
            activeUser = args.User;
        }
        private void OnLoginFormClosing(object sender, EventArgs args) {
            if(activeUser == null) {
                Close();
            }
            else {
                LoadDataFromDatabase();
                ReloadAppointmentCalander();
                ReloadComboboxes();
            }
        }
        private void OnAppointmentViewSelectionChanged(object sender, EventArgs e) {
            int apptID = (int)dataAppointmentView[0, dataAppointmentView.CurrentCell.RowIndex].Value;

            // The following three lines all use lambdas with LINQ to quickly pull the element we need from the lists, while remaining human readable
            Appointment selectedAppointment = allAppointments.Where(appt => appt.ID == apptID).ElementAt(0);

            UserAccount appointmentUser = allUsers.Where(user => user.ID == selectedAppointment.UserID).ElementAt(0);
            Customer appointmentCustomer = allCustomers.Where(customer => customer.CustomerID == selectedAppointment.CustomerID).ElementAt(0);

            string userEntry = $"[{appointmentUser.ID}] {appointmentUser.Username}";
            string customerEntry = $"[{appointmentCustomer.CustomerID}] {appointmentCustomer.Name}";

            tboxApptId.Text = selectedAppointment.ID.ToString();
            cmbApptUsers.Text = userEntry;
            cmbApptCustomers.Text = customerEntry;

            tboxApptTitle.Text = selectedAppointment.Title;
            tboxApptDescription.Text = selectedAppointment.Description;
            tboxApptLocation.Text = selectedAppointment.Location;
            tboxApptContact.Text = selectedAppointment.Contact;

            if(radioTimeViewLocal.Checked == true) {
                dtpApptStart.Value = selectedAppointment.StartTime.ToLocalTime();
                dtpApptEnd.Value = selectedAppointment.EndTime.ToLocalTime();
            }
            else {
                dtpApptStart.Value = selectedAppointment.StartTime.ToUniversalTime();
                dtpApptEnd.Value = selectedAppointment.EndTime.ToUniversalTime();
            }
        }

        private void OnAppointmentViewOptionChange() {
            DateTime currentDate = DateTime.Now;
            CultureInfo currentCulture = CultureInfo.CurrentCulture;

            dataAppointmentView.SelectionChanged -= OnAppointmentViewSelectionChanged;

            if(radioApptViewMonth.Checked == true) {
                // Set Appointment Window to range from 1st of current month to end of current month
                earliestAppointmentViewDate = new DateTime(currentDate.Year, currentDate.Month, 1);
                latestAppointmentViewDate = earliestAppointmentViewDate.AddMonths(1).AddTicks(-1);
            }
            else {
                // Set Appointment Window to range from beginning to end of current week
                var diff = currentDate.DayOfWeek - currentCulture.DateTimeFormat.FirstDayOfWeek;
                if(diff < 0) { diff += 7; }

                earliestAppointmentViewDate = currentDate.AddDays(-diff).Date;
                latestAppointmentViewDate = earliestAppointmentViewDate.AddDays(6);
            }

            lblAppointementsHeader.Text = $"Upcoming Appointments ({earliestAppointmentViewDate} to {latestAppointmentViewDate})";
            ReloadAppointmentCalander();
        }
        private void OnTimeViewOptionChange() {
            OnAppointmentViewOptionChange();
        }

        private void cmbCustomerId_SelectedIndexChanged(object sender, EventArgs e) {
            
        }
        private void dataAppointmentView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }
        private void radioApptViewWeek_CheckedChanged(object sender, EventArgs e) {
            if(radioApptViewWeek.Checked == true) {
                radioApptViewMonth.Checked = false;
                OnAppointmentViewOptionChange();
            }
        }
        private void radioApptViewMonth_CheckedChanged(object sender, EventArgs e) {
            if(radioApptViewMonth.Checked == true) {
                radioApptViewWeek.Checked = false;
                OnAppointmentViewOptionChange();
            }
        }
        private void radioTimeViewUTC_CheckedChanged(object sender, EventArgs e) {
            // NULL
        }
        private void radioTimeViewLocal_CheckedChanged(object sender, EventArgs e) {
            // NULL
        }
        private void radioTimeViewUTC_CheckedChanged_1(object sender, EventArgs e) {
            if(radioTimeViewUTC.Checked == true) {
                radioTimeViewLocal.Checked = false;
                OnTimeViewOptionChange();
            }
        }
        private void radioTimeViewLocal_CheckedChanged_1(object sender, EventArgs e) {
            if(radioTimeViewLocal.Checked == true) {
                radioTimeViewUTC.Checked = false;
                OnTimeViewOptionChange();
            }
        }
    }
}
