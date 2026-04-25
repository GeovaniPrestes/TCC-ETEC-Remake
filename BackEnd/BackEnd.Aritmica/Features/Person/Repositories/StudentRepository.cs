using BackEnd.Aritmica.Features.Logs.Services.Interfaces;
using BackEnd.Aritmica.Features.Person.Models;
using BackEnd.Aritmica.Features.Person.Repositories.Interfaces;
using Dapper;
using System.Data;

namespace BackEnd.Aritmica.Features.Person.Repositories;

public class StudentRepository(ILogsService logsService) : PersonRepository(logsService), IStudentRepository
{
    private readonly ILogsService _logsService = logsService;

    public bool SaveStudent(IDbTransaction dbTransaction, StudentModel student)
    {
        try
        {
            student.IdPerson = SavePerson(dbTransaction, student);
            dbTransaction.Connection!.Execute("", student, dbTransaction);
            return true;
        }
        catch (Exception exception)
        {
            _logsService.SaveErrorLog(exception.Message, nameof(PersonRepository));
            return false;
        }

    }

    public IEnumerable<StudentModel> GetStudents(IDbConnection dbConnection) =>
        dbConnection.Query<StudentModel>("");

    public bool DeactiveStudent(IDbTransaction dbTransaction, int idStudent)
    {
        try
        {

            return true;
        }
        catch
        {
            return false;
        }
    }

    public StudentModel GetStudent(IDbConnection dbConnection, int idPerson) =>
        dbConnection.QueryFirst<StudentModel>("", new {idPerson});
}