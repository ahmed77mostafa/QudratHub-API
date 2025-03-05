using System.ComponentModel.DataAnnotations;

namespace QudrantHub.Models
{
    public class Deputy
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string DirectorName { get; set; }
        [Required]
        [EmailAddress]
        public string DirectorEmail { get; set; }
        [Required]
        public string DirectorPhone { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
        public string DirectorPassword {  get; set; }
    }
}
