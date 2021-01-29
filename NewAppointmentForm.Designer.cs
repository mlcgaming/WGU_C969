namespace WGU_C969 {
    partial class NewAppointmentForm {
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
            this.grpAppointment = new System.Windows.Forms.GroupBox();
            this.btnSaveForm = new System.Windows.Forms.Button();
            this.grpApptDetails = new System.Windows.Forms.GroupBox();
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
            this.btnCancelForm = new System.Windows.Forms.Button();
            this.tboxApptId = new System.Windows.Forms.TextBox();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.cmbApptCustomers = new System.Windows.Forms.ComboBox();
            this.cmbApptUsers = new System.Windows.Forms.ComboBox();
            this.lblApptCustomer = new System.Windows.Forms.Label();
            this.lblApptUser = new System.Windows.Forms.Label();
            this.lblApptID = new System.Windows.Forms.Label();
            this.tboxApptUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAppointment.SuspendLayout();
            this.grpApptDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAppointment
            // 
            this.grpAppointment.Controls.Add(this.btnSaveForm);
            this.grpAppointment.Controls.Add(this.grpApptDetails);
            this.grpAppointment.Controls.Add(this.btnCancelForm);
            this.grpAppointment.Controls.Add(this.tboxApptId);
            this.grpAppointment.Controls.Add(this.btnResetForm);
            this.grpAppointment.Controls.Add(this.cmbApptCustomers);
            this.grpAppointment.Controls.Add(this.cmbApptUsers);
            this.grpAppointment.Controls.Add(this.lblApptCustomer);
            this.grpAppointment.Controls.Add(this.lblApptUser);
            this.grpAppointment.Controls.Add(this.lblApptID);
            this.grpAppointment.Location = new System.Drawing.Point(12, 12);
            this.grpAppointment.Name = "grpAppointment";
            this.grpAppointment.Size = new System.Drawing.Size(309, 329);
            this.grpAppointment.TabIndex = 3;
            this.grpAppointment.TabStop = false;
            this.grpAppointment.Text = "Appointment";
            // 
            // btnSaveForm
            // 
            this.btnSaveForm.Location = new System.Drawing.Point(9, 292);
            this.btnSaveForm.Name = "btnSaveForm";
            this.btnSaveForm.Size = new System.Drawing.Size(75, 23);
            this.btnSaveForm.TabIndex = 10;
            this.btnSaveForm.Text = "Save";
            this.btnSaveForm.UseVisualStyleBackColor = true;
            this.btnSaveForm.Click += new System.EventHandler(this.btnSaveForm_Click);
            // 
            // grpApptDetails
            // 
            this.grpApptDetails.Controls.Add(this.tboxApptUrl);
            this.grpApptDetails.Controls.Add(this.label1);
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
            this.tboxApptContact.Location = new System.Drawing.Point(196, 75);
            this.tboxApptContact.Name = "tboxApptContact";
            this.tboxApptContact.Size = new System.Drawing.Size(86, 20);
            this.tboxApptContact.TabIndex = 7;
            // 
            // lblApptContact
            // 
            this.lblApptContact.AutoSize = true;
            this.lblApptContact.Location = new System.Drawing.Point(149, 78);
            this.lblApptContact.Name = "lblApptContact";
            this.lblApptContact.Size = new System.Drawing.Size(47, 13);
            this.lblApptContact.TabIndex = 6;
            this.lblApptContact.Text = "Contact:";
            // 
            // tboxApptLocation
            // 
            this.tboxApptLocation.Location = new System.Drawing.Point(61, 75);
            this.tboxApptLocation.Name = "tboxApptLocation";
            this.tboxApptLocation.Size = new System.Drawing.Size(82, 20);
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
            // btnCancelForm
            // 
            this.btnCancelForm.Location = new System.Drawing.Point(228, 292);
            this.btnCancelForm.Name = "btnCancelForm";
            this.btnCancelForm.Size = new System.Drawing.Size(75, 23);
            this.btnCancelForm.TabIndex = 9;
            this.btnCancelForm.Text = "Cancel";
            this.btnCancelForm.UseVisualStyleBackColor = true;
            this.btnCancelForm.Click += new System.EventHandler(this.btnCancelForm_Click);
            // 
            // tboxApptId
            // 
            this.tboxApptId.Location = new System.Drawing.Point(33, 25);
            this.tboxApptId.Name = "tboxApptId";
            this.tboxApptId.ReadOnly = true;
            this.tboxApptId.Size = new System.Drawing.Size(47, 20);
            this.tboxApptId.TabIndex = 5;
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(147, 292);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 8;
            this.btnResetForm.Text = "Reset";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
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
            // tboxApptUrl
            // 
            this.tboxApptUrl.Location = new System.Drawing.Point(46, 101);
            this.tboxApptUrl.Name = "tboxApptUrl";
            this.tboxApptUrl.Size = new System.Drawing.Size(236, 20);
            this.tboxApptUrl.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "URL:";
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 353);
            this.Controls.Add(this.grpAppointment);
            this.Name = "NewAppointmentForm";
            this.Text = "New Appointment";
            this.grpAppointment.ResumeLayout(false);
            this.grpAppointment.PerformLayout();
            this.grpApptDetails.ResumeLayout(false);
            this.grpApptDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAppointment;
        private System.Windows.Forms.Button btnSaveForm;
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
        private System.Windows.Forms.Button btnCancelForm;
        private System.Windows.Forms.TextBox tboxApptId;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.ComboBox cmbApptCustomers;
        private System.Windows.Forms.ComboBox cmbApptUsers;
        private System.Windows.Forms.Label lblApptCustomer;
        private System.Windows.Forms.Label lblApptUser;
        private System.Windows.Forms.Label lblApptID;
        private System.Windows.Forms.TextBox tboxApptUrl;
        private System.Windows.Forms.Label label1;
    }
}