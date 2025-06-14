using System.ComponentModel.DataAnnotations;

namespace Services.DTOs
{
    public class AngularUsersDTO
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        public string Password { get; set; }
    }
}
