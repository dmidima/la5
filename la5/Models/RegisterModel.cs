using System.ComponentModel.DataAnnotations;

namespace la5.Models;

public class RegisterModel
{
    [Required(ErrorMessage = "Поле 'Имя' обязательно для заполнения.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Поле 'Фамилия' обязательно для заполнения.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Поле 'Email' обязательно для заполнения.")]
    [EmailAddress(ErrorMessage = "Введите корректный адрес электронной почты.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Поле 'Пароль' обязательно для заполнения.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Пароли не совпадают.")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
}