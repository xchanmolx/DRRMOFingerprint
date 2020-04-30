namespace DRRMOFingerprintApp.UI
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegisterAccount = new System.Windows.Forms.Button();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterAccount
            // 
            this.btnRegisterAccount.BackColor = System.Drawing.Color.Olive;
            this.btnRegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegisterAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRegisterAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegisterAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterAccount.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAccount.ForeColor = System.Drawing.Color.White;
            this.btnRegisterAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterAccount.Image")));
            this.btnRegisterAccount.Location = new System.Drawing.Point(12, 12);
            this.btnRegisterAccount.Name = "btnRegisterAccount";
            this.btnRegisterAccount.Size = new System.Drawing.Size(63, 61);
            this.btnRegisterAccount.TabIndex = 5;
            this.btnRegisterAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterAccount.UseVisualStyleBackColor = false;
            this.btnRegisterAccount.Click += new System.EventHandler(this.btnRegisterAccount_Click);
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Condensed Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPeople.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPeople.EnableHeadersVisualStyles = false;
            this.dgvPeople.Location = new System.Drawing.Point(12, 352);
            this.dgvPeople.Name = "dgvPeople";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvPeople.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPeople.Size = new System.Drawing.Size(844, 258);
            this.dgvPeople.TabIndex = 7;
            this.dgvPeople.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeople_RowHeaderMouseClick);
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
            this.btnExit.Location = new System.Drawing.Point(1297, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 45);
            this.btnExit.TabIndex = 12;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.btnRegisterAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegisterAccount;
        public System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Button btnExit;
    }
}