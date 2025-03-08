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
        [MinLength(6, ErrorMessage = "Password length must be at least 6 characters")]
        public string Password { get; set; }
        public string TaxRecodrd { get; set; }

        [Required]
        [StringLength(100)]
        public string AdminName { get; set; }
        [Required]
        [EmailAddress]
        public string AdminEmail { get; set; }
        [Required]
        public string AdminPhone { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Admin Password length must be at least 6 characters")]
        public string AdminPassword { get; set; }

        [Required]
        [StringLength(100)]
        public string DirectorName { get; set; }
        [Required]
        [EmailAddress]
        public string DirectorEmail { get; set; }
        [Required]
        public string DirectorPhone { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Password length must be at least 6 characters")]
        public string DirectorPassword { get; set; }

        public IList<Employee> Employees { get; set; }
    }
}
