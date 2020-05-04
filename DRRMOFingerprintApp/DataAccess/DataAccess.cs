using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp
{
    public class DataAccess
    {
        private const string dbString = "DRRMOFingerprintDB";

        public IEnumerable<Person> GetPeople()
        {
            IEnumerable<Person> people;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
            {
                people = connection.Query<Person>("spPerson_SelectAllPerson", commandType: CommandType.StoredProcedure);
            }

            return people;
        }

        public IEnumerable<Account> GetAccounts()
        {
            IEnumerable<Account> accounts;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
            {
                accounts = connection.Query<Account>("spAccount_SelectAllAccount", commandType: CommandType.StoredProcedure);
            }

            return accounts;
        }

        public IEnumerable<Fingerprint> GetFingerprints()
        {
            IEnumerable<Fingerprint> fingerprints;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
            {
                fingerprints = connection.Query<Fingerprint>("spFingerprint_SelectAllFingerprint", commandType: CommandType.StoredProcedure);
            }

            return fingerprints;
        }

        public IEnumerable<PersonInfo> GetPersonInfos()
        {
            IEnumerable<PersonInfo> personInfos;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
            {
                personInfos = connection.Query<PersonInfo>("spPersonInfo_SelectAll", commandType: CommandType.StoredProcedure);
            }

            return personInfos;
        }

        public IEnumerable<Contact> GetContacts()
        {
            IEnumerable<Contact> contacts;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
            {
                contacts = connection.Query<Contact>("spContact_SelectAll", commandType: CommandType.StoredProcedure);
            }

            return contacts;
        }

        public IEnumerable<Address> GetAddresses()
        {
            IEnumerable<Address> addresses;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
            {
                addresses = connection.Query<Address>("spAddress_SelectAll", commandType: CommandType.StoredProcedure);
            }

            return addresses;
        }

        public IEnumerable<Occupation> GetOccupations()
        {
            IEnumerable<Occupation> occupations;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
            {
                occupations = connection.Query<Occupation>("spOccupation_SelectAll", commandType: CommandType.StoredProcedure);
            }

            return occupations;
        }

        public IEnumerable<Educational> GetEducationals()
        {
            IEnumerable<Educational> educationals;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
            {
                educationals = connection.Query<Educational>("spEducational_SelectAll", commandType: CommandType.StoredProcedure);
            }

            return educationals;
        }

        public IEnumerable<Spouse> GetSpouses()
        {
            IEnumerable<Spouse> spouses;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
            {
                spouses = connection.Query<Spouse>("spSpouse_SelectAll", commandType: CommandType.StoredProcedure);
            }

            return spouses;
        }

        public async Task InsertFingerprint(Fingerprint fingerprint)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", fingerprint.PersonId, DbType.Int32);
                parameters.Add("FingerprintPerson", fingerprint.FingerprintPerson, DbType.Binary);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spFingerprint_InsertFingerprint", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert fingerprint", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task InsertSpouse(Spouse spouse)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", spouse.PersonId, DbType.Int32);
                parameters.Add("NameOfSpouse", spouse.NameOfSpouse, DbType.String);
                parameters.Add("NameOfChildren", spouse.NameOfChildren, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spSpouse_InsertSpouse", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert spouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task InsertAddress(Address address)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", address.PersonId, DbType.Int32);
                parameters.Add("HomeAddress", address.HomeAddress, DbType.String);
                parameters.Add("Town", address.Town, DbType.String);
                parameters.Add("Barangay", address.Barangay, DbType.String);
                parameters.Add("Sitio", address.Sitio, DbType.String);
                parameters.Add("Province", address.Province, DbType.String);
                parameters.Add("Country", address.Country, DbType.String);
                parameters.Add("ZipCode", address.ZipCode, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spAddress_InsertAddress", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task InsertOccupation(Occupation occupation)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", occupation.PersonId, DbType.Int32);
                parameters.Add("WorkPosition", occupation.WorkPosition, DbType.String);
                parameters.Add("WorkAddress", occupation.WorkAddress, DbType.String);
                parameters.Add("WorkPhoneNumber", occupation.WorkPhoneNumber, DbType.String);
                parameters.Add("Organization", occupation.Organization, DbType.String);
                parameters.Add("Designation", occupation.Designation, DbType.String);
                parameters.Add("OfficeName", occupation.OfficeName, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spOccupation_InsertOccupation", parameters, commandType: CommandType.StoredProcedure);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert occupation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task InsertContact(Contact contact)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", contact.PersonId, DbType.Int32);
                parameters.Add("PhoneNumber", contact.PhoneNumber, DbType.String);
                parameters.Add("EmailAddress", contact.EmailAddress, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spContact_InsertContact", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task InsertAccount(Account account)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("FirstName", account.FirstName, DbType.String);
                parameters.Add("LastName", account.LastName, DbType.String);
                parameters.Add("Username", account.Username, DbType.String);
                parameters.Add("Password", account.Password, DbType.String);
                parameters.Add("StringImage", account.StringImage, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spAccount_InsertAccount", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task InsertPersonAdditionalInfo(PersonInfo personInfo)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", personInfo.PersonId, DbType.Int32);
                parameters.Add("NickName", personInfo.Nickname, DbType.String);
                parameters.Add("CivilStatus", personInfo.CivilStatus, DbType.String);
                parameters.Add("BirthPlace", personInfo.BirthPlace, DbType.String);
                parameters.Add("Height", personInfo.Height, DbType.String);
                parameters.Add("Weight", personInfo.Weight, DbType.String);
                parameters.Add("Religion", personInfo.Religion, DbType.String);
                parameters.Add("IdentifyingMarks", personInfo.IdentifyingMarks, DbType.String);
                parameters.Add("DateAdded", personInfo.DateAdded, DbType.String);
                parameters.Add("Age", personInfo.Age, DbType.Int32);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spPersonInfo_InsertInfo", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert person additional info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task InsertEducationalQualification(Educational educational)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", educational.PersonId, DbType.Int32);
                parameters.Add("LevelOfEducation", educational.LevelOfEducation, DbType.String);
                parameters.Add("NameOfSchool", educational.NameOfSchool, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spEducational_Insert", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert highest educational qualification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdatePerson(Person person)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id", person.Id, DbType.Int32);
                parameters.Add("FirstName", person.FirstName, DbType.String);
                parameters.Add("MiddleName", person.MiddleName, DbType.String);
                parameters.Add("LastName", person.LastName, DbType.String);
                parameters.Add("ExtensionName", person.ExtensionName, DbType.String);
                parameters.Add("DateOfBirth", person.DateOfBirth, DbType.String);
                parameters.Add("Gender", person.Gender, DbType.String);
                parameters.Add("Remarks", person.Remarks, DbType.String);
                parameters.Add("StringImage", person.StringImage, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spPerson_Update", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, update person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdatePersonInfo(PersonInfo personInfo)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", personInfo.PersonId, DbType.Int32);
                parameters.Add("Nickname", personInfo.Nickname, DbType.String);
                parameters.Add("CivilStatus", personInfo.CivilStatus, DbType.String);
                parameters.Add("BirthPlace", personInfo.BirthPlace, DbType.String);
                parameters.Add("Height", personInfo.Height, DbType.String);
                parameters.Add("Weight", personInfo.Weight, DbType.String);
                parameters.Add("Religion", personInfo.Religion, DbType.String);
                parameters.Add("IdentifyingMarks", personInfo.IdentifyingMarks, DbType.String);
                parameters.Add("DateAdded", personInfo.DateAdded, DbType.String);
                parameters.Add("Age", personInfo.Age, DbType.Int32);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spPersonInfo_Update", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, update person info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateContact(Contact contact)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", contact.PersonId, DbType.Int32);
                parameters.Add("PhoneNumber", contact.PhoneNumber, DbType.String);
                parameters.Add("EmailAddress", contact.EmailAddress, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spContact_Update", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, update contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateAddress(Address address)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", address.PersonId, DbType.Int32);
                parameters.Add("HomeAddress", address.HomeAddress, DbType.String);
                parameters.Add("Town", address.Town, DbType.String);
                parameters.Add("Barangay", address.Barangay, DbType.String);
                parameters.Add("Sitio", address.Sitio, DbType.String);
                parameters.Add("Province", address.Province, DbType.String);
                parameters.Add("Country", address.Country, DbType.String);
                parameters.Add("ZipCode", address.ZipCode, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spAddress_Update", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, update address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateOccupation(Occupation occupation)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", occupation.PersonId, DbType.Int32);
                parameters.Add("WorkPosition", occupation.WorkPosition, DbType.String);
                parameters.Add("WorkAddress", occupation.WorkAddress, DbType.String);
                parameters.Add("WorkPhoneNumber", occupation.WorkPhoneNumber, DbType.String);
                parameters.Add("Organization", occupation.Organization, DbType.String);
                parameters.Add("Designation", occupation.Designation, DbType.String);
                parameters.Add("OfficeName", occupation.OfficeName, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spOccupation_Update", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, update occupation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateEducational(Educational educational)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", educational.PersonId, DbType.Int32);
                parameters.Add("LevelOfEducation", educational.LevelOfEducation, DbType.String);
                parameters.Add("NameOfSchool", educational.NameOfSchool, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spEducational_Update", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, update educational", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateSpouse(Spouse spouse)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("PersonId", spouse.PersonId, DbType.Int32);
                parameters.Add("NameOfSpouse", spouse.NameOfSpouse, DbType.String);
                parameters.Add("NameOfChildren", spouse.NameOfChildren, DbType.String);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spSpouse_Update", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, update spouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task DeletePerson(Person person)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id", person.Id, DbType.Int32);

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(dbString)))
                {
                    await connection.ExecuteAsync("spPerson_DeletePerson", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, delete person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable SearchPersons(string keywords)
        {
            // SQL connection for database connection
            SqlConnection conn = new SqlConnection(Helper.CnnVal(dbString));

            // Creating data table to hold the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Search items from database
                String sql = "SELECT * FROM dbo.Person WHERE Id LIKE '%" + keywords + "%' OR FirstName LIKE '%" + keywords + "%' OR MiddleName LIKE '%" + keywords + "%' OR LastName LIKE '%" + keywords + "%' OR ExtensionName LIKE '%" + keywords + "%' OR DateOfBirth LIKE '%" + keywords + "%' OR Gender LIKE '%" + keywords + "%' OR Remarks LIKE '%" + keywords + "%' ";

                // Creating SQL Commant to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Getting data from database
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                // Open database connection
                conn.Open();

                // Passing values from adapter to Data Table dt
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Persons!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
    }
}
