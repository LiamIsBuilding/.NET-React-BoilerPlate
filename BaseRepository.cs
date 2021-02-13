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
                Host = "", // e.g. ec2-1-2-3-4@eu-west-1.compute.amazonaws.com
                Database = "", // e.g. ksdjfhsafnfas
                Username = "", // e.g. lksfhdslkfsdflk
                Password = "",// e.g KJZDldfj34567dslkfjsdlfksdjflsdkfjsdlkfjsdl34567fkjdsgDRTYUI
                Port = , // e.g 5432
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