using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp.UI
{
    public partial class RegisterAccount : Form
    {
        readonly DataAccess db = new DataAccess();
        List<Account> accounts = new List<Account>();

        public RegisterAccount()
        {
            InitializeComponent();
            pctrBoxPhotos.Image = Properties.Resources.default_image;
        }

        private void Clean()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            pctrBoxPhotos.Image = Properties.Resources.default_image;

            txtFirstName.Focus();

            btnSave.Enabled = false;
        }

        private bool ValidateForm()
        {
            bool bStatus = true;

            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProviderRegisterAccount.SetError(txtFirstName, "Required First Name");
                bStatus = false;
            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProviderRegisterAccount.SetError(txtLastName, "Required Last Name");
                bStatus = false;
            }
            else if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProviderRegisterAccount.SetError(txtUsername, "Required Username");
                bStatus = false;
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProviderRegisterAccount.SetError(txtPassword, "Required Password");
                bStatus = false;
            }

            return bStatus;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    string defaultPathImage = @"\Images\Persons\";
                    string defaultImage = "default-image.jpg";
                    string correctFileName = Path.GetFileName(ofd.FileName);

                    var account = new Account();

                    account.FirstName = txtFirstName.Text;
                    account.LastName = txtLastName.Text;
                    account.Username = txtUsername.Text;
                    account.Password = txtPassword.Text;

                    if (btnBrowseWasClick == true)
                    {
                        account.StringImage = defaultPathImage + correctFileName;
                    }
                    else if (btnBrowseWasClick == false)
                    {
                        account.StringImage = defaultPathImage + defaultImage;
                    }
                    btnBrowseWasClick = false;

                    await db.InsertAccount(account);

                    accounts.Add(account);

                    MessageBox.Show("Record added to database successfully", "Record added to account", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear Controls
                    Clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error, save account data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private bool btnBrowseWasClick = false;
        private void btnBrowsePhotos_Click(object sender, EventArgs e)
        {
            // Clear picture box
            errorProviderRegisterAccount.SetError(pctrBoxPhotos, "");

            btnBrowseWasClick = true;
            string defaultPathImage = @"\Images\Persons\";

            try
            {
                // OpenFileDialog
                ofd.Filter = "Image Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.CheckFileExists)
                    {
                        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        string correctFileName = Path.GetFileName(ofd.FileName);
                        File.Copy(ofd.FileName, paths + defaultPathImage + correctFileName, true);

                        pctrBoxPhotos.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, browse image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.TextLength > 0)
            {
                errorProviderRegisterAccount.SetError(pctrBoxPhotos, "Please browse photos");
                btnSave.Enabled = true;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show($"Are your sure you want to update {txtFirstName.Text} {txtLastName.Text}?", "Update personal data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Get file name of the image & default image path
                    string defaultPathImage = @"\Images\Persons\";
                    string correctFileName = Path.GetFileName(ofd.FileName);

                    int id = Convert.ToInt32(lblId.Text);

                    // Get the values from User Form | Person table
                    var account = new Account();
                    account.Id = id;
                    account.FirstName = txtFirstName.Text;
                    account.LastName = txtLastName.Text;
                    account.Username = txtUsername.Text;
                    account.Password = txtPassword.Text;

                    if (btnBrowseWasClick == true)
                    {
                        account.StringImage = defaultPathImage + correctFileName;
                    }
                    else if (btnBrowseWasClick == false)
                    {
                        account.StringImage = txtPathImage.Text;
                    }
                    btnBrowseWasClick = false;

                    await db.UpdateAccount(account);

                    MessageBox.Show($"Update successfully for {txtFirstName.Text} {txtLastName.Text}", "Update successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtFirstName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, update person data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show($"Are your sure you want to delete {txtFirstName.Text} {txtLastName.Text}?", "Delete personal data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var account = new Account();
                    account.Id = Convert.ToInt32(lblId.Text);

                    await db.DeleteAccount(account);

                    MessageBox.Show($"Delete successfully for {txtFirstName.Text} {txtLastName.Text}", "Delete successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete individual account data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
