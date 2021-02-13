using Npgsql;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace _NET_React_Boiler
{
    public class BaseRepository
    {
        IConfiguration _configuration;

        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private NpgsqlConnection SqlConnection()
        {
            var StringBuilder = new NpgsqlConnectionStringBuilder
            {
                Host = "",
                Database = "",
                Username = "",
                Password = "",
                Port = ,
                SslMode = Npgsql.SslMode.Require, // Heroku Specific Setting
                TrustServerCertificate = true // Heroku Specific Setting
            };
            return new NpgsqlConnection(StringBuilder.ConnectionString);
        }
        public IDbConnection CreateConnection()
        {
            var connection = SqlConnection();
            connection.Open();
            return connection;
        }
    }
}