using QudrantHub.Models;
using System.ComponentModel.DataAnnotations;

namespace QudrantHub.Data.DTOs
{
    public class EmployeeDTO
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string? AnotherEmail { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
        public string Password { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string NationalCardFile { get; set; }
        public string Statement { get; set; }
        public string SocialSolidarity { get; set; }
    }
    public class ShowEmployeeWithIdDTO
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
        public int Age { get; set; }
        public string Gender { get; set; }

        public string NationalCardFile { get; set; }
        public string Statement { get; set; }
        public string SocialSolidarity { get; set; }
    }
    public class AddEmployeeCompanyDTO
    {
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
        public int Age { get; set; }
        public string Gender { get; set; }

        public string NationalCardFile { get; set; }
        public string Statement { get; set; }
        public string SocialSolidarity { get; set; }

        public IList<Company> Companies { get; set; }
    }
    public class ShowEmployeeCompanyDTO
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
        public int Age { get; set; }
        public string Gender { get; set; }

        public string NationalCardFile { get; set; }
        public string Statement { get; set; }
        public string SocialSolidarity { get; set; }

        public IList<Company> Companies { get; set; }
    }
}
