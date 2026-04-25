using BackEnd.Aritmica.Features.Logs.Models;
using BackEnd.Aritmica.Features.Logs.Repositories.Interfaces;
using Dapper;
using System.Data;

namespace BackEnd.Aritmica.Features.Logs.Repositories;
public class LogsRepository : ILogsRepository
{
    private const string SqlSaveErrorLog = "";
    private const string SqlSaveSucessLog = "";

    public void CreateErrorLog(IDbTransaction dbTransaction, LogModel log) => 
        dbTransaction.Connection!.ExecuteAsync("", log, dbTransaction);

    public void CreateSuccessLog(IDbTransaction dbTransaction, LogModel log) => 
        dbTransaction.Connection!.ExecuteAsync("", log, dbTransaction);

    public void CreateLoginLog(IDbTransaction dbTransaction, LogModel log) => 
        dbTransaction.Connection!.ExecuteAsync("", log, dbTransaction);
}
