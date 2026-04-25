using BackEnd.Aritmica.Connection.Interfaces;
using Npgsql;
using System.Data;

namespace BackEnd.Aritmica.Data
{
    public class ConnectionFactory(IConfiguration configuration) : IConnectionFactory
    {
        private readonly string? _connectionString = configuration.GetConnectionString("DefaultConnection");

        public IDbConnection GetConnection()
        {
            try
            {
                return new NpgsqlConnection(_connectionString);
            }
            catch (Exception ex)
            {
                // ignored
                return new NpgsqlConnection("");
            }
        }
    }
}
