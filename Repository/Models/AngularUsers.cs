using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class AngularUsers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
