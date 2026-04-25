using BackEnd.Aritmica.Features.Person.Enums;
using BackEnd.Aritmica.Features.Person.ViewModels;

namespace BackEnd.Aritmica.Features.Person.Models
{
    public class PersonModel(PersonViewModel person)
    {
        public int IdPerson { get; set; } = person.IdPerson;
        public string NamePerson { get; set; } = person.NamePerson;
        public string NickName { get; set; } = person.NickName;
        public string EmailPerson { get; set; } = person.EmailPerson;
        public string PasswordPerson { get; set; } = person.PasswordPerson;
        public string PhoneNumberPerson { get; set; } = person.PhoneNumberPerson;
        public PersonTypeEnum TypePerson { get; set; } = person.TypePerson;
        public DateTime BirthdayDate { get; set; } = person.BirthdayDate;
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Active { get; set; }
        public string ProfilePic { get; set; } = person.ProfilePic;
    }
}
