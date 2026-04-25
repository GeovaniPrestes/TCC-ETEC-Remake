using System.Data;

namespace BackEnd.Aritmica.Features.Base.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(IDbTransaction dbTransaction, object baseObject, string sql);
        bool Update(IDbTransaction dbTransaction, object baseObject, string sql);
        T GetDetails(IDbConnection dbConnection, string sql);
        IList<T> GetList(IDbConnection dbConnection, string sql);
        bool RemoveById(IDbTransaction dbTransaction, int id, string sql);
    }
}
