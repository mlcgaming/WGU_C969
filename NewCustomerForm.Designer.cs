namespace WGU_C969 {
    partial class NewCustomerForm {
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
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnCancelForm = new System.Windows.Forms.Button();
            this.btnSaveForm = new System.Windows.Forms.Button();
            this.checkCustomerActive = new System.Windows.Forms.CheckBox();
            this.cmbCustomerAddress = new System.Windows.Forms.ComboBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.tboxCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.tboxCustomerId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(106, 113);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearForm.TabIndex = 7;
            this.btnClearForm.Text = "Reset";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnCancelForm
            // 
            this.btnCancelForm.Location = new System.Drawing.Point(187, 113);
            this.btnCancelForm.Name = "btnCancelForm";
            this.btnCancelForm.Size = new System.Drawing.Size(75, 23);
            this.btnCancelForm.TabIndex = 6;
            this.btnCancelForm.Text = "Cancel";
            this.btnCancelForm.UseVisualStyleBackColor = true;
            this.btnCancelForm.Click += new System.EventHandler(this.btnCancelForm_Click);
            // 
            // btnSaveForm
            // 
            this.btnSaveForm.Location = new System.Drawing.Point(20, 113);
            this.btnSaveForm.Name = "btnSaveForm";
            this.btnSaveForm.Size = new System.Drawing.Size(75, 23);
            this.btnSaveForm.TabIndex = 5;
            this.btnSaveForm.Text = "Save";
            this.btnSaveForm.UseVisualStyleBackColor = true;
            this.btnSaveForm.Click += new System.EventHandler(this.btnSaveForm_Click);
            // 
            // checkCustomerActive
            // 
            this.checkCustomerActive.AutoSize = true;
            this.checkCustomerActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCustomerActive.Location = new System.Drawing.Point(150, 77);
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
            this.cmbCustomerAddress.Location = new System.Drawing.Point(71, 48);
            this.cmbCustomerAddress.Name = "cmbCustomerAddress";
            this.cmbCustomerAddress.Size = new System.Drawing.Size(192, 21);
            this.cmbCustomerAddress.TabIndex = 3;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(17, 51);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(56, 13);
            this.lblCustomerAddress.TabIndex = 2;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // tboxCustomerName
            // 
            this.tboxCustomerName.Location = new System.Drawing.Point(135, 18);
            this.tboxCustomerName.Name = "tboxCustomerName";
            this.tboxCustomerName.Size = new System.Drawing.Size(127, 20);
            this.tboxCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(91, 21);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(43, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(17, 21);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(21, 13);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "ID:";
            // 
            // tboxCustomerId
            // 
            this.tboxCustomerId.Location = new System.Drawing.Point(44, 18);
            this.tboxCustomerId.Name = "tboxCustomerId";
            this.tboxCustomerId.ReadOnly = true;
            this.tboxCustomerId.Size = new System.Drawing.Size(41, 20);
            this.tboxCustomerId.TabIndex = 8;
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 149);
            this.Controls.Add(this.tboxCustomerId);
            this.Controls.Add(this.checkCustomerActive);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.btnSaveForm);
            this.Controls.Add(this.cmbCustomerAddress);
            this.Controls.Add(this.btnCancelForm);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.tboxCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "NewCustomerForm";
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnCancelForm;
        private System.Windows.Forms.Button btnSaveForm;
        private System.Windows.Forms.CheckBox checkCustomerActive;
        private System.Windows.Forms.ComboBox cmbCustomerAddress;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox tboxCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox tboxCustomerId;
    }
}