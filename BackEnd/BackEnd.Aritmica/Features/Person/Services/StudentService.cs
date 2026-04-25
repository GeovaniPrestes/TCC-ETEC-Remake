using BackEnd.Aritmica.Features.Person.Models;
using BackEnd.Aritmica.Features.Person.Repositories.Interfaces;
using BackEnd.Aritmica.Features.Person.Services.Interfaces;
using System.Data;

namespace BackEnd.Aritmica.Features.Person.Services;

public class StudentService(IStudentRepository studentRepository) : IStudentService
{
    private readonly IStudentRepository _studentRepository = studentRepository;

    public bool SaveStudent(IDbTransaction dbTransaction, StudentModel student)
    {
        throw new NotImplementedException();
    }

    public IList<StudentModel> ListStudents(IDbConnection dbConnection)
    {
        throw new NotImplementedException();
    }

    public bool DeactiveStudent(IDbTransaction dbTransaction, int idStudent)
    {
        throw new NotImplementedException();
    }

    public StudentModel ReturnStudent(IDbConnection dbConnection, int idStudent)
    {
        throw new NotImplementedException();
    }
}