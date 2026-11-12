using Microsoft.Data.SqlClient;
using System.Data;

namespace WebAPI_Wilber_Alvarez.Data
{

    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Default")
                ?? throw new InvalidOperationException("Falta la cadena de conexion");

        }

        public IDbConnection CreateConnection()=> new SqlConnection(_connectionString)
    }
}
