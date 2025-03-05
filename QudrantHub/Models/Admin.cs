using System.ComponentModel.DataAnnotations;

namespace QudrantHub.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password length must be least 8 characters")]
        public string Password { get; set; }
    }
}
