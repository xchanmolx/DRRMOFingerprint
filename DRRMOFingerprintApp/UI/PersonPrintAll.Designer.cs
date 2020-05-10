namespace DRRMOFingerprintApp.UI
{
    partial class PersonPrintAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonPrintAll));
            this.reportViewerPersonPrintAll = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPersonPrintAll
            // 
            this.reportViewerPersonPrintAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPersonPrintAll.LocalReport.ReportEmbeddedResource = "DRRMOFingerprintApp.Report.rptPerson_PrintAll.rdlc";
            this.reportViewerPersonPrintAll.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPersonPrintAll.Name = "reportViewerPersonPrintAll";
            this.reportViewerPersonPrintAll.ServerReport.BearerToken = null;
            this.reportViewerPersonPrintAll.Size = new System.Drawing.Size(800, 450);
            this.reportViewerPersonPrintAll.TabIndex = 0;
            // 
            // PersonPrintAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerPersonPrintAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonPrintAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINT ALL PERSON";
            this.Load += new System.EventHandler(this.PersonPrintAll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPersonPrintAll;
    }
}