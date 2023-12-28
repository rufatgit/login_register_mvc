using System.ComponentModel.DataAnnotations;

namespace mvcapp.Models
{
    public class Profile
    {
        public int Id { get; set; }


        public string ProfilePhoto { get; set; }

        [MaxLength(100)]

        public string Bio { get; set; }






    }
}
