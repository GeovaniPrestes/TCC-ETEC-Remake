using BackEnd.Aritmica.Features.Logs.Models;
using System.Data;

namespace BackEnd.Aritmica.Features.Logs.Repositories.Interfaces
{
    public interface ILogsRepository
    {
        void CreateErrorLog(IDbTransaction dbTransaction, LogModel log);
        void CreateSuccessLog(IDbTransaction dbTransaction, LogModel log);
        void CreateLoginLog(IDbTransaction dbTransaction, LogModel log);
    }
}
