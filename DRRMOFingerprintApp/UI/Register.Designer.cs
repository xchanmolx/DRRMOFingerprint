namespace DRRMOFingerprintApp
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dgvLists = new System.Windows.Forms.DataGridView();
            this.gbPersonalInformation = new System.Windows.Forms.GroupBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtExtensionName = new System.Windows.Forms.TextBox();
            this.lblExtensionName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphoneNo = new System.Windows.Forms.Label();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtSitio = new System.Windows.Forms.TextBox();
            this.lblSitio = new System.Windows.Forms.Label();
            this.txtBarangay = new System.Windows.Forms.TextBox();
            this.lblBarangay = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.gbFingerprint = new System.Windows.Forms.GroupBox();
            this.txtFingerprint = new System.Windows.Forms.TextBox();
            this.lblFingerprint = new System.Windows.Forms.Label();
            this.btnBackToHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).BeginInit();
            this.gbPersonalInformation.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbFingerprint.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(12, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 78);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegister.Location = new System.Drawing.Point(201, 421);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(212, 78);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "&Register Fingerprint";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dgvLists
            // 
            this.dgvLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLists.Location = new System.Drawing.Point(12, 505);
            this.dgvLists.Name = "dgvLists";
            this.dgvLists.Size = new System.Drawing.Size(1326, 182);
            this.dgvLists.TabIndex = 6;
            // 
            // gbPersonalInformation
            // 
            this.gbPersonalInformation.Controls.Add(this.txtDateOfBirth);
            this.gbPersonalInformation.Controls.Add(this.lblDateOfBirth);
            this.gbPersonalInformation.Controls.Add(this.txtGender);
            this.gbPersonalInformation.Controls.Add(this.lblGender);
            this.gbPersonalInformation.Controls.Add(this.txtOccupation);
            this.gbPersonalInformation.Controls.Add(this.lblOccupation);
            this.gbPersonalInformation.Controls.Add(this.txtExtensionName);
            this.gbPersonalInformation.Controls.Add(this.lblExtensionName);
            this.gbPersonalInformation.Controls.Add(this.txtLastName);
            this.gbPersonalInformation.Controls.Add(this.lblLastName);
            this.gbPersonalInformation.Controls.Add(this.txtMiddleName);
            this.gbPersonalInformation.Controls.Add(this.lblMiddleName);
            this.gbPersonalInformation.Controls.Add(this.txtId);
            this.gbPersonalInformation.Controls.Add(this.lblId);
            this.gbPersonalInformation.Controls.Add(this.txtFirstName);
            this.gbPersonalInformation.Controls.Add(this.lblFirstName);
            this.gbPersonalInformation.Location = new System.Drawing.Point(12, 12);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Size = new System.Drawing.Size(274, 295);
            this.gbPersonalInformation.TabIndex = 0;
            this.gbPersonalInformation.TabStop = false;
            this.gbPersonalInformation.Text = "Personal Information";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(84, 262);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(177, 20);
            this.txtDateOfBirth.TabIndex = 7;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(9, 269);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfBirth.TabIndex = 30;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(84, 225);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(177, 20);
            this.txtGender.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(33, 232);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 28;
            this.lblGender.Text = "Gender:";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(84, 190);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(177, 20);
            this.txtOccupation.TabIndex = 5;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(13, 197);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(65, 13);
            this.lblOccupation.TabIndex = 26;
            this.lblOccupation.Text = "Occupation:";
            // 
            // txtExtensionName
            // 
            this.txtExtensionName.Location = new System.Drawing.Point(84, 154);
            this.txtExtensionName.Name = "txtExtensionName";
            this.txtExtensionName.Size = new System.Drawing.Size(99, 20);
            this.txtExtensionName.TabIndex = 4;
            // 
            // lblExtensionName
            // 
            this.lblExtensionName.AutoSize = true;
            this.lblExtensionName.Location = new System.Drawing.Point(19, 161);
            this.lblExtensionName.Name = "lblExtensionName";
            this.lblExtensionName.Size = new System.Drawing.Size(59, 13);
            this.lblExtensionName.TabIndex = 24;
            this.lblExtensionName.Text = "Ext. Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(84, 118);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(177, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(17, 125);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(84, 86);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(177, 20);
            this.txtMiddleName.TabIndex = 2;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(6, 93);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(72, 13);
            this.lblMiddleName.TabIndex = 20;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(84, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(99, 20);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "ID:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(84, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(177, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 60);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "First Name:";
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.txtEmailAddress);
            this.gbContact.Controls.Add(this.lblEmailAddress);
            this.gbContact.Controls.Add(this.txtCellphone);
            this.gbContact.Controls.Add(this.lblCellphoneNo);
            this.gbContact.Location = new System.Drawing.Point(12, 313);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(401, 102);
            this.gbContact.TabIndex = 1;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Contact";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(84, 65);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(311, 20);
            this.txtEmailAddress.TabIndex = 36;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(2, 72);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblEmailAddress.TabIndex = 38;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(84, 28);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(177, 20);
            this.txtCellphone.TabIndex = 35;
            // 
            // lblCellphoneNo
            // 
            this.lblCellphoneNo.AutoSize = true;
            this.lblCellphoneNo.Location = new System.Drawing.Point(11, 35);
            this.lblCellphoneNo.Name = "lblCellphoneNo";
            this.lblCellphoneNo.Size = new System.Drawing.Size(67, 13);
            this.lblCellphoneNo.TabIndex = 37;
            this.lblCellphoneNo.Text = "Cellphone #:";
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.txtZipCode);
            this.gbAddress.Controls.Add(this.lblZipCode);
            this.gbAddress.Controls.Add(this.txtSitio);
            this.gbAddress.Controls.Add(this.lblSitio);
            this.gbAddress.Controls.Add(this.txtBarangay);
            this.gbAddress.Controls.Add(this.lblBarangay);
            this.gbAddress.Controls.Add(this.txtCountry);
            this.gbAddress.Controls.Add(this.lblCountry);
            this.gbAddress.Controls.Add(this.txtProvince);
            this.gbAddress.Controls.Add(this.lblProvince);
            this.gbAddress.Controls.Add(this.txtCity);
            this.gbAddress.Controls.Add(this.lblCity);
            this.gbAddress.Controls.Add(this.txtHomeAddress);
            this.gbAddress.Controls.Add(this.lblHomeAddress);
            this.gbAddress.Location = new System.Drawing.Point(292, 12);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(479, 295);
            this.gbAddress.TabIndex = 2;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Address";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(106, 257);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(187, 20);
            this.txtZipCode.TabIndex = 43;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(47, 264);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(53, 13);
            this.lblZipCode.TabIndex = 44;
            this.lblZipCode.Text = "Zip Code:";
            // 
            // txtSitio
            // 
            this.txtSitio.Location = new System.Drawing.Point(106, 216);
            this.txtSitio.Name = "txtSitio";
            this.txtSitio.Size = new System.Drawing.Size(187, 20);
            this.txtSitio.TabIndex = 41;
            // 
            // lblSitio
            // 
            this.lblSitio.AutoSize = true;
            this.lblSitio.Location = new System.Drawing.Point(70, 223);
            this.lblSitio.Name = "lblSitio";
            this.lblSitio.Size = new System.Drawing.Size(30, 13);
            this.lblSitio.TabIndex = 42;
            this.lblSitio.Text = "Sitio:";
            // 
            // txtBarangay
            // 
            this.txtBarangay.Location = new System.Drawing.Point(106, 175);
            this.txtBarangay.Name = "txtBarangay";
            this.txtBarangay.Size = new System.Drawing.Size(187, 20);
            this.txtBarangay.TabIndex = 39;
            // 
            // lblBarangay
            // 
            this.lblBarangay.AutoSize = true;
            this.lblBarangay.Location = new System.Drawing.Point(45, 182);
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Size = new System.Drawing.Size(55, 13);
            this.lblBarangay.TabIndex = 40;
            this.lblBarangay.Text = "Barangay:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(106, 136);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(187, 20);
            this.txtCountry.TabIndex = 37;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(54, 143);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 38;
            this.lblCountry.Text = "Country:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(106, 100);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(187, 20);
            this.txtProvince.TabIndex = 35;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(48, 107);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 36;
            this.lblProvince.Text = "Province:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(106, 64);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(187, 20);
            this.txtCity.TabIndex = 33;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(73, 71);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 34;
            this.lblCity.Text = "City:";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(106, 26);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(365, 20);
            this.txtHomeAddress.TabIndex = 31;
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(21, 33);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(79, 13);
            this.lblHomeAddress.TabIndex = 32;
            this.lblHomeAddress.Text = "Home Address:";
            // 
            // gbFingerprint
            // 
            this.gbFingerprint.Controls.Add(this.txtFingerprint);
            this.gbFingerprint.Controls.Add(this.lblFingerprint);
            this.gbFingerprint.Location = new System.Drawing.Point(419, 313);
            this.gbFingerprint.Name = "gbFingerprint";
            this.gbFingerprint.Size = new System.Drawing.Size(352, 102);
            this.gbFingerprint.TabIndex = 9;
            this.gbFingerprint.TabStop = false;
            this.gbFingerprint.Text = "Fingerprint";
            // 
            // txtFingerprint
            // 
            this.txtFingerprint.Location = new System.Drawing.Point(76, 35);
            this.txtFingerprint.Multiline = true;
            this.txtFingerprint.Name = "txtFingerprint";
            this.txtFingerprint.ReadOnly = true;
            this.txtFingerprint.Size = new System.Drawing.Size(268, 44);
            this.txtFingerprint.TabIndex = 0;
            this.txtFingerprint.TabStop = false;
            // 
            // lblFingerprint
            // 
            this.lblFingerprint.AutoSize = true;
            this.lblFingerprint.Location = new System.Drawing.Point(11, 51);
            this.lblFingerprint.Name = "lblFingerprint";
            this.lblFingerprint.Size = new System.Drawing.Size(59, 13);
            this.lblFingerprint.TabIndex = 3;
            this.lblFingerprint.Text = "Fingerprint:";
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToHome.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBackToHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBackToHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackToHome.Location = new System.Drawing.Point(1126, 12);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(212, 46);
            this.btnBackToHome.TabIndex = 5;
            this.btnBackToHome.Text = "<--- &Back to Home";
            this.btnBackToHome.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.gbFingerprint);
            this.Controls.Add(this.gbAddress);
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.gbPersonalInformation);
            this.Controls.Add(this.dgvLists);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register | Person Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).EndInit();
            this.gbPersonalInformation.ResumeLayout(false);
            this.gbPersonalInformation.PerformLayout();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbFingerprint.ResumeLayout(false);
            this.gbFingerprint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridView dgvLists;
        private System.Windows.Forms.GroupBox gbPersonalInformation;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtExtensionName;
        private System.Windows.Forms.Label lblExtensionName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphoneNo;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtSitio;
        private System.Windows.Forms.Label lblSitio;
        private System.Windows.Forms.TextBox txtBarangay;
        private System.Windows.Forms.Label lblBarangay;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.GroupBox gbFingerprint;
        private System.Windows.Forms.TextBox txtFingerprint;
        private System.Windows.Forms.Label lblFingerprint;
        private System.Windows.Forms.Button btnBackToHome;
    }
}