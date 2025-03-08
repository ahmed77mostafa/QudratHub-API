using QudrantHub.Models;
using System.ComponentModel.DataAnnotations;

namespace QudrantHub.Data.DTOs
{
    public class CompanyDTO
    {
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
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
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
        [MinLength(8, ErrorMessage = "Admin Password length must be at least 8 characters")]
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
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
        public string DirectorPassword { get; set; }
    }
    public class ShowCompanyWithIdDTO
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
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
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
        [MinLength(8, ErrorMessage = "Admin Password length must be at least 8 characters")]
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
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
        public string DirectorPassword { get; set; }
    }
    public class AddCompanyEmployeeDTO
    {
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
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
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
        [MinLength(8, ErrorMessage = "Admin Password length must be at least 8 characters")]
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
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
        public string DirectorPassword { get; set; }
        public IList<Employee> Employees { get; set; }
    }
    public class GetCompanyEmployeeDTO
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
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
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
        [MinLength(8, ErrorMessage = "Admin Password length must be at least 8 characters")]
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
        [MinLength(8, ErrorMessage = "Password length must be at least 8 characters")]
        public string DirectorPassword { get; set; }
        public IList<Employee> Employees { get; set; }

    }
}
