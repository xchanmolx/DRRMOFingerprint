﻿namespace DRRMOFingerprintApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pctrBoxSettings = new System.Windows.Forms.PictureBox();
            this.pctrBoxProfile = new System.Windows.Forms.PictureBox();
            this.btnVerification = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnUpdatePersonRows = new System.Windows.Forms.Button();
            this.lblPersonRows = new System.Windows.Forms.Label();
            this.lblAsOf = new System.Windows.Forms.Label();
            this.gbDRRMODataRecords = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegistrationForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxProfile)).BeginInit();
            this.gbDRRMODataRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto Condensed", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblName.Location = new System.Drawing.Point(118, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 16);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "?";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto Condensed", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Crimson;
            this.lblWelcome.Location = new System.Drawing.Point(71, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(49, 16);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctrBoxSettings
            // 
            this.pctrBoxSettings.BackColor = System.Drawing.SystemColors.Control;
            this.pctrBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxSettings.Image")));
            this.pctrBoxSettings.Location = new System.Drawing.Point(353, 3);
            this.pctrBoxSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctrBoxSettings.Name = "pctrBoxSettings";
            this.pctrBoxSettings.Size = new System.Drawing.Size(50, 38);
            this.pctrBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxSettings.TabIndex = 17;
            this.pctrBoxSettings.TabStop = false;
            this.pctrBoxSettings.Tag = "";
            this.pctrBoxSettings.Click += new System.EventHandler(this.pctrBoxSettings_Click);
            // 
            // pctrBoxProfile
            // 
            this.pctrBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrBoxProfile.Location = new System.Drawing.Point(13, 3);
            this.pctrBoxProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctrBoxProfile.Name = "pctrBoxProfile";
            this.pctrBoxProfile.Size = new System.Drawing.Size(50, 38);
            this.pctrBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxProfile.TabIndex = 5;
            this.pctrBoxProfile.TabStop = false;
            // 
            // btnVerification
            // 
            this.btnVerification.BackColor = System.Drawing.Color.Purple;
            this.btnVerification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnVerification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerification.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerification.ForeColor = System.Drawing.Color.White;
            this.btnVerification.Image = ((System.Drawing.Image)(resources.GetObject("btnVerification.Image")));
            this.btnVerification.Location = new System.Drawing.Point(242, 347);
            this.btnVerification.Name = "btnVerification";
            this.btnVerification.Size = new System.Drawing.Size(206, 81);
            this.btnVerification.TabIndex = 1;
            this.btnVerification.Text = "&Verification";
            this.btnVerification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerification.UseVisualStyleBackColor = false;
            this.btnVerification.Click += new System.EventHandler(this.btnVerification_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistration.Image")));
            this.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.Location = new System.Drawing.Point(12, 347);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(221, 81);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "&Registration";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdatePersonRows
            // 
            this.btnUpdatePersonRows.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdatePersonRows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePersonRows.FlatAppearance.BorderSize = 0;
            this.btnUpdatePersonRows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnUpdatePersonRows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnUpdatePersonRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePersonRows.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdatePersonRows.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePersonRows.Image")));
            this.btnUpdatePersonRows.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatePersonRows.Location = new System.Drawing.Point(50, 95);
            this.btnUpdatePersonRows.Name = "btnUpdatePersonRows";
            this.btnUpdatePersonRows.Size = new System.Drawing.Size(45, 41);
            this.btnUpdatePersonRows.TabIndex = 21;
            this.btnUpdatePersonRows.Text = "&u";
            this.btnUpdatePersonRows.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatePersonRows.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUpdatePersonRows.UseVisualStyleBackColor = false;
            this.btnUpdatePersonRows.Click += new System.EventHandler(this.btnUpdatePersonRows_Click);
            // 
            // lblPersonRows
            // 
            this.lblPersonRows.AutoSize = true;
            this.lblPersonRows.Font = new System.Drawing.Font("Roboto Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonRows.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPersonRows.Location = new System.Drawing.Point(179, 19);
            this.lblPersonRows.Name = "lblPersonRows";
            this.lblPersonRows.Size = new System.Drawing.Size(47, 58);
            this.lblPersonRows.TabIndex = 20;
            this.lblPersonRows.Text = "?";
            // 
            // lblAsOf
            // 
            this.lblAsOf.AutoSize = true;
            this.lblAsOf.BackColor = System.Drawing.Color.Transparent;
            this.lblAsOf.Font = new System.Drawing.Font("Roboto Condensed", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsOf.ForeColor = System.Drawing.Color.Orange;
            this.lblAsOf.Location = new System.Drawing.Point(44, 84);
            this.lblAsOf.Name = "lblAsOf";
            this.lblAsOf.Size = new System.Drawing.Size(63, 33);
            this.lblAsOf.TabIndex = 22;
            this.lblAsOf.Text = "as of";
            // 
            // gbDRRMODataRecords
            // 
            this.gbDRRMODataRecords.Controls.Add(this.lblDate);
            this.gbDRRMODataRecords.Controls.Add(this.lblAsOf);
            this.gbDRRMODataRecords.Controls.Add(this.lblPersonRows);
            this.gbDRRMODataRecords.Controls.Add(this.btnUpdatePersonRows);
            this.gbDRRMODataRecords.Location = new System.Drawing.Point(13, 150);
            this.gbDRRMODataRecords.Name = "gbDRRMODataRecords";
            this.gbDRRMODataRecords.Size = new System.Drawing.Size(435, 142);
            this.gbDRRMODataRecords.TabIndex = 20;
            this.gbDRRMODataRecords.TabStop = false;
            this.gbDRRMODataRecords.Text = "DRRMO DATA RECORDS";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Roboto Condensed", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Orange;
            this.lblDate.Location = new System.Drawing.Point(113, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(25, 33);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "?";
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
            this.btnExit.Location = new System.Drawing.Point(410, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 45);
            this.btnExit.TabIndex = 24;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegistrationForm
            // 
            this.btnRegistrationForm.BackColor = System.Drawing.Color.MediumBlue;
            this.btnRegistrationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrationForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrationForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRegistrationForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegistrationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrationForm.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrationForm.ForeColor = System.Drawing.Color.White;
            this.btnRegistrationForm.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrationForm.Image")));
            this.btnRegistrationForm.Location = new System.Drawing.Point(12, 298);
            this.btnRegistrationForm.Name = "btnRegistrationForm";
            this.btnRegistrationForm.Size = new System.Drawing.Size(436, 43);
            this.btnRegistrationForm.TabIndex = 25;
            this.btnRegistrationForm.Text = "Registration &Form";
            this.btnRegistrationForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrationForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrationForm.UseVisualStyleBackColor = false;
            this.btnRegistrationForm.Click += new System.EventHandler(this.btnRegistrationForm_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnRegistration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(461, 440);
            this.Controls.Add(this.btnRegistrationForm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDRRMODataRecords);
            this.Controls.Add(this.pctrBoxSettings);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pctrBoxProfile);
            this.Controls.Add(this.btnVerification);
            this.Controls.Add(this.btnRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRRMO Aloguinsan | Biometrics Data";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxProfile)).EndInit();
            this.gbDRRMODataRecords.ResumeLayout(false);
            this.gbDRRMODataRecords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnVerification;
        public System.Windows.Forms.PictureBox pctrBoxProfile;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.PictureBox pctrBoxSettings;
        private System.Windows.Forms.Button btnUpdatePersonRows;
        private System.Windows.Forms.Label lblPersonRows;
        private System.Windows.Forms.Label lblAsOf;
        private System.Windows.Forms.GroupBox gbDRRMODataRecords;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegistrationForm;
    }
}

