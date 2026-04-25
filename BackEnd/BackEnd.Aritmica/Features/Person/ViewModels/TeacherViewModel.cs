using BackEnd.Aritmica.Features.Person.Enums;

namespace BackEnd.Aritmica.Features.Person.ViewModels
{
    public class TeacherViewModel : PersonViewModel
    {
        public string Curriculum { get; set; }
        public List<DiciplineEnum> AppliedDiciplines { get; set; }
    }
}
