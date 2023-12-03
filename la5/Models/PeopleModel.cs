using System.ComponentModel.DataAnnotations;

namespace la5.Models
{
    public class PeopleModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле 'Имя' обязательно для заполнения")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле 'Возраст' обязательно для заполнения")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Поле 'Адрес' обязательно для заполнения")]
        public string Address { get; set; }
    }
}