namespace WGU_C969 {
    partial class ReportOptionsTypeMonthForm {
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblMeetingType = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbAppointmentType = new System.Windows.Forms.ComboBox();
            this.cmbAppointmentMonth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(52, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(164, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Please select your options below:";
            // 
            // lblMeetingType
            // 
            this.lblMeetingType.AutoSize = true;
            this.lblMeetingType.Location = new System.Drawing.Point(12, 54);
            this.lblMeetingType.Name = "lblMeetingType";
            this.lblMeetingType.Size = new System.Drawing.Size(34, 13);
            this.lblMeetingType.TabIndex = 1;
            this.lblMeetingType.Text = "Type:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(6, 91);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(27, 152);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbAppointmentType
            // 
            this.cmbAppointmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentType.FormattingEnabled = true;
            this.cmbAppointmentType.Location = new System.Drawing.Point(55, 51);
            this.cmbAppointmentType.Name = "cmbAppointmentType";
            this.cmbAppointmentType.Size = new System.Drawing.Size(190, 21);
            this.cmbAppointmentType.TabIndex = 5;
            // 
            // cmbAppointmentMonth
            // 
            this.cmbAppointmentMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentMonth.FormattingEnabled = true;
            this.cmbAppointmentMonth.Location = new System.Drawing.Point(55, 88);
            this.cmbAppointmentMonth.Name = "cmbAppointmentMonth";
            this.cmbAppointmentMonth.Size = new System.Drawing.Size(190, 21);
            this.cmbAppointmentMonth.TabIndex = 6;
            // 
            // ReportOptionsTypeMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 199);
            this.Controls.Add(this.cmbAppointmentMonth);
            this.Controls.Add(this.cmbAppointmentType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblMeetingType);
            this.Controls.Add(this.lblInstructions);
            this.Name = "ReportOptionsTypeMonthForm";
            this.Text = "Report Options";
            this.Load += new System.EventHandler(this.ReportOptionsTypeMonthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMeetingType;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbAppointmentType;
        private System.Windows.Forms.ComboBox cmbAppointmentMonth;
    }
}