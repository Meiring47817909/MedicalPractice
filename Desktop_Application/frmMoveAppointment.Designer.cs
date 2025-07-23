namespace Desktop_Application
{
    partial class frmMoveAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgAppointments = new System.Windows.Forms.DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAppointmentID = new MaterialSkin.Controls.MaterialComboBox();
            this.btnMove = new MaterialSkin.Controls.MaterialButton();
            this.lblAppointment = new MaterialSkin.Controls.MaterialLabel();
            this.lblSelect = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAppointments
            // 
            this.dtgAppointments.AllowUserToAddRows = false;
            this.dtgAppointments.AllowUserToDeleteRows = false;
            this.dtgAppointments.AllowUserToOrderColumns = true;
            this.dtgAppointments.AllowUserToResizeColumns = false;
            this.dtgAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.Date,
            this.Time,
            this.Doctor,
            this.Status});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAppointments.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgAppointments.Location = new System.Drawing.Point(168, 112);
            this.dtgAppointments.Name = "dtgAppointments";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgAppointments.RowTemplate.Height = 30;
            this.dtgAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgAppointments.Size = new System.Drawing.Size(608, 168);
            this.dtgAppointments.TabIndex = 23;
            // 
            // AppointmentID
            // 
            this.AppointmentID.DataPropertyName = "AppointmentID";
            this.AppointmentID.HeaderText = "Appointment ID";
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.ReadOnly = true;
            this.AppointmentID.Width = 162;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date_Time";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle8;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Date_Time";
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            this.Time.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.Status.DefaultCellStyle = dataGridViewCellStyle10;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // cmbAppointmentID
            // 
            this.cmbAppointmentID.AutoResize = false;
            this.cmbAppointmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAppointmentID.Depth = 0;
            this.cmbAppointmentID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAppointmentID.DropDownHeight = 118;
            this.cmbAppointmentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentID.DropDownWidth = 121;
            this.cmbAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbAppointmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbAppointmentID.FormattingEnabled = true;
            this.cmbAppointmentID.IntegralHeight = false;
            this.cmbAppointmentID.ItemHeight = 29;
            this.cmbAppointmentID.Location = new System.Drawing.Point(8, 112);
            this.cmbAppointmentID.MaxDropDownItems = 4;
            this.cmbAppointmentID.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbAppointmentID.Name = "cmbAppointmentID";
            this.cmbAppointmentID.Size = new System.Drawing.Size(121, 35);
            this.cmbAppointmentID.StartIndex = 0;
            this.cmbAppointmentID.TabIndex = 25;
            this.cmbAppointmentID.UseTallSize = false;
            // 
            // btnMove
            // 
            this.btnMove.AutoSize = false;
            this.btnMove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMove.Depth = 0;
            this.btnMove.HighEmphasis = true;
            this.btnMove.Icon = null;
            this.btnMove.Location = new System.Drawing.Point(8, 168);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMove.Name = "btnMove";
            this.btnMove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMove.Size = new System.Drawing.Size(120, 36);
            this.btnMove.TabIndex = 26;
            this.btnMove.Text = "Move";
            this.btnMove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMove.UseAccentColor = false;
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Depth = 0;
            this.lblAppointment.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAppointment.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblAppointment.Location = new System.Drawing.Point(8, 80);
            this.lblAppointment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(140, 24);
            this.lblAppointment.TabIndex = 40;
            this.lblAppointment.Text = "Appointment ID";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Depth = 0;
            this.lblSelect.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelect.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblSelect.Location = new System.Drawing.Point(168, 80);
            this.lblSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(399, 24);
            this.lblSelect.TabIndex = 41;
            this.lblSelect.Text = "Select the available appointment to move to:";
            // 
            // frmMoveAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 287);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.cmbAppointmentID);
            this.Controls.Add(this.dtgAppointments);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 287);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(785, 287);
            this.Name = "frmMoveAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move a appointment";
            this.Load += new System.EventHandler(this.frmMoveAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private MaterialSkin.Controls.MaterialComboBox cmbAppointmentID;
        private MaterialSkin.Controls.MaterialButton btnMove;
        private MaterialSkin.Controls.MaterialLabel lblAppointment;
        private MaterialSkin.Controls.MaterialLabel lblSelect;
    }
}