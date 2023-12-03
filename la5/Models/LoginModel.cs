using System.ComponentModel.DataAnnotations;

namespace la5.Models;

public class LoginModel
{
    [Required(ErrorMessage = "Поле 'Email' обязательно для заполнения.")]
    [EmailAddress(ErrorMessage = "Введите корректный адрес электронной почты.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Поле 'Пароль' обязательно для заполнения.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}