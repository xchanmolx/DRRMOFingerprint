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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegisterAccount = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.txtNext = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblSearchAttendance = new System.Windows.Forms.Label();
            this.txtSearchAttendance = new System.Windows.Forms.TextBox();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
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
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnRegisterAccount.TabIndex = 1;
            this.btnRegisterAccount.TabStop = false;
            this.btnRegisterAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterAccount.UseVisualStyleBackColor = false;
            this.btnRegisterAccount.Click += new System.EventHandler(this.btnRegisterAccount_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSearch.Location = new System.Drawing.Point(44, 87);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(203, 33);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search Account";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Roboto Condensed", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtSearch.Location = new System.Drawing.Point(43, 123);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(371, 40);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.Location = new System.Drawing.Point(43, 169);
            this.dgvAccount.Name = "dgvAccount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAccount.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccount.Size = new System.Drawing.Size(371, 90);
            this.dgvAccount.TabIndex = 3;
            this.dgvAccount.TabStop = false;
            this.dgvAccount.Visible = false;
            this.dgvAccount.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_RowHeaderMouseClick);
            // 
            // txtNext
            // 
            this.txtNext.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNext.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNext.Location = new System.Drawing.Point(648, 624);
            this.txtNext.Multiline = true;
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(73, 38);
            this.txtNext.TabIndex = 26;
            this.txtNext.TabStop = false;
            this.txtNext.Text = "10";
            this.txtNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNext.TextChanged += new System.EventHandler(this.txtNext_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(727, 624);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 38);
            this.btnNext.TabIndex = 25;
            this.btnNext.TabStop = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPrevious
            // 
            this.txtPrevious.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevious.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPrevious.Location = new System.Drawing.Point(94, 624);
            this.txtPrevious.Multiline = true;
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(73, 38);
            this.txtPrevious.TabIndex = 24;
            this.txtPrevious.TabStop = false;
            this.txtPrevious.Text = "1";
            this.txtPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrevious.TextChanged += new System.EventHandler(this.txtPrevious_TextChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(43, 624);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 38);
            this.btnPrevious.TabIndex = 23;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblSearchAttendance
            // 
            this.lblSearchAttendance.AutoSize = true;
            this.lblSearchAttendance.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAttendance.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSearchAttendance.Location = new System.Drawing.Point(44, 281);
            this.lblSearchAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchAttendance.Name = "lblSearchAttendance";
            this.lblSearchAttendance.Size = new System.Drawing.Size(240, 33);
            this.lblSearchAttendance.TabIndex = 22;
            this.lblSearchAttendance.Text = "Search Attendance";
            this.lblSearchAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchAttendance
            // 
            this.txtSearchAttendance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchAttendance.Font = new System.Drawing.Font("Roboto Condensed", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAttendance.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtSearchAttendance.Location = new System.Drawing.Point(43, 317);
            this.txtSearchAttendance.Multiline = true;
            this.txtSearchAttendance.Name = "txtSearchAttendance";
            this.txtSearchAttendance.Size = new System.Drawing.Size(729, 40);
            this.txtSearchAttendance.TabIndex = 0;
            this.txtSearchAttendance.TextChanged += new System.EventHandler(this.txtSearchAttendance_TextChanged);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Condensed Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.Location = new System.Drawing.Point(43, 363);
            this.dgvAttendance.Name = "dgvAttendance";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAttendance.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAttendance.Size = new System.Drawing.Size(729, 255);
            this.dgvAttendance.TabIndex = 21;
            this.dgvAttendance.TabStop = false;
            this.dgvAttendance.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellEndEdit);
            this.dgvAttendance.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttendance_RowHeaderMouseClick);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Salmon;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(94, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(63, 61);
            this.btnShow.TabIndex = 27;
            this.btnShow.TabStop = false;
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.LawnGreen;
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.Location = new System.Drawing.Point(94, 12);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(63, 61);
            this.btnHide.TabIndex = 28;
            this.btnHide.TabStop = false;
            this.btnHide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteAll.Location = new System.Drawing.Point(297, 624);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(110, 38);
            this.btnDeleteAll.TabIndex = 31;
            this.btnDeleteAll.Text = "&Delete All";
            this.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrint.Location = new System.Drawing.Point(425, 624);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 38);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "&Print All";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.btnRegisterAccount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.txtNext);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblSearchAttendance);
            this.Controls.Add(this.txtSearchAttendance);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegisterAccount);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegisterAccount;
        public System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.TextBox txtNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.Button btnPrevious;
        public System.Windows.Forms.Label lblSearchAttendance;
        public System.Windows.Forms.TextBox txtSearchAttendance;
        public System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnPrint;
    }
}