namespace BackEnd.Aritmica.Features.Logs.Services.Interfaces;
public interface ILogsService
{
    void SaveSucessLog(string message, string entity);
    void SaveErrorLog(string message, string entity);
}
