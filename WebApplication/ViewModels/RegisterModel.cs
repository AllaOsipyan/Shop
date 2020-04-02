using System.ComponentModel.DataAnnotations;

namespace WebApplication.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указано имя пользователя")]
        [StringLength(50, MinimumLength=8, ErrorMessage = "Имя пользователя должно содежрать не менее 5 и не более 50 символов")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        [EmailAddress(ErrorMessage = "Не правильно указан Email")]
        public string email { get; set; }

          
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength=8, ErrorMessage = "Пароль должен содрежать не менее 5 и не более 50 символов")]
        public string password { get; set; }

        [Required(ErrorMessage = "Повторите пароль")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Пароли не совпадают")]
        public string checkPassword { get; set; }

    }
}