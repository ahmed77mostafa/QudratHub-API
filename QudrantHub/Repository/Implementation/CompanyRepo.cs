using QudrantHub.Data;
using QudrantHub.Data.DTOs;
using QudrantHub.Models;
using QudrantHub.Repository.Interface;
using System.Numerics;

namespace QudrantHub.Repository.Implementation
{
    public class CompanyRepo : ICompanyRepo
    {
        private readonly AppDbContext _context;

        public CompanyRepo(AppDbContext context)
        {
            _context = context;
        }


        public bool SignUp(CompanyDTO companyDTO)
        {
            Company company = new Company
            {
                Name = companyDTO.Name,
                Email = companyDTO.Email,
                Phone = companyDTO.Phone,
                Password = companyDTO.Password,
                TaxRecodrd = companyDTO.TaxRecodrd,
                AdminName = companyDTO.AdminName,
                AdminEmail = companyDTO.AdminEmail,
                AdminPhone = companyDTO.AdminPhone,
                AdminPassword = companyDTO.AdminPassword,
                DirectorName = companyDTO.DirectorName,
                DirectorEmail = companyDTO.DirectorEmail,
                DirectorPhone = companyDTO.DirectorPhone,
                DirectorPassword = companyDTO.DirectorPassword,
            };
            _context.SaveChanges();
            _context.Companies.Add(company);
            return true;
        }
        public bool Login(string CompanyEmail, string CompanyPassword)
        {
            var company = _context.Companies.FirstOrDefault(x => x.Email == CompanyEmail);
            if (company == null) return false;
            return company.Password == CompanyPassword;
        }

        public bool ForgetPassowrd(string CompanyEmail, string CompanyPassword)
        {
            var company = _context.Companies.FirstOrDefault(x => x.Email == CompanyEmail);
            if (company == null) return false;
            company.Password = CompanyPassword;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteAll()
        {
            if (_context.Companies.Any())
            {
                _context.Companies.RemoveRange(_context.Companies);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteById(int Id)
        {
            var company = _context.Companies.FirstOrDefault(x => x.Id == Id);
            if (company == null) return false;
            _context.Companies.Remove(company);
            _context.SaveChanges();
            return true;
        }

        public IList<ShowCompanyWithIdDTO> GetAll()
        {
            if (_context.Companies.Any())
            {
                return _context.Companies.Select(company => new ShowCompanyWithIdDTO
                {
                    Id = company.Id,
                    Name = company.Name,
                    Email = company.Email,
                    Phone = company.Phone,
                    Password = company.Password,
                    TaxRecodrd = company.TaxRecodrd,
                    AdminName = company.AdminName,
                    AdminEmail = company.AdminEmail,
                    AdminPhone = company.AdminPhone,
                    AdminPassword = company.AdminPassword,
                    DirectorName = company.DirectorName,
                    DirectorEmail = company.DirectorEmail,
                    DirectorPhone = company.DirectorPhone,
                    DirectorPassword = company.DirectorPassword,
                }).ToList();
            }
            return null;
        }

        public ShowCompanyWithIdDTO GetById(int Id)
        {
            var company = _context.Companies.FirstOrDefault(x => x.Id == Id);
            if (company == null) return null;
            return new ShowCompanyWithIdDTO
            {
                Id = company.Id,
                Name = company.Name,
                Email = company.Email,
                Phone = company.Phone,
                Password = company.Password,
                TaxRecodrd = company.TaxRecodrd,
                AdminName = company.AdminName,
                AdminEmail = company.AdminEmail,
                AdminPhone = company.AdminPhone,
                AdminPassword = company.AdminPassword,
                DirectorName = company.DirectorName,
                DirectorEmail = company.DirectorEmail,
                DirectorPhone = company.DirectorPhone,
                DirectorPassword = company.DirectorPassword,
            };
        }

        public bool Update(int Id, CompanyDTO companyDTO)
        {
            var company = _context.Companies.FirstOrDefault(x => x.Id == Id);
            if (company == null) return false;

            company.Name = companyDTO.Name;
            company.Email = companyDTO.Email;
            company.Phone = companyDTO.Phone;
            company.Password = companyDTO.Password;
            company.TaxRecodrd = companyDTO.TaxRecodrd;
            company.AdminName = companyDTO.AdminName;
            company.AdminEmail = companyDTO.AdminEmail;
            company.AdminPhone = companyDTO.AdminPhone;
            company.AdminPassword = companyDTO.AdminPassword;
            company.DirectorName = companyDTO.DirectorName;
            company.DirectorEmail = companyDTO.DirectorEmail;
            company.DirectorPhone = companyDTO.DirectorPhone;
            company.DirectorPassword = companyDTO.DirectorPassword;

            _context.SaveChanges();
            return true;
        }
    }
}
