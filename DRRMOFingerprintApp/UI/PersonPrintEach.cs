using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DRRMOFingerprintApp.UI
{
    public partial class PersonPrintEach : Form
    {
        string _date, _imageUrl, _firstName, _middleName, _lastName, _exName, _nickname, _dateAdded, _age,
            _personId, _gender, _birthDate, _phoneNumber, _emailAddress, _religion, _birthPlace,
            _identifyingMarks, _civilStatus, _height, _weight, _homeAddress, _town, _barangay, 
            _purokSitio, _province, _country, _zipCode, _organization, _workPosition, _workAddress,
            _designation, _officeName, _workPhoneNumber, _levelOfEducation, _nameOfSchool,
            _nameOfSpouse, _nameOfChildren;

        public PersonPrintEach(string date, string imageUrl, string firstName, string middleName, string lastName, 
            string exName, string nickname, string dateAdded, string age, string personId, string gender, string birthDate,
            string phoneNumber, string emailAddress, string religion, string birthPlace, string identifyingMarks,
            string civilStatus, string height, string weight, string homeAddress, string town, string barangay,
            string purokSitio, string province, string country, string zipCode, string organization, string workPosition,
            string workAddress, string designation, string officeName, string workPhoneNumber, string levelOfEducation,
            string nameOfSchool, string nameOfSpouse, string nameOfChildren)
        {
            InitializeComponent();

            _date = date;
            _imageUrl = imageUrl;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _exName = exName;
            _nickname = nickname;
            _dateAdded = dateAdded;
            _age = age;
            _personId = personId;
            _gender = gender;
            _birthDate = birthDate;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;
            _religion = religion;
            _birthPlace = birthPlace;
            _identifyingMarks = identifyingMarks;
            _civilStatus = civilStatus;
            _height = height;
            _weight = weight;
            _homeAddress = homeAddress;
            _town = town;
            _barangay = barangay;
            _purokSitio = purokSitio;
            _province = province;
            _country = country;
            _zipCode = zipCode;
            _organization = organization;
            _workPosition = workPosition;
            _workAddress = workAddress;
            _designation = designation;
            _officeName = officeName;
            _workPhoneNumber = workPhoneNumber;
            _levelOfEducation = levelOfEducation;
            _nameOfSchool = nameOfSchool;
            _nameOfSpouse = nameOfSpouse;
            _nameOfChildren = nameOfChildren;
        }

        private void PersonPrintEach_Load(object sender, EventArgs e)
        {
            ReportParameter[] param = new ReportParameter[]
            {
                new ReportParameter("pDate", _date),
                new ReportParameter("pImageUrl", new Uri(_imageUrl).AbsoluteUri),
                new ReportParameter("pFirstName", _firstName),
                new ReportParameter("pMiddleName", _middleName),
                new ReportParameter("pLastName", _lastName),
                new ReportParameter("pExName", _exName),
                new ReportParameter("pNickname", _nickname),
                new ReportParameter("pDateAdded", _dateAdded),
                new ReportParameter("pAge", _age),
                new ReportParameter("pPersonId", _personId),
                new ReportParameter("pGender", _gender),
                new ReportParameter("pBirthDate", _birthDate),
                new ReportParameter("pPhoneNumber", _phoneNumber),
                new ReportParameter("pEmailAddress", _emailAddress),
                new ReportParameter("pReligion", _religion),
                new ReportParameter("pBirthPlace", _birthPlace),
                new ReportParameter("pIdentifyingMarks", _identifyingMarks),
                new ReportParameter("pCivilStatus", _civilStatus),
                new ReportParameter("pHeight", _height),
                new ReportParameter("pWeight", _weight),
                new ReportParameter("pHomeAddress", _homeAddress),
                new ReportParameter("pTown", _town),
                new ReportParameter("pBarangay", _barangay),
                new ReportParameter("pPurokSitio", _purokSitio),
                new ReportParameter("pProvince", _province),
                new ReportParameter("pCountry", _country),
                new ReportParameter("pZipCode", _zipCode),
                new ReportParameter("pOrganization", _organization),
                new ReportParameter("pWorkPosition", _workPosition),
                new ReportParameter("pWorkAddress", _workAddress),
                new ReportParameter("pDesignation", _designation),
                new ReportParameter("pOfficeName", _officeName),
                new ReportParameter("pWorkPhoneNumber", _workPhoneNumber),
                new ReportParameter("pLevelOfEducation", _levelOfEducation),
                new ReportParameter("pNameOfSchool", _nameOfSchool),
                new ReportParameter("pNameOfSpouse", _nameOfSpouse),
                new ReportParameter("pNameOfChildren", _nameOfChildren)
            };

            this.reportViewerPersonPrintEach.LocalReport.EnableExternalImages = true;
            this.reportViewerPersonPrintEach.LocalReport.SetParameters(param);
            this.reportViewerPersonPrintEach.RefreshReport();
        }
    }
}
