using System.ComponentModel.DataAnnotations;

namespace mvcapp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email should be entered")]
        [MaxLength(100, ErrorMessage = "Email can be max 100 symbols")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password should be entered")]
        [MaxLength(100, ErrorMessage = "Password can be max 100 symbols")]
        [MinLength(5, ErrorMessage = "Password can be min 5 symbols")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }



    }
}
