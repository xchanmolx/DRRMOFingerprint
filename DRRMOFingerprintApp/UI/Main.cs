using System;
using System.ComponentModel;
using System.Data;
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

        private DataSet dataToWatch = null;
        private SqlConnection connection = null;
        private SqlCommand command = null;

        public string GetConnectionString()
        {
            return Helper.CnnVal(dbString);
        }

        private string GetSQL()
        {
            return "SELECT [FirstName] FROM dbo.Person";
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            //MessageBox.Show("modification Occurred");
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)
            {
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);
                object[] args = { sender, e };
                i.BeginInvoke(tempDelegate, args);
                return;
            }

            SqlDependency dependency = (SqlDependency)sender;
            dependency.OnChange -= dependency_OnChange;
            //++changeCount;
            //lblChanges.Text = String.Format(statusMessage, changeCount);

            GetData();

            GetPersonRows();
        }

        private void GetData()
        {
            //dataToWatch.Clear();
            //command.Notification = null;
            dataToWatch.Clear();
            command.Notification = null;
            SqlDependency dependency = new SqlDependency(command);
            if (connection.State != ConnectionState.Open) connection.Open();
            using (var dr = command.ExecuteReader())
            {
                dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
            }
        }

        public void RealtimeData()
        {
            try
            {
                //changeCount = 0;
                //lblChanges.Text = String.Format(statusMessage, changeCount);

                SqlDependency.Stop(GetConnectionString());
                SqlDependency.Start(GetConnectionString());

                if (connection == null)
                {
                    connection = new SqlConnection(GetConnectionString());
                }

                if (command == null)
                {
                    command = new SqlCommand(GetSQL(), connection);
                }
                if (dataToWatch == null)
                {
                    dataToWatch = new DataSet();
                }

                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Start Realtime Button Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Main()
        {
            InitializeComponent();

            // Get person rows
            GetPersonRows();

            // Realtime data
            RealtimeData();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.Show();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            var verification = new Verification();
            verification.ShowDialog();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            var registerAccount = new RegisterAccount();
            registerAccount.ShowDialog();
        }

        private void pctrBoxSearch_Click(object sender, EventArgs e)
        {
            var search = new Search();
            search.ShowDialog();
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

        private void pctrBoxSettings_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            // Button btnOff = On
            Button off = (Button)btnOff;
            off.Enabled = true;

            // Button btnOn = Off
            Button on = (Button)btnOn;
            on.Enabled = false;

            lblEvent.Visible = false;
            txtEvent.Visible = false;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            // Button btnOn = On
            Button on = (Button)btnOn;
            on.Enabled = true;

            // Button btnOff = Off
            Button off = (Button)btnOff;
            off.Enabled = false;

            lblEvent.Visible = true;
            txtEvent.Visible = true;

            txtEvent.Focus();
        }

        private void txtEvent_TextChanged(object sender, EventArgs e)
        {
            txtEvent.MaxLength = 24;
        }

        private void lblLinkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            var login = new Login();
            login.Show();

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
