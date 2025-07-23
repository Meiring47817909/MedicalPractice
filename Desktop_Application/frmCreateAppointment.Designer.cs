namespace Desktop_Application
{
    partial class frmCreateAppointment
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
            this.btnCreate = new MaterialSkin.Controls.MaterialButton();
            this.pnlDoctor = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rbtnVisser = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnEngelbrecht = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnVisagie = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnGoosen = new MaterialSkin.Controls.MaterialRadioButton();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.cmbTime = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTime = new MaterialSkin.Controls.MaterialLabel();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.pnlDoctor.SuspendLayout();
            this.pnlDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = false;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreate.Depth = 0;
            this.btnCreate.HighEmphasis = true;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(8, 240);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreate.Size = new System.Drawing.Size(136, 32);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreate.UseAccentColor = false;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlDoctor
            // 
            this.pnlDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDoctor.Controls.Add(this.materialLabel1);
            this.pnlDoctor.Controls.Add(this.rbtnVisser);
            this.pnlDoctor.Controls.Add(this.rbtnEngelbrecht);
            this.pnlDoctor.Controls.Add(this.rbtnVisagie);
            this.pnlDoctor.Controls.Add(this.rbtnGoosen);
            this.pnlDoctor.Location = new System.Drawing.Point(152, 72);
            this.pnlDoctor.Name = "pnlDoctor";
            this.pnlDoctor.Size = new System.Drawing.Size(136, 200);
            this.pnlDoctor.TabIndex = 39;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(16, 8);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 24);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "Doctor";
            // 
            // rbtnVisser
            // 
            this.rbtnVisser.AutoSize = true;
            this.rbtnVisser.Depth = 0;
            this.rbtnVisser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVisser.Location = new System.Drawing.Point(8, 160);
            this.rbtnVisser.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnVisser.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnVisser.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnVisser.Name = "rbtnVisser";
            this.rbtnVisser.Ripple = true;
            this.rbtnVisser.Size = new System.Drawing.Size(78, 37);
            this.rbtnVisser.TabIndex = 19;
            this.rbtnVisser.TabStop = true;
            this.rbtnVisser.Text = "Visser";
            this.rbtnVisser.UseVisualStyleBackColor = true;
            // 
            // rbtnEngelbrecht
            // 
            this.rbtnEngelbrecht.AutoSize = true;
            this.rbtnEngelbrecht.Depth = 0;
            this.rbtnEngelbrecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEngelbrecht.Location = new System.Drawing.Point(8, 120);
            this.rbtnEngelbrecht.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnEngelbrecht.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnEngelbrecht.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnEngelbrecht.Name = "rbtnEngelbrecht";
            this.rbtnEngelbrecht.Ripple = true;
            this.rbtnEngelbrecht.Size = new System.Drawing.Size(118, 37);
            this.rbtnEngelbrecht.TabIndex = 18;
            this.rbtnEngelbrecht.TabStop = true;
            this.rbtnEngelbrecht.Text = "Engelbrecht";
            this.rbtnEngelbrecht.UseVisualStyleBackColor = true;
            // 
            // rbtnVisagie
            // 
            this.rbtnVisagie.AutoSize = true;
            this.rbtnVisagie.Depth = 0;
            this.rbtnVisagie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVisagie.Location = new System.Drawing.Point(8, 80);
            this.rbtnVisagie.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnVisagie.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnVisagie.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnVisagie.Name = "rbtnVisagie";
            this.rbtnVisagie.Ripple = true;
            this.rbtnVisagie.Size = new System.Drawing.Size(87, 37);
            this.rbtnVisagie.TabIndex = 17;
            this.rbtnVisagie.TabStop = true;
            this.rbtnVisagie.Text = "Visagie";
            this.rbtnVisagie.UseVisualStyleBackColor = true;
            // 
            // rbtnGoosen
            // 
            this.rbtnGoosen.AutoSize = true;
            this.rbtnGoosen.Depth = 0;
            this.rbtnGoosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGoosen.Location = new System.Drawing.Point(8, 40);
            this.rbtnGoosen.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnGoosen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnGoosen.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnGoosen.Name = "rbtnGoosen";
            this.rbtnGoosen.Ripple = true;
            this.rbtnGoosen.Size = new System.Drawing.Size(89, 37);
            this.rbtnGoosen.TabIndex = 16;
            this.rbtnGoosen.TabStop = true;
            this.rbtnGoosen.Text = "Goosen";
            this.rbtnGoosen.UseVisualStyleBackColor = true;
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDateTime.Controls.Add(this.cmbTime);
            this.pnlDateTime.Controls.Add(this.lblTime);
            this.pnlDateTime.Controls.Add(this.dtpAppointment);
            this.pnlDateTime.Controls.Add(this.lblDate);
            this.pnlDateTime.Location = new System.Drawing.Point(8, 72);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(136, 160);
            this.pnlDateTime.TabIndex = 40;
            // 
            // cmbTime
            // 
            this.cmbTime.AutoResize = false;
            this.cmbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTime.Depth = 0;
            this.cmbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTime.DropDownHeight = 118;
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.DropDownWidth = 121;
            this.cmbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.IntegralHeight = false;
            this.cmbTime.ItemHeight = 29;
            this.cmbTime.Location = new System.Drawing.Point(8, 112);
            this.cmbTime.MaxDropDownItems = 4;
            this.cmbTime.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 35);
            this.cmbTime.StartIndex = 0;
            this.cmbTime.TabIndex = 41;
            this.cmbTime.UseTallSize = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Depth = 0;
            this.lblTime.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTime.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTime.Location = new System.Drawing.Point(8, 80);
            this.lblTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 24);
            this.lblTime.TabIndex = 40;
            this.lblTime.Text = "Time";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.CustomFormat = "";
            this.dtpAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointment.Location = new System.Drawing.Point(8, 40);
            this.dtpAppointment.MinDate = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(120, 26);
            this.dtpAppointment.TabIndex = 39;
            this.dtpAppointment.Value = new System.DateTime(2024, 6, 4, 21, 58, 5, 0);
            this.dtpAppointment.ValueChanged += new System.EventHandler(this.dtpAppointment_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblDate.Location = new System.Drawing.Point(8, 8);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 24);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "Date";
            // 
            // frmCreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 280);
            this.Controls.Add(this.pnlDateTime);
            this.Controls.Add(this.pnlDoctor);
            this.Controls.Add(this.btnCreate);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 280);
            this.Name = "frmCreateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create an appointment";
            this.Load += new System.EventHandler(this.frmCreateAppointment_Load);
            this.pnlDoctor.ResumeLayout(false);
            this.pnlDoctor.PerformLayout();
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnCreate;
        private System.Windows.Forms.Panel pnlDoctor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rbtnVisser;
        private MaterialSkin.Controls.MaterialRadioButton rbtnEngelbrecht;
        private MaterialSkin.Controls.MaterialRadioButton rbtnVisagie;
        private MaterialSkin.Controls.MaterialRadioButton rbtnGoosen;
        private System.Windows.Forms.Panel pnlDateTime;
        private MaterialSkin.Controls.MaterialComboBox cmbTime;
        private MaterialSkin.Controls.MaterialLabel lblTime;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private MaterialSkin.Controls.MaterialLabel lblDate;
    }
}