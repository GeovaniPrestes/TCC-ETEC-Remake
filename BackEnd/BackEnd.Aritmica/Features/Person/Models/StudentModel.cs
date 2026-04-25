using BackEnd.Aritmica.Features.Person.ViewModels;

namespace BackEnd.Aritmica.Features.Person.Models
{
    public class StudentModel(StudentViewModel person) : PersonModel(person)
    {
        public int LastClassViewed { get; set; } = person.LastClassViewed;
    }
}
