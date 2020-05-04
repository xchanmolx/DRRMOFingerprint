using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp.UI
{
    public partial class Settings : Form
    {
        DataAccess db = new DataAccess();
        List<Account> accounts = new List<Account>();

        private const string dbString = "DRRMOFingerprintDB";
        private DataSet dataToWatch = null;
        private SqlConnection connection = null;
        private SqlCommand command = null;

        public string GetConnectionString()
        {
            return Helper.CnnVal(dbString);
        }

        private string GetSQL()
        {
            return "SELECT [FirstName] FROM dbo.Account";
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

            GetAccounts();
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

        public Settings()
        {
            InitializeComponent();

            GetAccounts();

            // Realtime fetch data
            RealtimeData();
        }

        public void GetAccounts()
        {
            accounts = db.GetAccounts().ToList();
            dgvAccount.DataSource = accounts;

            // Change column name
            dgvAccount.Columns[0].HeaderText = "Account Id";
            dgvAccount.Columns[1].HeaderText = "First Name";
            dgvAccount.Columns[2].HeaderText = "Last Name";

            // Hide string image column
            dgvAccount.Columns["Username"].Visible = false;
            dgvAccount.Columns["Password"].Visible = false;
            dgvAccount.Columns["StringImage"].Visible = false;
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            var registerAccount = new RegisterAccount();
            registerAccount.ShowDialog();
        }

        private void dgvAccount_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var registerAccount = new RegisterAccount();

                // Header name
                registerAccount.Text = "Update | Delete | Account Data";

                // Image path
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                // Get the index of particular row
                int rowIndex = e.RowIndex;
                registerAccount.lblId.Text = dgvAccount.Rows[rowIndex].Cells[0].Value.ToString();
                registerAccount.txtFirstName.Text = dgvAccount.Rows[rowIndex].Cells[1].Value.ToString();
                registerAccount.txtLastName.Text = dgvAccount.Rows[rowIndex].Cells[2].Value.ToString();
                registerAccount.txtUsername.Text = dgvAccount.Rows[rowIndex].Cells[3].Value.ToString();
                registerAccount.txtPassword.Text = dgvAccount.Rows[rowIndex].Cells[4].Value.ToString();
                registerAccount.pctrBoxPhotos.Image = Image.FromFile(paths + dgvAccount.Rows[rowIndex].Cells[5].Value.ToString());

                // Path image
                registerAccount.txtPathImage.Text = dgvAccount.Rows[rowIndex].Cells[5].Value.ToString();

                registerAccount.lblRegisterAccount.Visible = false;
                registerAccount.btnSave.Visible = false;
                registerAccount.btnUpdate.Visible = true;
                registerAccount.btnDelete.Visible = true;
                registerAccount.errorProviderRegisterAccount.Clear();

                registerAccount.ShowDialog();
                txtSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, row header mouse click, fetch account data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the keywords
            string keywords = txtSearch.Text.Trim();

            // Filter the items based on keywords
            if (keywords != null)
            {
                // Use search method to display items
                DataTable dt = db.SearchAccounts(keywords);
                dgvAccount.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Id DESC";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
