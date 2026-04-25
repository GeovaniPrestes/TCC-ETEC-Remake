using System.Data;

namespace BackEnd.Aritmica.Connection.Interfaces
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
