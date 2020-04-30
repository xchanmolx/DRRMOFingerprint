﻿using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
