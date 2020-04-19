namespace DRRMOFingerprintApp
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
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnVerification = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.pbMainForm = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistration.Image")));
            this.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.Location = new System.Drawing.Point(12, 347);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(233, 81);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "&Registration";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnVerification
            // 
            this.btnVerification.BackColor = System.Drawing.Color.Purple;
            this.btnVerification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnVerification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerification.ForeColor = System.Drawing.Color.White;
            this.btnVerification.Image = ((System.Drawing.Image)(resources.GetObject("btnVerification.Image")));
            this.btnVerification.Location = new System.Drawing.Point(251, 347);
            this.btnVerification.Name = "btnVerification";
            this.btnVerification.Size = new System.Drawing.Size(213, 81);
            this.btnVerification.TabIndex = 1;
            this.btnVerification.Text = "&Verification";
            this.btnVerification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerification.UseVisualStyleBackColor = false;
            this.btnVerification.Click += new System.EventHandler(this.btnVerification_Click);
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.pbMainForm);
            this.gbMain.Location = new System.Drawing.Point(2, -15);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(660, 356);
            this.gbMain.TabIndex = 3;
            this.gbMain.TabStop = false;
            // 
            // pbMainForm
            // 
            this.pbMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainForm.Image = ((System.Drawing.Image)(resources.GetObject("pbMainForm.Image")));
            this.pbMainForm.Location = new System.Drawing.Point(3, 16);
            this.pbMainForm.Name = "pbMainForm";
            this.pbMainForm.Size = new System.Drawing.Size(654, 337);
            this.pbMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainForm.TabIndex = 3;
            this.pbMainForm.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Chocolate;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(470, 347);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 81);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 440);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.btnVerification);
            this.Controls.Add(this.btnRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRRMO Aloguinsan | Biometrics Data";
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnVerification;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.PictureBox pbMainForm;
        private System.Windows.Forms.Button btnSearch;
    }
}

