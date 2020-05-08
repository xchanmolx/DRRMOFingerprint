namespace DRRMOFingerprintApp.UI
{
    partial class AttendancePrintAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendancePrintAll));
            this.reportViewerAttendancePrintAll = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerAttendancePrintAll
            // 
            this.reportViewerAttendancePrintAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerAttendancePrintAll.LocalReport.ReportEmbeddedResource = "DRRMOFingerprintApp.Report.rptAttendance_PrintAll.rdlc";
            this.reportViewerAttendancePrintAll.Location = new System.Drawing.Point(0, 0);
            this.reportViewerAttendancePrintAll.Name = "reportViewerAttendancePrintAll";
            this.reportViewerAttendancePrintAll.ServerReport.BearerToken = null;
            this.reportViewerAttendancePrintAll.Size = new System.Drawing.Size(844, 450);
            this.reportViewerAttendancePrintAll.TabIndex = 0;
            // 
            // AttendancePrintAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.reportViewerAttendancePrintAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttendancePrintAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINT ALL ATTENDANCE";
            this.Load += new System.EventHandler(this.AttendancePrintAll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAttendancePrintAll;
    }
}