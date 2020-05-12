using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Dapper;
using DRRMOFingerprintApp.Model;
using DRRMOFingerprintApp.UI;

namespace DRRMOFingerprintApp
{
    public partial class Register : Form
    {
        private DPFP.Template Template;

        readonly DataAccess db = new DataAccess();
        List<Person> people = new List<Person>();
        IEnumerable<Fingerprint> paws;

        public static DateTime Now { get; }

        public Register()
        {
            InitializeComponent();
            cmbGender.SelectedIndex = 0;
            cmbCivilStatus.SelectedIndex = 0;
            cmbDesignation.SelectedIndex = 0;
            cmbLevelOfEducation.SelectedIndex = 0;
            pctrBoxPhotos.Image = Properties.Resources.default_image;
        }

        private void Clean()
        {
            // Personal Info
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtExtensionName.Text = "";
            txtDateOfBirth.Text = "";
            cmbGender.SelectedIndex = 0;
            txtRemarks.Text = "";

            // Photos
            pctrBoxPhotos.Image = Properties.Resources.default_image;

            // Additional Info
            txtNickName.Text = "";
            cmbCivilStatus.SelectedIndex = 0;
            txtBirthPlace.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtReligion.Text = "";
            txtIdentifyingMarks.Text = "";

            // Contact
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";

            // Address
            txtHomeAddress.Text = "";
            txtTown.Text = "";
            txtBarangay.Text = "";
            txtSitio.Text = "";
            txtZipCode.Text = "";

            // Occupation
            txtOrganization.Text = "";
            txtWorkPosition.Text = "";
            txtWorkAddress.Text = "";
            cmbDesignation.SelectedIndex = 0;
            txtOfficeName.Text = "";
            txtWorkPhoneNumber.Text = "";

            // Highest Educational Qualification
            cmbLevelOfEducation.SelectedIndex = 0;
            txtNameOfSchool.Text = "";

            // If Married
            txtNameOfSpouse.Text = "";
            txtNameOfChildren.Text = "";

            // Fingerprint
            txtIdFingerprint.Text = "";
            txtFingerprint.Text = "";

            // Focus on First Name TextBox when save all
            txtFirstName.Focus();

            // Clear error provider
            errorProviderRegisterForm.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Clear error provider
            errorProviderRegisterForm.SetError(btnRegister, "");

            var registerFingerprint = new RegisterFingerprint();
            registerFingerprint.OnTemplate += this.OnTemplate;
            registerFingerprint.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(async delegate ()
            {
                Template = template;
                btnSave.Enabled = (Template != null);
                if (Template != null)
                {
                    try
                    {
                        // Save fingerprint
                        byte[] streamFingerprint = Template.Bytes;

                        var fingerprint = new Fingerprint();
                        fingerprint.PersonId = Convert.ToInt32(txtIdFingerprint.Text);
                        fingerprint.FingerprintPerson = streamFingerprint;

                        await db.InsertFingerprint(fingerprint);

                        MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFingerprint.Text = "Fingerprint captured correctly";
                        btnSave.Enabled = false;

                        // Register the fingerprint to change label
                        lblAlreadyRegistered.BringToFront();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error, save fingerprint", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment", "Fingerprint Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
        }

        private bool ValidateForm()
        {
            bool bStatus = true;

            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProviderRegisterForm.SetError(txtFirstName, "Required First Name");
                bStatus = false;
            }
            else if (String.IsNullOrWhiteSpace(txtDateOfBirth.Text))
            {
                errorProviderRegisterForm.SetError(txtDateOfBirth, "Required Date of Birth");
                bStatus = false;
            }
            else if (txtDateOfBirth.Text.Length < 8 || txtDateOfBirth.Text.Length > 8)
            {
                errorProviderRegisterForm.SetError(txtDateOfBirth, "Please specify 8 characters");
                bStatus = false;
            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProviderRegisterForm.SetError(txtLastName, "Required Last Name");
                bStatus = false;
            }
            else if (cmbGender.SelectedIndex == 0)
            {
                errorProviderRegisterForm.SetError(cmbGender, "Required Gender");
                bStatus = false;
            }

            return bStatus;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    // Save person table
                    string defaultPathImage = @"\Images\Persons\";
                    string defaultImage = "default-image.jpg";
                    string correctFileName = Path.GetFileName(ofd.FileName);

                    var person = new Person();

                    person.FirstName = txtFirstName.Text;
                    person.MiddleName = txtMiddleName.Text;
                    person.LastName = txtLastName.Text;
                    person.ExtensionName = txtExtensionName.Text;
                    person.DateOfBirth = txtDateOfBirth.Text;
                    person.Gender = cmbGender.Text;

                    if (btnBrowseWasClick == true)
                    {
                        if (ofd.FileName == "")
                        {
                            person.StringImage = defaultPathImage + defaultImage;
                        }
                        else
                        {
                            person.StringImage = defaultPathImage + correctFileName;
                        }
                    }
                    else if (btnBrowseWasClick == false)
                    {
                        person.StringImage = defaultPathImage + defaultImage;
                    }
                    btnBrowseWasClick = false;

                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DRRMOFingerprintDB")))
                    {
                        string query = @"INSERT INTO dbo.[Person] (FirstName, MiddleName, LastName, ExtensionName, DateOfBirth, Gender, StringImage) OUTPUT INSERTED.[Id] VALUES (@FirstName, @MiddleName, @LastName, @ExtensionName, @DateOfBirth, @Gender, @StringImage)";
                        int newUserId = connection.QuerySingle<int>(query, new { person.FirstName, person.MiddleName, person.LastName, person.ExtensionName, person.DateOfBirth, person.Gender, person.StringImage });

                        txtIdFingerprint.Text = Convert.ToString(newUserId);
                    }

                    people.Add(person);

                    MessageBox.Show("Record added to database successfully", "Record added to personal data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Template = null;

                    btnSave.Enabled = false;
                    gbPersonalInformation.Enabled = false;
                    gbPhoto.Enabled = false;

                    // Secondary profile
                    btnRegister.Enabled = true;
                    btnAddAnotherPerson.Enabled = true;

                    gbAdditionalInfo.Enabled = true;
                    gbContact.Enabled = true;
                    gbAddress.Enabled = true;
                    gbOccupation.Enabled = true;
                    gbHighestEducationalQualification.Enabled = true;
                    gbIfMarried.Enabled = true;

                    txtNickName.Focus();

                    errorProviderRegisterForm.SetError(btnRegister, "Please register fingerprint");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error, save person data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnAddAnotherPerson_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Haven't you finished register the fingerprint?", "Register Fingerprint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Local date of PC
                    var localDate = DateTime.Now;

                    // Get age of person
                    string birthDate = txtDateOfBirth.Text;
                    int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                    int dob = int.Parse(birthDate);
                    int age = (now - dob) / 10000;

                    // Save additional info
                    var personInfo = new PersonInfo();
                    personInfo.PersonId = Convert.ToInt32(txtIdFingerprint.Text);
                    personInfo.Nickname = txtNickName.Text;
                    personInfo.CivilStatus = cmbCivilStatus.Text;
                    personInfo.BirthPlace = txtBirthPlace.Text;
                    personInfo.Height = txtHeight.Text;
                    personInfo.Weight = txtWeight.Text;
                    personInfo.Religion = txtReligion.Text;
                    personInfo.IdentifyingMarks = txtIdentifyingMarks.Text;
                    personInfo.DateAdded = Convert.ToString(localDate);
                    personInfo.Age = age;

                    await db.InsertPersonAdditionalInfo(personInfo);

                    // Save contact to table
                    var contact = new Contact();
                    contact.PersonId = Convert.ToInt32(txtIdFingerprint.Text);
                    contact.PhoneNumber = txtPhoneNumber.Text;
                    contact.EmailAddress = txtEmailAddress.Text;

                    await db.InsertContact(contact);

                    // Save address to table
                    var address = new Address();
                    address.PersonId = Convert.ToInt32(txtIdFingerprint.Text);
                    address.HomeAddress = txtHomeAddress.Text;
                    address.Town = txtTown.Text;
                    address.Barangay = txtBarangay.Text;
                    address.Sitio = txtSitio.Text;
                    address.Province = txtProvince.Text;
                    address.Country = txtCountry.Text;
                    address.ZipCode = txtZipCode.Text;

                    await db.InsertAddress(address);

                    // Save occupation to table
                    var occupation = new Occupation();
                    occupation.PersonId = Convert.ToInt32(txtIdFingerprint.Text);
                    occupation.Organization = txtOrganization.Text;
                    occupation.WorkPosition = txtWorkPosition.Text;
                    occupation.WorkAddress = txtWorkAddress.Text;
                    occupation.Designation = cmbDesignation.Text;
                    occupation.OfficeName = txtOfficeName.Text;
                    occupation.WorkPhoneNumber = txtWorkPhoneNumber.Text;

                    await db.InsertOccupation(occupation);

                    // Save educational to table
                    var educational = new Educational();
                    educational.PersonId = Convert.ToInt32(txtIdFingerprint.Text);
                    educational.LevelOfEducation = cmbLevelOfEducation.Text;
                    educational.NameOfSchool = txtNameOfSchool.Text;

                    await db.InsertEducationalQualification(educational);

                    // Save spouse to table
                    var spouse = new Spouse();
                    spouse.PersonId = Convert.ToInt32(txtIdFingerprint.Text);
                    spouse.NameOfSpouse = txtNameOfSpouse.Text;
                    spouse.NameOfChildren = txtNameOfChildren.Text;

                    await db.InsertSpouse(spouse);

                    // Change Controls
                    gbPersonalInformation.Enabled = true;
                    gbPhoto.Enabled = true;

                    gbAdditionalInfo.Enabled = false;
                    gbContact.Enabled = false;
                    gbAddress.Enabled = false;
                    gbOccupation.Enabled = false;
                    gbHighestEducationalQualification.Enabled = false;
                    gbIfMarried.Enabled = false;

                    btnSave.Enabled = false;
                    btnAddAnotherPerson.Enabled = false;
                    btnRegister.Enabled = false;

                    // Clear Text Boxes
                    Clean();

                    lblNotYetRegistered.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert spouse, address, occupation, & contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private bool btnBrowseWasClick = false;
        private void btnBrowsePhotos_Click(object sender, EventArgs e)
        {
            // Clear picture box
            errorProviderRegisterForm.SetError(pctrBoxPhotos, "");

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

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        #region TextChanged
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != null)
            {
                errorProviderRegisterForm.SetError(txtFirstName, "");
            }
        }

        private void txtDateOfBirth_TextChanged(object sender, EventArgs e)
        {
            if (txtDateOfBirth.Text != null)
            {
                errorProviderRegisterForm.SetError(txtDateOfBirth, "");
            }
        }
        #endregion

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex > 0)
            {
                errorProviderRegisterForm.SetError(cmbGender, "");
                errorProviderRegisterForm.SetError(pctrBoxPhotos, "Please browse photos");
            }
        }

        private void txtDateOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDateOfBirth.MaxLength = 10;

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == 22)
            {
                e.Handled = true;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show($"Are your sure you want to update {txtFirstName.Text} {txtLastName.Text}?", "Update personal data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Remove "-" to date of birth textbox
                    txtDateOfBirth.Text = txtDateOfBirth.Text.Remove(4, 1);
                    txtDateOfBirth.Text = txtDateOfBirth.Text.Remove(6, 1);

                    string dateOfBirth = txtDateOfBirth.Text;

                    int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                    int dob = int.Parse(dateOfBirth);
                    int age = (now - dob) / 10000;

                    // Get file name of the image & default image path
                    string defaultPathImage = @"\Images\Persons\";
                    string correctFileName = Path.GetFileName(ofd.FileName);

                    int id = Convert.ToInt32(txtIdFingerprint.Text);

                    // Get the values from User Form | Person table
                    var person = new Person();
                    person.Id = id;
                    person.FirstName = txtFirstName.Text;
                    person.MiddleName = txtMiddleName.Text;
                    person.LastName = txtLastName.Text;
                    person.ExtensionName = txtExtensionName.Text;
                    person.DateOfBirth = dateOfBirth;
                    person.Gender = Convert.ToString(cmbGender.SelectedItem);
                    person.Remarks = txtRemarks.Text;

                    if (btnBrowseWasClick == true)
                    {
                        person.StringImage = defaultPathImage + correctFileName;
                    }
                    else if (btnBrowseWasClick == false)
                    {
                        person.StringImage = txtPathImage.Text;
                    }
                    btnBrowseWasClick = false;

                    await db.UpdatePerson(person);

                    // Get the values from User Form | PersonInfo table
                    var personInfo = new PersonInfo();
                    personInfo.PersonId = id;
                    personInfo.Nickname = txtNickName.Text;
                    personInfo.CivilStatus = Convert.ToString(cmbCivilStatus.SelectedItem);
                    personInfo.BirthPlace = txtBirthPlace.Text;
                    personInfo.Height = txtHeight.Text;
                    personInfo.Weight = txtWeight.Text;
                    personInfo.Religion = txtReligion.Text;
                    personInfo.IdentifyingMarks = txtIdentifyingMarks.Text;
                    personInfo.DateAdded = lblDateAdded.Text;
                    personInfo.Age = Convert.ToInt32(lblAge.Text);

                    await db.UpdatePersonInfo(personInfo);

                    // Get the values from User Form | Contact table
                    var contact = new Contact();
                    contact.PersonId = id;
                    contact.PhoneNumber = txtPhoneNumber.Text;
                    contact.EmailAddress = txtEmailAddress.Text;

                    await db.UpdateContact(contact);

                    // Get the values from User Form | Address table
                    var address = new Address();
                    address.PersonId = id;
                    address.HomeAddress = txtHomeAddress.Text;
                    address.Town = txtTown.Text;
                    address.Barangay = txtBarangay.Text;
                    address.Sitio = txtSitio.Text;
                    address.Province = txtProvince.Text;
                    address.Country = txtCountry.Text;
                    address.ZipCode = txtZipCode.Text;

                    await db.UpdateAddress(address);

                    // Get the values from User Form | Occupation table
                    var occupation = new Occupation();
                    occupation.PersonId = id;
                    occupation.WorkPosition = txtWorkPosition.Text;
                    occupation.WorkAddress = txtWorkAddress.Text;
                    occupation.WorkPhoneNumber = txtWorkPhoneNumber.Text;
                    occupation.Organization = txtOrganization.Text;
                    occupation.Designation = Convert.ToString(cmbDesignation.SelectedItem);
                    occupation.OfficeName = txtOfficeName.Text;

                    await db.UpdateOccupation(occupation);

                    // Get the values from User Form | Educational table
                    var educational = new Educational();
                    educational.PersonId = id;
                    educational.LevelOfEducation = Convert.ToString(cmbLevelOfEducation.SelectedItem);
                    educational.NameOfSchool = txtNameOfSchool.Text;

                    await db.UpdateEducational(educational);

                    // Get the values from User Form | Spouse table
                    var spouse = new Spouse();
                    spouse.PersonId = id;
                    spouse.NameOfSpouse = txtNameOfSpouse.Text;
                    spouse.NameOfChildren = txtNameOfChildren.Text;

                    await db.UpdateSpouse(spouse);

                    // Insert "-" date of birth textbox
                    txtDateOfBirth.Text = txtDateOfBirth.Text.Insert(4, "-");
                    txtDateOfBirth.Text = txtDateOfBirth.Text.Insert(7, "-");

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
                    var person = new Person();
                    person.Id = Convert.ToInt32(txtIdFingerprint.Text);

                    await db.DeletePerson(person);

                    MessageBox.Show($"Delete successfully for {txtFirstName.Text} {txtLastName.Text}", "Delete successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete individual personal data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                var personPrintEach = new PersonPrintEach(DateTime.Now.ToString("dddd, MMMM dd, yyyy"), (paths + txtPathImage.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, 
                    txtExtensionName.Text, txtNickName.Text, lblDateAdded.Text, lblAge.Text, txtIdFingerprint.Text, Convert.ToString(cmbGender.SelectedItem), txtDateOfBirth.Text, txtPhoneNumber.Text,
                    txtEmailAddress.Text, txtReligion.Text, txtBirthPlace.Text, txtIdentifyingMarks.Text, Convert.ToString(cmbCivilStatus.SelectedItem), txtHeight.Text, txtWeight.Text,
                    txtHomeAddress.Text, txtTown.Text, txtBarangay.Text, txtSitio.Text, txtProvince.Text, txtCountry.Text, txtZipCode.Text, txtOrganization.Text, txtWorkPosition.Text, txtWorkAddress.Text,
                    Convert.ToString(cmbDesignation.SelectedItem), txtOfficeName.Text, txtWorkPhoneNumber.Text, Convert.ToString(cmbLevelOfEducation.SelectedItem),
                    txtNameOfSchool.Text, txtNameOfSpouse.Text, txtNameOfChildren.Text);

                personPrintEach.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, print personal profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFingerprint_Click(object sender, EventArgs e)
        {
            try
            {
                var fingerprints = new Fingerprints();

                fingerprints.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, delete fingerprint", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnAddAnotherPerson.Enabled == false)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please click Add Another Profile button before you close the form, so that it will save the additional personal informaiton", "Save the additional personal information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
