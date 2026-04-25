using BackEnd.Aritmica.Connection.Interfaces;
using BackEnd.Aritmica.Features.Logs.Enum;
using BackEnd.Aritmica.Features.Logs.Models;
using BackEnd.Aritmica.Features.Logs.Repositories.Interfaces;
using BackEnd.Aritmica.Features.Logs.Services.Interfaces;
using System.Data;

namespace BackEnd.Aritmica.Features.Logs.Services;
public class LogsService(IConnectionFactory connectionFactory, ILogsRepository logsRepository)
    : ILogsService
{
    public void SaveSucessLog(string message, string entity)
    {
        using var dbTransaction = GetDbTransaction();

        logsRepository.CreateSuccessLog(dbTransaction, GetNewSucessLogModel(message, entity));
    }

    private static LogModel GetNewSucessLogModel(string message, string entity) =>
        new()
        {
            Message = message,
            Entity = entity,
            LogType = LogTypeEnum.Sucess
        };

    public void SaveErrorLog(string message, string entity)
    {
        using var dbTransaction = GetDbTransaction();

        logsRepository.CreateErrorLog(dbTransaction, GetNewErrorLogModel(message, entity));
    }

    private IDbTransaction GetDbTransaction()
    {
        IDbTransaction? dbTransaction = null;
        try
        {
            using var dbConnection = connectionFactory.GetConnection();
            dbConnection.Open();
            dbTransaction = dbConnection.BeginTransaction();
            return dbTransaction;
        }
        catch
        {
            dbTransaction?.Dispose();
            throw;
        }
    }

    private static LogModel GetNewErrorLogModel(string message, string entity) =>
        new()
        {
            Message = message,
            Entity = entity,
            LogType = LogTypeEnum.Error
        };
}
