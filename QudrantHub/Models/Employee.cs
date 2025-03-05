using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace QudrantHub.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [EmailAddress]
        public string? AnotherEmail { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public byte[] NationalCardFile { get; set; }
        public string Statement { get; set; }
        public string SocialSolidarity { get; set; }
    }
}
