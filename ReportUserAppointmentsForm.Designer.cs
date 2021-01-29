namespace WGU_C969 {
    partial class ReportUserAppointmentsForm {
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.cmbReportUsers = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(84, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(71, 13);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Select a User";
            // 
            // cmbReportUsers
            // 
            this.cmbReportUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportUsers.FormattingEnabled = true;
            this.cmbReportUsers.Location = new System.Drawing.Point(12, 38);
            this.cmbReportUsers.Name = "cmbReportUsers";
            this.cmbReportUsers.Size = new System.Drawing.Size(219, 21);
            this.cmbReportUsers.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 79);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReportUserAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 114);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cmbReportUsers);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "ReportUserAppointmentsForm";
            this.Text = "Report Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ComboBox cmbReportUsers;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}