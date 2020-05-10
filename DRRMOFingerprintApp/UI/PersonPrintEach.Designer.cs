namespace DRRMOFingerprintApp.UI
{
    partial class PersonPrintEach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonPrintEach));
            this.reportViewerPersonPrintEach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPersonPrintEach
            // 
            this.reportViewerPersonPrintEach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPersonPrintEach.LocalReport.ReportEmbeddedResource = "DRRMOFingerprintApp.Report.rptPerson_PrintEach.rdlc";
            this.reportViewerPersonPrintEach.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPersonPrintEach.Name = "reportViewerPersonPrintEach";
            this.reportViewerPersonPrintEach.ServerReport.BearerToken = null;
            this.reportViewerPersonPrintEach.Size = new System.Drawing.Size(857, 450);
            this.reportViewerPersonPrintEach.TabIndex = 0;
            // 
            // PersonPrintEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.reportViewerPersonPrintEach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonPrintEach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINT PERSON PROFILE";
            this.Load += new System.EventHandler(this.PersonPrintEach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPersonPrintEach;
    }
}