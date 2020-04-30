using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using DRRMOFingerprintApp.UI;

namespace DRRMOFingerprintApp
{
    public partial class Main : Form
    {
        private const string dbString = "DRRMOFingerprintDB";
        public static DateTime Now { get; }

        public Main()
        {
            InitializeComponent();

            // Get person rows
            GetPersonRows();

            // As of Date
            var localDate = DateTime.Now;
            lblDate.Text = Convert.ToString(localDate);
        }

        public void GetPersonRows()
        {
            using (SqlConnection connection = new SqlConnection(Helper.CnnVal(dbString)))
            {
                string query = "SELECT COUNT(*) FROM dbo.Person";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                lblPersonRows.Text = Convert.ToString(count);
                connection.Close();
            }

            // As of Date
            DateTime localDate = DateTime.Now;
            lblDate.Text = Convert.ToString(localDate);
        }

        private void btnUpdatePersonRows_Click(object sender, EventArgs e)
        {
            GetPersonRows();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.ShowDialog();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            var verificationId = new VerificationId();
            verificationId.ShowDialog();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            var registerAccount = new RegisterAccount();
            registerAccount.ShowDialog();
        }

        private void pctrBoxSettings_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
        }

        private void btnRegistrationForm_Click(object sender, EventArgs e)
        {
            try
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string defaultPathName = @"\Document\Registration-Form.xlsx";

                Process.Start(paths + defaultPathName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, registration form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Are your sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
                Application.Exit();
            //}
        }
    }
}
