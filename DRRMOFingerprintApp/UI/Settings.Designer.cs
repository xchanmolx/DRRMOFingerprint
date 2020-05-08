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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.txtNext = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.lblSearchAttendance = new System.Windows.Forms.Label();
            this.txtSearchAttendance = new System.Windows.Forms.TextBox();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.lblTotalPerson = new System.Windows.Forms.Label();
            this.groupBoxPrinting = new System.Windows.Forms.GroupBox();
            this.txtHeader1 = new System.Windows.Forms.TextBox();
            this.txtHeader2 = new System.Windows.Forms.TextBox();
            this.txtHeader3 = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.lblHeader3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbPhoto = new System.Windows.Forms.GroupBox();
            this.lblHeaderImage = new System.Windows.Forms.Label();
            this.btnRegisterAccount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBrowsePhotos = new System.Windows.Forms.Button();
            this.pctrBoxPhotos = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnClearPhotos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.groupBoxPrinting.SuspendLayout();
            this.gbPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPhotos)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto Condensed Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.Location = new System.Drawing.Point(43, 169);
            this.dgvAccount.Name = "dgvAccount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAccount.RowsDefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Condensed Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.Location = new System.Drawing.Point(43, 363);
            this.dgvAttendance.Name = "dgvAttendance";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAttendance.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAttendance.Size = new System.Drawing.Size(729, 255);
            this.dgvAttendance.TabIndex = 21;
            this.dgvAttendance.TabStop = false;
            this.dgvAttendance.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellEndEdit);
            this.dgvAttendance.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttendance_RowHeaderMouseClick);
            this.dgvAttendance.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAttendance_RowsAdded);
            this.dgvAttendance.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAttendance_RowsRemoved);
            // 
            // lblTotalPerson
            // 
            this.lblTotalPerson.AutoSize = true;
            this.lblTotalPerson.Font = new System.Drawing.Font("Roboto Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPerson.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalPerson.Location = new System.Drawing.Point(337, 634);
            this.lblTotalPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPerson.Name = "lblTotalPerson";
            this.lblTotalPerson.Size = new System.Drawing.Size(15, 18);
            this.lblTotalPerson.TabIndex = 34;
            this.lblTotalPerson.Text = "?";
            this.lblTotalPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxPrinting
            // 
            this.groupBoxPrinting.Controls.Add(this.lblTitle);
            this.groupBoxPrinting.Controls.Add(this.lblHeader3);
            this.groupBoxPrinting.Controls.Add(this.lblHeader2);
            this.groupBoxPrinting.Controls.Add(this.lblHeader1);
            this.groupBoxPrinting.Controls.Add(this.txtTitle);
            this.groupBoxPrinting.Controls.Add(this.txtHeader3);
            this.groupBoxPrinting.Controls.Add(this.txtHeader2);
            this.groupBoxPrinting.Controls.Add(this.txtHeader1);
            this.groupBoxPrinting.Location = new System.Drawing.Point(778, 455);
            this.groupBoxPrinting.Name = "groupBoxPrinting";
            this.groupBoxPrinting.Size = new System.Drawing.Size(447, 163);
            this.groupBoxPrinting.TabIndex = 35;
            this.groupBoxPrinting.TabStop = false;
            this.groupBoxPrinting.Text = "PRINTING INFORMATION";
            // 
            // txtHeader1
            // 
            this.txtHeader1.Location = new System.Drawing.Point(87, 19);
            this.txtHeader1.Name = "txtHeader1";
            this.txtHeader1.Size = new System.Drawing.Size(354, 20);
            this.txtHeader1.TabIndex = 0;
            this.txtHeader1.Text = "Republic of the Philippines";
            // 
            // txtHeader2
            // 
            this.txtHeader2.Location = new System.Drawing.Point(87, 54);
            this.txtHeader2.Name = "txtHeader2";
            this.txtHeader2.Size = new System.Drawing.Size(354, 20);
            this.txtHeader2.TabIndex = 1;
            this.txtHeader2.Text = "Province of Cebu";
            // 
            // txtHeader3
            // 
            this.txtHeader3.Location = new System.Drawing.Point(87, 89);
            this.txtHeader3.Name = "txtHeader3";
            this.txtHeader3.Size = new System.Drawing.Size(354, 20);
            this.txtHeader3.TabIndex = 2;
            this.txtHeader3.Text = "Municipality of Aloguinsan";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(87, 124);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(354, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Location = new System.Drawing.Point(30, 26);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(51, 13);
            this.lblHeader1.TabIndex = 4;
            this.lblHeader1.Text = "Header 1";
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Location = new System.Drawing.Point(30, 61);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(51, 13);
            this.lblHeader2.TabIndex = 5;
            this.lblHeader2.Text = "Header 2";
            // 
            // lblHeader3
            // 
            this.lblHeader3.AutoSize = true;
            this.lblHeader3.Location = new System.Drawing.Point(30, 96);
            this.lblHeader3.Name = "lblHeader3";
            this.lblHeader3.Size = new System.Drawing.Size(51, 13);
            this.lblHeader3.TabIndex = 6;
            this.lblHeader3.Text = "Header 3";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(54, 131);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title";
            // 
            // gbPhoto
            // 
            this.gbPhoto.Controls.Add(this.lblHeaderImage);
            this.gbPhoto.Controls.Add(this.btnBrowsePhotos);
            this.gbPhoto.Controls.Add(this.pctrBoxPhotos);
            this.gbPhoto.Location = new System.Drawing.Point(778, 317);
            this.gbPhoto.Name = "gbPhoto";
            this.gbPhoto.Size = new System.Drawing.Size(350, 129);
            this.gbPhoto.TabIndex = 1;
            this.gbPhoto.TabStop = false;
            this.gbPhoto.Text = "PHOTOS";
            // 
            // lblHeaderImage
            // 
            this.lblHeaderImage.AutoSize = true;
            this.lblHeaderImage.Location = new System.Drawing.Point(165, 19);
            this.lblHeaderImage.Name = "lblHeaderImage";
            this.lblHeaderImage.Size = new System.Drawing.Size(74, 13);
            this.lblHeaderImage.TabIndex = 1;
            this.lblHeaderImage.Text = "Header Image";
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
            this.btnRegisterAccount.TabIndex = 29;
            this.btnRegisterAccount.TabStop = false;
            this.btnRegisterAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterAccount.UseVisualStyleBackColor = false;
            this.btnRegisterAccount.Click += new System.EventHandler(this.btnRegisterAccount_Click);
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
            this.btnPrint.Location = new System.Drawing.Point(498, 624);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 38);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "&Print | 8.5x13";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnDeleteAll.Location = new System.Drawing.Point(184, 624);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(110, 38);
            this.btnDeleteAll.TabIndex = 31;
            this.btnDeleteAll.TabStop = false;
            this.btnDeleteAll.Text = "&Delete All";
            this.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
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
            // btnClearPhotos
            // 
            this.btnClearPhotos.BackColor = System.Drawing.Color.Wheat;
            this.btnClearPhotos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPhotos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearPhotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClearPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPhotos.Font = new System.Drawing.Font("Roboto Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPhotos.ForeColor = System.Drawing.Color.Black;
            this.btnClearPhotos.Image = ((System.Drawing.Image)(resources.GetObject("btnClearPhotos.Image")));
            this.btnClearPhotos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClearPhotos.Location = new System.Drawing.Point(1134, 329);
            this.btnClearPhotos.Name = "btnClearPhotos";
            this.btnClearPhotos.Size = new System.Drawing.Size(91, 117);
            this.btnClearPhotos.TabIndex = 36;
            this.btnClearPhotos.TabStop = false;
            this.btnClearPhotos.Text = "&Clear Photos";
            this.btnClearPhotos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearPhotos.UseVisualStyleBackColor = false;
            this.btnClearPhotos.Click += new System.EventHandler(this.btnClearPhotos_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.btnRegisterAccount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnClearPhotos);
            this.Controls.Add(this.gbPhoto);
            this.Controls.Add(this.groupBoxPrinting);
            this.Controls.Add(this.lblTotalPerson);
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
            this.groupBoxPrinting.ResumeLayout(false);
            this.groupBoxPrinting.PerformLayout();
            this.gbPhoto.ResumeLayout(false);
            this.gbPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPhotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegisterAccount;
        public System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView dgvAccount;
        public System.Windows.Forms.TextBox txtNext;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.Button btnPrevious;
        public System.Windows.Forms.Label lblSearchAttendance;
        public System.Windows.Forms.TextBox txtSearchAttendance;
        public System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Label lblTotalPerson;
        private System.Windows.Forms.GroupBox groupBoxPrinting;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeader3;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtHeader3;
        private System.Windows.Forms.TextBox txtHeader2;
        private System.Windows.Forms.TextBox txtHeader1;
        private System.Windows.Forms.GroupBox gbPhoto;
        private System.Windows.Forms.Button btnBrowsePhotos;
        public System.Windows.Forms.PictureBox pctrBoxPhotos;
        public System.Windows.Forms.Label lblHeaderImage;
        private System.Windows.Forms.Button btnClearPhotos;
    }
}