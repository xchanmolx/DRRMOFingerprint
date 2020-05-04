using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp.UI
{
    public partial class Search : Form
    {
        DataAccess db = new DataAccess();
        List<Person> people = new List<Person>();
        List<PersonInfo> personInfos = new List<PersonInfo>();
        List<Contact> contacts = new List<Contact>();
        List<Address> addresses = new List<Address>();
        List<Occupation> occupations = new List<Occupation>();
        List<Educational> educationals = new List<Educational>();
        List<Spouse> spouses = new List<Spouse>();
        List<Fingerprint> fingerprints = new List<Fingerprint>();

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

            GetPersons();   
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

        public Search()
        {
            InitializeComponent();

            GetPersons();

            // Realtime data
            RealtimeData();
        }

        public void GetPersons()
        {
            people = db.GetPeople().ToList();
            dgvPeople.DataSource = people;

            // Change column name
            dgvPeople.Columns[0].HeaderText = "Person Id";
            dgvPeople.Columns[1].HeaderText = "First Name";
            dgvPeople.Columns[2].HeaderText = "Middle Name";
            dgvPeople.Columns[3].HeaderText = "Last Name";
            dgvPeople.Columns[4].HeaderText = "Ext. Name";
            dgvPeople.Columns[5].HeaderText = "Date of Birth";

            // Hide string image column
            dgvPeople.Columns["StringImage"].Visible = false;
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            var registerAccount = new RegisterAccount();
            registerAccount.ShowDialog();
        }

        private void dgvPeople_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var register = new Register();

                // Header name
                register.Text = "Update | Delete | Personal Data";

                // Image path
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                // Get the index of particular row
                int rowIndex = e.RowIndex;
                register.txtIdFingerprint.Text = dgvPeople.Rows[rowIndex].Cells[0].Value.ToString();
                register.txtFirstName.Text = dgvPeople.Rows[rowIndex].Cells[1].Value.ToString();
                register.txtMiddleName.Text = dgvPeople.Rows[rowIndex].Cells[2].Value.ToString();
                register.txtLastName.Text = dgvPeople.Rows[rowIndex].Cells[3].Value.ToString();
                register.txtExtensionName.Text = dgvPeople.Rows[rowIndex].Cells[4].Value.ToString();
                register.txtDateOfBirth.Text = dgvPeople.Rows[rowIndex].Cells[5].Value.ToString();
                register.cmbGender.SelectedItem = dgvPeople.Rows[rowIndex].Cells[6].Value.ToString();

                int id = Convert.ToInt32(register.txtIdFingerprint.Text);

                people = db.GetPeople().ToList();
                foreach (var person in people)
                {
                    if (person.Id == id)
                    {
                        register.txtRemarks.Text = person.Remarks;
                    }
                }

                register.pctrBoxPhotos.Image = Image.FromFile(paths + dgvPeople.Rows[rowIndex].Cells[8].Value.ToString());

                // Path image
                register.txtPathImage.Text = dgvPeople.Rows[rowIndex].Cells[8].Value.ToString();

                // Insert "-" to date of birth textbox
                register.txtDateOfBirth.Text = register.txtDateOfBirth.Text.Insert(4, "-");
                register.txtDateOfBirth.Text = register.txtDateOfBirth.Text.Insert(7, "-");

                // Additional info & controls
                register.lblRemarks.Visible = true;
                register.txtRemarks.Visible = true;
                register.lblAgeLabel.Visible = true;
                register.lblAge.Visible = true;
                register.lblDateAddedTitle.Visible = true;
                register.lblDateAddedLabel.Visible = true;
                register.lblDateAdded.Visible = true;
                register.gbAdditionalInfo.Enabled = true;
                register.gbContact.Enabled = true;
                register.gbAddress.Enabled = true;
                register.gbOccupation.Enabled = true;
                register.gbHighestEducationalQualification.Enabled = true;
                register.gbIfMarried.Enabled = true;
                register.btnSave.Visible = false;
                register.btnAddAnotherPerson.Visible = false;
                register.btnRegister.Enabled = true;
                register.lblFingerprintRegister.Visible = false;
                register.lblAlreadyRegistered.Visible = false;
                register.lblNotYetRegistered.Visible = false;
                register.btnUpdate.Visible = true;
                register.btnDelete.Visible = true;
                register.errorProviderRegisterForm.Clear();

                personInfos = db.GetPersonInfos().ToList();
                foreach (var personInfo in personInfos)
                {
                    if (personInfo.PersonId == id)
                    {
                        register.txtNickName.Text = personInfo.Nickname;
                        register.cmbCivilStatus.SelectedItem = personInfo.CivilStatus;
                        register.txtBirthPlace.Text = personInfo.BirthPlace;
                        register.txtHeight.Text = personInfo.Height;
                        register.txtWeight.Text = personInfo.Weight;
                        register.txtReligion.Text = personInfo.Religion;
                        register.txtIdentifyingMarks.Text = personInfo.IdentifyingMarks;
                        register.lblDateAdded.Text = personInfo.DateAdded;
                        register.lblAge.Text = Convert.ToString(personInfo.Age);
                    }
                }

                // Contact
                contacts = db.GetContacts().ToList();
                foreach (var contact in contacts)
                {
                    if (contact.PersonId == id)
                    {
                        register.txtPhoneNumber.Text = contact.PhoneNumber;
                        register.txtEmailAddress.Text = contact.EmailAddress;
                    }
                }

                // Address
                addresses = db.GetAddresses().ToList();
                foreach (var address in addresses)
                {
                    if (address.PersonId == id)
                    {
                        register.txtHomeAddress.Text = address.HomeAddress;
                        register.txtTown.Text = address.Town;
                        register.txtBarangay.Text = address.Barangay;
                        register.txtSitio.Text = address.Sitio;
                        register.txtProvince.Text = address.Province;
                        register.txtCountry.Text = address.Country;
                        register.txtZipCode.Text = address.ZipCode;
                    }
                }

                // Occupation
                occupations = db.GetOccupations().ToList();
                foreach (var occupation in occupations)
                {
                    if (occupation.PersonId == id)
                    {
                        register.txtWorkPosition.Text = occupation.WorkPosition;
                        register.txtWorkAddress.Text = occupation.WorkAddress;
                        register.txtWorkPhoneNumber.Text = occupation.WorkPhoneNumber;
                        register.txtOrganization.Text = occupation.Organization;
                        register.cmbDesignation.SelectedItem = occupation.Designation;
                        register.txtOfficeName.Text = occupation.OfficeName;
                    }
                }

                // Highest Educational Qualification
                educationals = db.GetEducationals().ToList();
                foreach (var educational in educationals)
                {
                    if (educational.PersonId == id)
                    {
                        register.cmbLevelOfEducation.SelectedItem = educational.LevelOfEducation;
                        register.txtNameOfSchool.Text = educational.NameOfSchool;
                    }
                }

                // If Married
                spouses = db.GetSpouses().ToList();
                foreach (var spouse in spouses)
                {
                    if (spouse.PersonId == id)
                    {
                        register.txtNameOfSpouse.Text = spouse.NameOfSpouse;
                        register.txtNameOfChildren.Text = spouse.NameOfChildren;
                    }
                }

                // Fingerprint
                fingerprints = db.GetFingerprints().ToList();
                foreach (var fingerprint in fingerprints)
                {
                    if (fingerprint.PersonId == id)
                    {
                        register.txtFingerprint.Text = Convert.ToString(fingerprint.FingerprintPerson);
                    }
                }
             
                register.ShowDialog();
                txtSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, row header mouse click, fetch person data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DataTable dt = db.SearchPersons(keywords);
                dgvPeople.DataSource = dt;

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
