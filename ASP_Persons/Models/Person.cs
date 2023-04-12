using System.ComponentModel.DataAnnotations;

namespace ASP_Persons.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Не ввели Имя"), MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Не ввели Фамилия"), MaxLength(50), MinLength(2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Не ввели возраст"), MaxLength(3), MinLength(1)]
        public int Age { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public DateTime DateAddition { get; set;}
    }
}
