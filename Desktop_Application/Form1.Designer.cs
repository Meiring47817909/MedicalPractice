namespace Desktop_Application
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLoginDetails = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAdministratorID = new MaterialSkin.Controls.MaterialTextBox();
            this.erpLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogin.Controls.Add(this.lblLoginDetails);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtAdministratorID);
            this.pnlLogin.Location = new System.Drawing.Point(555, 305);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(244, 265);
            this.pnlLogin.TabIndex = 4;
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.AutoSize = true;
            this.lblLoginDetails.Depth = 0;
            this.lblLoginDetails.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoginDetails.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblLoginDetails.Location = new System.Drawing.Point(11, 10);
            this.lblLoginDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoginDetails.Name = "lblLoginDetails";
            this.lblLoginDetails.Size = new System.Drawing.Size(161, 24);
            this.lblLoginDetails.TabIndex = 39;
            this.lblLoginDetails.Text = "Enter login details";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(11, 207);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(203, 44);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Password";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(11, 128);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(203, 50);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtAdministratorID
            // 
            this.txtAdministratorID.AnimateReadOnly = false;
            this.txtAdministratorID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdministratorID.Depth = 0;
            this.txtAdministratorID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdministratorID.Hint = "Administrator ID";
            this.txtAdministratorID.LeadingIcon = null;
            this.txtAdministratorID.Location = new System.Drawing.Point(11, 49);
            this.txtAdministratorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdministratorID.MaxLength = 10;
            this.txtAdministratorID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdministratorID.Multiline = false;
            this.txtAdministratorID.Name = "txtAdministratorID";
            this.txtAdministratorID.Size = new System.Drawing.Size(203, 50);
            this.txtAdministratorID.TabIndex = 0;
            this.txtAdministratorID.Text = "";
            this.txtAdministratorID.TrailingIcon = null;
            this.txtAdministratorID.TextChanged += new System.EventHandler(this.txtAdministratorID_TextChanged);
            // 
            // erpLogin
            // 
            this.erpLogin.ContainerControl = this;
            // 
            // picBackground
            // 
            this.picBackground.BackgroundImage = global::Desktop_Application.Properties.Resources.Login_Administrator;
            this.picBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Location = new System.Drawing.Point(4, 79);
            this.picBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1363, 765);
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            this.picBackground.Resize += new System.EventHandler(this.picBackground_Resize);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1371, 848);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.picBackground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login administrator";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Panel pnlLogin;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtAdministratorID;
        private System.Windows.Forms.ErrorProvider erpLogin;
        private MaterialSkin.Controls.MaterialLabel lblLoginDetails;
    }
}

