using BackEnd.Aritmica.Features.Person.Enums;
using BackEnd.Aritmica.Features.Person.ViewModels;

namespace BackEnd.Aritmica.Features.Person.Models
{
    public class TeacherModel(TeacherViewModel person) : PersonModel(person)
    {
        public string Curriculum { get; set; } = person.Curriculum;
        public List<DiciplineEnum> AppliedDiciplines { get; set; } = person.AppliedDiciplines;
    }
}
