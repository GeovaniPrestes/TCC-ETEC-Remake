using System.ComponentModel.DataAnnotations;

namespace BackEnd.Aritmica.Data.Entities
{
    public class Student : Person
    {
        public int LastClassViewed { get; set; }
    }
}
