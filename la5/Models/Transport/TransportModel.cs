using System.ComponentModel.DataAnnotations;

namespace tr.Models.Transport
{
    public class TransportModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Бренд обязательно")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Страна обязательна")]
        public string Country { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Дата выпуска обязательна")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Цена обязателена")]
        public int Price { get; set; }
    }
}
