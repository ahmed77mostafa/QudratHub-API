using System.ComponentModel.DataAnnotations;

namespace QudrantHub.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
