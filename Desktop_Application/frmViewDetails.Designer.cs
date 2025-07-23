namespace Desktop_Application
{
    partial class frmViewDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmergencyContact = new MaterialSkin.Controls.MaterialLabel();
            this.lblContact = new MaterialSkin.Controls.MaterialLabel();
            this.lblSurname = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmergencyContact = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContact = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblProcedure = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProcedure = new MaterialSkin.Controls.MaterialTextBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblEmergencyContact);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtEmergencyContact);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(8, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 488);
            this.panel1.TabIndex = 31;
            // 
            // lblEmergencyContact
            // 
            this.lblEmergencyContact.AutoSize = true;
            this.lblEmergencyContact.Depth = 0;
            this.lblEmergencyContact.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmergencyContact.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblEmergencyContact.Location = new System.Drawing.Point(8, 392);
            this.lblEmergencyContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmergencyContact.Name = "lblEmergencyContact";
            this.lblEmergencyContact.Size = new System.Drawing.Size(169, 24);
            this.lblEmergencyContact.TabIndex = 40;
            this.lblEmergencyContact.Text = "Emergenct contact";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Depth = 0;
            this.lblContact.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblContact.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblContact.Location = new System.Drawing.Point(8, 296);
            this.lblContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(144, 24);
            this.lblContact.TabIndex = 39;
            this.lblContact.Text = "Contact number";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Depth = 0;
            this.lblSurname.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSurname.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblSurname.Location = new System.Drawing.Point(8, 104);
            this.lblSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 24);
            this.lblSurname.TabIndex = 37;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblName.Location = new System.Drawing.Point(8, 8);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 24);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Name";
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.AnimateReadOnly = false;
            this.txtEmergencyContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmergencyContact.Depth = 0;
            this.txtEmergencyContact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmergencyContact.LeadingIcon = null;
            this.txtEmergencyContact.Location = new System.Drawing.Point(8, 424);
            this.txtEmergencyContact.MaxLength = 50;
            this.txtEmergencyContact.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmergencyContact.Multiline = false;
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.ReadOnly = true;
            this.txtEmergencyContact.Size = new System.Drawing.Size(200, 50);
            this.txtEmergencyContact.TabIndex = 35;
            this.txtEmergencyContact.Text = "";
            this.txtEmergencyContact.TrailingIcon = null;
            // 
            // txtContact
            // 
            this.txtContact.AnimateReadOnly = false;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Depth = 0;
            this.txtContact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContact.LeadingIcon = null;
            this.txtContact.Location = new System.Drawing.Point(8, 328);
            this.txtContact.MaxLength = 50;
            this.txtContact.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContact.Multiline = false;
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(200, 50);
            this.txtContact.TabIndex = 34;
            this.txtContact.Text = "";
            this.txtContact.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(8, 232);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(200, 50);
            this.txtEmail.TabIndex = 33;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtSurname
            // 
            this.txtSurname.AnimateReadOnly = false;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Depth = 0;
            this.txtSurname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSurname.LeadingIcon = null;
            this.txtSurname.Location = new System.Drawing.Point(8, 136);
            this.txtSurname.MaxLength = 50;
            this.txtSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(200, 50);
            this.txtSurname.TabIndex = 32;
            this.txtSurname.Text = "";
            this.txtSurname.TrailingIcon = null;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(8, 40);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 50);
            this.txtName.TabIndex = 31;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblProcedure);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtProcedure);
            this.panel2.Location = new System.Drawing.Point(248, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 200);
            this.panel2.TabIndex = 32;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Depth = 0;
            this.lblPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblPrice.Location = new System.Drawing.Point(8, 104);
            this.lblPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 24);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Price";
            // 
            // lblProcedure
            // 
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Depth = 0;
            this.lblProcedure.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblProcedure.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblProcedure.Location = new System.Drawing.Point(8, 8);
            this.lblProcedure.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(93, 24);
            this.lblProcedure.TabIndex = 41;
            this.lblProcedure.Text = "Procedure";
            // 
            // txtPrice
            // 
            this.txtPrice.AnimateReadOnly = false;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Depth = 0;
            this.txtPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.LeadingIcon = null;
            this.txtPrice.Location = new System.Drawing.Point(8, 136);
            this.txtPrice.MaxLength = 50;
            this.txtPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(232, 50);
            this.txtPrice.TabIndex = 33;
            this.txtPrice.Text = "";
            this.txtPrice.TrailingIcon = null;
            // 
            // txtProcedure
            // 
            this.txtProcedure.AnimateReadOnly = false;
            this.txtProcedure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcedure.Depth = 0;
            this.txtProcedure.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProcedure.LeadingIcon = null;
            this.txtProcedure.Location = new System.Drawing.Point(8, 40);
            this.txtProcedure.MaxLength = 50;
            this.txtProcedure.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProcedure.Multiline = false;
            this.txtProcedure.Name = "txtProcedure";
            this.txtProcedure.ReadOnly = true;
            this.txtProcedure.Size = new System.Drawing.Size(232, 50);
            this.txtProcedure.TabIndex = 32;
            this.txtProcedure.Text = "";
            this.txtProcedure.TrailingIcon = null;
            // 
            // picAvatar
            // 
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvatar.Location = new System.Drawing.Point(248, 280);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(256, 280);
            this.picAvatar.TabIndex = 33;
            this.picAvatar.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblEmail.Location = new System.Drawing.Point(8, 200);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 24);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "Email address";
            // 
            // frmViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 570);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 570);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 570);
            this.Name = "frmViewDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View appointment\'s details";
            this.Load += new System.EventHandler(this.frmViewDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtEmergencyContact;
        private MaterialSkin.Controls.MaterialTextBox txtContact;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtSurname;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox txtPrice;
        private MaterialSkin.Controls.MaterialTextBox txtProcedure;
        private System.Windows.Forms.PictureBox picAvatar;
        private MaterialSkin.Controls.MaterialLabel lblEmergencyContact;
        private MaterialSkin.Controls.MaterialLabel lblContact;
        private MaterialSkin.Controls.MaterialLabel lblSurname;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblProcedure;
        private MaterialSkin.Controls.MaterialLabel lblPrice;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
    }
}