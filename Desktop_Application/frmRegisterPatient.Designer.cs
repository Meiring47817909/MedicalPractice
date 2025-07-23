namespace Desktop_Application
{
    partial class frmRegisterPatient
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
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblContact = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmergencyContact = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblSurname = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.mtxtEmergencyContact = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mtxtContact = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mtxtEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mtxtSurname = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mtxtName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pnlAllergies = new System.Windows.Forms.Panel();
            this.lblAllergy = new MaterialSkin.Controls.MaterialLabel();
            this.mtxtAllergy = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.lstAllergies = new System.Windows.Forms.ListBox();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.erpRegister = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDetails.SuspendLayout();
            this.pnlAllergies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetails.Controls.Add(this.lblContact);
            this.pnlDetails.Controls.Add(this.lblEmergencyContact);
            this.pnlDetails.Controls.Add(this.lblEmail);
            this.pnlDetails.Controls.Add(this.lblSurname);
            this.pnlDetails.Controls.Add(this.lblName);
            this.pnlDetails.Controls.Add(this.mtxtEmergencyContact);
            this.pnlDetails.Controls.Add(this.mtxtContact);
            this.pnlDetails.Controls.Add(this.mtxtEmail);
            this.pnlDetails.Controls.Add(this.mtxtSurname);
            this.pnlDetails.Controls.Add(this.mtxtName);
            this.pnlDetails.Location = new System.Drawing.Point(8, 72);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(384, 272);
            this.pnlDetails.TabIndex = 17;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Depth = 0;
            this.lblContact.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblContact.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblContact.Location = new System.Drawing.Point(200, 8);
            this.lblContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(144, 24);
            this.lblContact.TabIndex = 42;
            this.lblContact.Text = "Contact number";
            // 
            // lblEmergencyContact
            // 
            this.lblEmergencyContact.AutoSize = true;
            this.lblEmergencyContact.Depth = 0;
            this.lblEmergencyContact.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmergencyContact.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblEmergencyContact.Location = new System.Drawing.Point(200, 96);
            this.lblEmergencyContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmergencyContact.Name = "lblEmergencyContact";
            this.lblEmergencyContact.Size = new System.Drawing.Size(172, 24);
            this.lblEmergencyContact.TabIndex = 41;
            this.lblEmergencyContact.Text = "Emergency contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblEmail.Location = new System.Drawing.Point(8, 184);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 24);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email address";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Depth = 0;
            this.lblSurname.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSurname.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblSurname.Location = new System.Drawing.Point(8, 96);
            this.lblSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 24);
            this.lblSurname.TabIndex = 38;
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
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Name";
            // 
            // mtxtEmergencyContact
            // 
            this.mtxtEmergencyContact.AllowPromptAsInput = false;
            this.mtxtEmergencyContact.AnimateReadOnly = false;
            this.mtxtEmergencyContact.AsciiOnly = false;
            this.mtxtEmergencyContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtEmergencyContact.BeepOnError = false;
            this.mtxtEmergencyContact.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtEmergencyContact.Depth = 0;
            this.mtxtEmergencyContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtEmergencyContact.HidePromptOnLeave = false;
            this.mtxtEmergencyContact.HideSelection = true;
            this.mtxtEmergencyContact.Hint = "Enter contact";
            this.mtxtEmergencyContact.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtEmergencyContact.LeadingIcon = null;
            this.mtxtEmergencyContact.Location = new System.Drawing.Point(200, 128);
            this.mtxtEmergencyContact.Mask = "0000000000";
            this.mtxtEmergencyContact.MaxLength = 32767;
            this.mtxtEmergencyContact.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtEmergencyContact.Name = "mtxtEmergencyContact";
            this.mtxtEmergencyContact.PasswordChar = '\0';
            this.mtxtEmergencyContact.PrefixSuffixText = null;
            this.mtxtEmergencyContact.PromptChar = ' ';
            this.mtxtEmergencyContact.ReadOnly = false;
            this.mtxtEmergencyContact.RejectInputOnFirstFailure = false;
            this.mtxtEmergencyContact.ResetOnPrompt = false;
            this.mtxtEmergencyContact.ResetOnSpace = false;
            this.mtxtEmergencyContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtEmergencyContact.SelectedText = "";
            this.mtxtEmergencyContact.SelectionLength = 0;
            this.mtxtEmergencyContact.SelectionStart = 0;
            this.mtxtEmergencyContact.ShortcutsEnabled = true;
            this.mtxtEmergencyContact.Size = new System.Drawing.Size(160, 48);
            this.mtxtEmergencyContact.SkipLiterals = true;
            this.mtxtEmergencyContact.TabIndex = 25;
            this.mtxtEmergencyContact.TabStop = false;
            this.mtxtEmergencyContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtEmergencyContact.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtEmergencyContact.TrailingIcon = null;
            this.mtxtEmergencyContact.UseSystemPasswordChar = false;
            this.mtxtEmergencyContact.ValidatingType = null;
            this.mtxtEmergencyContact.Click += new System.EventHandler(this.MaskInput_Click);
            this.mtxtEmergencyContact.TextChanged += new System.EventHandler(this.mtxtEmergencyContact_TextChanged);
            // 
            // mtxtContact
            // 
            this.mtxtContact.AllowPromptAsInput = false;
            this.mtxtContact.AnimateReadOnly = false;
            this.mtxtContact.AsciiOnly = false;
            this.mtxtContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtContact.BeepOnError = false;
            this.mtxtContact.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtContact.Depth = 0;
            this.mtxtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtContact.HidePromptOnLeave = false;
            this.mtxtContact.HideSelection = true;
            this.mtxtContact.Hint = "Enter contact";
            this.mtxtContact.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtContact.LeadingIcon = null;
            this.mtxtContact.Location = new System.Drawing.Point(200, 40);
            this.mtxtContact.Mask = "0000000000";
            this.mtxtContact.MaxLength = 32767;
            this.mtxtContact.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtContact.Name = "mtxtContact";
            this.mtxtContact.PasswordChar = '\0';
            this.mtxtContact.PrefixSuffixText = null;
            this.mtxtContact.PromptChar = ' ';
            this.mtxtContact.ReadOnly = false;
            this.mtxtContact.RejectInputOnFirstFailure = false;
            this.mtxtContact.ResetOnPrompt = false;
            this.mtxtContact.ResetOnSpace = false;
            this.mtxtContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtContact.SelectedText = "";
            this.mtxtContact.SelectionLength = 0;
            this.mtxtContact.SelectionStart = 0;
            this.mtxtContact.ShortcutsEnabled = true;
            this.mtxtContact.Size = new System.Drawing.Size(160, 48);
            this.mtxtContact.SkipLiterals = true;
            this.mtxtContact.TabIndex = 24;
            this.mtxtContact.TabStop = false;
            this.mtxtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtContact.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtContact.TrailingIcon = null;
            this.mtxtContact.UseSystemPasswordChar = false;
            this.mtxtContact.ValidatingType = null;
            this.mtxtContact.Click += new System.EventHandler(this.MaskInput_Click);
            this.mtxtContact.TextChanged += new System.EventHandler(this.mtxtContact_TextChanged);
            // 
            // mtxtEmail
            // 
            this.mtxtEmail.AllowPromptAsInput = false;
            this.mtxtEmail.AnimateReadOnly = false;
            this.mtxtEmail.AsciiOnly = false;
            this.mtxtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtEmail.BeepOnError = false;
            this.mtxtEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtEmail.Depth = 0;
            this.mtxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtEmail.HidePromptOnLeave = false;
            this.mtxtEmail.HideSelection = true;
            this.mtxtEmail.Hint = "Enter email address";
            this.mtxtEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtEmail.LeadingIcon = null;
            this.mtxtEmail.Location = new System.Drawing.Point(8, 216);
            this.mtxtEmail.Mask = "&&&&&&&&&&&&&&&&&&&&";
            this.mtxtEmail.MaxLength = 32767;
            this.mtxtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.PasswordChar = '\0';
            this.mtxtEmail.PrefixSuffixText = null;
            this.mtxtEmail.PromptChar = ' ';
            this.mtxtEmail.ReadOnly = false;
            this.mtxtEmail.RejectInputOnFirstFailure = false;
            this.mtxtEmail.ResetOnPrompt = false;
            this.mtxtEmail.ResetOnSpace = false;
            this.mtxtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtEmail.SelectedText = "";
            this.mtxtEmail.SelectionLength = 0;
            this.mtxtEmail.SelectionStart = 0;
            this.mtxtEmail.ShortcutsEnabled = true;
            this.mtxtEmail.Size = new System.Drawing.Size(160, 48);
            this.mtxtEmail.SkipLiterals = true;
            this.mtxtEmail.TabIndex = 23;
            this.mtxtEmail.TabStop = false;
            this.mtxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtEmail.TrailingIcon = null;
            this.mtxtEmail.UseSystemPasswordChar = false;
            this.mtxtEmail.ValidatingType = null;
            this.mtxtEmail.Click += new System.EventHandler(this.MaskInput_Click);
            this.mtxtEmail.TextChanged += new System.EventHandler(this.mtxtEmail_TextChanged);
            // 
            // mtxtSurname
            // 
            this.mtxtSurname.AllowPromptAsInput = true;
            this.mtxtSurname.AnimateReadOnly = false;
            this.mtxtSurname.AsciiOnly = false;
            this.mtxtSurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtSurname.BeepOnError = false;
            this.mtxtSurname.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSurname.Depth = 0;
            this.mtxtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtSurname.HidePromptOnLeave = false;
            this.mtxtSurname.HideSelection = true;
            this.mtxtSurname.Hint = "Enter surname";
            this.mtxtSurname.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtSurname.LeadingIcon = null;
            this.mtxtSurname.Location = new System.Drawing.Point(8, 128);
            this.mtxtSurname.Mask = "L???????????????????";
            this.mtxtSurname.MaxLength = 32767;
            this.mtxtSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtSurname.Name = "mtxtSurname";
            this.mtxtSurname.PasswordChar = '\0';
            this.mtxtSurname.PrefixSuffixText = null;
            this.mtxtSurname.PromptChar = ' ';
            this.mtxtSurname.ReadOnly = false;
            this.mtxtSurname.RejectInputOnFirstFailure = false;
            this.mtxtSurname.ResetOnPrompt = false;
            this.mtxtSurname.ResetOnSpace = false;
            this.mtxtSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtSurname.SelectedText = "";
            this.mtxtSurname.SelectionLength = 0;
            this.mtxtSurname.SelectionStart = 0;
            this.mtxtSurname.ShortcutsEnabled = true;
            this.mtxtSurname.Size = new System.Drawing.Size(160, 48);
            this.mtxtSurname.SkipLiterals = true;
            this.mtxtSurname.TabIndex = 22;
            this.mtxtSurname.TabStop = false;
            this.mtxtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtSurname.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSurname.TrailingIcon = null;
            this.mtxtSurname.UseSystemPasswordChar = false;
            this.mtxtSurname.ValidatingType = null;
            this.mtxtSurname.Click += new System.EventHandler(this.MaskInput_Click);
            this.mtxtSurname.TextChanged += new System.EventHandler(this.mtxtSurname_TextChanged);
            // 
            // mtxtName
            // 
            this.mtxtName.AllowPromptAsInput = true;
            this.mtxtName.AnimateReadOnly = false;
            this.mtxtName.AsciiOnly = false;
            this.mtxtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtName.BeepOnError = false;
            this.mtxtName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtName.Depth = 0;
            this.mtxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtName.HidePromptOnLeave = false;
            this.mtxtName.HideSelection = true;
            this.mtxtName.Hint = "Enter name";
            this.mtxtName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtName.LeadingIcon = null;
            this.mtxtName.Location = new System.Drawing.Point(8, 40);
            this.mtxtName.Mask = "L???????????????????";
            this.mtxtName.MaxLength = 32767;
            this.mtxtName.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtName.Name = "mtxtName";
            this.mtxtName.PasswordChar = '\0';
            this.mtxtName.PrefixSuffixText = null;
            this.mtxtName.PromptChar = ' ';
            this.mtxtName.ReadOnly = false;
            this.mtxtName.RejectInputOnFirstFailure = false;
            this.mtxtName.ResetOnPrompt = false;
            this.mtxtName.ResetOnSpace = false;
            this.mtxtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtName.SelectedText = "";
            this.mtxtName.SelectionLength = 0;
            this.mtxtName.SelectionStart = 0;
            this.mtxtName.ShortcutsEnabled = true;
            this.mtxtName.Size = new System.Drawing.Size(160, 48);
            this.mtxtName.SkipLiterals = true;
            this.mtxtName.TabIndex = 21;
            this.mtxtName.TabStop = false;
            this.mtxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtName.TrailingIcon = null;
            this.mtxtName.UseSystemPasswordChar = false;
            this.mtxtName.ValidatingType = null;
            this.mtxtName.Click += new System.EventHandler(this.MaskInput_Click);
            this.mtxtName.TextChanged += new System.EventHandler(this.mtxtName_TextChanged);
            // 
            // pnlAllergies
            // 
            this.pnlAllergies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAllergies.Controls.Add(this.lblAllergy);
            this.pnlAllergies.Controls.Add(this.mtxtAllergy);
            this.pnlAllergies.Controls.Add(this.btnAdd);
            this.pnlAllergies.Controls.Add(this.lstAllergies);
            this.pnlAllergies.Location = new System.Drawing.Point(8, 352);
            this.pnlAllergies.Name = "pnlAllergies";
            this.pnlAllergies.Size = new System.Drawing.Size(384, 216);
            this.pnlAllergies.TabIndex = 18;
            // 
            // lblAllergy
            // 
            this.lblAllergy.AutoSize = true;
            this.lblAllergy.Depth = 0;
            this.lblAllergy.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAllergy.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblAllergy.Location = new System.Drawing.Point(8, 8);
            this.lblAllergy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAllergy.Name = "lblAllergy";
            this.lblAllergy.Size = new System.Drawing.Size(63, 24);
            this.lblAllergy.TabIndex = 39;
            this.lblAllergy.Text = "Allergy";
            // 
            // mtxtAllergy
            // 
            this.mtxtAllergy.AllowPromptAsInput = true;
            this.mtxtAllergy.AnimateReadOnly = false;
            this.mtxtAllergy.AsciiOnly = false;
            this.mtxtAllergy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtAllergy.BeepOnError = false;
            this.mtxtAllergy.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtAllergy.Depth = 0;
            this.mtxtAllergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtAllergy.HidePromptOnLeave = false;
            this.mtxtAllergy.HideSelection = true;
            this.mtxtAllergy.Hint = "Enter allergy";
            this.mtxtAllergy.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtAllergy.LeadingIcon = null;
            this.mtxtAllergy.Location = new System.Drawing.Point(8, 40);
            this.mtxtAllergy.Mask = "L???????????????????";
            this.mtxtAllergy.MaxLength = 32767;
            this.mtxtAllergy.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtAllergy.Name = "mtxtAllergy";
            this.mtxtAllergy.PasswordChar = '\0';
            this.mtxtAllergy.PrefixSuffixText = null;
            this.mtxtAllergy.PromptChar = ' ';
            this.mtxtAllergy.ReadOnly = false;
            this.mtxtAllergy.RejectInputOnFirstFailure = false;
            this.mtxtAllergy.ResetOnPrompt = false;
            this.mtxtAllergy.ResetOnSpace = false;
            this.mtxtAllergy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtAllergy.SelectedText = "";
            this.mtxtAllergy.SelectionLength = 0;
            this.mtxtAllergy.SelectionStart = 0;
            this.mtxtAllergy.ShortcutsEnabled = true;
            this.mtxtAllergy.Size = new System.Drawing.Size(160, 48);
            this.mtxtAllergy.SkipLiterals = true;
            this.mtxtAllergy.TabIndex = 25;
            this.mtxtAllergy.TabStop = false;
            this.mtxtAllergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtAllergy.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtAllergy.TrailingIcon = null;
            this.mtxtAllergy.UseSystemPasswordChar = false;
            this.mtxtAllergy.ValidatingType = null;
            this.mtxtAllergy.Click += new System.EventHandler(this.MaskInput_Click);
            this.mtxtAllergy.TextChanged += new System.EventHandler(this.mtxtAllergy_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(200, 40);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(80, 48);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstAllergies
            // 
            this.lstAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllergies.FormattingEnabled = true;
            this.lstAllergies.ItemHeight = 24;
            this.lstAllergies.Location = new System.Drawing.Point(8, 96);
            this.lstAllergies.Name = "lstAllergies";
            this.lstAllergies.ScrollAlwaysVisible = true;
            this.lstAllergies.Size = new System.Drawing.Size(272, 100);
            this.lstAllergies.TabIndex = 18;
            this.lstAllergies.SelectedIndexChanged += new System.EventHandler(this.lstAllergies_SelectedIndexChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = false;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(8, 576);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(120, 36);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // erpRegister
            // 
            this.erpRegister.ContainerControl = this;
            // 
            // frmRegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 622);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pnlAllergies);
            this.Controls.Add(this.pnlDetails);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 622);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 622);
            this.Name = "frmRegisterPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register a patient";
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlAllergies.ResumeLayout(false);
            this.pnlAllergies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlAllergies;
        private System.Windows.Forms.ListBox lstAllergies;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtName;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtSurname;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtEmergencyContact;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtContact;
        private System.Windows.Forms.ErrorProvider erpRegister;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtAllergy;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblSurname;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblContact;
        private MaterialSkin.Controls.MaterialLabel lblEmergencyContact;
        private MaterialSkin.Controls.MaterialLabel lblAllergy;
    }
}