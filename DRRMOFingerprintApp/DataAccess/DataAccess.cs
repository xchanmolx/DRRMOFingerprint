using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp
{
    public class DataAccess
    {
        public List<PersonTest> GetPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB")))
            {
                return connection.Query<PersonTest>("SELECT * FROM Person").ToList();
            }
        }
    }
}
