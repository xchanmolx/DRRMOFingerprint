using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DRRMOFingerprintApp.DS;
using Microsoft.Reporting.WinForms;

namespace DRRMOFingerprintApp.UI
{
    public partial class PersonPrintAll : Form
    {
        private const string dbString = "DRRMOFingerprintDB";
        string _date;

        public PersonPrintAll(string date)
        {
            InitializeComponent();

            _date = date;
        }

        private void PersonPrintAll_Load(object sender, EventArgs e)
        {
            // Get textboxes from Settings form pass to PersonPrintAll form
            TextBox txtSearch = Application.OpenForms["Search"].Controls["txtSearch"] as TextBox;

            txtSearch.Text = txtSearch.Text;

            dsPerson_PrintAll dsPPA = new dsPerson_PrintAll();
            SqlConnection connection = new SqlConnection(Helper.CnnVal(dbString));
            string query = @"SELECT * FROM dbo.Person WHERE FirstName LIKE '%" + txtSearch.Text + "%' " +
                "OR MiddleName LIKE '%" + txtSearch.Text + "%' OR LastName LIKE '%" + txtSearch.Text + "%' OR ExtensionName LIKE '%" + txtSearch.Text + "%'" +
                "OR DateOfBirth LIKE '%" + txtSearch.Text + "%' OR Gender LIKE '%" + txtSearch.Text + "%' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            sda.Fill(dsPPA, dsPPA.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("dsPerson_PrintAll", dsPPA.Tables[0].DefaultView.ToTable());
            this.reportViewerPersonPrintAll.LocalReport.DataSources.Clear();
            this.reportViewerPersonPrintAll.LocalReport.DataSources.Add(rds);
            this.reportViewerPersonPrintAll.LocalReport.Refresh();

            ReportParameter[] param = new ReportParameter[]
            {
                new ReportParameter("pDate", _date)
            };

            this.reportViewerPersonPrintAll.LocalReport.SetParameters(param);
            this.reportViewerPersonPrintAll.RefreshReport();
        }
    }
}
