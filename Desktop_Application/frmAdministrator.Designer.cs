namespace Desktop_Application
{
    partial class frmAdministrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuAdministrator = new System.Windows.Forms.MenuStrip();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInvoice = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.dtgAppointments = new System.Windows.Forms.DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cancelled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAdministrator
            // 
            this.menuAdministrator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentToolStripMenuItem,
            this.patientToolStripMenuItem});
            this.menuAdministrator.Location = new System.Drawing.Point(3, 64);
            this.menuAdministrator.Name = "menuAdministrator";
            this.menuAdministrator.Size = new System.Drawing.Size(1009, 45);
            this.menuAdministrator.TabIndex = 0;
            this.menuAdministrator.Text = "menuStrip1";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.moveToolStripMenuItem});
            this.appointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(186, 41);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(171, 42);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(171, 42);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPatientToolStripMenuItem});
            this.patientToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(111, 41);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // registerPatientToolStripMenuItem
            // 
            this.registerPatientToolStripMenuItem.Name = "registerPatientToolStripMenuItem";
            this.registerPatientToolStripMenuItem.Size = new System.Drawing.Size(280, 42);
            this.registerPatientToolStripMenuItem.Text = "Register patient";
            this.registerPatientToolStripMenuItem.Click += new System.EventHandler(this.registerPatientToolStripMenuItem_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.AutoSize = false;
            this.btnInvoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInvoice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInvoice.Depth = 0;
            this.btnInvoice.HighEmphasis = true;
            this.btnInvoice.Icon = null;
            this.btnInvoice.Location = new System.Drawing.Point(8, 144);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInvoice.Size = new System.Drawing.Size(280, 36);
            this.btnInvoice.TabIndex = 1;
            this.btnInvoice.Text = "Invoice a complete appointment";
            this.btnInvoice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInvoice.UseAccentColor = false;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(724, 144);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(280, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete all cancelled appointments";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtgAppointments
            // 
            this.dtgAppointments.AllowUserToAddRows = false;
            this.dtgAppointments.AllowUserToDeleteRows = false;
            this.dtgAppointments.AllowUserToResizeColumns = false;
            this.dtgAppointments.AllowUserToResizeRows = false;
            this.dtgAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.PatientID,
            this.Date,
            this.Time,
            this.Doctor,
            this.Status,
            this.Complete,
            this.Cancelled});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAppointments.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgAppointments.Location = new System.Drawing.Point(8, 192);
            this.dtgAppointments.MultiSelect = false;
            this.dtgAppointments.Name = "dtgAppointments";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgAppointments.RowTemplate.Height = 30;
            this.dtgAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgAppointments.Size = new System.Drawing.Size(994, 216);
            this.dtgAppointments.TabIndex = 4;
            this.dtgAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAppointments_CellContentClick);
            this.dtgAppointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgAppointments_CellFormatting);
            this.dtgAppointments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgAppointments_CellMouseDoubleClick);
            // 
            // AppointmentID
            // 
            this.AppointmentID.DataPropertyName = "AppointmentID";
            this.AppointmentID.HeaderText = "Appointment";
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "Patient";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date_Time";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Date_Time";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.Time.DefaultCellStyle = dataGridViewCellStyle3;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Doctor
            // 
            this.Doctor.DataPropertyName = "Doctor";
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Complete
            // 
            this.Complete.DataPropertyName = "Complete";
            this.Complete.FalseValue = "false";
            this.Complete.HeaderText = "Complete";
            this.Complete.IndeterminateValue = "";
            this.Complete.Name = "Complete";
            this.Complete.ReadOnly = true;
            this.Complete.TrueValue = "true";
            // 
            // Cancelled
            // 
            this.Cancelled.DataPropertyName = "Cancelled";
            this.Cancelled.FalseValue = "false";
            this.Cancelled.HeaderText = "Cancelled";
            this.Cancelled.IndeterminateValue = "";
            this.Cancelled.Name = "Cancelled";
            this.Cancelled.ReadOnly = true;
            this.Cancelled.TrueValue = "true";
            // 
            // frmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 417);
            this.Controls.Add(this.dtgAppointments);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.menuAdministrator);
            this.MainMenuStrip = this.menuAdministrator;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1015, 417);
            this.Name = "frmAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdministrator_FormClosing);
            this.Load += new System.EventHandler(this.frmAdministrator_Load);
            this.menuAdministrator.ResumeLayout(false);
            this.menuAdministrator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdministrator;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPatientToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton btnInvoice;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private System.Windows.Forms.DataGridView dtgAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Complete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cancelled;
    }
}