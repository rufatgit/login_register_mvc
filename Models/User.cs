using System.ComponentModel.DataAnnotations;

namespace mvcapp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(100)]
        public string  Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }










    }
}
