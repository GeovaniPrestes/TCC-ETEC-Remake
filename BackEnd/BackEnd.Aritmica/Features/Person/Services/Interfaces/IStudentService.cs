using BackEnd.Aritmica.Features.Person.Models;
using System.Data;

namespace BackEnd.Aritmica.Features.Person.Services.Interfaces;

public interface IStudentService
{
    bool SaveStudent(IDbTransaction dbTransaction, StudentModel student);
    IList<StudentModel> ListStudents(IDbConnection dbConnection);
    bool DeactiveStudent(IDbTransaction dbTransaction, int idStudent);
    StudentModel ReturnStudent(IDbConnection dbConnection, int idStudent);
}
