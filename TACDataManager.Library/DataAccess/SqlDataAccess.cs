using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACDataManager.Library.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private string GetConnectionString()
        {
            #region ConnectionString
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TACData;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            #endregion
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters)
        {
            string connectionString = GetConnectionString();

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }

        public void SaveData<T>(string storedProcedure, T parameters)
        {
            string connectionString = GetConnectionString();

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}