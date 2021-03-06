﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DRRMOFingerprintApp.DS;
using Microsoft.Reporting.WinForms;

namespace DRRMOFingerprintApp.UI
{
    public partial class AttendancePrintAll : Form
    {
        private const string dbString = "DRRMOFingerprintDB";
        string _header1, _header2, _header3, _title, _date, _imageUrl;

        public AttendancePrintAll(string header1, string header2, string header3, string title, string date, string imageUrl)
        {
            InitializeComponent();

            _header1 = header1;
            _header2 = header2;
            _header3 = header3;
            _title = title;
            _date = date;
            _imageUrl = imageUrl;
        }

        private void AttendancePrintAll_Load(object sender, EventArgs e)
        {
            // Get textboxes from Settings form pass to AttendancePrintAll form
            TextBox txtSearchAttendance = Application.OpenForms["Settings"].Controls["txtSearchAttendance"] as TextBox;
            TextBox txtSearchDate = Application.OpenForms["Settings"].Controls["txtSearchDate"] as TextBox;

            txtSearchAttendance.Text = txtSearchAttendance.Text;
            txtSearchDate.Text = txtSearchDate.Text;

            dsAttendance_PrintAll dsAPA = new dsAttendance_PrintAll();
            SqlConnection connection = new SqlConnection(Helper.CnnVal(dbString));
            string query = "SELECT * FROM dbo.Attendance WHERE FirstName LIKE '%" + txtSearchAttendance.Text + "%' AND LocalDate LIKE '%" + txtSearchDate.Text + "%' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            sda.Fill(dsAPA, dsAPA.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("dsAttendance_PrintAll", dsAPA.Tables[0].DefaultView.ToTable());
            this.reportViewerAttendancePrintAll.LocalReport.DataSources.Clear();
            this.reportViewerAttendancePrintAll.LocalReport.DataSources.Add(rds);
            this.reportViewerAttendancePrintAll.LocalReport.Refresh();

            ReportParameter[] param = new ReportParameter[]
            {
                new ReportParameter("pHeader1", _header1),
                new ReportParameter("pHeader2", _header2),
                new ReportParameter("pHeader3", _header3),
                new ReportParameter("pTitle", _title),
                new ReportParameter("pDate", _date),
                new ReportParameter("pImageUrl", new Uri(_imageUrl).AbsoluteUri)
            };

            this.reportViewerAttendancePrintAll.LocalReport.EnableExternalImages = true;
            this.reportViewerAttendancePrintAll.LocalReport.SetParameters(param);
            this.reportViewerAttendancePrintAll.RefreshReport();
        }
    }
}
