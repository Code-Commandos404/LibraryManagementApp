using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace DataAccessLibrary
{
    public class LibraryClass
    {


        public class SqlDb : ISqlDb
        {
            private readonly IConfiguration _config;
            public string myConnectionString { get; set; } = "default";
            public SqlDb(IConfiguration config)
            {
                _config = config;
            }

            public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
            {
                string connectionString = _config.GetConnectionString(myConnectionString); // Creates a new connection String
                using IDbConnection connection = new SqlConnection(connectionString); //creates a connection
                var data = await connection.QueryAsync<T>(sql, parameters); //fetches the data using parameters weve specified,asyncrnously
                return data.ToList(); //converts the dat to a list.
            }
            public async Task SaveData<T>(string sql, T parameters)
            {
                string connectionString = _config.GetConnectionString(myConnectionString); // Creates a new connection String
                using (IDbConnection connection = new SqlConnection(connectionString)) //creates a connection
                {
                    await connection.ExecuteAsync(sql, parameters); //pushes the data using parameters weve specified,asyncrnously

                }
            }
        }
    }
}