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

            cmbCustomerId.SelectedIndexChanged -= cmbCustomerId_SelectedIndexChanged;
            cmbCustomerId.SelectedIndex = 0;
            cmbCustomerId.SelectedIndexChanged += cmbCustomerId_SelectedIndexChanged;
        }
        private void ReloadAppointmentCalander() {
            btnApptDelete.Enabled = false;
            btnApptSave.Enabled = false;

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

            if(userAppointments.Count > 0) {
                dataAppointmentView.DataSource = userAppointments;
                dataAppointmentView.CurrentCell = dataAppointmentView[0, 0];
                dataAppointmentView.SelectionChanged += OnAppointmentViewSelectionChanged;
            }
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
            catch (InvalidAppointmentDateTimeException ex) {
                MessageBox.Show(ex.Message, ex.InnerMessage);
            }

            return true;
        }
        private Appointment GetClosestAppointment() {
            Appointment nearestAppointment;

            IEnumerable<Appointment> allAppointmentsAfterNow =
                from appt in allAppointments
                where appt.StartTime > DateTime.Now
                select appt;

            nearestAppointment = allAppointmentsAfterNow.ElementAt(0);

            // Iterate through until closest appointment is found
            foreach(var appt in allAppointmentsAfterNow) {
                if(appt.StartTime < nearestAppointment.StartTime) {
                    nearestAppointment = appt;
                }
            }

            return nearestAppointment;
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

                Appointment soonestAppointment = GetClosestAppointment();

                if(soonestAppointment.StartTime < DateTime.Now.AddMinutes(15)) {
                    string customerName = (from c in allCustomers where c.CustomerID == soonestAppointment.CustomerID select c).ElementAt(0).Name;

                    MessageBox.Show($"You have a meeting with {customerName} in {(soonestAppointment.StartTime - DateTime.Now).Minutes}.");
                }
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

            btnApptSave.Enabled = true;
            btnApptDelete.Enabled = true;
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
            // Load Customer Data based on selected item
            string idSubstring = cmbCustomerId.SelectedItem.ToString().Substring(1, cmbCustomerId.SelectedItem.ToString().IndexOf(']') - 1);
            int customerID = int.Parse(idSubstring);

            Customer customer = allCustomers.Where(cust => cust.CustomerID == customerID).ElementAt(0);
            Address customerAddress = allAddresses.Where(addr => addr.ID == customer.AddressID).ElementAt(0);

            tboxCustomerName.Text = customer.Name;
            checkCustomerActive.Checked = customer.IsActive;
            cmbCustomerAddress.Text = $"[{customerAddress.ID}] {customerAddress.Address1}, {allCities.Where(city => city.ID == customerAddress.CityID).ElementAt(0).Name}, {customerAddress.PostalCode}";

            btnCustomerDelete.Enabled = true;
            btnCustomerSave.Enabled = true;
        }
        private void dataAppointmentView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            // NULL
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

        private void btnApptDelete_Click(object sender, EventArgs e) {
            // Delete Appointment, then Rebuild Appointment Lists
            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            string apptDeleteQuery = $"DELETE FROM appointment WHERE appointmentId = \"{tboxApptId.Text}\"";
            MySqlCommand apptDeleteCommand = new MySqlCommand(apptDeleteQuery, dbConnection);

            try {
                dbConnection.Open();

                int rowsAffected = apptDeleteCommand.ExecuteNonQuery();

                MessageBox.Show($"Save affected {rowsAffected} records. Reloading appointment data.");

                if(rowsAffected > 0) {
                    for(int i = allAppointments.Count - 1; i >= 0; i--) {
                        if(allAppointments.ElementAt(i).ID == int.Parse(tboxApptId.Text)) {
                            allAppointments.RemoveAt(i);
                        }
                    }
                }

                dataAppointmentView.SelectionChanged -= OnAppointmentViewSelectionChanged;
                dataAppointmentView.CurrentCell = dataAppointmentView[0, 0];
                ReloadAppointmentCalander();

                dataAppointmentView.SelectionChanged += OnAppointmentViewSelectionChanged;
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }
        }
        private void btnApptSave_Click(object sender, EventArgs e) {
            // Push all fields to Database
            Appointment existingAppointment = allAppointments.Where(appt => appt.ID == int.Parse(tboxApptId.Text)).ElementAt(0);

            string custSubstring = cmbApptCustomers.SelectedItem.ToString().Substring(1, cmbApptCustomers.SelectedItem.ToString().IndexOf(']') - 1);
            int customerID = int.Parse(custSubstring);

            string userSubstring = cmbApptUsers.SelectedItem.ToString().Substring(1, cmbApptUsers.SelectedItem.ToString().IndexOf(']') - 1);
            int userID = int.Parse(userSubstring);

            DateTime startTime = dtpApptStart.Value;
            DateTime endTime = dtpApptEnd.Value;

            Appointment updatedAppointment = new Appointment(int.Parse(tboxApptId.Text), customerID, userID, tboxApptTitle.Text, tboxApptDescription.Text, tboxApptLocation.Text, tboxApptContact.Text,
                cmbApptType.SelectedItem.ToString(), tboxApptUrl.Text, startTime, endTime, existingAppointment.CreateDate, existingAppointment.CreatedBy, DateTime.Now, activeUser.Username);

            // Create Query to Push Data
            string updateQuery = $"UPDATE appointment SET customerId = \"{updatedAppointment.CustomerID}\", userId = \"{updatedAppointment.UserID}\", " +
                $"title = \"{updatedAppointment.Title}\", description = \"{updatedAppointment.Description}\", location = \"{updatedAppointment.Location}\", " +
                $"contact = \"{updatedAppointment.Contact}\", type = \"{updatedAppointment.Type}\", url = \"{updatedAppointment.URL}\", " +
                $"start = \"{updatedAppointment.StartTime.ToString("yyyy-MM-dd HH:mm:ss")}\", end = \"{updatedAppointment.EndTime.ToString("yyyy-MM-dd HH:mm:ss")}\", " +
                $"lastUpdate = \"{updatedAppointment.LastUpdate.ToString("yyyy-MM-dd HH:mm:ss")}\", lastUpdateBy = \"{updatedAppointment.LastUpdatedBy}\", " +
                $"WHERE appointmentId = \"{updatedAppointment.ID}\"";

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, dbConnection);

            try {
                dbConnection.Open();

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if(rowsAffected > 0) {
                    MessageBox.Show($"Updated {rowsAffected} records. Reloading Data.");
                    
                    for(int i = allAppointments.Count - 1; i >= 0; i--) {
                        if(allAppointments.ElementAt(i).ID == updatedAppointment.ID) {
                            allAppointments.RemoveAt(i);
                        }
                    }

                    allAppointments.Add(updatedAppointment);
                }

                ReloadAppointmentCalander();
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }
        }

        private void btnApptNew_Click(object sender, EventArgs e) {

        }

        private void btnCustomerDelete_Click(object sender, EventArgs e) {
            string custSubstring = cmbCustomerId.SelectedItem.ToString().Substring(1, cmbCustomerId.SelectedItem.ToString().IndexOf(']') - 1);
            int customerID = int.Parse(custSubstring);

            Customer selectedCustomer = allCustomers.Where(cust => cust.CustomerID == customerID).ElementAt(0);

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            string deleteQuery = $"DELETE FROM customer WHERE customerId = \"{selectedCustomer.CustomerID}\"";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, dbConnection);

            try {
                dbConnection.Open();

                int rowsAffected = deleteCommand.ExecuteNonQuery();

                MessageBox.Show($"Save affected {rowsAffected} records. Reloading customer data.");

                if(rowsAffected > 0) {
                    for(int i = allCustomers.Count - 1; i >= 0; i--) {
                        if(allCustomers.ElementAt(i).CustomerID == selectedCustomer.CustomerID) {
                            allCustomers.RemoveAt(i);
                        }
                    }
                }

                ReloadComboboxes();
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }
        }
        private void btnCustomerSave_Click(object sender, EventArgs e) {
            string custSubstring = cmbCustomerId.SelectedItem.ToString().Substring(1, cmbCustomerId.SelectedItem.ToString().IndexOf(']') - 1);
            int customerID = int.Parse(custSubstring);

            string addrSubstring = cmbCustomerAddress.SelectedItem.ToString().Substring(1, cmbCustomerAddress.SelectedItem.ToString().IndexOf(']') - 1);
            int addressID = int.Parse(addrSubstring);

            Customer selectedCustomer = allCustomers.Where(cust => cust.CustomerID == customerID).ElementAt(0);
            Customer updatedCustomer = new Customer(customerID, tboxCustomerName.Text, addressID, checkCustomerActive.Checked, selectedCustomer.DateCreated, selectedCustomer.CreatedBy, DateTime.Now, activeUser.Username);

            // Create Update Query
            string updateQuery = $"UPDATE customer SET customerName = \'{updatedCustomer.Name}\', addressId = {updatedCustomer.AddressID}, active = {updatedCustomer.IsActive}, " +
                $"lastUpdate = \'{updatedCustomer.DateLastUpdated.ToString("yyyy-MM-dd HH:mm:ss")}\', lastUpdateBy = \'{updatedCustomer.LastUpdatedBy}\' " +
                $"WHERE customerId = {updatedCustomer.CustomerID}";

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, dbConnection);

            try {
                dbConnection.Open();

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if(rowsAffected > 0) {
                    MessageBox.Show($"Updated {rowsAffected} records. Reloading Data.");

                    for(int i = allCustomers.Count - 1; i >= 0; i--) {
                        if(allCustomers.ElementAt(i).CustomerID == updatedCustomer.CustomerID) {
                            allCustomers.RemoveAt(i);
                        }
                    }

                    allCustomers.Add(updatedCustomer);
                }

                ReloadComboboxes();
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                dbConnection.Close();
            }
        }

        private void btnCustomerNew_Click(object sender, EventArgs e) {

        }
    }
}
