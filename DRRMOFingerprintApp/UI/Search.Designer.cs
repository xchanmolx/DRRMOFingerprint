namespace DRRMOFingerprintApp.UI
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtNext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPeople.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPeople.EnableHeadersVisualStyles = false;
            this.dgvPeople.Location = new System.Drawing.Point(27, 96);
            this.dgvPeople.Name = "dgvPeople";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvPeople.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeople.Size = new System.Drawing.Size(881, 255);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.TabStop = false;
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
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Roboto Condensed", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtSearch.Location = new System.Drawing.Point(27, 50);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(881, 40);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSearch.Location = new System.Drawing.Point(28, 14);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 33);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(27, 357);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 38);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtPrevious
            // 
            this.txtPrevious.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevious.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPrevious.Location = new System.Drawing.Point(78, 357);
            this.txtPrevious.Multiline = true;
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(73, 38);
            this.txtPrevious.TabIndex = 17;
            this.txtPrevious.TabStop = false;
            this.txtPrevious.Text = "1";
            this.txtPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrevious.TextChanged += new System.EventHandler(this.txtPrevious_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(863, 357);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 38);
            this.btnNext.TabIndex = 18;
            this.btnNext.TabStop = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtNext
            // 
            this.txtNext.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNext.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNext.Location = new System.Drawing.Point(784, 357);
            this.txtNext.Multiline = true;
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(73, 38);
            this.txtNext.TabIndex = 19;
            this.txtNext.TabStop = false;
            this.txtNext.Text = "10";
            this.txtNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNext.TextChanged += new System.EventHandler(this.txtNext_TextChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtNext);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvPeople);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtNext;
    }
}