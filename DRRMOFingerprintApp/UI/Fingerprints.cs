using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp.UI
{
    public partial class Fingerprints : Form
    {
        DataAccess db = new DataAccess();
        IEnumerable<Fingerprint> fingerprints;
        IEnumerable<Person> people;
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
            return "SELECT [Id] FROM dbo.Fingerprint";
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

            SearchAndPaginationFingerprint();
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
                MessageBox.Show(ex.Message, "Service broker warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Fingerprints()
        {
            InitializeComponent();

            // Search and pagination
            SearchAndPaginationFingerprint();

            // Realtime fetch data
            RealtimeData();
        }

        public void SearchAndPaginationFingerprint()
        {
            // Get the keywords
            string keywords = txtSearchFingerprint.Text.Trim();

            // Filter the items based on keywords
            if (keywords.Length > 0)
            {
                // Use search method to display items
                DataTable dt = db.SearchFingerprints(keywords);
                dgvFingerprint.DataSource = dt;

                // Change column name
                dgvFingerprint.Columns[1].HeaderText = "Person Id";

                // Hide string image column
                dgvFingerprint.Columns["Id"].Visible = false;

                DataView dv = dt.DefaultView;
                dv.Sort = "Id DESC";
                DataTable sortedDT = dv.ToTable();
            }
            else if (keywords.Length <= 0)
            {
                int pageNumber, pageSize;
                int.TryParse(txtPrevious.Text, out pageNumber);
                int.TryParse(txtNext.Text, out pageSize);

                GetFingerprintsPagination(pageNumber, pageSize);
            }
        }

        public void GetFingerprintsPagination(int pageNumber, int pageSize) 
        {
            int.TryParse(txtPrevious.Text, out pageNumber);
            int.TryParse(txtNext.Text, out pageSize);

            dgvFingerprint.DataSource = db.FingerprintsPagination(pageNumber, pageSize);

            // Change column name
            dgvFingerprint.Columns[1].HeaderText = "Person Id";

            // Hide string image column
            dgvFingerprint.Columns["Id"].Visible = false;
        }

        private void txtSearchFingerprint_TextChanged(object sender, EventArgs e)
        {
            // Get the keywords
            string keywords = txtSearchFingerprint.Text.Trim();

            // Filter the items based on keywords
            if (keywords.Length > 0)
            {
                // Use search method to display items
                DataTable dt = db.SearchFingerprints(keywords);
                dgvFingerprint.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Id DESC";
                DataTable sortedDT = dv.ToTable();
            }
            else if (keywords.Length <= 0)
            {
                int pageNumber, pageSize;
                int.TryParse(txtPrevious.Text, out pageNumber);
                int.TryParse(txtNext.Text, out pageSize);

                if (pageNumber <= 0 || pageSize <= 0)
                {
                    pageNumber = 1;
                    pageSize = 10;
                    dgvFingerprint.DataSource = db.FingerprintsPagination(pageNumber, pageSize);
                }
                else
                {
                    dgvFingerprint.DataSource = db.FingerprintsPagination(pageNumber, pageSize);
                }
            }
        }

        private async void dgvFingerprint_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                fingerprints = db.GetFingerprints();
                people = db.GetPeople();

                foreach (var fingerprint in fingerprints)
                {
                    // Get row index
                    int rowIndex = e.RowIndex;
                    int id = Convert.ToInt32(dgvFingerprint.Rows[rowIndex].Cells[0].Value.ToString());

                    if (fingerprint.Id == id)
                    {
                        foreach (var person in people)
                        {
                            if (person.Id == fingerprint.PersonId)
                            {
                                DialogResult result = MessageBox.Show($"Are you sure you want to delete PERSON ID: {fingerprint.PersonId} {person.FirstName} {person.LastName} fingerprint?", "Delete Fingerprint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    await db.DeleteFingerprint(fingerprint);

                                    txtSearchFingerprint.Focus();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, delete fingerprint", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFingerprint_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalFingerprint.Text = "Total Fingerprint: " + dgvFingerprint.Rows.Count.ToString();
        }

        private void dgvFingerprint_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalFingerprint.Text = "Total Fingerprint: " + dgvFingerprint.Rows.Count.ToString();
        }

        private void txtPrevious_TextChanged(object sender, EventArgs e)
        {
            int pageNumber, pageSize;
            int.TryParse(txtPrevious.Text, out pageNumber);
            int.TryParse(txtNext.Text, out pageSize);

            if (pageNumber <= 0)
            {
                pageNumber = 1;
                dgvFingerprint.DataSource = db.FingerprintsPagination(pageNumber, pageSize);
            }
            else
            {
                dgvFingerprint.DataSource = db.FingerprintsPagination(pageNumber, pageSize);
            }
        }

        private void txtNext_TextChanged(object sender, EventArgs e)
        {
            int pageNumber, pageSize;
            int.TryParse(txtPrevious.Text, out pageNumber);
            int.TryParse(txtNext.Text, out pageSize);

            if (pageSize <= 0)
            {
                pageSize = 10;
                dgvFingerprint.DataSource = db.FingerprintsPagination(pageNumber, pageSize);
            }
            else
            {
                dgvFingerprint.DataSource = db.FingerprintsPagination(pageNumber, pageSize);
            }
        }

        private void txtPrevious_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == 22)
            {
                e.Handled = true;
            }
        }

        private void txtNext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == 22)
            {
                e.Handled = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int pageNumber;
            int.TryParse(txtPrevious.Text, out pageNumber);

            pageNumber--;
            txtPrevious.Text = pageNumber.ToString();

            txtSearchFingerprint.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int pageNumber;
            int.TryParse(txtPrevious.Text, out pageNumber);

            pageNumber++;
            txtPrevious.Text = pageNumber.ToString();

            txtSearchFingerprint.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
