using BackEnd.Aritmica.Features.Person.Models;
using System.Data;

namespace BackEnd.Aritmica.Features.Person.Repositories.Interfaces;

public interface IStudentRepository
{
    bool SaveStudent(IDbTransaction dbTransaction, StudentModel student);
    IEnumerable<StudentModel> GetStudents(IDbConnection dbConnection);
    bool DeactiveStudent(IDbTransaction dbTransaction, int idStudent);
    StudentModel GetStudent(IDbConnection dbConnection, int idPerson);
}