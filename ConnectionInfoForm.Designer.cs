namespace WGU_C969 {
    partial class ConnectionInfoForm {
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
            this.components = new System.ComponentModel.Container();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblDBServer = new System.Windows.Forms.Label();
            this.lblDBPort = new System.Windows.Forms.Label();
            this.lblDBSchema = new System.Windows.Forms.Label();
            this.lblDBUser = new System.Windows.Forms.Label();
            this.tboxDBServer = new System.Windows.Forms.TextBox();
            this.tboxDBPort = new System.Windows.Forms.TextBox();
            this.tboxDBSchema = new System.Windows.Forms.TextBox();
            this.tboxDBUser = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tooltipMain = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(21, 9);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(177, 13);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Fields are Read Only in Trial Version";
            // 
            // lblDBServer
            // 
            this.lblDBServer.AutoSize = true;
            this.lblDBServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBServer.Location = new System.Drawing.Point(29, 61);
            this.lblDBServer.Name = "lblDBServer";
            this.lblDBServer.Size = new System.Drawing.Size(41, 13);
            this.lblDBServer.TabIndex = 1;
            this.lblDBServer.Text = "Server:";
            // 
            // lblDBPort
            // 
            this.lblDBPort.AutoSize = true;
            this.lblDBPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBPort.Location = new System.Drawing.Point(41, 90);
            this.lblDBPort.Name = "lblDBPort";
            this.lblDBPort.Size = new System.Drawing.Size(29, 13);
            this.lblDBPort.TabIndex = 2;
            this.lblDBPort.Text = "Port:";
            // 
            // lblDBSchema
            // 
            this.lblDBSchema.AutoSize = true;
            this.lblDBSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBSchema.Location = new System.Drawing.Point(21, 119);
            this.lblDBSchema.Name = "lblDBSchema";
            this.lblDBSchema.Size = new System.Drawing.Size(49, 13);
            this.lblDBSchema.TabIndex = 3;
            this.lblDBSchema.Text = "Schema:";
            // 
            // lblDBUser
            // 
            this.lblDBUser.AutoSize = true;
            this.lblDBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBUser.Location = new System.Drawing.Point(12, 148);
            this.lblDBUser.Name = "lblDBUser";
            this.lblDBUser.Size = new System.Drawing.Size(58, 13);
            this.lblDBUser.TabIndex = 4;
            this.lblDBUser.Text = "Username:";
            // 
            // tboxDBServer
            // 
            this.tboxDBServer.Location = new System.Drawing.Point(76, 58);
            this.tboxDBServer.Name = "tboxDBServer";
            this.tboxDBServer.ReadOnly = true;
            this.tboxDBServer.Size = new System.Drawing.Size(122, 20);
            this.tboxDBServer.TabIndex = 5;
            // 
            // tboxDBPort
            // 
            this.tboxDBPort.Location = new System.Drawing.Point(76, 87);
            this.tboxDBPort.Name = "tboxDBPort";
            this.tboxDBPort.ReadOnly = true;
            this.tboxDBPort.Size = new System.Drawing.Size(54, 20);
            this.tboxDBPort.TabIndex = 6;
            // 
            // tboxDBSchema
            // 
            this.tboxDBSchema.Location = new System.Drawing.Point(76, 116);
            this.tboxDBSchema.Name = "tboxDBSchema";
            this.tboxDBSchema.ReadOnly = true;
            this.tboxDBSchema.Size = new System.Drawing.Size(122, 20);
            this.tboxDBSchema.TabIndex = 7;
            // 
            // tboxDBUser
            // 
            this.tboxDBUser.Location = new System.Drawing.Point(76, 145);
            this.tboxDBUser.Name = "tboxDBUser";
            this.tboxDBUser.ReadOnly = true;
            this.tboxDBUser.Size = new System.Drawing.Size(122, 20);
            this.tboxDBUser.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(135, 182);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.tooltipMain.SetToolTip(this.btnSave, "Disabled in Trial Version");
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ConnectionInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 215);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tboxDBUser);
            this.Controls.Add(this.tboxDBSchema);
            this.Controls.Add(this.tboxDBPort);
            this.Controls.Add(this.tboxDBServer);
            this.Controls.Add(this.lblDBUser);
            this.Controls.Add(this.lblDBSchema);
            this.Controls.Add(this.lblDBPort);
            this.Controls.Add(this.lblDBServer);
            this.Controls.Add(this.lblWarning);
            this.Name = "ConnectionInfoForm";
            this.Text = "Connection Info";
            this.Load += new System.EventHandler(this.ConnectionInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblDBServer;
        private System.Windows.Forms.Label lblDBPort;
        private System.Windows.Forms.Label lblDBSchema;
        private System.Windows.Forms.Label lblDBUser;
        private System.Windows.Forms.TextBox tboxDBServer;
        private System.Windows.Forms.TextBox tboxDBPort;
        private System.Windows.Forms.TextBox tboxDBSchema;
        private System.Windows.Forms.TextBox tboxDBUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip tooltipMain;
    }
}