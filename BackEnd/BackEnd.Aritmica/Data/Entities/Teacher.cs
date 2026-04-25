using BackEnd.Aritmica.Features.Person.Enums;

namespace BackEnd.Aritmica.Data.Entities
{
    public class Teacher : Person
    {
        public string Curriculum { get; set; }
        public List<DiciplineEnum> AppliedDiciplines { get; set; }
    }
}
