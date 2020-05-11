using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        List<Attendance> attendances = new List<Attendance>();

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
            return "SELECT [FirstName] FROM dbo.Account" + " SELECT [FirstName] FROM dbo.Attendance";
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
            SearchAndPaginationAttendance();
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

            // Get accounts
            GetAccounts();

            // Search and pagination
            SearchAndPaginationAttendance();

            // Realtime fetch data
            RealtimeData();

            pctrBoxPhotos.Image = Properties.Resources.aloguinsan_logo;
        }

        public void SearchAndPaginationAttendance()
        {
            // Get the keywords
            string keywords = txtSearchAttendance.Text.Trim();

            // Filter the items based on keywords
            if (keywords.Length > 0)
            {
                // Use search method to display items
                DataTable dt = db.SearchAttendances(keywords);
                dgvAttendance.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Id DESC";
                DataTable sortedDT = dv.ToTable();
            }
            else if (keywords.Length <= 0)
            {
                int pageNumber, pageSize;
                int.TryParse(txtPrevious.Text, out pageNumber);
                int.TryParse(txtNext.Text, out pageSize);

                GetAttendancesPagination(pageNumber, pageSize);
            }
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

        public void GetAttendancesPagination(int pageNumber, int pageSize)
        {
            int.TryParse(txtPrevious.Text, out pageNumber);
            int.TryParse(txtNext.Text, out pageSize);

            dgvAttendance.DataSource = db.AttendancesPagination(pageNumber, pageSize);

            // Change column name
            dgvAttendance.Columns[1].HeaderText = "First Name";
            dgvAttendance.Columns[2].HeaderText = "Last Name";
            dgvAttendance.Columns[4].HeaderText = "Office Name";
            dgvAttendance.Columns[6].HeaderText = "Date & Time";

            // Hide string image column
            dgvAttendance.Columns["Id"].Visible = false;
            dgvAttendance.Columns["Signature"].Visible = false;
        }

        private void txtSearchAttendance_TextChanged(object sender, EventArgs e)
        {
            // Get the keywords
            string keywords = txtSearchAttendance.Text.Trim();

            // Filter the items based on keywords
            if (keywords.Length > 0)
            {
                // Use search method to display items
                DataTable dt = db.SearchAttendances(keywords);
                dgvAttendance.DataSource = dt;

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
                    dgvAttendance.DataSource = db.AttendancesPagination(pageNumber, pageSize);
                }
                else
                {
                    dgvAttendance.DataSource = db.AttendancesPagination(pageNumber, pageSize);
                }
            }
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            var registerAccount = new RegisterAccount();
            registerAccount.ShowDialog();

            txtSearchAttendance.Focus();
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblSearch.Visible = true;
            txtSearch.Visible = true;
            dgvAccount.Visible = true;

            btnShow.Visible = false;

            txtSearch.Focus();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
            txtSearch.Visible = false;
            dgvAccount.Visible = false;

            btnShow.Visible = true;

            txtSearchAttendance.Focus();
        }

        private void txtPrevious_TextChanged(object sender, EventArgs e)
        {
            int pageNumber, pageSize;
            int.TryParse(txtPrevious.Text, out pageNumber);
            int.TryParse(txtNext.Text, out pageSize);

            if (pageNumber <= 0)
            {
                pageNumber = 1;
                dgvAttendance.DataSource = db.AttendancesPagination(pageNumber, pageSize);
            }
            else
            {
                dgvAttendance.DataSource = db.AttendancesPagination(pageNumber, pageSize);
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
                dgvAttendance.DataSource = db.AttendancesPagination(pageNumber, pageSize);
            }
            else
            {
                dgvAttendance.DataSource = db.AttendancesPagination(pageNumber, pageSize);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int pageNumber;
            int.TryParse(txtPrevious.Text, out pageNumber);

            pageNumber--;
            txtPrevious.Text = pageNumber.ToString();

            txtSearchAttendance.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int pageNumber;
            int.TryParse(txtPrevious.Text, out pageNumber);

            pageNumber++;
            txtPrevious.Text = pageNumber.ToString();

            txtSearchAttendance.Focus();
        }

        private async void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all attendance?", "Delete All Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await db.DeleteAllAttendance();
                MessageBox.Show("Deleted all attendance successfully!", "Deleted successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string defaultImage = "aloguinsan-logo.png";
                string defaultPathImage = @"\Images\Logos\";
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string correctFileName = Path.GetFileName(ofd.FileName);
                if (btnBrowsePhotosWasClicked == true)
                {
                    if (ofd.FileName == "")
                    {
                        imageUrl = defaultImage;
                    }
                    else
                    {
                        imageUrl = correctFileName;
                    }
                }
                else
                {
                    imageUrl = defaultImage;
                }

                if (btnClearPhotosWasClicked == true)
                {
                    imageUrl = null;
                }

                var frm = new AttendancePrintAll(txtHeader1.Text, txtHeader2.Text, txtHeader3.Text, txtTitle.Text, DateTime.Now.ToString("dddd, MMMM dd, yyyy"), paths + defaultPathImage + imageUrl);

                frm.ShowDialog();

                txtSearchAttendance.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, print all attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvAttendance_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                attendances = db.GetAttendances().ToList();

                foreach (var attendance in attendances)
                {
                    // Get row index
                    int rowIndex = e.RowIndex;
                    int id = Convert.ToInt32(dgvAttendance.Rows[rowIndex].Cells[0].Value.ToString());
                    
                    if (attendance.Id == id)
                    {
                        DialogResult result = MessageBox.Show($"Are you sure you want to delete {attendance.FirstName} {attendance.LastName} attendance?", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            await db.DeleteAttendance(attendance);

                            txtSearchAttendance.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, deleting attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvAttendance_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get row index
                int rowIndex = e.RowIndex;

                var attendance = new Attendance();
                attendance.Id = Convert.ToInt32(dgvAttendance.Rows[rowIndex].Cells[0].Value.ToString());
                attendance.FirstName = dgvAttendance.Rows[rowIndex].Cells[1].Value.ToString();
                attendance.LastName = dgvAttendance.Rows[rowIndex].Cells[2].Value.ToString();
                attendance.Gender = dgvAttendance.Rows[rowIndex].Cells[3].Value.ToString();
                attendance.OfficeName = dgvAttendance.Rows[rowIndex].Cells[4].Value.ToString();
                attendance.Designation = dgvAttendance.Rows[rowIndex].Cells[5].Value.ToString();
                attendance.LocalDate = dgvAttendance.Rows[rowIndex].Cells[6].Value.ToString();

                await db.UpdateAttendance(attendance);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, update datagridview attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAttendance_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalPerson.Text = "Total Person: " + dgvAttendance.Rows.Count.ToString();
        }

        private void dgvAttendance_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalPerson.Text = "Total Person: " + dgvAttendance.Rows.Count.ToString();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        string imageUrl = null;
        bool btnBrowsePhotosWasClicked = false;
        private void btnBrowsePhotos_Click(object sender, EventArgs e)
        {
            try
            {
                btnBrowsePhotosWasClicked = true;

                // OpenFileDialog
                ofd.Filter = @"All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif" +
                                "|PNG Portable Network Graphics (*.png)|*.png" +
                                "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
                                "|BMP Windows Bitmap (*.bmp)|*.bmp" +
                                "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
                                "|GIF Graphics Interchange Format (*.gif)|*.gif";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.CheckFileExists)
                    {
                        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        string correctFileName = Path.GetFileName(ofd.FileName);
                        File.Copy(ofd.FileName, paths + @"\Images\Logos\" + correctFileName, true);

                        pctrBoxPhotos.Image = Image.FromFile(ofd.FileName);

                        imageUrl = correctFileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, browse image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool btnClearPhotosWasClicked = false;
        private void btnClearPhotos_Click(object sender, EventArgs e)
        {
            btnClearPhotosWasClicked = true;

            pctrBoxPhotos.Image = null;
            imageUrl = null;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
