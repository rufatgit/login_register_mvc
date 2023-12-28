using System.ComponentModel.DataAnnotations;

namespace mvcapp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(5, ErrorMessage = "PasswordMin 5 chars")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Min 5 chars")]
        [Compare("Password", ErrorMessage = "Password and Password confirmation should be same")]
        public string PasswordConfirm { get; set; }





    }
}
