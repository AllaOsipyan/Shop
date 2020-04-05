using System.ComponentModel.DataAnnotations;

namespace WebApplication.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указано имя пользователя")]
        public string userName { get; set; }
        
         
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        
       
    }
}