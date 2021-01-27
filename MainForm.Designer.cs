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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblApptID = new System.Windows.Forms.Label();
            this.lblApptUser = new System.Windows.Forms.Label();
            this.lblApptCustomer = new System.Windows.Forms.Label();
            this.cmbApptUsers = new System.Windows.Forms.ComboBox();
            this.cmbApptCustomers = new System.Windows.Forms.ComboBox();
            this.tboxApptId = new System.Windows.Forms.TextBox();
            this.grpApptDetails = new System.Windows.Forms.GroupBox();
            this.lblApptTitle = new System.Windows.Forms.Label();
            this.tboxApptTitle = new System.Windows.Forms.TextBox();
            this.tboxApptDescription = new System.Windows.Forms.TextBox();
            this.lblApptDescription = new System.Windows.Forms.Label();
            this.tboxApptLocation = new System.Windows.Forms.TextBox();
            this.lblApptLocation = new System.Windows.Forms.Label();
            this.tboxApptContact = new System.Windows.Forms.TextBox();
            this.lblApptContact = new System.Windows.Forms.Label();
            this.lblApptType = new System.Windows.Forms.Label();
            this.cmbApptType = new System.Windows.Forms.ComboBox();
            this.lblApptStart = new System.Windows.Forms.Label();
            this.dtpApptStart = new System.Windows.Forms.DateTimePicker();
            this.dtpApptEnd = new System.Windows.Forms.DateTimePicker();
            this.lblApptEnd = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.cmbCustomerId = new System.Windows.Forms.ComboBox();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tboxCustomerName = new System.Windows.Forms.TextBox();
            this.cmbCustomerAddress = new System.Windows.Forms.ComboBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.checkCustomerActive = new System.Windows.Forms.CheckBox();
            this.btnCustomerNew = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.btnApptNew = new System.Windows.Forms.Button();
            this.btnApptDelete = new System.Windows.Forms.Button();
            this.btnApptSave = new System.Windows.Forms.Button();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.btnReportGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointmentView)).BeginInit();
            this.grpAppointment.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpApptDetails.SuspendLayout();
            this.grpCustomerDetails.SuspendLayout();
            this.grpReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataAppointmentView
            // 
            this.dataAppointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAppointmentView.Location = new System.Drawing.Point(12, 371);
            this.dataAppointmentView.Name = "dataAppointmentView";
            this.dataAppointmentView.Size = new System.Drawing.Size(578, 150);
            this.dataAppointmentView.TabIndex = 0;
            // 
            // lblAppointementsHeader
            // 
            this.lblAppointementsHeader.AutoSize = true;
            this.lblAppointementsHeader.Location = new System.Drawing.Point(12, 355);
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
            this.grpAppointment.Size = new System.Drawing.Size(309, 329);
            this.grpAppointment.TabIndex = 2;
            this.grpAppointment.TabStop = false;
            this.grpAppointment.Text = "Appointment";
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
            // lblApptID
            // 
            this.lblApptID.AutoSize = true;
            this.lblApptID.Location = new System.Drawing.Point(6, 28);
            this.lblApptID.Name = "lblApptID";
            this.lblApptID.Size = new System.Drawing.Size(21, 13);
            this.lblApptID.TabIndex = 0;
            this.lblApptID.Text = "ID:";
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
            // lblApptCustomer
            // 
            this.lblApptCustomer.AutoSize = true;
            this.lblApptCustomer.Location = new System.Drawing.Point(79, 53);
            this.lblApptCustomer.Name = "lblApptCustomer";
            this.lblApptCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblApptCustomer.TabIndex = 2;
            this.lblApptCustomer.Text = "Customer:";
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
            // cmbApptCustomers
            // 
            this.cmbApptCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptCustomers.FormattingEnabled = true;
            this.cmbApptCustomers.Location = new System.Drawing.Point(139, 50);
            this.cmbApptCustomers.Name = "cmbApptCustomers";
            this.cmbApptCustomers.Size = new System.Drawing.Size(144, 21);
            this.cmbApptCustomers.TabIndex = 4;
            // 
            // tboxApptId
            // 
            this.tboxApptId.Location = new System.Drawing.Point(33, 25);
            this.tboxApptId.Name = "tboxApptId";
            this.tboxApptId.ReadOnly = true;
            this.tboxApptId.Size = new System.Drawing.Size(47, 20);
            this.tboxApptId.TabIndex = 5;
            // 
            // grpApptDetails
            // 
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
            // lblApptTitle
            // 
            this.lblApptTitle.AutoSize = true;
            this.lblApptTitle.Location = new System.Drawing.Point(8, 24);
            this.lblApptTitle.Name = "lblApptTitle";
            this.lblApptTitle.Size = new System.Drawing.Size(30, 13);
            this.lblApptTitle.TabIndex = 0;
            this.lblApptTitle.Text = "Title:";
            // 
            // tboxApptTitle
            // 
            this.tboxApptTitle.Location = new System.Drawing.Point(40, 21);
            this.tboxApptTitle.Name = "tboxApptTitle";
            this.tboxApptTitle.Size = new System.Drawing.Size(242, 20);
            this.tboxApptTitle.TabIndex = 1;
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
            // tboxApptContact
            // 
            this.tboxApptContact.Location = new System.Drawing.Point(55, 101);
            this.tboxApptContact.Name = "tboxApptContact";
            this.tboxApptContact.Size = new System.Drawing.Size(227, 20);
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
            // lblApptType
            // 
            this.lblApptType.AutoSize = true;
            this.lblApptType.Location = new System.Drawing.Point(8, 130);
            this.lblApptType.Name = "lblApptType";
            this.lblApptType.Size = new System.Drawing.Size(108, 13);
            this.lblApptType.TabIndex = 8;
            this.lblApptType.Text = "Type of Appointment:";
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
            // lblApptStart
            // 
            this.lblApptStart.AutoSize = true;
            this.lblApptStart.Location = new System.Drawing.Point(8, 157);
            this.lblApptStart.Name = "lblApptStart";
            this.lblApptStart.Size = new System.Drawing.Size(58, 13);
            this.lblApptStart.TabIndex = 10;
            this.lblApptStart.Text = "Start Date:";
            // 
            // dtpApptStart
            // 
            this.dtpApptStart.CustomFormat = "ddd dd MMM yyyy HH:MM:ss tt";
            this.dtpApptStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApptStart.Location = new System.Drawing.Point(71, 154);
            this.dtpApptStart.Name = "dtpApptStart";
            this.dtpApptStart.ShowUpDown = true;
            this.dtpApptStart.Size = new System.Drawing.Size(211, 20);
            this.dtpApptStart.TabIndex = 11;
            // 
            // dtpApptEnd
            // 
            this.dtpApptEnd.CustomFormat = "ddd dd MMM yyyy HH:MM:ss tt";
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
            this.lblApptEnd.Location = new System.Drawing.Point(8, 183);
            this.lblApptEnd.Name = "lblApptEnd";
            this.lblApptEnd.Size = new System.Drawing.Size(55, 13);
            this.lblApptEnd.TabIndex = 12;
            this.lblApptEnd.Text = "End Date:";
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
            // cmbCustomerId
            // 
            this.cmbCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerId.FormattingEnabled = true;
            this.cmbCustomerId.Location = new System.Drawing.Point(70, 19);
            this.cmbCustomerId.Name = "cmbCustomerId";
            this.cmbCustomerId.Size = new System.Drawing.Size(179, 21);
            this.cmbCustomerId.TabIndex = 1;
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
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(6, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // tboxCustomerName
            // 
            this.tboxCustomerName.Location = new System.Drawing.Point(50, 21);
            this.tboxCustomerName.Name = "tboxCustomerName";
            this.tboxCustomerName.Size = new System.Drawing.Size(192, 20);
            this.tboxCustomerName.TabIndex = 1;
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
            this.lblCustomerAddress.Location = new System.Drawing.Point(5, 48);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(48, 13);
            this.lblCustomerAddress.TabIndex = 2;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // checkCustomerActive
            // 
            this.checkCustomerActive.AutoSize = true;
            this.checkCustomerActive.Location = new System.Drawing.Point(8, 76);
            this.checkCustomerActive.Name = "checkCustomerActive";
            this.checkCustomerActive.Size = new System.Drawing.Size(99, 17);
            this.checkCustomerActive.TabIndex = 4;
            this.checkCustomerActive.Text = "Active Account";
            this.checkCustomerActive.UseVisualStyleBackColor = true;
            // 
            // btnCustomerNew
            // 
            this.btnCustomerNew.Location = new System.Drawing.Point(6, 163);
            this.btnCustomerNew.Name = "btnCustomerNew";
            this.btnCustomerNew.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerNew.TabIndex = 5;
            this.btnCustomerNew.Text = "New";
            this.btnCustomerNew.UseVisualStyleBackColor = true;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(179, 163);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerDelete.TabIndex = 6;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Location = new System.Drawing.Point(93, 163);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerSave.TabIndex = 7;
            this.btnCustomerSave.Text = "Save";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            // 
            // btnApptNew
            // 
            this.btnApptNew.Location = new System.Drawing.Point(9, 292);
            this.btnApptNew.Name = "btnApptNew";
            this.btnApptNew.Size = new System.Drawing.Size(75, 23);
            this.btnApptNew.TabIndex = 10;
            this.btnApptNew.Text = "New";
            this.btnApptNew.UseVisualStyleBackColor = true;
            // 
            // btnApptDelete
            // 
            this.btnApptDelete.Location = new System.Drawing.Point(228, 292);
            this.btnApptDelete.Name = "btnApptDelete";
            this.btnApptDelete.Size = new System.Drawing.Size(75, 23);
            this.btnApptDelete.TabIndex = 9;
            this.btnApptDelete.Text = "Delete";
            this.btnApptDelete.UseVisualStyleBackColor = true;
            // 
            // btnApptSave
            // 
            this.btnApptSave.Location = new System.Drawing.Point(147, 292);
            this.btnApptSave.Name = "btnApptSave";
            this.btnApptSave.Size = new System.Drawing.Size(75, 23);
            this.btnApptSave.TabIndex = 8;
            this.btnApptSave.Text = "Save";
            this.btnApptSave.UseVisualStyleBackColor = true;
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
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(6, 19);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(162, 21);
            this.cmbReportType.TabIndex = 0;
            // 
            // btnReportGenerate
            // 
            this.btnReportGenerate.Location = new System.Drawing.Point(179, 17);
            this.btnReportGenerate.Name = "btnReportGenerate";
            this.btnReportGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnReportGenerate.TabIndex = 11;
            this.btnReportGenerate.Text = "Generate";
            this.btnReportGenerate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 533);
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
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpApptDetails.ResumeLayout(false);
            this.grpApptDetails.PerformLayout();
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.grpReports.ResumeLayout(false);
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
    }
}

