using BackEnd.Aritmica.Features.Person.Enums;

namespace BackEnd.Aritmica.Features.Person.ViewModels
{
    public class PersonViewModel
    {
        public int IdPerson { get; set; }
        public string NamePerson { get; set; }
        public string NickName { get; set; }
        public string EmailPerson { get; set; }
        public string PasswordPerson { get; set; }
        public string PhoneNumberPerson { get; set; }
        public PersonTypeEnum TypePerson { get; set; }
        public DateTime BirthdayDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Active { get; set; }
        public string ProfilePic { get; set; }
    }
}
