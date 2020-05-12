namespace DRRMOFingerprintApp.UI
{
    partial class Fingerprints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fingerprints));
            this.lblTotalFingerprint = new System.Windows.Forms.Label();
            this.txtNext = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.lblSearchFingerprint = new System.Windows.Forms.Label();
            this.txtSearchFingerprint = new System.Windows.Forms.TextBox();
            this.dgvFingerprint = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFingerprint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalFingerprint
            // 
            this.lblTotalFingerprint.Font = new System.Drawing.Font("Roboto Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFingerprint.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalFingerprint.Location = new System.Drawing.Point(161, 362);
            this.lblTotalFingerprint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFingerprint.Name = "lblTotalFingerprint";
            this.lblTotalFingerprint.Size = new System.Drawing.Size(203, 18);
            this.lblTotalFingerprint.TabIndex = 42;
            this.lblTotalFingerprint.Text = "?";
            this.lblTotalFingerprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNext
            // 
            this.txtNext.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNext.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNext.Location = new System.Drawing.Point(371, 352);
            this.txtNext.Multiline = true;
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(73, 38);
            this.txtNext.TabIndex = 41;
            this.txtNext.TabStop = false;
            this.txtNext.Text = "10";
            this.txtNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNext.TextChanged += new System.EventHandler(this.txtNext_TextChanged);
            this.txtNext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNext_KeyPress);
            // 
            // txtPrevious
            // 
            this.txtPrevious.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevious.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPrevious.Location = new System.Drawing.Point(81, 352);
            this.txtPrevious.Multiline = true;
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(73, 38);
            this.txtPrevious.TabIndex = 39;
            this.txtPrevious.TabStop = false;
            this.txtPrevious.Text = "1";
            this.txtPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrevious.TextChanged += new System.EventHandler(this.txtPrevious_TextChanged);
            this.txtPrevious.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrevious_KeyPress);
            // 
            // lblSearchFingerprint
            // 
            this.lblSearchFingerprint.AutoSize = true;
            this.lblSearchFingerprint.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFingerprint.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSearchFingerprint.Location = new System.Drawing.Point(31, 9);
            this.lblSearchFingerprint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchFingerprint.Name = "lblSearchFingerprint";
            this.lblSearchFingerprint.Size = new System.Drawing.Size(246, 33);
            this.lblSearchFingerprint.TabIndex = 37;
            this.lblSearchFingerprint.Text = "Search Fingerprints";
            this.lblSearchFingerprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchFingerprint
            // 
            this.txtSearchFingerprint.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchFingerprint.Font = new System.Drawing.Font("Roboto Condensed", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFingerprint.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtSearchFingerprint.Location = new System.Drawing.Point(30, 45);
            this.txtSearchFingerprint.Multiline = true;
            this.txtSearchFingerprint.Name = "txtSearchFingerprint";
            this.txtSearchFingerprint.Size = new System.Drawing.Size(465, 40);
            this.txtSearchFingerprint.TabIndex = 35;
            this.txtSearchFingerprint.TextChanged += new System.EventHandler(this.txtSearchFingerprint_TextChanged);
            // 
            // dgvFingerprint
            // 
            this.dgvFingerprint.AllowUserToAddRows = false;
            this.dgvFingerprint.AllowUserToDeleteRows = false;
            this.dgvFingerprint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFingerprint.BackgroundColor = System.Drawing.Color.White;
            this.dgvFingerprint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFingerprint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFingerprint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFingerprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFingerprint.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFingerprint.EnableHeadersVisualStyles = false;
            this.dgvFingerprint.Location = new System.Drawing.Point(30, 91);
            this.dgvFingerprint.Name = "dgvFingerprint";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFingerprint.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvFingerprint.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFingerprint.Size = new System.Drawing.Size(465, 255);
            this.dgvFingerprint.TabIndex = 36;
            this.dgvFingerprint.TabStop = false;
            this.dgvFingerprint.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFingerprint_RowHeaderMouseClick);
            this.dgvFingerprint.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFingerprint_RowsAdded);
            this.dgvFingerprint.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvFingerprint_RowsRemoved);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(450, 352);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 38);
            this.btnNext.TabIndex = 40;
            this.btnNext.TabStop = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(30, 352);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 38);
            this.btnPrevious.TabIndex = 38;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
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
            this.btnExit.Location = new System.Drawing.Point(479, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 45);
            this.btnExit.TabIndex = 43;
            this.btnExit.TabStop = false;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Fingerprints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(528, 409);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalFingerprint);
            this.Controls.Add(this.txtNext);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblSearchFingerprint);
            this.Controls.Add(this.txtSearchFingerprint);
            this.Controls.Add(this.dgvFingerprint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fingerprints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fingerprints";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFingerprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTotalFingerprint;
        public System.Windows.Forms.TextBox txtNext;
        public System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.TextBox txtPrevious;
        public System.Windows.Forms.Button btnPrevious;
        public System.Windows.Forms.Label lblSearchFingerprint;
        public System.Windows.Forms.TextBox txtSearchFingerprint;
        public System.Windows.Forms.DataGridView dgvFingerprint;
        public System.Windows.Forms.Button btnExit;
    }
}