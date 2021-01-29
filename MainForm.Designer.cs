namespace WGU_C969 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataAppointmentView = new System.Windows.Forms.DataGridView();
            this.lblAppointementsHeader = new System.Windows.Forms.Label();
            this.grpAppointment = new System.Windows.Forms.GroupBox();
            this.btnApptNew = new System.Windows.Forms.Button();
            this.grpApptDetails = new System.Windows.Forms.GroupBox();
            this.tboxApptUrl = new System.Windows.Forms.TextBox();
            this.lblApptUrl = new System.Windows.Forms.Label();
            this.dtpApptEnd = new System.Windows.Forms.DateTimePicker();
            this.lblApptEnd = new System.Windows.Forms.Label();
            this.dtpApptStart = new System.Windows.Forms.DateTimePicker();
            this.lblApptStart = new System.Windows.Forms.Label();
            this.cmbApptType = new System.Windows.Forms.ComboBox();
            this.lblApptType = new System.Windows.Forms.Label();
            this.tboxApptContact = new System.Windows.Forms.TextBox();
            this.lblApptContact = new System.Windows.Forms.Label();
            this.tboxApptLocation = new System.Windows.Forms.TextBox();
            this.lblApptLocation = new System.Windows.Forms.Label();
            this.tboxApptDescription = new System.Windows.Forms.TextBox();
            this.lblApptDescription = new System.Windows.Forms.Label();
            this.tboxApptTitle = new System.Windows.Forms.TextBox();
            this.lblApptTitle = new System.Windows.Forms.Label();
            this.btnApptDelete = new System.Windows.Forms.Button();
            this.tboxApptId = new System.Windows.Forms.TextBox();
            this.btnApptSave = new System.Windows.Forms.Button();
            this.cmbApptCustomers = new System.Windows.Forms.ComboBox();
            this.cmbApptUsers = new System.Windows.Forms.ComboBox();
            this.lblApptCustomer = new System.Windows.Forms.Label();
            this.lblApptUser = new System.Windows.Forms.Label();
            this.lblApptID = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerNew = new System.Windows.Forms.Button();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.checkCustomerActive = new System.Windows.Forms.CheckBox();
            this.cmbCustomerAddress = new System.Windows.Forms.ComboBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.tboxCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cmbCustomerId = new System.Windows.Forms.ComboBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.btnReportGenerate = new System.Windows.Forms.Button();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblApptView = new System.Windows.Forms.Label();
            this.radioApptViewWeek = new System.Windows.Forms.RadioButton();
            this.radioApptViewMonth = new System.Windows.Forms.RadioButton();
            this.radioTimeViewLocal = new System.Windows.Forms.RadioButton();
            this.radioTimeViewUTC = new System.Windows.Forms.RadioButton();
            this.lblTimeSet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointmentView)).BeginInit();
            this.grpAppointment.SuspendLayout();
            this.grpApptDetails.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpCustomerDetails.SuspendLayout();
            this.grpReports.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataAppointmentView
            // 
            this.dataAppointmentView.AllowUserToAddRows = false;
            this.dataAppointmentView.AllowUserToDeleteRows = false;
            this.dataAppointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAppointmentView.Location = new System.Drawing.Point(12, 376);
            this.dataAppointmentView.MultiSelect = false;
            this.dataAppointmentView.Name = "dataAppointmentView";
            this.dataAppointmentView.Size = new System.Drawing.Size(578, 150);
            this.dataAppointmentView.TabIndex = 0;
            this.dataAppointmentView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAppointmentView_CellContentClick);
            // 
            // lblAppointementsHeader
            // 
            this.lblAppointementsHeader.AutoSize = true;
            this.lblAppointementsHeader.Location = new System.Drawing.Point(12, 360);
            this.lblAppointementsHeader.Name = "lblAppointementsHeader";
            this.lblAppointementsHeader.Size = new System.Drawing.Size(71, 13);
            this.lblAppointementsHeader.TabIndex = 1;
            this.lblAppointementsHeader.Text = "Appointments";
            // 
            // grpAppointment
            // 
            this.grpAppointment.Controls.Add(this.btnApptNew);
            this.grpAppointment.Controls.Add(this.grpApptDetails);
            this.grpAppointment.Controls.Add(this.btnApptDelete);
            this.grpAppointment.Controls.Add(this.tboxApptId);
            this.grpAppointment.Controls.Add(this.btnApptSave);
            this.grpAppointment.Controls.Add(this.cmbApptCustomers);
            this.grpAppointment.Controls.Add(this.cmbApptUsers);
            this.grpAppointment.Controls.Add(this.lblApptCustomer);
            this.grpAppointment.Controls.Add(this.lblApptUser);
            this.grpAppointment.Controls.Add(this.lblApptID);
            this.grpAppointment.Location = new System.Drawing.Point(281, 12);
            this.grpAppointment.Name = "grpAppointment";
            this.grpAppointment.Size = new System.Drawing.Size(309, 337);
            this.grpAppointment.TabIndex = 2;
            this.grpAppointment.TabStop = false;
            this.grpAppointment.Text = "Appointment";
            // 
            // btnApptNew
            // 
            this.btnApptNew.Location = new System.Drawing.Point(9, 301);
            this.btnApptNew.Name = "btnApptNew";
            this.btnApptNew.Size = new System.Drawing.Size(75, 23);
            this.btnApptNew.TabIndex = 10;
            this.btnApptNew.Text = "New";
            this.btnApptNew.UseVisualStyleBackColor = true;
            this.btnApptNew.Click += new System.EventHandler(this.btnApptNew_Click);
            // 
            // grpApptDetails
            // 
            this.grpApptDetails.Controls.Add(this.tboxApptUrl);
            this.grpApptDetails.Controls.Add(this.lblApptUrl);
            this.grpApptDetails.Controls.Add(this.dtpApptEnd);
            this.grpApptDetails.Controls.Add(this.lblApptEnd);
            this.grpApptDetails.Controls.Add(this.dtpApptStart);
            this.grpApptDetails.Controls.Add(this.lblApptStart);
            this.grpApptDetails.Controls.Add(this.cmbApptType);
            this.grpApptDetails.Controls.Add(this.lblApptType);
            this.grpApptDetails.Controls.Add(this.tboxApptContact);
            this.grpApptDetails.Controls.Add(this.lblApptContact);
            this.grpApptDetails.Controls.Add(this.tboxApptLocation);
            this.grpApptDetails.Controls.Add(this.lblApptLocation);
            this.grpApptDetails.Controls.Add(this.tboxApptDescription);
            this.grpApptDetails.Controls.Add(this.lblApptDescription);
            this.grpApptDetails.Controls.Add(this.tboxApptTitle);
            this.grpApptDetails.Controls.Add(this.lblApptTitle);
            this.grpApptDetails.Location = new System.Drawing.Point(9, 77);
            this.grpApptDetails.Name = "grpApptDetails";
            this.grpApptDetails.Size = new System.Drawing.Size(294, 209);
            this.grpApptDetails.TabIndex = 6;
            this.grpApptDetails.TabStop = false;
            this.grpApptDetails.Text = "Details (Bold are Required)";
            // 
            // tboxApptUrl
            // 
            this.tboxApptUrl.Location = new System.Drawing.Point(182, 101);
            this.tboxApptUrl.Name = "tboxApptUrl";
            this.tboxApptUrl.Size = new System.Drawing.Size(100, 20);
            this.tboxApptUrl.TabIndex = 15;
            // 
            // lblApptUrl
            // 
            this.lblApptUrl.AutoSize = true;
            this.lblApptUrl.Location = new System.Drawing.Point(135, 104);
            this.lblApptUrl.Name = "lblApptUrl";
            this.lblApptUrl.Size = new System.Drawing.Size(32, 13);
            this.lblApptUrl.TabIndex = 14;
            this.lblApptUrl.Text = "URL:";
            // 
            // dtpApptEnd
            // 
            this.dtpApptEnd.CustomFormat = "ddd dd MMM yyyy HH:mm:ss tt";
            this.dtpApptEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApptEnd.Location = new System.Drawing.Point(71, 180);
            this.dtpApptEnd.Name = "dtpApptEnd";
            this.dtpApptEnd.ShowUpDown = true;
            this.dtpApptEnd.Size = new System.Drawing.Size(211, 20);
            this.dtpApptEnd.TabIndex = 13;
            // 
            // lblApptEnd
            // 
            this.lblApptEnd.AutoSize = true;
            this.lblApptEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptEnd.Location = new System.Drawing.Point(8, 183);
            this.lblApptEnd.Name = "lblApptEnd";
            this.lblApptEnd.Size = new System.Drawing.Size(64, 13);
            this.lblApptEnd.TabIndex = 12;
            this.lblApptEnd.Text = "End Date:";
            // 
            // dtpApptStart
            // 
            this.dtpApptStart.CustomFormat = "ddd dd MMM yyyy HH:mm:ss tt";
            this.dtpApptStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApptStart.Location = new System.Drawing.Point(71, 154);
            this.dtpApptStart.Name = "dtpApptStart";
            this.dtpApptStart.ShowUpDown = true;
            this.dtpApptStart.Size = new System.Drawing.Size(211, 20);
            this.dtpApptStart.TabIndex = 11;
            // 
            // lblApptStart
            // 
            this.lblApptStart.AutoSize = true;
            this.lblApptStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptStart.Location = new System.Drawing.Point(8, 157);
            this.lblApptStart.Name = "lblApptStart";
            this.lblApptStart.Size = new System.Drawing.Size(69, 13);
            this.lblApptStart.TabIndex = 10;
            this.lblApptStart.Text = "Start Date:";
            // 
            // cmbApptType
            // 
            this.cmbApptType.FormattingEnabled = true;
            this.cmbApptType.Items.AddRange(new object[] {
            "Presentation",
            "Scrum",
            "Meeting",
            "Evaluation"});
            this.cmbApptType.Location = new System.Drawing.Point(122, 127);
            this.cmbApptType.Name = "cmbApptType";
            this.cmbApptType.Size = new System.Drawing.Size(160, 21);
            this.cmbApptType.TabIndex = 9;
            // 
            // lblApptType
            // 
            this.lblApptType.AutoSize = true;
            this.lblApptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptType.Location = new System.Drawing.Point(8, 130);
            this.lblApptType.Name = "lblApptType";
            this.lblApptType.Size = new System.Drawing.Size(113, 13);
            this.lblApptType.TabIndex = 8;
            this.lblApptType.Text = "Appointment Type:";
            // 
            // tboxApptContact
            // 
            this.tboxApptContact.Location = new System.Drawing.Point(55, 101);
            this.tboxApptContact.Name = "tboxApptContact";
            this.tboxApptContact.Size = new System.Drawing.Size(69, 20);
            this.tboxApptContact.TabIndex = 7;
            // 
            // lblApptContact
            // 
            this.lblApptContact.AutoSize = true;
            this.lblApptContact.Location = new System.Drawing.Point(8, 104);
            this.lblApptContact.Name = "lblApptContact";
            this.lblApptContact.Size = new System.Drawing.Size(47, 13);
            this.lblApptContact.TabIndex = 6;
            this.lblApptContact.Text = "Contact:";
            // 
            // tboxApptLocation
            // 
            this.tboxApptLocation.Location = new System.Drawing.Point(61, 75);
            this.tboxApptLocation.Name = "tboxApptLocation";
            this.tboxApptLocation.Size = new System.Drawing.Size(221, 20);
            this.tboxApptLocation.TabIndex = 5;
            // 
            // lblApptLocation
            // 
            this.lblApptLocation.AutoSize = true;
            this.lblApptLocation.Location = new System.Drawing.Point(8, 78);
            this.lblApptLocation.Name = "lblApptLocation";
            this.lblApptLocation.Size = new System.Drawing.Size(51, 13);
            this.lblApptLocation.TabIndex = 4;
            this.lblApptLocation.Text = "Location:";
            // 
            // tboxApptDescription
            // 
            this.tboxApptDescription.Location = new System.Drawing.Point(71, 49);
            this.tboxApptDescription.Name = "tboxApptDescription";
            this.tboxApptDescription.Size = new System.Drawing.Size(211, 20);
            this.tboxApptDescription.TabIndex = 3;
            // 
            // lblApptDescription
            // 
            this.lblApptDescription.AutoSize = true;
            this.lblApptDescription.Location = new System.Drawing.Point(8, 52);
            this.lblApptDescription.Name = "lblApptDescription";
            this.lblApptDescription.Size = new System.Drawing.Size(63, 13);
            this.lblApptDescription.TabIndex = 2;
            this.lblApptDescription.Text = "Description:";
            // 
            // tboxApptTitle
            // 
            this.tboxApptTitle.Location = new System.Drawing.Point(40, 21);
            this.tboxApptTitle.Name = "tboxApptTitle";
            this.tboxApptTitle.Size = new System.Drawing.Size(242, 20);
            this.tboxApptTitle.TabIndex = 1;
            // 
            // lblApptTitle
            // 
            this.lblApptTitle.AutoSize = true;
            this.lblApptTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptTitle.Location = new System.Drawing.Point(8, 24);
            this.lblApptTitle.Name = "lblApptTitle";
            this.lblApptTitle.Size = new System.Drawing.Size(36, 13);
            this.lblApptTitle.TabIndex = 0;
            this.lblApptTitle.Text = "Title:";
            // 
            // btnApptDelete
            // 
            this.btnApptDelete.Enabled = false;
            this.btnApptDelete.Location = new System.Drawing.Point(228, 301);
            this.btnApptDelete.Name = "btnApptDelete";
            this.btnApptDelete.Size = new System.Drawing.Size(75, 23);
            this.btnApptDelete.TabIndex = 9;
            this.btnApptDelete.Text = "Delete";
            this.btnApptDelete.UseVisualStyleBackColor = true;
            this.btnApptDelete.Click += new System.EventHandler(this.btnApptDelete_Click);
            // 
            // tboxApptId
            // 
            this.tboxApptId.Location = new System.Drawing.Point(33, 25);
            this.tboxApptId.Name = "tboxApptId";
            this.tboxApptId.ReadOnly = true;
            this.tboxApptId.Size = new System.Drawing.Size(47, 20);
            this.tboxApptId.TabIndex = 5;
            // 
            // btnApptSave
            // 
            this.btnApptSave.Enabled = false;
            this.btnApptSave.Location = new System.Drawing.Point(147, 301);
            this.btnApptSave.Name = "btnApptSave";
            this.btnApptSave.Size = new System.Drawing.Size(75, 23);
            this.btnApptSave.TabIndex = 8;
            this.btnApptSave.Text = "Save";
            this.btnApptSave.UseVisualStyleBackColor = true;
            this.btnApptSave.Click += new System.EventHandler(this.btnApptSave_Click);
            // 
            // cmbApptCustomers
            // 
            this.cmbApptCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptCustomers.FormattingEnabled = true;
            this.cmbApptCustomers.Location = new System.Drawing.Point(139, 50);
            this.cmbApptCustomers.Name = "cmbApptCustomers";
            this.cmbApptCustomers.Size = new System.Drawing.Size(144, 21);
            this.cmbApptCustomers.TabIndex = 4;
            // 
            // cmbApptUsers
            // 
            this.cmbApptUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptUsers.FormattingEnabled = true;
            this.cmbApptUsers.Location = new System.Drawing.Point(139, 25);
            this.cmbApptUsers.Name = "cmbApptUsers";
            this.cmbApptUsers.Size = new System.Drawing.Size(144, 21);
            this.cmbApptUsers.TabIndex = 3;
            // 
            // lblApptCustomer
            // 
            this.lblApptCustomer.AutoSize = true;
            this.lblApptCustomer.Location = new System.Drawing.Point(79, 53);
            this.lblApptCustomer.Name = "lblApptCustomer";
            this.lblApptCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblApptCustomer.TabIndex = 2;
            this.lblApptCustomer.Text = "Customer:";
            // 
            // lblApptUser
            // 
            this.lblApptUser.AutoSize = true;
            this.lblApptUser.Location = new System.Drawing.Point(101, 28);
            this.lblApptUser.Name = "lblApptUser";
            this.lblApptUser.Size = new System.Drawing.Size(32, 13);
            this.lblApptUser.TabIndex = 1;
            this.lblApptUser.Text = "User:";
            // 
            // lblApptID
            // 
            this.lblApptID.AutoSize = true;
            this.lblApptID.Location = new System.Drawing.Point(6, 28);
            this.lblApptID.Name = "lblApptID";
            this.lblApptID.Size = new System.Drawing.Size(21, 13);
            this.lblApptID.TabIndex = 0;
            this.lblApptID.Text = "ID:";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnCustomerSave);
            this.grpCustomer.Controls.Add(this.btnCustomerDelete);
            this.grpCustomer.Controls.Add(this.btnCustomerNew);
            this.grpCustomer.Controls.Add(this.grpCustomerDetails);
            this.grpCustomer.Controls.Add(this.cmbCustomerId);
            this.grpCustomer.Controls.Add(this.lblCustomerId);
            this.grpCustomer.Location = new System.Drawing.Point(15, 12);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(260, 194);
            this.grpCustomer.TabIndex = 3;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Enabled = false;
            this.btnCustomerSave.Location = new System.Drawing.Point(93, 163);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerSave.TabIndex = 7;
            this.btnCustomerSave.Text = "Save";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            this.btnCustomerSave.Click += new System.EventHandler(this.btnCustomerSave_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Enabled = false;
            this.btnCustomerDelete.Location = new System.Drawing.Point(179, 163);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerDelete.TabIndex = 6;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerNew
            // 
            this.btnCustomerNew.Location = new System.Drawing.Point(6, 163);
            this.btnCustomerNew.Name = "btnCustomerNew";
            this.btnCustomerNew.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerNew.TabIndex = 5;
            this.btnCustomerNew.Text = "New";
            this.btnCustomerNew.UseVisualStyleBackColor = true;
            this.btnCustomerNew.Click += new System.EventHandler(this.btnCustomerNew_Click);
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.checkCustomerActive);
            this.grpCustomerDetails.Controls.Add(this.cmbCustomerAddress);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerAddress);
            this.grpCustomerDetails.Controls.Add(this.tboxCustomerName);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerName);
            this.grpCustomerDetails.Location = new System.Drawing.Point(6, 53);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(248, 104);
            this.grpCustomerDetails.TabIndex = 4;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Details (Bold are Required)";
            // 
            // checkCustomerActive
            // 
            this.checkCustomerActive.AutoSize = true;
            this.checkCustomerActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCustomerActive.Location = new System.Drawing.Point(8, 76);
            this.checkCustomerActive.Name = "checkCustomerActive";
            this.checkCustomerActive.Size = new System.Drawing.Size(113, 17);
            this.checkCustomerActive.TabIndex = 4;
            this.checkCustomerActive.Text = "Active Account";
            this.checkCustomerActive.UseVisualStyleBackColor = true;
            // 
            // cmbCustomerAddress
            // 
            this.cmbCustomerAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerAddress.FormattingEnabled = true;
            this.cmbCustomerAddress.Location = new System.Drawing.Point(59, 45);
            this.cmbCustomerAddress.Name = "cmbCustomerAddress";
            this.cmbCustomerAddress.Size = new System.Drawing.Size(183, 21);
            this.cmbCustomerAddress.TabIndex = 3;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(5, 48);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(56, 13);
            this.lblCustomerAddress.TabIndex = 2;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // tboxCustomerName
            // 
            this.tboxCustomerName.Location = new System.Drawing.Point(50, 21);
            this.tboxCustomerName.Name = "tboxCustomerName";
            this.tboxCustomerName.Size = new System.Drawing.Size(192, 20);
            this.tboxCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(6, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(43, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // cmbCustomerId
            // 
            this.cmbCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerId.FormattingEnabled = true;
            this.cmbCustomerId.Location = new System.Drawing.Point(70, 19);
            this.cmbCustomerId.Name = "cmbCustomerId";
            this.cmbCustomerId.Size = new System.Drawing.Size(179, 21);
            this.cmbCustomerId.TabIndex = 1;
            this.cmbCustomerId.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerId_SelectedIndexChanged);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(10, 22);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(54, 13);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "Customer:";
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.btnReportGenerate);
            this.grpReports.Controls.Add(this.cmbReportType);
            this.grpReports.Location = new System.Drawing.Point(15, 212);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(260, 51);
            this.grpReports.TabIndex = 4;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // btnReportGenerate
            // 
            this.btnReportGenerate.Location = new System.Drawing.Point(179, 17);
            this.btnReportGenerate.Name = "btnReportGenerate";
            this.btnReportGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnReportGenerate.TabIndex = 11;
            this.btnReportGenerate.Text = "Generate";
            this.btnReportGenerate.UseVisualStyleBackColor = true;
            this.btnReportGenerate.Click += new System.EventHandler(this.btnReportGenerate_Click);
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "All Appts by TYPE by MONTH",
            "All Appts for USER",
            "All ACTIVE Customers"});
            this.cmbReportType.Location = new System.Drawing.Point(6, 19);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(162, 21);
            this.cmbReportType.TabIndex = 0;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.panel1);
            this.grpOptions.Controls.Add(this.radioTimeViewLocal);
            this.grpOptions.Controls.Add(this.radioTimeViewUTC);
            this.grpOptions.Controls.Add(this.lblTimeSet);
            this.grpOptions.Location = new System.Drawing.Point(15, 269);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(260, 80);
            this.grpOptions.TabIndex = 5;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblApptView);
            this.panel1.Controls.Add(this.radioApptViewWeek);
            this.panel1.Controls.Add(this.radioApptViewMonth);
            this.panel1.Location = new System.Drawing.Point(7, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 64);
            this.panel1.TabIndex = 6;
            // 
            // lblApptView
            // 
            this.lblApptView.AutoSize = true;
            this.lblApptView.Location = new System.Drawing.Point(3, 8);
            this.lblApptView.Name = "lblApptView";
            this.lblApptView.Size = new System.Drawing.Size(95, 13);
            this.lblApptView.TabIndex = 0;
            this.lblApptView.Text = "Appointment View:";
            // 
            // radioApptViewWeek
            // 
            this.radioApptViewWeek.AutoSize = true;
            this.radioApptViewWeek.Location = new System.Drawing.Point(9, 24);
            this.radioApptViewWeek.Name = "radioApptViewWeek";
            this.radioApptViewWeek.Size = new System.Drawing.Size(69, 17);
            this.radioApptViewWeek.TabIndex = 2;
            this.radioApptViewWeek.Text = "By Week";
            this.radioApptViewWeek.UseVisualStyleBackColor = true;
            this.radioApptViewWeek.CheckedChanged += new System.EventHandler(this.radioApptViewWeek_CheckedChanged);
            // 
            // radioApptViewMonth
            // 
            this.radioApptViewMonth.AutoSize = true;
            this.radioApptViewMonth.Checked = true;
            this.radioApptViewMonth.Location = new System.Drawing.Point(9, 41);
            this.radioApptViewMonth.Name = "radioApptViewMonth";
            this.radioApptViewMonth.Size = new System.Drawing.Size(70, 17);
            this.radioApptViewMonth.TabIndex = 3;
            this.radioApptViewMonth.TabStop = true;
            this.radioApptViewMonth.Text = "By Month";
            this.radioApptViewMonth.UseVisualStyleBackColor = true;
            this.radioApptViewMonth.CheckedChanged += new System.EventHandler(this.radioApptViewMonth_CheckedChanged);
            // 
            // radioTimeViewLocal
            // 
            this.radioTimeViewLocal.AutoSize = true;
            this.radioTimeViewLocal.Checked = true;
            this.radioTimeViewLocal.Location = new System.Drawing.Point(160, 50);
            this.radioTimeViewLocal.Name = "radioTimeViewLocal";
            this.radioTimeViewLocal.Size = new System.Drawing.Size(77, 17);
            this.radioTimeViewLocal.TabIndex = 5;
            this.radioTimeViewLocal.TabStop = true;
            this.radioTimeViewLocal.Text = "Local Time";
            this.radioTimeViewLocal.UseVisualStyleBackColor = true;
            this.radioTimeViewLocal.CheckedChanged += new System.EventHandler(this.radioTimeViewLocal_CheckedChanged_1);
            // 
            // radioTimeViewUTC
            // 
            this.radioTimeViewUTC.AutoSize = true;
            this.radioTimeViewUTC.Location = new System.Drawing.Point(160, 32);
            this.radioTimeViewUTC.Name = "radioTimeViewUTC";
            this.radioTimeViewUTC.Size = new System.Drawing.Size(47, 17);
            this.radioTimeViewUTC.TabIndex = 4;
            this.radioTimeViewUTC.Text = "UTC";
            this.radioTimeViewUTC.UseVisualStyleBackColor = true;
            this.radioTimeViewUTC.CheckedChanged += new System.EventHandler(this.radioTimeViewUTC_CheckedChanged_1);
            // 
            // lblTimeSet
            // 
            this.lblTimeSet.AutoSize = true;
            this.lblTimeSet.Location = new System.Drawing.Point(157, 19);
            this.lblTimeSet.Name = "lblTimeSet";
            this.lblTimeSet.Size = new System.Drawing.Size(59, 13);
            this.lblTimeSet.TabIndex = 1;
            this.lblTimeSet.Text = "Time View:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 534);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpReports);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpAppointment);
            this.Controls.Add(this.lblAppointementsHeader);
            this.Controls.Add(this.dataAppointmentView);
            this.Name = "MainForm";
            this.Text = "Appointment Scheduler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointmentView)).EndInit();
            this.grpAppointment.ResumeLayout(false);
            this.grpAppointment.PerformLayout();
            this.grpApptDetails.ResumeLayout(false);
            this.grpApptDetails.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.grpReports.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAppointmentView;
        private System.Windows.Forms.Label lblAppointementsHeader;
        private System.Windows.Forms.GroupBox grpAppointment;
        private System.Windows.Forms.TextBox tboxApptId;
        private System.Windows.Forms.ComboBox cmbApptCustomers;
        private System.Windows.Forms.ComboBox cmbApptUsers;
        private System.Windows.Forms.Label lblApptCustomer;
        private System.Windows.Forms.Label lblApptUser;
        private System.Windows.Forms.Label lblApptID;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnApptNew;
        private System.Windows.Forms.GroupBox grpApptDetails;
        private System.Windows.Forms.DateTimePicker dtpApptEnd;
        private System.Windows.Forms.Label lblApptEnd;
        private System.Windows.Forms.DateTimePicker dtpApptStart;
        private System.Windows.Forms.Label lblApptStart;
        private System.Windows.Forms.ComboBox cmbApptType;
        private System.Windows.Forms.Label lblApptType;
        private System.Windows.Forms.TextBox tboxApptContact;
        private System.Windows.Forms.Label lblApptContact;
        private System.Windows.Forms.TextBox tboxApptLocation;
        private System.Windows.Forms.Label lblApptLocation;
        private System.Windows.Forms.TextBox tboxApptDescription;
        private System.Windows.Forms.Label lblApptDescription;
        private System.Windows.Forms.TextBox tboxApptTitle;
        private System.Windows.Forms.Label lblApptTitle;
        private System.Windows.Forms.Button btnApptDelete;
        private System.Windows.Forms.Button btnApptSave;
        private System.Windows.Forms.Button btnCustomerSave;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerNew;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.CheckBox checkCustomerActive;
        private System.Windows.Forms.ComboBox cmbCustomerAddress;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox tboxCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cmbCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.GroupBox grpReports;
        private System.Windows.Forms.Button btnReportGenerate;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton radioApptViewMonth;
        private System.Windows.Forms.RadioButton radioApptViewWeek;
        private System.Windows.Forms.Label lblTimeSet;
        private System.Windows.Forms.Label lblApptView;
        private System.Windows.Forms.RadioButton radioTimeViewUTC;
        private System.Windows.Forms.RadioButton radioTimeViewLocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxApptUrl;
        private System.Windows.Forms.Label lblApptUrl;
    }
}

