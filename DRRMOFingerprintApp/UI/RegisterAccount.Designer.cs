namespace DRRMOFingerprintApp.UI
{
    partial class RegisterAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAccount));
            this.gbPhoto = new System.Windows.Forms.GroupBox();
            this.btnBrowsePhotos = new System.Windows.Forms.Button();
            this.pctrBoxPhotos = new System.Windows.Forms.PictureBox();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRegisterAccount = new System.Windows.Forms.Label();
            this.errorProviderRegisterAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPhotos)).BeginInit();
            this.gbAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegisterAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPhoto
            // 
            this.gbPhoto.Controls.Add(this.btnBrowsePhotos);
            this.gbPhoto.Controls.Add(this.pctrBoxPhotos);
            this.gbPhoto.Location = new System.Drawing.Point(12, 229);
            this.gbPhoto.Name = "gbPhoto";
            this.gbPhoto.Size = new System.Drawing.Size(387, 129);
            this.gbPhoto.TabIndex = 1;
            this.gbPhoto.TabStop = false;
            this.gbPhoto.Text = "PHOTOS";
            // 
            // btnBrowsePhotos
            // 
            this.btnBrowsePhotos.BackColor = System.Drawing.Color.Peru;
            this.btnBrowsePhotos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowsePhotos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowsePhotos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBrowsePhotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBrowsePhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowsePhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePhotos.ForeColor = System.Drawing.Color.White;
            this.btnBrowsePhotos.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowsePhotos.Image")));
            this.btnBrowsePhotos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowsePhotos.Location = new System.Drawing.Point(168, 63);
            this.btnBrowsePhotos.Name = "btnBrowsePhotos";
            this.btnBrowsePhotos.Size = new System.Drawing.Size(176, 60);
            this.btnBrowsePhotos.TabIndex = 0;
            this.btnBrowsePhotos.Text = "     Bro&wse Photos";
            this.btnBrowsePhotos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowsePhotos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowsePhotos.UseVisualStyleBackColor = false;
            this.btnBrowsePhotos.Click += new System.EventHandler(this.btnBrowsePhotos_Click);
            // 
            // pctrBoxPhotos
            // 
            this.pctrBoxPhotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrBoxPhotos.Location = new System.Drawing.Point(6, 19);
            this.pctrBoxPhotos.Name = "pctrBoxPhotos";
            this.pctrBoxPhotos.Size = new System.Drawing.Size(134, 104);
            this.pctrBoxPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxPhotos.TabIndex = 0;
            this.pctrBoxPhotos.TabStop = false;
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.txtPassword);
            this.gbAccount.Controls.Add(this.lblPassword);
            this.gbAccount.Controls.Add(this.txtUsername);
            this.gbAccount.Controls.Add(this.lblUsername);
            this.gbAccount.Controls.Add(this.txtLastName);
            this.gbAccount.Controls.Add(this.lblLastName);
            this.gbAccount.Controls.Add(this.txtFirstName);
            this.gbAccount.Controls.Add(this.lblFirstName);
            this.gbAccount.ForeColor = System.Drawing.Color.Black;
            this.gbAccount.Location = new System.Drawing.Point(12, 49);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(388, 174);
            this.gbAccount.TabIndex = 0;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "ACCOUNT INFORMATION";
            // 
            // txtPassword
            // 
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Location = new System.Drawing.Point(84, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(233, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(22, 147);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsername.Location = new System.Drawing.Point(84, 101);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(233, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 108);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "Username:";
            // 
            // txtLastName
            // 
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.Location = new System.Drawing.Point(84, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(233, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(17, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFirstName.Location = new System.Drawing.Point(84, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(233, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(12, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(388, 68);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "   &Save Account";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRegisterAccount
            // 
            this.lblRegisterAccount.AutoSize = true;
            this.lblRegisterAccount.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRegisterAccount.Location = new System.Drawing.Point(13, 9);
            this.lblRegisterAccount.Name = "lblRegisterAccount";
            this.lblRegisterAccount.Size = new System.Drawing.Size(355, 25);
            this.lblRegisterAccount.TabIndex = 15;
            this.lblRegisterAccount.Text = "Register Account --------------------";
            // 
            // errorProviderRegisterAccount
            // 
            this.errorProviderRegisterAccount.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(360, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 45);
            this.btnExit.TabIndex = 16;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(12, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 67);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = " &UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.Location = new System.Drawing.Point(224, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 67);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = " &DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // RegisterAccount
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(412, 446);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRegisterAccount);
            this.Controls.Add(this.gbPhoto);
            this.Controls.Add(this.gbAccount);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Account";
            this.gbPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPhotos)).EndInit();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegisterAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPhoto;
        private System.Windows.Forms.Button btnBrowsePhotos;
        public System.Windows.Forms.PictureBox pctrBoxPhotos;
        private System.Windows.Forms.GroupBox gbAccount;
        public System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblRegisterAccount;
        public System.Windows.Forms.ErrorProvider errorProviderRegisterAccount;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
    }
}